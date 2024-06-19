using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit_April.BusinessLogic
{
	public abstract class PosiljkaBaseComposite : PosiljkaBase
	{
		#region Data
		public List<PosiljkaBase> _elementi = new List<PosiljkaBase>();
		#endregion

		#region Props
		public int BrojNeposrednihElemenata => _elementi.Count;
		public int UkupanBrojElemenata
		{
			get
			{
				int ukupanBroj = 0;
				foreach (var item in _elementi)
				{
					PosiljkaBaseComposite itemCast = item as PosiljkaBaseComposite;
					if (itemCast != null)
					{
						ukupanBroj += itemCast._elementi.Count();
					}
					else
					{
						ukupanBroj++;
					}
				}

				return ukupanBroj;
			}
		}
		public override string Posiljalac => _posiljalac;
		public override string Primalac => _primalac;
		public override decimal NovcanaVrednost
		{
			get
			{
				return _elementi.Sum(x => x.NovcanaVrednost);
			}
		}

		#endregion

		#region Methods
		//Add element to composite
		public bool Dodaj(PosiljkaBase child)
		{
			if (child == null)
				return false;
			bool dodajSe = false;

			PosiljkaBaseComposite childCast = child as PosiljkaBaseComposite;

			if (childCast == null) dodajSe = true;
			else
			{
				if (childCast.UkupanBrojElemenata > UkupanBrojElemenata) dodajSe = false;
				bool daLiJeThisUnutarObjGrupa = DaLiJeDrugiUnutarPrvog(childCast, this);
				dodajSe = !daLiJeThisUnutarObjGrupa;
			}
			if (dodajSe) DodajPromeniRoditelja(child);
			return dodajSe;
		}
		//Checks if child element is already in parent composite, preventing infinite recursion
		protected static bool DaLiJeDrugiUnutarPrvog(PosiljkaBaseComposite parent, PosiljkaBaseComposite child)
		{
			if ((parent == null) || (child == null)) return false;
			if (!child.DaLiJeUKompozitu) return false;
			if (object.ReferenceEquals(parent, child.Parent)) return true;
			if (child.Parent.DaLiJeUKompozitu) return DaLiJeDrugiUnutarPrvog(parent, child.Parent as PosiljkaBaseComposite);
			return false;
		}
		//Adds element and sets parent
		protected void DodajPromeniRoditelja(PosiljkaBase obj)
		{
			if (obj.Parent != null) IzbaciIzKompozitaUKomSeNalazi(obj);
			obj.Parent = this;
			_elementi.Add(obj);
		}
		//Removes item from composite
		protected static bool IzbaciIzKompozitaUKomSeNalazi(PosiljkaBase obj)
		{
			if (obj.Parent == null)
				return false;

			Paket parent = obj.Parent as Paket;

			int index = -1;
			for (int i = 0; i <= parent._elementi.Count; i++)
			{
				if (object.ReferenceEquals(parent._elementi[i], obj))
				{
					index = i; break;
				}
			}

			if (index >= 0)
			{
				parent._elementi.RemoveAt(index);
				obj.Parent = null;
			}
			return true;
		}
		#endregion
	}
}
