using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Lego_xml_json
{
    
    internal static class Program
    {
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LoadXML();

            
        }
      
       public static void LoadXML()
       {
           
            try
            {
               
                XmlSerializer xmls = new XmlSerializer(typeof(Lego));
                StreamReader sr = new StreamReader(@".\..\..\XML\Lego.xml");
                Lego lego = (Lego)xmls.Deserialize(sr);
                Application.Run(new Form1(lego));
                

            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                 
            }
       }
    




    }
}   
