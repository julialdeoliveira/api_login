using Data.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
       
        public virtual string Create(T model)
        {
            using (ApiPersonContext apiPersonContext = new ApiPersonContext())
            {
                apiPersonContext.Set<T>().Add(model);
                apiPersonContext.SaveChanges();

            }
            return "Created";
            
        }

        public virtual string Delete(int id)
        {
            using (ApiPersonContext apiPersonContext = new ApiPersonContext())
            {
                apiPersonContext.Entry<T>(GetById(id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                apiPersonContext.SaveChanges();
            }
            return "Deleted";
            
        }


        public virtual T GetById(int Id)
        {
            T model = null;
            using (ApiPersonContext apiPersonContext = new ApiPersonContext())
            {
                model = apiPersonContext.Set<T>().Find(Id);                

            }
            return model;
        }

        public virtual string Update(T model)
        {
            using (ApiPersonContext apiPersonContext = new ApiPersonContext())
            {
                apiPersonContext.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                apiPersonContext.SaveChanges();

            }
            return "Modified";
        }
    }


}
