﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    //amish tangri -
    //Assignment 3 -
    //24/07/2020
    //301108446

    // PRIVATE INSTANCE VARIABLES
    public abstract class Planet
        {
            private double _diameter;
            private double _mass;
            private int _moonCount;
            private string _name;
            private double _orbitalPeriod;
            private int _ringCount;
            private double _rotationPeriod;
        // PUBLIC PROPERTIES
        public double Diameter
            {
                get
                {
                    return _diameter;
                }
            }

            public double Mass
            {
                get
                {
                    return _mass;
                }
            }

            public int MoonCount
            {
                get
                {
                    return _moonCount;
                }
                set
                {
                    _moonCount = value;
                }
            }

            public string Name
            {
                get
                {
                    return _name;
                }
            }

            public double OrbitalPeriod
            {
                get
                {
                    return _orbitalPeriod;
                }
                set
                {
                    _orbitalPeriod = value;
                }
            }

            public int RingCount
            {
                get
                {
                    return _ringCount;
                }
                set
                {
                    _ringCount = value;
                }
            }

            public double RotationPeriod
            {
                get
                {
                    return _rotationPeriod;
                }
                set
                {
                    _rotationPeriod = value;
                }
            }

            public Planet(string name, double diameter, double mass)
            {
                _name = name;
                _diameter = diameter;
                _mass = mass;
            }

            public override string ToString()
            {
                return string.Format("{0} - diameter = {1} | mass = {2} ", Name, Diameter, Mass);
            }
        }
    }
