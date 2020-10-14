
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Globalization;
using System.Drawing;
using System.Collections;

namespace Wochenbericht
{
    public partial class Form1 : Form
    {

       private string filePath = Path.Combine(Application.StartupPath, "muster.docx"); //word file embedded resource C#, to use as muster for find and replace
        GetFiles get = new GetFiles(); 
        AutoColpletClass autoColplet = new AutoColpletClass(); // Fill the textboxes automatically
        public Form1()
        {
            InitializeComponent();
            autoColplet.TextAutoComplet(department,nameBox);
        }

        /// <summary>
        /// Find and Replace Method
        /// Daten that are marked in the "word.muster" are exchanged with the data in the text boxes.
        /// </summary>
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
     

            object replace = 2;
            object wrap = 1;
            wordApp.Selection.Find.Execute( ToFindText,
              
                 Wrap : wrap, ReplaceWith: replaceWithText,
                 Replace :replace 
                );
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
            
          CreateWordDocument(filePath, get.GetPath()+"\\" + nameDokument.Text + ".docx"); //filePath ist the path of the muster file, get.GetPath() ist path to save the new Dokoment with the the name in nameDokument.Text 
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
            get.getAllFiles(filesList, nachweisNummer); // at the start of the app, the data is displayed in the filesList and in the nachweisNummer-Textbox.
            nameDokument.Text = nachweisNummer.Text; // als Vorschlag wird die nächste Nachweisnummer angezeigt.
            DateTime dtBegin = DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(-7); // Als Vorschlag wird das Datum auf das Datum von dem ersten Arbeitstag der lezten Woche eingesetzt.
			vonWoche.Value = dtBegin;
            DateTime dtEnd = DateTime.Now.EndOfWeek(DayOfWeek.Friday).AddDays(-7);// Als Vorschlag wird das Datum auf das Datum von dem letzten Arbeitstag der lezten Woche eingesetzt.
            bisWoche.Value = dtEnd;


        }
        /// <summary>
        ///open SelectedFiles
        /// </summary>
   
        private void filesList_MouseClick(object sender, MouseEventArgs e)
        {

           
            String adress = get.GetPath() + "\\";
            int index = filesList.FocusedItem.Index;
          
                for (int i = 0; i <= filesList.Items.Count; i++)
                {
                    if (index == i)
                    {
                        i++;
					try
					{
						System.Diagnostics.Process.Start(adress + i.ToString() + ".odt");
					}

					catch { }
					try
					{
						System.Diagnostics.Process.Start(adress + i.ToString() + ".docx");
					}
					catch{ }


					break;
                    }
         }
           
        }
        /// <summary>
        /// open the folder of all files
        /// </summary>
     
        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String adress = get.GetPath();
            System.Diagnostics.Process.Start(adress);
        
        }
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// refrech the filelist
        /// </summary>
        private void btnRefrech_Click(object sender, EventArgs e)
        {
            filesList.Items.Clear();
            Form1_Load(sender, e);
        }
        /// <summary>
        /// to select the path of Word-files
        /// </summary>
		private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
            
          //MessageBox.Show("Wählen Sie bitte einen Ordner aus, in dem mindestens eine Datei vorhanden ist.");
            
            OpenFileDialog choofdlog = new OpenFileDialog();
           
            
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                get.SetPath(sFileName);
            }
        }
	}
    }