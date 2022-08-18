using Braspag.Model;
using Braspag.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Braspag.Repositories
{
    public class BrasPagRepository : IBrasPagRepository
    {
        public readonly BrasPagContext _context;

        public BrasPagRepository(BrasPagContext context)
        {
            _context = context;

        }

        //CREATE
        public async Task<PessoaModel> Create(PessoaModel pessoa)
        {
            _context.pessoas.Add(pessoa);
            await _context.SaveChangesAsync();
            return pessoa;
        }

        //GETALL
        public async Task<IEnumerable<PessoaModel>> Get()
        {
            return await _context.pessoas.ToListAsync();
        }

        ////GET POR ID
        //public async Task<PessoaModel> Get(string Adquirente)
        //{
        //    return await _context.pessoas.FindAsync(Adquirente);
        //}

        //public async Task Update(PessoaModel brasPag)
        //{
        //    _context.Entry(brasPag).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();


        //}
        //public async Task Delete(int id)
        //{
        //    var pessoaDelete = await _context.pessoas.FindAsync(id);
        //    _context.pessoas.Remove(pessoaDelete);
        //    await _context.SaveChangesAsync();
        //}
    }

}
