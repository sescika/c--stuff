using System.Collections.Generic;
using System.Linq;

namespace Ispit_April.BusinessLogic
{
	public class Paket : PosiljkaBaseComposite
	{
		public Paket(PosiljkaBase element, string posiljalac, string primalac)
		{
			_posiljalac = posiljalac;
			_primalac = primalac;
			if (element != null)
				element.Parent = this;
				_elementi.Add(element);
		}

		public Paket(string posiljalac, string primalac) {
			_posiljalac = posiljalac;
			_primalac = primalac;
		}
	}
}
