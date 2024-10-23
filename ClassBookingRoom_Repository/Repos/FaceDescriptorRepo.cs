using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.ResponseModels.FaceDescriptor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Repository.Repos
{
    public class FaceDescriptorRepo : BaseRepository<FaceDescriptor>, IFaceDescriptorRepo
    {
        public FaceDescriptorRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<FaceDescriptor>> GetAllFaceDescriptors()
        {
            return await _context.FaceDescriptors.Include(f => f.User).ToListAsync();
        }

        public async Task<FaceDescriptor?> GetByUserId(Guid userId)
        {
            return await _context.FaceDescriptors.SingleOrDefaultAsync(x => x.UserId == userId);
        }
    }
}
