using System.Text.Json;

namespace Politesh_parsing_net_core.Classes
{
    internal class JsonBuild
    {
        static string den_nedeli;
        public static void JsonBuilder(Group group)
        {
            
        }



        private class Para
        {
            string name;
            string prepod;
            string cabin;

            public Para(string name, string prepod, string cabin)
            {
                this.name = name;
                this.prepod = prepod;
                this.cabin = cabin;
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
                    break;

            }
        }

    }
}
