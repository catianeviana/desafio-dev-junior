using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestao__de_Contrato.Contexto;
using Gestao__de_Contrato.TiposEnum;

namespace Gestao__de_Contrato.Models
{
    [Table("Contratos")]
    public class ContratoModel
    {
        private readonly ContratoContext _contexto;

        public ContratoModel()
        {
            _contexto = new ContratoContext();
        }
        [Key()]
        public int ContratoId { get; set; }
        public string Objeto { get; set; }
        [ForeignKey("Empresa")]
        public int IdEmpresaContratante { get; set; }
        public int IdEmpresaContratada { get; set; }
        public string Status { get; set; }       
        public string Descricao_do_Objeto { get; set; }
        public DateTime? Datacontrato { get; set; }
        public DateTime Carencia { get; set; }
        public DateTime? Vigencia { get; set; }
        public decimal Valor { get; set; }
        public DateTime Prazo { get; set; }
        public virtual Empresa Empresa { get; set; }


        public string salvarContrato()
        {
            _contexto.Salvar(this);
            return "Contrato Salvo, adicionar um novo cadastro?";

        }
        public IList<ContratoModel> ListarContratos()
        {
            return _contexto.Listar();
        }
        public ContratoModel BuscarPorId(int id)
        {
            return _contexto.BuscarContratoPorId(id);
        }
        public IList<ContratoModel> BuscarLike(ContratoModel contrato)
        {
            return _contexto.FiltrarDados(contrato);
        }
        public string Deletar(int id)
        {
            _contexto.Excluir(id);
            return "Contrato Excluido";
        }
        public string AtualizarContrato(ContratoModel contrato)
        {
            _contexto.Atualizar(contrato);
            return "Contrato Atualizado";
        }

        public ContratoModel DetalharContrato(int id)
        {
            return _contexto.Detalhar(id);
        }
    }
}
