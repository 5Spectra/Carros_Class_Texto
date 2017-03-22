using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Carro
    {
        public string modelo = "", cor = "";
        public int velocidade = 0, marcha = 0;

        public void Exibir()
        {
            Console.WriteLine("Carro: " + modelo + " Cor: " + cor + " Marchas: " + marcha + " Velocidade: " + velocidade);

        }
    }
}
