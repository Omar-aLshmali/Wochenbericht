using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace Wochenbericht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoC();
            listView1.Items.Add("fw44t4t4t");

        }
        //Find and Replace Method
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
        
            object replace = 2;
            object wrap = 1;
            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        //Creeate the Doc Method
        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                this.FindAndReplace(wordApp, "<name>", nameBox.Text);
                this.FindAndReplace(wordApp, "<jahr>", yearBox.Text);
                this.FindAndReplace(wordApp, "<Nummer>", nachweisNummer.Text);
                this.FindAndReplace(wordApp, "<Abteilung>", department.Text);
                this.FindAndReplace(wordApp, "<betrieblich>", betrieblich.Text);
                this.FindAndReplace(wordApp, "<unterweisungen>", unterweisungeg.Text);
                this.FindAndReplace(wordApp, "<berufschule>", berufschule.Text);
                this.FindAndReplace(wordApp, "<vom>", vonWoche.Value.ToShortDateString());
                this.FindAndReplace(wordApp, "<bis>", bisWoche.Value.ToShortDateString());

            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

        private void FileCreat(object sender, EventArgs e)
        {
            CreateWordDocument(@"C:\Users\oalshmali\source\repos\Wochenbericht\Wochenbericht\Muster.docx", @"C:\Users\oalshmali\Desktop\WochenberichtApp\"+textBox1.Text+".docx");
           
        }
        private void TextBoxClear(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    ((TextBox)this.Controls[i]).Clear();
                }
            }
        }
        public void AutoC()
        {
            nameBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            nameBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addItems(DataCollection);
            nameBox.AutoCompleteCustomSource = DataCollection;
        }
        public void addItems(AutoCompleteStringCollection col)
        {
            col.Add("Omar Alshmali");
            col.Add("Levi Koppelle ");
            col.Add("Jörn Tepferd");

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (listView1.SelectedItems.IndexOf(listView1.Items[2]) == 2)
            //{
            //    System.Diagnostics.Process.Start(@"C:\Users\oalshmali\Desktop\Monatsbericht\0.odt");
            //}
            for (int i = 0; i <= 3; i++)
            {
                int select = listView1.Items.IndexOf(listView1.Items[i]);
                if (select==i)
                {

                    System.Diagnostics.Process.Start(@"C:\Users\oalshmali\Desktop\Monatsbericht\" +i.ToString()+ ".odt");
                   
                }
                else
                MessageBox.Show(listView1.Items.IndexOf(listView1.SelectedItems[i]).ToString());
        }
            }
            

        }
    }

