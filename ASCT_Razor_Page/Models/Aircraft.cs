using System;
namespace ASCT_Razor_Page.Models
{
    public class Aircraft
    {
        public string Tail_Number { get; set; }

        public string LRU_Name { get; set; }

        public string LRU_Part_Number { get; set; }

        public string Software_Name { get; set; }

        public string Software_Part_Number { get; set; }

        public string EC_Number { get; set; }

        public string Pre_Post_Condition { get; set; }

        public Aircraft()
        {
        }
    }
}
