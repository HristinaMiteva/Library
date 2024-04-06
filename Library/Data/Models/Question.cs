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
        //public string UserAnswer { get; set; } = string.Empty;

        //[ForeignKey(nameof(Book))]
        //public Guid? BookId { get; set; }
        //public Book? Book { get; set; }

    }
}
