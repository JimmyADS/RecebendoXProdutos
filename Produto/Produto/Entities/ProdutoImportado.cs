using System.Globalization;

namespace Produto.Entities
{
     class ProdutoImportado : Produto
    {
        public double TaxaAlfandegaria { get; set; }

        public ProdutoImportado()
        { 
        }
        public ProdutoImportado(string nome, double preco,double taxaAlfandegaria) : base(nome, preco)
        {
            TaxaAlfandegaria = taxaAlfandegaria;
        }
        public Double TotalPreco()
        {
            return Preco + TaxaAlfandegaria;
        }
        public override string PrecoTag()
        {
            return Nome
                + " $ "
                + TotalPreco().ToString("F2", CultureInfo.InvariantCulture)
                + " Taxa alfandegaria: $ "
                + TaxaAlfandegaria.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
            
        }
        
    }
}
