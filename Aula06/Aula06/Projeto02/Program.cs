using Projeto02.Controle;
using Projeto02.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarme alarme = new Alarme();
            Lampada lampada = new Lampada();
            Botao botao = new Botao();
            botao.Ativar(alarme);
            botao.Ativar(lampada);
            Console.ReadKey(); //pausar..
        }
    }
}
