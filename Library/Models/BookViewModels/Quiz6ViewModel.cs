using Library.Data.Models;

namespace Library.Models.BookViewModels
{
    public class Quiz6ViewModel
    {
        public List<Question> Questions { get; set; } = new List<Question>()
        {
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "1. What kind of animal is going to sleep in \"Goodnight Moon\"?",
                 Options = new List<string>()
                 {
                     "bunny",
                     "puppy",
                     "kitten",
                     "lamb"
                 },
                 Answer = "bunny"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "2. What color is the room?",
                 Options = new List<string>()
                 {
                     "red",
                     "yellow",
                     "green",
                     "blue"
                 },
                 Answer = "green"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "3. Complete this line from the book: \"There is a picture of....\"",
                 Options = new List<string>()
                 {
                     "the cat and the fiddle",
                     "the cow jumping over the moon",
                     "a laughing dog",
                     "a dish running away with a spoon"
                 },
                 Answer = "the cow jumping over the moon"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "4. How many kittens were there?",
                 Options = new List<string>()
                 {
                     "3",
                     "2",
                     "4",
                     "5"
                 },
                 Answer = "2"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "5. What does the quiet old lady do?",
                 Options = new List<string>()
                 {
                     "whispers 'hush'",
                     "falls asleep",
                     "sings a lullabye",
                     "jumps up and down"
                 },
                 Answer = "whispers 'hush'"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "6. What little animal is in every picture of the room?",
                 Options = new List<string>()
                 {
                     "bird",
                     "England",
                     "flea",
                     "mouse"
                 },
                 Answer = "mouse"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "7. What comes next in this list? \"Goodnight comb, goodnight brush, goodnight nobody, goodnight....?\"",
                 Options = new List<string>()
                 {
                     "mom",
                     "mush",
                     "dad",
                     "baby"
                 },
                 Answer = "mush"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "8. The book begins at 7pm and ends at what time?",
                 Options = new List<string>()
                 {
                     "8:10pm",
                     "7:30pm",
                     "9:10pm",
                     "7:50pm"
                 },
                 Answer = "8:10pm"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "9. There is a picture in the room of a rabbit who is doing what activity?",
                 Options = new List<string>()
                 {
                     "Tobogganing",
                     "Skating",
                     "Fishing",
                     "Swimming"
                 },
                 Answer = "Fishing"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "10. The book ends with the following line, can you fill in the blank? \"Goodnight ______ everywhere.\"",
                 Options = new List<string>()
                 {
                     "noises",
                     "stars",
                     "people",
                     "mommies"
                 },
                 Answer = "noises"
             },
        };
    }
}
