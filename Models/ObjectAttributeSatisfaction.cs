using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("object_attribute_satisfaction")]
    public class ObjectAttributeSatisfaction
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("element_attribute_id")]
        public long ElementAttributeId { get; set; }
        [Column("object_id")]
        public long ObjectId { get; set; }
        [Column("is_satisfies")]
        public bool IsSatisfies { get; set; }
    }
}