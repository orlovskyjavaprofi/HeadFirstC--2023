using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchGame.GameCode
{
    public class GameInitializer
    {
        public List<string> SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐙","🐙",
                "🐟","🐟",
                "🐘","🐘",
                "🐳","🐳",
                "🐪","🐪",
                "🦕","🦕",
                "🦘","🦘",
                "🐿","🐿"
            };


            return animalEmoji;
        }
    }

  
}
