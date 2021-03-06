using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_system
{
    internal class Person_Details
    {
        public string first_Name { get; set; }
        public string last_Name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string phone_Number { get; set; }
        public string email { get; set; }

        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Person_Details))
            {
                return false;
            }
            return this.first_Name == ((Person_Details)obj).first_Name;
        }
    }
}
