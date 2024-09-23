﻿using ClassBookingRoom_BusinessObject.Models;
using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class ActivityRepo : BaseRepository<Activity>, IActivityRepo
    {
        public ActivityRepo(AppDbContext context) : base(context)
        {
        }
    }
}