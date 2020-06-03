using System;
using System.Collections.Generic;
using System.Text;

namespace Delicacies.Model
{
   public class Item
    {   public string Name { get; set; }
        public string Image { get; set; }
        public  string Description { get; set; }
        public int Price { get; set; }
    }
    public class Banner
    {
        public string Image { get; set; }

    }public class Special
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
