using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.Domain.Entities;

public class Shorturl
{
    public Guid Id { get; set; }
    public string? OriginalUrl { get; set; }
    public DateTime CreatedDate { get; set; }= DateTime.Now;
    public DateTime ExpiryDate { get; set; }
}