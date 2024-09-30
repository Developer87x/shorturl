using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShortUrl.Domain.Entities;
using ShortUrl.Domain.SharedKernel;

namespace ShortUrl.Domain.Repositories
{
    public interface IShortUrlRepository :IRepository<Shorturl>
    {
        Task<Shorturl> GetById(Guid id);
        
    }
}