﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// User/Employee passes this object to create a new Brand Object into Data Base
/// </summary>
namespace Cars.Dtos
{
    public record BrandInputDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Founder { get; set; }
        [Required]
        public string Origin { get; set; }  // country
        [Required]
        public string Headquarter { get; set; } // city
        [Required]
        public DateTime EstablishmentDate { get; set; }
        public BrandInputDto(string name, string founder, string origin, string headquarter, DateTime establishmentDate)
        {
            Name = name;
            Founder = founder;
            Origin = origin;
            Headquarter = headquarter;
            EstablishmentDate = establishmentDate;
        }
    }
}
