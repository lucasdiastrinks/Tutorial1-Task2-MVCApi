using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tutorial2.Models;
using System.Linq;

namespace Tutorial2.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase {

        private readonly Cliente[] Clientes = new Cliente[] {
                    new Cliente { Id = 1, Nome = "Eduardo Pires", Email = "falecom@eduardopires.net.br", Ativo = true },
                    new Cliente { Id = 2, Nome = "Bill Gates", Email = "gates@microsoft.com", Ativo = true },
                    new Cliente { Id = 3, Nome = "Aleister Crowley", Email = "aleister@therion.com", Ativo = false }
        };

        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Get() {
            return Clientes;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id) {
            return (from i in Clientes where i.Id == id select i).FirstOrDefault();
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] Cliente value) {
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente value) {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
