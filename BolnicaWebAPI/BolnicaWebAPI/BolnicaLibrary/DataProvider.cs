using NHibernate;
using NHibernate.Event.Default;
using System.Web;

namespace BolnicaLibrary;

public static class DataProvider
{
    #region Odeljenja

    public static async Task<Result<List<OdeljenjeView>, string>> VratiSvaOdeljenjaAsync()
    {
        List<OdeljenjeView> data = new();

        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            data = (await s.QueryOver<Odeljenje>().ListAsync())
                           .Select(p => new OdeljenjeView(p)).ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o odeljenjima.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }
    public async static Task<Result<OdeljenjeView, string>> AzurirajOdeljenjeAsync(OdeljenjeView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Odeljenje o = s.Load<Odeljenje>(p.Sifra);
            o.Tip = p.Tip;
            o.Datum_izgradnje = p.Datum_izgradnje;

            await s.UpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati odeljenje.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return p;
    }

    public async static Task<Result<bool, string>> IzmeniOdeljenjeAsync(OdeljenjeView odeljenje)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Odeljenje o = await s.LoadAsync<Odeljenje>(odeljenje.Sifra);

            o.Tip = odeljenje.Tip;
            o.Datum_izgradnje = odeljenje.Datum_izgradnje;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti odeljenje.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<OdeljenjeView, string>> VratiOdeljenjeAsync(int sifra)
    {
        ISession? s = null;

        OdeljenjeView odeljenjeView = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Odeljenje o = await s.LoadAsync<Odeljenje>(sifra);
            odeljenjeView = new OdeljenjeView(o);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti odeljenje sa zadatom SIFROM.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odeljenjeView;
    }

    public async static Task<Result<bool, string>> ObrisiOdeljenjeAsync(int sifra)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Odeljenje o = await s.LoadAsync<Odeljenje>(sifra);

            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati odeljenje.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<int, string>> SacuvajOdeljenjeBezSpecijalisteAsync(OdeljenjeView odeljenje)
    {
        ISession? s = null;
        int sifra = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Odeljenje o = new()
            {
                Tip = odeljenje.Tip,
                Datum_izgradnje = odeljenje.Datum_izgradnje
            };

            await s.SaveAsync(o);
            await s.FlushAsync();

            sifra = o.Sifra;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati odeljenje bez specijaliste.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return sifra;
    }


