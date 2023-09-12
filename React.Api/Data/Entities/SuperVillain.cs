using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React.Api.Data.Entities
{
    public class SuperVillain
    {
        public int Id { get; set; }
        public string VillainName { get; set; }
        public string? Franchise { get; set; }
        public string? Powers { get; set; }
        public string ImageUrl { get; set; }
    }
}
