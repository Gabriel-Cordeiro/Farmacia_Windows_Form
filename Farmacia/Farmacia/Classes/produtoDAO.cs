using Farmacia.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Classes
{
    public class produtoDAO
    {
        public bool inserirProduto(tb_produtos objProduto)
        {
            var db = new FarmaciaEntities();
            db.tb_produtos.Add(objProduto);

            #region .: db.SaveChanges :.

            try
            {
                db.SaveChanges();
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                var raise = (from validationErrors in dbEx.EntityValidationErrors
                             from validationError in validationErrors.ValidationErrors
                             select string.Format("{0}:{1}", validationErrors.Entry.Entity, validationError.ErrorMessage))
                    .Aggregate<string, Exception>(dbEx,
                        (current, message) => new InvalidOperationException(message, current));
                throw raise;
            }

            #endregion
        }

        public bool atualizarProduto(tb_produtos objProduto)
        {
            var db = new FarmaciaEntities();
            db.Entry(objProduto).State = System.Data.Entity.EntityState.Modified;

            #region .: db.SaveChanges :.

            try
            {
                db.SaveChanges();
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                var raise = (from validationErrors in dbEx.EntityValidationErrors
                             from validationError in validationErrors.ValidationErrors
                             select string.Format("{0}:{1}", validationErrors.Entry.Entity, validationError.ErrorMessage))
                    .Aggregate<string, Exception>(dbEx,
                        (current, message) => new InvalidOperationException(message, current));
                throw raise;
            }

            #endregion
        }

        public List<tb_produtos> pegarTodosProdutos()
        {
            using (var db = new FarmaciaEntities())
            {
                return db.tb_produtos.ToList().OrderBy(x => x.tx_nome_produto).ToList();
            }
        }

        public tb_produtos pegarProdutoPorCodigo(int codigo)
        {
            using (var db = new FarmaciaEntities())
            {
                return db.tb_produtos.Where(x => x.id_produto == codigo).FirstOrDefault();
            }
        }

        public bool insertVenda(tb_produtos_vendidos objVenda)
        {
            var db = new FarmaciaEntities();
            db.tb_produtos_vendidos.Add(objVenda);

            #region .: db.SaveChanges :.

            try
            {
                db.SaveChanges();
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                var raise = (from validationErrors in dbEx.EntityValidationErrors
                             from validationError in validationErrors.ValidationErrors
                             select string.Format("{0}:{1}", validationErrors.Entry.Entity, validationError.ErrorMessage))
                    .Aggregate<string, Exception>(dbEx,
                        (current, message) => new InvalidOperationException(message, current));
                throw raise;
            }
            #endregion
        }

        public List<tb_produtos> buscarProdutosPorNome(string nome_produto)
        {
            using (var db = new FarmaciaEntities())
            {
                return db.tb_produtos.Where(x => x.tx_nome_produto.Contains(nome_produto)).ToList();
            }
        }

        public List<tb_produtos> pegarProdutosMaisVendidos()
        {
            using (var db = new FarmaciaEntities())
            {
                return db.tb_produtos.Join(db.tb_produtos_vendidos, pro => pro.id_produto, prov => prov.id_produto, (pro, prov) => new { pro, prov })
                    .Where(pro => pro.pro.in_quantidade > 0)
                    .Select(pro => pro.pro).Distinct().Take(15).ToList();
            }
        }

    }
}
