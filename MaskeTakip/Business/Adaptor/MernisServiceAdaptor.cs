using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adaptor
{
    public class MernisServiceAdaptor : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdenity, person.FirstName, person.LastName, person.DateOdBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
