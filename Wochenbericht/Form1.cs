
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Globalization;
using System.Drawing;


namespace Wochenbericht
{
    public partial class Form1 : Form
    {
        GetFiles get = new GetFiles();
        AutoColpletClass autoColplet = new AutoColpletClass();
        public Form1()
        {
            InitializeComponent();
            autoColplet.TextAutoComplet(department,nameBox);

        }

        /// <summary>
        /// Find and Replace Method
        /// </summary>
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
            try
            {
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
            catch
            {
                MessageBox.Show("Bitte Name eingeben");
            }
        }

        private void FileCreat(object sender, EventArgs e)
        { 

                CreateWordDocument(@"C:\Users\oalshmali\source\repos\Wochenbericht\Wochenbericht\Muster.docx", get.GetPath()+"\\" + nameDokument.Text + ".docx");

           
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
		private void Form1_Load(object sender, EventArgs e)
        {
            get.getAllFiles(filesList, nachweisNummer,nameDokument);
            DateTime dtBegin = DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(-7);
			vonWoche.Value = dtBegin;
            DateTime dtEnd = DateTime.Now.EndOfWeek(DayOfWeek.Friday).AddDays(-7);
            bisWoche.Value = dtEnd;

        }
        private void filesList_MouseClick(object sender, MouseEventArgs e)
        {
            String adress = get.GetPath() + "\\";
            int index = filesList.FocusedItem.Index;
            try
            {
                for (int i = 0; i <= filesList.Items.Count; i++)
                {
                    if (index == i)
                    {
                        i++;
                        System.Diagnostics.Process.Start(adress + i.ToString() + ".docx");

                        break;
                    }
                }
            }
            catch { }
            try
            {
                for (int i = 0; i <= filesList.Items.Count; i++)
                {
                    if (index == i)

                    {
                        i++;
                        
                        System.Diagnostics.Process.Start(adress+i.ToString() + ".odt");

                        break;
                    }
                }
            }
            catch { }
             
        }
        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String adress = get.GetPath();
            System.Diagnostics.Process.Start(adress);
        
        }
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            filesList.Items.Clear();
            Form1_Load(sender, e);
        }

		private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
            
          MessageBox.Show("Achtung, wählen Sie einen Ordner aus, in der mindistes eine File vorhanden ist.");
            
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                get.SetPath(sFileName);
            }

        }
    }
    }