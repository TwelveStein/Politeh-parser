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
                MessageBox.Show(ws.Cells[3, 2].Value.ToString());
            }
        } 







    }
}
