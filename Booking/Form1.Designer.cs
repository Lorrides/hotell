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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.gjesteListe = new System.Windows.Forms.ListBox();
            this.bookingListe = new System.Windows.Forms.ListBox();
            this.etasjeOversiktTabControl = new System.Windows.Forms.TabControl();
            this.leggTilNyGjest = new System.Windows.Forms.Button();
            this.innsjekkDatoVelger = new System.Windows.Forms.DateTimePicker();
            this.innSjekkDatoLabel = new System.Windows.Forms.Label();
            this.utSjekkDatoLabel = new System.Windows.Forms.Label();
            this.utsjekkDatoVelger = new System.Windows.Forms.DateTimePicker();
            this.bakgrunnGjesteBestilling = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.navnPåGjestLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bakgrunnGjesteBestilling)).BeginInit();
            this.SuspendLayout();
            // 
            // nameInputBox
            // 
            this.nameInputBox.Location = new System.Drawing.Point(57, 95);
            this.nameInputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(189, 22);
            this.nameInputBox.TabIndex = 1;
            // 
            // gjesteListe
            // 
            this.gjesteListe.BackColor = System.Drawing.SystemColors.Info;
            this.gjesteListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gjesteListe.FormattingEnabled = true;
            this.gjesteListe.ItemHeight = 16;
            this.gjesteListe.Location = new System.Drawing.Point(17, 302);
            this.gjesteListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gjesteListe.Name = "gjesteListe";
            this.gjesteListe.Size = new System.Drawing.Size(273, 452);
            this.gjesteListe.TabIndex = 2;
            this.gjesteListe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gjesteListe_MouseDown);
            this.gjesteListe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gjesteListe_MouseMove);
            // 
            // bookingListe
            // 
            this.bookingListe.BackColor = System.Drawing.SystemColors.Info;
            this.bookingListe.FormattingEnabled = true;
            this.bookingListe.ItemHeight = 16;
            this.bookingListe.Location = new System.Drawing.Point(297, 14);
            this.bookingListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookingListe.Name = "bookingListe";
            this.bookingListe.Size = new System.Drawing.Size(267, 740);
            this.bookingListe.TabIndex = 4;
            // 
            // etasjeOversiktTabControl
            // 
            this.etasjeOversiktTabControl.Location = new System.Drawing.Point(571, 12);
            this.etasjeOversiktTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.etasjeOversiktTabControl.Name = "etasjeOversiktTabControl";
            this.etasjeOversiktTabControl.SelectedIndex = 0;
            this.etasjeOversiktTabControl.Size = new System.Drawing.Size(779, 742);
            this.etasjeOversiktTabControl.TabIndex = 3;
            // 
            // leggTilNyGjest
            // 
            this.leggTilNyGjest.Location = new System.Drawing.Point(60, 249);
            this.leggTilNyGjest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leggTilNyGjest.Name = "leggTilNyGjest";
            this.leggTilNyGjest.Size = new System.Drawing.Size(191, 36);
            this.leggTilNyGjest.TabIndex = 7;
            this.leggTilNyGjest.Text = "Legg til ny gjest";
            this.leggTilNyGjest.UseVisualStyleBackColor = true;
            this.leggTilNyGjest.Click += new System.EventHandler(this.button1_Click);
            // 
            // innsjekkDatoVelger
            // 
            this.innsjekkDatoVelger.CalendarMonthBackground = System.Drawing.Color.Tan;
            this.innsjekkDatoVelger.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.innsjekkDatoVelger.Location = new System.Drawing.Point(88, 155);
            this.innsjekkDatoVelger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.innsjekkDatoVelger.Name = "innsjekkDatoVelger";
            this.innsjekkDatoVelger.Size = new System.Drawing.Size(129, 22);
            this.innsjekkDatoVelger.TabIndex = 8;
            this.innsjekkDatoVelger.ValueChanged += new System.EventHandler(this.innSjekkDato_ValueChanged);
            // 
            // innSjekkDatoLabel
            // 
            this.innSjekkDatoLabel.AutoSize = true;
            this.innSjekkDatoLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.innSjekkDatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.innSjekkDatoLabel.Location = new System.Drawing.Point(55, 122);
            this.innSjekkDatoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.innSjekkDatoLabel.Name = "innSjekkDatoLabel";
            this.innSjekkDatoLabel.Size = new System.Drawing.Size(199, 29);
            this.innSjekkDatoLabel.TabIndex = 9;
            this.innSjekkDatoLabel.Text = "Innsjekkingsdato:";
            // 
            // utSjekkDatoLabel
            // 
            this.utSjekkDatoLabel.AutoSize = true;
            this.utSjekkDatoLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.utSjekkDatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utSjekkDatoLabel.Location = new System.Drawing.Point(55, 183);
            this.utSjekkDatoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.utSjekkDatoLabel.Name = "utSjekkDatoLabel";
            this.utSjekkDatoLabel.Size = new System.Drawing.Size(190, 29);
            this.utSjekkDatoLabel.TabIndex = 10;
            this.utSjekkDatoLabel.Text = "Utsjekkingsdato:";
            // 
            // utsjekkDatoVelger
            // 
            this.utsjekkDatoVelger.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.utsjekkDatoVelger.Location = new System.Drawing.Point(88, 217);
            this.utsjekkDatoVelger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.utsjekkDatoVelger.Name = "utsjekkDatoVelger";
            this.utsjekkDatoVelger.Size = new System.Drawing.Size(129, 22);
            this.utsjekkDatoVelger.TabIndex = 11;
            this.utsjekkDatoVelger.ValueChanged += new System.EventHandler(this.utsjekkDatoVelger_ValueChanged);
            // 
            // bakgrunnGjesteBestilling
            // 
            this.bakgrunnGjesteBestilling.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bakgrunnGjesteBestilling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bakgrunnGjesteBestilling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bakgrunnGjesteBestilling.Location = new System.Drawing.Point(17, 55);
            this.bakgrunnGjesteBestilling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bakgrunnGjesteBestilling.Name = "bakgrunnGjesteBestilling";
            this.bakgrunnGjesteBestilling.Size = new System.Drawing.Size(274, 240);
            this.bakgrunnGjesteBestilling.TabIndex = 12;
            this.bakgrunnGjesteBestilling.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(345, 343);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 116);
            this.listBox1.TabIndex = 13;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 464);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "navn her";
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            this.label1.DragOver += new System.Windows.Forms.DragEventHandler(this.label1_DragOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "H.O.O.K.E.R";
            // 
            // navnPåGjestLabel
            // 
            this.navnPåGjestLabel.AutoSize = true;
            this.navnPåGjestLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.navnPåGjestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navnPåGjestLabel.Location = new System.Drawing.Point(55, 63);
            this.navnPåGjestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.navnPåGjestLabel.Name = "navnPåGjestLabel";
            this.navnPåGjestLabel.Size = new System.Drawing.Size(165, 29);
            this.navnPåGjestLabel.TabIndex = 16;
            this.navnPåGjestLabel.Text = "Navn på gjest:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::Booking.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 773);
            this.Controls.Add(this.navnPåGjestLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.utsjekkDatoVelger);
            this.Controls.Add(this.utSjekkDatoLabel);
            this.Controls.Add(this.innSjekkDatoLabel);
            this.Controls.Add(this.innsjekkDatoVelger);
            this.Controls.Add(this.leggTilNyGjest);
            this.Controls.Add(this.bookingListe);
            this.Controls.Add(this.etasjeOversiktTabControl);
            this.Controls.Add(this.gjesteListe);
            this.Controls.Add(this.nameInputBox);
            this.Controls.Add(this.bakgrunnGjesteBestilling);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Hotell for originale kristne erkerivaler";
            ((System.ComponentModel.ISupportInitialize)(this.bakgrunnGjesteBestilling)).EndInit();
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
        private System.Windows.Forms.PictureBox bakgrunnGjesteBestilling;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label navnPåGjestLabel;
    }
}

