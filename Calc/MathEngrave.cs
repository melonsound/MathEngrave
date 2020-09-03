﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class MathEngrave
    {
        public float timeResult;
        float engraveHeadSpeed = 400; //CNC optional parameter
        float verticalOffset = 0.1f; //Head vertical offset of laser engrave CNC
        public string length { get; set; }
        public string height { get; set; }

        public void EngraveTime()
        {
            timeResult = engraveHeadSpeed / Convert.ToSingle(length);
            timeResult *= verticalOffset;
            timeResult = Convert.ToSingle(height) / timeResult;
            timeResult /= 60;
            timeResult *= 2;

            //Alternative math operation all in one

            //timeResult = ((Convert.ToSingle(height) / ((engraveHeadSpeed / Convert.ToSingle(length)) * verticalOffset)) / 60) * 2;
        }
    }
}
