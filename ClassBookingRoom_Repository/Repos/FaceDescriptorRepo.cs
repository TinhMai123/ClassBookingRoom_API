using ClassBookingRoom_Repository.Data;
using ClassBookingRoom_Repository.IRepos;
using ClassBookingRoom_Repository.Models;
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
    }
}
