using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Stat : ITrait
    {
        public int modifierInt { get; set; }

        public int modifierPercentage { get; set; }
        public int value { get; set; }

        public int OpenCheck()
        {
            throw new NotImplementedException();
        }

        public bool Check()
        {
            throw new NotImplementedException();
        }

        public object Contest()
        {
            throw new NotImplementedException();
        }

    }
}