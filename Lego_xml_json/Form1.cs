using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lego_xml_json
{
    public partial class Form1 : Form
    {
        public Form1(Lego lego)
        {
            InitializeComponent();
            Data_GV(lego);
            Data_GV2(lego);
            Data_GV3(lego);
        }
        
        private void Data_GV(Lego lego)
        {
            dataGV_1.Rows.Add(lego.Characters.CharacterArray[0].DId, lego.Characters.CharacterArray[0].DName, lego.Characters.CharacterArray[0].DSurname, lego.Characters.CharacterArray[0].DAge, lego.Characters.CharacterArray[0].Dlego_Features.Production.NAme, lego.Characters.CharacterArray[0].Dlego_Features.Production.DEtailCounts, lego.Characters.CharacterArray[0].Dlego_Features.Production.PRofession);
            dataGV_1.Rows.Add(lego.Characters.CharacterArray[1].DId, lego.Characters.CharacterArray[1].DName, lego.Characters.CharacterArray[1].DSurname, lego.Characters.CharacterArray[1].DAge, lego.Characters.CharacterArray[1].Dlego_Features.Production.NAme, lego.Characters.CharacterArray[1].Dlego_Features.Production.DEtailCounts, lego.Characters.CharacterArray[1].Dlego_Features.Production.PRofession);

        }
        private void Data_GV2(Lego lego)
        {
            dataGV2.Rows.Add(lego.Buildings.BuildingArray[0].PId, lego.Buildings.BuildingArray[0].PName, lego.Buildings.BuildingArray[0].PDate_Of, lego.Buildings.BuildingArray[0].PFloors, lego.Buildings.BuildingArray[0].Pinformation.Speaicialization, lego.Buildings.BuildingArray[0].Pinformation.Capacity, lego.Buildings.BuildingArray[0].Pinformation.Color);
            dataGV2.Rows.Add(lego.Buildings.BuildingArray[1].PId, lego.Buildings.BuildingArray[1].PName, lego.Buildings.BuildingArray[1].PDate_Of, lego.Buildings.BuildingArray[1].PFloors, lego.Buildings.BuildingArray[1].Pinformation.Speaicialization, lego.Buildings.BuildingArray[1].Pinformation.Capacity, lego.Buildings.BuildingArray[1].Pinformation.Color);
        }  
        private void Data_GV3(Lego lego)
        {
            dataGV3.Rows.Add(lego.Legocombos.LegocombosArray[0].HId, lego.Legocombos.LegocombosArray[0].HName, lego.Legocombos.LegocombosArray[0].PPrice, lego.Legocombos.LegocombosArray[0].PDetailCount, lego.Legocombos.LegocombosArray[0].PPeople.HeRo, lego.Legocombos.LegocombosArray[0].PPeople.ViLlain, lego.Legocombos.LegocombosArray[0].PPeople.SpEcialOfCombo, lego.Legocombos.LegocombosArray[0].PPeople.CoUntPeople);
            dataGV3.Rows.Add(lego.Legocombos.LegocombosArray[1].HId, lego.Legocombos.LegocombosArray[1].HName, lego.Legocombos.LegocombosArray[1].PPrice, lego.Legocombos.LegocombosArray[1].PDetailCount, lego.Legocombos.LegocombosArray[1].PPeople.HeRo, lego.Legocombos.LegocombosArray[1].PPeople.ViLlain, lego.Legocombos.LegocombosArray[1].PPeople.SpEcialOfCombo, lego.Legocombos.LegocombosArray[1].PPeople.CoUntPeople);
        }
        
    }
    
}
