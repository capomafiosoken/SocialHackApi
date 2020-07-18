using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("disability_types")]
    public class DisabilityType
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
    }
}