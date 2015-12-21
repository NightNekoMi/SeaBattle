﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Model.ForShips
{
    public class FourDeckShipCreator : ShipCreator
    {
        public override Ship createShip()
        {
            return new Ship(ShipType.FourDeckShip);
        }
    }
}
