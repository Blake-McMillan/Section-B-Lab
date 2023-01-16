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
            
        }

        private void SaveData()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            lstNames.Items.Add(txtNames.Text);

             //string[] NamesArray = new string[2];
            
            try
            {
                StreamWriter writer = File.CreateText("Names.txt");
                foreach(string item in lstNames.Items)
                {
                    writer.WriteLine(item);
                }
                writer.Close();

                

                //lstNames.Items.Add(NamesArray);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //using(StreamWriter writetext = new StreamWriter("Names.txt"))
            //{
            //    writetext.WriteLine(txtNames.Text);
            //}

            

        }
        //for (int i = 0; i < NamesArray.Length; i++)
        //            outputfile.WriteLine(NamesArray[i]);
    }
}