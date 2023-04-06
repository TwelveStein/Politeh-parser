using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Politesh_parsing_net_core.Classes
{
    internal class JsonPush
    {
        static bool one_day = true;
        public static void JsonPushing(string Json) 
        {
            if (one_day == true) 
            {
                try
                {
                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter("json.txt");
                    //Write a line of text
                    sw.WriteLine(Json);
                    //Write a second line of text
                    //Close the file
                    sw.Close();
                }
                catch 
                {
                    MessageBox.Show("Error");
                }
                one_day = false;
            }
        }
    }
}
