using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M05_Lab_Transportmittel;
using Newtonsoft.Json;

namespace M12_Demo_File_Access
{
    public partial class Form1 : Form
    {
        // fields
        List<Transportmittel> transportmittels = new List<Transportmittel>();
        List<Transportmittel> tmListFromJson = new List<Transportmittel>();


        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }


        private void btnAddTransport_Click(object sender, EventArgs e)
        {
            transportmittels.Add(new Transportmittel(txtBoxName.Text, (double)numericUpDownPrice.Value, (uint)numericUpDownSpeed.Value));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("Transportmittel.txt");
            foreach (Transportmittel tm in transportmittels)
                streamWriter.WriteLine(tm.BeschreibeMich());
            streamWriter.Close();
        }

        private void btnSaveAsJSON_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("Transportmittel.json");
            string jsonString = JsonConvert.SerializeObject(transportmittels);
            MessageBox.Show(jsonString);
            streamWriter.Write(jsonString);
            streamWriter.Close();
        }

        private void btnReadJSON_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("Transportmittel.json");
            var objekt = JsonConvert.DeserializeObject<List<Transportmittel>>(streamReader.ReadToEnd());
            Console.WriteLine("Deserialisiertes Objekt:");
            foreach (Transportmittel item in (objekt as List<Transportmittel>))
            {
                Console.WriteLine(item.BeschreibeMich());
            }
        }
    }
}
