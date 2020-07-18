using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("task_statuses")]
    public class TaskStatus
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }
}