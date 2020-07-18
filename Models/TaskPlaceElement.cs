using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("task_place_elements")]
    public class TaskPlaceElement
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("task_id")]
        public long TaskId { get; set; }
        [Column("place_element_id")]
        public long PlaceElementId { get; set; }
    }
}