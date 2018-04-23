using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    class Card
    {
        //string , jo vertība var būt arī tekstuāla, piemēram, karalis, dāma utt
        public string Value;
        /// <summary>
        /// masts
        /// </summary>
        public char Suit;
        /// <summary>
        /// izveido jaunu kārti
        /// </summary>
        /// <param name="value">Vērtība.</param>
        /// <param name="value">Masts.</param>
        public Card(string value, char suit)
            {
            this.Value = value;
            this.Suit = suit;
            }
        public int GetValue()
        {
            return 0;

        }

    }
}
