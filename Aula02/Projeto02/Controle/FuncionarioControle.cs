using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controle
{
    public class FuncionarioControle
    {
        public void ExportarTxt(Funcionario funcionario)
        {
            StreamWriter streamWriter = new StreamWriter("c:\\temp\\Funcionarios.txt", true);

            streamWriter.WriteLine("Codigo................." + funcionario.IdFuncionario);
            streamWriter.WriteLine("Nome..................." + funcionario.Nome);
            streamWriter.WriteLine("Salario................" + funcionario.Salario);
            streamWriter.WriteLine("Tipo de Contratação...." + funcionario.TipoContratacao);

            streamWriter.WriteLine("\n");

            streamWriter.Close();

        }

        public void ExportarCSV(Funcionario funcionario)
        {
            StreamWriter streamWriter = new StreamWriter("c:\\temp\\Funcionario.csv", true);

            string dados = $"{funcionario.IdFuncionario};{funcionario.Nome};{funcionario.Salario};{funcionario.TipoContratacao}";

            streamWriter.WriteLine(dados);
            streamWriter.Close();
        }

        public void ExportarParaXml(Funcionario funcionario)
        {
            StreamWriter streamWriter
            = new StreamWriter("c:\\temp\\funcionarios.xml");

            streamWriter.WriteLine("<?xml version='1.0' encoding='ISO-8859-1'?>");
            streamWriter.WriteLine("<FUNCIONARIO>");
            streamWriter.WriteLine
            ($"<CODIGO>{funcionario.IdFuncionario}</CODIGO>");
            streamWriter.WriteLine
            ($"<NOME>{funcionario.IdFuncionario}</NOME>");
            streamWriter.WriteLine
            ($"<SALARIO>{funcionario.IdFuncionario}</SALARIO>");
            streamWriter.WriteLine
            ($"<TIPO>{funcionario.TipoContratacao}</TIPO>");
            streamWriter.WriteLine("</FUNCIONARIO>");
            streamWriter.Close();
        }
    }
}
