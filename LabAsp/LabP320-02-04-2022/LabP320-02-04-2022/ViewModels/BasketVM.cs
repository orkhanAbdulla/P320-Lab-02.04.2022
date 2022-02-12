using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.ViewModels
{
    public class BasketVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Count { get; set; } = 1;
    }
}
