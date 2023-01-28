using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politeh_Parser.Classes
{
    internal class JsonBuild
    {
        public static void JsonBuilder(Group group) 
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("test.txt");
                sw.WriteLine(
                    group.Group_name+"\n"+
                    group.Class_houre + "\n" +
                    group.First_para+ "\n" +
                    group.Second_para + "\n" +
                    group.Third_para+ "\n" +
                    group.Fourth_para + "\n" +
                    group.Fifth_para + "\n" +
                    group.Count_par + "\n" );
                
                sw.Close();
            }
            catch 
            {
            
            }
        }

    }
}
