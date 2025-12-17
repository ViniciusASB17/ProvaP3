
namespace ProvaP3.Dominio.Entidades
{
    public class Jogo
    {
        public int IdJogo { get; private set; }
        public int Valor1 { get; private set; }
        public int Valor2 { get; private set; }
        public int Valor3 { get; private set; }
        public int Valor4 { get; private set; }
        public int Valor5 { get; private set; }
        public int Valor6 { get; private set; }
        public DateTime DataJogo { get; private set; }

        public Jogo(int valor1, int valor2, int valor3, int valor4, int valor5, int valor6)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            Valor3 = valor3;
            Valor4 = valor4;
            Valor5 = valor5;
            Valor6 = valor6;
            DataJogo = DateTime.Now;
        }
    }
}
