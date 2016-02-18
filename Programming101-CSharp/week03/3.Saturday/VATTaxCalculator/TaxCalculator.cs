using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
    public class TaxCalculator
    {
        private readonly List<CountryVatTax> countries;

        public TaxCalculator(List<CountryVatTax> countries)
        {
            this.countries = new List<CountryVatTax>(countries.Count);
            foreach (var country in countries)
            {
                this.countries.Add(country);
            }
        }

        public double CalculateTax(double itemPrice, int countryId)
        {
            foreach (var country in countries)
            {
                if (country.CountryId == countryId)
                {
                    return itemPrice + itemPrice * country.VATTax;
                }
            }

            throw new NotSupportedCountryException("ID not found in the calculator database!");
        }

        public double CalculateTax(double itemPrice)
        {
            foreach (var country in countries)
            {
                if (country.IsDefault)
                {
                    return itemPrice + itemPrice * country.VATTax;
                }
            }

            throw new NotSupportedCountryException("No default country in calculator database!");
        }
    }

    public class NotSupportedCountryException : Exception
    {
        public NotSupportedCountryException()
        {

        }

        public NotSupportedCountryException(string message)
            : base(message)
        {

        }
    }
}
