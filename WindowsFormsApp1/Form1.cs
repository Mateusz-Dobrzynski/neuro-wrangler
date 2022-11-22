using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /*
     TO-DO:
    - Rename labels and buttons to be more descriptive
    - Make [stat]Penalty labels interactive (showing penalty percentages)
    - Add Check and Open check buttons
    - Text input allowing insertion of the characters's name
    - Save button allows to save a character as a creature
        - Save button allows to pick a directory
        - File will be saved with Serializer under name
          typed by the user in the text input
    - Load button allows to load parameters of a character.
      Character's stats are shown in GUI
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {   
            //Saving the file
            if (saveLocationDialog.ShowDialog() == DialogResult.OK)
            {
                //Declaring all the basic information
                Creature creatureToSave = new Creature();
                creatureToSave.stats = new Stats(0, 0, 0, 0, 0);
                creatureToSave.abilities = new Abilities();
                creatureToSave.wounds = new List<IWound>();

                //Getting the name
                creatureToSave.name = nameTextBox.Text;

                //Getting the stats
                creatureToSave.stats.charisma.value = (int) charismaUpDown.Value;
                creatureToSave.stats.constitution.value = (int) constitutionUpDown.Value;
                creatureToSave.stats.dexterity.value = (int) dexterityUpDown.Value;
                creatureToSave.stats.intelligence.value = (int) intelligenceUpDown.Value;
                creatureToSave.stats.perception.value = (int) perceptionUpDown.Value;

                //Getting the abilites
                creatureToSave.abilities.brawling.value = (int) brawlingUpDown.Value;
                creatureToSave.abilities.meleeWeapons.value = (int) meleeUpDown.Value;
                creatureToSave.abilities.throwing.value = (int) throwingUpDown.Value;

                creatureToSave.abilities.pistols.value = (int) pistolsUpDown.Value;
                creatureToSave.abilities.rifles.value = (int) riflesUpDown.Value;
                creatureToSave.abilities.machineGuns.value = (int) machineGunsUpDown.Value;

                creatureToSave.abilities.bow.value = (int) bowUpDown.Value;
                creatureToSave.abilities.crossbow.value = (int) crossbowUpDown.Value;
                creatureToSave.abilities.slingshot.value = (int) slingshotUpDown.Value;

                creatureToSave.abilities.painResistance.value = (int) painResistanceUpDown.Value;
                creatureToSave.abilities.resilience.value = (int) resilienceUpDown.Value;
                creatureToSave.abilities.morale.value = (int )moraleUpDown.Value;

                creatureToSave.abilities.firstAid.value = (int)firstAidUpDown.Value;
                creatureToSave.abilities.woundsHealing.value = (int) woundsHealingUpDown.Value;
                creatureToSave.abilities.diseaseTreatment.value = (int) diseaseTreatmentUpDown.Value;

                creatureToSave.abilities.gunsmithing.value = (int) gunsmithingUpDown.Value;
                creatureToSave.abilities.pyrotechnicLaunchers.value = (int) pyrotechnicsLaunchersUpDown.Value;
                creatureToSave.abilities.explosives.value = (int) explosivesUpDown.Value;

                creatureToSave.abilities.listening.value = (int) listeningUpDown.Value;
                creatureToSave.abilities.looking.value = (int) lookingUpDown.Value;
                creatureToSave.abilities.vigilance.value = (int) vigilanceUpDown.Value;

                creatureToSave.abilities.sneaking.value = (int) sneakingUpDown.Value;
                creatureToSave.abilities.hiding.value = (int) hidingUpDown.Value;
                creatureToSave.abilities.masking.value = (int) maskingUpDown.Value;

                string directory = saveLocationDialog.SelectedPath;
                Serializer s = new Serializer();
                s.Save(creatureToSave, directory);
            }
            
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void addWoundButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Serializer s = new Serializer();
                string path = dialog.FileName;
                Creature loadedCreature = s.Load<Creature>(path);

                //Changing the name
                nameTextBox.Text = loadedCreature.name;

                //Changing the stats
                charismaUpDown.Value = loadedCreature.stats.charisma.value;
                constitutionUpDown.Value = loadedCreature.stats.constitution.value;
                dexterityUpDown.Value = loadedCreature.stats.dexterity.value;
                intelligenceUpDown.Value = loadedCreature.stats.intelligence.value;
                perceptionUpDown.Value = loadedCreature.stats.perception.value;

                //Changing the abilities
                brawlingUpDown.Value = loadedCreature.abilities.brawling.value;
                meleeUpDown.Value = loadedCreature.abilities.meleeWeapons.value;
                throwingUpDown.Value = loadedCreature.abilities.throwing.value;

                pistolsUpDown.Value = loadedCreature.abilities.pistols.value;
                riflesUpDown.Value = loadedCreature.abilities.rifles.value;
                machineGunsUpDown.Value = loadedCreature.abilities.machineGuns.value;

                bowUpDown.Value = loadedCreature.abilities.bow.value;
                crossbowUpDown.Value = loadedCreature.abilities.crossbow.value;
                slingshotUpDown.Value = loadedCreature.abilities.slingshot.value;

                painResistanceUpDown.Value = loadedCreature.abilities.painResistance.value;
                resilienceUpDown.Value = loadedCreature.abilities.resilience.value;
                moraleUpDown.Value = loadedCreature.abilities.morale.value;

                firstAidUpDown.Value = loadedCreature.abilities.firstAid.value;
                woundsHealingUpDown.Value = loadedCreature.abilities.woundsHealing.value;
                diseaseTreatmentUpDown.Value = loadedCreature.abilities.diseaseTreatment.value;

                gunsmithingUpDown.Value = loadedCreature.abilities.gunsmithing.value;
                pyrotechnicsLaunchersUpDown.Value = loadedCreature.abilities.pyrotechnicLaunchers.value;
                explosivesUpDown.Value = loadedCreature.abilities.explosives.value;

                listeningUpDown.Value = loadedCreature.abilities.listening.value;
                lookingUpDown.Value = loadedCreature.abilities.looking.value;
                vigilanceUpDown.Value = loadedCreature.abilities.vigilance.value;

                sneakingUpDown.Value = loadedCreature.abilities.sneaking.value;
                hidingUpDown.Value = loadedCreature.abilities.hiding.value;
                maskingUpDown.Value = loadedCreature.abilities.masking.value;
                
            }
        }

        private void diseaseTreatmentUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }   
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)

        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown22_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pistolsUpDown_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
