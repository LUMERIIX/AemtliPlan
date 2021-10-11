using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace AemtliPlan
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        static public XmlSerializer memberSerializer = new XmlSerializer(typeof(Member));
        static TextWriter twMembers = new StreamWriter(@"c:\temp\members.xml");
        static public XmlSerializer tasksSerializer = new XmlSerializer(typeof(Aemtli));
        static TextWriter twTasks = new StreamWriter(@"c:\temp\tasks.xml");

        static bool StoreXML(TextWriter tw, List<String> memberList)
        {
            return false;
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AemltliGenerator());
        }
    }
}
