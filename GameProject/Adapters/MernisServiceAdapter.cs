using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamer.Tc, gamer.FirstName, gamer.LastName, gamer.DateOfBirth).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }

        //public bool Validate(Gamer gamer)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
