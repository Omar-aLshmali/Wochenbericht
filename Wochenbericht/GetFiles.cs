using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wochenbericht
{
    class GetFiles
    {
      
      private  String fileName = "paath.json";
        public void getAllFiles(ListView filesList, TextBox nachweisNummer,TextBox nameDokument)
        {
            try
            {
                DateTime now = DateTime.Now;

                //JsonFile is read

                string json = File.ReadAllText(fileName);

                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                String filePath = jsonObj["Infos"][0]["FilePath"];
                DirectoryInfo d = new DirectoryInfo(filePath);//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles(); //Getting Text files

                foreach (FileInfo file in Files)
                {
                    filesList.Items.Add("Woche : " + file.Name);

                }
                jsonObj["Infos"][0]["Nachweisnummer"] = jsonObj["Infos"][0]["Anzahl"] + 1;

                if (filesList.Items.Count < Convert.ToInt32(jsonObj["Infos"][0]["Anzahl"]))
                {
                    filesList.Items.Add("Wochenbericht fehlt!");
                    jsonObj["Infos"][0]["Nachweisnummer"] = jsonObj["Infos"][0]["Anzahl"] + 1;

                    for (int j = 0; j < filesList.Items.Count; j++)
                    {
                        if (filesList.Items[j].Text.Equals("Wochenbericht fehlt!"))
                        { filesList.Items[j].ForeColor = Color.Red; }
                    }

                }
                if (now.Day.Equals(Convert.ToInt32(jsonObj["Infos"][0]["DayInfo"])) && filesList.Items.Count == Convert.ToInt32(jsonObj["Infos"][0]["Anzahl"]) && DayWeek() == Convert.ToInt32(jsonObj["Infos"][0]["Woche"]))
                {
                    jsonObj["Infos"][0]["DayInfo"] = DateTime.Now.AddDays(7).ToString("dd");

                    jsonObj["Infos"][0]["Anzahl"] = jsonObj["Infos"][0]["Anzahl"] + 1;
                    jsonObj["Infos"][0]["Woche"] = jsonObj["Infos"][0]["Woche"] + 1;

                }
                nachweisNummer.Text = jsonObj["Infos"][0]["Nachweisnummer"];
                nameDokument.Text = jsonObj["Infos"][0]["Nachweisnummer"];
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(fileName, output);
            }
			catch { }
        }
        
        public int DayWeek()
        {
            CultureInfo myCI = new CultureInfo("DE");
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            int week = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            return week;
        }
        public void SetPath(String filePath)
		{
            try
            {
                String directoryPath = Path.GetDirectoryName(filePath);
                //JsonFile is read
                string json = File.ReadAllText(fileName);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                //jsonObj["Infos"][0]["DayInfo"] = now.Day;
                jsonObj["Infos"][0]["FilePath"] = directoryPath;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(fileName, output);
            }
            catch { }

            
        }
        public String GetPath()
		{
            string json = File.ReadAllText(fileName);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            String filePath = jsonObj["Infos"][0]["FilePath"];
            return filePath;
        }
    }

}
