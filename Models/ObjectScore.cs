using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("object_scores")]
    public class ObjectScore
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("score")]
        public int Score { get; set; }
        [Column("disability_type_id")]
        public long DisabilityTypeId { get; set; }
        [Column("city_object_id")]
        public long CityObjectId { get; set; }
        [Column("user_id")]
        public long UserId { get; set; }
    }
}