using Bolnica.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica
{
    public class DTOManager
    {
        #region Odeljenja
        public static void obrisiOdeljenje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje odeljenje = s.Load<Odeljenje>(id);

                s.Delete(odeljenje);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static OdeljenjeBasic vratiOdeljenje(int sifra)
        {
            OdeljenjeBasic o = new OdeljenjeBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje odeljenje = s.Load<Odeljenje>(sifra);

                o.Sifra = odeljenje.Sifra;
                o.Tip = odeljenje.Tip;
                o.Datum_izgradnje = odeljenje.Datum_izgradnje;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }
        public static List<OdeljenjePregled> vratiSvaOdeljenja()
        {
            List<OdeljenjePregled> od = new List<OdeljenjePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Bolnica.Entiteti.Odeljenje> odeljenja = from o in s.Query<Bolnica.Entiteti.Odeljenje>()
                                                                    select o;

                foreach (Bolnica.Entiteti.Odeljenje r in odeljenja)
                {
                    od.Add(new OdeljenjePregled(r.Sifra, r.Tip, r.Datum_izgradnje));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return od;
        }
        public static OdeljenjeBasic azurirajOdeljenje(OdeljenjeBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Odeljenje o = s.Load<Bolnica.Entiteti.Odeljenje>(r.Sifra);

                o.Tip = r.Tip;
                o.Datum_izgradnje = r.Datum_izgradnje;
                // o.Sef = r.Sef;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return r;
        }
        public static void izmeniOdeljenje(OdeljenjeBasic odeljenje)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Odeljenje o = s.Load<Odeljenje>(odeljenje.Sifra);

                o.Tip = odeljenje.Tip;
                o.Datum_izgradnje = odeljenje.Datum_izgradnje;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void sacuvajOdeljenje(OdeljenjeBasic odeljenje)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Odeljenje o = new Bolnica.Entiteti.Odeljenje();

                o.Tip = odeljenje.Tip;
                o.Datum_izgradnje = odeljenje.Datum_izgradnje;
                //o.Pripada_Specijalisti= odeljenje.


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static List<OdeljenjeBasic> GetInfoOdeljenjeSpecijalista(int medicinsko)
        {
            List<OdeljenjeBasic> odInfos = new List<OdeljenjeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Odeljenje> odeljenja = from o in s.Query<Odeljenje>()
                                                   where o.Pripada_Specijalisti.MatBr == medicinsko
                                                   select o;

                foreach (Odeljenje o in odeljenja)
                {
                    odInfos.Add(new OdeljenjeBasic(o.Sifra, o.Tip, o.Datum_izgradnje, o.Pripada_Specijalisti.Ime, o.Pripada_Specijalisti.Prezime));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static List<OdrzavaHigijenuNaBasic> vratiSveOdrzavaHigijenu(int sifra)
        {
            List<OdrzavaHigijenuNaBasic> odrzavaHigijenuNa = new List<OdrzavaHigijenuNaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Bolnica.Entiteti.Odrzava_higijenu_na> svaodeljenja = from o in s.Query<Bolnica.Entiteti.Odrzava_higijenu_na>()
                                                                                 where o.Odeljenja.Sifra == sifra
                                                                                 select o;

                foreach (Bolnica.Entiteti.Odrzava_higijenu_na r in svaodeljenja)
                {

                    NemedicinskoBasic higijenicar = DTOManager.vratiNemedicinsko(r.Higijenicar.MatBr);
                    OdeljenjeBasic odeljenje = DTOManager.vratiOdeljenje(r.Odeljenja.Sifra);
                    odrzavaHigijenuNa.Add(new OdrzavaHigijenuNaBasic(r.Mat_br, higijenicar, odeljenje, r.Vreme_odrzavanja));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odrzavaHigijenuNa;
        }
        #endregion

        #region Intervencija
        public static void obrisiIntervenciju(string vrsta)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Intervencija i = s.Load<Intervencija>(vrsta);

                s.Delete(i);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static IntervencijaBasic vratiIntervenciju(string vrsta)
        {
            IntervencijaBasic o = new IntervencijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Intervencija i = s.Load<Intervencija>(vrsta);

                o.Vrsta = i.Vrsta;
                o.Datum = i.Datum;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }
        public static void izmeniIntervenciju(IntervencijaBasic intervencija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Intervencija o = s.Load<Intervencija>(intervencija.Vrsta);

                o.Datum = intervencija.Datum;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajIntervencijuu(IntervencijaBasic intervencija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Intervencija o = new Bolnica.Entiteti.Intervencija();

                o.Datum = intervencija.Datum;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion

        #region Smena
        public static void obrisiSmenu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena smena = s.Load<Smena>(id);

                s.Delete(smena);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static SmenaBasic vratiSmenu(int id)
        {
            SmenaBasic o = new SmenaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Smena smena = s.Load<Smena>(id);

                o.Id = smena.Id;
                o.Tip_smene = smena.Tip_smene;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }
        public static void izmeniSmenu(SmenaBasic smena)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Smena o = s.Load<Smena>(smena.Id);

                o.Tip_smene = smena.Tip_smene;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajSmenu(SmenaBasic smena)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Smena o = new Bolnica.Entiteti.Smena();

                o.Tip_smene = smena.Tip_smene;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion

        #region Stomatoloska_stolica
        public static void obrisiStomatoloskuStolicu(string proizvodjac)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Stomatoloska_stolica stolica = s.Load<Stomatoloska_stolica>(proizvodjac);

                s.Delete(stolica);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static Stomatoloska_stolicaBasic vratiStomatoloskuStolicu(string proizvodjac)
        {
            Stomatoloska_stolicaBasic o = new Stomatoloska_stolicaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Stomatoloska_stolica stolica = s.Load<Stomatoloska_stolica>(proizvodjac);

                o.Proizvodjac = stolica.Proizvodjac;
                o.Datum_proizvodnje = stolica.Datum_proizvodnje;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }
        public static void izmeniStomatoloskuStolicu(Stomatoloska_stolicaBasic stolica)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Stomatoloska_stolica o = s.Load<Stomatoloska_stolica>(stolica.Proizvodjac);

                o.Datum_proizvodnje = stolica.Datum_proizvodnje;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void sacuvajStomatoloskeStolice(Stomatoloska_stolicaBasic stolica)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Stomatoloska_stolica o = new Bolnica.Entiteti.Stomatoloska_stolica();

                o.Datum_proizvodnje = stolica.Datum_proizvodnje;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static List<Stomatoloska_stolicaBasic> GetInfoStolicaOdrzavanje(int nemedicinsko)
        {
            List<Stomatoloska_stolicaBasic> odInfos = new List<Stomatoloska_stolicaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Stomatoloska_stolica> stolice = from o in s.Query<Stomatoloska_stolica>()
                                                            where o.Pripada_tehnickom_osoblju.MatBr == nemedicinsko
                                                            select o;

                foreach (Stomatoloska_stolica o in stolice)
                {
                    odInfos.Add(new Stomatoloska_stolicaBasic(o.Proizvodjac, o.Datum_proizvodnje));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        #endregion

        #region Pacijent
        public static List<PacijentBasic> GetInfoPacijentLekar(int medicinsko)
        {
            List<PacijentBasic> odInfos = new List<PacijentBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Pacijent> pacijenti = from o in s.Query<Pacijent>()
                                                  where o.Pripada_Lekaru_Opste_prakse.MatBr == medicinsko
                                                  select o;

                foreach (Pacijent o in pacijenti)
                {
                    odInfos.Add(new PacijentBasic(o.Mat_br_pac, o.Ime_pac, o.Prezime_pac));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }

        #region Ambulantni
        public static void obrisiAmbulantni(int matbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ambulantni pacijent = s.Load<Ambulantni>(matbr);

                s.Delete(pacijent);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static AmbulantniBasic vratiPacijentAmbulantni(int matbr)
        {
            AmbulantniBasic o = new AmbulantniBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Ambulantni pacijent = s.Load<Ambulantni>(matbr);

                o.Mat_br = pacijent.Mat_br_pac;
                o.Ime = pacijent.Ime_pac;
                o.Prezime = pacijent.Prezime_pac;
                o.Ulica = pacijent.Ulica;
                o.Broj = pacijent.Broj;

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;
        }
        public static List<AmbulantniPregled> vratiSveAmbulantne()
        {
            List<AmbulantniPregled> pacijenti = new List<AmbulantniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Bolnica.Entiteti.Ambulantni> ambulantni = from o in s.Query<Bolnica.Entiteti.Ambulantni>()
                                                                      select o;

                foreach (Bolnica.Entiteti.Ambulantni r in ambulantni)
                {
                    pacijenti.Add(new AmbulantniPregled(r.Mat_br_pac, r.Ime_pac, r.Prezime_pac, r.Ulica, r.Broj.ToString()));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pacijenti;
        }
        /* Veza 1:N sa lekarom opste prakse
        public static List<PacijentBasic> GetOdInfos(int prodavnicaId)
        {
            List<OdeljenjeBasic> odInfos = new List<OdeljenjeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Odeljenje> odeljenja = from o in s.Query<Odeljenje>()
                                                   where o.PripadaProdavnici.Id == prodavnicaId
                                                   select o;

                foreach (Odeljenje o in odeljenja)
                {
                    odInfos.Add(new OdeljenjeBasic(o.Id, o.Lokacija, o.PripadaProdavnici.Naziv, o.ProdajeSeProizvod.Count));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }*/
        /*
        public static List<OdeljenjeDo5Pregled> vratiOdeljenjaDo5Prodavnice(int prodavnicaId)
        {
            List<OdeljenjeDo5Pregled> odInfos = new List<OdeljenjeDo5Pregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<OdeljenjeDo5> odeljenja = from o in s.Query<OdeljenjeDo5>()
                                                      where o.PripadaProdavnici.Id == prodavnicaId
                                                      select o;

                foreach (OdeljenjeDo5 o in odeljenja)
                {
                    odInfos.Add(new OdeljenjeDo5Pregled(o.Id, o.Lokacija, o.BrojKasa, o.InfoPult));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }*/
        public static void izmeniAmbulantni(AmbulantniBasic pacijent)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Ambulantni o = s.Load<Ambulantni>(pacijent.Mat_br);

                o.Ime_pac = pacijent.Ime;
                o.Prezime_pac = pacijent.Prezime;
                o.Ulica = pacijent.Ulica;
                o.Broj = pacijent.Broj;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajAmbulantni(AmbulantniBasic pacijent)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Ambulantni o = new Bolnica.Entiteti.Ambulantni();

                o.Ime_pac = pacijent.Ime;
                o.Prezime_pac = pacijent.Prezime;
                o.Ulica = pacijent.Ulica;
                o.Broj = pacijent.Broj;
                //Bolnica.Entiteti.Prodavnica p = s.Load<Prodavnica.Entiteti.Prodavnica>(odeljenje.Prodavnica.Id);
                //o.PripadaProdavnici = p;

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion

        #region Stacionarni
        public static void obrisiStacionarni(int matbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Stacionarni pacijent = s.Load<Stacionarni>(matbr);

                s.Delete(pacijent);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static StacionarniBasic vratiPacijentStacionarni(int matbr)
        {
            StacionarniBasic o = new StacionarniBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Stacionarni pacijent = s.Load<Stacionarni>(matbr);

                o.Mat_br = pacijent.Mat_br_pac;
                o.Ime = pacijent.Ime_pac;
                o.Prezime = pacijent.Prezime_pac;
                o.Datum_prijema = pacijent.Datum_prijema;
                o.Datum_otpusta = pacijent.Datum_otpusta;

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;
        }
        public static List<StacionarniPregled> vratiSveStacionarne()
        {
            List<StacionarniPregled> pacijenti = new List<StacionarniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Bolnica.Entiteti.Stacionarni> stacionarni = from o in s.Query<Bolnica.Entiteti.Stacionarni>()
                                                                        select o;

                foreach (Bolnica.Entiteti.Stacionarni r in stacionarni)
                {
                    pacijenti.Add(new StacionarniPregled(r.Mat_br_pac, r.Ime_pac, r.Prezime_pac, r.Datum_prijema, r.Datum_otpusta));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pacijenti;
        }
        public static List<StacionarniBasic> GetInfoStacionarniLekar(int medicinsko)
        {
            List<StacionarniBasic> odInfos = new List<StacionarniBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Stacionarni> stacionarni = from o in s.Query<Stacionarni>()
                                                       where o.Pripada_Lekaru_Specijalisti.MatBr == medicinsko
                                                       select o;

                foreach (Stacionarni o in stacionarni)
                {
                    //fali ime i prezime lekara specijaliste
                    odInfos.Add(new StacionarniBasic(o.Mat_br_pac, o.Ime_pac, o.Prezime_pac, o.Datum_prijema, o.Datum_otpusta));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniStacionarni(StacionarniBasic pacijent)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Stacionarni o = s.Load<Stacionarni>(pacijent.Mat_br);

                o.Ime_pac = pacijent.Ime;
                o.Prezime_pac = pacijent.Prezime;
                o.Datum_prijema = pacijent.Datum_prijema;
                o.Datum_otpusta = pacijent.Datum_otpusta;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void sacuvajStacionarni(StacionarniBasic pacijent)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Stacionarni o = new Bolnica.Entiteti.Stacionarni();

                o.Ime_pac = pacijent.Ime;
                o.Prezime_pac = pacijent.Prezime;
                o.Datum_prijema = pacijent.Datum_prijema;
                o.Datum_otpusta = pacijent.Datum_otpusta;
                //Bolnica.Entiteti.Prodavnica p = s.Load<Prodavnica.Entiteti.Prodavnica>(odeljenje.Prodavnica.Id);
                //o.PripadaProdavnici = p;

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static List<LeziNaBasic> vratiSveLeziNa(int matBr)
        {
            List<LeziNaBasic> leziNa = new List<LeziNaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Bolnica.Entiteti.Lezi_na> sviStacionarni = from o in s.Query<Bolnica.Entiteti.Lezi_na>()
                                                                       where o.Stacionarnis.Mat_br_pac == matBr
                                                                       select o;

                foreach (Bolnica.Entiteti.Lezi_na r in sviStacionarni)
                {
                    StacionarniBasic pacijent = DTOManager.vratiPacijentStacionarni(r.Stacionarnis.Mat_br_pac);
                    OdeljenjeBasic odeljenje = DTOManager.vratiOdeljenje(r.Odeljenja.Sifra);
                    leziNa.Add(new LeziNaBasic(r.Mat_br, pacijent, odeljenje, r.Vreme_pocetka));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return leziNa;
        }
        #endregion
        #endregion

        #region Osoblje

        /*public static List<OsobljePregled> vratiSvaOsoblja()
        {
            List<OsobljePregled> proizvodi = new List<OsobljePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                /*IEnumerable<Bolnica.Entiteti.Osoblje> svaOsoblja = from o in s.Query<Prodavnica.Entiteti.Proizvod>()
                                                                         select o;

                foreach (Prodavnica.Entiteti.Proizvod p in sviProizvodi)
                {
                    proizvodi.Add(new ProizvodPregled(p.BarKod, p.Tip, p.Naziv, p.Proizvodjac));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return proizvodi;
        }*/

        #endregion

        #region Medicinsko
        /*public static List<OsobljeBasic> vratiSvaOsobljaBasic()  ///VEZAA!!!
    {
        List<OsobljaBasic> prodaja = new List<OsobljaBasic>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Osoblje> osoblja = from o in s.Query<Bolnica.Entiteti.Osoblje>()
                                              select o;

            foreach (Osoblje p in osoblja)
            {
                OsobljeBasic osoblje = DTOManager.vratiOsoblje(p.MatBr);
                prodaja.Add(osoblje);
            }

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return prodaja;

    }*/
        /*
    public static List<ProdajeSeBasic> vratiProizvodeOdeljenjaDo5(int odeljenjeId)
    {
        List<ProdajeSeBasic> prodaja = new List<ProdajeSeBasic>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<ProdajeSe> proizvodi = from o in s.Query<Prodavnica.Entiteti.ProdajeSe>()
                                               where o.ProdajeOdeljenje.Id == odeljenjeId
                                               select o;

            foreach (ProdajeSe p in proizvodi)
            {
                ProizvodBasic proizvod = DTOManager.vratiProizvod(p.ProdajeProzivod.BarKod);
                OdeljenjeDo5Basic odeljenje = DTOManager.vratiOdeljenjeDo5(p.ProdajeOdeljenje.Id);
                prodaja.Add(new ProdajeSeBasic(p.Id, proizvod, odeljenje));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return prodaja;
    }*/
        /*
    public static void obrisiOsoblje(int matbr)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Bolnica.Entiteti.Osoblje r = s.Load<Bolnica.Entiteti.Osoblje>(matbr);

            s.Delete(r);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }
    }

    public static ProizvodBasic vratiProizvod(int id)
    {
        ProizvodBasic rb = new ProizvodBasic();
        try
        {
            ISession s = DataLayer.GetSession();

            Prodavnica.Entiteti.Proizvod p = s.Load<Prodavnica.Entiteti.Proizvod>(id);
            rb = new ProizvodBasic(p.BarKod, p.Tip, p.Naziv, p.Proizvodjac);

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return rb;
    }

    public static OdeljenjeDo5Basic vratiOdeljenjeDo5(int id)
    {
        OdeljenjeDo5Basic pb = new OdeljenjeDo5Basic();
        try
        {
            ISession s = DataLayer.GetSession();

            Prodavnica.Entiteti.OdeljenjeDo5 o = s.Load<Prodavnica.Entiteti.OdeljenjeDo5>(id);
            pb = new OdeljenjeDo5Basic(o.Id, o.Lokacija, o.PripadaProdavnici.Naziv, o.BrojKasa);

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return pb;
    }

    public static OdeljenjeOd6Do15Basic vratiOdeljenjeOd6Do15(int id)
    {
        OdeljenjeOd6Do15Basic pb = new OdeljenjeOd6Do15Basic();
        try
        {
            ISession s = DataLayer.GetSession();

            Prodavnica.Entiteti.OdeljenjeOd6Do15 o = s.Load<Prodavnica.Entiteti.OdeljenjeOd6Do15>(id);
            pb = new OdeljenjeOd6Do15Basic(o.Id, o.Lokacija, o.PripadaProdavnici.Naziv, o.BrojKasa);

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return pb;
    }

    public static OdeljenjeOdrasliBasic vratiOdeljenjeOdrasli(int id)
    {
        OdeljenjeOdrasliBasic pb = new OdeljenjeOdrasliBasic();
        try
        {
            ISession s = DataLayer.GetSession();

            Prodavnica.Entiteti.OdeljenjeOdrasli o = s.Load<Prodavnica.Entiteti.OdeljenjeOdrasli>(id);
            pb = new OdeljenjeOdrasliBasic(o.Id, o.Lokacija, o.PripadaProdavnici.Naziv, o.BrojKasa);

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return pb;
    }
    */

        public static void sacuvajMedicinsko(MedicinskoBasic medicinsko)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Medicinsko v = new Bolnica.Entiteti.Medicinsko();

                v.Ime = medicinsko.Ime;
                v.Prezime = medicinsko.Prezime;
                v.Radni_staz = medicinsko.Radni_staz;
                v.Tip_lekara = medicinsko.TipLekara;
                v.Broj_ordinacije = medicinsko.BrOrdinacije;
                v.Specijalnost = medicinsko.Specijalnost;

                s.Save(v);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static MedicinskoBasic vratiMedicinsko(int matbr)
        {
            MedicinskoBasic rb = new MedicinskoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Medicinsko ip = s.Load<Bolnica.Entiteti.Medicinsko>(matbr);
                rb = new MedicinskoBasic(ip.MatBr, ip.Ime, ip.Prezime, ip.Radni_staz, ip.Tip_lekara, ip.Broj_ordinacije, ip.Specijalnost);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return rb;
        }

        public static MedicinskoBasic izmeniMedicinsko(MedicinskoBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Medicinsko ip = s.Load<Bolnica.Entiteti.Medicinsko>(r.Mat_br);

                ip.Ime = r.Ime;
                ip.Prezime = r.Prezime;
                ip.Radni_staz = r.Radni_staz;
                ip.Broj_ordinacije = r.BrOrdinacije;
                ip.Specijalnost = r.Specijalnost;

                s.Update(ip);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return r;
        }
        public static void obrisiOsobljeIzSistema(int matbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Osoblje p = s.Load<Bolnica.Entiteti.Osoblje>(matbr);
                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion

        #region Nemedicinsko
        /*public static List<OsobljeBasic> vratiSvaOsobljaBasic()  ///VEZAA!!!
    {
        List<OsobljaBasic> prodaja = new List<OsobljaBasic>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Osoblje> osoblja = from o in s.Query<Bolnica.Entiteti.Osoblje>()
                                              select o;

            foreach (Osoblje p in osoblja)
            {
                OsobljeBasic osoblje = DTOManager.vratiOsoblje(p.MatBr);
                prodaja.Add(osoblje);
            }

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return prodaja;

    }*/
        /*
    public static List<ProdajeSeBasic> vratiProizvodeOdeljenjaDo5(int odeljenjeId)
    {
        List<ProdajeSeBasic> prodaja = new List<ProdajeSeBasic>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<ProdajeSe> proizvodi = from o in s.Query<Prodavnica.Entiteti.ProdajeSe>()
                                               where o.ProdajeOdeljenje.Id == odeljenjeId
                                               select o;

            foreach (ProdajeSe p in proizvodi)
            {
                ProizvodBasic proizvod = DTOManager.vratiProizvod(p.ProdajeProzivod.BarKod);
                OdeljenjeDo5Basic odeljenje = DTOManager.vratiOdeljenjeDo5(p.ProdajeOdeljenje.Id);
                prodaja.Add(new ProdajeSeBasic(p.Id, proizvod, odeljenje));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return prodaja;
    }*/
        /*
    public static void obrisiOsoblje(int matbr)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Bolnica.Entiteti.Osoblje r = s.Load<Bolnica.Entiteti.Osoblje>(matbr);

            s.Delete(r);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }
    }

    public static ProizvodBasic vratiProizvod(int id)
    {
        ProizvodBasic rb = new ProizvodBasic();
        try
        {
            ISession s = DataLayer.GetSession();

            Prodavnica.Entiteti.Proizvod p = s.Load<Prodavnica.Entiteti.Proizvod>(id);
            rb = new ProizvodBasic(p.BarKod, p.Tip, p.Naziv, p.Proizvodjac);

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return rb;
    }

    public static OdeljenjeDo5Basic vratiOdeljenjeDo5(int id)
    {
        OdeljenjeDo5Basic pb = new OdeljenjeDo5Basic();
        try
        {
            ISession s = DataLayer.GetSession();

            Prodavnica.Entiteti.OdeljenjeDo5 o = s.Load<Prodavnica.Entiteti.OdeljenjeDo5>(id);
            pb = new OdeljenjeDo5Basic(o.Id, o.Lokacija, o.PripadaProdavnici.Naziv, o.BrojKasa);

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return pb;
    }

    public static OdeljenjeOd6Do15Basic vratiOdeljenjeOd6Do15(int id)
    {
        OdeljenjeOd6Do15Basic pb = new OdeljenjeOd6Do15Basic();
        try
        {
            ISession s = DataLayer.GetSession();

            Prodavnica.Entiteti.OdeljenjeOd6Do15 o = s.Load<Prodavnica.Entiteti.OdeljenjeOd6Do15>(id);
            pb = new OdeljenjeOd6Do15Basic(o.Id, o.Lokacija, o.PripadaProdavnici.Naziv, o.BrojKasa);

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return pb;
    }

    public static OdeljenjeOdrasliBasic vratiOdeljenjeOdrasli(int id)
    {
        OdeljenjeOdrasliBasic pb = new OdeljenjeOdrasliBasic();
        try
        {
            ISession s = DataLayer.GetSession();

            Prodavnica.Entiteti.OdeljenjeOdrasli o = s.Load<Prodavnica.Entiteti.OdeljenjeOdrasli>(id);
            pb = new OdeljenjeOdrasliBasic(o.Id, o.Lokacija, o.PripadaProdavnici.Naziv, o.BrojKasa);

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return pb;
    }
    */

        public static void sacuvajNemedicinsko(NemedicinskoBasic nemedicinsko)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Nemedicinsko v = new Bolnica.Entiteti.Nemedicinsko();

                v.Ime = nemedicinsko.Ime;
                v.Prezime = nemedicinsko.Prezime;
                v.TipOdrzavanja = nemedicinsko.TipOdrzavanja;
                v.Struka = nemedicinsko.Struka;

                s.Save(v);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static NemedicinskoBasic vratiNemedicinsko(int matbr)
        {
            NemedicinskoBasic rb = new NemedicinskoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Nemedicinsko ip = s.Load<Bolnica.Entiteti.Nemedicinsko>(matbr);
                rb = new NemedicinskoBasic(ip.MatBr, ip.Ime, ip.Prezime, ip.TipOdrzavanja, ip.Struka);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return rb;
        }

        public static NemedicinskoBasic izmeniNemedicinsko(NemedicinskoBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Nemedicinsko ip = s.Load<Bolnica.Entiteti.Nemedicinsko>(r.Mat_br);

                ip.Ime = r.Ime;
                ip.Prezime = r.Prezime;
                ip.Struka = r.Struka;

                s.Update(ip);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return r;
        }
        #endregion
    }


}