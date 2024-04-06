using Library.Data.Models;

namespace Library.Models.BookViewModels
{
    public class QuizViewModel
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
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "2.What was Jemima wearing when she went outside the farm?",
                Options = new List<string>()
                {
                    "A bikini and suncream",
                    "An evening dress and a tiara",
                    "Cut-off jeans and a sweatshirt",
                    "A shawl and a poke bonnet"
                },
                Answer = "A shawl and a poke bonnet"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "3.How was Jemima able to get into the air to start flying?",
                Options = new List<string>()
                {
                    "The other ducks pushed her off a cliff",
                    "She ran downhill then jumped upwards",
                    "She jumped from a haystack",
                    "A milkmaid tossed her up high"
                },
                Answer = "She ran downhill then jumped upwards"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "4.What impression did the gentleman make on Jemima?",
                Options = new List<string>()
                {
                    "She was scared by his whiskers",
                    "She thought he was very civil and good-looking",
                    "She felt he was dangerous",
                    "She admired his smart clothes"
                },
                Answer = "She thought he was very civil and good-looking"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "5.How was the gentleman able to help Jemima?",
                Options = new List<string>()
                {
                    "By showing her the way to the hospital",
                    "By lending her some money to buy food",
                    "By helping her to cross a busy road",
                    "By offering her his woodshed to lay her eggs in"
                },
                Answer = "By offering her his woodshed to lay her eggs in"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "6.Which materials was the gentleman's house made of?",
                Options = new List<string>()
                {
                    "Straw and moss",
                    "Faggots (bundles of sticks) and turf",
                    "Palm leaves",
                    "Concrete blocks"
                },
                Answer = "Faggots (bundles of sticks) and turf"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "7.How many eggs did Jemima lay in the shed?",
                Options = new List<string>()
                {
                    "Two",
                    "Nine",
                    "Five",
                    "Twenty"
                },
                Answer = "Nine"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "8.Whereabouts on the farm did Jemima confide in the collie-dog, Kep?",
                Options = new List<string>()
                {
                    "In the farmhouse kitchen",
                    "In a sheepfold",
                    "By the pigsty",
                    "Near the old willow tree"
                },
                Answer = "In the farmhouse kitchen"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "9.What happened when Jemima went into the woodshed to start sitting on her eggs?",
                Options = new List<string>()
                {
                    "She found another bird was in there",
                    "The eggshells had turned purple",
                    "The eggs had already started hatching",
                    "Someone with a black nose locked her in"
                },
                Answer = "Someone with a black nose locked her in"
            },
            new Question()
            {
                Id=Guid.NewGuid(),
                QuestionTitle = "10.When did Jemima lay eggs at the farm again?",
                Options = new List<string>()
                {
                    "In June",
                    "Three years later",
                    "Never",
                    "The next spring"
                },
                Answer = "In June"
            }
        };
    }
}
