﻿using Fsd.Bartek.Cs2.Ex2.Domain.UI;
using Fsd.Bartek.Cs2.Ex3.Domain.Magazine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bartek.Cs.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse Shop = new Warehouse();

            BasicUi.Introducion(3, "Objects");
            ProgramUi.Decision(false, Shop);
        }
    }
}
