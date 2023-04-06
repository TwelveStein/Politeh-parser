using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;

//using Microsoft.Office.Interop.Excel;
//using _Excel = Microsoft.Office.Interop.Excel;

namespace Politesh_parsing_net_core.Classes
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

            string[] massive_days = new string[] { "пн", "вт", "ср", "чт", "пт" }; ;
            foreach (string day in massive_days)
            {
                JsonBuild.New_Day(day);
                Days_processing(group, file, day);
                JsonBuild.Finish_build();
            }



        }

        private static void Days_processing(Group group, string file, string day)
        {
            using (var package = new ExcelPackage(new FileInfo(file)))
            {
                int Num1, Num2, Num3, max_count_pars;
                if (day == "пн")
                {
                    Num1 = 2; Num2 = 13; Num3 = 30; max_count_pars = 7;
                }
                else
                {
                    Num1 = 1; Num2 = 12; Num3 = 26; max_count_pars = 6;
                }
                string text_from_the_cell = "";
                int counter = 0;
                var ws = package.Workbook.Worksheets[day];

                for (int i = Num1; i < Num2; i++)
                {
                    for (int j = 3; j <= Num3; j++)
                    {
                        if (ws.Cells[j, i].Value != null)
                        {
                            if (ws.Cells[j, i].Value.ToString().Length > 2)
                            {
                                if (counter != 0)
                                    group.Count_par++;
                                text_from_the_cell = ws.Cells[j, i].Value.ToString();
                            }
                            else
                            {
                                text_from_the_cell = "None";
                            }

                        }
                        else
                        {
                            text_from_the_cell = "None";
                        }

                        if (day == "пн")
                        {
                            group = Monday(group, counter, text_from_the_cell);
                        }
                        else
                        {
                            group = Other_day(group, counter, text_from_the_cell);
                        }
                        counter++;
                        if (counter == max_count_pars)
                        {
                            JsonBuild.JsonBuilder(group);
                            group.Count_par = 0;
                            counter = 0;
                        }
                    }
                }

            }
        }
        private static Group Monday(Group group, int couter, string text)
        {
            switch (couter)
            {
                case 0:
                    group.Group_name = text;
                    break;
                case 1:
                    group.Class_houre = text;
                    break;
                case 2:
                    group.First_para = text;
                    break;
                case 3:
                    group.Second_para = text;
                    break;
                case 4:
                    group.Third_para = text;
                    break;
                case 5:
                    group.Fourth_para = text;
                    break;
                case 6:
                    group.Fifth_para = text;
                    break;
            }
            return group;
        }
        private static Group Other_day(Group group, int couter, string text)
        {
            switch (couter)
            {
                case 0:
                    group.Group_name = text;
                    break;
                case 1:
                    group.First_para = text;
                    group.Class_houre = "";
                    break;
                case 2:
                    group.Second_para = text;
                    break;
                case 3:
                    group.Third_para = text;
                    break;
                case 4:
                    group.Fourth_para = text;
                    break;
                case 5:
                    group.Fifth_para = text;
                    break;
            }
            return group;
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
