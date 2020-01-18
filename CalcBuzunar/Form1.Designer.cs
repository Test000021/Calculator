namespace CalcBuzunar
{
    partial class Calculator
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
            this.textBoxSus = new System.Windows.Forms.TextBox();
            this.textBoxJos = new System.Windows.Forms.TextBox();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdunare = new System.Windows.Forms.Button();
            this.buttonScadere = new System.Windows.Forms.Button();
            this.buttonInmultire = new System.Windows.Forms.Button();
            this.buttonImpartirea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSus
            // 
            this.textBoxSus.Location = new System.Drawing.Point(12, 21);
            this.textBoxSus.Name = "textBoxSus";
            this.textBoxSus.Size = new System.Drawing.Size(198, 20);
            this.textBoxSus.TabIndex = 0;
            // 
            // textBoxJos
            // 
            this.textBoxJos.Location = new System.Drawing.Point(13, 60);
            this.textBoxJos.Name = "textBoxJos";
            this.textBoxJos.Size = new System.Drawing.Size(197, 20);
            this.textBoxJos.TabIndex = 1;
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(13, 125);
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(197, 20);
            this.textBoxRezultat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "---------------------------------------------------------------";
            // 
            // buttonAdunare
            // 
            this.buttonAdunare.Location = new System.Drawing.Point(15, 167);
            this.buttonAdunare.Name = "buttonAdunare";
            this.buttonAdunare.Size = new System.Drawing.Size(41, 32);
            this.buttonAdunare.TabIndex = 4;
            this.buttonAdunare.Text = "+";
            this.buttonAdunare.UseVisualStyleBackColor = true;
            this.buttonAdunare.Click += new System.EventHandler(this.buttonAdunare_Click);
            // 
            // buttonScadere
            // 
            this.buttonScadere.Location = new System.Drawing.Point(60, 167);
            this.buttonScadere.Name = "buttonScadere";
            this.buttonScadere.Size = new System.Drawing.Size(41, 32);
            this.buttonScadere.TabIndex = 5;
            this.buttonScadere.Text = "-";
            this.buttonScadere.UseVisualStyleBackColor = true;
            this.buttonScadere.Click += new System.EventHandler(this.buttonScadere_Click);
            // 
            // buttonInmultire
            // 
            this.buttonInmultire.Location = new System.Drawing.Point(107, 167);
            this.buttonInmultire.Name = "buttonInmultire";
            this.buttonInmultire.Size = new System.Drawing.Size(40, 32);
            this.buttonInmultire.TabIndex = 6;
            this.buttonInmultire.Text = "*";
            this.buttonInmultire.UseVisualStyleBackColor = true;
            this.buttonInmultire.Click += new System.EventHandler(this.buttonInmultire_Click);
            // 
            // buttonImpartirea
            // 
            this.buttonImpartirea.Location = new System.Drawing.Point(153, 167);
            this.buttonImpartirea.Name = "buttonImpartirea";
            this.buttonImpartirea.Size = new System.Drawing.Size(39, 32);
            this.buttonImpartirea.TabIndex = 7;
            this.buttonImpartirea.Text = "/";
            this.buttonImpartirea.UseVisualStyleBackColor = true;
            this.buttonImpartirea.Click += new System.EventHandler(this.buttonImpartirea_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 262);
            this.Controls.Add(this.buttonImpartirea);
            this.Controls.Add(this.buttonInmultire);
            this.Controls.Add(this.buttonScadere);
            this.Controls.Add(this.buttonAdunare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.textBoxJos);
            this.Controls.Add(this.textBoxSus);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSus;
        private System.Windows.Forms.TextBox textBoxJos;
        private System.Windows.Forms.TextBox textBoxRezultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdunare;
        private System.Windows.Forms.Button buttonScadere;
        private System.Windows.Forms.Button buttonInmultire;
        private System.Windows.Forms.Button buttonImpartirea;
    }
}

