using Library.Data.Models;
using System.Diagnostics.Metrics;

namespace Library.Models.BookViewModels
{
    public class Quiz7ViewModel
    {
        public List<Question> Questions { get; set; } = new List<Question>()
        {
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "1. If You Give A Mouse A Cookie, what is the next thing he will want ?",
                 Options = new List<string>()
                 {
                     "A Glass of Milk",
                     "A Soda",
                     "A Napkin",
                     "A Glass of Water"
                 },
                 Answer = "A Glass of Milk"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "2. After he drinks the milk, why does the mouse want to look in a mirror ?",
                 Options = new List<string>()
                 {
                     "To see if he has a milk mustache",
                     "to see if he has crumbs on his outfit",
                     "to see if he has grown",
                     "to see if one eye is bigger than the other"
                 },
                 Answer = "To see if he has a milk mustache"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "3. What will he discover while looking in the mirror ?",
                 Options = new List<string>()
                 {
                     "That he is getting fat",
                     "That he needs another cookie",
                     "That he is too small",
                     "That he needs a trim"
                 },
                 Answer = "That he needs a trim"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "4. After he gives himself a trim, what will he do next ?",
                 Options = new List<string>()
                 {
                     "He will clean up the floor",
                     "He will bake cookies",
                     "He will take a bath",
                     "He will cut the little boy's hair"
                 },
                 Answer = "He will clean up the floor"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "5. After he cleans the floor of the whole house, he will be tired, where will he rest ?",
                 Options = new List<string>()
                 {
                     "In a box",
                     "In your sock drawer",
                     "In a treehouse",
                     "In your refrigerator"
                 },
                 Answer = "In a box"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "6. The mouse now wants to draw a picture, what will he need ?",
                 Options = new List<string>()
                 {
                     "colored pencils and an envelope",
                     "crayons and paper",
                     "watercolors and easel",
                     "chalk and sidewalk"
                 },
                 Answer = "crayons and paper"

             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "7. He will want to hang his picture on the refrigerator with what ?",
                 Options = new List<string>()
                 {
                     "Glue",
                     "Scotch Tape",
                     "Play-Doh",
                     "Staples"
                 },
                 Answer = "Scotch Tape"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "8. Before he hangs it, he will need a good pen to do what ?",
                 Options = new List<string>()
                 {
                     "Outline his drawing",
                     "draw another mouse",
                     "scribble out a tree in the picture",
                     "Sign his name"
                 },
                 Answer = "Sign his name"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "9. Looking at your refrigerator will remind him that he is what?",
                 Options = new List<string>()
                 {
                     "Ready to draw some more",
                     "Tired",
                     "Thirsty",
                     "Angry"
                 },
                 Answer = "Thirsty"
             },
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "10. And chances are if he gets a glass of milk, he will want what with it ?",
                 Options = new List<string>()
                 {
                     "Candy",
                     "A Cookie",
                     "A Brownie",
                     "A slice of cheese"
                 },
                 Answer = "A Cookie"
             },
        };
    }
}
