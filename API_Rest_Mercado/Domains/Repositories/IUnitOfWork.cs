using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Rest_Mercado.Domains.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
