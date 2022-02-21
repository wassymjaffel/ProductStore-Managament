using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PS.Service
{
    public class ManageProvider
    {
        public List<Provider> Providers { get; set; }
        public List<Provider> GetProviderByName(String name)
        {
            return (from prov in Providers 
                   where prov.UserName.Contains(name) 
                   select prov).ToList();
        }

        public Provider GetFirstProviderByName(String name)
        {
            return (from prov in Providers
                    where prov.UserName.Contains(name)
                    select prov).FirstOrDefault();
        }
        public Provider GetProviderById(int id)
        {
            return  (from prov in Providers
                    where prov.Id==id
                    select prov).SingleOrDefault();
        }
    }
}
