using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ispit_April.BusinessLogic
{
	public class Kontejner : PosiljkaBaseComposite
	{
		public Kontejner(PosiljkaBase element, string posiljalac, string primalac, decimal cenaKontejnera)
		{
			_posiljalac = posiljalac;
			_primalac = primalac;
			_cena = cenaKontejnera;
			if (element != null)
				element.Parent = this;
				_elementi.Add(element);
		}
		public Kontejner(string posiljalac, string primalac, decimal cenaKontejnera)
		{
			{
				_posiljalac = posiljalac;
				_primalac = primalac;
				_cena = cenaKontejnera;
			}
		}
		public decimal UkupnaVrednost => NovcanaVrednost + _cena;
	}
}
