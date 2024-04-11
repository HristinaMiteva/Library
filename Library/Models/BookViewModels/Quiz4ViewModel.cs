using Library.Data.Models;

namespace Library.Models.BookViewModels
{
    public class Quiz4ViewModel
    {
        public List<Question> Questions { get; set; } = new List<Question>()
        {

              new Question()
              {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "1. Who was the first person seen in the beginning of the movie?",
                 Options = new List<string>()
                 {
                     "Professor McGonagall",
                     "Professor Dumbledore",
                     "Hagrid",
                     "A cat"
                 },
                 Answer = "Professor Dumbledore"
              },
              new Question()
              {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "2. Where did the Dursleys live?",
                 Options = new List<string>()
                 {
                     "Little Whinging, Surrey",
                     "Little Singing, Surrey",
                     "Little Winding, Surrey",
                     "Little Windy, Surrey"
                 },
                 Answer = "Little Whinging, Surrey"
              },
              new Question()
              {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "3. Where did Harry sleep?",
                 Options = new List<string>()
                 {
                     "In Dudley's old bedroom",
                     "In a cupboard under the stairs",
                     "In the kitchen",
                     "In the living room"
                 },
                 Answer = "In a cupboard under the stairs"
              },
              new Question()
              {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "4. The Dursleys and Harry went to the zoo. In which part of the \n" +
                  "zoo did they see the snake?",
                 Options = new List<string>()
                 {
                     "The Animal House",
                     "The Alligator House",
                     "The Reptile House",
                     "The Iguana House"
                 },
                 Answer = "The Reptile House"
              },
              new Question()
              {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "5. In Mr. Dursley's opinion, Sunday was the best day of the week. Why?",
                 Options = new List<string>()
                 {
                     "No one visits on Sundays",
                     "No post on Sundays",
                     "Sunday is the Lord's day",
                     "None of these"
                 },
                 Answer = "No post on Sundays"
              },
              new Question()
              {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "6. Who was the first person Harry met who came from Hogwarts?",
                 Options = new List<string>()
                 {
                     "Professor Dumbledore",
                     "Hagrid",
                     "Professor McGonagall",
                     "Ron"
                 },
                 Answer = "Hagrid"
              },
              new Question()
              {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "7. What was Hagrid carrying in his hand when he broke the door open?",
                 Options = new List<string>()
                 {
                     "An umbrella",
                     "A wand",
                     "A cake",
                     "Nothing"
                 },
                 Answer = "An umbrella"
              },
              new Question()
              {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "8. What was one of the things Harry did NOT need for school?",
                 Options = new List<string>()
                 {
                     "Pewter Cauldron",
                     "Wand",
                     "Dog",
                     "Owl, cat, or toad"
                 },
                 Answer = "Dog"
              },
              new Question()
              {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "9. Harry and Hagrid went to Gringotts, the Wizard Bank,\n" +
                  " to withdraw some money for Harry. His vault number was 687.\n" +
                  " Then they went to vault 713. What was in that vault?",
                 Options = new List<string>()
                 {
                     "Nothing",
                     "The Sorcerer's Stone",
                     "A magical broom",
                     "A bird"
                 },
                 Answer = "The Sorcerer's Stone"
              },
              new Question()
              {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "10. Harry went to Ollivander to buy a wand. \n" +
                  "What was written at the top of the door before he entered?",
                 Options = new List<string>()
                 {
                     "Makers of fine wands since 382 B.C",
                     "You want wands, we've got 'em",
                     "We've made the finest wands since 302 B.C",
                     "You will not find any wand maker better than Ollivander"
                 },
                 Answer = "Makers of fine wands since 382 B.C"
              }
        };
    }
}
