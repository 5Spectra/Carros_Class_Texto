using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro monza = new Carro();
            monza.modelo = "Monza";
            monza.cor = "Bege";
            monza.velocidade = 40;
            monza.marcha = 2;

            Carro uno = new Carro();
            uno.modelo = "Uno";
            uno.cor = "Verde";
            uno.velocidade = 120;
            uno.marcha = 4;

            uno.Exibir();
            Console.ReadLine();
        }
    }
}
