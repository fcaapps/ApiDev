using System;
using System.Collections.Generic;
using System.Text;
using ApiDev.Domain.Entities;

namespace ApiDev.Domain.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        IEnumerable<Fornecedor> GetAll();
    }
}
