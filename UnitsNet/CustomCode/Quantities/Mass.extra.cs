﻿// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using JetBrains.Annotations;
using UnitsNet.Units;

namespace UnitsNet
{
    public partial struct Mass
    {
        public static Mass FromGravitationalForce(Force f)
        {
            return new Mass(f.KilogramsForce, MassUnit.Kilogram);
        }

        /// <summary>
        ///     StonePounds related code makes it easier to work with Stone/Pound combination, which are customarily used in the UK
        ///     to express body weight. For example, someone weighs 11 stone 4 pounds (about 72 kilograms).
        /// </summary>
        private const double StonesInOnePound = 14.0;

        /// <summary>
        ///     Converts the mass to a customary stone/pounds combination.
        /// </summary>
        public StonePounds StonePounds
        {
            get
            {
                var inPounds = Pounds;

                var stones = Math.Truncate(inPounds / StonesInOnePound);
                var pounds = inPounds % StonesInOnePound;

                return new StonePounds(stones, pounds);
            }
        }

        /// <summary>
        ///     Get Mass from combination of stone and pounds.
        /// </summary>
        public static Mass FromStonePounds(double stone, double pounds)
        {
            return FromPounds(StonesInOnePound*stone + pounds);
        }

        public static MassFlow operator /(Mass mass, TimeSpan timeSpan)
        {
            return MassFlow.FromKilogramsPerSecond(mass.Kilograms/timeSpan.TotalSeconds);
        }

        public static MassFlow operator /(Mass mass, Duration duration)
        {
            return MassFlow.FromKilogramsPerSecond(mass.Kilograms/duration.Seconds);
        }

        public static Density operator /(Mass mass, Volume volume)
        {
            return Density.FromKilogramsPerCubicMeter(mass.Kilograms/volume.CubicMeters);
        }

        public static Volume operator /(Mass mass, Density density)
        {
            return Volume.FromCubicMeters(mass.Kilograms / density.KilogramsPerCubicMeter);
        }

        public static Force operator *(Mass mass, Acceleration acceleration)
        {
            return Force.FromNewtons(mass.Kilograms*acceleration.MetersPerSecondSquared);
        }

        public static Force operator *(Acceleration acceleration, Mass mass)
        {
            return Force.FromNewtons(mass.Kilograms*acceleration.MetersPerSecondSquared);
        }
    }

    public sealed class StonePounds
    {
        public StonePounds(double stone, double pounds)
        {
            Stone = stone;
            Pounds = pounds;
        }

        public double Stone { get; }
        public double Pounds { get; }

        public override string ToString()
        {
            return ToString(null);
        }

        public string ToString([CanBeNull] IFormatProvider cultureInfo)
        {
            cultureInfo = cultureInfo ?? GlobalConfiguration.DefaultCulture;

            var stoneUnit = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(MassUnit.Stone, cultureInfo);
            var poundUnit = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(MassUnit.Pound, cultureInfo);

            // Note that it isn't customary to use fractions - one wouldn't say "I am 11 stone and 4.5 pounds".
            // So pounds are rounded here.
            return string.Format(cultureInfo, "{0:n0} {1} {2:n0} {3}", Stone, stoneUnit, Math.Round(Pounds), poundUnit);
        }
    }
}
