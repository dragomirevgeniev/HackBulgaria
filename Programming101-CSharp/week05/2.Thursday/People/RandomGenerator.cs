using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class RandomGenerator
    {
        private static Random rand = new Random();

        public string RandomName()
        {
            string[] namePrefix =
	        {
		        "",
	            "bel",
		        "nar",
		        "xan",
		        "bell",
		        "natr",
		        "ev",
            };

            string[] nameStems =
	        {
		        "", "adur", "aes", "anim", "apoll", "imac",
		        "educ", "equis", "extr", "guius", "han",
		        "equi", "amor", "hum", "iace", "ill",
		        "inept", "iuv", "obe", "ocul", "orbis"
	        };

            string[] nameSuffix =
	        {
		        "", "us", "ix", "ox", "ith",
		        "ath", "um", "ator", "or", "axia",
		        "imus", "ais", "itur", "orex", "o",
		        "y"
	        };

            string playerName = "";
            playerName += namePrefix[(rand.Next(0, 7))];
            playerName += nameStems[(rand.Next(0, 21))];
            playerName += nameSuffix[(rand.Next(0, 16))];

            return string.Format("{0}{1}", char.ToUpper(playerName[0]), playerName.Substring(1));
        }

        public string RandomGender()
        {
            string[] genders = {"male", "female"};
            return genders[rand.Next(0, genders.Length)];
        }

        public string RandomColor()
        {
            string[] colors = { "black", "white", "red", "green", "blue", "yellow", "brown", "pink" };
            return colors[rand.Next(0, colors.Length)];
        }

        public string RandomSize()
        {
            string[] sizes = {"really small", "small", "not very large", "large"};
            return sizes[rand.Next(0, sizes.Length)];
        }
    }
}
