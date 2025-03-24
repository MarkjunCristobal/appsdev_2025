using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleFavoriteCartoonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cartoons = { "Luffy", "Zoro", "Sanji", "Nami", "Robin" };
            comboBox1.Items.AddRange(cartoons);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCharacter = comboBox1.SelectedItem.ToString();
            switch (selectedCharacter)
            {
                case "Luffy":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\mm316\Downloads\download (2).jfif");
                    break;
                case "Zoro":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\mm316\Downloads\download.jfif");
                    break;
                case "Sanji":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\mm316\Downloads\download (1).jfif");
                    break;
                case "Nami":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\mm316\Downloads\Nami ⚜️.jfif");
                    break;
                case "Robin":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\mm316\Downloads\Nico Robin.jfif");
                    break;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}

