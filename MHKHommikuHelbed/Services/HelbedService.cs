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
                Name = "Name",
                PFP = "image.png",
                Description = "Description",
                Images = new()
                {
                    "Image1.png",
                    "Image2.png",
                    "Image3.png",
                }
            }
        };

        public static List<Helbed> GetFeaturedPlanets()
        {
            var random = new Random();
            var ranomizedPlanets = helbeds.OrderBy(item => random.Next());

            return ranomizedPlanets.Take(2).ToList();
        }

        public static List<Helbed> GetAllPlanets()
            => helbeds;

    }
}
