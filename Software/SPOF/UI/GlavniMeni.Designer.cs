namespace SPOF.UI
{
    partial class GlavniMeni
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UkupnoStanjeLbl = new System.Windows.Forms.Label();
            this.NazivTxt = new System.Windows.Forms.TextBox();
            this.IznosTxt = new System.Windows.Forms.TextBox();
            this.PrihodCheckB = new System.Windows.Forms.CheckBox();
            this.RashodCheckB = new System.Windows.Forms.CheckBox();
            this.StednjaCheckB = new System.Windows.Forms.CheckBox();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.OcistiBtn = new System.Windows.Forms.Button();
            this.OdjavaBtn = new System.Windows.Forms.Button();
            this.ObrisiBtn = new System.Windows.Forms.Button();
            this.PrihodiBtn = new System.Windows.Forms.Button();
            this.RashodiBtn = new System.Windows.Forms.Button();
            this.StednjaBtn = new System.Windows.Forms.Button();
            this.IzvjestajBtn = new System.Windows.Forms.Button();
            this.UplataIsplateDataGrid = new System.Windows.Forms.DataGridView();
            this.ExitAppLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ImeKorisnikaLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UplataIsplateDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(563, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaz svih transakcija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Iznos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ukupno stanje na računu:";
            // 
            // UkupnoStanjeLbl
            // 
            this.UkupnoStanjeLbl.AutoSize = true;
            this.UkupnoStanjeLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UkupnoStanjeLbl.Location = new System.Drawing.Point(809, 412);
            this.UkupnoStanjeLbl.Name = "UkupnoStanjeLbl";
            this.UkupnoStanjeLbl.Size = new System.Drawing.Size(65, 25);
            this.UkupnoStanjeLbl.TabIndex = 4;
            this.UkupnoStanjeLbl.Text = "label5";
            // 
            // NazivTxt
            // 
            this.NazivTxt.Location = new System.Drawing.Point(244, 101);
            this.NazivTxt.Name = "NazivTxt";
            this.NazivTxt.Size = new System.Drawing.Size(228, 33);
            this.NazivTxt.TabIndex = 5;
            // 
            // IznosTxt
            // 
            this.IznosTxt.Location = new System.Drawing.Point(244, 174);
            this.IznosTxt.Name = "IznosTxt";
            this.IznosTxt.Size = new System.Drawing.Size(228, 33);
            this.IznosTxt.TabIndex = 6;
            // 
            // PrihodCheckB
            // 
            this.PrihodCheckB.AutoSize = true;
            this.PrihodCheckB.Location = new System.Drawing.Point(244, 220);
            this.PrihodCheckB.Name = "PrihodCheckB";
            this.PrihodCheckB.Size = new System.Drawing.Size(87, 29);
            this.PrihodCheckB.TabIndex = 7;
            this.PrihodCheckB.Text = "Prihod";
            this.PrihodCheckB.UseVisualStyleBackColor = true;
            // 
            // RashodCheckB
            // 
            this.RashodCheckB.AutoSize = true;
            this.RashodCheckB.Location = new System.Drawing.Point(244, 255);
            this.RashodCheckB.Name = "RashodCheckB";
            this.RashodCheckB.Size = new System.Drawing.Size(93, 29);
            this.RashodCheckB.TabIndex = 8;
            this.RashodCheckB.Text = "Rashod";
            this.RashodCheckB.UseVisualStyleBackColor = true;
            // 
            // StednjaCheckB
            // 
            this.StednjaCheckB.AutoSize = true;
            this.StednjaCheckB.Location = new System.Drawing.Point(244, 290);
            this.StednjaCheckB.Name = "StednjaCheckB";
            this.StednjaCheckB.Size = new System.Drawing.Size(93, 29);
            this.StednjaCheckB.TabIndex = 9;
            this.StednjaCheckB.Text = "Štednja";
            this.StednjaCheckB.UseVisualStyleBackColor = true;
            // 
            // DodajBtn
            // 
            this.DodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.DodajBtn.ForeColor = System.Drawing.Color.White;
            this.DodajBtn.Location = new System.Drawing.Point(244, 354);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(70, 44);
            this.DodajBtn.TabIndex = 10;
            this.DodajBtn.Text = "Dodaj";
            this.DodajBtn.UseVisualStyleBackColor = false;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // OcistiBtn
            // 
            this.OcistiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.OcistiBtn.ForeColor = System.Drawing.Color.White;
            this.OcistiBtn.Location = new System.Drawing.Point(320, 354);
            this.OcistiBtn.Name = "OcistiBtn";
            this.OcistiBtn.Size = new System.Drawing.Size(71, 44);
            this.OcistiBtn.TabIndex = 11;
            this.OcistiBtn.Text = "Očisti";
            this.OcistiBtn.UseVisualStyleBackColor = false;
            this.OcistiBtn.Click += new System.EventHandler(this.OcistiBtn_Click);
            // 
            // OdjavaBtn
            // 
            this.OdjavaBtn.Location = new System.Drawing.Point(40, 354);
            this.OdjavaBtn.Name = "OdjavaBtn";
            this.OdjavaBtn.Size = new System.Drawing.Size(103, 44);
            this.OdjavaBtn.TabIndex = 13;
            this.OdjavaBtn.Text = "Odjava";
            this.OdjavaBtn.UseVisualStyleBackColor = true;
            this.OdjavaBtn.Click += new System.EventHandler(this.OdjavaBtn_Click);
            // 
            // ObrisiBtn
            // 
            this.ObrisiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.ObrisiBtn.ForeColor = System.Drawing.Color.White;
            this.ObrisiBtn.Location = new System.Drawing.Point(397, 354);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(74, 44);
            this.ObrisiBtn.TabIndex = 12;
            this.ObrisiBtn.Text = "Obriši";
            this.ObrisiBtn.UseVisualStyleBackColor = false;
            this.ObrisiBtn.Click += new System.EventHandler(this.ObrisiBtn_Click);
            // 
            // PrihodiBtn
            // 
            this.PrihodiBtn.Location = new System.Drawing.Point(40, 69);
            this.PrihodiBtn.Name = "PrihodiBtn";
            this.PrihodiBtn.Size = new System.Drawing.Size(103, 44);
            this.PrihodiBtn.TabIndex = 14;
            this.PrihodiBtn.Text = "Prihodi";
            this.PrihodiBtn.UseVisualStyleBackColor = true;
            this.PrihodiBtn.Click += new System.EventHandler(this.PrihodiBtn_Click);
            // 
            // RashodiBtn
            // 
            this.RashodiBtn.Location = new System.Drawing.Point(40, 137);
            this.RashodiBtn.Name = "RashodiBtn";
            this.RashodiBtn.Size = new System.Drawing.Size(103, 44);
            this.RashodiBtn.TabIndex = 15;
            this.RashodiBtn.Text = "Rashodi";
            this.RashodiBtn.UseVisualStyleBackColor = true;
            this.RashodiBtn.Click += new System.EventHandler(this.RashodiBtn_Click);
            // 
            // StednjaBtn
            // 
            this.StednjaBtn.Location = new System.Drawing.Point(40, 211);
            this.StednjaBtn.Name = "StednjaBtn";
            this.StednjaBtn.Size = new System.Drawing.Size(103, 44);
            this.StednjaBtn.TabIndex = 16;
            this.StednjaBtn.Text = "Štednja";
            this.StednjaBtn.UseVisualStyleBackColor = true;
            this.StednjaBtn.Click += new System.EventHandler(this.StednjaBtn_Click);
            // 
            // IzvjestajBtn
            // 
            this.IzvjestajBtn.Location = new System.Drawing.Point(40, 283);
            this.IzvjestajBtn.Name = "IzvjestajBtn";
            this.IzvjestajBtn.Size = new System.Drawing.Size(103, 44);
            this.IzvjestajBtn.TabIndex = 17;
            this.IzvjestajBtn.Text = "Izvještaj";
            this.IzvjestajBtn.UseVisualStyleBackColor = true;
            this.IzvjestajBtn.Click += new System.EventHandler(this.IzvjestajBtn_Click);
            // 
            // UplataIsplateDataGrid
            // 
            this.UplataIsplateDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UplataIsplateDataGrid.Location = new System.Drawing.Point(568, 69);
            this.UplataIsplateDataGrid.Name = "UplataIsplateDataGrid";
            this.UplataIsplateDataGrid.Size = new System.Drawing.Size(578, 329);
            this.UplataIsplateDataGrid.TabIndex = 18;
            // 
            // ExitAppLbl
            // 
            this.ExitAppLbl.AutoSize = true;
            this.ExitAppLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitAppLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitAppLbl.Location = new System.Drawing.Point(1132, 18);
            this.ExitAppLbl.Name = "ExitAppLbl";
            this.ExitAppLbl.Size = new System.Drawing.Size(24, 25);
            this.ExitAppLbl.TabIndex = 19;
            this.ExitAppLbl.Text = "X";
            this.ExitAppLbl.Click += new System.EventHandler(this.ExitAppLbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.IzvjestajBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.StednjaBtn);
            this.panel1.Controls.Add(this.PrihodiBtn);
            this.panel1.Controls.Add(this.RashodiBtn);
            this.panel1.Controls.Add(this.OdjavaBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 30);
            this.label5.TabIndex = 21;
            this.label5.Text = "Glavni izbornik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(239, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Dobro došao, ";
            // 
            // ImeKorisnikaLbl
            // 
            this.ImeKorisnikaLbl.AutoSize = true;
            this.ImeKorisnikaLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImeKorisnikaLbl.Location = new System.Drawing.Point(368, 14);
            this.ImeKorisnikaLbl.Name = "ImeKorisnikaLbl";
            this.ImeKorisnikaLbl.Size = new System.Drawing.Size(65, 25);
            this.ImeKorisnikaLbl.TabIndex = 22;
            this.ImeKorisnikaLbl.Text = "label7";
            // 
            // GlavniMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 450);
            this.Controls.Add(this.ImeKorisnikaLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitAppLbl);
            this.Controls.Add(this.UplataIsplateDataGrid);
            this.Controls.Add(this.ObrisiBtn);
            this.Controls.Add(this.OcistiBtn);
            this.Controls.Add(this.DodajBtn);
            this.Controls.Add(this.StednjaCheckB);
            this.Controls.Add(this.RashodCheckB);
            this.Controls.Add(this.PrihodCheckB);
            this.Controls.Add(this.IznosTxt);
            this.Controls.Add(this.NazivTxt);
            this.Controls.Add(this.UkupnoStanjeLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GlavniMeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavniMeni";
            this.Load += new System.EventHandler(this.GlavniMeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UplataIsplateDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UkupnoStanjeLbl;
        private System.Windows.Forms.TextBox NazivTxt;
        private System.Windows.Forms.TextBox IznosTxt;
        private System.Windows.Forms.CheckBox PrihodCheckB;
        private System.Windows.Forms.CheckBox RashodCheckB;
        private System.Windows.Forms.CheckBox StednjaCheckB;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.Button OcistiBtn;
        private System.Windows.Forms.Button OdjavaBtn;
        private System.Windows.Forms.Button ObrisiBtn;
        private System.Windows.Forms.Button PrihodiBtn;
        private System.Windows.Forms.Button RashodiBtn;
        private System.Windows.Forms.Button StednjaBtn;
        private System.Windows.Forms.Button IzvjestajBtn;
        private System.Windows.Forms.DataGridView UplataIsplateDataGrid;
        private System.Windows.Forms.Label ExitAppLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ImeKorisnikaLbl;
    }
}