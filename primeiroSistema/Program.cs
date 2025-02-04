using System;


namespace primeiroSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!"); //Mostra texto com quebra de linha
            Console.Write("Olá Mundo!!!"); //Mostra texto sem quebra de linha
            Console.WriteLine(1 + 3);
            //declaração de variáveis -> tipo de dados | nome da variável | valor
            string nomeAluno = "Ataliba";
            Console.WriteLine(nomeAluno);
            Console.WriteLine("==============");
            int idAluno = 1;
            Console.WriteLine(idAluno);
            string telAluno = "(14) 99999-8888";
            Console.WriteLine(telAluno);
            double salarioAluno = 1518.99;     
            Console.WriteLine(salarioAluno);
            //interpolação de variáveis
            Console.WriteLine("O aluno "+ nomeAluno +" tem o id = "+idAluno+", " +
                "seu telefone é "+telAluno+" e seu salário é R$ "+salarioAluno);
            string cidadeAluno; //declaração de variáveis
            cidadeAluno = "Jacareí"; //atribuição de valores nas variáveis
            string estadoAluno;
            estadoAluno = "São Paulo";

            Console.WriteLine(cidadeAluno);
            Console.WriteLine(estadoAluno);
            
            //declaração de constante
            const int meuNum = 1;
            Console.WriteLine(meuNum);

            string paisAluno;
            paisAluno = "Brasil";
            //Interpolação de strings
            /* Diferença entre concatenação e interpolação de strings --> A interpolação ($"...") permite 
             * inserir variáveis diretamente na string, melhorando a legibilidade. Ambas as abordagens
             funcionam, mas a interpolação de strings é mais moderna e facilita a manutenção do código */
            Console.WriteLine("O aluno nasceu no " + paisAluno + " Seja bem-vindo, " + nomeAluno + "!");
            //Maneira mais usual de interpolação
            Console.WriteLine($"O aluno nasceu no {paisAluno} Seja bem-vindo, {nomeAluno}!");

            //Atividade 1 C# - Declarando variáveis
            int idCurso = 2;
            string nomeCurso = "Técnico em Informática";
            string dtInicioCurso = "03/02/2025";
            string dtFimCurso = "30/06/2026";
            int idadeMinimaCurso = 16;
            int qtdAlunosCurso = 20;
            Console.WriteLine($"O {nomeCurso} de id {idCurso} inicia {dtInicioCurso} e finaliza {dtFimCurso}, podendo ter {qtdAlunosCurso} alunos na turma.");

            //Variáveis funcionando como operador matemático
            Console.WriteLine("========== Variáveis ============");
            int x = 10;
            int y = 20;
            Console.WriteLine(x + y);

            //Múltiplas variáveis funcionando como operador matemático
            Console.WriteLine("========= Múltiplas Variáveis ==========");
            int x1 = 10, y1 = 20, z1 = 30;
            Console.WriteLine(x1 + y1 + z1);

            //Atividade 2 - Tipos de dados

            int meuCodigo = 10;
            double meuSalario = 1000;
            char minhaInicial = 'G';
            bool meuBooleano = false;
            string meuTexto = "Olá TI!";

            Console.WriteLine("======= Tipos de dados =======");
            Console.WriteLine($"Meu código é: {meuCodigo}, meu salário é: R$ {meuSalario}, A inicial é: {minhaInicial} e a mensagem escrita é: {meuTexto}");

            //Conversão de tipo de dados C#

            int meuInt = 10;
            double meuDouble = meuInt; //conversão de int para double

            Console.WriteLine(meuInt);
            Console.WriteLine(meuDouble);

            double meuDouble1 = 10.50;
            int meuInt1 = (int) meuDouble1; //conversão de double para int

            Console.WriteLine(meuDouble1);
            Console.WriteLine(meuInt1);

            int meuInt2 = 10;
            double meuDouble2 = 8.15;
            bool meuBooleano1 = true;

            Console.WriteLine(Convert.ToString(meuInt2));
            Console.WriteLine(Convert.ToDouble(meuInt2));
            Console.WriteLine(Convert.ToInt32(meuDouble2));
            Console.WriteLine(Convert.ToString(meuBooleano1));

        }
    }
}
