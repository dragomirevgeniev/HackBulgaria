using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAnURL
{
    public class DecodeAnURL
    {
        public static string DecodeUrl(string input)
        {
            string decoded = string.Empty;
            string function = string.Empty;

            for (int i = 0; i < input.Length - 2; i++)
            {
                if (input[i] == '%')
                {
                    function += input[i + 1].ToString() + input[i + 2].ToString();

                    switch (function)
                    {
                        case "20":
                            decoded += " ";
                            i += 3;
                            break;
                        case "3A":
                            decoded += ":";
                            i += 3;
                            break;
                        case "3D":
                            decoded += "?";
                            i += 3;
                            break;
                        case "2F":
                            decoded += "/";
                            i += 3;
                            break;
                        default:
                            break;
                    }

                    function = string.Empty;
                }

                decoded += input[i];
            }

            decoded += input[input.Length - 2].ToString() + input[input.Length - 1].ToString();

            return decoded;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an URL to be docoded: ");
            string input = Console.ReadLine();
            Console.WriteLine("Decoded: {0}", DecodeUrl(input));
        }
    }
}
