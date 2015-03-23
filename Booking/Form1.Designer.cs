namespace Booking
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
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.gjesteListe = new System.Windows.Forms.ListBox();
            this.bookingListe = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.leggTilNyGjest = new System.Windows.Forms.Button();
            this.innSjekkDato = new System.Windows.Forms.DateTimePicker();
            this.innSjekkDatoLabel = new System.Windows.Forms.Label();
            this.utSjekkDatoLabel = new System.Windows.Forms.Label();
            this.utSjekkDato = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameInputBox
            // 
            this.nameInputBox.Location = new System.Drawing.Point(12, 10);
            this.nameInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(207, 20);
            this.nameInputBox.TabIndex = 1;
            // 
            // gjesteListe
            // 
            this.gjesteListe.FormattingEnabled = true;
            this.gjesteListe.Location = new System.Drawing.Point(11, 71);
            this.gjesteListe.Margin = new System.Windows.Forms.Padding(2);
            this.gjesteListe.Name = "gjesteListe";
            this.gjesteListe.Size = new System.Drawing.Size(206, 355);
            this.gjesteListe.TabIndex = 2;
            // 
            // bookingListe
            // 
            this.bookingListe.FormattingEnabled = true;
            this.bookingListe.Location = new System.Drawing.Point(223, 19);
            this.bookingListe.Margin = new System.Windows.Forms.Padding(2);
            this.bookingListe.Name = "bookingListe";
            this.bookingListe.Size = new System.Drawing.Size(201, 576);
            this.bookingListe.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(576, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3. etg";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(576, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2. etg";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(428, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 585);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(576, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. etg";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // leggTilNyGjest
            // 
            this.leggTilNyGjest.Location = new System.Drawing.Point(12, 35);
            this.leggTilNyGjest.Name = "leggTilNyGjest";
            this.leggTilNyGjest.Size = new System.Drawing.Size(207, 29);
            this.leggTilNyGjest.TabIndex = 7;
            this.leggTilNyGjest.Text = "Legg til ny gjest";
            this.leggTilNyGjest.UseVisualStyleBackColor = true;
            this.leggTilNyGjest.Click += new System.EventHandler(this.button1_Click);
            // 
            // innSjekkDato
            // 
            this.innSjekkDato.Location = new System.Drawing.Point(11, 521);
            this.innSjekkDato.Name = "innSjekkDato";
            this.innSjekkDato.Size = new System.Drawing.Size(200, 20);
            this.innSjekkDato.TabIndex = 8;
            // 
            // innSjekkDatoLabel
            // 
            this.innSjekkDatoLabel.AutoSize = true;
            this.innSjekkDatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.innSjekkDatoLabel.Location = new System.Drawing.Point(27, 494);
            this.innSjekkDatoLabel.Name = "innSjekkDatoLabel";
            this.innSjekkDatoLabel.Size = new System.Drawing.Size(159, 24);
            this.innSjekkDatoLabel.TabIndex = 9;
            this.innSjekkDatoLabel.Text = "Innsjekkings dato:";
            // 
            // utSjekkDatoLabel
            // 
            this.utSjekkDatoLabel.AutoSize = true;
            this.utSjekkDatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utSjekkDatoLabel.Location = new System.Drawing.Point(27, 544);
            this.utSjekkDatoLabel.Name = "utSjekkDatoLabel";
            this.utSjekkDatoLabel.Size = new System.Drawing.Size(150, 24);
            this.utSjekkDatoLabel.TabIndex = 10;
            this.utSjekkDatoLabel.Text = "Utsjekkings dato:";
            // 
            // utSjekkDato
            // 
            this.utSjekkDato.Location = new System.Drawing.Point(12, 571);
            this.utSjekkDato.Name = "utSjekkDato";
            this.utSjekkDato.Size = new System.Drawing.Size(200, 20);
            this.utSjekkDato.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 606);
            this.Controls.Add(this.utSjekkDato);
            this.Controls.Add(this.utSjekkDatoLabel);
            this.Controls.Add(this.innSjekkDatoLabel);
            this.Controls.Add(this.innSjekkDato);
            this.Controls.Add(this.leggTilNyGjest);
            this.Controls.Add(this.bookingListe);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gjesteListe);
            this.Controls.Add(this.nameInputBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.ListBox gjesteListe;
        private System.Windows.Forms.ListBox bookingListe;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button leggTilNyGjest;
        private System.Windows.Forms.DateTimePicker innSjekkDato;
        private System.Windows.Forms.Label innSjekkDatoLabel;
        private System.Windows.Forms.Label utSjekkDatoLabel;
        private System.Windows.Forms.DateTimePicker utSjekkDato;
    }
}

