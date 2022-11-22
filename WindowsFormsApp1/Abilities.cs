using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    /// <summary>
    /// This class is a container for all the ablilites of a given creature
    /// Abilities come in packages of three (e.g. Insight, Animal Handling and Deception make up a package of Empathy).
    /// Packages are important when creating a character, but are not important during the game.
    /// Authors of this project decided to implement only the essential abilities in the simplest possible form
    /// (but in accordance with DRY rule).
    /// However, if an interactive character creator is to be implemented, this class will require refactoring.
    /// </summary>
    public class Abilities
    {
        ///CONSTITUTION BASED ABILITIES

        ///Fitness
        ///public Ability condition { get; set; }
        ///public Ability swimming { get; set; }
        ///public Ability climbing { get; set; }

        ///Horse riding
        ///public Ability horseRiding { get; set; }
        ///public Ability carriageDriving { get; set; }
        ///public Ability dressage { get; set; }


        ///DEXTERITY BASED ABILITIES

        ///Melee combat
        public DexterityBasedAbility brawling { get; set; } = new DexterityBasedAbility();
        public DexterityBasedAbility meleeWeapons { get; set; } = new DexterityBasedAbility();
        public DexterityBasedAbility throwing { get; set; } = new DexterityBasedAbility();

        ///Vehicle driving
        ///public Ability carDriving { get; set; }
        ///public Ability motorcycleDriving { get; set; }
        ///public Ability truckDriving { get; set; }

        ///Manual skills
        ///public Ability pickpocketing { get; set; }
        ///public Ability lockpicking { get; set; }
        ///public Ability sleightOfHand { get; set; }

        ///Firearms
        public DexterityBasedAbility pistols { get; set; } = new DexterityBasedAbility();
        public DexterityBasedAbility rifles { get; set; } = new DexterityBasedAbility();
        public DexterityBasedAbility machineGuns { get; set; } = new DexterityBasedAbility();

        ///Ranged weapons
        public DexterityBasedAbility bow { get; set; } = new DexterityBasedAbility();
        public DexterityBasedAbility crossbow { get; set; } = new DexterityBasedAbility();
        public DexterityBasedAbility slingshot { get; set; } = new DexterityBasedAbility();


        ///CHARISMA BASED ABILITIES

        ///Negotiating
        ///public Ability intimidation { get; set; }
        ///public Ability persuassion { get; set; }
        ///public Ability leadership { get; set; }

        ///Empathy
        ///public Ability insight { get; set; }
        ///public Ability deception { get; set; }
        ///public Ability animalHandling { get; set; }

        ///Willpower
        public CharismaBasedAbility painResistance { get; set; } = new CharismaBasedAbility();
        public CharismaBasedAbility resilience { get; set; } = new CharismaBasedAbility();
        public CharismaBasedAbility morale { get; set; } = new CharismaBasedAbility();


        ///INTELLIGENCE BASED ABILITIES

        ///Medicine
        public IntelligenceBasedAbility firstAid { get; set; } = new IntelligenceBasedAbility(); 
        public IntelligenceBasedAbility woundsHealing { get; set; } = new IntelligenceBasedAbility();
        public IntelligenceBasedAbility diseaseTreatment { get; set; } = new IntelligenceBasedAbility();

        ///Technics
        ///public Ability mechanics { get; set; }
        ///public Ability electronics { get; set; }
        ///public Ability computers { get; set; }

        ///Heavy equipment
        ///public Ability heavyMachinery { get; set; }
        ///public Ability combatVehicles { get; set; }
        ///public Ability cutters { get; set; }

        ///Pyrotechnics
        public IntelligenceBasedAbility gunsmithing { get; set; } = new IntelligenceBasedAbility();
        public IntelligenceBasedAbility pyrotechnicLaunchers { get; set; } = new IntelligenceBasedAbility();
        public IntelligenceBasedAbility explosives { get; set; } = new IntelligenceBasedAbility();


        ///PERCEPTION BASED ABILITIES

        ///Spatial orienatation
        ///public Ability senseOfDirection { get; set; }
        ///public Ability trapmaking { get; set; }
        ///public Ability tracking { get; set; }

        ///Perceptivity
        public PerceptionBasedAbility listening { get; set; } = new PerceptionBasedAbility();
        public PerceptionBasedAbility looking { get; set; } = new PerceptionBasedAbility();
        public PerceptionBasedAbility vigilance { get; set; } = new PerceptionBasedAbility();

        ///Camouflage
        public PerceptionBasedAbility sneaking { get; set; } = new PerceptionBasedAbility();
        public PerceptionBasedAbility hiding { get; set; } = new PerceptionBasedAbility();
        public PerceptionBasedAbility masking { get; set; } = new PerceptionBasedAbility();

        ///Survival
        ///public Ability hunting { get; set; }
        ///public Ability terrainKnowledge { get; set; }
        ///public Ability waterGathering { get; set; }

        /// <summary>
        /// Because Abilities class has over 50 fields and most of them usually have default value,
        /// this constructor sets value of every ability at 0
        /// </summary>
    }
}