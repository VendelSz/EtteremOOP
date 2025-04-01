﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteremOOP
{
	internal class MenuElem
	{
		public string Nev {get; set;}
		public int Ar {get; set;}
		public string Kategoria {get; set;}

		public MenuElem(string nev, int ar, string kategoria)
		{
			Nev = nev;
			Ar = ar;
			Kategoria = kategoria;
		}

		public override string ToString()
		{
			return $"{Nev} - {Ar} Ft ({Kategoria})";
		}
	}
}