    //METODE KOJE IMAJU VEZE SA DODAVANJEM VEZE 1:N kod odeljenja i Medicinskog osoblja i Nemedicnskog osoblja
    //ova metoda NE RADI LEPO!
    public static Result<List<OdeljenjeView>, string> GetOdeljenjeInfos(int medicinskoId)
    {
        ISession? s = null;
        List<OdeljenjeView> odInfos = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            IEnumerable<Odeljenje> odeljenja = from o in s.Query<Odeljenje>()
                                               where o.Pripada_Specijalisti != null && o.Pripada_Specijalisti.MatBr == medicinskoId
                                               select o;

            foreach (Odeljenje o in odeljenja)
            {
                odInfos.Add(new OdeljenjeView(o));
            }

        }
        catch (Exception)
        {
            return "Nemoguće pronaći odeljenja ili pripadajućeg lekara specijalistu, tj medicinsko osoblje.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }

    //METODA ZA VRACANJE ODELJENJA I LEKARA SPECIJALISTA, metoda za vezu, NE RADI!
    public static Result<List<OdeljenjeView>, string> VratiOdeljenjaSpecijaliste(int medicinskoId)
    {
        ISession? s = null;
        List<OdeljenjeView> odInfos = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            IEnumerable<Odeljenje> odeljenja = from o in s.Query<Odeljenje>()
                                                  where o.Pripada_Specijalisti != null && o.Pripada_Specijalisti.MatBr == medicinskoId
                                                  select o;

            odInfos = odeljenja.Select(o => new OdeljenjeView(o, o.Pripada_Specijalisti)).ToList();

        }
        catch (Exception)
        {
            return "Nemoguće pronaći odeljenja koja pripadaju specijalisti.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }


    public async static Task<Result<bool, string>> PoveziOdeljenjeISpecijalistuAsync(int odeljenjeID, int specijalistaID)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Odeljenje odeljenje = await s.LoadAsync<Odeljenje>(odeljenjeID);
            Medicinsko specijalista = await s.LoadAsync<Medicinsko>(specijalistaID);

            odeljenje.Pripada_Specijalisti = specijalista;

            await s.UpdateAsync(odeljenje);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće povezati odeljenje sa specijalistom.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, string>> SacuvajOdeljenjeAsync(OdeljenjeView odeljenje, int idSpecijaliste)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Odeljenje o = new();
            Medicinsko p = await s.LoadAsync<Medicinsko>(idSpecijaliste);

            o.Tip = odeljenje.Tip;
            o.Datum_izgradnje = odeljenje.Datum_izgradnje;
            o.Pripada_Specijalisti = p;

            await s.SaveAsync(o);
            await s.FlushAsync();
            odeljenje.Sifra = o.Sifra;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati odeljenje.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    //treba da se doda i veza 1:N sa higijenicarom koji odrzava to odeljenje, ako ovo proradi, samo copy-paste
    #endregion

    #region Stomatoloske stolice

    public static Result<List<Stomatoloska_stolicaView>, string> VratiSveStolice()
    {
        ISession? s = null;

        List<Stomatoloska_stolicaView> stolice = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            IEnumerable<Stomatoloska_stolica> sveStolice = from o in s.Query<Stomatoloska_stolica>()
                                                    select o;

            foreach (Stomatoloska_stolica p in sveStolice)
            {
                stolice.Add(new Stomatoloska_stolicaView(p));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve stomatoloske stolice.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return stolice;
    }

    public async static Task<Result<bool, string>> DodajStolicuAsync(Stomatoloska_stolicaView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stomatoloska_stolica o = new()
            {
                Proizvodjac = p.Proizvodjac,
                Datum_proizvodnje = p.Datum_proizvodnje
            };

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati stomatolosku stolicu.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<Stomatoloska_stolicaView, string>> AzurirajStolicuAsync(Stomatoloska_stolicaView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stomatoloska_stolica o = s.Load<Stomatoloska_stolica>(p.Proizvodjac);
            o.Datum_proizvodnje = p.Datum_proizvodnje;

            await s.UpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati stomatolosku stolicu.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return p;
    }

    public async static Task<Result<Stomatoloska_stolicaView, string>> VratiStolicuAsync(string proizvodjac)
    {
        ISession? s = null;

        Stomatoloska_stolicaView stolicaView = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stomatoloska_stolica o = await s.LoadAsync<Stomatoloska_stolica>(proizvodjac);
            stolicaView = new Stomatoloska_stolicaView(o);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti stomatolosku stolicu sa zadatim proizvodjacem.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return stolicaView;
    }

    public async static Task<Result<bool, string>> ObrisiStolicuAsync(string proizvodjac)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stomatoloska_stolica o = await s.LoadAsync<Stomatoloska_stolica>(proizvodjac);

            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati stomatolosku stolicu.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region Pacijent
    public static async Task<Result<List<PacijentView>, string>> VratiPacijenteAsync()
    {
        List<PacijentView> data = new();

        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            data = (await s.QueryOver<Pacijent>().ListAsync())
                           .Select(p => new PacijentView(p)).ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o odeljenjima.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }
    public async static Task<Result<bool, string>> ObrisiPacijentaAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Pacijent pacijent = await s.LoadAsync<Pacijent>(id);

            await s.DeleteAsync(pacijent);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja pacijenta.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<PacijentView, string>> VratiPacijentaAsync(int id)
    {
        ISession? s = null;
        PacijentView o = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Pacijent pacijent = await s.LoadAsync<Pacijent>(id);

            o.Mat_br = pacijent.Mat_br_pac;
            o.Ime = pacijent.Ime_pac;
            o.Prezime = pacijent.Prezime_pac;
        }
        catch (Exception)
        {
            return "Nemoguće vratiti pacijenta.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return o;
    }
    public async static Task<Result<bool, string>> IzmeniPacijentaAsync(PacijentView pacijent)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Pacijent o = await s.LoadAsync<Pacijent>(pacijent.Mat_br);

            o.Ime_pac = pacijent.Ime;
            o.Prezime_pac = pacijent.Prezime;


            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti pacijenta.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    public async static Task<Result<int, string>> SacuvajStacionarnogPacijentaBezLekaraAsync(StacionarniView pacijent)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stacionarni o = new()
            {
                Ime_pac = pacijent.Ime,
                Prezime_pac = pacijent.Prezime,
                Datum_otpusta=pacijent.Datum_otpusta,
                Datum_prijema=pacijent.Datum_prijema
            };

            await s.SaveAsync(o);
            await s.FlushAsync();

            id = o.Mat_br_pac;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati pacijenta bez lekara.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }
    public async static Task<Result<bool, string>> PoveziStacionarnogILekaraAsync(int pacijentId, int lekarId)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stacionarni pacijent = await s.LoadAsync<Stacionarni>(pacijentId);
            Medicinsko lekar = await s.LoadAsync<Medicinsko>(lekarId);

            pacijent.Pripada_Lekaru_Opste_prakse = lekar;

            await s.UpdateAsync(pacijent);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće povezati pacijenta sa lekarom.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    public async static Task<Result<bool, string>> PoveziStacionarnogISpecijalistuAsync(int pacijentId, int lekarId)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stacionarni pacijent = await s.LoadAsync<Stacionarni>(pacijentId);
            Medicinsko lekar = await s.LoadAsync<Medicinsko>(lekarId);

            pacijent.Pripada_Lekaru_Specijalisti = lekar;

            await s.UpdateAsync(pacijent);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće povezati pacijenta sa specijalistom.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #region Ambulantni

    public async static Task<Result<AmbulantniView, string>> VratiAmbulantnogAsync(int id)
    {
        ISession? s = null;
        AmbulantniView o = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Ambulantni ambulantni = await s.LoadAsync<Ambulantni>(id);

            o.Ime = ambulantni.Ime_pac;
            o.Prezime = ambulantni.Prezime_pac;
            o.Broj = ambulantni.Broj;
            o.Mat_br = ambulantni.Mat_br_pac;
            o.Ulica = ambulantni.Ulica;
        }
        catch (Exception)
        {
            return "Nemoguće vratiti ambulantnog pacijenta.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return o;
    }
    public static Result<List<PacijentView>, string> GetOdInfos(int medicinskoId)
    {
        ISession? s = null;
        List<PacijentView> odInfos = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            IEnumerable<Pacijent> pacijenti = from o in s.Query<Pacijent>()
                                              where o.Pripada_Lekaru_Opste_prakse != null && o.Pripada_Lekaru_Opste_prakse.MatBr == medicinskoId
                                              select o;


            foreach (Pacijent o in pacijenti)
            {
                odInfos.Add(new PacijentView(o));
            }

        }
        catch (Exception)
        {
            return "Nemoguće pronaći pacijente ili pripadajućeg lekara opste prakse.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return odInfos;
    }
    //public static Result<List<AmbulantniView>, string> VratiAmbulantnogLekare(int medicinskoId)
    //{
    //    ISession? s = null;
    //    List<AmbulantniView> odInfos = new();

    //    try
    //    {
    //        s = DataLayer.GetSession();

    //        if (!(s?.IsConnected ?? false))
    //        {
    //            return "Nemoguće otvoriti sesiju.";
    //        }

    //        IEnumerable<Ambulantni> ambulantni= from o in s.Query<Ambulantni>()
    //                                              where o.Pripada_Lekaru_Opste_prakse != null && o.Pripada_Lekaru_Opste_prakse.MatBr == medicinskoId
    //                                              select o;

    //        odInfos = ambulantni.Select(o => new AmbulantniView(o, o.Pripada_Lekaru_Opste_prakse)).ToList();

    //    }
    //    catch (Exception)
    //    {
    //        return "Nemoguće pronaći pacijenta koja pripadaju lekaru opste prakse.";
    //    }
    //    finally
    //    {
    //        s?.Close();
    //        s?.Dispose();
    //    }

    //    return odInfos;
    //}
    public async static Task<Result<bool, string>> IzmeniAmbulantnogAsync(AmbulantniView ambulantni)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Ambulantni o = await s.LoadAsync<Ambulantni>(ambulantni.Mat_br);

            o.Broj = ambulantni.Broj;
            o.Ulica = ambulantni.Ulica;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti ambulantnog.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    public async static Task<Result<int, string>> SacuvajAmbulantnogBezLekaraAsync(AmbulantniView ambulantni)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Ambulantni o = new()
            {
                Ime_pac = ambulantni.Ime,
                Prezime_pac = ambulantni.Prezime,
                Broj = ambulantni.Broj,
                Ulica = ambulantni.Ulica
            };

            await s.SaveAsync(o);
            await s.FlushAsync();

            id = o.Mat_br_pac;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati ambulantni bez lekara.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }
    public async static Task<Result<bool, string>> PoveziAmbulantnogILekaraAsync(int ambulantniId, int lekarId)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Ambulantni ambulantni = await s.LoadAsync<Ambulantni>(ambulantniId);
            Medicinsko medicinsko = await s.LoadAsync<Medicinsko>(lekarId);

            ambulantni.Pripada_Lekaru_Opste_prakse = medicinsko;

            await s.UpdateAsync(ambulantni);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće povezati pacijenta sa lekarom.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    public async static Task<Result<bool, string>> ObrisiAmbulantnogAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Ambulantni ambulantni = await s.LoadAsync<Ambulantni>(id);

            await s.DeleteAsync(ambulantni);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja pacijenta.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, string>> SacuvajAmbulantnogAsync(AmbulantniView ambulantni, int idLekara)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Ambulantni o = new();
            Medicinsko p = await s.LoadAsync<Medicinsko>(idLekara);

            o.Ime_pac = ambulantni.Ime;
            o.Prezime_pac = ambulantni.Prezime;
            o.Broj = ambulantni.Broj;
            o.Ulica = ambulantni.Ulica;
            o.Pripada_Lekaru_Opste_prakse = p;

            await s.SaveAsync(o);
            await s.FlushAsync();
            ambulantni.Mat_br = o.Mat_br_pac;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati ambulantnog.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    #endregion

    #region Stacionarni
    public async static Task<Result<bool, string>> ObrisiStacionarnogAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stacionarni stacionarni = await s.LoadAsync<Stacionarni>(id);

            await s.DeleteAsync(stacionarni);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja pacijenta.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    public async static Task<Result<StacionarniView, string>> VratiStacionarnogAsync(int id)
    {
        ISession? s = null;
        StacionarniView o = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stacionarni stacionarni = await s.LoadAsync<Stacionarni>(id);

            o.Ime = stacionarni.Ime_pac;
            o.Prezime = stacionarni.Prezime_pac;
            o.Datum_prijema = stacionarni.Datum_prijema;
            o.Datum_otpusta = stacionarni.Datum_prijema;
            o.Mat_br = stacionarni.Mat_br_pac;

        }
        catch (Exception)
        {
            return "Nemoguće vratiti stacionarnog pacijenta.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return o;
    }
    public async static Task<Result<bool, string>> IzmeniStacionarnogAsync(StacionarniView stacionarni)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stacionarni o = await s.LoadAsync<Stacionarni>(stacionarni.Mat_br);

            o.Ime_pac = stacionarni.Ime;
            o.Prezime_pac = stacionarni.Prezime;
            o.Datum_prijema = stacionarni.Datum_prijema;
            o.Datum_otpusta = stacionarni.Datum_otpusta;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti stacionarnog.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    public async static Task<Result<int, string>> SacuvajStacionarnogBezLekaraAsync(StacionarniView stacionarni)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stacionarni o = new()
            {
                Ime_pac = stacionarni.Ime,
                Prezime_pac = stacionarni.Prezime,
                Datum_otpusta = stacionarni.Datum_otpusta,
                Datum_prijema = stacionarni.Datum_prijema
            };

            await s.SaveAsync(o);
            await s.FlushAsync();

            id = o.Mat_br_pac;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati stacionarnog bez lekara.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }
    public async static Task<Result<int, string>> SacuvajStacionarnogBezSpecijalisteAsync(StacionarniView stacionarni)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stacionarni o = new()
            {
                Ime_pac = stacionarni.Ime,
                Prezime_pac = stacionarni.Prezime,
                Datum_otpusta = stacionarni.Datum_otpusta,
                Datum_prijema = stacionarni.Datum_prijema
            };

            await s.SaveAsync(o);
            await s.FlushAsync();

            id = o.Mat_br_pac;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati stacionarnog bez lekara.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }
    public async static Task<Result<bool, string>> SacuvajStacionarnogAsync(StacionarniView stacionarni, int idLekara)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Stacionarni o = new();
            Medicinsko p = await s.LoadAsync<Medicinsko>(idLekara);

