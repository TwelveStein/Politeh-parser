using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Politeh_Parser
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();

        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var File_Excel = openFileDialog1.FileName;
                File_Name_in_Form.Text = File_Excel;
                if (File_Excel.Contains(".xlsx"))
                    Classes.ParseExcel.Load_excel_file(File_Excel);
                else 
                {
                    MessageBox.Show("Error type of File . Type excel only");
                }
            }
        }
    }
}
