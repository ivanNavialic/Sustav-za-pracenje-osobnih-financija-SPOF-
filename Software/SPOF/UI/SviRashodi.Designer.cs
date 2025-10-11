namespace SPOF.UI
{
    partial class SviRashodi
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
            this.SviRashodiDataGrid = new System.Windows.Forms.DataGridView();
            this.NazadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SviRashodiDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Svi rashodi:";
            // 
            // SviRashodiDataGrid
            // 
            this.SviRashodiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SviRashodiDataGrid.Location = new System.Drawing.Point(30, 83);
            this.SviRashodiDataGrid.Name = "SviRashodiDataGrid";
            this.SviRashodiDataGrid.Size = new System.Drawing.Size(632, 307);
            this.SviRashodiDataGrid.TabIndex = 1;
            // 
            // NazadBtn
            // 
            this.NazadBtn.Location = new System.Drawing.Point(543, 401);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(119, 37);
            this.NazadBtn.TabIndex = 2;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = true;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // SviRashodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.SviRashodiDataGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SviRashodi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SviRashodi";
            this.Load += new System.EventHandler(this.SviRashodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SviRashodiDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SviRashodiDataGrid;
        private System.Windows.Forms.Button NazadBtn;
    }
}