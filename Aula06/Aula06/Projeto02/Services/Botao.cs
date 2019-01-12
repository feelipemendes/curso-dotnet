using Projeto02.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Services
{
    public class Botao
    {
        public void Ativar(IDispositivo dispositivo)
        {
            dispositivo.Ligar();            
        }
    }
}
