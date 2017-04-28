using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KavyaStockTrading.Models
{
    public class StockInfo
    {
        public string Symbol { get; set; }
        public decimal AverageVolume { get; set; }

        public decimal LastTradedPrice { get; set; }

    }

    public static class YahooFinance
    {

        public static List<StockInfo> Parse(string CSVdata)
        {

            try
            {
                List<StockInfo> stockinfo = new List<StockInfo>();
                string[] rows = CSVdata.Replace("r", "").Replace("\"", "").Split('\n');



            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }



    public class Rootobject
    {
        public MetaData MetaData { get; set; }
        public TimeSeries1Min TimeSeries1min { get; set; }
    }

    public class MetaData
    {
        public string _1Information { get; set; }
        public string _2Symbol { get; set; }
        public string _3LastRefreshed { get; set; }
        public string _4Interval { get; set; }
        public string _5OutputSize { get; set; }
        public string _6TimeZone { get; set; }
    }

    public class TimeSeries1Min
    {
        public _20170426160000 _20170426160000 { get; set; }
      
    }

    public class _20170426160000
    {
        public string _1open { get; set; }
        public string _2high { get; set; }
        public string _3low { get; set; }
        public string _4close { get; set; }
        public string _5volume { get; set; }
    }

      

}