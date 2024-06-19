namespace Ispit_April.BusinessLogic
{
	public abstract class PosiljkaBase
	{
		#region Data
		protected PosiljkaBase _parent;
		protected decimal _cena = 0	;
		protected string _posiljalac;
		protected string _primalac;
		#endregion


		#region Props	
		public abstract string Posiljalac { get;  }
		public abstract string Primalac { get; }
		public abstract decimal NovcanaVrednost { get; }
		public PosiljkaBase Parent { get => _parent; set => _parent = value; }
		public bool DaLiJeUKompozitu => _parent != null;
		public PosiljkaBase OsnovniKompozit
		{
			get
			{
				if(_parent == null)	return null;
				if (!_parent.DaLiJeUKompozitu) return _parent;
				else return _parent.OsnovniKompozit;
			}
		}
		#endregion

		#region Methods
		public override string ToString()
		{
			return $"<{Posiljalac}>, <{Primalac}>, <{NovcanaVrednost}>";
		}
		#endregion
	}
}
