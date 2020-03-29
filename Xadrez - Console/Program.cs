using System;
using tabuleiro;
using Xadrez___Console.Xadrez;

namespace Xadrez___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, tabuleiro.Enums.Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab,tabuleiro.Enums.Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, tabuleiro.Enums.Cor.Branca), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
