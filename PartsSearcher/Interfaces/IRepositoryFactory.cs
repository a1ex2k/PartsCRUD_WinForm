using PartsSearcher.Data;
using PartsSearcher.Forms;

namespace PartsSearcher.Interfaces;

public interface IRepositoryFactory
{
	IRepository<TPart> GetRepository<TPart>() where TPart : IPart;
	IRepository<IPart> GetRepositoryFor(IPart part);
}