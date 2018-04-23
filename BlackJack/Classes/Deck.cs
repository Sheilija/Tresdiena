using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    class Deck
    {
        //norādīsim, kādas iespējamas vērtības
        //mums būs saraksts ar visiem iespejamiem mastiem - tie ir četri

        public char[] Suits = { 'H', 'D', 'S', 'C' };

        //OTRS MASĪVS IR PRIEKŠ VĒRTĪBĀM - noteiktas 13 vērtības
        public string[] Values =
        {
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        /// <summary>
        /// Kārtis
        /// </summary>
        public List<Card> Cards;
        public Deck()
        {
            Cards = new List<Card>();


            //sarakstu varam aizpidīt ar visām kārtīm, lidz ar to veidojam ciklu, kurš iet cauri visiem mastiem
            foreach (char s in Suits)
            {
                //šajā ciklā uzreiz otrs cikls, kurš apstrādā vērtības
                foreach (string v in Values)
                {//pievienojam jaunu kārti ar vērtību no masta un cikla
                    Cards.Add(new Card(v, s));

                }
            }
        }
        //mums nepieciešams izveidot jaunu kārti
        public Card TakeCard()
        {
            //definējam, ka jaunā kārts ir 

            Card newCard = Cards[0];
            //izņemt no saraksta
            Cards.RemoveAt(0);
            //atgriežam to  kārti, ko mēs paņēmām
            return newCard;
        }
        /// <summary>
        /// Izveido jaunu kāršu kavu
        /// </summary>
        /// <returns></returns>
        public Deck TakeNewDeck()
        {

            return null;
        }
        /// <summary>
        /// Sajauc kāršu kavu
        /// </summary>

        public void Shuffle()
        {

        }
        
    }
}
