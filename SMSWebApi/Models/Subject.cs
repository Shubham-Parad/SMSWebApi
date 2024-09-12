using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SMSWebApi.Models
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int TeacherID { get; set; }
        public int ClassID { get; set; }
    }
}
