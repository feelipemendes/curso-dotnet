using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Contratos
{
    public interface IControle<T>
    {
        void ExportarParaTxt(T obj);
        void ExportarParaCsv(T obj);
        void ExportarParaXml(T obj);
    }
}
