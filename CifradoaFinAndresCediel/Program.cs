using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CifradoaFinAndresCediel
{
    class Program
    {
        readonly string ABECEDARIO = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        static void Main(string[] args)
        {
            Program p = new Program();
            Dictionary<string, int> x = p.GetMaxLetter(   "IJNYI WBNYF KMYLF JOYLI YBZKT WBNWN JDKNY WLUWM JTBYK EFKIW BLYFK VKQYB"
                                                        + "UWFPY EFKLW BJKWH DELKW LUKIW BLYFK VKQYB WLWMV WSYBK VJPYR EWUWF"
                                                        + "PYWFW MVEFN YUWFP YYUBK WHDEL KWLUK IWBLY FKVKQ YBWLD KIKAN WWFUW"
                                                        + "FNWBM YUYNY ZKLUK MYLMJ TBYLI KBKFJ OYLUW FPYEF KUWBD WBKWH DELKW LUKIW"
                                                        + "BLYFK VKQYB ÑJÑWW FGBKF DJKNY FNWIK LKZKV TBWQG BJYÑW BNKNW BKVWF"
                                                        + "UWFWD WLJUK DYFLE WMYLJ UYNKL WLKLW HDELK LFYTK LUKLW FTJWF IEWNY NWNJD"
                                                        + "KBWLU WMJTB YKMFJ OYREW EFKÑW AGEWW LUKIW BLYFK VKQYB UYNYL MYLVK"
                                                        + "QYBWL ZKFLJ NYIBJ VWBYF JOYL");
        }

        public Dictionary<string, int> GetMaxLetter(string text) => (from id in Regex.Replace(text, @"\s+", "")
                                                                     .Select(c => c.ToString().ToUpper()).ToList()
                                                                     group id by id into g
                                                                     orderby g.Count() descending
                                                                     select new { Id = g.Key, Count = g.Count() })
                                                                    .ToDictionary(o => o.Id, o => o.Count);
    }
}
