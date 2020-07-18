using System.ComponentModel.DataAnnotations.Schema;

namespace SocialHackApi.Models
{
    [Table("city_objects")]
    public class CityObject
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("district_id")]
        public long DistrictId { get; set; }
        [Column("object_category_id")]
        public long ObjectCategoryId { get; set; }
        [Column("coordinates")]
        public double[] Coordinates { get; set; }
        [Column("attendance_count")]
        public long AttendanceCount { get; set; }
        [Column("sum")]
        public double Sum { get; set; }
    }
}