            o.Ime_pac = stacionarni.Ime;
            o.Prezime_pac = stacionarni.Prezime;
            o.Datum_prijema = stacionarni.Datum_prijema;
            o.Datum_otpusta = stacionarni.Datum_otpusta;
            o.Pripada_Lekaru_Opste_prakse = p;

            await s.SaveAsync(o);
            await s.FlushAsync();
            stacionarni.Mat_br = o.Mat_br_pac;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati stacionarnog.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    #endregion
    #endregion

    #region Osoblje
    public static Result<List<OsobljeView>, string> VratiSvaOsoblja()
    {
        List<OsobljeView> osoblje = new();



        try
        {
            ISession? s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            IEnumerable<Osoblje> svaOsoblja = from o in s.Query<Osoblje>()
                                              select o;



            foreach (Osoblje p in svaOsoblja)
            {
                osoblje.Add(new OsobljeView(p));
            }



            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti osoblje.";
        }



        return osoblje;
    }
    #endregion

    #region Medicinsko
    public static Result<List<MedicinskoView>, string> VratiSvaMedicinska()
    {
        List<MedicinskoView> osoblje = new();



        try
        {
            ISession? s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            IEnumerable<Medicinsko> svaOsoblja = from o in s.Query<Medicinsko>()
                                                 select o;



            foreach (Medicinsko p in svaOsoblja)
            {
                osoblje.Add(new MedicinskoView(p));
            }



            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti medicinsko osoblje.";
        }



        return osoblje;
    }
    public async static Task<Result<bool, string>> ObrisiMedicinskoAsync(int id)
    {
        ISession? s = null;



        try
        {
            s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            Medicinsko medicinsko = await s.LoadAsync<Medicinsko>(id);



            await s.DeleteAsync(medicinsko);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja medicinskog.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }



        return true;
    }
    public async static Task<Result<MedicinskoView, string>> VratiMedicinskuOsobuAsync(int id)
    {
        ISession? s = null;
        MedicinskoView o = default!;



        try
        {
            s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            Medicinsko medicinsko = await s.LoadAsync<Medicinsko>(id);



            o.Mat_br = medicinsko.MatBr;
            o.Ime = medicinsko.Ime;
            o.Prezime = medicinsko.Prezime;
            o.Radni_staz = medicinsko.Radni_staz;
        }
        catch (Exception)
        {
            return "Nemoguće vratiti medicinsko.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }



        return o;
    }
    public async static Task<Result<bool, string>> IzmeniMedicinskoAsync(MedicinskoView medicinsko)
    {
        ISession? s = null;



        try
        {
            s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            Medicinsko o = await s.LoadAsync<Medicinsko>(medicinsko.Mat_br);



            o.Ime = medicinsko.Ime;
            o.Prezime = medicinsko.Prezime;
            o.Radni_staz = medicinsko.Radni_staz;



            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti medicinsko osoblje.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }



        return true;
    }
    public static Result<bool, string> DodajMedicinsko(MedicinskoView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            Medicinsko o = new()
            {
                MatBr = r.Mat_br,
                Ime = r.Ime,
                Prezime = r.Prezime,
                Radni_staz = r.Radni_staz,
                Tip_lekara = r.TipLekara,
                Broj_ordinacije = r.BrOrdinacije,
                Specijalnost = r.Specijalnost
            };



            s.SaveOrUpdate(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;



            return "Nemoguće dodati medicinsko.";
        }



        return true;
    }
    #endregion

    #region Nemedicinsko
    public static Result<List<NemedicinskoView>, string> VratiSvaNemedicinska()
    {
        List<NemedicinskoView> osoblje = new();



        try
        {
            ISession? s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            IEnumerable<Nemedicinsko> svaOsoblja = from o in s.Query<Nemedicinsko>()
                                                   select o;



            foreach (Nemedicinsko p in svaOsoblja)
            {
                osoblje.Add(new NemedicinskoView(p));
            }



            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti nemedicinsko osoblje.";
        }



        return osoblje;
    }
    public async static Task<Result<bool, string>> ObrisiNemedicinskoAsync(int id)
    {
        ISession? s = null;



        try
        {
            s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            Nemedicinsko nemedicinsko = await s.LoadAsync<Nemedicinsko>(id);



            await s.DeleteAsync(nemedicinsko);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja nemedicinskog.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }



        return true;
    }

    public async static Task<Result<NemedicinskoView, string>> VratiNemedicinskuOsobuAsync(int id)
    {
        ISession? s = null;
        NemedicinskoView o = default!;



        try
        {
            s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            Nemedicinsko nemedicinsko = await s.LoadAsync<Nemedicinsko>(id);



            o.Mat_br = nemedicinsko.MatBr;
            o.Ime = nemedicinsko.Ime;
            o.Prezime = nemedicinsko.Prezime;
            o.TipOdrzavanja = nemedicinsko.TipOdrzavanja;
            o.Struka = nemedicinsko.Struka;
        }
        catch (Exception)
        {
            return "Nemoguće vratiti nemedicinsko.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }



        return o;
    }
    public async static Task<Result<bool, string>> IzmeniNemedicinskoAsync(NemedicinskoView nemedicinsko)
    {
        ISession? s = null;



        try
        {
            s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            Nemedicinsko o = await s.LoadAsync<Nemedicinsko>(nemedicinsko.Mat_br);



            o.Ime = nemedicinsko.Ime;
            o.Prezime = nemedicinsko.Prezime;
            o.Struka = nemedicinsko.Struka;
            o.TipOdrzavanja = nemedicinsko.TipOdrzavanja;




            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti nemedicinsko osoblje.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }



        return true;
    }
    public static Result<bool, string> DodajNemedicinsko(NemedicinskoView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            Nemedicinsko o = new()
            {
                MatBr = r.Mat_br,
                Ime = r.Ime,
                Prezime = r.Prezime,
                Struka = r.Struka,
                TipOdrzavanja = r.TipOdrzavanja
            };



            s.SaveOrUpdate(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;



            return "Nemoguće dodati nemedicinsko.";
        }



        return true;
    }
    #endregion

    #region LeziNa
    public async static Task<Result<bool, string>> SacuvajLeziNaAsync(LeziNaView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Lezi_na a = new()
            {
                Stacionarnis = await s.LoadAsync<Stacionarni>(p.StacionarniLezi?.Mat_br),
                Odeljenja = await s.LoadAsync<Odeljenje>(p.LeziNaOdeljenju?.Sifra)
            };

            await s.SaveAsync(a);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati vezu stacionarnog pacijenta i odeljenja na kome lezi pacijent.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    #endregion

    #region OdrzavaHigijenuNa
    public async static Task<Result<bool, string>> SacuvajOdrzavaHigijenuNaAsync(OdrzavaHigijenuNaView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Odrzava_higijenu_na a = new()
            {
                Higijenicar = await s.LoadAsync<Nemedicinsko>(p.HigijenicarOdrzava?.Mat_br),
                Odeljenja = await s.LoadAsync<Odeljenje>(p.OdrzavaOdeljenje?.Sifra)
            };

            await s.SaveAsync(a);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati vezu odeljenja i higijenicara koji odrzava to odeljenje.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    #endregion

    #region Smena
    public static Result<List<SmenaView>, string> VratiSmene()
    {
        List<SmenaView> smene = new();

        try
        {
            ISession? s = DataLayer.GetSession();



            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }



            IEnumerable<Smena> sveSmene = from o in s.Query<Smena>()
                                                 select o;



            foreach (Smena p in sveSmene)
            {
                smene.Add(new SmenaView(p));
            }



            s.Close();
        }
        catch (Exception)
        {
            //handle exceptions
            //throw;
            return "Nemoguće vratiti medicinsko osoblje.";
        }



        return smene;
    }
    public async static Task<Result<bool, string>> DodajSmenuAsync(SmenaView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Smena o = new()
            {
                Tip_smene = p.Tip_smene
            };

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati smenu.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<SmenaView, string>> AzurirajSmenuAsync(SmenaView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Smena o = s.Load<Smena>(p.Id);
            o.Tip_smene = p.Tip_smene;

            await s.UpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati smenu.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return p;
    }

    public async static Task<Result<SmenaView, string>> VratiSmenuAsync(int id)
    {
        ISession? s = null;

        SmenaView smenaView = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Smena o = await s.LoadAsync<Smena>(id);
            smenaView = new SmenaView(o);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti smenu sa zadatim id-ijem.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return smenaView;
    }

    public async static Task<Result<bool, string>> ObrisiSmennuAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.";
            }

            Smena o = await s.LoadAsync<Smena>(id);

            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati smenu.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    #endregion
}