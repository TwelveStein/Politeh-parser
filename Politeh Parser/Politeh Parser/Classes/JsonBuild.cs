using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Politeh_Parser.Classes
{
    internal class JsonBuild
    {
        public static void JsonBuilder(Group group) 
        {
            try
            {
                
                //Pass the filepath and filename to the StreamWriter Constructor
                using (StreamWriter sw = File.AppendText("test.txt"))
                {
                    sw.WriteLine(
                    group.Group_name + "\n\n" +
                    group.Class_houre + "\n\n" +
                    group.First_para + "\n\n" +
                    group.Second_para + "\n\n" +
                    group.Third_para + "\n\n" +
                    group.Fourth_para + "\n\n" +
                    group.Fifth_para + "\n\n" +
                    group.Count_par + "\n\n\n\n"
                    );
                }
                
            }
            catch 
            {
                
            }
        }
        public static void json_cleaner() 
        {
            StreamWriter stream = new StreamWriter("test.txt");
            stream.WriteLine("");
            stream.Close();
        }
        public static void New_Day(string day) 
        {
            using (StreamWriter sw = File.AppendText("test.txt"))
            {
                sw.WriteLine($"\n______________\n {day} \n______________\n");
            }
        }

    }
}
