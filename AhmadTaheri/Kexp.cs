using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    class Kexp
    {
        public Tuple<double,int> kexp(double k,double E,double DeltaV,int RNum,double P,double Temp)
        {

            if(RNum==0)
            {
                Console.WriteLine("Reaction Number is Wrong");
            }
            // Kexp
            // p feshar reactor folan shomare
           
            double T0 = 438;
            double e = 2.7183;
            double R = 8.3142;


            // Kexp1
            if(RNum==1)
            { 
            double Kexp1 = k * (Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp))));
                var t = Tuple.Create(Kexp1, 1);
                return t;
            }
            // Kexp2
            if (RNum == 2)
            {
                double Kexp2 = k * (Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp))));
                var t = Tuple.Create(Kexp2, 2);
                return t;
            }
            // Kexp3
            if (RNum == 3)
            {
                double Kexp3 = k * (Math.Pow(e, -(E) / (R * Temp)));
                var t = Tuple.Create(Kexp3, 3);
                return t;
            }
            // Kexp4
            if (RNum == 4)
            {
                double Kexp4 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp4, 4);
                return t;
            }
            // Kexp5
            if (RNum == 5)
            {
                double Kexp5 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp5, 5);
                return t;
            }
            // Kexp6
            if (RNum == 6)
            {
                double Kexp6 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp6, 6);
                return t;
            }
            // Kexp7
            if (RNum == 7)
            {
                double Kexp7 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp7, 7);
                return t;
            }
            // Kexp8
            if (RNum == 8)
            {
                double Kexp8 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp8, 8);
                return t;
            }
            // Kexp9
            if (RNum == 9)
            {
                double Kexp9 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp9, 9);
                return t;
            }
            // Kexp10
            if (RNum == 10)
            {
                double Kexp10 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp10, 10);
                return t;
            }
            // Kexp11
            if (RNum == 11)
            {
                double Kexp11 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp11, 11);
                return t;
            }
            // Kexp12
            if (RNum == 12)
            {
                double Kexp12 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp12, 12);
                return t;
            }
            // Kexp13
            if (RNum == 13)
            {
                double Kexp13 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp13, 13);
                return t;
            }
            // Kexp14
            if (RNum == 14)
            {
                double Kexp14 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp14, 14);
                return t;
            }
            // Kexp15
            if (RNum == 15)
            {
                double Kexp15 = k * Math.Pow(e, -((E + (P * DeltaV)) / (R * Temp)));
                var t = Tuple.Create(Kexp15, 15);
                return t;

            }
            else
            { 
            return null;
            }
        }
    }
}
