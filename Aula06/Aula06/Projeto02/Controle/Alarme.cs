using Projeto02.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controle
{
    public class Alarme : IDispositivo
    {
        public void Ligar()
        {
            Console.WriteLine("Alarme disparado.");
        }
    }
}
