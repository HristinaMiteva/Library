using Library.Data.Models;

namespace Library.Models.BookViewModels
{
    public class Quiz2ViewModel
    {
        public List<Question> Questions { get; set; } = new List<Question>()
        {
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "1.Why did Jemima feel cross at the start of the book?",
                Options = new List<string>()
                {
                    "She was not allowed to hatch her own eggs",
                    "A cow had trodden on her feet",
                    "Another duck was in her favourite nesting site",
                    "She had overslept and missed breakfast"
                },
                Answer = "She was not allowed to hatch her own eggs",
            }
            };
    }
}
