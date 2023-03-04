using System.CodeDom.Compiler;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PartsSearcher.Data;
using PartsSearcher.Interfaces;

namespace PartsSearcher.Repositories;

public class FlangesRepository : IRepository<Flange>
{
	private readonly IDbContextFactory<DataContext> _contextFactory;
	private readonly ILogger<FlangesRepository> _logger;
	private Flange _searchModel = new();
	private Flange[] _flanges = Array.Empty<Flange>();

	public Flange SearchModel => _searchModel;
	public Flange[] LoadedData => _flanges;


	public FlangesRepository(IDbContextFactory<DataContext> contextFactory, ILogger<FlangesRepository> logger)
	{
		_contextFactory = contextFactory;
		_logger = logger;
	}

	public async Task LoadAllAsync()
	{
		await using var context = await _contextFactory.CreateDbContextAsync();
		_flanges = await context.Flanges
			.AsNoTracking()
			.Where(f => !f.SoftDeleted)
			.ToArrayAsync();
	}

	public async Task SearchAsync()
	{
		await using var context = await _contextFactory.CreateDbContextAsync();
		var query = context.Flanges
			.AsNoTracking()
			.Where(f => !f.SoftDeleted);

		if (!string.IsNullOrWhiteSpace(_searchModel.Oboznachenie))
			query = query.Where(f => EF.Functions.Like(f.Oboznachenie, $"{_searchModel.Oboznachenie}%"));

		if (_searchModel.Status != null)
			query = query.Where(f => EF.Functions.Like(f.Status, $"{_searchModel.Status}%"));

		if (_searchModel.DiametrOtverstijaPodPodshipnik != null)
			query = query.Where(f => f.DiametrOtverstijaPodPodshipnik == _searchModel.DiametrOtverstijaPodPodshipnik);

		if (_searchModel.RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik != null)
			query = query.Where(f =>
				f.RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik ==
				_searchModel.RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik);

		if (_searchModel.DiametrCentrirujushhegoPojaska != null)
			query = query.Where(f => f.DiametrCentrirujushhegoPojaska == _searchModel.DiametrCentrirujushhegoPojaska);

		if (_searchModel.VysotaCentrirujushhegoPojaska != null)
			query = query.Where(f => f.VysotaCentrirujushhegoPojaska == _searchModel.VysotaCentrirujushhegoPojaska);

		if (_searchModel.DiametrCentrirujushhejProtochki != null)
			query = query.Where(f => f.DiametrCentrirujushhejProtochki == _searchModel.DiametrCentrirujushhejProtochki);

		if (_searchModel.GlubinaCentrirujushhejProtochki != null)
			query = query.Where(f => f.GlubinaCentrirujushhejProtochki == _searchModel.GlubinaCentrirujushhejProtochki);

		if (_searchModel.RasstojanieMezhduKanavkamiPodStopornyeKolca != null)
			query = query.Where(f =>
				f.RasstojanieMezhduKanavkamiPodStopornyeKolca ==
				_searchModel.RasstojanieMezhduKanavkamiPodStopornyeKolca);

		if (_searchModel.NaruzhnyjRazmerFrezerovkiProushin != null)
			query = query.Where(f =>
				f.NaruzhnyjRazmerFrezerovkiProushin == _searchModel.NaruzhnyjRazmerFrezerovkiProushin);

		if (_searchModel.VnutrennijRazmerFrezerovkiProushin != null)
			query = query.Where(f =>
				f.VnutrennijRazmerFrezerovkiProushin == _searchModel.VnutrennijRazmerFrezerovkiProushin);

		if (_searchModel.KolichestvoKrepjozhnyhOtverstij != null)
			query = query.Where(f => f.KolichestvoKrepjozhnyhOtverstij == _searchModel.KolichestvoKrepjozhnyhOtverstij);

		if (_searchModel.DiametrKrepjozhnyhOtverstij != null)
			query = query.Where(f => f.DiametrKrepjozhnyhOtverstij == _searchModel.DiametrKrepjozhnyhOtverstij);

		if (_searchModel.DiametrRaspolozhenijaKrepjozhnyhOtverstij != null)
			query = query.Where(f =>
				f.DiametrRaspolozhenijaKrepjozhnyhOtverstij == _searchModel.DiametrRaspolozhenijaKrepjozhnyhOtverstij);

		if (_searchModel.LinejnyjRazmerMezhduKrepjozhnymiOtverstijami != null)
			query = query.Where(f =>
				f.LinejnyjRazmerMezhduKrepjozhnymiOtverstijami ==
				_searchModel.LinejnyjRazmerMezhduKrepjozhnymiOtverstijami);

		if (_searchModel.UglovojRazmerMezhduKrepjozhnymiOtverstijami != null)
			query = query.Where(f =>
				f.UglovojRazmerMezhduKrepjozhnymiOtverstijami ==
				_searchModel.UglovojRazmerMezhduKrepjozhnymiOtverstijami);

		if (!string.IsNullOrWhiteSpace(_searchModel.TiporazmerPoIso12667))
			query = query.Where(f => EF.Functions.Like(f.TiporazmerPoIso12667, $"{_searchModel.TiporazmerPoIso12667}%"));

		if (_searchModel.DiametrOboda != null) query = query.Where(f => f.DiametrOboda == _searchModel.DiametrOboda);

		if (_searchModel.TolshhinaOboda != null)
			query = query.Where(f => f.TolshhinaOboda == _searchModel.TolshhinaOboda);

		if (_searchModel.DiametrTelaVrashhenijaPoObodu != null)
			query = query.Where(f => f.DiametrTelaVrashhenijaPoObodu == _searchModel.DiametrTelaVrashhenijaPoObodu);

		if (_searchModel.RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha != null)
			query = query.Where(f =>
				f.RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha ==
				_searchModel.RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha);

		if (_searchModel.DiametrVnutrennejRastochkiOboda != null)
			query = query.Where(f => f.DiametrVnutrennejRastochkiOboda == _searchModel.DiametrVnutrennejRastochkiOboda);

		if (_searchModel.GlubinaVnutrennejRastochkiOboda != null)
			query = query.Where(f => f.GlubinaVnutrennejRastochkiOboda == _searchModel.GlubinaVnutrennejRastochkiOboda);

		_flanges = await query.ToArrayAsync();
	}

