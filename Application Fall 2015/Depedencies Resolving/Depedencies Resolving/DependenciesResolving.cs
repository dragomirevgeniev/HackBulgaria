using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


namespace DependenciesResolving
{
    class DependenciesResolving
    {
        public static List<Package> installedPackages;
        public static List<Package> packages;

        public static String LoadJson()
        {
            using (StreamReader readJson = new StreamReader("all_packages.json"))
            {
                return readJson.ReadToEnd();
            }
        }

        private static void ExtractInput(List<Package> packages)
        {
            string json = LoadJson();
            json = json.Replace("{", string.Empty);
            json = json.Replace("}", string.Empty);
            json = json.Replace("\"", string.Empty);
            json = json.Replace("[", string.Empty);
            json = RemoveWhiteSpace(json);
            json = json.Replace("],", "|");
            string[] rows = json.Split('|');
            rows[rows.Length - 1] = rows[rows.Length - 1].Replace("]", string.Empty);

            for (int i = 0; i < rows.Length; i++)
            {
                Package package = new Package();
                package.Name = rows[i].Split(':')[0];
                package.Dependences = rows[i].Split(':')[1].Split(',');
                packages.Add(package);
            }
        }

        public static string RemoveWhiteSpace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

        public static Package GetPackageByName(string name)
        {
            for (int i = 0; i < packages.Count; i++)
            {
                if (name == packages[i].Name)
                {
                    return packages[i];
                }
            }

            throw new Exception("Invalid package! ");
        }

        static void Main(string[] args)
        {
            packages = new List<Package>();
            installedPackages = new List<Package>();
            ExtractInput(packages);

            Console.WriteLine("Enter the package you want to install: ");
            string input = Console.ReadLine();
            GetPackageByName(input).Install();
            Console.WriteLine("All done.");
        }
    }
}
