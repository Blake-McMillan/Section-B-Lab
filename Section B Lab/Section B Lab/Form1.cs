namespace Section_B_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            //grabs and reads data from Names.txt to display in the Listbox
            StreamReader reader = File.OpenText("Names.txt");
            while (reader.EndOfStream == false)
            {
                string item = reader.ReadLine();
                lstNames.Items.Add(item);
            }
            reader.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //saves name typed in textbox to Names.txt and also displays the name in the Listbox
            lstNames.Items.Add(txtNames.Text);        
            try
            {
                StreamWriter writer = File.CreateText("Names.txt");
                foreach(string item in lstNames.Items)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstNames.Items.Clear();
            //clears all names from the listbox and from Names.txt 
            using (StreamWriter sw = new StreamWriter("Names.txt", false))
            {
                foreach (string line in lstNames.Items)
                {
                    sw.Write(""); 
                }
                sw.Close();
            }          
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            //Loads data from Names.txt on load to display in the Listbox
            LoadData();
        }

        private void CalcAverage()
        {
            StreamReader inputfile = File.OpenText("mh_temp2021.txt");
            List<string> dgList = new List<string>();

            while (!inputfile.EndOfStream)
                dgList.Add(inputfile.ReadLine());

            inputfile.Close();





            //StreamReader reader = File.OpenText("mh_temp2021.txt");
            //while (reader.EndOfStream == false)
            //{
            //    string item = reader.ReadLine();

            //}
            //reader.Close();
        }







        private void btnWeather_Click(object sender, EventArgs e)
        {
            StreamReader reader = File.OpenText("mh_temp2021.txt");
            while (reader.EndOfStream == false)
            {
                string item = reader.ReadLine();
                txtAverageTemp.Text = item;
            }
            reader.Close();
        }
    }
}