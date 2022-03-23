using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

class Ispol
{
    public string numberdIS { get; private set; }
    public string codeSIS { get; private set; }
    public DateTime DateEndIS { get; private set; }
    public string timeSIS { get; private set; }
    

    public Ispol(string str) 
    {  
        const string inputDateFormat = "yyyy,MM,dd";
        IFormatProvider formatProvider = CultureInfo.InvariantCulture;

        string[] parts = str.Split(';');
        numberdIS = parts[0];
        codeSIS = parts[1];
        DateEndIS = DateTime.ParseExact(parts[2], inputDateFormat, formatProvider);
        timeSIS = parts[3];

        
    }
}
