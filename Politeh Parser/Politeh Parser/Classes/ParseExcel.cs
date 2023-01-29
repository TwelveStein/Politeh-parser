using OfficeOpenXml;
using System.IO;

//using Microsoft.Office.Interop.Excel;
//using _Excel = Microsoft.Office.Interop.Excel;

namespace Politeh_Parser.Classes
{
    internal class ParseExcel
    {
        public static void Load_excel_file(string file) 
        {

            Group group = new Group
            (
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                 0
            );
             ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
             
             string[] massive_days = new string[] { "пн", "вт", "ср", "чт", "пт" };
             foreach (string day in massive_days)
             {
                 JsonBuild.New_Day(day);
                 if (day == "пн"){
                     Monday_processing(group,file);
                 }
                 else 
                 {
                     Other_days_processing(group,day,file);
                 }
             }
             
            
        }

        private static Group Monday_processing(Group group, string file) 
        {
            using (var package = new ExcelPackage(new FileInfo(file)))
            {
                string text_from_the_cell = "";
                int counter = 0;
                var ws = package.Workbook.Worksheets["пн"];
                for (int i = 2; i < 13; i++) 
                {
                    for (int j = 3; j < 30; j++) 
                    {
                        if (ws.Cells[j, i].Value == null) 
                        {
                            
                        }
                    }
                }
                return group;
            }
        }
        private static Group Other_days_processing(Group group,string day, string file)
        {
            using (var package = new ExcelPackage(new FileInfo(file)))
            {
                string text_from_the_cell = "";
                int counter = 0;
                var ws = package.Workbook.Worksheets[day];
                for (int i = 2; i < 13; i++)
                {
                    for (int j = 3; j < 30; j++)
                    {
                        if (ws.Cells[j, i].Value == null)
                        {

                        }
                    }
                }
                return group;
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
