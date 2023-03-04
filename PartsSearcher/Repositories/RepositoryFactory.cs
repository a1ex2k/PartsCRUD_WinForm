
using Microsoft.Extensions.DependencyInjection;
using PartsSearcher.Data;
using PartsSearcher.Forms;
using PartsSearcher.Interfaces;

namespace PartsSearcher.Services;

public class RepositoryFactory : IRepositoryFactory
{
    private IServiceProvider _serviceProvider;

    public RepositoryFactory(IServiceProvider serviceProvider)
    {
        this._serviceProvider = serviceProvider;
    }
    
    public IRepository<TPart> GetRepository<TPart>() where TPart : IPart
    {
		var repo = _serviceProvider.GetService<IRepository<TPart>>();
		return repo;
	}

    public IRepository<IPart> GetRepositoryFor(IPart part)
    {
	    if (part is Flange) return _serviceProvider.GetService<IRepository<Flange>>();
	    else throw new ArgumentException();
    }
}


