using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsSearcher.Interfaces;

public interface IRepository<out TPart> where TPart : IPart
{
	TPart SearchModel { get; }
	TPart[] LoadedData { get; }
	Task LoadAllAsync();
	Task SearchAsync();
	Task<bool> SaveOrUpdateAsync(IPart part);
	Task<bool> SoftDeleteAsync(IPart part);
	TPart GetNewPart();
	void ResetSearchModel();
	void CopyValues(IPart from, IPart to);
}