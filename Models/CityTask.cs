using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("city_task")]
    public class CityTask
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("object_id")]
        public long ObjectId { get; set; }
        [Column("status_id")]
        public long StatusId { get; set; }
        [Column("sum")]
        public double Sum { get; set; }
    }
}