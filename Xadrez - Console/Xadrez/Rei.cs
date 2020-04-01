﻿using tabuleiro;
using tabuleiro.Enums;

namespace Xadrez
{
    class Rei : Peca
    {

        public PartidaDeXadrez Partida;

        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base (tab, cor)
        {
            Partida = partida;
        }

        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        private bool TesteParaTorreParaRoque(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return (p != null) && (p is Torre) && (p.Cor == Cor) && (p.QteMovimentos == 0);

        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            
            if(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //nordeste

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna +1);

            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //direita


            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);

            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudeste


            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo


            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);

            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudoeste

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //esquerda


            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);

            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //noroeste


            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //#jogadaespecial

            if(QteMovimentos == 0 && !Partida.Xeque)
            {
                //roque pequeno #jogadaespecial
                Posicao posT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (TesteParaTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);
                    if(Tab.Peca(p1) == null && Tab.Peca(p2) == null)
                    {
                        mat[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }
                //roque grande #jogadaespecial
                Posicao posT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (TesteParaTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);
                    if (Tab.Peca(p1) == null && Tab.Peca(p2) == null && Tab.Peca(p3) == null)
                    {
                        mat[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }

            return mat;

        }

    }
}
