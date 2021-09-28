using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace GPTB1.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string id)
        {
            string numPart, strPart, newKey = "", newNumPart="";
            int intNumber;
            numPart = Regex.Match(id, @"\d+").Value;
            intNumber = Convert.ToInt32(numPart) + 1;
            for (int i = 0; i < numPart.Length - intNumber.ToString().Length; i++)
            {
                newNumPart += "0";
            }
            newNumPart += intNumber;
            newNumPart = "00" + intNumber;
            strPart = numPart = Regex.Match(id, @"\D+").Value;
            newKey = strPart + newNumPart;
            return newKey;
        }
    }
}