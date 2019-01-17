using System;
using System.Linq;
using System.IO;
using Microsoft.Deployment.WindowsInstaller;

namespace WriteVersion
{
    public class PropertyTable
    {
        public static string Get(string msi, string name,out string productName)
        {
            using (Database db = new Database(msi))
            {
                productName = db.SummaryInfo.Subject;
                return db.ExecuteScalar("SELECT `Value` FROM `Property` WHERE `Property` = '{0}'", name) as string;   
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            WriteToFile();
        }
        private static void WriteToFile()
        {
            string productName;
            DateTime dateTime = DateTime.UtcNow.Date;
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream(@"\\delta3\TFSBUILDS\CAE2019\DVD\Version.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                return;
            }
            Console.SetOut(writer);
            Console.Write("CAE 2019 DVD ");
            Console.WriteLine(dateTime.ToString("(dd/MM/yyyy)"));
            Console.WriteLine(Environment.NewLine + "Design Software" + Environment.NewLine);
            string[] fileNames = Directory.GetFiles(@"\\delta3\TFSBUILDS\CAE2019\DVD\Design", "*.msi", SearchOption.AllDirectories);
            for (int i = 0; i < fileNames.Count(); i++)
            {
                var msiVersion = PropertyTable.Get(fileNames[i], "ProductVersion", out productName);
                string[] number = msiVersion.Split('.');
                String result = String.Format("{0}     - V{1}.{2} (Build {3}) ", productName.PadRight(38), number[0].PadRight(0), number[1].PadRight(3), number[2].PadRight(0));
                Console.WriteLine(result);
            }
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
        }
    }
}
