using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCartGame
{
    public class Player
    {
        public List<Card> Import { get; set; }
        public List<Card> Export { get; set; }

        public Player()
        {
            Import = new List<Card>();
            Export = new List<Card>();
        }
    }
}
