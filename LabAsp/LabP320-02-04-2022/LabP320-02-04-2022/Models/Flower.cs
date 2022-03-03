using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.Models
{
    public class Flower
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:50)]
        public string Name { get; set; }

        [StringLength(maximumLength: 500)]
        public string Description { get; set; }
        public double Price { get; set; }

        public int SkuCode { get; set; }

        public string Weight { get; set; }

        public string Dimension { get; set; }

        public List<FlowerImage> FlowersImages { get; set; }
        [NotMapped]
        public List<IFormFile> FormFiles { get; set; }

        public List<FlowerCategory> FlowerCategories { get; set; }

        public int? CampaignId { get; set; }

        public Campaign Campaign { get; set; }
        [NotMapped]
        public List<int> CategoryIds { get; set; }
    }
}
