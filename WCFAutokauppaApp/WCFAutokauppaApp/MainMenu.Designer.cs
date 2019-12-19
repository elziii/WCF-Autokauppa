namespace WCFAutokauppaApp
{
    partial class MainMenu
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
            this.datePvm = new System.Windows.Forms.DateTimePicker();
            this.labelPvm = new System.Windows.Forms.Label();
            this.labelVari = new System.Windows.Forms.Label();
            this.labelPolttoaine = new System.Windows.Forms.Label();
            this.cbVarit = new System.Windows.Forms.ComboBox();
            this.cbPolttoaine = new System.Windows.Forms.ComboBox();
            this.btnSeuraava = new System.Windows.Forms.Button();
            this.btnEdellinen = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnTietue = new System.Windows.Forms.Button();
            this.labelMalli = new System.Windows.Forms.Label();
            this.labelMerkki = new System.Windows.Forms.Label();
            this.cbMalli = new System.Windows.Forms.ComboBox();
            this.labelHinta = new System.Windows.Forms.Label();
            this.labelTilavuus = new System.Windows.Forms.Label();
            this.labelMittarilukema = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbTilavuus = new System.Windows.Forms.TextBox();
            this.tbMittarilukema = new System.Windows.Forms.TextBox();
            this.testaaTietokantayhteysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMerkki = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePvm
            // 
            this.datePvm.CalendarForeColor = System.Drawing.Color.Black;
            this.datePvm.CalendarMonthBackground = System.Drawing.Color.White;
            this.datePvm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePvm.Location = new System.Drawing.Point(16, 259);
            this.datePvm.Name = "datePvm";
            this.datePvm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePvm.Size = new System.Drawing.Size(100, 20);
            this.datePvm.TabIndex = 44;
            // 
            // labelPvm
            // 
            this.labelPvm.AutoSize = true;
            this.labelPvm.Location = new System.Drawing.Point(125, 265);
            this.labelPvm.Name = "labelPvm";
            this.labelPvm.Size = new System.Drawing.Size(71, 13);
            this.labelPvm.TabIndex = 43;
            this.labelPvm.Text = "Rekisteri pvm";
            // 
            // labelVari
            // 
            this.labelVari.AutoSize = true;
            this.labelVari.Location = new System.Drawing.Point(142, 123);
            this.labelVari.Name = "labelVari";
            this.labelVari.Size = new System.Drawing.Size(25, 13);
            this.labelVari.TabIndex = 42;
            this.labelVari.Text = "Väri";
            // 
            // labelPolttoaine
            // 
            this.labelPolttoaine.AutoSize = true;
            this.labelPolttoaine.Location = new System.Drawing.Point(142, 96);
            this.labelPolttoaine.Name = "labelPolttoaine";
            this.labelPolttoaine.Size = new System.Drawing.Size(54, 13);
            this.labelPolttoaine.TabIndex = 41;
            this.labelPolttoaine.Text = "Polttoaine";
            // 
            // cbVarit
            // 
            this.cbVarit.BackColor = System.Drawing.Color.White;
            this.cbVarit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVarit.FormattingEnabled = true;
            this.cbVarit.Location = new System.Drawing.Point(15, 120);
            this.cbVarit.Name = "cbVarit";
            this.cbVarit.Size = new System.Drawing.Size(121, 21);
            this.cbVarit.TabIndex = 40;
            // 
            // cbPolttoaine
            // 
            this.cbPolttoaine.BackColor = System.Drawing.Color.White;
            this.cbPolttoaine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPolttoaine.FormattingEnabled = true;
            this.cbPolttoaine.Location = new System.Drawing.Point(15, 93);
            this.cbPolttoaine.Name = "cbPolttoaine";
            this.cbPolttoaine.Size = new System.Drawing.Size(121, 21);
            this.cbPolttoaine.TabIndex = 39;
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.BackColor = System.Drawing.Color.White;
            this.btnSeuraava.Location = new System.Drawing.Point(311, 178);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(78, 31);
            this.btnSeuraava.TabIndex = 38;
            this.btnSeuraava.Text = "Seuraava >";
            this.btnSeuraava.UseVisualStyleBackColor = false;
            this.btnSeuraava.Click += new System.EventHandler(this.btnSeuraava_Click);
            // 
            // btnEdellinen
            // 
            this.btnEdellinen.BackColor = System.Drawing.Color.White;
            this.btnEdellinen.Location = new System.Drawing.Point(227, 177);
            this.btnEdellinen.Name = "btnEdellinen";
            this.btnEdellinen.Size = new System.Drawing.Size(78, 31);
            this.btnEdellinen.TabIndex = 37;
            this.btnEdellinen.Text = "< Edellinen";
            this.btnEdellinen.UseVisualStyleBackColor = false;
            this.btnEdellinen.Click += new System.EventHandler(this.btnEdellinen_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.BackColor = System.Drawing.Color.White;
            this.btnPoista.Location = new System.Drawing.Point(311, 141);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(78, 31);
            this.btnPoista.TabIndex = 36;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = false;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.BackColor = System.Drawing.Color.White;
            this.btnTallenna.Location = new System.Drawing.Point(227, 141);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(78, 31);
            this.btnTallenna.TabIndex = 35;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = false;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // btnTietue
            // 
            this.btnTietue.BackColor = System.Drawing.Color.White;
            this.btnTietue.Location = new System.Drawing.Point(227, 105);
            this.btnTietue.Name = "btnTietue";
            this.btnTietue.Size = new System.Drawing.Size(162, 31);
            this.btnTietue.TabIndex = 34;
            this.btnTietue.Text = "Uusi tietue";
            this.btnTietue.UseVisualStyleBackColor = false;
            this.btnTietue.Click += new System.EventHandler(this.btnTietue_Click);
            // 
            // labelMalli
            // 
            this.labelMalli.AutoSize = true;
            this.labelMalli.Location = new System.Drawing.Point(142, 69);
            this.labelMalli.Name = "labelMalli";
            this.labelMalli.Size = new System.Drawing.Size(58, 13);
            this.labelMalli.TabIndex = 33;
            this.labelMalli.Text = "Auton malli";
            // 
            // labelMerkki
            // 
            this.labelMerkki.AutoSize = true;
            this.labelMerkki.Location = new System.Drawing.Point(142, 42);
            this.labelMerkki.Name = "labelMerkki";
            this.labelMerkki.Size = new System.Drawing.Size(69, 13);
            this.labelMerkki.TabIndex = 32;
            this.labelMerkki.Text = "Auton merkki";
            // 
            // cbMalli
            // 
            this.cbMalli.BackColor = System.Drawing.Color.White;
            this.cbMalli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMalli.FormattingEnabled = true;
            this.cbMalli.Location = new System.Drawing.Point(15, 66);
            this.cbMalli.Name = "cbMalli";
            this.cbMalli.Size = new System.Drawing.Size(121, 21);
            this.cbMalli.TabIndex = 31;
            // 
            // labelHinta
            // 
            this.labelHinta.AutoSize = true;
            this.labelHinta.Location = new System.Drawing.Point(122, 236);
            this.labelHinta.Name = "labelHinta";
            this.labelHinta.Size = new System.Drawing.Size(32, 13);
            this.labelHinta.TabIndex = 29;
            this.labelHinta.Text = "Hinta";
            // 
            // labelTilavuus
            // 
            this.labelTilavuus.AutoSize = true;
            this.labelTilavuus.Location = new System.Drawing.Point(121, 210);
            this.labelTilavuus.Name = "labelTilavuus";
            this.labelTilavuus.Size = new System.Drawing.Size(90, 13);
            this.labelTilavuus.TabIndex = 28;
            this.labelTilavuus.Text = "Moottorin tilavuus";
            // 
            // labelMittarilukema
            // 
            this.labelMittarilukema.AutoSize = true;
            this.labelMittarilukema.Location = new System.Drawing.Point(122, 184);
            this.labelMittarilukema.Name = "labelMittarilukema";
            this.labelMittarilukema.Size = new System.Drawing.Size(69, 13);
            this.labelMittarilukema.TabIndex = 27;
            this.labelMittarilukema.Text = "Mittarilukema";
            // 
            // tbHinta
            // 
            this.tbHinta.BackColor = System.Drawing.Color.White;
            this.tbHinta.Location = new System.Drawing.Point(16, 233);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(100, 20);
            this.tbHinta.TabIndex = 26;
            // 
            // tbTilavuus
            // 
            this.tbTilavuus.BackColor = System.Drawing.Color.White;
            this.tbTilavuus.Location = new System.Drawing.Point(16, 207);
            this.tbTilavuus.Name = "tbTilavuus";
            this.tbTilavuus.Size = new System.Drawing.Size(100, 20);
            this.tbTilavuus.TabIndex = 25;
            // 
            // tbMittarilukema
            // 
            this.tbMittarilukema.BackColor = System.Drawing.Color.White;
            this.tbMittarilukema.Location = new System.Drawing.Point(16, 181);
            this.tbMittarilukema.Name = "tbMittarilukema";
            this.tbMittarilukema.Size = new System.Drawing.Size(100, 20);
            this.tbMittarilukema.TabIndex = 24;
            // 
            // testaaTietokantayhteysToolStripMenuItem
            // 
            this.testaaTietokantayhteysToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.testaaTietokantayhteysToolStripMenuItem.Name = "testaaTietokantayhteysToolStripMenuItem";
            this.testaaTietokantayhteysToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.testaaTietokantayhteysToolStripMenuItem.Text = "Testaa tietokantayhteys";
            this.testaaTietokantayhteysToolStripMenuItem.Click += new System.EventHandler(this.testaaTietokantayhteysToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteysToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // cbMerkki
            // 
            this.cbMerkki.BackColor = System.Drawing.Color.White;
            this.cbMerkki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMerkki.FormattingEnabled = true;
            this.cbMerkki.Location = new System.Drawing.Point(15, 39);
            this.cbMerkki.Name = "cbMerkki";
            this.cbMerkki.Size = new System.Drawing.Size(121, 21);
            this.cbMerkki.TabIndex = 30;
            this.cbMerkki.DropDownClosed += new System.EventHandler(this.cbMerkki_DropDownClosed);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(436, 314);
            this.Controls.Add(this.datePvm);
            this.Controls.Add(this.labelPvm);
            this.Controls.Add(this.labelVari);
            this.Controls.Add(this.labelPolttoaine);
            this.Controls.Add(this.cbVarit);
            this.Controls.Add(this.cbPolttoaine);
            this.Controls.Add(this.btnSeuraava);
            this.Controls.Add(this.btnEdellinen);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.btnTietue);
            this.Controls.Add(this.labelMalli);
            this.Controls.Add(this.labelMerkki);
            this.Controls.Add(this.cbMalli);
            this.Controls.Add(this.labelHinta);
            this.Controls.Add(this.labelTilavuus);
            this.Controls.Add(this.labelMittarilukema);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbTilavuus);
            this.Controls.Add(this.tbMittarilukema);
            this.Controls.Add(this.cbMerkki);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePvm;
        private System.Windows.Forms.Label labelPvm;
        private System.Windows.Forms.Label labelVari;
        private System.Windows.Forms.Label labelPolttoaine;
        private System.Windows.Forms.ComboBox cbVarit;
        private System.Windows.Forms.ComboBox cbPolttoaine;
        private System.Windows.Forms.Button btnSeuraava;
        private System.Windows.Forms.Button btnEdellinen;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnTietue;
        private System.Windows.Forms.Label labelMalli;
        private System.Windows.Forms.Label labelMerkki;
        private System.Windows.Forms.ComboBox cbMalli;
        private System.Windows.Forms.Label labelHinta;
        private System.Windows.Forms.Label labelTilavuus;
        private System.Windows.Forms.Label labelMittarilukema;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbTilavuus;
        private System.Windows.Forms.TextBox tbMittarilukema;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbMerkki;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

