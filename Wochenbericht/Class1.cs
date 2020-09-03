using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wochenbericht
{
    class Class1
    {

        public  void AutoC(TextBox [] textBoxes)
        {
            textBoxes[0].AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxes[0].AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addItems(DataCollection);
            textBoxes[0].AutoCompleteCustomSource = DataCollection;
        }
        public void addItems(AutoCompleteStringCollection col)
        {
            col.Add("Omar Alshmali");
            col.Add("Levi Koppelle ");
            col.Add("Jörn Tepferd");

        }
    }
}