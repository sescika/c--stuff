using System;

namespace Ispit_April.BusinessLogic
{
	public class Posiljka : PosiljkaBase
	{
		public Posiljka(decimal cena, string posiljalac, string primalac)
		{
			_primalac = primalac;
			_posiljalac = posiljalac;
			_cena = cena;
		}
		public override string Posiljalac => _posiljalac;
		public override string Primalac => _primalac;
		public override decimal NovcanaVrednost
		{
			get
			{
				return _cena;
			}
		}
	}
}
