using MHKHommikuHelbed.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal class HelbedService
    {
        private static List<Helbed> helbeds = new()
        {
            new()
            {
                Name = "Nesquik",
                PFP = "nesquik.png",
                Description = "Description",
                Images = new()
                {
                    "Image1.png",
                    "Image2.png",
                    "Image3.png",
                }
            },

            new()
            {
                Name = "CiniMinis",
                PFP = "cinipng.png",
                Description = "Description",
                Images = new()
                {
                    "Image1.png",
                    "Image2.png",
                    "Image3.png",
                }
            },

            new()
            {
                Name = "CornFlakes",
                PFP = "corn.png",
                Description = "Description",
                Images = new()
                {
                    "Image1.png",
                    "Image2.png",
                    "Image3.png",
                }
            },

            new()
            {
                Name = "KitKat",
                PFP = "kit.png",
                Description = "Description",
                Images = new()
                {
                    "Image1.png",
                    "Image2.png",
                    "Image3.png",
                }
            },
        };



        public static List<Helbed> GetAllHelbed()
            => helbeds;

    }
}
