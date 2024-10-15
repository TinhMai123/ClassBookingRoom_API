using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class RoomTypeRepo : BaseRepository<RoomType>, IRoomTypeRepo
    {
        public RoomTypeRepo(AppDbContext context) : base(context)
        {
            
        }

/*        public async Task AddRoomTypeWithCohort(RoomTypeCohortRequestModel model)
        {
            var 
            var cohort = await _context.Cohorts.FindAsync(model.CohortId);
            if (cohort == null)
            {
                throw new Exception("Cohort not found");
            }

            cohort.RoomTypes ??= new List<RoomType>();
            cohort.RoomTypes.Add(newType);

            // Optional: Add the cohort to the RoomType's AllowedCohorts if needed
            newType.AllowedCohorts.Add(cohort);

            // Step 4: Save changes to the database
            _context.RoomTypes.Add(newType); // Add new RoomType to DbSet if required
            await _context.SaveChangesAsync();
        }*/

        public Task<RoomType> GetRoomTypeByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<RoomType> GetRoomTypeByIdWithAttribute(int id) {
            return await _context.RoomsTypes.
                Include(c => c.AllowedCohorts).
                Include(c => c.Activities).
                FirstOrDefaultAsync(c => c.Id == id);
        }

    }
}
