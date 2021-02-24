using Gestao__de_Contrato.Models;
using Gestao__de_Contrato.TiposEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao__de_Contrato.Contexto
{
    public class ContratoContext
    {
        private readonly BaseContext db;
        public ContratoContext()
        {
            db = new BaseContext();
        }
        #region Métodos
        public void Salvar(ContratoModel contrato)
        {
            db.Contratos.Add(contrato);
            db.SaveChanges();
        }
        public IList<ContratoModel> Listar()
        {
            return db.Contratos.ToList();
        }
        public void Atualizar(ContratoModel contrato)
        {
            var dados = db.Contratos.Find(contrato.ContratoId);
            if (dados != null)
            {
                dados.Carencia = contrato.Carencia;
                dados.Datacontrato = contrato.Datacontrato;
                dados.IdEmpresaContratada = contrato.IdEmpresaContratada;
                dados.IdEmpresaContratante = contrato.IdEmpresaContratante;
                dados.Prazo = contrato.Prazo;
                dados.Valor = contrato.Valor;
                dados.Status = contrato.Status;
                dados.Vigencia = contrato.Vigencia;
                dados.Descricao_do_Objeto = contrato.Descricao_do_Objeto;
                dados.Objeto = contrato.Objeto;
            }
            db.SaveChanges();
        }
        public ContratoModel BuscarContratoPorId(int id)
        {
            return db.Contratos.Find(id);
        }
        public void Excluir(int id)
        {
            var dados = db.Contratos.Find(id);
            db.Contratos.Remove(dados);
            db.SaveChanges();
        }
        public IList<ContratoModel> FiltrarDados(ContratoModel contrato)
        {
            var query = db.Contratos.Include("Empresa").Where(cm =>
            (contrato.Datacontrato == null || cm.Datacontrato == contrato.Datacontrato) &&
            (contrato.Vigencia == null || cm.Vigencia == contrato.Vigencia) &&
            (contrato.Status == "Selecione.." || cm.Status == contrato.Status) &&
            (contrato.Objeto == "Selecione.." || cm.Objeto == contrato.Objeto)
            ).ToList();
            return query;
        }

        public ContratoModel Detalhar(int id)
        {
            var query = db.Contratos.Include("Empresa").Where(c=>c.ContratoId==id).FirstOrDefault();
            return query;

        }
        #endregion
    }
}
