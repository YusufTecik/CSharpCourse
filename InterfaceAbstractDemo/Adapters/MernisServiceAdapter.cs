﻿using InterfaceAbstractDemo.Abstarct;
using InterfaceAbstractDemo.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody
                (Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
    
}

