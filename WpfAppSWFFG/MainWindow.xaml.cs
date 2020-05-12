using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace WpfAppSWFFG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            XmlSerializer serializer = new XmlSerializer(typeof(Character));
            using (FileStream fileStream = new FileStream("Nej.xml", FileMode.Open))
            {
                Character loadedCharacter = (Character)serializer.Deserialize(fileStream);
                Application.Current.Resources.Add("loadedCharacter", loadedCharacter);
                WoundThreshold.Content = loadedCharacter.woundThreshold;
                WoundsBar.Maximum = loadedCharacter.woundThreshold;
                CurrentWounds.Content = loadedCharacter.currentWounds;
                WoundsBar.Value = loadedCharacter.currentWounds;

                StrainThreshold.Content = loadedCharacter.strainThreshold;
                StrainBar.Maximum = loadedCharacter.strainThreshold;
                CurrentStrain.Content = loadedCharacter.currentStrain;
                StrainBar.Value = loadedCharacter.currentStrain;
            }            
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Character loadedCharacter = Application.Current.Resources["loadedCharacter"] as Character;
            using (System.IO.TextWriter writeFile = new StreamWriter("Nej.xml"))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(loadedCharacter.GetType());
                x.Serialize(writeFile, loadedCharacter);
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void BtnCharacteristics_Click(object sender, RoutedEventArgs e)
        {
            CharacteristicsWindow characteristicsWindow = new CharacteristicsWindow();
            characteristicsWindow.Show();
        }

        private void Take_Wounds(object sender, RoutedEventArgs e)
        {
            Character loadedCharacter = Application.Current.Resources["loadedCharacter"] as Character;
            loadedCharacter.currentWounds += int.Parse(WoundAddValue.Text);
            CurrentWounds.Content = loadedCharacter.currentWounds;
            WoundsBar.Value = loadedCharacter.currentWounds;
            Application.Current.Resources["loadedCharacter"] = loadedCharacter;
        }

        private void Take_Strain(object sender, RoutedEventArgs e)
        {
            Character loadedCharacter = Application.Current.Resources["loadedCharacter"] as Character;
            loadedCharacter.currentStrain += int.Parse(StrainAddValue.Text);
            CurrentStrain.Content = loadedCharacter.currentStrain;
            StrainBar.Value = loadedCharacter.currentStrain;
            Application.Current.Resources["loadedCharacter"] = loadedCharacter;
        }

        private void btnSkills_Click(object sender, RoutedEventArgs e)
        {
            SkillsWindow skillsWindow = new SkillsWindow();
            skillsWindow.Show();
        }
    }
}
