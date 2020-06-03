using System;
using System.Collections.Generic;
using System.Text;

using Delicacies.Model;
using Xamarin.Forms;

namespace Delicacies.ViewModel
{
   public  class MenuPageViewModel
    {
        public List<Banner> GetBanner { get; set; } = new List<Banner>();
        public List<Item> GetItems { get; set; } = new List<Item>();
        public List<Special> GetSpecials { get; set; } = new List<Special>();

        public MenuPageViewModel()
        {
            GetBanner = new List<Banner>
            {
                new Banner{ Image="Ramnata.jpg"},
                new Banner{Image="flan.jpg"},
                new Banner{Image="buttercream.jpg"}
            };

            GetItems = new List<Item>
            {
                new Item { Name = "Churro Chips", Image = "churrochips.jpg", Description = "You've never had chips like these", Price = 10 },
                new Item { Name = "Cheese Cake", Image = "cheeseCake.jpg", Description = "These Bars Are fun and Cripsy", Price = 15 },
                new Item { Name = "Ramnata CupCake", Image = "Ramnata.jpg", Description = "Is this a beauty or what",Price=25 },
                new Item { Name = "Churo Pie", Image = "churopie.jpg", Description = "Churo as Pie Crust?Genius",Price=30 },
                new Item { Name = "Ramnata Cake", Image = "chocolatepie.jpg", Description = "This Boozy is a crowd Pleaser",Price=20 },
                new Item{Name="Churro Biscuit",Image="biscuit.jpg",Description="Nuteella in the Middle",Price=10},
                new Item{Name="Churros",Image="churros.jpg",Description="Its all Churros in this menu",Price=5}
            };
            GetSpecials = new List<Special>
            {
                new Special{Name="TresLeches Cake",Image="leches.jpg",Price=25},
                new Special{Name="Hot Chocolate", Image="HotChocolate.jpg",Price=5 }
            };




            }

        
    }
}
