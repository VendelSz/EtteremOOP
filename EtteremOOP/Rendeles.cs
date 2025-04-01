using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteremOOP
{
	internal class Rendeles
	{
		public string VendegNev {get; set;}
		public List<MenuElem> RendeltEtelek {get; set;}

		public Rendeles(string vendegNev, List<MenuElem> rendeltEtelek)
		{
			VendegNev = vendegNev;
			RendeltEtelek = rendeltEtelek;
		}

		public int Vegosszeg()
		{
			return RendeltEtelek.Sum(item => item.Ar);
		}
	}
}
