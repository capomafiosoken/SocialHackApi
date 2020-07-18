using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("object_feedback")]
    public class ObjectFeedback
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("feedback")]
        public string Feedback { get; set; }
        [Column("object_id")]
        public long ObjectId { get; set; }
        [Column("user_id")]
        public long UserId { get; set; }
        [Column("place_element_id")]
        public long PlaceElementId { get; set; }
        [Column("media_path")]
        public string MediaPath { get; set; }
        [Column("feedback_type_id")]
        public long FeedbackTypeId { get; set; }
    }
}