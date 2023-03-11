namespace Politesh_parsing_net_core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_EXCEL_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var File_Excel = openFileDialog1.FileName;
                File_Name_in_Form.Text = File_Excel;
                if (File_Excel.Contains(".xlsx")) 
                {
                    Classes.ParseExcel.Load_excel_file(File_Excel);

                }
                else
                {
                    MessageBox.Show("Error type of File. Choose excel only");
                }
            }
        }
    }
}