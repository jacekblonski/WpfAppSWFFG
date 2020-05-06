using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WpfAppSWFFG
{
    [XmlRoot("Character")]
    public class Character
    {
        [XmlElement("woundThreshold")]
        public int woundThreshold { get; }
        [XmlElement("currentWounds")]
        public int currentWounds { get; set; }
        [XmlElement("strainThreshold")]
        public int strainThreshold { get; }
        [XmlElement("currentStrain")]
        public int currentStrain { get; set; }        
        [XmlElement("Brawn")]
        public int Brawn { get; set; }
        [XmlElement("Agility")]
        public int Agility { get; set; }
        [XmlElement("Intellect")]
        public int Intellect { get; set; }
        [XmlElement("Cunning")]
        public int Cunning { get; set; }
        [XmlElement("Willpower")]
        public int Willpower { get; set; }
        [XmlElement("Presence")]
        public int Presence { get; set; }
        [XmlElement("ForceRank")]
        public int ForceRank { get; set; }

        [XmlElement("Astrogation")]
        /*
         * Int
         */
        public Skill Astrogation { get; set; }

        [XmlElement("Athletics")]
        /*
         * Br
         */
        public Skill Athletics { get; set; }

        [XmlElement("Charm")]
        /*
         * Pr
         */
        public Skill Charm { get; set; }

        [XmlElement("Coercion")]
        /*
         * Will
         */
        public Skill Coercion { get; set; }

        [XmlElement("Computers")]
        /*
         * Int
         */
        public Skill Computers { get; set; }

        [XmlElement("Cool")]
        /*
         * Pr
         */
        public Skill Cool { get; set; }

        [XmlElement("Coordination")]
        /*
         * Ag
         */
        public Skill Coordination { get; set; }

        [XmlElement("Deception")]
        /*
         * Cun
         */
        public Skill Deception { get; set; }

        [XmlElement("Discipline")]
        /*
         * Will
         */
        public Skill Discipline { get; set; }

        [XmlElement("Leadership")]
        /*
         * Pr
         */
        public Skill Leadership { get; set; }

        [XmlElement("Mechanics")]
        /*
         * Int
         */
        public Skill Mechanics { get; set; }

        [XmlElement("Medicine")]
        /*
         * Int
         */
        public Skill Medicine { get; set; }

        [XmlElement("Negotiation")]
        /*
         * Pr
         */
        public Skill Negotiation { get; set; }

        [XmlElement("Perception")]
        /*
         * Cun
         */
        public Skill Perception { get; set; }

        [XmlElement("PilotingPlanetary")]
        /*
         * Ag
         */
        public Skill PilotingPlanetary { get; set; }

        [XmlElement("PilotingSpace")]
        /*
         * Ag
         */
        public Skill PilotingSpace { get; set; }

        [XmlElement("Resilience")]
        /*
         * Br
         */
        public Skill Resilience { get; set; }

        [XmlElement("Skulduggery")]
        /*
         * Cun
         */
        public Skill Skulduggery { get; set; }

        [XmlElement("Stealth")]
        /*
         * Ag
         */
        public Skill Stealth { get; set; }

        [XmlElement("Streetwise")]
        /*
         * Cun
         */
        public Skill Streetwise { get; set; }

        [XmlElement("Survival")]
        /*
         * Cun
         */
        public Skill Survival { get; set; }

        [XmlElement("Vigilance")]
        /*
         * Will
         */
        public Skill Vigilance { get; set; }

        [XmlElement("Brawl")]
        /*
         * Br
         */
        public Skill Brawl { get; set; }

        [XmlElement("Gunnery")]
        /*
         * Ag
         */
        public Skill Gunnery { get; set; }

        [XmlElement("Lightsaber")]
        /*
         * Varies
         */
        public Skill Lightsaber { get; set; }

        [XmlElement("Leadership")]
        /*
         * Pr
         */
        public Skill Leadership { get; set; }

        [XmlElement("Melee")]
        /*
         * Br
         */
        public Skill Melee { get; set; }

        [XmlElement("RangedLight")]
        /*
         * Ag
         */
        public Skill RangedLight { get; set; }

        [XmlElement("RangedHeavy")]
        /*
         * Ag
         */
        public Skill RangedHeavy { get; set; }

        [XmlElement("CoreWorlds")]
        /*
         * Int
         */
        public Skill CoreWorlds { get; set; }

        [XmlElement("Education")]
        /*
         * Int
         */
        public Skill Education { get; set; }

        [XmlElement("Lore")]
        /*
         * Int
         */
        public Skill Lore { get; set; }

        [XmlElement("OuterRim")]
        /*
         * Int
         */
        public Skill OuterRim { get; set; }

        [XmlElement("Underworld")]
        /*
         * Int
         */
        public Skill Underworld { get; set; }

        [XmlElement("Warfare")]
        /*
         * Int
         */
        public Skill Warfare { get; set; }

        [XmlElement("Xenology")]
        /*
         * Int
         */
        public Skill Xenology { get; set; }

        public Character()
        {
            
        }


    }

    [XmlRoot("Skill")]
    public class Skill
    {
        [XmlElement("Ranks")]
        public int Ranks { get; set; }

        [XmlElement("Characteristic")]
        public CHARACTERISTIC Characteristic { get; set; }

       public string Roll ()
        {
            throw new NotImplementedException();
        }

    }

    public enum CHARACTERISTIC
    {
        BRAWN,
        AGILITY,
        INTELLECT,
        CUNNING,
        WILLPOWER,
        PRESENCE,
        FORCERATING
    }
}
