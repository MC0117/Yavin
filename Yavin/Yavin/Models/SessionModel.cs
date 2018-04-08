using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yavin.Models
{
    class SessionModel
    {
        public int ID { get; set; }
        public Contributor[] Contributers { get; set; }
        public string Note { get; set; } //this is not the ideal data type but it was the best I could think of.
        //TO ADD:
        //Level, which indicates what requirements there is on the contributor during that session
        //Time, during what time is the session going to last




    }
}
