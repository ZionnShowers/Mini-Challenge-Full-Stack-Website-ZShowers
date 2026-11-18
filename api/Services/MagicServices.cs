using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class MagicServices : IMagicServices
    {

        public string MagicBall()
        {
            string magicAnswer = "";
            
            int answer;
            Random rnd = new Random();
            answer = rnd.Next(1, 9);

            if (answer == 1)
            {
                magicAnswer = "Most definitely!";
            }
            else if (answer == 2)
            {
                magicAnswer = "Not likely...";
            }
            else if (answer == 3)
            {
                magicAnswer = "It's possible!";
            }
            else if (answer == 4)
            {
                magicAnswer = "Absolutely NOT!";
            }
            else if (answer == 5)
            {
                magicAnswer = "Maybe...";
            }
            else if (answer == 6)
            {
                magicAnswer = "It is decidedly so!";
            }
            else if (answer == 7)
            {
                magicAnswer = "It's best if I don't tell you...";
            }
            else
            {
                magicAnswer = "Don't count on it!";
            }
            return magicAnswer;
        }
    }
}