using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public class Stats
    {
        public Stat charisma { get; set; }
        public Stat constitution { get; set; }
        public Stat dexterity { get; set; }
        public Stat intelligence { get; set; }
        public Stat perception { get; set; }

        public Stats(int charisma, int constitution, int dexterity, int intelligence, int perception)
        {
            this.charisma = new Stat();
            this.charisma.value = charisma;
            this.constitution = new Stat();
            this.constitution.value = constitution;
            this.dexterity = new Stat();
            this.dexterity.value = dexterity;
            this.intelligence = new Stat();
            this.intelligence.value = intelligence;
            this.perception = new Stat();
            this.perception.value = perception;
        }

        public void ApplyModifierInt(int modifier)
        {
            this.charisma.ApplyModifierInt(modifier);
            this.constitution.ApplyModifierInt(modifier);
            this.dexterity.ApplyModifierInt(modifier);
            this.intelligence.ApplyModifierInt(modifier);
            this.perception.ApplyModifierInt(modifier);
        }

        public void ApplyModifierPercentage(int modifier)
        {
            this.charisma.ApplyModifierPercentage(modifier);
            this.constitution.ApplyModifierPercentage(modifier);
            this.dexterity.ApplyModifierPercentage(modifier);
            this.intelligence.ApplyModifierPercentage(modifier);
            this.perception.ApplyModifierPercentage(modifier);
        }
    }
}