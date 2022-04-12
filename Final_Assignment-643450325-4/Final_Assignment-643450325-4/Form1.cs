using System.Data;

namespace Final_Assignment_643450325_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV(.csv)|*csv";
            openFile.Title = "Please select fiel";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = null;

                DataTable dt = new DataTable();
                string[] colName = { "รายการ", "ราคา", "จ่าย", "ทอน" };

                foreach (string col in colName)
                {
                    dt.Columns.Add(col);
                }

                foreach (string file in openFile.FileNames)
                {
                    try
                    {
                        if (File.Exists(file) == true)
                        {
                            StreamReader csv = new StreamReader(file);
                            string textLine;
                            string[] spLitline;
                            do
                            {
                                textLine = csv.ReadLine();
                                spLitline = textLine.Split(",");
                                dt.Rows.Add(spLitline);

                            }

                            while (csv.Peek() != -1);
                            csv.Close();
                            csv.Dispose();





                        }





                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }



        }

        private StreamReader StreamReader(string file)
        {
            throw new NotImplementedException();
        }

        


    }
}
    