	public async Task<bool> SaveOrUpdateAsync(IPart flange)
	{
		if (flange is not Flange localFlange) return false;

		await using var context = await _contextFactory.CreateDbContextAsync();
		context.Update(localFlange);
		try
		{
			await context.SaveChangesAsync();
			return true;
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error while saving flange", localFlange);
			return false;
		}
	}

	public async Task<bool> SoftDeleteAsync(IPart flange)
	{
		if (flange is not Flange localFlange) return false;
		if (localFlange.Id == default) return true;

		await using var context = await _contextFactory.CreateDbContextAsync();
		localFlange.SoftDeleted = true;
		context.Entry(localFlange).Property(p => p.SoftDeleted).IsModified = true;

		try
		{
			await context.SaveChangesAsync();
			return true;
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error while soft deleting flange", localFlange);
			return false;
		}
	}

	public Flange GetNewPart()
	{
		return new Flange();
	}

	public void ResetSearchModel()
	{
		_searchModel = new();

	}

	public void CopyValues(IPart fromFlange, IPart toFlange)
	{
		if (fromFlange is not Flange from || toFlange is not Flange to)
			throw new ArgumentException("Incorrect argument type");

		to.Id = fromFlange.Id;
		to.Oboznachenie = from.Oboznachenie;
		to.Status = from.Status;
		to.DiametrOtverstijaPodPodshipnik = from.DiametrOtverstijaPodPodshipnik;
		to.RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik =
			from.RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik;
		to.DiametrCentrirujushhegoPojaska = from.DiametrCentrirujushhegoPojaska;
		to.VysotaCentrirujushhegoPojaska = from.VysotaCentrirujushhegoPojaska;
		to.DiametrCentrirujushhejProtochki = from.DiametrCentrirujushhejProtochki;
		to.GlubinaCentrirujushhejProtochki = from.GlubinaCentrirujushhejProtochki;
		to.RasstojanieMezhduKanavkamiPodStopornyeKolca = from.RasstojanieMezhduKanavkamiPodStopornyeKolca;
		to.NaruzhnyjRazmerFrezerovkiProushin = from.NaruzhnyjRazmerFrezerovkiProushin;
		to.VnutrennijRazmerFrezerovkiProushin = from.VnutrennijRazmerFrezerovkiProushin;
		to.KolichestvoKrepjozhnyhOtverstij = from.KolichestvoKrepjozhnyhOtverstij;
		to.DiametrKrepjozhnyhOtverstij = from.DiametrKrepjozhnyhOtverstij;
		to.DiametrRaspolozhenijaKrepjozhnyhOtverstij = from.DiametrRaspolozhenijaKrepjozhnyhOtverstij;
		to.LinejnyjRazmerMezhduKrepjozhnymiOtverstijami = from.LinejnyjRazmerMezhduKrepjozhnymiOtverstijami;
		to.UglovojRazmerMezhduKrepjozhnymiOtverstijami = from.UglovojRazmerMezhduKrepjozhnymiOtverstijami;
		to.TiporazmerPoIso12667 = from.TiporazmerPoIso12667;
		to.DiametrOboda = from.DiametrOboda;
		to.TolshhinaOboda = from.TolshhinaOboda;
		to.DiametrTelaVrashhenijaPoObodu = from.DiametrTelaVrashhenijaPoObodu;
		to.RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha = from.RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha;
		to.DiametrVnutrennejRastochkiOboda = from.DiametrVnutrennejRastochkiOboda;
		to.GlubinaVnutrennejRastochkiOboda = from.GlubinaVnutrennejRastochkiOboda;
	}


}