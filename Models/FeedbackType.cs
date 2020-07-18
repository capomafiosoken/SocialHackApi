using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("feedback_types")]
    public class FeedbackType
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("points")]
        public int Points { get; set; }
    }
}