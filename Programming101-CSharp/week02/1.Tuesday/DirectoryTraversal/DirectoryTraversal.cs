using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryTraversal
{
    public class DirectoryTraversal
    {
        public static IEnumerable<string> IterateDirectory(DirectoryInfo dir)
        {
            foreach (var subDir in dir.GetDirectories())
            {
                yield return string.Format("├─" + subDir.Name);

                foreach (var item in IterateDirectory(subDir))
                {
                    yield return string.Format(" " + item);
                }
            }

            foreach (var file in dir.GetFiles())
            {
                yield return string.Format(" -" + file.Name);
            }
        }
        
        public static void Main(string[] args)
        {
            string path = @"C:\Users\User\Downloads";
            DirectoryInfo directory = new DirectoryInfo(path);
            Console.WriteLine(path);
            try
            {
                foreach (var dir in IterateDirectory(directory))
                {
                    Console.WriteLine(dir);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
