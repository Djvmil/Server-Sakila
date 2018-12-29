using ServerSakila.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerSakila
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceSakila" à la fois dans le code et le fichier de configuration.
    public class ServiceSakila : IServiceSakila
    {
        BdContext bd = new BdContext();
        public void AjoutActeur(Actor act)
        {
            try
            {
                bd.Actors.Add(act);
                bd.SaveChanges();

            }
            catch (Exception)
            {
                throw;

            }
        }

        public void FindActor(string nomacteur)
        {
            Actor act = new Actor();

            act = bd.Actors.Where(a => a.FirstName.Equals(nomacteur)).FirstOrDefault();
            if (act != null)
            {
                act.FirstName = nomacteur;
                bd.Actors.Add(act);
                bd.SaveChanges();
            }



        }

        public List<Actor> GetList()
        {
            return bd.Actors.ToList();
        }
        public void Add(Address adr)
        {
            try
            {
                bd.Addresses.Add(adr);
                bd.SaveChanges();

            }
            catch (Exception)
            {
                throw;

            }


        }

        public Address Find(string phone)
        {
            return bd.Addresses.Where(a => a.Phone.Equals(phone)).FirstOrDefault();
        }

        public List<Address> listerAdresse()
        {
            return bd.Addresses.ToList();
        }
        public void AddCat(Category cat)
        {
            try
            {
                bd.Categories.Add(cat);
                bd.SaveChanges();

            }
            catch (Exception)
            {
                throw;

            }

        }

        public void Findcat(string nom)
        {
            Category cat = new Category();
            cat = bd.Categories.Where(a => a.Name.Equals(nom)).FirstOrDefault();
            if (cat != null)
            {
                cat.Name = nom;
                bd.Categories.Add(cat);
                bd.SaveChanges();
            }
        }

        public List<Category> GetListCat()
        {
            return bd.Categories.ToList();
        }
        public City Ajoutcity(City cit)
        {



            try
            {
                bd.Cities.Add(cit);
                bd.SaveChanges();

            }
            catch (Exception)
            {
                throw;

            }
            return cit;
        }

        public List<City> GetListCity()
        {
            return bd.Cities.ToList();
        }

        public Country AddCountry(Country con)
        {
            try
            {
                bd.Countries.Add(con);
                bd.SaveChanges();

            }
            catch (Exception)
            {
                throw;

            }
            return con;
        }
        public List<Country> GetListCountry()
        {
            return bd.Countries.ToList();
        }

        public void Addcustomer(Customer client)
        {
            bd.Customers.Add(client);
            bd.SaveChanges();
        }
        public void Find(int Idfilm)
        {
            Film film = new Film();
            film = bd.Films.Where(x => x.Id.Equals(Idfilm)).FirstOrDefault();
            if (film != null)
            {
                bd.Films.Add(film);
                bd.SaveChanges();
            }

        }

        public List<Film> GetListFilm()
        {
            return bd.Films.ToList();

        }

        public void Add(List<Film_Actor> film_Actors)
        {

            foreach (Film_Actor fa in film_Actors)
            {
                bd.Film_Actors.Add(fa);

            }
            bd.SaveChanges();
        }

        public List<Film_Actor> GetListFilm_Actor()
        {
            return bd.Film_Actors.ToList();
        }

        public void Add(List<Film_Category> film_Category)
        {
            foreach (Film_Category fC in film_Category)
            {
                bd.film_Categories.Add(fC);

            }
            bd.SaveChanges();
        }

        public List<Film_Category> GetListFilm_Categorie()
        {
            return bd.film_Categories.ToList();
        }

        public void Add(List<Inventory> inventories)
        {
            foreach (Inventory fC in inventories)
            {
                bd.Inventories.Add(fC);

            }
            bd.SaveChanges();
        }

        public List<Inventory> GetListInventory()
        {
            return bd.Inventories.ToList();
        }

        public void Add(Language lang)
        {
            bd.Languages.Add(lang);
            bd.SaveChanges();
        }

        public List<Language> GetListLanguage()
        {
            return bd.Languages.ToList();
        }

        public void Add(Store store)
        {
            bd.Stores.Add(store);
            bd.SaveChanges();
        }

        public void Find()
        {

        }

        public List<Store> GetListStore()
        {
            return bd.Stores.ToList();
        }
    }
}
