namespace uygulama2
{
    partial class Form1
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
            this.btnMavi = new System.Windows.Forms.Button();
            this.btnSari = new System.Windows.Forms.Button();
            this.btnSiyah = new System.Windows.Forms.Button();
            this.btnBeyaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMavi
            // 
            this.btnMavi.BackColor = System.Drawing.Color.Red;
            this.btnMavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMavi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMavi.Location = new System.Drawing.Point(209, 31);
            this.btnMavi.Name = "btnMavi";
            this.btnMavi.Size = new System.Drawing.Size(166, 166);
            this.btnMavi.TabIndex = 0;
            this.btnMavi.Text = "Kırmızı";
            this.btnMavi.UseVisualStyleBackColor = false;
            this.btnMavi.Click += new System.EventHandler(this.btnMavi_Click);
            // 
            // btnSari
            // 
            this.btnSari.BackColor = System.Drawing.Color.Gold;
            this.btnSari.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSari.Location = new System.Drawing.Point(381, 31);
            this.btnSari.Name = "btnSari";
            this.btnSari.Size = new System.Drawing.Size(166, 166);
            this.btnSari.TabIndex = 1;
            this.btnSari.Text = "Sarı";
            this.btnSari.UseVisualStyleBackColor = false;
            this.btnSari.Click += new System.EventHandler(this.btnSari_Click);
            // 
            // btnSiyah
            // 
            this.btnSiyah.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiyah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSiyah.Location = new System.Drawing.Point(381, 203);
            this.btnSiyah.Name = "btnSiyah";
            this.btnSiyah.Size = new System.Drawing.Size(166, 166);
            this.btnSiyah.TabIndex = 2;
            this.btnSiyah.Text = "Siyah";
            this.btnSiyah.UseVisualStyleBackColor = false;
            this.btnSiyah.Click += new System.EventHandler(this.btnSiyah_Click);
            // 
            // btnBeyaz
            // 
            this.btnBeyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeyaz.Location = new System.Drawing.Point(209, 203);
            this.btnBeyaz.Name = "btnBeyaz";
            this.btnBeyaz.Size = new System.Drawing.Size(166, 166);
            this.btnBeyaz.TabIndex = 3;
            this.btnBeyaz.Text = "Beyaz";
            this.btnBeyaz.UseVisualStyleBackColor = true;
            this.btnBeyaz.Click += new System.EventHandler(this.btnBeyaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBeyaz);
            this.Controls.Add(this.btnSiyah);
            this.Controls.Add(this.btnSari);
            this.Controls.Add(this.btnMavi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMavi;
        private System.Windows.Forms.Button btnSari;
        private System.Windows.Forms.Button btnSiyah;
        private System.Windows.Forms.Button btnBeyaz;
    }
}

