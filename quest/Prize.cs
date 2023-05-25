using System;
namespace Quest
{
    public class Prize
    {
        

        public Prize(string prize)
        {
            _text = prize;
        }

       public void showPrize(Adventurer quester){
        
            if(quester.Awesomeness>0){
                for (int i =0; i<quester.Awesomeness; i++){
                  Console.WriteLine(_text);
                };
            }
            else if(quester.Awesomeness<=0){
                Console.WriteLine(pity); 
            }
            
        }
        
        private string _text ="you win!"; 
        private string pity = "git gud scrub";
     
    }
    
}