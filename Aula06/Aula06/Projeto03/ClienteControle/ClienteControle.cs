using Projeto03.Contratos;
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
    public class ClienteControle : IControle<Cliente>
    {
        public void ExportarParaCsv(Cliente obj)
        {
            using (StreamWriter sw = new StreamWriter
            ("c:\\temp\\clientes.csv", true))
            {
                sw.WriteLine($"{obj.IdCliente};{obj.Nome};{obj.Email}");
            }
        }

        public void ExportarParaTxt(Cliente obj)
        {
            using (StreamWriter sw = new StreamWriter
            ("c:\\temp\\clientes.txt", true))
            {
                sw.WriteLine("Id.....: " + obj.IdCliente);
                sw.WriteLine("Nome...: " + obj.Nome);
                sw.WriteLine("Email..: " + obj.Email);
                sw.WriteLine("--");
            }
        }
        public void ExportarParaXml(Cliente obj)
        {
            using (XmlWriter xml = XmlWriter.Create("c:\\temp\\clientes.xml"))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("cliente");
                xml.WriteElementString("idcliente",
                obj.IdCliente.ToString());
                xml.WriteElementString("nome", obj.Nome);
                xml.WriteElementString("email", obj.Email);
                xml.WriteEndElement();
            }
        }
    }
}

