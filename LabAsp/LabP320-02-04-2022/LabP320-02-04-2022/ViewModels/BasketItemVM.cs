using LabP320_02_04_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.ViewModels
{
    public class BasketItemVM
    {
        public Flower Flower { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

    }
}
