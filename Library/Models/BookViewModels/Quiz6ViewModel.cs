using Library.Data.Models;

namespace Library.Models.BookViewModels
{
    public class Quiz6ViewModel
    {
        public List<Question> Questions { get; set; } = new List<Question>()
        {
            /* new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "1. What city does Peter Pan take place in?",
                 Options = new List<string>()
                 {
                     "India",
                     "England",
                     "China",
                     "France"
                 },
                 Answer = "London"
             },*/
        };
    }
}
