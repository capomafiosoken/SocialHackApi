using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("district")]
    public class District
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("sum")]
        public double? Sum { get;  }
    }
}