namespace Ispit_April
{
	partial class Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnPrikazi = new System.Windows.Forms.Button();
			this.tbVrednostElemenata = new System.Windows.Forms.TextBox();
			this.tbUkupnaVrednost = new System.Windows.Forms.TextBox();
			this.tbUkupanBrojElemenata = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbElementi = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnPrikazi
			// 
			this.btnPrikazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnPrikazi.Location = new System.Drawing.Point(221, 12);
			this.btnPrikazi.Name = "btnPrikazi";
			this.btnPrikazi.Size = new System.Drawing.Size(183, 52);
			this.btnPrikazi.TabIndex = 0;
			this.btnPrikazi.Text = "Prikazi";
			this.btnPrikazi.UseVisualStyleBackColor = true;
			this.btnPrikazi.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbVrednostElemenata
			// 
			this.tbVrednostElemenata.Location = new System.Drawing.Point(221, 83);
			this.tbVrednostElemenata.Name = "tbVrednostElemenata";
			this.tbVrednostElemenata.Size = new System.Drawing.Size(183, 20);
			this.tbVrednostElemenata.TabIndex = 1;
			// 
			// tbUkupnaVrednost
			// 
			this.tbUkupnaVrednost.Location = new System.Drawing.Point(221, 131);
			this.tbUkupnaVrednost.Name = "tbUkupnaVrednost";
			this.tbUkupnaVrednost.Size = new System.Drawing.Size(183, 20);
			this.tbUkupnaVrednost.TabIndex = 2;
			// 
			// tbUkupanBrojElemenata
			// 
			this.tbUkupanBrojElemenata.Location = new System.Drawing.Point(221, 184);
			this.tbUkupanBrojElemenata.Name = "tbUkupanBrojElemenata";
			this.tbUkupanBrojElemenata.Size = new System.Drawing.Size(183, 20);
			this.tbUkupanBrojElemenata.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(218, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Vrednost Elemenata";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(218, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Ukupna Vrednost";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(218, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Ukupan Broj Elemenata";
			// 
			// lbElementi
			// 
			this.lbElementi.FormattingEnabled = true;
			this.lbElementi.Location = new System.Drawing.Point(12, 236);
			this.lbElementi.Name = "lbElementi";
			this.lbElementi.Size = new System.Drawing.Size(573, 186);
			this.lbElementi.TabIndex = 7;
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 439);
			this.Controls.Add(this.lbElementi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbUkupanBrojElemenata);
			this.Controls.Add(this.tbUkupnaVrednost);
			this.Controls.Add(this.tbVrednostElemenata);
			this.Controls.Add(this.btnPrikazi);
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPrikazi;
		private System.Windows.Forms.TextBox tbVrednostElemenata;
		private System.Windows.Forms.TextBox tbUkupnaVrednost;
		private System.Windows.Forms.TextBox tbUkupanBrojElemenata;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox lbElementi;
	}
}

