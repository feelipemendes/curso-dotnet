using Projeto03.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Projeto03.ClienteControle
{
    public class IProdutoControle
    {
        public void ExportarParaCsv(Produto obj)
        {
            using (StreamWriter sw = new StreamWriter
            ("c:\\temp\\produtos.csv", true))
            {
                sw.WriteLine($"{obj.IdProduto};{obj.Nome};{obj.Preco}");
            }
        }
        public void ExportarParaTxt(Produto obj)
        {
            using (StreamWriter sw = new StreamWriter
            ("c:\\temp\\produtos.txt", true))
            {
                sw.WriteLine("Id.....: " + obj.IdProduto);
                sw.WriteLine("Nome...: " + obj.Nome);
                sw.WriteLine("Email..: " + obj.Preco);
                sw.WriteLine("--");
            }
        }
        public void ExportarParaXml(Produto obj)
        {
            using (XmlWriter xml = XmlWriter.Create("c:\\temp\\produtos.xml"))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("produto");
                xml.WriteElementString("idproduto", obj.IdProduto.ToString());
                xml.WriteElementString("nome", obj.Nome);
                xml.WriteElementString("preco", obj.Preco.ToString());
                xml.WriteEndElement();
            }
        }
    }
}
