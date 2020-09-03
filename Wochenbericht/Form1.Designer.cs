namespace Wochenbericht
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Die erste Woche");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Die Zweite Woche");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Die dritte Woche");
            this.FileCreating = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vonWoche = new System.Windows.Forms.DateTimePicker();
            this.bisWoche = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nachweisNummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.betrieblich = new System.Windows.Forms.TextBox();
            this.unterweisungeg = new System.Windows.Forms.TextBox();
            this.berufschule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // FileCreating
            // 
            this.FileCreating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FileCreating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileCreating.Location = new System.Drawing.Point(1053, 415);
            this.FileCreating.Margin = new System.Windows.Forms.Padding(4);
            this.FileCreating.Name = "FileCreating";
            this.FileCreating.Size = new System.Drawing.Size(173, 70);
            this.FileCreating.TabIndex = 0;
            this.FileCreating.Text = "Erstellen";
            this.FileCreating.UseVisualStyleBackColor = false;
            this.FileCreating.Click += new System.EventHandler(this.FileCreat);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(661, 46);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(155, 22);
            this.nameBox.TabIndex = 1;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(845, 46);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(152, 22);
            this.yearBox.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(658, 26);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 16);
            this.name.TabIndex = 4;
            this.name.Text = "Name :";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(842, 26);
            this.year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(108, 16);
            this.year.TabIndex = 5;
            this.year.Text = "Ausbildungshahr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Von :";
            // 
            // vonWoche
            // 
            this.vonWoche.Location = new System.Drawing.Point(661, 158);
            this.vonWoche.Margin = new System.Windows.Forms.Padding(4);
            this.vonWoche.Name = "vonWoche";
            this.vonWoche.Size = new System.Drawing.Size(336, 22);
            this.vonWoche.TabIndex = 7;
            // 
            // bisWoche
            // 
            this.bisWoche.Location = new System.Drawing.Point(661, 217);
            this.bisWoche.Margin = new System.Windows.Forms.Padding(4);
            this.bisWoche.Name = "bisWoche";
            this.bisWoche.Size = new System.Drawing.Size(336, 22);
            this.bisWoche.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(617, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bis :";
            // 
            // nachweisNummer
            // 
            this.nachweisNummer.Location = new System.Drawing.Point(661, 98);
            this.nachweisNummer.Margin = new System.Windows.Forms.Padding(4);
            this.nachweisNummer.Name = "nachweisNummer";
            this.nachweisNummer.Size = new System.Drawing.Size(155, 22);
            this.nachweisNummer.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ausbildungsnachweis Nr ";
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(845, 99);
            this.department.Margin = new System.Windows.Forms.Padding(4);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(152, 22);
            this.department.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(842, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Abteilung";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(661, 291);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 22);
            this.textBox1.TabIndex = 14;
            // 
            // betrieblich
            // 
            this.betrieblich.Location = new System.Drawing.Point(1054, 46);
            this.betrieblich.Margin = new System.Windows.Forms.Padding(4);
            this.betrieblich.Multiline = true;
            this.betrieblich.Name = "betrieblich";
            this.betrieblich.Size = new System.Drawing.Size(365, 95);
            this.betrieblich.TabIndex = 16;
            // 
            // unterweisungeg
            // 
            this.unterweisungeg.Location = new System.Drawing.Point(1054, 164);
            this.unterweisungeg.Margin = new System.Windows.Forms.Padding(4);
            this.unterweisungeg.Multiline = true;
            this.unterweisungeg.Name = "unterweisungeg";
            this.unterweisungeg.Size = new System.Drawing.Size(365, 91);
            this.unterweisungeg.TabIndex = 17;
            // 
            // berufschule
            // 
            this.berufschule.Location = new System.Drawing.Point(1054, 286);
            this.berufschule.Margin = new System.Windows.Forms.Padding(4);
            this.berufschule.Multiline = true;
            this.berufschule.Name = "berufschule";
            this.berufschule.Size = new System.Drawing.Size(365, 90);
            this.berufschule.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1050, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Betriebliche Tätigkeit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1050, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Unterweisungen, betrieblicher Unterricht, sonstige Schulungen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1050, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Berufsschule (Unterrichtsthemen)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(658, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Document Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1249, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 70);
            this.button1.TabIndex = 23;
            this.button1.Text = "Felder leeren";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.TextBoxClear);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(0, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 467);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 661);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.berufschule);
            this.Controls.Add(this.unterweisungeg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nachweisNummer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bisWoche);
            this.Controls.Add(this.vonWoche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.year);
            this.Controls.Add(this.name);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.FileCreating);
            this.Controls.Add(this.betrieblich);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Wochenbericht";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileCreating;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker vonWoche;
        private System.Windows.Forms.DateTimePicker bisWoche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nachweisNummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox betrieblich;
        private System.Windows.Forms.TextBox unterweisungeg;
        private System.Windows.Forms.TextBox berufschule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ListView listView1;
    }
}

