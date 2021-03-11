namespace VlaknaFormCas
{
    partial class frmOvladaciPanel
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
            this.tlZobrazuj = new System.Windows.Forms.Button();
            this.tlNezobrazuj = new System.Windows.Forms.Button();
            this.tlKonec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlZobrazuj
            // 
            this.tlZobrazuj.Location = new System.Drawing.Point(43, 36);
            this.tlZobrazuj.Name = "tlZobrazuj";
            this.tlZobrazuj.Size = new System.Drawing.Size(127, 23);
            this.tlZobrazuj.TabIndex = 0;
            this.tlZobrazuj.Text = "zobrazuj";
            this.tlZobrazuj.UseVisualStyleBackColor = true;
            this.tlZobrazuj.Click += new System.EventHandler(this.tlZobrazuj_Click);
            // 
            // tlNezobrazuj
            // 
            this.tlNezobrazuj.Location = new System.Drawing.Point(42, 83);
            this.tlNezobrazuj.Name = "tlNezobrazuj";
            this.tlNezobrazuj.Size = new System.Drawing.Size(128, 23);
            this.tlNezobrazuj.TabIndex = 1;
            this.tlNezobrazuj.Text = "nezobrazuj";
            this.tlNezobrazuj.UseVisualStyleBackColor = true;
            this.tlNezobrazuj.Click += new System.EventHandler(this.tlNezobrazuj_Click);
            // 
            // tlKonec
            // 
            this.tlKonec.Location = new System.Drawing.Point(43, 130);
            this.tlKonec.Name = "tlKonec";
            this.tlKonec.Size = new System.Drawing.Size(127, 23);
            this.tlKonec.TabIndex = 2;
            this.tlKonec.Text = "konec";
            this.tlKonec.UseVisualStyleBackColor = true;
            this.tlKonec.Click += new System.EventHandler(this.tlKonec_Click);
            // 
            // frmOvladaciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 197);
            this.Controls.Add(this.tlKonec);
            this.Controls.Add(this.tlNezobrazuj);
            this.Controls.Add(this.tlZobrazuj);
            this.Name = "frmOvladaciPanel";
            this.Text = "Ovládací panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlZobrazuj;
        private System.Windows.Forms.Button tlNezobrazuj;
        private System.Windows.Forms.Button tlKonec;
    }
}

