using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeStatisticsVolleyball.Class
{
    internal class Player
    {
        private string name;
        private int number;

        private int dig;
        private int spike;
        private int serve;
        private int set;
        private int block;

        private int errorDig;
        private int errorSpike;
        private int errorServe;
        private int errorSet;
        private int errorBlock;

        private int pointDig;
        private int pointSpike;
        private int pointServe;
        private int pointSet;
        private int pointBlock;


        private int points;

        public Player(string name, int number)
        {
            this.name = name;
            this.number = number;

            this.Dig = 0;  
            this.Spike = 0;
            this.Serve = 0;
            this.Set = 0;
            this.Block = 0;

            this.ErrorDig = 0;
            this.ErrorSpike = 0;
            this.ErrorServe = 0;
            this.PointSet = 0;
            this.PointBlock = 0;

            this.PointDig = 0;
            this.PointSpike = 0;
            this.PointServe = 0;
            this.PointSet = 0;
            this.PointBlock = 0;
            
            this.points = 0;
        }

        public int Dig { get => dig; set => dig = value; }
        public int Spike { get => spike; set => spike = value; }
        public int Serve { get => serve; set => serve = value; }
        public int Set { get => set; set => set = value; }
        public int Block { get => block; set => block = value; }
        public int ErrorDig { get => errorDig; set => errorDig = value; }
        public int ErrorSpike { get => errorSpike; set => errorSpike = value; }
        public int ErrorServe { get => errorServe; set => errorServe = value; }
        public int ErrorSet { get => errorSet; set => errorSet = value; }
        public int ErrorBlock { get => errorBlock; set => errorBlock = value; }
        public int PointDig { get => pointDig; set => pointDig = value; }
        public int PointSpike { get => pointSpike; set => pointSpike = value; }
        public int PointServe { get => pointServe; set => pointServe = value; }
        public int PointSet { get => pointSet; set => pointSet = value; }
        public int PointBlock { get => pointBlock; set => pointBlock = value; }

        public void doDig(bool point,bool error)
        {

            if (point)
            {
                PointDig++;
                points++;
            }
            if (error)
            {
                ErrorDig++;
            }
            Dig++;
        }

        public void doSpike(bool point, bool error)
        {
            if (point)
            {
                PointSpike++;
                points++;
            }
            if (error)
            {
                ErrorSpike++;
            }
            Spike++;
        }

        public void doServe(bool point, bool error)
        {
            if (point)
            {
                PointServe++;
                points++;
            }
            if (error)
            {
                ErrorServe++;
            }
            Serve++;
        }

        public void doSet(bool point, bool error)
        {
            if (point)
            {
                PointSet++;
                points++;
            }
            if (error)
            {
                ErrorSet++;
            }
            Set++;
        }

        public void doBlock(bool point, bool error)
        {
            if (point)
            {
                PointBlock++;
                points++;
            }
            if (error)
            {
                ErrorBlock++;
            }
            Block++;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
