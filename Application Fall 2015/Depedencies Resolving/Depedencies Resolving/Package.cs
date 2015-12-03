using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenciesResolving
{
    class Package
    {
        private string name;
        private string[] dependences;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string[] Dependences
        {
            get
            {
                return dependences;
            }

            set
            {
                dependences = value;
            }
        }

        public void Install()
        {
            Console.WriteLine("Installing {0}.", Name);

            if (DependenciesResolving.installedPackages.Contains(this))
            {
                Console.WriteLine("Already installed {0}.", Name);
                return;
            }

            if (Dependences.Length == 1 && Dependences[0] == "" )
            {
                DependenciesResolving.installedPackages.Add(this);
                Console.WriteLine("{0} install completed.", Name);
                return;
            }

            Console.Write("In order to install {0} we need: ", Name);

            for (int i = 0; i < Dependences.Length; i++)
            {
                Console.Write(Dependences[i] + "{0}", (Dependences.Length-1==i) ? "." : ", ");
            }

            Console.WriteLine("");

            for (int i = 0; i < Dependences.Length; i++)
            {
                DependenciesResolving.GetPackageByName(Dependences[i]).Install();
            }

            Console.WriteLine("{0} install completed.", Name);
        }
    }
}

