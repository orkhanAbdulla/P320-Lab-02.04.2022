using LabP320_02_04_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.ViewModels
{
    public class HomeVM
    {
        public List<Flower> Flowers { get; set; }

        public List<Category> Categories { get; set; }
    }
}
