using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_pessoa.Controllers
{

    [Route("api/controller")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private PersonRepository repository;
        public PersonController()
        {
            this.repository = new PersonRepository();
        }

        [HttpGet]
        public Person GetById(int id)
        {
            PersonRepository personRepository = new PersonRepository();
            return personRepository.GetById(id);

        }
        [HttpPost]
        public string Post (Person model)
        {
            PersonRepository personRepository = new PersonRepository();
            return personRepository.Create(model);
        }
        [HttpDelete]
        public string Delete (int id)
        {
            PersonRepository personRepository = new PersonRepository();
            return personRepository.Delete(id);

        }
        [HttpPut]
        public string Update(Person model)
        {
            PersonRepository personRepository= new PersonRepository();
            return repository.Update(model);
            
        }
      
    }
}
