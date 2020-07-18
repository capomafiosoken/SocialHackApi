using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("place_category")]
    public class PlaceCategory
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("points")]
        public int Points { get; set; }
    }
}