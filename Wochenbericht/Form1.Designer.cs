﻿namespace Wochenbericht
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.FileCreating = new System.Windows.Forms.Button();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.yearBox = new System.Windows.Forms.TextBox();
			this.lableName = new System.Windows.Forms.Label();
			this.year = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.vonWoche = new System.Windows.Forms.DateTimePicker();
			this.bisWoche = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.nachweisNummer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.department = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nameDokument = new System.Windows.Forms.TextBox();
			this.betrieblich = new System.Windows.Forms.TextBox();
			this.unterweisungeg = new System.Windows.Forms.TextBox();
			this.berufschule = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxClear1 = new System.Windows.Forms.Button();
			this.filesList = new System.Windows.Forms.ListView();
			this.aaaaaaa = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnRefrech = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// FileCreating
			// 
			this.FileCreating.BackColor = System.Drawing.Color.Gainsboro;
			this.FileCreating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FileCreating.Location = new System.Drawing.Point(557, 511);
			this.FileCreating.Margin = new System.Windows.Forms.Padding(5);
			this.FileCreating.Name = "FileCreating";
			this.FileCreating.Size = new System.Drawing.Size(154, 67);
			this.FileCreating.TabIndex = 0;
			this.FileCreating.Text = "Erstellen";
			this.FileCreating.UseVisualStyleBackColor = false;
			this.FileCreating.Click += new System.EventHandler(this.FileCreat);
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(66, 82);
			this.nameBox.Margin = new System.Windows.Forms.Padding(5);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(193, 26);
			this.nameBox.TabIndex = 1;
			// 
			// yearBox
			// 
			this.yearBox.Location = new System.Drawing.Point(296, 82);
			this.yearBox.Margin = new System.Windows.Forms.Padding(5);
			this.yearBox.Name = "yearBox";
			this.yearBox.Size = new System.Drawing.Size(189, 26);
			this.yearBox.TabIndex = 2;
			// 
			// lableName
			// 
			this.lableName.AutoSize = true;
			this.lableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lableName.Location = new System.Drawing.Point(62, 57);
			this.lableName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lableName.Name = "lableName";
			this.lableName.Size = new System.Drawing.Size(65, 20);
			this.lableName.TabIndex = 4;
			this.lableName.Text = "Name :";
			// 
			// year
			// 
			this.year.AutoSize = true;
			this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.year.Location = new System.Drawing.Point(292, 57);
			this.year.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.year.Name = "year";
			this.year.Size = new System.Drawing.Size(153, 20);
			this.year.TabIndex = 5;
			this.year.Text = "Ausbildungshahr :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 228);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Von :";
			// 
			// vonWoche
			// 
			this.vonWoche.Location = new System.Drawing.Point(66, 222);
			this.vonWoche.Margin = new System.Windows.Forms.Padding(5);
			this.vonWoche.Name = "vonWoche";
			this.vonWoche.Size = new System.Drawing.Size(419, 26);
			this.vonWoche.TabIndex = 7;
			// 
			// bisWoche
			// 
			this.bisWoche.Location = new System.Drawing.Point(66, 296);
			this.bisWoche.Margin = new System.Windows.Forms.Padding(5);
			this.bisWoche.Name = "bisWoche";
			this.bisWoche.Size = new System.Drawing.Size(419, 26);
			this.bisWoche.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 302);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Bis :";
			// 
			// nachweisNummer
			// 
			this.nachweisNummer.Location = new System.Drawing.Point(66, 147);
			this.nachweisNummer.Margin = new System.Windows.Forms.Padding(5);
			this.nachweisNummer.Name = "nachweisNummer";
			this.nachweisNummer.Size = new System.Drawing.Size(193, 26);
			this.nachweisNummer.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(62, 122);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Ausbildungsnachweis Nr :";
			// 
			// department
			// 
			this.department.Location = new System.Drawing.Point(296, 149);
			this.department.Margin = new System.Windows.Forms.Padding(5);
			this.department.Name = "department";
			this.department.Size = new System.Drawing.Size(189, 26);
			this.department.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(292, 122);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "Abteilung :";
			// 
			// nameDokument
			// 
			this.nameDokument.Location = new System.Drawing.Point(66, 389);
			this.nameDokument.Margin = new System.Windows.Forms.Padding(5);
			this.nameDokument.Name = "nameDokument";
			this.nameDokument.Size = new System.Drawing.Size(419, 26);
			this.nameDokument.TabIndex = 14;
			// 
			// betrieblich
			// 
			this.betrieblich.Location = new System.Drawing.Point(557, 82);
			this.betrieblich.Margin = new System.Windows.Forms.Padding(5);
			this.betrieblich.Multiline = true;
			this.betrieblich.Name = "betrieblich";
			this.betrieblich.Size = new System.Drawing.Size(388, 118);
			this.betrieblich.TabIndex = 16;
			// 
			// unterweisungeg
			// 
			this.unterweisungeg.Location = new System.Drawing.Point(557, 250);
			this.unterweisungeg.Margin = new System.Windows.Forms.Padding(5);
			this.unterweisungeg.Multiline = true;
			this.unterweisungeg.Name = "unterweisungeg";
			this.unterweisungeg.Size = new System.Drawing.Size(388, 113);
			this.unterweisungeg.TabIndex = 17;
			// 
			// berufschule
			// 
			this.berufschule.Location = new System.Drawing.Point(557, 389);
			this.berufschule.Margin = new System.Windows.Forms.Padding(5);
			this.berufschule.Multiline = true;
			this.berufschule.Name = "berufschule";
			this.berufschule.Size = new System.Drawing.Size(388, 112);
			this.berufschule.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(552, 51);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(178, 20);
			this.label5.TabIndex = 19;
			this.label5.Text = "Betriebliche Tätigkeit";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(552, 205);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(343, 40);
			this.label6.TabIndex = 20;
			this.label6.Text = "Unterweisungen, betrieblicher Unterricht, \r\nsonstige Schulungen";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(552, 364);
			this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(280, 20);
			this.label7.TabIndex = 21;
			this.label7.Text = "Berufsschule (Unterrichtsthemen)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(62, 351);
			this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(147, 20);
			this.label8.TabIndex = 22;
			this.label8.Text = "Document Name:";
			// 
			// textBoxClear1
			// 
			this.textBoxClear1.BackColor = System.Drawing.Color.Gainsboro;
			this.textBoxClear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxClear1.Location = new System.Drawing.Point(795, 511);
			this.textBoxClear1.Margin = new System.Windows.Forms.Padding(5);
			this.textBoxClear1.Name = "textBoxClear1";
			this.textBoxClear1.Size = new System.Drawing.Size(150, 67);
			this.textBoxClear1.TabIndex = 23;
			this.textBoxClear1.Text = "Felder leeren";
			this.textBoxClear1.UseVisualStyleBackColor = false;
			this.textBoxClear1.Click += new System.EventHandler(this.TextBoxClear);
			// 
			// filesList
			// 
			this.filesList.BackColor = System.Drawing.Color.White;
			this.filesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filesList.HideSelection = false;
			this.filesList.Location = new System.Drawing.Point(990, 82);
			this.filesList.Margin = new System.Windows.Forms.Padding(4);
			this.filesList.Name = "filesList";
			this.filesList.Size = new System.Drawing.Size(241, 333);
			this.filesList.TabIndex = 26;
			this.filesList.UseCompatibleStateImageBehavior = false;
			this.filesList.View = System.Windows.Forms.View.List;
		
			this.filesList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filesList_MouseClick);
			// 
			// aaaaaaa
			// 
			this.aaaaaaa.AutoSize = true;
			this.aaaaaaa.Location = new System.Drawing.Point(5, 611);
			this.aaaaaaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.aaaaaaa.Name = "aaaaaaa";
			this.aaaaaaa.Size = new System.Drawing.Size(109, 20);
			this.aaaaaaa.TabIndex = 28;
			this.aaaaaaa.Text = "TESTLABLE";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1599, 24);
			this.menuStrip1.TabIndex = 29;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFilesToolStripMenuItem,
            this.OpenFolderToolStripMenuItem,
            this.beendenToolStripMenuItem});
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.exitToolStripMenuItem.Text = "Menu";
			// 
			// openFilesToolStripMenuItem
			// 
			this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
			this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.openFilesToolStripMenuItem.Text = "OpenFiles";
			this.openFilesToolStripMenuItem.Click += new System.EventHandler(this.openFilesToolStripMenuItem_Click);
			// 
			// OpenFolderToolStripMenuItem
			// 
			this.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem";
			this.OpenFolderToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.OpenFolderToolStripMenuItem.Text = "Alle Dokumente";
			this.OpenFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.beendenToolStripMenuItem.Text = "Beenden";
			this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// btnRefrech
			// 
			this.btnRefrech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnRefrech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRefrech.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefrech.Location = new System.Drawing.Point(990, 434);
			this.btnRefrech.Margin = new System.Windows.Forms.Padding(5);
			this.btnRefrech.Name = "btnRefrech";
			this.btnRefrech.Size = new System.Drawing.Size(156, 67);
			this.btnRefrech.TabIndex = 30;
			this.btnRefrech.Text = "Aktualisieren";
			this.btnRefrech.UseVisualStyleBackColor = false;
			this.btnRefrech.Click += new System.EventHandler(this.btnRefrech_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1599, 767);
			this.Controls.Add(this.btnRefrech);
			this.Controls.Add(this.aaaaaaa);
			this.Controls.Add(this.filesList);
			this.Controls.Add(this.textBoxClear1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.berufschule);
			this.Controls.Add(this.unterweisungeg);
			this.Controls.Add(this.nameDokument);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.department);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nachweisNummer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bisWoche);
			this.Controls.Add(this.vonWoche);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.year);
			this.Controls.Add(this.lableName);
			this.Controls.Add(this.yearBox);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.FileCreating);
			this.Controls.Add(this.betrieblich);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Form1";
			this.Text = "Wochenbericht";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileCreating;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker vonWoche;
        private System.Windows.Forms.DateTimePicker bisWoche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nachweisNummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameDokument;
        private System.Windows.Forms.TextBox betrieblich;
        private System.Windows.Forms.TextBox unterweisungeg;
        private System.Windows.Forms.TextBox berufschule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button textBoxClear1;
        public System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label aaaaaaa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        public System.Windows.Forms.ListView filesList;
        private System.Windows.Forms.Button btnRefrech;
		private System.Windows.Forms.ToolStripMenuItem openFilesToolStripMenuItem;
	}
}

