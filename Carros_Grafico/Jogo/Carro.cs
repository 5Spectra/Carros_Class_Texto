using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Carro
    {
        public string modelo;
        public int ano;
        public bool status;

        public void ligar(string varmodelo, int varano, bool varstatus){
            modelo = varmodelo;
            ano = varano;
            status = varstatus;
        }
        public void Desligar(bool status)
        {
            status = false;
        }
        public int acelerar(int qpercorrer)
        {
            int dpercorrer = 0;
            dpercorrer = qpercorrer;
            return dpercorrer;
        }
    }
}
