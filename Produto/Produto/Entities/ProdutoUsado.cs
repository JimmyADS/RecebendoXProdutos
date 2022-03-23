using System.Globalization;

namespace Produto.Entities
{
     class ProdutoUsado : Produto
    {
        public DateTime DataFrabicacao { get; set; }

        public ProdutoUsado()
        { 
        }
        public ProdutoUsado(string nome, double preco, DateTime datafrabricacao) : base(nome, preco)
        {
            DataFrabicacao = datafrabricacao;
        }
        public override string PrecoTag()
        {
            return Nome
                + "(Usado) $ "
                + Preco.ToString("f2", CultureInfo.InvariantCulture)
                + " (Data de fabricação: "
                + DataFrabicacao.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
