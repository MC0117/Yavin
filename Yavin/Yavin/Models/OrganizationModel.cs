using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yavin.Models
{
    class Organization
    {
        public int ID { get; set; }
        public DateTime[,] HoursOfOperation { get; set; } //will change data type later on
        public string OrganizationName { get; set; }
    }
}
