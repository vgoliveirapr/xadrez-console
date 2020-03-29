﻿using tabuleiro;
using tabuleiro.Enums;

namespace Xadrez___Console.Xadrez
{
    class Rei : Peca
    {

        public Rei(Tabuleiro tab, Cor cor) : base (tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}