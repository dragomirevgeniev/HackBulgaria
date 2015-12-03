using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBombing
{
    public class BombMatrix
    {
        public static int MatrixBombing(int[,] m)
        {
            int maxDamage = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    int currDamage = 0;
                    for (int x = -1; x <= 1; x++)
                    {
                        for (int y = -1; y <= 1; y++)
                        {
                            if (i == 0 && j == 0)
                            {
                                if (x > 0 || y > 0)
                                {
                                    continue;
                                }

                                else if (m[x + i + 1, y + j + 1] > m[i, j])
                                {
                                    currDamage += m[i, j];
                                }

                                else
                                {
                                    currDamage += m[x + i + 1, y + j + 1];
                                }
                            } 

                            else if (i == 0 && j == m.GetLength(1) - 1)
                            {
                                if (x > 0 || y < 0)
                                {
                                    continue; 
                                }
                                
                                if (m[x + i + 1, y + j - 1] >= m[i, j])
                                {
                                    currDamage += m[i, j];
                                }

                                else
                                {
                                    currDamage += m[x + i + 1, y + j - 1];
                                }
                            } 

                            else if (i == 0)
                            {
                                if (x > 0)
                                {
                                    continue;
                                }

                                if (m[x + i + 1, y + j] >= m[i, j])
                                {
                                    currDamage += m[i, j];
                                }

                                else
                                {
                                    currDamage += m[x + i + 1, y + j];
                                }
                            } 

                            else if (i == m.GetLength(0) - 1 && j == 0)
                            {
                                if (x < 0 || y > 0)
                                {
                                    continue;
                                }
                                
                                if (m[x + i - 1, y + j + 1] >= m[i, j])
                                {
                                    currDamage += m[i, j];
                                }

                                else
                                {
                                    currDamage += m[x + i - 1, y + j + 1];
                                }
                            } 

                            else if (j == 0)
                            {
                                if (y > 0)
                                {
                                    continue;
                                }
                                
                                if (m[x + i, y + j + 1] >= m[i, j])
                                {
                                    currDamage += m[i, j];
                                }

                                else
                                {
                                    currDamage += m[x + i, y + j + 1];
                                }
                            } 

                            else if (i == m.GetLength(0) - 1 && j == m.GetLength(1) - 1)
                            {
                                if (x < 0 || y < 0)
                                {
                                    continue;
                                }
                                
                                if (m[x + i - 1, y + j - 1] >= m[i, j])
                                {
                                    currDamage += m[i, j];
                                }

                                else
                                {
                                    currDamage += m[x + i - 1, y + j - 1];
                                }
                            } 

                            else if (i == m.GetLength(0) - 1)
                            {
                                if (x < 0)
                                {
                                    continue;
                                }
                                
                                if (m[x + i - 1, y + j] >= m[i, j])
                                {
                                    currDamage += m[i, j];
                                }

                                else
                                {
                                    currDamage += m[x + i - 1, y + j];
                                }
                            } 

                            else if (j == m.GetLength(1) - 1)
                            {
                                if (y < 0)
                                {
                                    continue;
                                }
                                
                                if (m[x + i, y + j - 1] >= m[i, j])
                                {
                                    currDamage += m[i, j];
                                }

                                else
                                {
                                    currDamage += m[x + i, y + j - 1];
                                }
                            } 

                            else
                            {
                                if (m[x + i, y + j] >= m[i, j])
                                {
                                    currDamage += m[i, j];
                                }

                                else
                                {
                                    currDamage += m[x + i, y + j];
                                }
                            } 
                        }
                    }

                    currDamage -= m[i, j];
                    maxDamage = Math.Max(maxDamage, currDamage);
                }
            }

            return maxDamage;
        }
        
        public static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3, 4 },
                                         { 5, 6, 7, 8 },
                                         { 9, 10, 11, 12}
                                                };
            Console.WriteLine("The maximum damage that can be dealt is {0}", MatrixBombing(matrix));
        }
    }
}
