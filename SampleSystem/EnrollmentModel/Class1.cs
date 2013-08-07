using System.Collections.Generic;

namespace EnrollmentModel
{
    public class OfferCatalogBuilder
    {
        private Location _location = new Location();
        private CommodityType _commodityType;
        private UtilityProvider _utilityProvider;
        private IList<string> _personalCodes = new List<string>();

        public OfferCatalog GetOffers()
        {
            return new OfferCatalog()
            {
                Offers = new List<Offer>(new[]
                {
                    new Offer()
                    {
                        Plan = new Plan("BGE", "24", new Price(5.98m, UoM.CentkWh))
                    }
                })
            };
        }

        public void SetZipCode(string zipCode)
        {
            _location.SetZipCode(zipCode);
        }

    }

    internal class Location
    {
        private string _zipCode = "";

        public void SetZipCode(string zipCode)
        {
            _zipCode = zipCode;
        }
    }

    public class UtilityProvider
    {
        private readonly string _udcCode;

        public UtilityProvider(string udcCode)
        {
            _udcCode = udcCode;
        }

        public string UdcCode
        {
            get { return _udcCode; }
        }
    }

    public class OfferCatalog
    {
        public IList<UtilityProvider> UtilityProviders { get; set; }
        public IList<Offer> Offers { get; set; }
        public bool OffersReady { get; set; }
        public IList<CommodityType> CommodityTypes { get; set; }
    }

    public enum CommodityType
    {
        Gas, Electricity, HomeService, Solar
    }

    public enum UoM
    {
        CentkWh
    }

    public class Offer
    {
        public Plan Plan { get; set; }
    }

    public class Plan
    {
        public Plan(string utility, string term, Price price)
        {

        }
    }

    public class Price
    {
        private readonly decimal _value;
        private readonly UoM _unitOfMeasure;

        public Price(decimal value, UoM unitOfMeasure)
        {
            _value = value;
            _unitOfMeasure = unitOfMeasure;
        }
    }


}
