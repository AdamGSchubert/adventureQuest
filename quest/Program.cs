using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge
            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 20
            );
            Challenge starWars = new Challenge(@"is darth vader good? 
             1)yes
             2)no",
              2, 10 );

            Challenge zelda = new Challenge(@"who do you play as in the game Zelda?
            1) Zelda
            2) Mario
            3) Link
            ", 3,5);

            // "Awesomeness" is like our Adventurer's current "score"
            // A higher Awesomeness is better

            // Here we set some reasonable min and max values.
            //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
            //  If an Adventurer has an Awesomeness less than the min, they are terrible
            int minAwesomeness = 0;
            int maxAwesomeness = 100;

            Robe xyz = new Robe(){
                Colors= new List<string>(){
                    "red",
                    "blue",
                    "green",
                },
                Length= 960
            };

            Hat ballcap = new Hat(){
                ShininessLevel = 1
            };
            
            Console.WriteLine("What is your name Adventurer?");

            string adventureName = Console.ReadLine();

            // Make a new "Adventurer" object using the "Adventurer" class
            Adventurer theAdventurer = new Adventurer(adventureName,xyz,ballcap);
            Console.WriteLine(theAdventurer.getDescription());
            runGauntlet(theAdventurer);
            
            // A list of challenges for the Adventurer to complete
            // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
            // void runGauntlet(){
            void runGauntlet(Adventurer greg){
            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle,
                starWars,
                zelda
            }; 

            

            // select 5 challenges at random
            List<Challenge> randomChallenge= new List<Challenge>();
            for (int i =0; i<5; i++){
                Random selectChallenge = new Random();
                int index = selectChallenge.Next(0,6);
                randomChallenge.Add(challenges[index]);
            } 

            // Loop through all the challenges and subject the Adventurer to them
            foreach (Challenge challenge in randomChallenge)
            {
                challenge.RunChallenge(theAdventurer);
            }

            // This code examines how Awesome the Adventurer is after completing the challenges
            // And praises or humiliates them accordingly
            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            }
            // }
            Prize thePrize= new Prize("this is gold");

            thePrize.showPrize(theAdventurer);
            
        //    thePrize._text;
            // Console.WriteLine(theAdventurer.correctAnswers);
            Console.WriteLine(@"do you want to play again?
             1) yes
             2) no");
            string playAgain = Console.ReadLine();
            int play= int.Parse(playAgain);
            switch(play)
            {
                case 1:
                    int addAwesome = theAdventurer.correctAnswers * 10;
                    theAdventurer.Awesomeness = 50 + addAwesome;
                    theAdventurer.correctAnswers=0;
                    runGauntlet(theAdventurer);
                    break;
                case 2:
                    return;
            }
           }//run gauntlet end
            
        
            
            

            
        }
            
            




        
        
        
        
    }
}