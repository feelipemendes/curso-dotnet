using Projeto02.Controle;
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
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("\nCADASTRO DE FUNCIONÁRIOS:\n");
            Console.WriteLine("Código do Funcionário.: ");
            funcionario.IdFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do Funcionário...: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Salário do Funcionário:");
            funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\tTipo de Contração do Funcionário");
            Console.WriteLine("\t(1) - Estágio");
            Console.WriteLine("\t(2) - CLT");
            Console.WriteLine("\t(3) - Terceirizado");

            Console.WriteLine("Informe o Tipo de Contratação.:");
            funcionario.TipoContratacao = (TipoContratacao)int.Parse(Console.ReadLine());

            //Imprimindo
            Console.WriteLine("\tCOD....:" + funcionario.IdFuncionario);
            Console.WriteLine("\tNome...:" + funcionario.Nome);
            Console.WriteLine("\tSalario:" + funcionario.Salario);
            Console.WriteLine("\tContratação..: " + funcionario.TipoContratacao);
            Console.WriteLine("..");

            FuncionarioControle funcionarioControle = new FuncionarioControle();

            funcionarioControle.ExportarCSV(funcionario);
            funcionarioControle.ExportarParaXml(funcionario);
            funcionarioControle.ExportarTxt(funcionario);

            Console.WriteLine("\nDados gravados com sucesso.");

            Console.ReadKey();

        }
    }
}
