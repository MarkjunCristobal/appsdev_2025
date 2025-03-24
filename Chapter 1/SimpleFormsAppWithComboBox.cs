namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxFavoriteFood.SelectedIndex != -1)
            {
                listBoxFavoriteFood.Items.RemoveAt(listBoxFavoriteFood.SelectedIndex);
            }
        }


        private void checkedListBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCuisine_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxFood.Items.Clear(); // Clear previous items
            string selectedCuisine = comboBoxCuisine.SelectedItem.ToString();

            switch (selectedCuisine)
            {
                case "Filipino":
                    checkedListBoxFood.Items.AddRange(new string[] { "Bulalo", "Kare-Kare", "Bicol Express", "Pinakbet" });
                    break;
                case "Japanese":
                    checkedListBoxFood.Items.AddRange(new string[] { "Sushi", "Ramen", "Tempura", "Teriyaki" }); // Add Japanese dishes
                    break;
                case "Chinese":
                    checkedListBoxFood.Items.AddRange(new string[] { "Kung Pao Chicken", "Dumplings", "Fried Rice", "Peking Duck" }); // Add Chinese dishes
                    break;
                case "Korean":
                    checkedListBoxFood.Items.AddRange(new string[] { "Kimchi", "Bibimbap", "Bulgogi", "Tteokbokki" }); // Add Korean dishes
                    break;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxFood.CheckedItems)
            {
                listBoxFavoriteFood.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxFood.CheckedItems)
            {
                listBoxFavoriteFood.Items.Add(item);
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            listBoxFavoriteFood.Items.Clear();
        }
    }
}



