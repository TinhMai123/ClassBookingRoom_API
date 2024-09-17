using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.Models
{
    public class UserTeam
    {
        public int Id { get; set; }
        [Required]
        public User? User { get; set; }
        [Required]
        public Team? Team { get; set; }
        [Required]
        public bool isLeader {  get; set; }
    }
}
