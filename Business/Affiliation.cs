using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Affiliation
    {
        public void CreateNewAffliation(DAV2.Affiliation affiliation) {

            using (DAV2.MAP_DB context = new DAV2.MAP_DB()) {

                affiliation.Business = new DAV2.Business {
                    DTIRegDate= DateTime.Now,LegalName="Business"
                   
                };
                context.Affiliation.Add(affiliation);

                context.SaveChanges();

            }
        }
    }
}
