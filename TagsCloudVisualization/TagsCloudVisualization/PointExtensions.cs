﻿using System;
using System.Drawing;


namespace TagsCloudVisualization
{
    public static class PointExtensions
    {
        public static double CountDistanceTo(this Point point1, Point point2)
        {
            return Math.Sqrt(point1.X * point1.X + point2.Y * point2.Y);
        }
    }
}
