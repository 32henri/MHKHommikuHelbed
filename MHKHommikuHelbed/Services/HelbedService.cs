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
    }
}
