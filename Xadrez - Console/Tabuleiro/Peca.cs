using tabuleiro.Enums;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao pos, Tabuleiro tab, Cor cor)
        {
            Posicao = pos;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }

    }
}
