using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    //amish tangri 
    //Assignment 3-
    //24/07/2020
    //301108446
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type; //either Gas or Ice
        public string Type { get { return _type; } set { _type = value; } }
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes 4 arguments
         * </summary>
         * 
         * @constructor
         */
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            _type = type;
        }

        public override string ToString() //this is more good ToString() method for this subclass
        {
            return string.Format("{0} - diameter = {1} | mass = {2} | type: {3}", Name, Diameter, Mass, Type);
        }
        // these are public methods
        public bool HasMoons()
        {
            if (MoonCount > 0)
                return true;
            else
                return false;
        }

        public bool HasRings()
        {
            if (RingCount > 0)
                return true;
            else
                return false;
        }
    }
}

