using System;

namespace Quiz_Arte
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontuação = 0;

            Console.WriteLine("Quiz: Arte por Fernanda R. Erthal");
            Console.WriteLine();
            Console.WriteLine("1 - Quem é o autor do quadro Os Comedores de Batata?");
            Console.WriteLine();
            Console.WriteLine("a) Leonardo Da Vinci");
            Console.WriteLine("b) Vincent Van Gogh");
            Console.WriteLine("c) Claude Monet");
            Console.WriteLine("d) Pablo Picasso");
            Console.WriteLine();
            Console.Write("Resposta:");

            String resposta = Console.ReadLine();

            if (resposta == "b")
            {

                Console.WriteLine();
                Console.WriteLine("Resposta correta!");
                pontuação = pontuação + 10;
                Console.WriteLine("Pontuação:" + pontuação);
                Console.WriteLine();

            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Pontuação: " + pontuação);
                Console.WriteLine();

            }

            Console.WriteLine("2 - Em que museu está localizada a obra Mona Lisa?");
            Console.WriteLine();
            Console.WriteLine("a) Museu do Louvre");
            Console.WriteLine("b) Museu de Orsay");
            Console.WriteLine("c) Museu do Vaticano");
            Console.WriteLine("d) Galeria Uffizi");
            Console.WriteLine();
            Console.Write("Resposta:");

            resposta = Console.ReadLine();

            if (resposta == "a")
            {

                Console.WriteLine();
                Console.WriteLine("Resposta correta!");
                pontuação = pontuação + 10;
                Console.WriteLine("Pontuação:" + pontuação);
                Console.WriteLine();

            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Pontuação: " + pontuação);
                Console.WriteLine();

            }

            Console.WriteLine("3 - Em que ano foi pintada a obra Noite Estrelada?");
            Console.WriteLine();
            Console.WriteLine("a) 1902");
            Console.WriteLine("b) 1790");
            Console.WriteLine("c) 1876");
            Console.WriteLine("d) 1889");
            Console.WriteLine();
            Console.Write("Resposta:");

            resposta = Console.ReadLine();

            if (resposta == "d")
            {

                Console.WriteLine();
                Console.WriteLine("Resposta correta!");
                pontuação = pontuação + 10;
                Console.WriteLine("Pontuação:" + pontuação);
                Console.WriteLine();

            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Pontuação: " + pontuação);
                Console.WriteLine();

            }

            Console.WriteLine("4 - Que artista é considerado pai do expressionismo?");
            Console.WriteLine();
            Console.WriteLine("a) Michelangelo");
            Console.WriteLine("b) Sandro Botticelli");
            Console.WriteLine("c) Claude Monet");
            Console.WriteLine("d) Vincent Van Gogh");
            Console.WriteLine();
            Console.Write("Resposta:");

            resposta = Console.ReadLine();

            if (resposta == "c")
            {

                Console.WriteLine();
                Console.WriteLine("Resposta correta!");
                pontuação = pontuação + 10;
                Console.WriteLine("Pontuação:" + pontuação);
                Console.WriteLine();

            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Pontuação: " + pontuação);
                Console.WriteLine();

            }

            Console.WriteLine("5 - Qual destas obras NÃO pertence a Salvador Dalí?");
            Console.WriteLine();
            Console.WriteLine("a) O Filho do Homem");
            Console.WriteLine("b) A Persistência da Memória");
            Console.WriteLine("c) Os elefantes");
            Console.WriteLine("d) Relógio mole no momento da primeira explosão");
            Console.WriteLine();
            Console.Write("Resposta:");

            resposta = Console.ReadLine();

            if (resposta == "a")
            {

                Console.WriteLine();
                Console.WriteLine("Resposta correta!");
                pontuação = pontuação + 10;
                Console.WriteLine("Pontuação:" + pontuação);
                Console.WriteLine();

            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Pontuação: " + pontuação);
                Console.WriteLine();

            }

            Console.WriteLine("Pontuação final: " + pontuação);
            Console.WriteLine("Obrigada por jogar!");

            Console.ReadLine();
        }
    }
}
