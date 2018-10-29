using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiNamespace
{
    class clase1
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro de MiNamespace");
        }
    }
}

namespace OtroNamespace
{
    class clase1
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro de OtroNamespace");
        }
    }
}

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creando objetos de clases contenidas en otros namespaces
            MiNamespace.clase1 obj1 = new MiNamespace.clase1();
            OtroNamespace.clase1 obj2 = new OtroNamespace.clase1();

            obj1.Metodo();
            obj2.Metodo();

        }
    }
}
