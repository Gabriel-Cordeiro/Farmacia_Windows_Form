﻿using Farmacia.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Classes
{
   public  class clienteDAO
    {
        public bool inserirCliente(tb_clientes_farmacia objCliente)
        {
            var db = new FarmaciaEntities();
            db.tb_clientes_farmacia.Add(objCliente);

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

        public bool atualizarCliente(tb_clientes_farmacia objCliente)
        {

            var db = new FarmaciaEntities();
            db.Entry<tb_clientes_farmacia>(objCliente).State = System.Data.Entity.EntityState.Modified;

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

        public List<tb_clientes_farmacia> pegarTodosClientes()
        {
            using (var db = new FarmaciaEntities())
            {
                return db.tb_clientes_farmacia.ToList().OrderBy(x => x.tx_nome).ToList();
            }
        }

        public tb_clientes_farmacia pegarClientePorCpf(decimal cpf)
        {
            using (var db = new FarmaciaEntities())
            {
                return db.tb_clientes_farmacia.Where(x => x.in_cpf == cpf).FirstOrDefault();
            }
        }

        public bool temCompraRecorrente(decimal id_cliente, int id_produto)
        {
            using (var db = new FarmaciaEntities())
            {
                return db.tb_produtos_vendidos_farmacia.Where(x => x.id_cliente == id_cliente && x.id_produto == id_produto).Count() > 0;
            }
        }
    }
}
