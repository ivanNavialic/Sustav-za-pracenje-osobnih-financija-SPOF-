namespace SPOF.UI
{
    partial class Registracija
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegKorisnickoImeTxt = new System.Windows.Forms.TextBox();
            this.RegLozinkaTxt = new System.Windows.Forms.TextBox();
            this.RegPonoviLozinkuTxt = new System.Windows.Forms.TextBox();
            this.PrikaziLozinkuChB = new System.Windows.Forms.CheckBox();
            this.RegistrirajSeBtn = new System.Windows.Forms.Button();
            this.ExitAppLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrijaviSeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(339, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "REGISTRACIJA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Korisničko ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lozinka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ponovi lozinku:";
            // 
            // RegKorisnickoImeTxt
            // 
            this.RegKorisnickoImeTxt.Location = new System.Drawing.Point(344, 122);
            this.RegKorisnickoImeTxt.Name = "RegKorisnickoImeTxt";
            this.RegKorisnickoImeTxt.Size = new System.Drawing.Size(211, 33);
            this.RegKorisnickoImeTxt.TabIndex = 6;
            // 
            // RegLozinkaTxt
            // 
            this.RegLozinkaTxt.Location = new System.Drawing.Point(344, 202);
            this.RegLozinkaTxt.Name = "RegLozinkaTxt";
            this.RegLozinkaTxt.Size = new System.Drawing.Size(211, 33);
            this.RegLozinkaTxt.TabIndex = 7;
            this.RegLozinkaTxt.UseSystemPasswordChar = true;
            // 
            // RegPonoviLozinkuTxt
            // 
            this.RegPonoviLozinkuTxt.Location = new System.Drawing.Point(344, 277);
            this.RegPonoviLozinkuTxt.Name = "RegPonoviLozinkuTxt";
            this.RegPonoviLozinkuTxt.Size = new System.Drawing.Size(211, 33);
            this.RegPonoviLozinkuTxt.TabIndex = 8;
            this.RegPonoviLozinkuTxt.UseSystemPasswordChar = true;
            // 
            // PrikaziLozinkuChB
            // 
            this.PrikaziLozinkuChB.AutoSize = true;
            this.PrikaziLozinkuChB.Location = new System.Drawing.Point(346, 325);
            this.PrikaziLozinkuChB.Name = "PrikaziLozinkuChB";
            this.PrikaziLozinkuChB.Size = new System.Drawing.Size(153, 29);
            this.PrikaziLozinkuChB.TabIndex = 9;
            this.PrikaziLozinkuChB.Text = "Prikaži lozinku";
            this.PrikaziLozinkuChB.UseVisualStyleBackColor = true;
            this.PrikaziLozinkuChB.CheckedChanged += new System.EventHandler(this.PrikaziLozinkuChB_CheckedChanged);
            // 
            // RegistrirajSeBtn
            // 
            this.RegistrirajSeBtn.Location = new System.Drawing.Point(346, 387);
            this.RegistrirajSeBtn.Name = "RegistrirajSeBtn";
            this.RegistrirajSeBtn.Size = new System.Drawing.Size(209, 40);
            this.RegistrirajSeBtn.TabIndex = 10;
            this.RegistrirajSeBtn.Text = "Registriraj se";
            this.RegistrirajSeBtn.UseVisualStyleBackColor = true;
            this.RegistrirajSeBtn.Click += new System.EventHandler(this.RegistrirajSeBtn_Click);
            // 
            // ExitAppLbl
            // 
            this.ExitAppLbl.AutoSize = true;
            this.ExitAppLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitAppLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitAppLbl.Location = new System.Drawing.Point(555, 12);
            this.ExitAppLbl.Name = "ExitAppLbl";
            this.ExitAppLbl.Size = new System.Drawing.Size(24, 25);
            this.ExitAppLbl.TabIndex = 12;
            this.ExitAppLbl.Text = "X";
            this.ExitAppLbl.Click += new System.EventHandler(this.ExitAppLbl_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(21, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 48);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sustav za praćenje osobnih                   financija";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPOF.Properties.Resources.budget;
            this.pictureBox1.Location = new System.Drawing.Point(72, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 117);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.PrijaviSeBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 450);
            this.panel1.TabIndex = 15;
            // 
            // PrijaviSeBtn
            // 
            this.PrijaviSeBtn.Location = new System.Drawing.Point(47, 387);
            this.PrijaviSeBtn.Name = "PrijaviSeBtn";
            this.PrijaviSeBtn.Size = new System.Drawing.Size(155, 40);
            this.PrijaviSeBtn.TabIndex = 11;
            this.PrijaviSeBtn.Text = "Prijavi se";
            this.PrijaviSeBtn.UseVisualStyleBackColor = true;
            this.PrijaviSeBtn.Click += new System.EventHandler(this.PrijaviSeBtn_Click);
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.ExitAppLbl);
            this.Controls.Add(this.RegistrirajSeBtn);
            this.Controls.Add(this.PrikaziLozinkuChB);
            this.Controls.Add(this.RegPonoviLozinkuTxt);
            this.Controls.Add(this.RegLozinkaTxt);
            this.Controls.Add(this.RegKorisnickoImeTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Registracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.Registracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RegKorisnickoImeTxt;
        private System.Windows.Forms.TextBox RegLozinkaTxt;
        private System.Windows.Forms.TextBox RegPonoviLozinkuTxt;
        private System.Windows.Forms.CheckBox PrikaziLozinkuChB;
        private System.Windows.Forms.Button RegistrirajSeBtn;
        private System.Windows.Forms.Label ExitAppLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PrijaviSeBtn;
    }
}