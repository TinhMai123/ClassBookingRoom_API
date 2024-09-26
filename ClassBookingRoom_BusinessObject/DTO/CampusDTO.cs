using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_BusinessObject.DTO
{
    public class CampusDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }    
        public string? HotLine { get; set; }
    }
}
