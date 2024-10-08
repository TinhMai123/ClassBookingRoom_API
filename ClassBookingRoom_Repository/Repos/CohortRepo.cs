﻿using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class CohortRepo : BaseRepository<Cohort> , ICohortRepo
    {
        public CohortRepo(AppDbContext context) : base(context)
        {
        }

        public Task<Cohort> GetCohortByCode(string code)
        {
            throw new NotImplementedException();
        }

    }
}
