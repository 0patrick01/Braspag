using Braspag.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Braspag.Repository
{
    public interface IBrasPagRepository
    {
        Task<IEnumerable<PessoaModel>> Get();
        Task<PessoaModel> Create(PessoaModel braspag);

        //Task<PessoaModel> Get(string Adquirente);

        //Task Update(BrasPag brasPag);

        //Task Delete(string Adquirente);
    }


}
