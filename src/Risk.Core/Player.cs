﻿namespace Risk.Core
{
    public class Player
    {
        public Player(string name, int numberOfStartingUnits, bool isNeutral)
        {
            this.Name = name;
            this.UnplacedUnits = numberOfStartingUnits;
            this.IsNeutral = isNeutral;
        }

        public string Name { get; private set; }

        public int UnplacedUnits { get; private set; }

        public bool IsNeutral { get; private set; }
    }
}