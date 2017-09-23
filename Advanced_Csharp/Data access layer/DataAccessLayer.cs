using Advanced_Csharp.Data_access_layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csharp
{
    public class DataAccessLayer<T> : IDataAccessLayer<T> where T : class
    {
        private UserContext db = new UserContext();
        protected DbSet<T> DbSet { get; set; }


        public DataAccessLayer()
        {
            db = new UserContext();
            DbSet = db.Set<T>();
        }

        //public DataAccessLayer(UserContext context)
        //{
        //    db = context;
        //    DbSet = db.Set<T>();
        //}

       

        public IEnumerable<T> SelectAll()
        {
            return DbSet.ToList();
        }

        public bool Add(T newElement)
        {
            try
            {
                DbSet.Add(newElement);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool Delete(object id)
        {
            try
            {
                T exEntity = DbSet.Find(id);
                DbSet.Remove(exEntity);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        
    }
}
