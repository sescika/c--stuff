using Ispit_April.BusinessLogic;
using System;
using System.Windows.Forms;

namespace Ispit_April
{
	public partial class Form : System.Windows.Forms.Form
	{
		public Form()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Posiljka po1 = new Posiljka(1, "PosiljalacPosiljka1", "PrimalacPosiljka1");
			Posiljka po2 = new Posiljka(2, "PosiljalacPosijlka2", "PrimalacPosiljka2");
			Paket p1 = new Paket("PosiljalacPaket1", "PrimalacPaket1");
			p1.Dodaj(po1);
			p1.Dodaj(po2);

			Posiljka po3 = new Posiljka(3, "PosiljalacPosiljka3", "PrimalacPosiljka3");
			Posiljka po4 = new Posiljka(4, "PosiljalacPosiljka4", "PrimalacPosiljka4");
			Paket p2 = new Paket("PosiljalacPaket2", "PrimalacPaket2");
			p2.Dodaj(po3);
			p2.Dodaj(po4);

			Posiljka po5 = new Posiljka(5, "PosiljalacPosiljka5", "PrimalacPosiljka5");

			Posiljka po6 = new Posiljka(6, "PosiljalacPosiljka6", "PrimalacPosiljka6");
			Posiljka po7 = new Posiljka(7, "PosiljalacPosiljka7", "PrimalacPosiljka7");

			Posiljka po8 = new Posiljka(8, "PosiljalacPosiljka8", "PrimalacPosiljka8");
			Posiljka po9 = new Posiljka(9, "PosiljalacPosiljka9", "PrimalacPosiljka9");
			Posiljka po10 = new Posiljka(10, "PosiljalacPosiljka10", "PrimalacPosiljka10");
			Paket p3 = new Paket("PosiljalacPaket3", "PrimalacPaket3");
			p3.Dodaj(po8);
			p3.Dodaj(po9);
			p3.Dodaj(po10);

			Kontejner k2 = new Kontejner("PosiljalacKontejner2", "PrimalacKontejner2", 10);
			k2.Dodaj(po6);
			k2.Dodaj(po7);
			k2.Dodaj(p3);

			Kontejner k1 = new Kontejner("PosiljalacKontejner1", "PrimalacKontejner1", 10);
			k1.Dodaj(p1);
			k1.Dodaj(p2);
			k1.Dodaj(po5);
			k1.Dodaj(k2);

			this.tbVrednostElemenata.Text = k1.NovcanaVrednost.ToString();
			this.tbUkupnaVrednost.Text = k1.UkupnaVrednost.ToString();
			this.tbUkupanBrojElemenata.Text = k1.UkupanBrojElemenata.ToString();

			this.lbElementi.DataSource = k1._elementi;
		}
	}
}
