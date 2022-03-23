using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

class Uslugi 
{
    public string nameS { get; private set; }
    public string codeS { get; private set; }
    public string tarifS { get; private set; }
    public string timeS { get; private set; }

    public Uslugi(string str) 
    {
        string[] parts = str.Split(',');
        nameS = parts[0];
        codeS = parts[1];
        tarifS = parts[2];
        timeS = parts[3];
    }
}