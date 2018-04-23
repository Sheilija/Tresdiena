using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    class Game
    {
        //lai spēle veiksmīgi noritētu uz priekšu,klasēm jābūt PUBLISKĀM!
        public Dealer Dealer;
        public Player Player;
        public Deck Deck;


        public bool StartNewGame()

        //šī klase atbild par spēles loģiku - par to, kā notiek spēle
        {
            bool startNew = Game.GetAnswer("Vai uzsākt jaunu spēli");
           /* Console.Write("Vai uzsākt jaunu spēli (jā/nē)? ");
            //nolasām atbildi, ar mazajiem burtiem - tolower
            string atbilde = Console.ReadLine().ToLower();
            //tagad definēsim bool vērtību, izvido jaunu  mainīgo - start  new, ja viņš ir jā, tad vērtība ir true
            //tad tiek uzsākta jauna spēle
            bool startNew = atbilde == "ja";
            */

            if (startNew)
            {
                Console.WriteLine("Uzsākta jauna spēle!");
                //KATRU REIZI, kad tiek uzsākta jauna spēle, tie izveidotas jaunas vienibas
                Deck = new Deck();
                Dealer = new Dealer();
                Player = new Player();
            }
            return startNew;
        }
        public static bool GetAnswer(string question)
        {
            Console.Write(question + "(ja/ne)?");
            string atbilde = Console.ReadLine().ToLower();
           
            bool answer = atbilde == "ja";
            return answer;
        }
    }
}
