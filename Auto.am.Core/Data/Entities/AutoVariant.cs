using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAm
{
    public class AutoVariant
    {
        public int Id { get; set; }
        public int Run { get; set; }
        public string Body { get; set; }
        public string Engine { get; set; }
        public string Gearbox { get; set; }
        public string Color { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool IsSteeringLeft { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Auto")]
        public int AutoId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public Auto Auto { get; set; }
    }
}
