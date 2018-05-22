using Farmacia.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;



namespace Farmacia.Classes
{
    public class usuarioDAO
    {
        public tb_usuarios_farmacia verificarLogin(string login, string senha)
        {
            using (var db = new FarmaciaEntities())
            {
                return db.tb_usuarios_farmacia.Where(x => x.tx_login == login && x.tx_senha == senha).FirstOrDefault();
            }
        }

        public bool inserirUsuario(tb_usuarios_farmacia objUsuario)
        {
            var db = new FarmaciaEntities();
            db.tb_usuarios_farmacia.Add(objUsuario);

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
    }
}
