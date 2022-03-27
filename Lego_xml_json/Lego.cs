using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lego_xml_json
{
    [System.Xml.Serialization.XmlRoot("Lego")]
    public class Lego
    {
        [System.Xml.Serialization.XmlElement("characters")]
        public Characters Characters { get; set; }
        [System.Xml.Serialization.XmlElement("building")]
        public Buildings Buildings { get; set; }
        [System.Xml.Serialization.XmlElement("legocombo")]
        public Legocombos Legocombos { get; set; }


       /* public static Lego Deserialize()
        {
            string Path = @".\..\..\XML\Lego.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Lego));
            FileStream stream = new FileStream(Path, FileMode.Open);
            return (Lego)serializer.Deserialize(stream);
                
        }*/

    }

    public class Characters
    {
        
        [System.Xml.Serialization.XmlElement("person")]
        public Character[] CharacterArray { get; set; }

    }

    public class Character
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int DId { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string DName { get; set; }

        [System.Xml.Serialization.XmlElement("surname", Namespace = "")]
        public string DSurname { get; set; }

        [System.Xml.Serialization.XmlElement("age", Namespace = "")]
        public byte DAge { get; set; }
        [System.Xml.Serialization.XmlElement("lego_features", Namespace = "")]
        public Lego_features Dlego_Features { get; set; }


    }
    public class Lego_features
    {
        [System.Xml.Serialization.XmlElement("production", Namespace = "")]
        public Production Production { get; set; }
    }
    public class Production
    {
        [System.Xml.Serialization.XmlAttribute("name", Namespace = "")]
        public string NAme { get; set; }
        [System.Xml.Serialization.XmlAttribute("detailCounts", Namespace = "")]
        public string DEtailCounts { get; set; }
        [System.Xml.Serialization.XmlAttribute("profession", Namespace = "")]
        public string PRofession { get; set; }
    }



    public class Buildings
    {
        [System.Xml.Serialization.XmlElement("build")]
        public Building[] BuildingArray { get; set; }
    }
    public class Building
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int PId { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string PName { get; set; }
        [System.Xml.Serialization.XmlElement("date_of", Namespace = "")]
        public int PDate_Of { get; set; }
        [System.Xml.Serialization.XmlElement("floors", Namespace = "")]
        public int PFloors { get; set; }
        [System.Xml.Serialization.XmlElement("information", Namespace = "")]
        public Information Pinformation { get; set; }


    }
    public class Information
    {
        [System.Xml.Serialization.XmlElement("speaticialization", Namespace = "")]
        public string Speaicialization { get; set; }

        [System.Xml.Serialization.XmlElement("capacity", Namespace = "")]
        public int Capacity { get; set; }

        [System.Xml.Serialization.XmlElement("color", Namespace = "")]
        public string Color { get; set; }
    }

    public class Legocombos
    {
        [System.Xml.Serialization.XmlElement("combo")]
        public Legocombo[] LegocombosArray { get; set; }
    }
    public class Legocombo
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int HId { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string HName { get; set; }
        [System.Xml.Serialization.XmlElement("date_of", Namespace = "")]
        public float PPrice { get; set; }
        [System.Xml.Serialization.XmlElement("detailCount", Namespace = "")]
        public int PDetailCount { get; set; }
        [System.Xml.Serialization.XmlElement("people", Namespace = "")]
        public People PPeople { get; set; }

    }
    public class People
    {
        [System.Xml.Serialization.XmlElement("hero", Namespace = "")]
        public string HeRo { get; set; }
        [System.Xml.Serialization.XmlElement("villain", Namespace = "")]
        public string ViLlain { get; set; }
        [System.Xml.Serialization.XmlElement("specialOfCombo", Namespace = "")]
        public string SpEcialOfCombo { get; set; }
        [System.Xml.Serialization.XmlElement("countPeople", Namespace = "")]
        public int CoUntPeople { get; set; }
    }

}
