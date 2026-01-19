using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLINQ
{
    class Venda
    {
        public string Produto { get; set; } = "";
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Total => Quantidade * PrecoUnitario;

        public override string ToString() =>
            $"{Produto}: {Quantidade}x R$ {PrecoUnitario:F2} = R$ {Total:F2}";
    }
}
