#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ClassBookingRoom_API/ClassBookingRoom_API.csproj", "ClassBookingRoom_API/"]
COPY ["ClassBookingRoom_Service/ClassBookingRoom_Service.csproj", "ClassBookingRoom_Service/"]
COPY ["ClassBookingRoom_Repository/ClassBookingRoom_Repository.csproj", "ClassBookingRoom_Repository/"]
COPY ["ClassBookingRoom_BusinessObject/ClassBookingRoom_BusinessObject.csproj", "ClassBookingRoom_BusinessObject/"]
RUN dotnet restore "./ClassBookingRoom_API/ClassBookingRoom_API.csproj"
COPY . .
WORKDIR "/src/ClassBookingRoom_API"
RUN dotnet build "./ClassBookingRoom_API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ClassBookingRoom_API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClassBookingRoom_API.dll"]