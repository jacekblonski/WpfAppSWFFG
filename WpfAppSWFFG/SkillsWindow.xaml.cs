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
    /// Interaction logic for SkillsWindow.xaml
    /// </summary>
    public partial class SkillsWindow : Window
    {

        public SkillsWindow()
        {
            InitializeComponent();
            Character loadedCharacter = Application.Current.Resources["loadedCharacter"] as Character;
            AstrogationSlider.Value = loadedCharacter.Astrogation.Ranks;
            BrawlSlider.Value = loadedCharacter.Brawl.Ranks;
            MeleeSlider.Value = loadedCharacter.Melee.Ranks;
        }
    }
}
