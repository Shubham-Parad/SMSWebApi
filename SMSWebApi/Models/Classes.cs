using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMSWebApi.Models
{
    public class Classes
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string Section {  get; set; }
        public int TeacherId { get; set; }
        public int TimetableId { get; set; }
    }
}
