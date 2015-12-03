namespace HackBulgaria_Fall_2015
{
    class WordGame
    {
        static int counter = 0;

        public static int CountWord(char [,] matrix, string word)
        {   
            if (word == "")
            {
                System.Console.WriteLine("ERROR: Cannot search for the empty word");
                counter = -1;
            }

            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        DigHorizontally(i, j, matrix, word, 1);
                        DigHorizontally(i, j, matrix, word, -1);
                        DigVertically(i, j, matrix, word, 1);
                        DigVertically(i, j, matrix, word, -1);
                        DigMainDiagonals(i, j, matrix, word, 1);
                        DigMainDiagonals(i, j, matrix, word, -1);
                        DigSecondDiagonals(i, j, matrix, word, 1);
                        DigSecondDiagonals(i, j, matrix, word, -1);
                    }
                }
            }

            return counter;
        }
        
        static void DigHorizontally(int row, int col, char[,] matrix, string word, int direction)
        {
            bool isFound = true;
            for (int i = 0; i < word.Length; i++)
            {
                try
                {
                    if (word[i] != matrix[row, col + direction * i])
                    {
                        isFound = false;
                        break;
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    isFound = false;
                }
            }

            if (isFound)
            {
                counter++;
            }
        }

        static void DigVertically(int row, int col, char[,] matrix, string word, int direction)
        {
            bool isFound = true;
            for (int i = 0; i < word.Length; i++)
            {
                try
                {
                    if (word[i] != matrix[row + direction * i, col])
                    {
                        isFound = false;
                        break;
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    isFound = false;
                }
            }

            if (isFound)
            {
                counter++;
            }
        }

        static void DigMainDiagonals(int row, int col, char[,] matrix, string word, int direction)
        {
            bool isFound = true;
            for (int i = 0; i < word.Length; i++)
            {
                try
                {
                    if (word[i] != matrix[row + direction * i, col + direction * i])
                    {
                        isFound = false;
                        break;
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    isFound = false;

                }
            }

            if (isFound)
            {
                counter++;
            }
        }

        static void DigSecondDiagonals(int row, int col, char[,] matrix, string word, int direction)
        {
            bool isFound = true;

            for (int i = 0; i < word.Length; i++)
            {
                try
                {
                    if (word[i] != matrix[row - direction * i, col + direction * i])
                    {
                        isFound = false;
                        break;
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    isFound = false;
                }
            }

            if (isFound)
            {
                counter++;
            }
        }

        static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            System.Array.Reverse(charArray);
            return new string(charArray);
        }

        static bool IsPalindrome(string searchedWord)
        {
            return searchedWord.Equals(Reverse(searchedWord));
        }

        public static void Main(string[] args)
        {
            char[,] table = { 
                { 'i', 'v', 'a', 'n'},
                { 'e', 'v', 'n', 'h'},
                { 'i', 'n', 'a', 'v'},
                { 'n', 'v', 'v', 'n'},
                { 'r', 'r', 'i', 't'}
            };

            string searchedWord = "ivan";
            int result = CountWord(table, searchedWord);
            
            if (IsPalindrome(searchedWord))
            {
                if (searchedWord != "")
                {
                    result /= 2;
                }
            }
        
            System.Console.WriteLine(result);
        }
    }
}

