using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    class CalCulateTou
    {
        AhmadTaheri.Model.PolymersMatrices db = new Model.PolymersMatrices();

        public Tuple<double, double[,], double[,], double[,], double, int, double[,]> Cal(double r1, double P0, double Vs, double NIA, double NIC, double NIS, double r2)
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


            // Kexp1
            double Kexp1 = k01 * (Math.Pow(e, -((E1 + (P0 * DeltaV1)) / (R * T0))));

            // Kexp2
            double Kexp2 = k02 * (Math.Pow(e, -((E2 + (P0 * DeltaV2)) / (R * T0))));

            // Kexp3
            double Kexp3 = k03 * (Math.Pow(e, -(E3) / (R * T0)));


            // Kexp4
            double Kexp4 = k04 * Math.Pow(e, -((E4 + (P0 * DeltaV4)) / (R * T0)));

            // Kexp5
            double Kexp5 = k05 * Math.Pow(e, -((E5 + (P0 * DeltaV5)) / (R * T0)));

            // Kexp6
            double Kexp6 = k06 * Math.Pow(e, -((E6 + (P0 * DeltaV6)) / (R * T0)));

            // Kexp7
            double Kexp7 = k07 * Math.Pow(e, -((E7 + (P0 * DeltaV7)) / (R * T0)));

            // Kexp8
            double Kexp8 = k08 * Math.Pow(e, -((E8 + (P0 * DeltaV8)) / (R * T0)));

            // Kexp9
            double Kexp9 = k09 * Math.Pow(e, -((E9 + (P0 * DeltaV9)) / (R * T0)));

            // Kexp10
            double Kexp10 = k10 * Math.Pow(e, -((E10 + (P0 * DeltaV10)) / (R * T0)));

            // Kexp11
            double Kexp11 = k11 * Math.Pow(e, -((E11 + (P0 * DeltaV11)) / (R * T0)));

            // Kexp12
            double Kexp12 = k12 * Math.Pow(e, -((E12 + (P0 * DeltaV12)) / (R * T0)));

            // Kexp13
            double Kexp13 = k13 * Math.Pow(e, -((E13 + (P0 * DeltaV13)) / (R * T0)));

            // Kexp14
            double Kexp14 = k14 * Math.Pow(e, -((E14 + (P0 * DeltaV14)) / (R * T0)));

            // Kexp15
            double Kexp15 = k15 * Math.Pow(e, -((E15 + (P0 * DeltaV15)) / (R * T0)));

            AhmadTaheri.Model.Kexp K = new Model.Kexp()
            {
                Kexp1 = Kexp1,
                Kexp2 = Kexp2,
                Kexp3 = Kexp3,
                Kexp4 = Kexp4,
                Kexp5 = Kexp5,
                Kexp6 = Kexp6,
                Kexp7 = Kexp7,
                Kexp8 = Kexp8,
                Kexp9 = Kexp9,
                Kexp10 = Kexp10,
                Kexp11 = Kexp11,
                Kexp12 = Kexp12,
                Kexp13 = Kexp13,
                Kexp14 = Kexp14,
                Kexp15 = Kexp15,
            };
            db.Kexps.Add(K);
            db.SaveChanges();

            //matrix Kexp
            for (i = 0; i <= 14; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    flag = 0;
                    if (i == 0 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp1;
                        flag += 1;

                    }
                    flag = 0;
                    if (i == 1 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp2;
                        flag += 1;

                    }
                    if (i == 2 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp3;
                        flag += 1;

                    }
                    if (i == 3 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp4;
                        flag += 1;

                    }
                    if (i == 4 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp5;
                        flag += 1;

                    }
                    if (i == 5 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp6;
                        flag += 1;

                    }
                    if (i == 6 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp7;
                        flag += 1;

                    }
                    if (i == 7 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp8;
                        flag += 1;

                    }
                    if (i == 8 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp9;
                        flag += 1;

                    }
                    if (i == 9 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp10;
                        flag += 1;

                    }
                    if (i == 10 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp11;
                        flag += 1;

                    }
                    if (i == 11 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp12;
                        flag += 1;

                    }
                    if (i == 12 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp13;
                        flag += 1;

                    }
                    if (i == 13 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp14;
                        flag += 1;

                    }
                    if (i == 14 && j == 0 && flag == 0)
                    {
                        KexpMatrix[i, j] = Kexp15;
                        flag += 1;

                    }


                }

            }












            double NAV = 6 * Math.Pow(10, 8);

            double KMC1 = Kexp1;

            double KMC2 = Kexp2;

            double KMC3 = Kexp3;

            double KMC4 = Kexp4 / (NAV * Vs);

            double KMC5 = Kexp5 / (NAV * Vs);

            double KMC6 = Kexp6 / (NAV * Vs);

            double KMC7 = Kexp7 / (NAV * Vs);

            double KMC8 = Kexp8 / (NAV * Vs);

            double KMC9 = Kexp9 / (NAV * Vs);

            double KMC10 = Kexp10 / (NAV * Vs);

            double KMC11 = Kexp11;

            double KMC12 = Kexp12;

            double KMC13 = Kexp13;

            double KMC14 = 2 * Kexp14 / (NAV * Vs);

            double KMC15 = 2 * Kexp15 / (NAV * Vs);



            AhmadTaheri.Model.KMC Km = new Model.KMC()
            {
                KMC1 = KMC1,
                KMC2 = KMC2,
                KMC3 = KMC3,
                KMC4 = KMC4,
                KMC5 = KMC5,
                KMC6 = KMC6,
                KMC7 = KMC7,
                KMC8 = KMC8,
                KMC9 = KMC9,
                KMC10 = KMC10,
                KMC11 = KMC11,
                KMC12 = KMC12,
                KMC13 = KMC13,
                KMC14 = KMC14,
                KMC15 = KMC15,
            };
            db.KMCs.Add(Km);
            db.SaveChanges();





            //matrix kmc
            for (i = 0; i <= 14; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    flag = 0;
                    if (i == 0 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC1;
                        flag += 1;

                    }
                    flag = 0;
                    if (i == 1 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC2;
                        flag += 1;

                    }
                    if (i == 2 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC3;
                        flag += 1;

                    }
                    if (i == 3 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC4;
                        flag += 1;

                    }
                    if (i == 4 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC5;
                        flag += 1;

                    }
                    if (i == 5 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC6;
                        flag += 1;

                    }
                    if (i == 6 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC7;
                        flag += 1;

                    }
                    if (i == 7 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC8;
                        flag += 1;

                    }
                    if (i == 8 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC9;
                        flag += 1;

                    }
                    if (i == 9 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC10;
                        flag += 1;

                    }
                    if (i == 10 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC11;
                        flag += 1;

                    }
                    if (i == 11 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC12;
                        flag += 1;

                    }
                    if (i == 12 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC13;
                        flag += 1;

                    }
                    if (i == 13 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC14;
                        flag += 1;

                    }
                    if (i == 14 && j == 0 && flag == 0)
                    {
                        KMCMatrix[i, j] = KMC15;
                        flag += 1;

                    }


                }

            }











            //RMC

            double RMC1 = KMC1 * NIA;
            double RMC2 = KMC2 * NIC;
            double RMC3 = KMC3 * NIS;
            AhmadTaheri.Model.RMC RR = new Model.RMC()
            {
                RMC1 = RMC1,
                RMC2 = RMC2,
                RMC3 = RMC3,
                RMC4 = 0,
                RMC5 = 0,
                RMC6 = 0,
                RMC7 = 0,
                RMC8 = 0,
                RMC9 = 0,
                RMC10 =0,
                RMC11 =0,
                RMC12 =0,
                RMC13 =0,
                RMC14 =0,
                RMC15 =0,
            };
            db.RMCs.Add(RR);
            db.SaveChanges();

            for (i = 0; i <= 14; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    flag = 0;
                    if (i == 0 && j == 0 && flag == 0)
                    {
                        RMCMatrix[i, j] = RMC1;
                        flag += 1;

                    }
                    if (i == 1 && j == 0 && flag == 0)
                    {
                        RMCMatrix[i, j] = RMC2;
                        flag += 1;
                    }

                    if (i == 2 && j == 0 && flag == 0)
                    {
                        RMCMatrix[i, j] = RMC3;
                        flag += 1;
                    }
                    else if (flag == 0)
                    {
                        RMCMatrix[i, j] = 0;
                        flag += 1;
                    }
                    //M[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.Write("Matrix RMC : ");


            for (i = 0; i < RMCMatrix.GetLength(0); i++)
            {

                for (j = 0; j < RMCMatrix.GetLength(1); j++)

                    Console.Write(RMCMatrix[i, j] + "\t");

                Console.WriteLine();

            }

            double RMC = RMC1 + RMC2 + RMC3;
            Console.WriteLine("RMC : ");

            Console.WriteLine(RMC);
            var Tou = (1 / RMC) * Math.Log(1 / r1);



            //PRK


            double[,] PrK = new double[15, 1];
            double Counter1;
            Counter1 = 0;
            double Counter2;
            Counter2 = 0;

            Model.Prk P = new Model.Prk();
            int ReactionNumber = 0;
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    flag = 0;
                    if (i == 0 && j == 0 && flag == 0)
                    {
                        PrK[i, j] = RMC1 / RMC;
                        flag = 1;
                        P.Prk1 = PrK[i, j];
                    }
                    if (i == 1 && j == 0 && flag == 0)
                    {
                        PrK[i, j] = RMC2 / RMC;
                        flag = 1;
                        P.Prk2 = PrK[i, j];
                    }

                    if (i == 2 && j == 0 && flag == 0)
                    {
                        PrK[i, j] = RMC3 / RMC;
                        flag = 1;
                        P.Prk3 = PrK[i, j];
                    }
                    else if (flag == 0)
                    {
                        PrK[i, j] = 0;
                        P.Prk4 = 0;
                        P.Prk5 = 0;
                        P.Prk6 = 0;
                        P.Prk7 = 0;
                        P.Prk8 = 0;
                        P.Prk9 = 0;
                        P.Prk10 = 0;
                        P.Prk11 = 0;
                        P.Prk12 = 0;
                        P.Prk13 = 0;
                        P.Prk14 = 0;
                        P.Prk15 = 0;

                    }
                    //M[i, j] = int.Parse(Console.ReadLine());
                }


            }
            db.Prks.Add(P);
            db.SaveChanges();
            for (i = 0; i < 14; i++)
            {
                double counter3;
                for (j = 0; j < 1; j++)
                {

                    Counter1 += PrK[i, j];
                    counter3 = PrK[i + 1, j];
                    Counter2 += PrK[i, j] + PrK[i + 1, j];
                    if (r2 > 0 && r2 <= Counter1)
                    {

                        return Tuple.Create(Tou, KexpMatrix, KMCMatrix, RMCMatrix, RMC, 1, PrK);

                    }
                    else if (r2 > Counter1 && r2 <= Counter2)
                    {
                        return Tuple.Create(Tou, KexpMatrix, KMCMatrix, RMCMatrix, RMC, 2, PrK);

                    }
                    else
                    {
                        return Tuple.Create(Tou, KexpMatrix, KMCMatrix, RMCMatrix, RMC, 3, PrK);

                    }
                    //if(r2==1)
                    //{
                    //    return Tuple.Create(Tou, KexpMatrix, KMCMatrix, RMCMatrix, RMC, 3, PrK);
                    //}
                    //if (counter3==0)
                    //{
                    //    Console.WriteLine("Reaction N = ");
                    //    Console.WriteLine(i + 1);
                    //    ReactionNumber = i + 1;
                    //    return Tuple.Create(Tou, KexpMatrix, KMCMatrix, RMCMatrix, RMC, ReactionNumber, PrK);

                    //}
                    //else if (r2 > Counter1 && r2 < Counter2 && ReactionNumber == 0)
                    //{

                    //    Console.WriteLine("Reaction N = ");
                    //    Console.WriteLine(i + 1);
                    //    ReactionNumber = i + 1;
                    //    return Tuple.Create(Tou, KexpMatrix, KMCMatrix, RMCMatrix, RMC, ReactionNumber, PrK);

                    //}

                }
            }













            return Tuple.Create(Tou, KexpMatrix, KMCMatrix, RMCMatrix, RMC, ReactionNumber, PrK);
        }
    }
}
