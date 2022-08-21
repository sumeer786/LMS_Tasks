using System;
namespace FancyItemLibrary
{
    public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _basePrice;
        private double _gst = 8;

        public Hat(string shortname, string longname, double baseprice)
        {
            _shortName = shortname;
            _longName = longname;
            _basePrice = baseprice;
        }

        public string GetShortName
        {
            get { return _shortName; }
        }

        public string GetLongName
        {
            get { return _longName; }
        }

        public double GetPrice
        {
            get { return _basePrice + (_basePrice * _gst) / 100;}
        }
    }
}
