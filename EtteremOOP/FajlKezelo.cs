using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteremOOP
{
	internal class FajlKezelo
	{
		public static List<MenuElem> MenuBetoltese()
		{
			List<MenuElem> menu = new List<MenuElem>();
			if (File.Exists("menu.txt"))
			{
				var lines = File.ReadAllLines("menu.txt");
				foreach (var line in lines)
				{
					var parts = line.Split(';');
					if (parts.Length == 3)
					{
						menu.Add(new MenuElem(parts[0], int.Parse(parts[1]), parts[2]));
					}
				}
			}
			return menu;
		}

		public static void MenuMentese(List<MenuElem> menu)
		{
			using (StreamWriter sw = new StreamWriter("menu.txt"))
			{
				foreach (var item in menu)
				{
					sw.WriteLine($"{item.Nev};{item.Ar};{item.Kategoria}");
				}
			}
		}

		public static void RendelesMentese(List<Rendeles> rendelesek)
		{
			using (StreamWriter sw = new StreamWriter("rendelesek.txt"))
			{
				foreach (var rendeles in rendelesek)
				{
					sw.WriteLine($"{rendeles.VendegNev};{string.Join(",", rendeles.RendeltEtelek.Select(e => e.Nev))}");
				}
			}
		}
	}
}
