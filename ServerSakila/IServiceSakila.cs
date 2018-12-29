using ServerSakila.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace ServerSakila
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceSakila" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceSakila
    {
        //Fonction Acteur
        [OperationContract]
        void AjoutActeur(Actor act);
        [OperationContract]
        void FindActor(string nomacteur);
        [OperationContract]
        List<Actor> GetList();
        //Fonction adresse
        [OperationContract]
        void Add(Address adr);

        [OperationContract]
        Address Find(string phone);

        [OperationContract]
        List<Address> listerAdresse();


        [OperationContract]
        void AddCat(Category cat);

        [OperationContract]
        void Findcat(string nom);

        [OperationContract]
        List<Category> GetListCat();

        [OperationContract]
        City Ajoutcity(City cit);
        [OperationContract]
        List<City> GetListCity();

        [OperationContract]
        Country AddCountry(Country con);
        [OperationContract]
        List<Country> GetListCountry();

        [OperationContract]
        void Addcustomer(Customer client);

        [OperationContract]
        void Find(int Idfilm);
        [OperationContract]
        List<Film> GetListFilm();

        [OperationContract]
        void Add(List<Film_Actor> film_Actors);
        [OperationContract]
        List<Film_Actor> GetListFilm_Actor();

        [OperationContract]
        void Add(List<Film_Category> film_Category);

        [OperationContract]
        List<Film_Category> GetListFilm_Categorie();

        [OperationContract]
        void Add(List<Inventory> inventories);

        [OperationContract]
        List<Inventory> GetListInventory();

        [OperationContract]
        void Add(Language lang);
        [OperationContract]
        List<Language> GetListLanguage();

        [OperationContract]
        void Add(Store store);
        [OperationContract]
        void Find();
        [OperationContract]
        List<Store> GetListStore();
    }
}

