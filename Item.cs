using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

 class Item
    {
        public string name { get; private set; }
        public string numberd { get; set; }
        public DateTime DateStart { get; private set; }
        public DateTime DateEnd { get; private set; }
        public string dolg { get; private set; }
        public string dostkredit { get; private set; }

        public Item(string str)
        {
            const string inputDateFormat = "yyyy,MM,dd";
            IFormatProvider formatProvider = CultureInfo.InvariantCulture;

            string[] parts = str.Split(';');
            name = parts[0];
            numberd = parts[1];
            
            DateStart = DateTime.ParseExact(parts[2], inputDateFormat, formatProvider);
            DateEnd = DateTime.ParseExact(parts[3], inputDateFormat, formatProvider);
            dolg = parts[4];
        }
    }