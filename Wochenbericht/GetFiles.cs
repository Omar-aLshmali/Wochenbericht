using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Wochenbericht
{
    class GetFiles
    {
      private  String fileName = "paath.json"; //JSON embedded resource C#

        /// <summary>
        /// Word files are fetched from the resource and packed into the listview()
        /// </summary>
        /// <param name="filesList">listview, in der die Daten gepackt werden</param>
        /// <param name="nachweisNummer">nachweisnummner is fetched from paath.json to insert the new nachweisnummner in the textbox</param>
       
        public void getAllFiles(ListView filesList, TextBox nachweisNummer)
        {
            DateTime now = DateTime.Now;
            try
            {
                //JsonFile is read
                string json = File.ReadAllText(fileName);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                String filePath = jsonObj["Infos"][0]["FilePath"]; // path of thr Word files
				DirectoryInfo d = new DirectoryInfo(filePath);//Assuming Test is your Folder
                FileInfo[] files = d.GetFiles().OrderBy(p => p.Name.Length).ToArray();  //Getting Text files and Order by date

                foreach (FileInfo file in files)
                {
                  filesList.Items.Add("Woche : " + file.Name); // add all names of the word files in the listview
                }

                jsonObj["Infos"][0]["Nachweisnummer"] = jsonObj["Infos"][0]["Anzahl"] + 1; // jsonObj["Infos"][0]["Anzahl"] is the nummber of the Word files in the Folder

                if (filesList.Items.Count < Convert.ToInt32(jsonObj["Infos"][0]["Anzahl"]))  // to know if a weekly report is missing. "Anzahl" is increased to 1 weekly.
                {
                  
                    filesList.Items.Add("Wochenbericht fehlt!");
                    jsonObj["Infos"][0]["Nachweisnummer"] = jsonObj["Infos"][0]["Anzahl"];

                    for (int j = 0; j < filesList.Items.Count; j++) // "Wochenbericht fehlt!" must be shown in red.
                    {
                        if (filesList.Items[j].Text.Equals("Wochenbericht fehlt!"))
                        { filesList.Items[j].ForeColor = Color.Red; }
                    }
                   
                    PopupAlarm();
                }
                if (now.Day.Equals(Convert.ToInt32(jsonObj["Infos"][0]["DayInfo"])) && filesList.Items.Count == Convert.ToInt32(jsonObj["Infos"][0]["Anzahl"]) && DayWeek() == Convert.ToInt32(jsonObj["Infos"][0]["Woche"]))// A new weekly report must be requested at the beginning of each week.
                {
                    jsonObj["Infos"][0]["DayInfo"] = DateTime.Now.AddDays(7).ToString("dd");
                    jsonObj["Infos"][0]["Anzahl"] = jsonObj["Infos"][0]["Anzahl"] + 1;
                    jsonObj["Infos"][0]["Woche"] = jsonObj["Infos"][0]["Woche"] + 1;
                }
                nachweisNummer.Text = jsonObj["Infos"][0]["Nachweisnummer"]; 
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(fileName, output); // the new changes are written in jsonfile
            }
			catch { }
        }

		private void PopupAlarm()
		{
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.be;
            popup.TitleText = "Achtung";
            popup.ContentText = "Wochenbericht fehlt!";
            popup.Popup();
        }
		/// <summary>
		/// This is a method that returns the number of the week.
		/// </summary>
		public int DayWeek()
        {
            CultureInfo myCI = new CultureInfo("DE");
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            int week = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            return week;
        }
        /// <summary>
        /// set the path of the world files, which is saved in jsonfile
        /// </summary>
        /// <param name="filePath"></param>
        public void SetPath(String filePath)
		{
            try
            {

                String directoryPath = Path.GetDirectoryName(filePath);
                //JsonFile is read
                 string json = File.ReadAllText(fileName) ;
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                jsonObj["Infos"][0]["FilePath"] = directoryPath;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(fileName, output);
            }
            catch { }
        }
/// <summary>
/// return the files path of the word files
/// </summary>
        public String GetPath()
		{
            string json = File.ReadAllText(fileName);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            String filePath = jsonObj["Infos"][0]["FilePath"];
            return filePath;
        }
    }

}
