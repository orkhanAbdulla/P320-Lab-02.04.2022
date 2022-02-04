using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.Models
{
    public class FlowerImage
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public bool IsMain { get; set; }

        public int FlowerId { get; set; }

        public Flower Flowers { get; set; }
    }
}
