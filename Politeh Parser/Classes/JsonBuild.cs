using System.Text.Json;

namespace Politesh_parsing_net_core.Classes
{
    internal class JsonBuild
    {
        #region Components

        static string den_nedeli;
        static string Date;
        static private List<string> Groups = new List<string>();
        static private List<string> Pars;
        static private string Push_info;


        #endregion
        public static void JsonBuilder(Group group)
        {
            if (group.Group_name != "None")
            {
                Groups.Add(group.Group_name);



                Equipment_pars(group);
                Para para_temp = new Para(0, "", "", "");

                //Запись в стринг
                Push_info += $"\n\"{group.Group_name}\"\n\t" + "{";
                for (int i = 0; i < Pars.Count; i++)
                {
                    if (Pars[i] != "None")
                    {
                        para_temp = FormatingPara
                            (
                            Pars[i], // необработанная спаршенная пара 
                            para_temp, // временный элемент для записи ипользуя класс Para
                            (den_nedeli != "Понедельник") ? (i + 1) // Ветвление на поледельник и другие дни
                            : i
                            );
                        Pars[i] = "";
                        Writer_info_of_para(para_temp);
                    }
                }
                Push_info += "\n\t}";
            }
        }

        public static void Finish_build()
        {
            
            Push_info += "\n}," + $"\n\t\"Grupps\": [\"{string.Join("\",\"", Groups)}\"] \n" + "}";
            JsonPush.JsonPushing(Push_info);
        }


        private static void Equipment_pars(Group group) 
        {
            Pars =
                (den_nedeli != "Понедельник") ? new List<string>()
                {
                    group.First_para,
                    group.Second_para,
                    group.Third_para,
                    group.Fourth_para,
                    group.Fifth_para
                } :
                new List<string>()
                {
                    group.Class_houre,
                    group.First_para,
                    group.Second_para,
                    group.Third_para,
                    group.Fourth_para,
                    group.Fifth_para
                };
        }

        private static void Writer_info_of_para(Para para) 
        {
            Push_info += $" \n\t \" {para.number} \" " +
                "\n\t{" +
                $"\n\t\t\"Lesson_name\": \"{para.name}\"," +
                $"\n\t\t\"Room\": \"{para.cabin}\"," +
                $"\n\t\t\"Teacher\": \"{para.prepod}\"" +
                "\n\t},";
        }



        private static Para FormatingPara(string para_none_format,Para para, int number_para) 
        {
            para.number = number_para;
            string a = para_none_format;
            a = a.Replace('\n', ' ');
            var b = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            b.Reverse();
            para.cabin = b[0]; para.prepod = b[1];
            b.Reverse();
            b.RemoveAt(b.Count - 1);
            b.RemoveAt(b.Count - 1);
            para.name = string.Join(" ", b.ToArray());

            return para;
        }

        private class Para
        {
            public int number;
            public string name;
            public string prepod;
            public string cabin;

            public Para(int number,string name, string prepod, string cabin)
            {
                this.number = number;
                this.name = name;
                this.prepod = prepod;
                this.cabin = cabin;
                
            }
        }


        public static void New_Day(string day)
        {
            Push_info += "{\n\"RequestType\": \"PostSchedule\",\n \"Date\": \"01.01.2020\",";
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
                    break;

            }
        }

    }
}
