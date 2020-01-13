using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Windows.Forms;

namespace SimulateSensor
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        private Random random;
        private int state = 7;
        public int State
        {
            set
            {
                state = value;
                OnPropertyChanged("State");
            }
            get
            {
                return state;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private string url = "http://localhost:1880";
       
        private int sampleCount = 0;
       
        private class SensorData
        {
            public int db
            {
                get; set;
            }
            public int ac
            {
                get; set;
            }
            public int window
            {
                get; set;
            }
            public int active
            {
                get; set;
            }
            public int position
            {
                get; set;
            }
            public int obj
            {
                get; set;
            }
            public int newData
            {
                get; set;
            }

            public SensorData(int db, int ac, int window, int active, int position, int obj)
            {
                this.db = db;
                this.ac = ac;
                this.window = window;
                this.active = active;
                this.position = position;
                this.obj = obj;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            comboBox_position.SelectedIndex = 0;
            comboBox_object.SelectedIndex = 0;

            // parameters
            random = new Random();
            
        }

        private void button_sendData_Click(object sender, EventArgs e)
        {
            SendData(new SensorData((checkBox_db.Checked ? 1 : 0), (checkBox_ac.Checked ? 1 : 0), (checkBox_window.Checked ? 1 : 0), (checkBox_active.Checked ? 1 : 0), comboBox_position.SelectedIndex, comboBox_object.SelectedIndex));
        }

        private async void SendData(SensorData data)
        {
            if (sampleCount != 100)
            {
                data.newData = 0;
            }
            else
            {
                data.newData = 1;
                sampleCount = 0;
            }
            string dataString = JsonConvert.SerializeObject(data);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("data", dataString)
                });
                try
                {
                    var result = await client.PostAsync("/SendData", content);
                    string resultContent = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(resultContent);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }

            }
        }
       
        
    }
}
