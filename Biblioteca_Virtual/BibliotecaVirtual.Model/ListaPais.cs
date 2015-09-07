using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Biblioteca.Model
{
    public static class ListaPais
    {
        public static List<string> ListaPaises()
        {
            List<string> ListaCultura = new List<string>();

            CultureInfo[] SelecionarCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo SelecionarCultura in SelecionarCultureInfo)
            {
                RegionInfo SelecionarRegionInfo = new RegionInfo(SelecionarCultura.LCID);
                if (!(ListaCultura.Contains(SelecionarRegionInfo.DisplayName)))
                {
                    ListaCultura.Add(SelecionarRegionInfo.DisplayName);
                }
            }
            ListaCultura.Sort();
            return ListaCultura;
        }
    }
}
