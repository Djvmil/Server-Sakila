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
        BdContext bdc = new BdContext();



/*
        public <T> Affiche<T>(T a)
        {
            Console.WriteLine("Afficheur d'objet :");
            Console.WriteLine("\tType : " + a.GetType());
            Console.WriteLine("\tReprésentation : " + a.ToString());
        }

       
        public Adresse Add(Adresse adr)
        {
            try
            {
                bdc.Adresses.Add(adr);
                bdc.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return adr;
        }*/
    }
}
