using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Contratos
{
    public interface IAutorControle
    {
        void ExportarParaCsv(Autor autor);
    }
}
