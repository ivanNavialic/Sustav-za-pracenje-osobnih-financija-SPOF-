namespace SPOF.UI
{
    partial class UkupnaStednja
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
            this.UkupnaStednjaLbl = new System.Windows.Forms.Label();
            this.UkupnaStednjaDataGrid = new System.Windows.Forms.DataGridView();
            this.IsplatiStednjuBtn = new System.Windows.Forms.Button();
            this.NazadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UkupnaStednjaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukupna štednja:";
            // 
            // UkupnaStednjaLbl
            // 
            this.UkupnaStednjaLbl.AutoSize = true;
            this.UkupnaStednjaLbl.Location = new System.Drawing.Point(181, 35);
            this.UkupnaStednjaLbl.Name = "UkupnaStednjaLbl";
            this.UkupnaStednjaLbl.Size = new System.Drawing.Size(63, 25);
            this.UkupnaStednjaLbl.TabIndex = 1;
            this.UkupnaStednjaLbl.Text = "label2";
            // 
            // UkupnaStednjaDataGrid
            // 
            this.UkupnaStednjaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UkupnaStednjaDataGrid.Location = new System.Drawing.Point(32, 89);
            this.UkupnaStednjaDataGrid.Name = "UkupnaStednjaDataGrid";
            this.UkupnaStednjaDataGrid.Size = new System.Drawing.Size(633, 284);
            this.UkupnaStednjaDataGrid.TabIndex = 2;
            // 
            // IsplatiStednjuBtn
            // 
            this.IsplatiStednjuBtn.Location = new System.Drawing.Point(343, 390);
            this.IsplatiStednjuBtn.Name = "IsplatiStednjuBtn";
            this.IsplatiStednjuBtn.Size = new System.Drawing.Size(158, 36);
            this.IsplatiStednjuBtn.TabIndex = 3;
            this.IsplatiStednjuBtn.Text = "Isplati štednju";
            this.IsplatiStednjuBtn.UseVisualStyleBackColor = true;
            this.IsplatiStednjuBtn.Click += new System.EventHandler(this.IsplatiStednjuBtn_Click);
            // 
            // NazadBtn
            // 
            this.NazadBtn.Location = new System.Drawing.Point(507, 390);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(158, 36);
            this.NazadBtn.TabIndex = 4;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = true;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // UkupnaStednja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.IsplatiStednjuBtn);
            this.Controls.Add(this.UkupnaStednjaDataGrid);
            this.Controls.Add(this.UkupnaStednjaLbl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UkupnaStednja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UkupnaStednja";
            this.Load += new System.EventHandler(this.UkupnaStednja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UkupnaStednjaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UkupnaStednjaLbl;
        private System.Windows.Forms.DataGridView UkupnaStednjaDataGrid;
        private System.Windows.Forms.Button IsplatiStednjuBtn;
        private System.Windows.Forms.Button NazadBtn;
    }
}