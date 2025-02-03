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



        }
    }
}
