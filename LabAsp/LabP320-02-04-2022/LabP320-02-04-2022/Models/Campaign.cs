using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.Models
{
    public class Campaign
    {
        public int Id { get; set; }

        public int Discount { get; set; }

        public List<Flower> Flowers { get; set; }
    }
}
