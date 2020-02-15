﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taxi.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }
        [StringLength(6, MinimumLength = 6, ErrorMessage = "The {0} field must have {1} characters.")]
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "The field {0} must stars wth three three characters and three numbers.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public String Plaque { get; set; }
        public ICollection<TripEntity> Trips { get; set; }

    }
}