using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
//using _Excel = Microsoft.Office.Interop.Excel;

namespace Politeh_Parser.Classes
{
    internal class ParseExcel
    {
        public static void Load_excel_file(string file) 
        {

            using (var package = new ExcelPackage(new FileInfo(file)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var ws = package.Workbook.Worksheets["пн"];
                //MessageBox.Show(ws.Cells[4, 2].Value.ToString());
                int stroka = 3;
                Group group = new Group
                    (
                        ws.Cells[stroka, 2].Value.ToString(),
                        ws.Cells[stroka+1, 2].Value.ToString(),
                        ws.Cells[stroka+2, 2].Value.ToString(),
                        ws.Cells[stroka+3, 2].Value.ToString(),
                        ws.Cells[stroka+4, 2].Value.ToString(),
                        ws.Cells[stroka+5, 2].Value.ToString(),
                        ws.Cells[stroka+6, 2].Value.ToString(),
                        5

                    );
                JsonBuild.JsonBuilder(group);
    
                    

                    
               
            }
        }
    }
    public class Group
    {
        public string Group_name;
        public string Class_houre;
        public string First_para;
        public string Second_para;
        public string Third_para;
        public string Fourth_para;
        public string Fifth_para;
        public int Count_par;

        public Group(string group_name, string class_houre, string first_para, string second_para, string third_para, string fourth_para, string fifth_para, int count_par)
        {
            Group_name = group_name;
            Count_par = count_par;
            Class_houre = class_houre;
            First_para = first_para;
            Second_para = second_para;
            Third_para = third_para;
            Fourth_para = fourth_para;
            Fifth_para = fifth_para;
        }
    } 
}
