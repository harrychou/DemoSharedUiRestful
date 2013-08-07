using System.Collections.Generic;
using System.Web.Http;
using EnrollmentModel;

namespace EnrollmentWebApi.Controllers
{
    public class OfferCatalogController : ApiController
    {
        // GET api/default1
        public OfferCatalog Get(string zip = "", string commodity = "", string udc = "")
        {
            if (!string.IsNullOrEmpty(udc))
            {
                return new OfferCatalog()
                           {
                               Offers = new List<Offer>(
                                    new []
                                        {
                                            new Offer()
                                                {
                                                    Plan = new Plan("BGE", "12", new Price(5.23m, UoM.CentkWh))
                                                },
                                            new Offer()
                                                {
                                                    Plan = new Plan("BGE", "6", new Price(6.23m, UoM.CentkWh))
                                                }
                                        }
                                   )
                           };
            }
            if (!string.IsNullOrEmpty(commodity))
            {
                return new OfferCatalog()
                {
                    UtilityProviders = new List<UtilityProvider> (
                        new []
                            {
                                new UtilityProvider("BGE"),
                                new UtilityProvider("ABC")
                            }
                    )
                };
            }
            return new OfferCatalog();
        }

        // GET api/default1/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/default1
        public void Post([FromBody]string value)
        {
        }

        // PUT api/default1/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/default1/5
        public void Delete(int id)
        {
        }
    }
}
