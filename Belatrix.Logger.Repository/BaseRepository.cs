using System;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;
using Belatrix.Logger.Repository.Entities;
using Belatrix.Logger.Transversal;

namespace Belatrix.Logger.Repository
{
    public class BaseRepository<T> where T : class
    {
        protected DbContext Context = new JobLoggerDBEntities();
        protected DbSet<T> DbSet;

        public BaseRepository()
        {
            DbSet = Context.Set<T>();
        }

        public Response<Boolean> Save(T entidad)
        {
            Response<Boolean> Response = null;
            try
            {
                DbSet.Add(entidad);
                Context.SaveChanges();

                Response = new Response<Boolean>()
                {
                    Success = true,
                    Message = "Operation Successfully Completed"
                };
            }
            catch (Exception e)
            {
                Response = new Response<Boolean>()
                {
                    Success = false,
                    Message = e.Message
                };
            }

            return Response;
        }

        public void Eliminar(T entidad)
        {
            DbSet.Remove(entidad);
        }

        public IQueryable<T> Filtrar(Expression<Func<T, bool>> expresion)
        {
            return DbSet.Where(expresion);
        }

        public T ObtenerPorId(string id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> ObtenerTodos()
        {
            return DbSet;
        }

        public void GuardarCambios()
        {
            Context.SaveChanges();
        }
    }
}
