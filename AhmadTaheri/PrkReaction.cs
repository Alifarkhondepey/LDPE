using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    class PrkReaction
    {
        AhmadTaheri.Model.PolymersMatrices db = new Model.PolymersMatrices();

        public int Pick(double r2, double RmcSum, double[,] Prk)
        {
            double[,] RMC = new double[15, 1];
            RmcSum = 0.0;
            int i, j;
            var Rmcs = db.RMCs.FirstOrDefault();

            var p = db.Prks.FirstOrDefault();
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Prk[i, j] = p.Prk1.Value;
                    }
                    if (i == 1 && j == 0)
                    {
                        Prk[i, j] = p.Prk2.Value;
                    }
                    if (i == 2 && j == 0)
                    {
                        Prk[i, j] = p.Prk3.Value;
                    }
                    if (i == 3 && j == 0)
                    {
                        Prk[i, j] = p.Prk4.Value;
                    }
                    if (i == 4 && j == 0)
                    {
                        Prk[i, j] = p.Prk5.Value;
                    }
                    if (i == 5 && j == 0)
                    {
                        Prk[i, j] = p.Prk6.Value;
                    }
                    if (i == 6 && j == 0)
                    {
                        Prk[i, j] = p.Prk7.Value;
                    }
                    if (i == 7 && j == 0)
                    {
                        Prk[i, j] = p.Prk8.Value;
                    }
                    if (i == 8 && j == 0)
                    {
                        Prk[i, j] = p.Prk9.Value;
                    }
                    if (i == 9 && j == 0)
                    {
                        Prk[i, j] = p.Prk10.Value;
                    }
                    if (i == 10 && j == 0)
                    {
                        Prk[i, j] = p.Prk11.Value;
                    }
                    if (i == 11 && j == 0)
                    {
                        Prk[i, j] = p.Prk12.Value;
                    }
                    if (i == 12 && j == 0)
                    {
                        Prk[i, j] = p.Prk13.Value;
                    }
                    if (i == 13 && j == 0)
                    {
                        Prk[i, j] = p.Prk14.Value;
                    }
                    if (i == 14 && j == 0)
                    {
                        Prk[i, j] = p.Prk15.Value;
                    }

                }
            }
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC1.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 1 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC2.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 2 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC3.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 3 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC4.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 4 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC5.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 5 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC6.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 6 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC7.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 7 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC8.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 8 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC9.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 9 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC10.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 10 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC11.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 11 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC12.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 12 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC13.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 13 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC14.Value;
                        RmcSum += RMC[i, j];
                    }
                    if (i == 14 && j == 0)
                    {
                        RMC[i, j] = Rmcs.RMC15.Value;
                        RmcSum += RMC[i, j];
                    }

                }
            }

            //jadid
            double[,] PrK = new double[15, 1];
            double Counter1;
            Counter1 = 0;
            double Counter2;
            Counter2 = 0;
            int ReactionNumber = 0;
            int reactcounter = 0;
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 1; j++)
                {

                    if (i == 0 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];

                        if (PrK[i, j] != 0) { reactcounter += 1; }

                    }
                    if (i == 1 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }

                    if (i == 2 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 3 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }

                    if (i == 4 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 5 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 6 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 7 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 8 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 9 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 10 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 11 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 12 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 13 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    if (i == 14 && j == 0)
                    {
                        PrK[i, j] = Prk[i, j];
                        if (PrK[i, j] != 0) { reactcounter += 1; }
                    }
                    //M[i, j] = int.Parse(Console.ReadLine());
                }

            }

            double counter3 = 0.0;
            Counter1 = 0.0;
            Counter2 = 0.0;
            var N = db.N.FirstOrDefault();

            //for (i = 0; i < 14; i++)
            //{
            //    for (j = 0; j < 1; j++)
            //    {

            //        Counter1 += PrK[i, j];
            //        counter3 = PrK[i + 1, j];
            //        Counter2 += PrK[i, j] + PrK[i + 1, j];
            //        if (r2 > Counter1 && r2 <= Counter2 && ReactionNumber == 0)
            //        {

            //            Console.WriteLine("Reaction N = ");
            //            Console.WriteLine(i + 2);
            //            ReactionNumber = i + 2;
            //            return ReactionNumber;

            //        }
            //        else if (r2 <= Counter1)
            //        {
            //            Console.WriteLine("Reaction N = ");
            //            Console.WriteLine(i + 1);
            //            ReactionNumber = i + 1;
            //            return ReactionNumber;

            //        }

            //    }
            //}

            if (r2>0 && r2<=p.Prk1.Value)
            {
                ReactionNumber = 1;
                return ReactionNumber;
            }
            else if(r2>p.Prk1.Value && r2<=(p.Prk1.Value+p.Prk2.Value))
            {
                ReactionNumber = 2;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value+p.Prk2.Value )&& r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value))
            {
                ReactionNumber = 3;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value) && r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value+p.Prk4.Value))
            {
                ReactionNumber = 4;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value) && r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value+p.Prk5.Value))
            {
                ReactionNumber = 5;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value+p.Prk5.Value) && r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value))
            {
                ReactionNumber = 6;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value) && r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value))
            {
                ReactionNumber = 7;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value+p.Prk7.Value) && r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value))
            {
                ReactionNumber = 8;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value) &&
                r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value+p.Prk9.Value))
            {
                ReactionNumber = 9;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value) &&
               r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value))
            {
                ReactionNumber = 10;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value) &&
              r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value + p.Prk11.Value))
            {
                ReactionNumber = 11;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value + p.Prk11.Value) &&
             r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value + p.Prk11.Value + p.Prk12.Value))
            {
                ReactionNumber = 12;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value + p.Prk11.Value + p.Prk12.Value) &&
            r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value + p.Prk11.Value + p.Prk12.Value + p.Prk13.Value))
            {
                ReactionNumber = 13;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value + p.Prk11.Value + p.Prk12.Value + p.Prk13.Value) &&
           r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value + p.Prk11.Value + p.Prk12.Value + p.Prk13.Value + p.Prk14.Value))
            {
                ReactionNumber = 14;
                return ReactionNumber;
            }
            else if (r2 > (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value + p.Prk11.Value + p.Prk12.Value + p.Prk13.Value + p.Prk14.Value) &&
          r2 <= (p.Prk1.Value + p.Prk2.Value + p.Prk3.Value + p.Prk4.Value + p.Prk5.Value + p.Prk6.Value + p.Prk7.Value + p.Prk8.Value + p.Prk9.Value + p.Prk10.Value + p.Prk11.Value + p.Prk12.Value + p.Prk13.Value + p.Prk14.Value + p.Prk15.Value))
            {
                ReactionNumber = 15;
                return ReactionNumber;
            }




            var RNum = db.ReactionNumbers.FirstOrDefault();
            Model.ReactionNumber n = new Model.ReactionNumber();
            n.ReactionNumber1 = ReactionNumber;
            if (RNum == null)
            {
                db.ReactionNumbers.Add(n);
                db.SaveChanges();
            }
            else
            {
                //db.ReactionNumbers.Attach(n);
                //db.Entry(n).State = EntityState.Modified;
                //db.SaveChanges();
            }
            return ReactionNumber;

        }

    }
}
