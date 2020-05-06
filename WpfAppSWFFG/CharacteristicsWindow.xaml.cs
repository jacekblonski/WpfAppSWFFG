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
    /// Interaction logic for CharacteristicsWindow.xaml
    /// </summary>
    public partial class CharacteristicsWindow : Window
    {

        public CharacteristicsWindow()
        {
            InitializeComponent();
            Character loadedCharacter = Application.Current.Resources["loadedCharacter"] as Character;
            BrawnValue.Content = loadedCharacter.Brawn;
            AgilityValue.Content = loadedCharacter.Agility;
            IntellectValue.Content = loadedCharacter.Intellect;
            CunningValue.Content = loadedCharacter.Cunning;
            WillpowerValue.Content = loadedCharacter.Willpower;
            PresenceValue.Content = loadedCharacter.Presence;
            ForceRatingValue.Content = loadedCharacter.ForceRank;
        }
    }
}
