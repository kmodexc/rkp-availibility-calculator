using System;
using System.IO;
using ExcelSearchBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CreateDataSheetTest
    {
        [TestMethod]
        public void NoException()
        {
            DataSheetCreator dataSheetCreator = new DataSheetCreator();
            string[] obj = new string[100];
            for (int cnt = 0; cnt < obj.Length; cnt++) obj[cnt] = "testStr_" + cnt;
            dataSheetCreator.CreateDataSheet(obj);
        }
        [TestMethod]
        public void Descriptions()
        {
            DataSheetCreator dataSheetCreator = new DataSheetCreator();
            string[] obj = new string[100];
            for (int cnt = 0; cnt < obj.Length; cnt++) obj[cnt] = "testStr_" + cnt;
            obj[0] = "test_descriptions";
            obj[1] = "test_descriptions";
            obj[7] = "HK";
            obj[8] = "L";
            obj[9] = "14";
            obj[10] = "B3";
            obj[11] = "RPK";
            obj[12] = "032";
            obj[13] = "R";
            obj[14] = "C";
            obj[15] = "35";
            obj[16] = "D1";
            obj[17] = "Z";
            obj[18] = "00";
            obj[19] = "";
            string content = dataSheetCreator.CreateDataSheet(obj);


            var str1 = content.Trim();
            var str2 = (@"Pumpennummer:;test_descriptions
Pumpenschlüssel:;test_descriptions
Typ;HK;Explosionsgeschützte Pumpe Gas und Staub
Drehrichtung;L;Auf Antrieb gesehen „links”
Drehzahl;14;n = 1400 min-1
Welle und Antriebsflansch;B3;unsinnige Kombination aus metrischer Welle B und SAE-Flansch 3
Pumpenart ;RPK;Konstantpumpe
Fördervolumen RKP;032;32 cm3/U
Pumpenanschlüsse;R;Deutscher 4-Loch-Flansch (nur bei Zahnradpumpen)
Betriebsflüssigkeit;C;HFC (Wasserglycol)
max. Betriebsdruck;35;350 bar für Mineralöl- , HFD- und Skydrol-Pumpen
Steuerung/Regler;D1;RKP-D mit Eigendruckversorgung
Zusatzeinrichtung;Z;ohne Zusatzeinrichtung
Zusatzangabe;00;").Trim();


            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Length diff");
            }
            string line1 = "";
            string line2 = "";
            for (int cnt = 0; cnt < str1.Length && cnt < str2.Length; cnt++)
            {
                if (str2[cnt] == '\n' && str1[cnt] == '\n')
                {
                    line1 = "";
                    line2 = "";
                }
                else
                {
                    line1 += str1[cnt];
                    line2 += str2[cnt];
                }
                Assert.AreEqual(str1[cnt], str2[cnt], "diffrence at pos " + cnt + " <expected line:\"" + line2 + "\"> <actual line:\"" + line1 + "\">");
            }


            Assert.AreEqual(content.Trim(), str2);
        }

        [TestMethod]
        public void DoublePump()
        {
            DataSheetCreator dataSheetCreator = new DataSheetCreator();
            string[] obj = new string[100];
            for (int cnt = 0; cnt < obj.Length; cnt++) obj[cnt] = "testStr_" + cnt;
            obj[0] = "test_double";
            obj[1] = "test_double";
            obj[7] = "HK";
            obj[8] = "L";
            obj[9] = "14";
            obj[10] = "B3";
            obj[11] = "RPK";
            obj[12] = "032";
            obj[13] = "R";
            obj[14] = "C";
            obj[15] = "35";
            obj[16] = "D1";
            obj[17] = "Z";
            obj[18] = "00";
            obj[19] = "RKP";
            obj[20] = "032";
            obj[21] = "K";
            obj[22] = "M";
            obj[23] = "28";
            obj[24] = "E2";
            obj[25] = "Z";
            obj[26] = "00";
            obj[27] = "";

            string content = dataSheetCreator.CreateDataSheet(obj);



            var str1 = content.Trim();
            var str2 = (@"Pumpennummer:;test_double
Pumpenschlüssel:;test_double
Typ;HK;Explosionsgeschützte Pumpe Gas und Staub
Drehrichtung;L;Auf Antrieb gesehen „links”
Drehzahl;14;n = 1400 min-1
Welle und Antriebsflansch;B3;unsinnige Kombination aus metrischer Welle B und SAE-Flansch 3
Pumpenart ;RPK;Konstantpumpe
Fördervolumen RKP;032;32 cm3/U
Pumpenanschlüsse;R;Deutscher 4-Loch-Flansch (nur bei Zahnradpumpen)
Betriebsflüssigkeit;C;HFC (Wasserglycol)
max. Betriebsdruck;35;350 bar für Mineralöl- , HFD- und Skydrol-Pumpen
Steuerung/Regler;D1;RKP-D mit Eigendruckversorgung
Zusatzeinrichtung;Z;ohne Zusatzeinrichtung
Zusatzangabe;00;
Pumpenstufe 2
Pumpenart ;RKP;Radialkolbenpumpe verstellbar, offene Kreis
Fördervolumen RKP;032;32 cm3/U
Pumpenanschlüsse;K;RKP II: Sauganschluß SAE 3000 psi (ISO 6162-1)	 Druckanschluß SAE 3000 psi (ISO 6162-1)
Betriebsflüssigkeit;M;Mineralöl, Getriebeöl, biologisch abbaubares Öl
max. Betriebsdruck;28;280 bar für Mineralöl-, HFD-, Polyol- und Isozyanat-Pumpen
Steuerung/Regler;E2;Elektrohydraulische Verstellung EHV 2 (Moog Ventil)	mit Fremddruckversorgung (Nur als Ersatz für T2)
Zusatzeinrichtung;Z;ohne Zusatzeinrichtung
Zusatzangabe;00;").Trim();


            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Length diff");
            }
            string line1 = "";
            string line2 = "";
            for (int cnt = 0; cnt < str1.Length && cnt < str2.Length; cnt++)
            {
                if (str2[cnt] == '\n' && str1[cnt] == '\n')
                {
                    line1 = "";
                    line2 = "";
                }
                else
                {
                    line1 += str1[cnt];
                    line2 += str2[cnt];
                }
                Assert.AreEqual(str1[cnt], str2[cnt], "diffrence at pos " + cnt + " <expected line:\"" + line2 + "\"> <actual line:\"" + line1 + "\">");
            }


            Assert.AreEqual(content.Trim(), str2);
        }

    }
}
