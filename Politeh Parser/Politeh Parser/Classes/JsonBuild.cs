using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Politeh_Parser.Classes
{
    internal class JsonBuild
    {
        public static string den_nedeli;
        private static List<Lessons> list = new List<Lessons>();
        private static List<Days> days = new List<Days>();
        public static void JsonBuilder(Group group) 
        {
            try
            {

                FormatingData(group.Class_houre,
                              group.First_para,
                              group.Second_para,
                              group.Third_para,
                              group.Fourth_para,
                              group.Fifth_para);
                Days day = new Days(den_nedeli, list);
                days.Add(day);
                var Raspisanie = JsonConvert.SerializeObject(days);
                File.WriteAllText($"E:\\GitHub\\Politeh-parser\\Politeh Parser\\Politeh Parser\\JsonFile\\\\Raspisanie.json", Raspisanie);
            }
            catch
            {

            }
        }


        //форматирование данных
        public static void FormatingData(
            string ClassHour,
            string first_para,
            string second_para,
            string third_para,
            string fourth_para,
            string fifth_para)
        {
            List <string> massive = new List<string>
            {
                ClassHour,
                first_para,
                second_para,
                third_para,
                fourth_para,
                fifth_para
            };
            
            foreach (string nomer_pari in massive)
            {
                string para;
                string prepod;
                string room;
                string a = nomer_pari;
                a = a.Replace('\n', ' ');
                var b = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                b.Reverse();
                room = b[0]; prepod = b[1];
                b.Reverse();
                b.RemoveAt(b.Count - 1);
                b.RemoveAt(b.Count - 1);
                para = string.Join(" ", b.ToArray());

                Lessons lessons = new Lessons(para, room, prepod);
                
                list.Add(lessons);


            }
        }



        public class Days
        {

            public string day_name { get; private set; }
            public List<Lessons> lessons { get; private set; }

            public Days(string day_name, List<Lessons> lessons)
            {
                this.day_name = day_name;
                this.lessons = lessons;
            }
        }

        public class Lessons
        {
            public string lesson_name { get; private set; }
            public string room { get; private set; }
            public string Teacher { get; private set; }
            public Lessons(string lesson_name, string room, string teacher)
            {
                this.lesson_name = lesson_name;
                this.room = room;
                Teacher = teacher;
            }
        }

        public static void New_Day(string day) 
        {
            switch (day) 
            {
                case "пн":
                    den_nedeli = "Понедельник";
                    break;
                case "вт":
                    den_nedeli = "Вторник";
                    break;
                case "ср":
                    den_nedeli = "Среда";
                    break;
                case "чт":
                    den_nedeli = "Четверг";
                    break;
                case "пт":
                    den_nedeli = "Пятница";
                    MessageBox.Show("Пятница");
                    break;

            }
        }

    }
}
