﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Rectangle
    {
        private readonly Point lowerLeftPoint;
        private readonly Point lowerRightPoint;
        private readonly Point upperLeftPoint;
        private readonly Point upperRightPoint;
        private readonly LineSegment lowerSide;
        private readonly LineSegment upperSide;
        private readonly LineSegment leftSide;
        private readonly LineSegment rightSide;
        private readonly double width;
        private readonly double height;
        private readonly Point center;
        public Point LowerLeftPoint { get { return lowerLeftPoint; } }
        public Point LowerRightPoint { get { return lowerRightPoint; } }
        public Point UpperLeftPoint { get { return upperLeftPoint; } }
        public Point UpperRightPoint { get { return upperRightPoint; } }
        public LineSegment LowerSide { get { return lowerSide; } }
        public LineSegment UpperSide { get { return upperSide; } }
        public LineSegment LeftSide { get { return leftSide; } }
        public LineSegment RightSide { get { return rightSide; } }
        public double Width { get { return width; } }
        public double Height { get { return height; } }
        public Point Center { get { return center; } }

        public Rectangle(Point p1, Point p2)
        {
            if (p1.X == p2.X || p1.Y == p2.Y) throw new ArgumentException("Points on same axis, can't create rectangle");

            if (p1.Y > p2.Y)
            {
                Point temp = p1;
                p1 = p2;
                p2 = temp;
            }

            width = p2.X - p1.X;
            height = p2.Y - p1.Y;
            lowerLeftPoint = p1;
            upperLeftPoint = new Point(p1.X, p2.Y - width);
            upperRightPoint = p2;
            lowerRightPoint = new Point(p2.X, p1.Y + width);
            lowerSide = new LineSegment(lowerLeftPoint, lowerRightPoint);
            upperSide = new LineSegment(upperLeftPoint, upperRightPoint);
            leftSide = new LineSegment(lowerLeftPoint, upperLeftPoint);
            rightSide = new LineSegment(lowerRightPoint, upperRightPoint);
            center = new Point(p1.X + width / 2, p1.Y + height / 2);
        }

        public Rectangle(Rectangle rect)
        {
            lowerLeftPoint = new Point(rect.lowerLeftPoint.X, rect.lowerLeftPoint.Y);
            lowerRightPoint = new Point(rect.lowerRightPoint.X, rect.lowerRightPoint.Y);
            upperLeftPoint = new Point(rect.upperLeftPoint.X, rect.upperLeftPoint.Y);
            upperRightPoint = new Point(rect.upperRightPoint.X, rect.upperRightPoint.Y);
            lowerSide = new LineSegment(rect.lowerSide.StartPoint, rect.lowerSide.EndPoint);
            upperSide = new LineSegment(rect.upperSide.StartPoint, rect.upperSide.EndPoint);
            leftSide = new LineSegment(rect.leftSide.StartPoint, rect.leftSide.EndPoint);
            rightSide = new LineSegment(rect.rightSide.StartPoint, rect.rightSide.EndPoint);
            width = rect.width;
            height = rect.height;
            center = new Point(rect.center.X, rect.center.Y);
        }

        public double GetPerimeter()
        {
            return 2 * width + 2 * height;
        }

        public double GetArea()
        {
            return width * height;
        }

        public override string ToString()
        {
            return string.Format("Rectangle[({0}, {1}), ({2}, {3})]", lowerLeftPoint.X, lowerLeftPoint.Y, height, width);
        }

        public override bool Equals(object obj)
        {
            if (obj is Rectangle)
            {
                Rectangle rect = obj as Rectangle;
                if (!lowerLeftPoint.Equals(rect.lowerLeftPoint) || !lowerRightPoint.Equals(rect.lowerRightPoint) || !upperLeftPoint.Equals(rect.upperLeftPoint) ||
                    !upperRightPoint.Equals(rect.upperRightPoint) || !lowerSide.Equals(rect.lowerSide) || !upperSide.Equals(rect.upperSide) ||
                    !leftSide.Equals(rect.leftSide) || !rightSide.Equals(rect.rightSide) || !width.Equals(rect.width) || !height.Equals(rect.height) || !center.Equals(rect.center))
                {
                    return false;
                }

                return true;
            }

            else return false;
        }

        public static bool operator ==(Rectangle rect1, Rectangle rect2)
        {
            return object.Equals(rect1, rect2);
        }

        public static bool operator !=(Rectangle rect1, Rectangle rect2)
        {
            return !object.Equals(rect1, rect2);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 13;
                hash = hash * 7 + lowerLeftPoint.GetHashCode();
                hash = hash * 7 + lowerRightPoint.GetHashCode();
                hash = hash * 7 + upperLeftPoint.GetHashCode();
                hash = hash * 7 + upperRightPoint.GetHashCode();
                hash = hash * 7 + lowerSide.GetHashCode();
                hash = hash * 7 + upperSide.GetHashCode();
                hash = hash * 7 + leftSide.GetHashCode();
                hash = hash * 7 + rightSide.GetHashCode();
                hash = hash * 7 + width.GetHashCode();
                hash = hash * 7 + height.GetHashCode();
                hash = hash * 7 + center.GetHashCode();
                return hash;
            }
        }
    }
}
