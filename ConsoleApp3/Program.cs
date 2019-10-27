using System;

namespace Nguyen_1minute_AD
{
    class shape
    {
        private double LongEdge;
        private double ShortEdge;
        public shape(double LongEdge, double ShortEdge)
        {
            this.LongEdge = LongEdge;
            this.ShortEdge = ShortEdge;
        }
        public double calculateArea()
        {
            return LongEdge * ShortEdge;
        }
    }
    class square : shape
    {
        public square(double LongEdge, double ShortEdge) : base(LongEdge, ShortEdge)
        {

        }
    }
    class rectangle : shape
    {
        public rectangle(double LongEdge, double ShortEdge) : base(LongEdge, ShortEdge)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            square sq = new square(20, 20);
            Console.WriteLine("dien tich hinh vuong la: " + sq.calculateArea());
            rectangle rec = new rectangle(30,60);
            Console.WriteLine("dien tich hinh chu nhat la: " + rec.calculateArea());
        }
    }
}