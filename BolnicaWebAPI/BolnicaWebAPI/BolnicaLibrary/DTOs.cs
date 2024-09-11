//using Bolnica.Entiteti;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bolnica
//{
//    #region Odeljenje
//    public class OdeljenjeBasic
//    {
//        public int Sifra { get; set; }
//        public string Tip { get; set; }
//        public DateTime Datum_izgradnje { get; set; }

//        public MedicinskoBasic Lekar_specijalista { get; set; }
//        public string Ime { get; set; }
//        public string Prezime { get; set; }
//        public IList<LeziNaBasic> LezeNaOdeljenju { get; set; }

//        public OdeljenjeBasic(int sifra, string tipOdeljenja, DateTime datum, string ime, string prezime)
//        {
//            this.Sifra = sifra;
//            this.Tip = tipOdeljenja;
//            this.Datum_izgradnje = datum;
//            this.Ime = ime;
//            this.Prezime = prezime;
//            LezeNaOdeljenju = new List<LeziNaBasic>();
//        }
//        public OdeljenjeBasic()
//        {

//        }
//    }
//    public class OdeljenjePregled
//    {
//        public int Sifra;
//        public string Tip;
//        public DateTime Datum_izgradnje;

//        public OdeljenjePregled()
//        {

//        }
//        public OdeljenjePregled(int sifra, string tip, DateTime datum)
//        {
//            this.Sifra = sifra;
//            this.Tip = tip;
//            this.Datum_izgradnje = datum;
//        }
//    }
//    #endregion

//    #region Stomatoloska_stolica
//    public class Stomatoloska_stolicaBasic
//    {
//        public string Proizvodjac { get; set; }
//        public DateTime Datum_proizvodnje { get; set; }

//        public Nemedicinsko Pripada_tehnickom_osoblju { get; set; }
//        public Stomatoloska_stolicaBasic(string prozivodjac, DateTime datum)
//        {
//            this.Proizvodjac = prozivodjac;
//            this.Datum_proizvodnje = datum;
//        }
//        public Stomatoloska_stolicaBasic()
//        {

//        }
//    }
//    #endregion

//    #region Smena
//    public class SmenaBasic
//    {
//        public virtual int Id { get; set; }
//        public virtual string Tip_smene { get; set; }

//        public SmenaBasic(int id, string tipSmene)
//        {
//            this.Id = id;
//            this.Tip_smene = tipSmene;
//        }
//        public SmenaBasic()
//        {

//        }
//    }
//    #endregion

//    #region Intervencija
//    public class IntervencijaBasic
//    {
//        public string Vrsta { get; set; }
//        public DateTime Datum { get; set; }

//        public IntervencijaBasic(string vrsta, DateTime datum)
//        {
//            this.Vrsta = vrsta;
//            this.Datum = datum;
//        }
//        public IntervencijaBasic()
//        {

//        }
//    }
//    #endregion

//    #region Pacijent
//    public class PacijentBasic
//    {
//        public int Mat_br { get; set; }
//        public string Ime { get; set; }
//        public string Prezime { get; set; }

//        public MedicinskoBasic Lekar_opste_prakse { get; set; }

//        public PacijentBasic(int MatBr, string ime, string prezime)
//        {
//            this.Mat_br = MatBr;
//            this.Ime = ime;
//            this.Prezime = prezime;
//        }
//        public PacijentBasic()
//        {

//        }
//    }
//    public class AmbulantniBasic : PacijentBasic
//    {
//        public string Ulica { get; set; }
//        public int Broj { get; set; }
//        public AmbulantniBasic()
//        {

//        }
//        public AmbulantniBasic(int matbr, string ime, string prezime, string ulica, int broj) : base(matbr, ime, prezime)
//        {
//            Ulica = ulica;
//            Broj = broj;
//        }
//    }

//    public class StacionarniBasic : PacijentBasic
//    {
//        public DateTime Datum_prijema { get; set; }
//        public DateTime Datum_otpusta { get; set; }

//        public Medicinsko Lekar_specijalista { get; set; }

