using Projeto01.Contratos;
using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Controle
{
    public class AutorControle : IAutorControle
    {
        public void ExportarParaCsv(Autor autor)
        {
            using (StreamWriter streamWriter
            = new StreamWriter("c:\\temp\\autores.csv", true))
            {
                streamWriter.WriteLine($"{autor.IdAutor};{autor.Nome}");
            }
        }
    }
}
