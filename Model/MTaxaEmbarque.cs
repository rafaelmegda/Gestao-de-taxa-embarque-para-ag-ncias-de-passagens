using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class MTaxaEmbarque
    {
        public int id { get; set; }
        public string Data { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTarifa { get; set; }
        public decimal ValorTotal { get; set; }
        public int? EmpresaID { get; set; }
        public string NomeDaEmpresa { get; set; }
    }
}
