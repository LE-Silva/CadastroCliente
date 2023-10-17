using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    public class Produto
    {
        public string CdProduto { get; set; }
        public string Descricao { get; set; }
        public bool IsActive { get; set;}
        public DateTime DtValidade { get; set; }
        public decimal Valor { get; set;}

        public Produto(string cdProduto, string descricao, bool isActive, DateTime dtValidade, decimal valor)
        {
            CdProduto = cdProduto;
            Descricao = descricao;
            IsActive = isActive;
            DtValidade = dtValidade;
            Valor = valor;
        }
    }
}
