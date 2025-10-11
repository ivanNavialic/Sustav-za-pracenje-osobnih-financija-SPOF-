namespace SPOF.UI
{
    partial class Prijava
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
            this.PrijaviSeBtn = new System.Windows.Forms.Button();
            this.RegistrirajBtn = new System.Windows.Forms.Button();
            this.PrijavaKorImeTxt = new System.Windows.Forms.TextBox();
            this.PrijavaLozinkaTxt = new System.Windows.Forms.TextBox();
            this.PrikaziLozinkuChB = new System.Windows.Forms.CheckBox();
            this.ExitAppLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRIJAVA U SUSTAV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lozinka:";
            // 
            // PrijaviSeBtn
            // 
            this.PrijaviSeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.PrijaviSeBtn.FlatAppearance.BorderSize = 0;
            this.PrijaviSeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrijaviSeBtn.ForeColor = System.Drawing.Color.White;
            this.PrijaviSeBtn.Location = new System.Drawing.Point(331, 376);
            this.PrijaviSeBtn.Name = "PrijaviSeBtn";
            this.PrijaviSeBtn.Size = new System.Drawing.Size(197, 44);
            this.PrijaviSeBtn.TabIndex = 3;
            this.PrijaviSeBtn.Text = "Prijavi se";
            this.PrijaviSeBtn.UseVisualStyleBackColor = false;
            this.PrijaviSeBtn.Click += new System.EventHandler(this.PrijaviSeBtn_Click);
            // 
            // RegistrirajBtn
            // 
            this.RegistrirajBtn.Location = new System.Drawing.Point(48, 376);
            this.RegistrirajBtn.Name = "RegistrirajBtn";
            this.RegistrirajBtn.Size = new System.Drawing.Size(159, 44);
            this.RegistrirajBtn.TabIndex = 4;
            this.RegistrirajBtn.Text = "Registriraj se";
            this.RegistrirajBtn.UseVisualStyleBackColor = true;
            this.RegistrirajBtn.Click += new System.EventHandler(this.RegistrirajBtn_Click);
            // 
            // PrijavaKorImeTxt
            // 
            this.PrijavaKorImeTxt.Location = new System.Drawing.Point(331, 128);
            this.PrijavaKorImeTxt.Name = "PrijavaKorImeTxt";
            this.PrijavaKorImeTxt.Size = new System.Drawing.Size(197, 33);
            this.PrijavaKorImeTxt.TabIndex = 5;
            // 
            // PrijavaLozinkaTxt
            // 
            this.PrijavaLozinkaTxt.Location = new System.Drawing.Point(331, 221);
            this.PrijavaLozinkaTxt.Name = "PrijavaLozinkaTxt";
            this.PrijavaLozinkaTxt.Size = new System.Drawing.Size(197, 33);
            this.PrijavaLozinkaTxt.TabIndex = 6;
            this.PrijavaLozinkaTxt.UseSystemPasswordChar = true;
            // 
            // PrikaziLozinkuChB
            // 
            this.PrikaziLozinkuChB.AutoSize = true;
            this.PrikaziLozinkuChB.Location = new System.Drawing.Point(331, 272);
            this.PrikaziLozinkuChB.Name = "PrikaziLozinkuChB";
            this.PrikaziLozinkuChB.Size = new System.Drawing.Size(153, 29);
            this.PrikaziLozinkuChB.TabIndex = 7;
            this.PrikaziLozinkuChB.Text = "Prikaži lozinku";
            this.PrikaziLozinkuChB.UseVisualStyleBackColor = true;
            this.PrikaziLozinkuChB.CheckedChanged += new System.EventHandler(this.PrikaziLozinkuChB_CheckedChanged);
            // 
            // ExitAppLbl
            // 
            this.ExitAppLbl.AutoSize = true;
            this.ExitAppLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitAppLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitAppLbl.Location = new System.Drawing.Point(564, 9);
            this.ExitAppLbl.Name = "ExitAppLbl";
            this.ExitAppLbl.Size = new System.Drawing.Size(24, 25);
            this.ExitAppLbl.TabIndex = 13;
            this.ExitAppLbl.Text = "X";
            this.ExitAppLbl.Click += new System.EventHandler(this.ExitAppLbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.RegistrirajBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 450);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sustav za praćenje osobnih                   financija";
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
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitAppLbl);
            this.Controls.Add(this.PrikaziLozinkuChB);
            this.Controls.Add(this.PrijavaLozinkaTxt);
            this.Controls.Add(this.PrijavaKorImeTxt);
            this.Controls.Add(this.PrijaviSeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PrijaviSeBtn;
        private System.Windows.Forms.Button RegistrirajBtn;
        private System.Windows.Forms.TextBox PrijavaKorImeTxt;
        private System.Windows.Forms.TextBox PrijavaLozinkaTxt;
        private System.Windows.Forms.CheckBox PrikaziLozinkuChB;
        private System.Windows.Forms.Label ExitAppLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}