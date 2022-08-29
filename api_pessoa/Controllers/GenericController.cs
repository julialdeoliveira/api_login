using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_pessoa.Controllers
{
    public class GenericController<T> : ControllerBase where T : BaseModel
    {
        private BaseRepository<T> repo;

        public GenericController()
        {
            this.repo = new BaseRepository<T>();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {

            return repo.GetById(id);

        }

        [HttpGet]
        public List<T>GetAll()
        {

            return repo.GetAll();

        }

        [HttpPost]
        public string Post(T model)
        {
  
            return repo.Create(model);
        }
        [HttpDelete]
        public string Delete(int id)
        {
  
            return repo.Delete(id);

        }
        [HttpPut]
        public string Update(T model)
        {


            return repo.Update(model);

        }

    }
}
