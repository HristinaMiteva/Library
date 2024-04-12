using Library.Data.Models;

namespace Library.Models.BookViewModels
{
    public class Quiz5ViewModel
    {
        public List<Question> Questions { get; set; } = new List<Question>()
        {
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "1. Who is the main character in 'The Gruffalo'?",
                 Options = new List<string>()
                 {
                     "A fox",
                     "A gruffalo",
                     "An owl",
                     "A little brown mouse"
                 },
                 Answer = "A little brown mouse"
             },
              new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "2. What is the first threatening thing the mouse meets as \n" +
                  "he takes a stroll through the deep dark wood?",
                 Options = new List<string>()
                 {
                     "The fox",
                     "A snake",
                     "The owl",
                     "A mouse trap"
                 },
                 Answer = "The fox"
             },
               new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "3. What excuse does the mouse give when he turns down the\n" +
                   " owl's invitation to tea in his treetop house?",
                 Options = new List<string>()
                 {
                     "He's got to get home in a hurry",
                     "He's allergic to owl feathers",
                     "He's already had tea",
                     "He's going to have tea with a gruffalo"
                 },
                 Answer = "He's going to have tea with a gruffalo"
             },
                new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "4. Where does the snake live?",
                 Options = new List<string>()
                 {
                     "In a cave",
                     "Under a big grey rock",
                     "In a logpile house",
                     "At the river bank"
                 },
                 Answer = "In a logpile house"
             },
                 new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "5. What colour are the gruffalo's eyes?",
                 Options = new List<string>()
                 {
                     "A nice shade of grey-green",
                     "Black",
                     "Orange",
                     "Blue"
                 },
                 Answer = "Orange"
             },
                  new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "6. What horrible things does the gruffalo have all over his back?",
                 Options = new List<string>()
                 {
                     "Poisonous warts",
                     "Green balls of fur",
                     "Purple prickles",
                     "Red spots"
                 },
                 Answer = "Purple prickles"
             },
                   new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "7. What does the gruffalo say is his favourite food?",
                 Options = new List<string>()
                 {
                     "Roasted fox",
                     "Scrambled snake",
                     "A little brown mouse",
                     "Owl ice cream"
                 },
                 Answer = "A little brown mouse"
             },
               new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "8. How does the mouse describe himself to stop the gruffalo \n" +
                   "from eating him?",
                 Options = new List<string>()
                 {
                     "Too small to make a decent meal",
                     "The scariest creature in the wood",
                     "Sorry he'd gone for a stroll in the wood",
                     "He says he's feeling a little ill"
                 },
                 Answer = "The scariest creature in the wood"
             },
                    new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "9. What does the mouse pretend is HIS favourite food?",
                 Options = new List<string>()
                 {
                     "Owl ice cream",
                     "Banoffee pie",
                     "Gruffalo crumble",
                     "Chocolate mousse"
                 },
                 Answer = "Gruffalo crumble"
             },
                     new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "10. At the end of the book, what does the mouse actually find to eat?",
                 Options = new List<string>()
                 {
                     "A piece of cheese",
                     "A nut",
                     "A wild mushroom",
                     "Nothing - he can't find any food"
                 },
                 Answer = "A nut"
             },
        };
    }
}
