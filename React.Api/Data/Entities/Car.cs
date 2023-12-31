﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React.Api.Data.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public decimal? Weight { get; set; }
        public string ? Brand { get; set; }
        public string? FuelType { get; set; }
        public string? ImageUrl { get; set; }
    }
}
