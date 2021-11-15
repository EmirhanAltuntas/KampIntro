using MyGameProject.Abstract;
using MyGameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Adapters
{
    class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(
                    gamer.NationalityId),
                    gamer.FirstName.ToUpper(),
                    gamer.LastName.ToUpper(),
                    gamer.DateOfBirth.Year)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
