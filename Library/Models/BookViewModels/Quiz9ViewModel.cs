using Library.Data.Models;

namespace Library.Models.BookViewModels
{
    public class Quiz9ViewModel
    {
        public List<Question> Questions { get; set; } = new List<Question>()
        {
            new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "1. What is the colour of the Once-ler's arms?",
                 Options = new List<string>()
                 {
                     "Green",
                     "Purple",
                     "Yellow",
                     "Brown"
                 },
                 Answer = "Green"
             },
              new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "2. What is the name of the boy who visits the Once-ler?",
                 Options = new List<string>()
                 {
                     "Franklin",
                     "Ralph",
                     "It is never specified in the book",
                     "Ted"
                 },
                 Answer = "It is never specified in the book"
             },
                new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "3. What does the Once-ler do with what you've paid him?",
                 Options = new List<string>()
                 {
                     "Puts it in a drawer",
                     "Hides it in his Snuvv",
                     "Throws it away",
                     "Puts it in a savings account"
                 },
                 Answer = "Hides it in his Snuvv"
             },
                  new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "4. What are the birds of the forest called?",
                 Options = new List<string>()
                 {
                     "Swannie-Swans",
                     "Swomme-Swans",
                     "Singer-Swans",
                     "Swomish-Swans"
                 },
                 Answer = "Swomme-Swans"
             },
                    new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "5. What colour was the first 'Thneed' knitted by the Once-ler?",
                 Options = new List<string>()
                 {
                     "Orange",
                     "Pink",
                     "Yellow",
                     "Red"
                 },
                 Answer = "Pink"
             },
                      new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "6. What did the Once-ler not mention the Thneed was capable of turning into?",
                 Options = new List<string>()
                 {
                     "Glove",
                     "Curtains",
                     "Hat",
                     "Skirt"
                 },
                 Answer = "Skirt"
             },
                        new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "7. What machine did the Once-ler invent which allowed him to chop four trees at a time?",
                 Options = new List<string>()
                 {
                     "The Super-Duper-Chopper",
                     "The Super-Axe-Hacker",
                     "The Tree-Killer",
                     "The Deluxe-Hacking-Machine"
                 },
                 Answer = "The Super-Axe-Hacker"
             },
                          new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "8. What transportation device did the Once-ler come into the forest with?",
                 Options = new List<string>()
                 {
                     "A bike",
                     "A car",
                     "A wagon",
                     "An airplane"
                 },
                 Answer = "A wagon"
             },
                            new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "9. After the Once-ler finished knitting his 'Thneed',\n" +
                                " he saw the Lorax come out of somewhere. What did he come out of?",
                 Options = new List<string>()
                 {
                     "A house",
                     "A hole in the ground",
                     "A car",
                     "A tree stump"
                 },
                 Answer = "A tree stump"
             },
                              new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "10. Finish this line: \"Unless someone like you cares a\n" +
                                  " whole awful lot nothing is going to get better....\"",
                 Options = new List<string>()
                 {
                     "It won't",
                     "No sir",
                     "It ain't",
                     "It's not"
                 },
                 Answer = "It's not"
             },
        };
    }
}
