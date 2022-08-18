using Braspag.Model;
using Braspag.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Braspag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BrasPagController : ControllerBase
    {
        private readonly IBrasPagRepository _repository;
        public BrasPagController(IBrasPagRepository repository)
        {
            _repository = repository;
        }

        //endpoint que busca todos
        [HttpGet]
        public async Task<IEnumerable<PessoaModel>> GetDados()
        {
            return await _repository.Get();

        }

        //insere dados
        [HttpPost]
        public async Task<ActionResult<PessoaModel>> PostDados([FromBody] PessoaModel pessoa)
        {
            double percentual = pessoa.valTaxa / 100.0;
            double valor_final = pessoa.valor - (percentual * pessoa.valor);
            pessoa.valorLiquido = valor_final;
            var newDado = await _repository.Create(pessoa);
            return newDado;
        }

        //// endpoint que busca por id
        //[HttpGet("{Adquirente}")]
        //public async Task<BrasPag> GetDados(string Adquirente)
        //{
        //    return await _repository.Get(Adquirente);
        //}


        ////delata dados 
        //[HttpDelete("{Adquirinte}")]

        //public async Task<ActionResult> Delete(int id)
        //{
        //    var bookToDelete = await _repository.Get(id);

        //    if (bookToDelete == null)
        //        return NotFound();

        //    await _repository.Delete(bookToDelete.Adquirente);
        //    return NoContent();


        //}

        //[HttpPut]

        //public async Task<ActionResult> PutDados(string Adquirente, [FromBody] BrasPag brasPag)
        //{
        //    if (Adquirente != brasPag.Adquirente)
        //        return BadRequest();

        //    await _repository.Update(brasPag);

        //    return NoContent();

    }




}


