using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsSearcher.Interfaces;

public interface IPart
{
    public int Id { get; set; }
    public bool Equals(object? obj);
    public string ToString();
    public bool SoftDeleted { get; set; }

}