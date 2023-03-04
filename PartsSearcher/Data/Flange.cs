using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PartsSearcher.Interfaces;
using PartsSearcher.TypeConvertors;

namespace PartsSearcher.Data;

public class Flange : IPart
{
    [Browsable(false), Key] public int Id { get; set; }
    [Browsable(false)] public bool SoftDeleted { get; set; }

    #region Part Properties

    [DisplayName("Обозначение")]
    public string Oboznachenie { get; set; }

    [DisplayName("Статус")]
    public string? Status { get; set; }

    [DisplayName("Диаметр отверстия под подшипник"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? DiametrOtverstijaPodPodshipnik { get; set; }

    [DisplayName("Расстояние от посадочной поверхности до оси отверстия под подшипник"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik { get; set; }

    [DisplayName("Диаметр центрирующего пояска"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? DiametrCentrirujushhegoPojaska { get; set; }

    [DisplayName("Высота центрирующего пояска"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? VysotaCentrirujushhegoPojaska { get; set; }

    [DisplayName("Диаметр центрирующей проточки"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? DiametrCentrirujushhejProtochki { get; set; }

    [DisplayName("Глубина центрирующей проточки"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? GlubinaCentrirujushhejProtochki { get; set; }

    [DisplayName("Расстояние между канавками под стопорные кольца"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? RasstojanieMezhduKanavkamiPodStopornyeKolca { get; set; }

    [DisplayName("Наружный размер фрезеровки проушин"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? NaruzhnyjRazmerFrezerovkiProushin { get; set; }

    [DisplayName("Внутренний размер фрезеровки проушин"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? VnutrennijRazmerFrezerovkiProushin { get; set; }

    [DisplayName("Количество крепёжных отверстий"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? KolichestvoKrepjozhnyhOtverstij { get; set; }

    [DisplayName("Диаметр крепёжных отверстий"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? DiametrKrepjozhnyhOtverstij { get; set; }

    [DisplayName("Диаметр расположения крепёжных отверстий"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? DiametrRaspolozhenijaKrepjozhnyhOtverstij { get; set; }

    [DisplayName("Линейный размер между крепёжными отверстиями"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? LinejnyjRazmerMezhduKrepjozhnymiOtverstijami { get; set; }

    [DisplayName("Угловой размер между крепёжными отверстиями"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? UglovojRazmerMezhduKrepjozhnymiOtverstijami { get; set; }

    [DisplayName("Типоразмер по ISO 12667")]
    public string? TiporazmerPoIso12667 { get; set; }

    [DisplayName("Диаметр обода"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? DiametrOboda { get; set; }

    [DisplayName("Толщина обода"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? TolshhinaOboda { get; set; }

    [DisplayName("Диаметр тела вращения по ободу"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? DiametrTelaVrashhenijaPoObodu { get; set; }

    [DisplayName("Расстояние от оси крепёжного отверстия до тела уха"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha { get; set; }

    [DisplayName("Диаметр внутренней расточки обода"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? DiametrVnutrennejRastochkiOboda { get; set; }

    [DisplayName("Глубина внутренней расточки обода"), TypeConverter(typeof(NullableDecimalConverter))]
    public decimal? GlubinaVnutrennejRastochkiOboda { get; set; }

    #endregion

    #region Methods

    public IPart Copy()
    {
        return new Flange()
        {
            Id = Id, Oboznachenie = Oboznachenie, Status = Status,
            DiametrOtverstijaPodPodshipnik = DiametrOtverstijaPodPodshipnik,
            RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik =
                RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik,
            DiametrCentrirujushhegoPojaska = DiametrCentrirujushhegoPojaska,
            VysotaCentrirujushhegoPojaska = VysotaCentrirujushhegoPojaska,
            DiametrCentrirujushhejProtochki = DiametrCentrirujushhejProtochki,
            GlubinaCentrirujushhejProtochki = GlubinaCentrirujushhejProtochki,
            RasstojanieMezhduKanavkamiPodStopornyeKolca = RasstojanieMezhduKanavkamiPodStopornyeKolca,
            NaruzhnyjRazmerFrezerovkiProushin = NaruzhnyjRazmerFrezerovkiProushin,
            VnutrennijRazmerFrezerovkiProushin = VnutrennijRazmerFrezerovkiProushin,
            KolichestvoKrepjozhnyhOtverstij = KolichestvoKrepjozhnyhOtverstij,
            DiametrKrepjozhnyhOtverstij = DiametrKrepjozhnyhOtverstij,
            DiametrRaspolozhenijaKrepjozhnyhOtverstij = DiametrRaspolozhenijaKrepjozhnyhOtverstij,
            LinejnyjRazmerMezhduKrepjozhnymiOtverstijami = LinejnyjRazmerMezhduKrepjozhnymiOtverstijami,
            UglovojRazmerMezhduKrepjozhnymiOtverstijami = UglovojRazmerMezhduKrepjozhnymiOtverstijami,
            TiporazmerPoIso12667 = TiporazmerPoIso12667, DiametrOboda = DiametrOboda, TolshhinaOboda = TolshhinaOboda,
            DiametrTelaVrashhenijaPoObodu = DiametrTelaVrashhenijaPoObodu,
            RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha = RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha,
            DiametrVnutrennejRastochkiOboda = DiametrVnutrennejRastochkiOboda,
            GlubinaVnutrennejRastochkiOboda = GlubinaVnutrennejRastochkiOboda
        };
    }
    
    protected bool Equals(Flange other)
    {
        return Id == other.Id && Oboznachenie == other.Oboznachenie && Status == other.Status && DiametrOtverstijaPodPodshipnik == other.DiametrOtverstijaPodPodshipnik && RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik == other.RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik && DiametrCentrirujushhegoPojaska == other.DiametrCentrirujushhegoPojaska && VysotaCentrirujushhegoPojaska == other.VysotaCentrirujushhegoPojaska && DiametrCentrirujushhejProtochki == other.DiametrCentrirujushhejProtochki && GlubinaCentrirujushhejProtochki == other.GlubinaCentrirujushhejProtochki && RasstojanieMezhduKanavkamiPodStopornyeKolca == other.RasstojanieMezhduKanavkamiPodStopornyeKolca && NaruzhnyjRazmerFrezerovkiProushin == other.NaruzhnyjRazmerFrezerovkiProushin && VnutrennijRazmerFrezerovkiProushin == other.VnutrennijRazmerFrezerovkiProushin && KolichestvoKrepjozhnyhOtverstij == other.KolichestvoKrepjozhnyhOtverstij && DiametrKrepjozhnyhOtverstij == other.DiametrKrepjozhnyhOtverstij && DiametrRaspolozhenijaKrepjozhnyhOtverstij == other.DiametrRaspolozhenijaKrepjozhnyhOtverstij && LinejnyjRazmerMezhduKrepjozhnymiOtverstijami == other.LinejnyjRazmerMezhduKrepjozhnymiOtverstijami && UglovojRazmerMezhduKrepjozhnymiOtverstijami == other.UglovojRazmerMezhduKrepjozhnymiOtverstijami && TiporazmerPoIso12667 == other.TiporazmerPoIso12667 && DiametrOboda == other.DiametrOboda && TolshhinaOboda == other.TolshhinaOboda && DiametrTelaVrashhenijaPoObodu == other.DiametrTelaVrashhenijaPoObodu && RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha == other.RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha && DiametrVnutrennejRastochkiOboda == other.DiametrVnutrennejRastochkiOboda && GlubinaVnutrennejRastochkiOboda == other.GlubinaVnutrennejRastochkiOboda;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Flange)obj);
    }

    public override string ToString() => $"Фланец {Oboznachenie}";

    #endregion
}