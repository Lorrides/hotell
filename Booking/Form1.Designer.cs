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
            this.nameInputBox.Location = new System.Drawing.Point(43, 77);
            this.nameInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(143, 20);
            this.nameInputBox.TabIndex = 1;
            // 
            // gjesteListe
            // 
            this.gjesteListe.BackColor = System.Drawing.SystemColors.Info;
            this.gjesteListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gjesteListe.FormattingEnabled = true;
            this.gjesteListe.Location = new System.Drawing.Point(13, 245);
            this.gjesteListe.Margin = new System.Windows.Forms.Padding(2);
            this.gjesteListe.Name = "gjesteListe";
            this.gjesteListe.Size = new System.Drawing.Size(206, 368);
            this.gjesteListe.TabIndex = 2;
            this.gjesteListe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gjesteListe_MouseDown);
            this.gjesteListe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gjesteListe_MouseMove);
            // 
            // bookingListe
            // 
            this.bookingListe.BackColor = System.Drawing.SystemColors.Info;
            this.bookingListe.FormattingEnabled = true;
            this.bookingListe.Location = new System.Drawing.Point(223, 11);
            this.bookingListe.Margin = new System.Windows.Forms.Padding(2);
            this.bookingListe.Name = "bookingListe";
            this.bookingListe.Size = new System.Drawing.Size(201, 602);
            this.bookingListe.TabIndex = 4;
            // 
            // etasjeOversiktTabControl
            // 
            this.etasjeOversiktTabControl.Location = new System.Drawing.Point(428, 10);
            this.etasjeOversiktTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.etasjeOversiktTabControl.Name = "etasjeOversiktTabControl";
            this.etasjeOversiktTabControl.SelectedIndex = 0;
            this.etasjeOversiktTabControl.Size = new System.Drawing.Size(584, 603);
            this.etasjeOversiktTabControl.TabIndex = 3;
            // 
            // leggTilNyGjest
            // 
            this.leggTilNyGjest.Location = new System.Drawing.Point(45, 202);
            this.leggTilNyGjest.Name = "leggTilNyGjest";
            this.leggTilNyGjest.Size = new System.Drawing.Size(143, 29);
            this.leggTilNyGjest.TabIndex = 7;
            this.leggTilNyGjest.Text = "Legg til ny gjest";
            this.leggTilNyGjest.UseVisualStyleBackColor = true;
            this.leggTilNyGjest.Click += new System.EventHandler(this.button1_Click);
            // 
            // innsjekkDatoVelger
            // 
            this.innsjekkDatoVelger.CalendarMonthBackground = System.Drawing.Color.Tan;
            this.innsjekkDatoVelger.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.innsjekkDatoVelger.Location = new System.Drawing.Point(66, 126);
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
            this.innSjekkDatoLabel.Location = new System.Drawing.Point(41, 99);
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
            this.utSjekkDatoLabel.Location = new System.Drawing.Point(41, 149);
            this.utSjekkDatoLabel.Name = "utSjekkDatoLabel";
            this.utSjekkDatoLabel.Size = new System.Drawing.Size(145, 24);
            this.utSjekkDatoLabel.TabIndex = 10;
            this.utSjekkDatoLabel.Text = "Utsjekkingsdato:";
            // 
            // utsjekkDatoVelger
            // 
            this.utsjekkDatoVelger.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.utsjekkDatoVelger.Location = new System.Drawing.Point(66, 176);
            this.utsjekkDatoVelger.Name = "utsjekkDatoVelger";
            this.utsjekkDatoVelger.Size = new System.Drawing.Size(98, 20);
            this.utsjekkDatoVelger.TabIndex = 11;
            this.utsjekkDatoVelger.ValueChanged += new System.EventHandler(this.utsjekkDatoVelger_ValueChanged);
            // 
            // bakgrunnGjesteBestilling
            // 
            this.bakgrunnGjesteBestilling.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bakgrunnGjesteBestilling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bakgrunnGjesteBestilling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bakgrunnGjesteBestilling.Location = new System.Drawing.Point(13, 45);
            this.bakgrunnGjesteBestilling.Name = "bakgrunnGjesteBestilling";
            this.bakgrunnGjesteBestilling.Size = new System.Drawing.Size(206, 195);
            this.bakgrunnGjesteBestilling.TabIndex = 12;
            this.bakgrunnGjesteBestilling.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(259, 279);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(130, 95);
            this.listBox1.TabIndex = 13;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
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
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "H.O.O.K.E.R";
            // 
            // navnPåGjestLabel
            // 
            this.navnPåGjestLabel.AutoSize = true;
            this.navnPåGjestLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.navnPåGjestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navnPåGjestLabel.Location = new System.Drawing.Point(41, 51);
            this.navnPåGjestLabel.Name = "navnPåGjestLabel";
            this.navnPåGjestLabel.Size = new System.Drawing.Size(129, 24);
            this.navnPåGjestLabel.TabIndex = 16;
            this.navnPåGjestLabel.Text = "Navn på gjest:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::Booking.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 628);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hotell for orginale kristene erke rivaler";
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

