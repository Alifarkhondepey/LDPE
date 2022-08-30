using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    class CalCulateTou2
    {
        AhmadTaheri.Model.PolymersMatrices db = new Model.PolymersMatrices();

        public Tuple<double> Cal(double r1)
        {
            int i, j, flag;

            double[,] RMCMatrix = new double[15, 1];
            double[,] KMCMatrix = new double[15, 1];
            double[,] KexpMatrix = new double[15, 1];
            double[,] PrkMatrix = new double[15, 1];

            double T0 = 438;
            double e = 2.7183;
            double R = 8.3142;
            //reaction 1
            double k01 = 5.75 * Math.Pow(10, 11);
            double E1 = 108800;
            double DeltaV1 = 6.11 * Math.Pow(10, -6);



            //reaction 2
            double k02 = 1.80 * Math.Pow(10, 16);
            double E2 = 160665.6;
            double DeltaV2 = 2.5 * Math.Pow(10, -6);



            //reaction 3
            double k03 = 1.54 * Math.Pow(10, 14);
            double E3 = 124.90 * Math.Pow(10, 3);

            //reaction 4
            double k04 = 2.59 * Math.Pow(10, 8);
            double E4 = 37656;
            double DeltaV4 = -19.7 * Math.Pow(10, -6);

            //reaction 5
            double k05 = 2.59 * Math.Pow(10, 8);
            double E5 = 37656;
            double DeltaV5 = -19.7 * Math.Pow(10, -6);

            //reaction 6
            double k06 = 1.25 * Math.Pow(10, 5);
            double E6 = 33767;
            double DeltaV6 = -19.7 * Math.Pow(10, -6);

            //reaction 7
            double k07 = 5.00 * Math.Pow(10, 11);
            double E7 = 72684.448;
            double DeltaV7 = -19.7 * Math.Pow(10, -6);

            //reaction 8
            double k08 = 1.0087 * Math.Pow(10, 9);
            double E8 = 52843.92;
            double DeltaV8 = 4.4 * Math.Pow(10, -6);

            //reaction 9
            double k09 = 3.70 * Math.Pow(10, 5);
            double E9 = 46358.72;
            double DeltaV9 = -16.8 * Math.Pow(10, -6);

            //reaction 10
            double k10 = 1.25 * Math.Pow(10, 6);
            double E10 = 33767;
            double DeltaV10 = -19.7 * Math.Pow(10, -6);

            //reaction 11
            double k11 = 4.8 * Math.Pow(10, 8);
            double E11 = 44224.88;
            double DeltaV11 = -15.9 * Math.Pow(10, -6);

            //reaction 12
            double k12 = 4.015 * Math.Pow(10, 7);
            double E12 = 50542.72;
            double DeltaV12 = -16.8 * Math.Pow(10, -6);

            //reaction 13
            double k13 = 4.0125 * Math.Pow(10, 7);
            double E13 = 50542.72;
            double DeltaV13 = -19.7 * Math.Pow(10, -6);


            //reaction 14
            double k14 = 4.75 * Math.Pow(10, 9);
            double E14 = 4184;
            double DeltaV14 = 1.3 * Math.Pow(10, -6);

            //reaction 15
            double k15 = 1.55 * Math.Pow(10, 9);
            double E15 = 4184;
            double DeltaV15 = 1.3 * Math.Pow(10, -6);
            // Kexp












            var RMC = db.RMCs.FirstOrDefault();






            

            double RMCSum = RMC.RMC1.Value + RMC.RMC2.Value + RMC.RMC3.Value +
                RMC.RMC4.Value + RMC.RMC5.Value + RMC.RMC6.Value
                + RMC.RMC7.Value + RMC.RMC8.Value + RMC.RMC9.Value + RMC.RMC10.Value + RMC.RMC11.Value + RMC.RMC12.Value + RMC.RMC13.Value + RMC.RMC14.Value + RMC.RMC15.Value;
            Console.WriteLine("RMC : ");

            Console.WriteLine(RMC);
            var Tou = (1 / RMCSum) * Math.Log(1 / r1);



            //PRK


            double[,] PrK = new double[15, 1];
            double Counter1;
            Counter1 = 0;
            double Counter2;
            Counter2 = 0;

            Model.Prk P = new Model.Prk();
            int ReactionNumber = 0;
            //for (i = 0; i < 15; i++)
            //{
            //    for (j = 0; j < 1; j++)
            //    {
            //        flag = 0;
            //        if (i == 0 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC1.Value / RMCSum;
            //            flag = 1;
            //            P.Prk1 = PrK[i, j];
            //        }
            //        if (i == 1 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC2.Value / RMCSum;
            //            flag = 1;
            //            P.Prk2 = PrK[i, j];
            //        }

            //        if (i == 2 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC3.Value / RMCSum;
            //            flag = 1;
            //            P.Prk3 = PrK[i, j];
            //        }
            //        if (i == 2 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC3.Value / RMCSum;
            //            flag = 1;
            //            P.Prk3 = PrK[i, j];
            //        }
            //        if (i == 3 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC3.Value / RMCSum;
            //            flag = 1;
            //            P.Prk3 = PrK[i, j];
            //        }
            //        if (i == 4 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC4.Value / RMCSum;
            //            flag = 1;
            //            P.Prk4 = PrK[i, j];
            //        }
            //        if (i == 5 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC6.Value / RMCSum;
            //            flag = 1;
            //            P.Prk6 = PrK[i, j];
            //        }
            //        if (i == 6 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC7.Value / RMCSum;
            //            flag = 1;
            //            P.Prk7 = PrK[i, j];
            //        }
            //        if (i == 7 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC8.Value / RMCSum;
            //            flag = 1;
            //            P.Prk8 = PrK[i, j];
            //        }
            //        if (i == 8 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC9.Value / RMCSum;
            //            flag = 1;
            //            P.Prk9 = PrK[i, j];
            //        }
            //        if (i == 9 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC10.Value / RMCSum;
            //            flag = 1;
            //            P.Prk10 = PrK[i, j];
            //        }
            //        if (i == 10 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC11.Value / RMCSum;
            //            flag = 1;
            //            P.Prk11 = PrK[i, j];
            //        }
            //        if (i == 11 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC12.Value / RMCSum;
            //            flag = 1;
            //            P.Prk12 = PrK[i, j];
            //        }
            //        if (i == 12 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC13.Value / RMCSum;
            //            flag = 1;
            //            P.Prk13 = PrK[i, j];
            //        }
            //        if (i == 13 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC14.Value / RMCSum;
            //            flag = 1;
            //            P.Prk14 = PrK[i, j];
            //        }
            //        if (i == 14 && j == 0 && flag == 0)
            //        {
            //            PrK[i, j] = RMC.RMC15.Value / RMCSum;
            //            flag = 1;
            //            P.Prk15 = PrK[i, j];
            //        }
                    
            //        //M[i, j] = int.Parse(Console.ReadLine());
            //    }


            //}
            //db.Prks.Attach(P);
            //db.Entry(P).State = EntityState.Modified;
            //db.SaveChanges();

            //db.Prks.Add(P);
            //db.SaveChanges();













            return Tuple.Create(Tou);
        }
    }
}
