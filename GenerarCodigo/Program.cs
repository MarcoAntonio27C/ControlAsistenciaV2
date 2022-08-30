using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarCodigo
{
    class Program
    {

        void GenerarMunicipios(string listMunicipios)
        {
            List<string> Tmp_municipios1 = new List<string>();
            List<string> Tmp_municipios2 = new List<string>();
            List<string> municipios = new List<string>();
            string inicio = "modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid(\"";
            string medio = "\"), Nombre = \"";
            string final = "\" });";
            
            Tmp_municipios1 = listMunicipios.Split(',').ToList();
            
            foreach(var x in Tmp_municipios1)
            {
                Tmp_municipios2.Add(x.Trim());
            }

            municipios = Tmp_municipios2.Distinct().ToList();

            int i = 1;
            foreach(var x in municipios)
            {
                var id = Guid.NewGuid();
                Console.WriteLine(inicio+id+medio+x+final);
                i++;
            }

        }

        static void Main(string[] args)
        {
            string listaMunicipio = "ACAJETE,ACATENO,ACATLAN DE OSORIO,ACATZINGO,AHUAZOTEPEC,AJALPAN,ALTEPEXI,AMOZOC,ATEMPAN,ATENCINGO,ATLIXCO,ATLIXCO ,CALPAN,CHALCHICOMULA DE SESMA,CHALCHIHUAPAN,CHIAUTLA DE TAPIA,CHIETLA,CHIGNAHUAPAN,CORONANGO,CUAUTLANCINGO,CUETZALAN DEL PROGRESO,ESPERANZA,GUADALUPE VICTORIA,HUAUCHINANGO,HUEHUETLA,HUEJOTZINGO,HUEYTAMALCO,IZUCAR DE MATAMOROS,JUAN C. BONILLA,LIBRES,LIBRES ,LOS REYES DE JUAREZ,METLALTOYUCA,OCOYUCAN,ORIENTAL,PALMAR DE BRAVO,PIAXTLA,PUEBLA,SAN ANDRES CHOLULA,SAN GABRIEL CHILAC,SAN JOSE CHIAPA,SAN MARTIN TEXMELUCAN,SAN PEDRO CHOLULA,SAN SALVADOR EL SECO,SANTA RITA TLAHUAPAN,SANTIAGO MIAHUATLAN,TECALI DE HERRERA,TECAMACHALCO,TEHUACAN,TEHUACAN ,TEHUITZINGO,TEPANCO DE LOPEZ,TEPATLAXCO DE HIDALGO,TEPEACA,TEPEACA ,TEPEOJUMA,TEPEXI DE RODRIGUEZ,TEPEYAHUALCO,TETELA DE OCAMPO,TEZIUTLAN,TEZIUTLAN ,TLACOTEPEC DE BENITO JUAREZ,TLALTENANGO,TLAOLA,TLAPANALA,TLATLAUQUITEPEC,VILLA LAZARO CARDENAS,XICOTEPEC DE JUAREZ,ZACAPOAXTLA,ZACATLAN,ZARAGOZA,ZOQUITLAN";

            Program generar = new Program();

            generar.GenerarMunicipios(listaMunicipio);
        }
    }
}
