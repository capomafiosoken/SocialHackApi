using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("place_element_attributes")]
    public class PlaceElementAttribute
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("element_id")]
        public long ElementId { get; set; }
        [Column("required_value")]
        public string RequiredValue { get; set; }
    }
}