using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    public class Question
    {
        [Key]
        public Guid Id { get; set; } 
        public string QuestionTitle { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; }=new List<string>();
        public string Answer { get; set; } = string.Empty;
    }
}
