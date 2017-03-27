using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Carro
    {
        public string modelo = "", cor = "", motor = "";
        public int velocidade = 0, marcha = 0, largura = 0, comprimento = 0, altura = 0;

        /// <summary>
        /// ABC
        /// </summary>
        public void Exibir()
        {
            Console.WriteLine("Carro: " + modelo + " Cor: " + cor + " Marchas: " + marcha + " Velocidade: " + velocidade);
        }
        public void acelerar() { }
        public void frear() { }
        public void buzinar() { }
        public void acender_farois() { }
    }
}
