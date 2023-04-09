using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace Politesh_parsing_net_core
{
    public partial class Form1 : Form
    {


       



        #region Components
        private static string File_Excel = "";
        private static bool MousePressed = false;
        private static Point ClickPosishon,MoveStartPos;
        Font myFont;
        #endregion
        public Form1()
        {
            InitializeComponent();
            LoadFont();
            label1.Font = myFont;
            File_Name_in_Form.Font = myFont;

        }

        #region Shadow

        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams 
        {
            get 
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow; 
                return cp;
            }
        }

        #endregion
        #region Load_and_push_excel
        private void Load_excel_Click(object sender, EventArgs e)
        {
            Push_to_work.Enabled = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.Contains(".xlsx"))
                {
                    File_Excel = openFileDialog1.FileName;
                    File_Name_in_Form.Text = File_Excel;
                    Push_to_work.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Неверный тип файла. Требуемый тип (.xlsx)");
                }
            }
        }

        private void Push_to_work_Click(object sender, EventArgs e)
        {
            Classes.ParseExcel.Load_excel_file(File_Excel);
        }

        #endregion

        private void LoadFont()
        {
            PrivateFontCollection private_fonts = new PrivateFontCollection();
            private_fonts.AddFontFile("Montserrat-Medium.ttf");
            myFont = new Font(private_fonts.Families[0], 10);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region MoveForm
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressed = true;
            ClickPosishon = Cursor.Position;
            MoveStartPos = Location;
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressed = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePressed) 
            {
                Size frmOffset = new Size(Point.Subtract(Cursor.Position, new Size(ClickPosishon)));
                Location = Point.Add(MoveStartPos, frmOffset);

            }
        }
        #endregion
    }
}