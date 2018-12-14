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
        [OperationContract]
        void Afficher<T>(T a);

      /*  [OperationContract]
        Adresse Add(Adresse adr);*/
    }
}

