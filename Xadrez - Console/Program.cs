using System;
using tabuleiro;
using Xadrez___Console.Xadrez;
using tabuleiro.Enums;

namespace Xadrez___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            try
            {
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 2));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));
                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.Write(e.Message);
            }

          

            Console.ReadLine();
        }
    }
}
