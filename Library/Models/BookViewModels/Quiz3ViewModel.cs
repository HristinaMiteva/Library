using Library.Data.Models;

namespace Library.Models.BookViewModels
{
    public class Quiz3ViewModel
    {
        public List<Question> Questions { get; set; } = new List<Question>()
        {
            new Question()
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
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "2. Where does most of the story take place?",
                Options = new List<string>()
                {
                    "He chose it because they believed in him",
                    "He chose it randomly",
                    "He chose it because it looked magical",
                    "He chose it because it seemed like a nice neighborhood"
                },
                Answer = "He chose it because they believed in him"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "3. Why did George move Wendy out of the nursery?",
                Options = new List<string>()
                {
                    "She was fighting with her brothers",
                    "She couldn't sleep in the nursery",
                    "He decided that it was time she grew up",
                    "She would sleepwalk through the room"
                },
                Answer = "He decided that it was time she grew up"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "4. Where did George put Nana after he got frustrated with her?",
                Options = new List<string>()
                {
                    "Outside",
                    "He sent her to the pound",
                    "In the nursery",
                    "In the basement"
                },
                Answer = "Outside"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "5. What did Wendy find that belongs to Peter Pan?",
                Options = new List<string>()
                {
                    "His hat",
                    "His shadow",
                    "His pen",
                    "His shoe"
                },
                Answer = "His shadow"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "6. Where did Peter Pan find his shadow?",
                Options = new List<string>()
                {
                    "In a drawer",
                    "Under the bed",
                    "In the kitchen",
                    "In Neverland"
                },
                Answer = "In a drawer"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "7. Why did Peter Pan come to the window of the nursery at night?",
                Options = new List<string>()
                {
                    "To give the children gifts",
                    "To pet Nana",
                    "To bring souvenirs from Neverland",
                    "To hear Wendy's stories"
                },
                Answer = "To hear Wendy's stories"
            },
                new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "8. What did Tinker Bell do to Wendy when she went to give Peter Pan a kiss?",
                Options = new List<string>()
                {
                    "She pushed her",
                    "She took Peter Pan back to Neverland",
                    "She locked herself in the drawer",
                    "She pulled her hair"
                },
                Answer = "She pulled her hair"
                },
                new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "9. What did Wendy, John and Michael have to do so that they could fly?",
                Options = new List<string>()
                {
                    "Think of a wonderful thought",
                    "Believe that they can",
                    "Imagine that they are flying",
                    "Flap their arms"
                },
                Answer = "Think of a wonderful thought"
                },
                new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "10. What animal almost ate Tinker Bell?",
                Options = new List<string>()
                {
                    "A dog",
                    "A bird",
                    "A fish",
                    "A cat"
                },
                Answer = "A fish"

            }

        };
    }
}
