using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M14_Demo_HttpClient
{
    public partial class Form1 : Form
    {
        // fields
        static readonly HttpClient httpClient = new HttpClient();
        Photo photo;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnHolePhotos_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await httpClient.GetAsync("http://jsonplaceholder.typicode.com/photos/1");
            Console.WriteLine($"response: {response}");
            string responseContent = await response.Content.ReadAsStringAsync();
            // responseContent muss deserialisiert werden
            photo = JsonConvert.DeserializeObject<Photo>(responseContent);
            pictureBox1.LoadAsync(photo.Url);
        }
    }

    class Photo
    {
        public int AlbumId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
