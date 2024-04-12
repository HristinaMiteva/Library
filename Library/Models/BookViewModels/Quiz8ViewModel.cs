using Humanizer;
using Library.Data.Models;
using NuGet.Packaging.Signing;
using System;

namespace Library.Models.BookViewModels
{
    public class Quiz8ViewModel
    {
        public List<Question> Questions { get; set; } = new List<Question>()
        {
             new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "1. Corduroy was a bear who lived in a department store. \n" +
                 "Every day he waited on the shelf for someone to buy him. \n" +
                 "He always tried to look his best. What color were his overalls?",
                 Options = new List<string>()
                 {
                     "Blue",
                     "Brown",
                     "Red",
                     "Green"
                 },
                 Answer = "Green"
             },
              new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "2. One day a little girl looks at him and wants to take him home, but her mother says no. Why?",
                 Options = new List<string>()
                 {
                     "One of the buttons on Corduroy's overalls was missing.",
                     "Corduroy looked dirty.",
                     "The little girl's mother was mean.",
                     "The little girl already had too many teddy bears."
                 },
                 Answer = "One of the buttons on Corduroy's overalls was missing."
             },
               new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "3. When Corduroy found out why the little girl didn't take him home, what did he do?",
                 Options = new List<string>()
                 {
                     "He took off his overalls and put a ribbon around his neck instead.",
                     "He went looking for his lost button.",
                     "He hid behind the other toys so no one would see him.",
                     "He cried."
                 },
                 Answer = "He went looking for his lost button."
             },
                new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "4. Corduroy's search took him on many adventures around the store. What was the first one?",
                 Options = new List<string>()
                 {
                     "He had to hide from the store security guard.",
                     "He rode in an elevator.",
                     "He rode on an escalator.",
                     "He talked to lots of other toys and stuffed animals."
                 },
                 Answer = "He rode on an escalator."
             },
                 new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "5. One of the first places Corduroy visited was the furniture department. Where did he think he was?",
                 Options = new List<string>()
                 {
                     "A magical land",
                     "A mansion",
                     "A palace",
                     "Heaven"
                 },
                 Answer = "A palace"
             },
                  new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "6. In the furniture department, Corduroy thinks he found his lost button. Where does he think he found it?",
                 Options = new List<string>()
                 {
                     "On a bed",
                     "On a pillow",
                     "On a chair",
                     "On the floor"
                 },
                 Answer = "On a bed"
             },
                   new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "7. When Corduroy thinks he's found his lost button, something happens. What?",
                 Options = new List<string>()
                 {
                     "His overalls get caught on something and rip even worse.",
                     "He falls behind some furniture and he can't get out.",
                     "He tries to pull the button and take it with him, and he knocks over a lamp.",
                     "He gets closed up inside a sofa bed."
                 },
                 Answer = "He tries to pull the button and take it with him, and he knocks over a lamp."
             },
                    new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "8. What happens next?",
                        Options = new List<string>()
                        {
                            "The security guard finds Corduroy and takes him back to the toy department.",
                            "He gets some help from a mouse who lives in the furniture department.",
                            "A lamp breaks and there are broken pieces all over the floor.",
                            "Corduroy gets scared and runs all the way back to the toy department."
                        },
                 Answer = "The security guard finds Corduroy and takes him back to the toy department."

             },
                     new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "9. The next day, back in the toy department, Corduroy has a visitor \n" +
                         "-- the little girl who had wanted to take him home the day before. \n" +
                         "What is her name?",
                 Options = new List<string>()
                 {
                     "Lisa",
                     "Cheryl",
                     "Denise",
                     "Michelle"
                 },
                 Answer = "Lisa"
             },
                      new Question()
             {
                 Id=Guid.NewGuid(),
                 QuestionTitle = "10. The little girl uses money she has saved in her piggy \n" +
                          "bank to buy Corduroy, and she takes him home. \n" +
                          "What happens to Corduroy when he gets home?",
                 Options = new List<string>()
                 {
                     "He meets all sorts of other stuffed animals.",
                     "She sews a button on for him, and shows him his very own bed.",
                     "They have a tea party.",
                     "Corduroy rides around in the little girl's wagon."
                 },
                 Answer = "She sews a button on for him, and shows him his very own bed."
             },
        };
    }
}