//        public IList<LeziNaBasic> Leze_na_odeljenju { get; set; }
//        public StacionarniBasic()
//        {
//            Leze_na_odeljenju = new List<LeziNaBasic>();
//        }
//        public StacionarniBasic(int matbr, string ime, string prezime, DateTime datum_prijema, DateTime datum_otpusta) : base(matbr, ime, prezime)
//        {
//            this.Datum_prijema = datum_prijema;
//            this.Datum_otpusta = datum_otpusta;
//        }
//    }
//    public class PacijentPregled
//    {
//        public int Mat_br { get; set; }
//        public string Ime { get; set; }
//        public string Prezime { get; set; }

//        public PacijentPregled(int matbr, string ime, string prezime)
//        {
//            this.Mat_br = matbr;
//            this.Ime = ime;
//            this.Prezime = prezime;
//        }

//        public PacijentPregled()
//        {
//        }

//    }
//    public class AmbulantniPregled : PacijentPregled
//    {
//        public string Ulica { get; set; }
//        public string Broj { get; set; }

//        public AmbulantniPregled(int matbr, string ime, string prezime, string ulica, string broj) : base(matbr, ime, prezime)
//        {
//            this.Ulica = ulica;
//            this.Broj = broj;
//        }
//    }

//    public class StacionarniPregled : PacijentPregled
//    {
//        public DateTime Datum_prijema { get; set; }
//        public DateTime Datum_otpusta { get; set; }
//        public StacionarniPregled(int matbr, string ime, string prezime, DateTime datum_prijema, DateTime datum_otpusta) : base(matbr, ime, prezime)
//        {
//            datum_prijema = Datum_prijema;
//            datum_otpusta = Datum_otpusta;
//        }
//    }
//    #endregion

//    #region Osoblje
//    public class OsobljePregled
//    {
//        public int Mar_br;
//        public string Ime;
//        public string Prezime;
//        public OsobljePregled()
//        {

//        }
//        public OsobljePregled(int matbr, string ime, string prezime)
//        {
//            this.Mar_br = matbr;
//            this.Ime = ime;
//            this.Prezime = prezime;
//        }
//    }
//    public class OsobljeBasic
//    {
//        public int Mat_br;
//        public string Ime;
//        public string Prezime;
//        public OsobljeBasic()
//        {

//        }
//        public OsobljeBasic(int matbr, string ime, string prezime)
//        {
//            this.Mat_br = matbr;
//            this.Ime = ime;
//            this.Prezime = prezime;
//        }

//    }
//    #endregion

//    #region Medicinsko
//    public class MedicinskoPregled : OsobljePregled
//    {
//        public int Radni_staz;
//        public string TipLekara;
//        public int BrOrdinacije;
//        public string Specijalnost;

//        public MedicinskoPregled()
//        {

//        }
//        public MedicinskoPregled(int matbr, string ime, string prezime, int radniStaz, string tipLekara, int brOrdinacije, string specijalnost) : base(matbr, ime, prezime)
//        {
//            this.Radni_staz = radniStaz;
//            this.TipLekara = tipLekara;
//            this.BrOrdinacije = brOrdinacije;
//            this.Specijalnost = specijalnost;
//        }
//    }
//    public class MedicinskoBasic : OsobljeBasic
//    {
//        public int Radni_staz;
//        public string TipLekara;
//        public int BrOrdinacije;
//        public string Specijalnost;

//        public IList<OdeljenjeBasic> Odeljenja { get; set; }
//        public IList<PacijentBasic> Pacijenti { get; set; }
//        public IList<StacionarniBasic> Stacionarni { get; set; }

//        public MedicinskoBasic()
//        {
//            Odeljenja = new List<OdeljenjeBasic>();
//            Pacijenti = new List<PacijentBasic>();
//            Stacionarni = new List<StacionarniBasic>();
//        }
//        public MedicinskoBasic(int matbr, string ime, string prezime, int radniStaz, string tipLekara, int brOrdinacije, string specijalnost) : base(matbr, ime, prezime)
//        {
//            this.Radni_staz = radniStaz;
//            this.TipLekara = tipLekara;
//            this.BrOrdinacije = brOrdinacije;
//            this.Specijalnost = specijalnost;
//        }
//    }
//    #endregion

