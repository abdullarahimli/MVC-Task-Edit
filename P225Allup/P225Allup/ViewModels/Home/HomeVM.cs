using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P225Allup.Models;

namespace P225Allup.ViewModels.Home
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Category> Categories { get; set; }

        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductTag> ProductTags { get; set; }
    }
}
