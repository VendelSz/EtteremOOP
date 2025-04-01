using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteremOOP
{
	internal class Etterem
	{
		public List<MenuElem> Menu {get; set;}
		public List<Rendeles> Rendelesek {get; set;}

		public Etterem()
		{
			Menu = new List<MenuElem>();
			Rendelesek = new List<Rendeles>();
		}

		public void HozzaadMenu(MenuElem menuElem)
		{
			Menu.Add(menuElem);
		}

		public void ListazMenut()
		{
			foreach (var item in Menu)
			{
				Console.WriteLine(item);
			}
		}

		public void UjRendeles(Vendeg vendeg)
		{
			Rendeles rendeles = new Rendeles(vendeg.Nev, new List<MenuElem>(vendeg.Rendelesek));
			Rendelesek.Add(rendeles);
		}
	}
}
