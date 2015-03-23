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
            this.etasjeOversiktTabControl = new System.Windows.Forms.TabControl();
            this.leggTilNyGjest = new System.Windows.Forms.Button();
            this.innsjekkDatoVelger = new System.Windows.Forms.DateTimePicker();
            this.innSjekkDatoLabel = new System.Windows.Forms.Label();
            this.utSjekkDatoLabel = new System.Windows.Forms.Label();
            this.utsjekkDatoVelger = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameInputBox
            // 
            this.nameInputBox.Location = new System.Drawing.Point(38, 22);
            this.nameInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(143, 20);
            this.nameInputBox.TabIndex = 1;
            // 
            // gjesteListe
            // 
            this.gjesteListe.FormattingEnabled = true;
            this.gjesteListe.Location = new System.Drawing.Point(13, 193);
            this.gjesteListe.Margin = new System.Windows.Forms.Padding(2);
            this.gjesteListe.Name = "gjesteListe";
            this.gjesteListe.Size = new System.Drawing.Size(206, 394);
            this.gjesteListe.TabIndex = 2;
            // 
            // bookingListe
            // 
            this.bookingListe.FormattingEnabled = true;
            this.bookingListe.Location = new System.Drawing.Point(223, 11);
            this.bookingListe.Margin = new System.Windows.Forms.Padding(2);
            this.bookingListe.Name = "bookingListe";
            this.bookingListe.Size = new System.Drawing.Size(201, 576);
            this.bookingListe.TabIndex = 4;
            // 
            // etasjeOversiktTabControl
            // 
            this.etasjeOversiktTabControl.Location = new System.Drawing.Point(428, 10);
            this.etasjeOversiktTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.etasjeOversiktTabControl.Name = "etasjeOversiktTabControl";
            this.etasjeOversiktTabControl.SelectedIndex = 0;
            this.etasjeOversiktTabControl.Size = new System.Drawing.Size(584, 585);
            this.etasjeOversiktTabControl.TabIndex = 3;
            // 
            // leggTilNyGjest
            // 
            this.leggTilNyGjest.Location = new System.Drawing.Point(38, 147);
            this.leggTilNyGjest.Name = "leggTilNyGjest";
            this.leggTilNyGjest.Size = new System.Drawing.Size(143, 29);
            this.leggTilNyGjest.TabIndex = 7;
            this.leggTilNyGjest.Text = "Legg til ny gjest";
            this.leggTilNyGjest.UseVisualStyleBackColor = true;
            this.leggTilNyGjest.Click += new System.EventHandler(this.button1_Click);
            // 
            // innsjekkDatoVelger
            // 
            this.innsjekkDatoVelger.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.innsjekkDatoVelger.Location = new System.Drawing.Point(55, 71);
            this.innsjekkDatoVelger.Name = "innsjekkDatoVelger";
            this.innsjekkDatoVelger.Size = new System.Drawing.Size(98, 20);
            this.innsjekkDatoVelger.TabIndex = 8;
            this.innsjekkDatoVelger.ValueChanged += new System.EventHandler(this.innSjekkDato_ValueChanged);
            // 
            // innSjekkDatoLabel
            // 
            this.innSjekkDatoLabel.AutoSize = true;
            this.innSjekkDatoLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.innSjekkDatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.innSjekkDatoLabel.Location = new System.Drawing.Point(34, 44);
            this.innSjekkDatoLabel.Name = "innSjekkDatoLabel";
            this.innSjekkDatoLabel.Size = new System.Drawing.Size(154, 24);
            this.innSjekkDatoLabel.TabIndex = 9;
            this.innSjekkDatoLabel.Text = "Innsjekkingsdato:";
            // 
            // utSjekkDatoLabel
            // 
            this.utSjekkDatoLabel.AutoSize = true;
            this.utSjekkDatoLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.utSjekkDatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utSjekkDatoLabel.Location = new System.Drawing.Point(34, 94);
            this.utSjekkDatoLabel.Name = "utSjekkDatoLabel";
            this.utSjekkDatoLabel.Size = new System.Drawing.Size(145, 24);
            this.utSjekkDatoLabel.TabIndex = 10;
            this.utSjekkDatoLabel.Text = "Utsjekkingsdato:";
            // 
            // utsjekkDatoVelger
            // 
            this.utsjekkDatoVelger.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.utsjekkDatoVelger.Location = new System.Drawing.Point(55, 121);
            this.utsjekkDatoVelger.Name = "utsjekkDatoVelger";
            this.utsjekkDatoVelger.Size = new System.Drawing.Size(98, 20);
            this.utsjekkDatoVelger.TabIndex = 11;
            this.utsjekkDatoVelger.ValueChanged += new System.EventHandler(this.utsjekkDatoVelger_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 177);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 606);
            this.Controls.Add(this.utsjekkDatoVelger);
            this.Controls.Add(this.utSjekkDatoLabel);
            this.Controls.Add(this.innSjekkDatoLabel);
            this.Controls.Add(this.innsjekkDatoVelger);
            this.Controls.Add(this.leggTilNyGjest);
            this.Controls.Add(this.bookingListe);
            this.Controls.Add(this.etasjeOversiktTabControl);
            this.Controls.Add(this.gjesteListe);
            this.Controls.Add(this.nameInputBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.ListBox gjesteListe;
        private System.Windows.Forms.ListBox bookingListe;
        internal System.Windows.Forms.TabControl etasjeOversiktTabControl;
        private System.Windows.Forms.Button leggTilNyGjest;
        private System.Windows.Forms.DateTimePicker innsjekkDatoVelger;
        private System.Windows.Forms.Label innSjekkDatoLabel;
        private System.Windows.Forms.Label utSjekkDatoLabel;
        private System.Windows.Forms.DateTimePicker utsjekkDatoVelger;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

