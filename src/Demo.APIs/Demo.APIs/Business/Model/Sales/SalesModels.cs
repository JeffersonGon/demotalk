using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.APIs.Infra.Model.Sales
{
    public class SalesModels : ISalesModels
    {
        public SalesModels(string produto, string cliente, string vendedor)
        {
            Id = Guid.NewGuid();
            Produto = produto;
            Cliente = cliente;
            Vendedor = vendedor;
        }
        //for dependency injection
        public SalesModels() { }

        public Guid Id { get; private set; }
        public string Produto { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }

        public IEnumerable<SalesModels> Values()
        {
            return new List<SalesModels>() {
                new SalesModels("DevOps", "Jefferson Almeida", "KONIA"),
                new SalesModels("Qualidade de software", "Jefferson Almeida", "KONIA"),
                new SalesModels("Desenvolvimento", "Cayo Diebe", "KONIA")
            };
        }
    }
}
