using Demo.APIs.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.APIs.Infra.Model.Sales
{
    public class ProductsModels : IProductsModels
    {
        public ProductsModels(string nome, decimal preco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Preco = preco;
        }

        public ProductsModels() { }

        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public IEnumerable<ProductsModels> Values()
        {
            return new List<ProductsModels>()
            {
                new ProductsModels("DevOps", 50M),
                new ProductsModels("Qualidade de software", 50M),
                new ProductsModels("Desenvolvimento", 50M)
            };
        }
    }
}
