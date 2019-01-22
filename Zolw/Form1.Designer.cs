namespace Zolw
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.btnNaprzod = new System.Windows.Forms.Button();
            this.txtKrok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnRysujDrzewo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.Color.White;
            this.pctBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBox.Location = new System.Drawing.Point(26, 24);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(389, 263);
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            // 
            // btnNaprzod
            // 
            this.btnNaprzod.Location = new System.Drawing.Point(430, 116);
            this.btnNaprzod.Name = "btnNaprzod";
            this.btnNaprzod.Size = new System.Drawing.Size(75, 23);
            this.btnNaprzod.TabIndex = 1;
            this.btnNaprzod.Text = "Naprzod";
            this.btnNaprzod.UseVisualStyleBackColor = true;
            this.btnNaprzod.Click += new System.EventHandler(this.btnNaprzod_Click);
            // 
            // txtKrok
            // 
            this.txtKrok.Location = new System.Drawing.Point(436, 37);
            this.txtKrok.Name = "txtKrok";
            this.txtKrok.Size = new System.Drawing.Size(69, 20);
            this.txtKrok.TabIndex = 2;
            this.txtKrok.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "krok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "kat ->";
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(531, 36);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(56, 20);
            this.txtKat.TabIndex = 5;
            this.txtKat.Text = "0";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Black;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor.Location = new System.Drawing.Point(531, 74);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(56, 23);
            this.lblColor.TabIndex = 6;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // btnRysujDrzewo
            // 
            this.btnRysujDrzewo.Location = new System.Drawing.Point(452, 205);
            this.btnRysujDrzewo.Name = "btnRysujDrzewo";
            this.btnRysujDrzewo.Size = new System.Drawing.Size(125, 23);
            this.btnRysujDrzewo.TabIndex = 7;
            this.btnRysujDrzewo.Text = "RysujDrzewo";
            this.btnRysujDrzewo.UseVisualStyleBackColor = true;
            this.btnRysujDrzewo.Click += new System.EventHandler(this.btnRysujDrzewo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 319);
            this.Controls.Add(this.btnRysujDrzewo);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKrok);
            this.Controls.Add(this.btnNaprzod);
            this.Controls.Add(this.pctBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Button btnNaprzod;
        private System.Windows.Forms.TextBox txtKrok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.ColorDialog colorDlg;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnRysujDrzewo;
    }
}

