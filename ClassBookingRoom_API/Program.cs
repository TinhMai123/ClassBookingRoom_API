using System.Text;
using ClassBookingRoom_API.Helper;
using ClassBookingRoom_Repository.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ClassBookingRoom_Service.IServices;
using ClassBookingRoom_Repository.Repos;
using ClassBookingRoom_Service.Services;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_API.Controllers;
using Microsoft.AspNetCore.Authentication.Cookies;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.Extensions.Configuration;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddServicesConfiguration();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    // Add the JWT Bearer security definition to Swagger
    c.AddSecurityDefinition(
        "Bearer",
        new OpenApiSecurityScheme
        {
            Description = "Enter your token Key",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.Http,
            Scheme = "Bearer"
        }
    );

    // Make sure Swagger understands the requirement for JWT Bearer token
    c.AddSecurityRequirement(
        new OpenApiSecurityRequirement()
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    },
                    Scheme = "oauth2",
                    Name = "Bearer",
                    In = ParameterLocation.Header,
                },
                new List<string>()
            }
        }
    );
    c.SupportNonNullableReferenceTypes();
});
builder.Services.AddScoped<IRoomTypeService, RoomTypeService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IActivityService, ActivityService>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<IReportRepo, ReportRepo>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<ICohortService, CohortService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IRoomSlotService, RoomSlotService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IBookingModifyHistoryService, BookingModifyHistoryService>();
builder.Services.AddScoped<IManagementService, ManagementService>();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddSingleton<IRedisService>(provider =>

    new RedisService(builder.Configuration.GetConnectionString("RedisConnection")));

builder
    .Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
               Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)
            )
        };
    });
builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; 
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
       .AddCookie()
       .AddGoogle(options =>
       {
           options.ClientId = builder.Configuration["Google:ClientId"];
           options.ClientSecret = builder.Configuration["Google:ClientSecret"];
       });
builder.Services.AddAuthorization();
builder.Services.AddCors(options => options.AddDefaultPolicy(policyBuilder =>
        policyBuilder
        .WithOrigins("http://localhost:5173",
        "https://swd392-lilac.vercel.app",
        "https://class-booking-room.vercel.app",
        "https://class-booking-room-k3qsnjlfd-vuvuvo0303s-projects.vercel.app")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithExposedHeaders("X-Total-Count", "X-Current-Page", "X-Total-Pages")
        .AllowCredentials())
);
builder.Services.AddHttpClient<AuthController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
} else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();
