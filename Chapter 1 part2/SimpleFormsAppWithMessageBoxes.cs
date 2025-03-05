using System.Xml.Linq;

namespace SimpleFormAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fnamevalue = textBox1.Text;
            string mnamevalue = textBox2.Text;
            string lnamevalue = textBox3.Text;
            string snamevalue = textBox4.Text;

            DialogResult confirmationResult = MessageBox.Show("Are you sure you want to submit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmationResult == DialogResult.Yes)
            {

                string greetingMessage = $"Hello There! {fnamevalue} {mnamevalue} {lnamevalue} {snamevalue}!";
                MessageBox.Show(greetingMessage, "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("Submission canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
