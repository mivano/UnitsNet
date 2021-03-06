﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make 
//     it easier to remember to implement all the unit conversion test cases.
// 
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
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

namespace UnitsNet.Tests.CustomCode
{
    public class ElectricResistivityTests : ElectricResistivityTestsBase
    {
        // TODO Override properties in base class here
        protected override double KiloohmsCentimeterInOneOhmMeter => 1e-1;

        protected override double KiloohmMetersInOneOhmMeter => 1e-3;

        protected override double MegaohmsCentimeterInOneOhmMeter => 1e-4;

        protected override double MegaohmMetersInOneOhmMeter => 1e-6;

        protected override double MicroohmsCentimeterInOneOhmMeter => 1e8;

        protected override double MicroohmMetersInOneOhmMeter => 1e6;

        protected override double MilliohmsCentimeterInOneOhmMeter => 1e5;

        protected override double MilliohmMetersInOneOhmMeter => 1e3;

        protected override double NanoohmsCentimeterInOneOhmMeter => 1e11;

        protected override double NanoohmMetersInOneOhmMeter => 1e9;

        protected override double OhmsCentimeterInOneOhmMeter => 1e2;

        protected override double OhmMetersInOneOhmMeter => 1;

        protected override double PicoohmsCentimeterInOneOhmMeter => 1e14;

        protected override double PicoohmMetersInOneOhmMeter => 1e+12;
    }
}