//    #region Nemedicinsko
//    public class NemedicinskoPregled : OsobljePregled
//    {
//        public string TipOdrzavanja;
//        public string Struka;

//        public NemedicinskoPregled()
//        {

//        }
//        public NemedicinskoPregled(int matbr, string ime, string prezime, string tipOdrzavanja, string struka) : base(matbr, ime, prezime)
//        {
//            this.TipOdrzavanja = tipOdrzavanja;
//            this.Struka = struka;
//        }
//    }
//    public class NemedicinskoBasic : OsobljeBasic
//    {
//        public string TipOdrzavanja;
//        public string Struka;

//        public IList<Stomatoloska_stolicaBasic> Stomatoloske_Stolice { get; set; }

//        public NemedicinskoBasic()
//        {
//            Stomatoloske_Stolice = new List<Stomatoloska_stolicaBasic>();
//        }
//        public NemedicinskoBasic(int matbr, string ime, string prezime, string tipOdrzavanja, string struka) : base(matbr, ime, prezime)
//        {
//            this.TipOdrzavanja = tipOdrzavanja;
//            this.Struka = struka;
//        }
//    }
//    #endregion

//    #region LeziNa
//    public class LeziNaPregled
//    {
//        public int Matbr;
//        public StacionarniPregled StacionarniLezi;
//        public OdeljenjePregled LeziNaOdeljenju;
//        public virtual DateTime Vreme_pocetka { get; set; }

//        public LeziNaPregled()
//        {

//        }
//        public LeziNaPregled(int matbr, StacionarniPregled p, OdeljenjePregled o, DateTime vreme_pocetka)
//        {
//            this.Matbr = matbr;
//            this.StacionarniLezi = p;
//            this.LeziNaOdeljenju = o;
//            this.Vreme_pocetka = vreme_pocetka;
//        }
//    }

//    public class LeziNaBasic
//    {
//        public int Matbr;
//        public StacionarniBasic StacionarniLezi;
//        public OdeljenjeBasic LeziNaOdeljenju;
//        public virtual DateTime Vreme_pocetka { get; set; }

//        public LeziNaBasic()
//        {

//        }
//        public LeziNaBasic(int matbr, StacionarniBasic stacionarni, OdeljenjeBasic odeljenje, DateTime vreme_pocetka)
//        {
//            this.Matbr = matbr;
//            this.StacionarniLezi = stacionarni;
//            this.LeziNaOdeljenju = odeljenje;
//            this.Vreme_pocetka = vreme_pocetka;
//        }
//    }

//    #endregion

//    #region OdrzavaHigijenuNa
//    public class OdrzavaHigijenuNaPregled
//    {
//        public int Matbr;
//        public NemedicinskoPregled HigijenicarOdrzava;
//        public OdeljenjePregled OdrzavaOdeljenje;
//        public DateTime Vreme_odrzavanja { get; set; }

//        public OdrzavaHigijenuNaPregled()
//        {

//        }
//        public OdrzavaHigijenuNaPregled(int matbr, NemedicinskoPregled p, OdeljenjePregled o, DateTime vreme_odrzavanja)
//        {
//            this.Matbr = matbr;
//            this.HigijenicarOdrzava = p;
//            this.OdrzavaOdeljenje = o;
//            this.Vreme_odrzavanja = vreme_odrzavanja;
//        }
//    }

//    public class OdrzavaHigijenuNaBasic
//    {
//        public int Matbr;
//        public NemedicinskoBasic HigijenicarOdrzava;
//        public OdeljenjeBasic OdrzavaOdeljenje;
//        public DateTime Vreme_odrzavanja { get; set; }

//        public OdrzavaHigijenuNaBasic()
//        {

//        }
//        public OdrzavaHigijenuNaBasic(int matbr, NemedicinskoBasic p, OdeljenjeBasic o, DateTime vreme_odrzavanja)
//        {
//            this.Matbr = matbr;
//            this.HigijenicarOdrzava = p;
//            this.OdrzavaOdeljenje = o;
//            this.Vreme_odrzavanja = vreme_odrzavanja;
//        }
//    }

//    #endregion
//}

