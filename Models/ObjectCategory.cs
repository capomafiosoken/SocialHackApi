using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("object_categories")]
    public class ObjectCategory
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("points")]
        public int Points { get; set; }
        public List<CityObject>  CityObjects { get; set; }
    }
}