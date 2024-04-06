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
                QuestionTitle = "1. Where does most of the story take place?",
                Options = new List<string>()
                {
                    "India",
                    "England",
                    "China",
                    "France"
                },
                Answer = "England",
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "2. What adjective best describes Mary Lennox, the main character, at the BEGINNING of the book?",
                Options = new List<string>()
                {
                    "Kind",
                    "Introverted",
                    "Shy",
                    "Bratty"
                },
                Answer = "Bratty",
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "3. What happens to Mary when she is in India at the beginning of the book?",
                Options = new List<string>()
                {
                    "She contracts cholera",
                    "She attempts suicide",
                    "Her father dies",
                    "She is orphaned"
                },
                Answer = "She is orphaned",
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "4. Who is Mary sent to live with after her stay in India?",
                Options = new List<string>()
                {
                    "Her uncle",
                    "Her aunt",
                    "Her grandmother",
                    "Her godparents"
                },
                Answer = "Her uncle",
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "5. When Mary arrives in England, who is the maid who becomes her friend?",
                Options = new List<string>()
                {
                    "Linda",
                    "Jane",
                    "Elizabeth",
                    "Martha"
                },
                Answer = "Martha",
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "6. Who is Mary's bombastic attendant?",
                Options = new List<string>()
                {
                    "Mrs. Medlock",
                    "Mrs. Jones",
                    "Mrs. Smith",
                    "Mrs. Dexter"
                },
                Answer = "Mrs. Medlock",
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "7. What animal has Mary's friend Dickon NOT kept as a pet?",
                Options = new List<string>()
                {
                    "A monkey",
                    "A crow",
                    "None of these",
                    "A fox"
                },
                Answer = "A monkey",
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "8. What is the name of Mary's hypochondriac cousin?",
                Options = new List<string>()
                {
                    "Colin",
                    "Roger",
                    "Richard",
                    "Nigel"
                },
                Answer = "Colin",
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "9. For how many years has no one gone into the garden?",
                Options = new List<string>()
                {
                    "10",
                    "20",
                    "5",
                    "15"
                },
                Answer = "10",
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "10. What was that screaming in the middle of the night?",
                Options = new List<string>()
                {
                    "A maid with an excruciating toothache",
                    "Colin crying out in pain",
                    "A maid with constant run-ins with mice",
                    "A ghost"
                },
                Answer = "Colin crying out in pain",
            }
            };
    }
}
