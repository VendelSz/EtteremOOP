using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteremOOP
{
	internal class Vendeg
	{
		public string Nev {get; set;}
		public List<MenuElem> Rendelesek {get; private set;}

		public Vendeg(string nev)
		{
			Nev = nev;
			Rendelesek = new List<MenuElem>();
		}

		public void Rendel(MenuElem menuElem)
		{
			Rendelesek.Add(menuElem);
		}

		public int Fizet()
		{
			int osszeg = Rendelesek.Sum(item => item.Ar);
			Rendelesek.Clear();
			return osszeg;
		}
	}
}
