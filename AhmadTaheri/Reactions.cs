using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    public class Reactions
    {


        // Method.
        
        public Tuple<double,double,double> RNum(int Num)
        {



            //reaction 1
            if(Num==1)
            { 
            double k01 = 5.75 * Math.Pow(10, 11);
            double E1 = 108800;
            double DeltaV1 = 6.11 * Math.Pow(10, -6);

                return Tuple.Create<double, double, double>(k01,E1,DeltaV1);
            }
            //reaction 2
            if(Num==2)
            { 
            double k02 = 1.180 * Math.Pow(10, 16);
            double E2 = 160665.6;
            double DeltaV2 = 2.5 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k02, E2, DeltaV2);

            }


            //reaction 3
            if(Num==3)
            { 
            double k03 = 1.54 * Math.Pow(10, 14);
            double E3 = 124.90 * Math.Pow(10, 3);
                return Tuple.Create<double, double, double>(k03, E3, 0.0);
            }
            //reaction 4
            if(Num==4)
            { 
            double k04 = 2.59 * Math.Pow(10, 8);
            double E4 = 37656;
            double DeltaV4 = -19.7 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k04, E4, DeltaV4);

            }
            //reaction 5
            if (Num == 5)
            {
                double k05 = 2.59 * Math.Pow(10, 8);
                double E5 = 37656;
                double DeltaV5 = -19.7 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k05, E5, DeltaV5);

            }
            //reaction 6
            if (Num == 6)
            {
                double k06 = 1.25 * Math.Pow(10, 5);
                double E6 = 33767;
                double DeltaV6 = -19.7 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k06, E6, DeltaV6);

            }
            //reaction 7
            if (Num == 7)
            {
                double k07 = 5.00 * Math.Pow(10, 11);
                double E7 = 72684.448;
                double DeltaV7 = -19.7 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k07, E7, DeltaV7);
            }
            //reaction 8
            if (Num == 8)
            {
                double k08 = 1.0087 * Math.Pow(10, 9);
                double E8 = 52843.92;
                double DeltaV8 = 4.4 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k08, E8, DeltaV8);

            }
            //reaction 9
            if (Num == 9)
            {
                double k09 = 3.70 * Math.Pow(10, 5);
                double E9 = 46358.72;
                double DeltaV9 = -16.8 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k09, E9, DeltaV9);

            }
            //reaction 10
            if (Num == 10)
            {
                double k10 = 1.25 * Math.Pow(10, 6);
                double E10 = 33767;
                double DeltaV10 = -19.7 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k10, E10, DeltaV10);

            }
            //reaction 11
            if (Num == 11)
            {
                double k11 = 4.8 * Math.Pow(10, 8);
                double E11 = 44224.88;
                double DeltaV11 = -15.9 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k11, E11, DeltaV11);

            }
            //reaction 12
            if (Num == 12)
            {
                double k12 = 4.015 * Math.Pow(10, 7);
                double E12 = 50542.72;
                double DeltaV12 = -16.8 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k12, E12, DeltaV12);

            }
            //reaction 13
            if (Num == 13)
            {
                double k13 = 4.0125 * Math.Pow(10, 7);
                double E13 = 50542.72;
                double DeltaV13 = -19.7 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k13, E13, DeltaV13);

            }

            //reaction 14
            if (Num == 14)
            {
                double k14 = 4.75 * Math.Pow(10, 9);
                double E14 = 4184;
                double DeltaV14 = 1.3 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k14, E14, DeltaV14);

            }
            //reaction 15
            if (Num == 15)
            {
                double k15 = 1.55 * Math.Pow(10, 9);
                double E15 = 4184;
                double DeltaV15 = 1.3 * Math.Pow(10, -6);
                return Tuple.Create<double, double, double>(k15, E15, DeltaV15);

            }
            return Tuple.Create<double, double, double>(0.0, 0.0, 0.0);
        }
    }
}
