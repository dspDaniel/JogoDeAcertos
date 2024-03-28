namespace JogoDeAcertos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo de acertos..");

            string[] quetoes =
            {
                "Normalmente, quantos litros de sangue uma pessoa tem? Em média.",
                "De onde é a invenção do chuveiro elétrico?",
                "Atualmente, quantos elementos químicos a tabela periódica possui?"
            };

            string[] respostas =
            {
                "A. 10litros \nB. 4 a 6 Litros\nC. 2 a 4 Litros ",
                "A. Austrália \nB. França \nC. Beasil",
                "A. 118 \nB.109 \nC. 92"
            };

            int[] _respCorreta = { 1, 2, 0 };
            int Pontos = 0;

            Console.WriteLine("Sejá bem vindo");
            for (int i = 0; i < quetoes.Length; i++)
            {
                Console.WriteLine("Questão" + (i + 1));
                Console.WriteLine(quetoes[i]);
                Console.WriteLine(respostas[i]);
                Console.WriteLine("Por favor, insira a alternativa correta(A, B ou C): ");
                string _respPlay = Console.ReadLine().ToUpper();
                if (_respPlay == "A" && _respCorreta[i] == 0 ||
                    _respPlay == "B" && _respCorreta[i] == 1 ||
                     _respPlay == "C" && _respCorreta[i] == 2)
                {
                    Pontos++;
                }

            }

            Console.WriteLine("\nQuiz completo!!");
            Console.WriteLine("Sua pontuação foi de  " + Pontos + " Pontos");
        }
    }
}