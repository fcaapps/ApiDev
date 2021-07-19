using System;
using System.Collections.Generic;
using System.Text;
using ApiDev.Application.ViewModels;

namespace ApiDev.Application.Interfaces
{
    public interface IFornecedorService
    {
        List<FornecedorViewModel> Get();        

    }
}
