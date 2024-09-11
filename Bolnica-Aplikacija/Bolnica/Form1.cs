using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bolnica.Entiteti;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;


namespace Bolnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Bolnica.Entiteti.Odeljenje p = s.Load<Bolnica.Entiteti.Odeljenje>(666);

                MessageBox.Show(p.Tip);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdReadSmena_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Bolnica.Entiteti.Smena p = s.Load<Bolnica.Entiteti.Smena>(1);

                MessageBox.Show(p.Tip_smene);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdCreateSmena_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Smena p = new Entiteti.Smena();

                p.Tip_smene = "Nocna";
               
                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdManyToOneOdeljenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o Odeljenju za zadatim brojem
                //Stomatoloska_stolica --2.slucaj
                Odeljenje o = s.Load<Odeljenje>(555);
            
                //Proizvodjac stolice i Struka tehnickog odrzavanja   --2.slucaj
                MessageBox.Show(o.Tip);
                MessageBox.Show(o.Pripada_Specijalisti.Specijalnost);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdOneToManyOdeljenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //podaci o Nemedicinskom osoblju
                Bolnica.Entiteti.Medicinsko p = s.Load<Bolnica.Entiteti.Medicinsko>(013);

                //trazimo Stolicu tog Tehnicara
                foreach (Odeljenje o in p.Odeljenja)
                {
                    //vrsta + datum
                    MessageBox.Show(o.Tip + " " + o.Datum_izgradnje);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Medicinsko p = new Entiteti.Medicinsko()
                {
                    Ime = "Milos",
                    Prezime = "Cikic",
                    Radni_staz = 25,
                    Tip_lekara = "LEKAR_SPECIJALISTA",
                    Broj_ordinacije = 0,
                    Specijalnost = "Ortopedija"
                };

                Odeljenje o = new Odeljenje()
                {
                    //Sifra = 777,
                    Tip = "Hirurgija",
                    Datum_izgradnje = new DateTime(2009,10,12)
                };

                Odeljenje o1 = new Odeljenje()
                {
                    //Sifra = 222,
                    Tip = "Maksilofacijalna",
                    Datum_izgradnje = new DateTime(2004, 11, 29)
                };

                s.Save(p);

                //POVEZIVANJE IZMEDJU OVOG TEHNICARA I OVE DVE STOLICE 1:N

                o.Pripada_Specijalisti = p;
                s.Save(o);

                o1.Pripada_Specijalisti = p;
                s.Save(o1);

                p.Odeljenja.Add(o);
                p.Odeljenja.Add(o1);

                s.Save(p);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Stomatoloska_stolica o = s.Load<Stomatoloska_stolica>("Castellini skema"); //trebalo bi da radi, PROVERI OPET
           
                MessageBox.Show(o.Proizvodjac);
                MessageBox.Show(o.Pripada_tehnickom_osoblju.Ime + " " + o.Pripada_tehnickom_osoblju.Prezime + " " + o.Pripada_tehnickom_osoblju.MatBr);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Nemedicinsko p = s.Load<Bolnica.Entiteti.Nemedicinsko>(023);

                foreach (Stomatoloska_stolica o in p.Stomatoloske_Stolice)
                {
                    MessageBox.Show(o.Proizvodjac + " " + o.Datum_proizvodnje);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdCreateStomatoloskaStolica_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Nemedicinsko p = new Entiteti.Nemedicinsko()
                {
                    Ime = "Milica",
                    Prezime = "Mitrovic",
                    TipOdrzavanja = "TEHNICKO_ODRZAVANJE",
                    Struka = "SREDNJA STRUCNA"
                };

                Stomatoloska_stolica o = new Stomatoloska_stolica()
                {
                    Proizvodjac = "Jugodent",
                    Datum_proizvodnje= new DateTime(1999, 10, 25)
                };

                Stomatoloska_stolica o1 = new Stomatoloska_stolica()
                {
                    Proizvodjac = "KaVo",
                    Datum_proizvodnje = new DateTime(2016, 11, 11)
                };

                s.Save(p);

                //POVEZIVANJE IZMEDJU OVOG TEHNICARA I OVE DVE STOLICE 1:N

                o.Pripada_tehnickom_osoblju = p;
                s.Save(o);

                o1.Pripada_tehnickom_osoblju = p;
                s.Save(o1);

                p.Stomatoloske_Stolice.Add(o);
                p.Stomatoloske_Stolice.Add(o1);

                s.Save(p);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdManyToOnePacijent_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pacijent o = s.Load<Pacijent>(30);

                MessageBox.Show(o.Ime_pac + " " + o.Prezime_pac);
                MessageBox.Show(o.Pripada_Lekaru_Opste_prakse.Ime + " " + o.Pripada_Lekaru_Opste_prakse.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdOneToManyPacijent_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Medicinsko p = s.Load<Bolnica.Entiteti.Medicinsko>(7);

                foreach (Pacijent o in p.Pacijenti)
                {
                    MessageBox.Show(o.Ime_pac + " " + o.Prezime_pac + " " + o.Mat_br_pac);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdManyToOneStacionarni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Stacionarni o = s.Load<Stacionarni>(28);

                MessageBox.Show("Pacijent: "+ o.Ime_pac + " " + o.Prezime_pac);
                MessageBox.Show("Lekar specijalista: " + o.Pripada_Lekaru_Specijalisti.Ime + " " + o.Pripada_Lekaru_Specijalisti.Prezime);


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdOneToManyStacionarni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolnica.Entiteti.Medicinsko p = s.Load<Bolnica.Entiteti.Medicinsko>(012);

                foreach (Stacionarni o in p.Stacionarnis)
                {
                    MessageBox.Show(o.Ime_pac + " " + o.Prezime_pac + " " + o.Mat_br_pac + " " + o.Datum_prijema);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdCreatePacijenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Medicinsko p1 = new Entiteti.Medicinsko()
                {
                    Ime = "Milorad",
                    Prezime = "Radovanovic",
                    Radni_staz = 25,
                    Tip_lekara = "LEKAR_OPSTE_PRAKSE",
                    Broj_ordinacije = 11,
                    Specijalnost = "Ortopedija"
                };

                Entiteti.Medicinsko p2 = new Entiteti.Medicinsko()
                {
                    Ime = "Anita",
                    Prezime = "Krstanovic",
                    Radni_staz = 19,
                    Tip_lekara = "LEKAR_SPECIJALISTA",
                    Broj_ordinacije = 0,
                    Specijalnost = "Ortopedija"
                };

                Stacionarni o = new Stacionarni()
                {
                    Ime_pac = "Veselinka",
                    Prezime_pac = "Stojkovic",
                    //Ulica = null,
                    //Broj = 0,
                    Datum_prijema = new DateTime(2019, 10, 12),
                    Datum_otpusta = new DateTime(2019, 10, 22)
                };

                s.Save(p1);
                s.Save(p2);

                o.Pripada_Lekaru_Opste_prakse = p1;
                s.Save(o);

                o.Pripada_Lekaru_Specijalisti = p2;
                s.Save(o);

                p1.Stacionarnis.Add(o);
                p2.Stacionarnis.Add(o);

                s.Save(p1);
                s.Save(p2);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdTPCMedicinsko_Click(object sender, EventArgs e)
        {
            //prikazivanje Medicinskog osoblja
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Osoblje> osoblja = s.QueryOver<Osoblje>()
                                                .Where(p => p.MatBr == 3)
                                                .List<Osoblje>();

                Medicinsko v = (Medicinsko)osoblja[0];

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdTPCNemedicinsko_Click(object sender, EventArgs e)
        {
            //prikazivanje Nemedicinskog osoblja
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Osoblje> osoblja = s.QueryOver<Osoblje>()
                                                .Where(p => p.MatBr == 019)
                                                .List<Osoblje>();

                Nemedicinsko v = (Nemedicinsko)osoblja[0];

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdCreateMedicinsko_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Medicinsko v = new Medicinsko();

                v.Ime = "Zeljko";
                v.Prezime = "Joksimovic";

                v.Radni_staz = 14;
                v.Tip_lekara = "STOMATOLOG";
                v.Broj_ordinacije = 0;
                v.Specijalnost = null;

                s.Save(v);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdCreateNemedicinsko_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nemedicinsko v = new Nemedicinsko();

                v.Ime = "Olivera";
                v.Prezime = "Nikolic";

                v.TipOdrzavanja = "HIGIJENICAR";
                v.Struka = null;

                s.Save(v);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdTPCHPacijent_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Pacijent> pacijenti = s.QueryOver<Pacijent>()
                                                .List<Pacijent>();

                foreach (Pacijent o in pacijenti)
                {
                    if (o.GetType() == typeof(Ambulantni))
                    {
                        Ambulantni aa = (Ambulantni)o;
                    }
                    else
                    {
                        Stacionarni ss = (Stacionarni)o;
                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdCreateSubclassPacijent_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Odeljenje p = s.Load<Entiteti.Odeljenje>(111);

                //kolona TIP automatski dobija vrednost STACIONARNI
                Stacionarni o1 = new Stacionarni()
                {
                    Ime_pac = "Milena",
                    Prezime_pac = "Jankovic",
                    Datum_prijema = new DateTime(2022, 1, 10),
                    Datum_otpusta = new DateTime(2022, 1, 20),
                    //Odeljenja = p
                };

                s.Save(o1);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdGetPacijent_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pacijent o = s.Get<Pacijent>(31);

                if (o != null)
                {
                    MessageBox.Show(o.Ime_pac + " " + o.Prezime_pac);
                }
                else
                {
                    MessageBox.Show("Ne postoji odeljenje sa zadatim identifikatorom");
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdlezina_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Stacionarni r = s.Load<Stacionarni>(27);
                Entiteti.Odeljenje p = s.Load<Entiteti.Odeljenje>(666);

                Entiteti.Lezi_na c = new Entiteti.Lezi_na()
                {
                    Vreme_pocetka = new DateTime(2010,10,12)
                };

                c.Stacionarnis = r;

                c.Odeljenja = p;

                c.Stacionarnis.Leze_na_odeljenju.Add(c);
                c.Odeljenja.Leze_stacionarni.Add(c);

                s.Save(c);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdCreateOdrzavaHigijenuNa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nemedicinsko r = s.Load<Nemedicinsko>(62);
                Entiteti.Odeljenje p = s.Load<Entiteti.Odeljenje>(888);

                Entiteti.Odrzava_higijenu_na c = new Entiteti.Odrzava_higijenu_na()
                {
                    Vreme_odrzavanja = new DateTime(2022, 10, 12)
                };

                c.Higijenicar = r;

                c.Odeljenja = p;

                c.Higijenicar.Odrzavaju_higijenu.Add(c);
                c.Odeljenja.Odrzavaju_odeljenja.Add(c);

                s.Save(c);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdCreateRadiNa_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    Medicinsko r = s.Load<Medicinsko>(63);
            //    Entiteti.Stomatoloska_stolica p = s.Load<Entiteti.Stomatoloska_stolica>("StomatoloskaStolica");
            //    Entiteti.Smena a = s.Load<Entiteti.Smena>(2);

            //    Entiteti.Radi_na c = new Entiteti.Radi_na()
            //    {

            //    };

            //    c.Stomatolog = r;

            //    c.StomatoloskaStolica = p;

            //    c.Smena = a;


            //    c.Smena.Stomatolozi_rade.Add(c);
            //    c.StomatoloskaStolica.Rade_u_smeni.Add(c);
            //    c.Stomatolog.Rade_u_smeni.Add(c);

            //    s.Save(c);

            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }
        private void cmdCreateObavlja_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    Medicinsko r = s.Load<Medicinsko>(64);
            //    Entiteti.Ambulantni p = s.Load<Entiteti.Ambulantni>(23);
            //    Entiteti.Intervencija a = s.Load<Entiteti.Intervencija>("Pozlacivanje zuba");

            //    Entiteti.Obavlja c = new Entiteti.Obavlja()
            //    {
            //        Vreme_intervencije = new DateTime(2022, 11, 13)
            //    };

            //    c.Stomatolog = r;

            //    c.AmbulantniPacijent = p;

            //    c.Intervencija = a;

            //    c.AmbulantniPacijent.Intervencije.Add(c);
            //    c.Intervencija.Nad_ambulatnim.Add(c);
            //    c.Stomatolog.ObavljaIntervenciju.Add(c);

            //    s.Save(c);

            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pacijent o = s.Get<Pacijent>(32);

                //obrada podataka o odeljenju

                s.Refresh(o);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdFind1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Pacijent");

                IList<Pacijent> pacijenti = q.List<Pacijent>();

                foreach (Pacijent o in pacijenti)
                {
                    MessageBox.Show(o.Ime_pac + " " + o.Prezime_pac);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdQuery1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Odeljenja koja nemaju info pult
                IQuery q = s.CreateQuery("from Pacijent as o where o.Tip_pacijenta = 'AMBULANTNI'");

                IList<Pacijent> pacijenti = q.List<Pacijent>();

                foreach (Pacijent o in pacijenti)
                {
                    MessageBox.Show(o.Mat_br_pac + " " + o.Ime_pac + "" + o.Prezime_pac + " " + o.Ulica + " " + o.Broj);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdQueryParameters_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Paramterizovani upit
                IQuery q = s.CreateQuery("from Pacijent as o where o.Tip_pacijenta = ?");
                q.SetParameter(0, "STACIONARNI");
                //q.SetInt32(1, 1);

                IList<Pacijent> pacijenti = q.List<Pacijent>();

                foreach (Pacijent o in pacijenti)
                {
                    MessageBox.Show(o.Mat_br_pac + " " + o.Ime_pac + " " + o.Prezime_pac + " " + o.Datum_otpusta);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdQueryNamedParamters_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Paramterizovani upit
                IQuery q = s.CreateQuery("select o.Pripada_Specijalisti from Odeljenje as o "
                                        + " where o.Tip = :tip");
                q.SetString("tip", "Nefrologija");

                IList<Entiteti.Medicinsko> lekari_specijalisti = q.List<Entiteti.Medicinsko>();

                foreach (Entiteti.Medicinsko p in lekari_specijalisti)
                {
                    MessageBox.Show(p.Ime + " " + p.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdQueryNamedParameters1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Paramterizovani upit
                IQuery q = s.CreateQuery("select o.Pripada_Specijalisti from Odeljenje as o "
                                        + " where o.Tip = :tip"
                                        + " and o.Pripada_Specijalisti.Specijalnost = :specijalnost");
                q.SetString("tip", "Kardiologija");
                q.SetString("specijalnost", "Kardiologija");

                IList<Entiteti.Medicinsko> lekari_specijalisti = q.List<Entiteti.Medicinsko>();

                foreach (Entiteti.Medicinsko p in lekari_specijalisti)
                {
                    MessageBox.Show(p.Ime + " " + p.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void smdEnumerable_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Pacijent");

                IEnumerable<Pacijent> pacijenti = q.Enumerable<Pacijent>();

                foreach (Pacijent o in pacijenti)
                {
                    if (o.Broj == 0)
                        break;
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdScalar_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select sum(o.Radni_staz) from Medicinsko o ");

                //za slucaj da upit vraca samo jednu vrednost
                Int64 radniStaz = q.UniqueResult<Int64>();

                MessageBox.Show(radniStaz.ToString());

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUnique_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select o from Medicinsko o where o.Matbr = 5 ");

                //za slucaj da upit vraca samo jednu vrednost
                Medicinsko o = q.UniqueResult<Medicinsko>();

                MessageBox.Show(o.Ime + " " + o.Prezime + " " + o.Tip_lekara);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdMultiple_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    IQuery q = s.CreateQuery("select o.Tip_lekara, sum(o.Broj_ordinacije), count(o) from Medicinsko o "
            //                            + " group by o.Tip_lekara ");

            //    //za slucaj da upit vraca visestruku vrednost
            //    IList<object[]> result = q.List<object[]>();

            //    foreach (object[] r in result)
            //    {
            //        string Ime = (string)r[0];
            //        string Prezime = (string)r[0];
            //        Int64 Broj_ordinacije = (Int64)r[1];
            //        long broj = (long)r[2];

            //        MessageBox.Show(Ime + " " + broj.ToString() + " " + kase.ToString());
            //    }

            //    s.Close();

            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }

        private void cmdPaging_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Odeljenje");
                q.SetFirstResult(5);
                q.SetMaxResults(5);

                IList<Odeljenje> odeljenja = q.List<Odeljenje>();

                foreach (Odeljenje o in odeljenja)
                {
                    MessageBox.Show(o.Sifra.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCriteria_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<Medicinsko>();

                c.Add(Expression.Ge("Radni_staz", 15));
                c.Add(Expression.Eq("Tip_lekara", "LEKAR_OPSTE_PRAKSE"));

                IList<Medicinsko> lekari_opste_prakse = c.List<Medicinsko>();

                foreach (Medicinsko o in lekari_opste_prakse)
                {
                    MessageBox.Show(o.MatBr + " " + o.Ime + " " + o.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdQueryOver_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Medicinsko> lekari_specijalist = s.QueryOver<Medicinsko>()
                                                .Where(x => x.Radni_staz >= 15)
                                                .Where(x => x.Tip_lekara == "LEKAR_SPECIJALISTA")
                                                .List<Medicinsko>();

                foreach (Medicinsko o in lekari_specijalist)
                {
                    MessageBox.Show(o.MatBr + " " + o.Ime + " " + o.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdSQL_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM PACIJENT O");
                q.AddEntity(typeof(Pacijent));


                IList<Pacijent> pacijenti = q.List<Pacijent>();

                foreach (Pacijent o in pacijenti)
                {
                    MessageBox.Show(o.Mat_br_pac.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje o = s.Load<Odeljenje>(5);

                //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije
                s.Close();

                //objekat se modifikuje potpuno nezavisno od sesije
                o.Tip = "Psihijatrija";

                //otvara se nova sesija
                ISession s1 = DataLayer.GetSession();

                //poziva se Update i objekat se povezuje sa novom sesijom
                s1.Update(o);

                s1.Flush();
                s1.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje o = s.Load<Odeljenje>(6);

                //brise se objekat iz baze ali ne i instanca objekta u memoriji
                s.Delete(o);
                //s.Delete("from Odeljenje");

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdTransaction_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje o = s.Load<Odeljenje>(7);

                ITransaction t = s.BeginTransaction();

                s.Delete(o);

                //t.Commit();
                t.Rollback();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLINQ_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Medicinsko> specijalisti = (from o in s.Query<Medicinsko>()
                                              where (o.Radni_staz >= 20 && o.Tip_lekara == "LEKAR_SPECIJALISTA")
                                              select o).ToList<Medicinsko>();

                foreach (Medicinsko o in specijalisti)
                {
                    MessageBox.Show(o.MatBr + " " + o.Ime + " " + o.Prezime);
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLINQ1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Medicinsko> medicinsko = from p in s.Query<Medicinsko>()
                                                  where (p.Tip_lekara == "LEKAR_SPECIJALISTA" || p.Tip_lekara == "lEKAR_OPSTE_PRAKSE")
                                                  orderby p.Tip_lekara, p.Radni_staz
                                                  select p;

                foreach (Medicinsko p in medicinsko)
                {
                    MessageBox.Show(p.Radni_staz.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLINQ2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Medicinsko> medicinskaOsoblja = s.Query<Medicinsko>()
                                                    .Where(p => (p.Tip_lekara == "LEKAR_OPSTE_PRAKSE" || p.Tip_lekara == "STOMATOLOG"))
                                                    .OrderBy(p => p.Tip_lekara).ThenBy(p => p.Radni_staz)
                                                    .Select(p => p);

                foreach (Medicinsko p in medicinskaOsoblja)
                {
                    MessageBox.Show(p.Radni_staz.ToString());
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button_dtoexample1_Click(object sender, EventArgs e)
        {
            //OdeljenjaInformacije odInfoForm = new OdeljenjaInformacije(61);

            // odInfoForm.Show();
        }
    }
}
