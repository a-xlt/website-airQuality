using System;

namespace website_airQuality.Models
{
    public class ViewData
    {
        public int Id { get; set; }
        public DateTime time { get; set; }
        public int Humd { get; set; }
        public int Temp { get; set; }
        public int Tvoc { get; set; }
        public int Co2 { get; set; }
        public double Dust { get; set; }
        public int O3 { get; set; }

    }
}
