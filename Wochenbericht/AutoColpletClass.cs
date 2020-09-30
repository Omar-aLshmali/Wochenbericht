using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wochenbericht
{
    class AutoColpletClass
    {
        public void TextAutoComplet(TextBox department, TextBox nameBox)
        {
            nameBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            nameBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            department.AutoCompleteMode = AutoCompleteMode.Suggest;
            department.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addItemsToAutoComplet(DataCollection);
            nameBox.AutoCompleteCustomSource = DataCollection;
            department.AutoCompleteCustomSource = DataCollection;
        }
        //AutoCompleteItems
        public void addItemsToAutoComplet(AutoCompleteStringCollection col)
        {
            col.Add("Omar Alshmali");
            col.Add("Anwendungsenticklung");

        }
    }
}
