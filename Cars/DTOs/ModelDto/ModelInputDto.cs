﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//User passes ths object to create a new Model object into Data Base
namespace Cars.Dtos
{
    public record ModelInputDto
    {
        [Required]
        [Range(0, 9999999)]
        public int BrandId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Generation { get; set; }
        [Required]
        [Range(1, 4)]
        public int IdFuelType { get; set; }
        [Required]
        [Range(0, 999)]
        public double Combustion { get; set; }

        public ModelInputDto(int brandId, string type, string name, string generation, int idFuelType, double combustion)
        {
            BrandId = brandId;
            Type = type;
            Name = name;
            Generation = generation;
            IdFuelType = idFuelType;
            Combustion = combustion;
        }
    }
}