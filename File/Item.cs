using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT_Project
{
    public class Item
    {
        public string name { get; set; }
        public Double len { get; set; }
        public Double time { get; set; }
        public string picture { get; set; }
        public int quanity { get; set; }
        public string filename { get; set; }
        public Item(string name, Double len, Double time, int quanity)
        {
            if (len > 2000)
            {
                len = 0;
            }
            this.len = len;
            this.name = name;
            this.time = time;
            this.quanity = quanity;
        }
        public override string ToString()
        {
            return name+"  -Group: "+ filename;
        }
        public int CompareTo(Item other)
        {
            return this.name.CompareTo(other.name);
        }
    }
}
