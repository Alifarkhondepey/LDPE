using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace AhmadTaheri
{
    class Program
    {
        static void Main(string[] args)
        {







            Random rnd = new Random();
            double Time = 0.0;

            const int MATRIX_ROWS = 13;
            const int MATRIX_COLUMNS = 1;
            double k = 6 * Math.Pow(10, 8);
            double NIA = 0.0;
            double NIC = 0.0;
            double NIS = 0.0;
            double NM = 0.0;
            double NCTA = 0.0;
            double[,] M = new double[MATRIX_ROWS, MATRIX_COLUMNS];
            double[,] c = new double[MATRIX_ROWS, MATRIX_COLUMNS];
            double[,] N = new double[MATRIX_ROWS, MATRIX_COLUMNS];


            double NR = 0.0;
            double NP = 0.0;
            double NPtert = 0.0;
            double NPsec = 0.0;
            double NDprime = 0.0;
            double ND = 0.0;
            double NLcb = 0.0;
            double NScb = 0.0;
            //lal original
            double Dla1;
            Console.WriteLine("Dla1 :");

            Dla1 = double.Parse(Console.ReadLine());

            double Ttotal;
            Console.WriteLine("T total (Houre):");

            Ttotal = double.Parse(Console.ReadLine());

            double Ma;

            Console.WriteLine("First Ma :");

            Ma = double.Parse(Console.ReadLine());


            double La1 = Dla1 * Ttotal;


            var Lalorginal = La1 * 1000 / Ma;

            Console.WriteLine("[La1] = ");
            Console.WriteLine(Lalorginal);

            //lal original closed

            //lcl original
            double Dlc1;
            Console.WriteLine("Dlc1 :");

            Dlc1 = double.Parse(Console.ReadLine());


            double lc1 = Dlc1 * Ttotal;

            double Mc;
            Console.WriteLine("Mc :");

            Mc = double.Parse(Console.ReadLine());



            double lc1Original = lc1 * 1000 / Mc;

            //lcl original closed

            //lsl

            double Dls1;
            Console.WriteLine("Dls1 :");

            Dls1 = double.Parse(Console.ReadLine());


            double ls1 = Dls1 * Ttotal;

            double Ms;
            Console.WriteLine("Ms :");

            Ms = double.Parse(Console.ReadLine());



            double ls1Original = ls1 * 1000 / Ms;



            //lsl closed
            //

            double la2Original;
            double la2;

            Console.WriteLine("Dla2 : ");
            double Dla2 = double.Parse(Console.ReadLine());

            la2 = Dla2 * Ttotal;
            la2Original = (la2 * 1000) / Ma;

            double lc2Original;
            double lc2;

            Console.WriteLine("Dlc2 : ");
            double Dlc2 = double.Parse(Console.ReadLine());

            lc2 = Dlc2 * Ttotal;
            lc2Original = (lc2 * 1000) / Ma;


            double la3Original;
            double la3;

            Console.WriteLine("Dla3 : ");
            double Dla3 = double.Parse(Console.ReadLine());

            la3 = Dla3 * Ttotal;
            la3Original = (la3 * 1000) / Ma;

            double la4Original;
            double la4;

            Console.WriteLine("Dla4 : ");
            double Dla4 = double.Parse(Console.ReadLine());

            la4 = Dla4 * Ttotal;
            la4Original = (la4 * 1000) / Ma;


            //
            //M


            double Dm;
            Console.WriteLine("Dm :");

            Dm = double.Parse(Console.ReadLine());


            double m = Dm * Ttotal;

            double Mm;
            Console.WriteLine("Mm :");

            Mm = double.Parse(Console.ReadLine());



            double MOriginal = m * 1000 / Mm;





            //M closed

            //CTA

            double Dcta;
            Console.WriteLine("Dcta :");

            Dcta = double.Parse(Console.ReadLine());


            double CTA = Dcta * Ttotal;
            double Mcta;
            Console.WriteLine("Mcta :");
            Mcta = double.Parse(Console.ReadLine());
            double CTAOriginal = CTA * 1000 / Mcta;
            double P0;//tekrar
            Console.WriteLine("P0 :");
            P0 = double.Parse(Console.ReadLine());

            double Vs;
            double L1 = 0.0;
            double D1 = 0.0;

            Console.WriteLine("L1 :");

            L1 = double.Parse(Console.ReadLine());
            Console.WriteLine("D1 :");

            D1 = double.Parse(Console.ReadLine());

            Vs = 0.785 * Math.Pow(D1, 2) * L1;


            //CTA closed
            double p1 = P0;
            double p2;
            double p3;
            double p4;
            double v1 = Vs;
            //l jadi
            // Vs = 0.785 * Math.Pow(D1, 2) * L1;
            double L2 = 0.0;
            double L3 = 0.0;
            double L4 = 0.0;
            Console.WriteLine("L2 : ");
            L2 = double.Parse(Console.ReadLine());
            Console.WriteLine("L3 : ");
            L3 = double.Parse(Console.ReadLine());
            Console.WriteLine("L4 : ");
            L4 = double.Parse(Console.ReadLine());

            double v2 = 0.785 * Math.Pow(D1, 2) * L2;
            double v3 = 0.785 * Math.Pow(D1, 2) * L3;
            double v4 = 0.785 * Math.Pow(D1, 2) * L4;
            Console.WriteLine("P2 : ");
            p2 = double.Parse(Console.ReadLine());

            Console.WriteLine("P3 : ");
            p3 = double.Parse(Console.ReadLine());

            Console.WriteLine("P4 : ");
            p4 = double.Parse(Console.ReadLine());







            #region Test
            //Tuple<double, double, double, double, int,string> ReactionCalculatestest = new Tuple<double, double, double, double, int,string>(0.0, 0.0, 0.0, 0.0, 0,"");
            //ReactionCalculates rctest = new ReactionCalculates();

            //Reactions rtest = new Reactions();
            //int? Idtest = 0;
            //string IdentityNametest = null;
            ////ReactionCalculatestest = rctest.ReactCal();
            //IdentityNametest= ReactionCalculatestest.Item6 ;

            //ReactionCalculatestest = rctest.ReactCal(5, NIA, NR, NIC, NIS, NM, NP, NPsec, NPtert, ND, NLcb, NScb, NDprime, Idtest.Value, IdentityNametest);


            #endregion














            int i, j, flag;
            //Matrix M
            for (i = 0; i < MATRIX_ROWS; i++)
            {
                for (j = 0; j < MATRIX_COLUMNS; j++)
                {
                    flag = 0;
                    if (i == 0 && j == 0 && flag == 0)
                    {
                        M[i, j] = Lalorginal;
                        flag = +1;
                    }
                    if (i == 1 && j == 0 && flag == 0)
                    {
                        M[i, j] = lc1Original;
                        flag = +1;
                    }
                    if (i == 2 && j == 0 && flag == 0)
                    {
                        M[i, j] = ls1Original;
                        flag = +1;
                    }
                    if (i == 3 && j == 0 && flag == 0)
                    {
                        M[i, j] = MOriginal;
                        flag = +1;
                    }
                    if (i == 5 && j == 0 && flag == 0)
                    {
                        M[i, j] = CTAOriginal;
                        flag = +1;
                    }
                    else if (flag == 0)
                    {
                        M[i, j] = 0;
                    }
                    //M[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.Write("Matrix M : ");


            for (i = 0; i < M.GetLength(0); i++)
            {

                for (j = 0; j < M.GetLength(1); j++)

                    Console.Write(M[i, j] + "\t");

                Console.WriteLine();

            }


            //Matrix N

            for (i = 0; i < M.GetLength(0); i++)
            {

                for (j = 0; j < M.GetLength(1); j++)
                {

                    N[i, j] = M[i, j] * k;

                    if (i == 0 && j == 0)
                    {
                        NIA = N[i, j];
                    }
                    if (i == 1 && j == 0)
                    {
                        NIC = N[i, j];
                    }
                    if (i == 2 && j == 0)
                    {
                        NIS = N[i, j];
                    }
                    if (i == 3 && j == 0)
                    {
                        NM = N[i, j];
                    }
                    if (i == 5 && j == 0)
                    {
                        NCTA = N[i, j];
                    }

                }

            }
            AhmadTaheri.Model.PolymersMatrices db = new Model.PolymersMatrices();
            Model.N MatN = new Model.N()
            {
                NIA = NIA,
                NIC = NIC,
                 NIS = NIS,
                  NM = NM,
                   NCTA = NCTA,
                    ND = ND,
                     NDprime = NDprime,
                      NLCB = NLcb,
                       NPsec = NPsec,
                        NP = NP,
                          NPtert = NPtert,
                           NR = NR,
                            NSCB = NScb
            };
            db.N.Add(MatN);
            db.SaveChanges();

            
           

            double r1 = rnd.NextDouble();//tekrar
                                         //double Rmc;

            //Kmc

            double r2 = rnd.NextDouble();

            CalCulateTou tou = new CalCulateTou();
            var Tou = tou.Cal(r1, P0, Vs, NIA, NIC, NIS, r2);

            var RmcSum0 = Tou.Item5;


            Console.WriteLine("Tou : ");


            Console.WriteLine(Tou);

            double Temperature = +273;
            Time = Tou.Item1 + Time;
            double[,] Kexp = new double[15, 1];
            double[,] Kmc = new double[15, 1];
            double[,] RmcMatrix = new double[15, 1];
            double[,] Prk = new double[15, 1];



            Kexp = Tou.Item2;
            Kmc = Tou.Item3;
            RmcMatrix = Tou.Item4;



            Reactors react = new Reactors();

            var R = react.reactors(N, Time, Temperature, MATRIX_ROWS, MATRIX_COLUMNS, la2Original, lc2Original, la3Original, la4Original);
            Temperature += R.Item1;

            //R2 and Call Action
            //if 
            while (Time != Ttotal)
            {
                try
                {
                    double r22 = rnd.NextDouble();



                    double[,] PrK = new double[15, 1];
                    PrK = Tou.Item7;
                    Tuple<double, double, double> ReactionRes = new Tuple<double, double, double>(0.0, 0.0, 0.0);

                    int ReactionNumber = 0;
                    if (Tou.Item6 != 0)
                    {
                        ReactionNumber = Tou.Item6;
                    }

                    ReactionCalculates rc = new ReactionCalculates();
                    CalCulateTou2 CT2 = new CalCulateTou2();
                    double r11 = rnd.NextDouble();//tekrar
                    var TOU = CT2.Cal(r11);
                    var np = db.N.FirstOrDefault();
                   if(np.NP.Value == 10)
                    {

                    }
                    Tuple<double,int,double[,] > R2 = new Tuple<double, int, double[,]>(0.0, 0, null);

                    try
                    {

                    Time += TOU.Item1;
                             R2 = react.reactors(N, Time, Temperature, MATRIX_ROWS, MATRIX_COLUMNS, la2Original, lc2Original, la3Original, la4Original);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }
                    try
                    {
                        PrkReaction Preaction = new PrkReaction();
                        ReactionNumber = Preaction.Pick(r22, RmcSum0, PrK);
                        if (ReactionNumber != 0)
                        {
                            //Console.WriteLine("Reaction N = ");
                            //Console.WriteLine(ReactionNumber);

                            Reactions r = new Reactions();
                            ReactionRes = r.RNum(ReactionNumber);
                            //Tuple<double, double,double, double,int,string> ReactionCalculates = new Tuple<double, double,double,double,int,string>(0.0, 0.0,0.0,0.0,0,"");
                            // int? Id = 0;
                            // string IdentityName = null;
                            //Reaction Call
                            rc.ReactCal(ReactionNumber);


                            Console.WriteLine("K : ");
                            Console.WriteLine(ReactionRes.Item1);
                            Console.WriteLine("E : ");
                            Console.WriteLine(ReactionRes.Item2);
                            Console.WriteLine("DeltaV : ");
                            Console.WriteLine(ReactionRes.Item3);
                        }

                    }
                    catch (Exception E)
                    {

                        Console.WriteLine(E.Message);

                    }
                    //Kexp 
                    Kexp kp = new Kexp();
                    Tuple<double, int> res = null;
                    if (R.Item2 == 1)
                    {
                        res = kp.kexp(ReactionRes.Item1, ReactionRes.Item2, ReactionRes.Item3, ReactionNumber, p1, R2.Item1);
                    }
                    if (R.Item2 == 2)
                    {
                        res = kp.kexp(ReactionRes.Item1, ReactionRes.Item2, ReactionRes.Item3, ReactionNumber, p2, R2.Item1);

                    }
                    if (R.Item2 == 3)
                    {
                        res = kp.kexp(ReactionRes.Item1, ReactionRes.Item2, ReactionRes.Item3, ReactionNumber, p3, R2.Item1);

                    }
                    if (R.Item2 == 4)
                    {
                        res = kp.kexp(ReactionRes.Item1, ReactionRes.Item2, ReactionRes.Item3, ReactionNumber, p4, R2.Item1);

                    }

                    //add to matrix Kexp
                    if (res != null)
                    {
                        var NullCheck = true;
                        foreach (var item in Kexp)
                        {
                            if (item != 0)
                            {
                                NullCheck = false;
                            }

                        }
                        if (NullCheck == true)
                        {
                            for (i = 0; i < 15; i++)
                            {
                                for (j = 0; j < 1; j++)
                                {

                                    if (i == 0 && j == 0 && res.Item2 == 1)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 1 && j == 0 && res.Item2 == 2)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }

                                    if (i == 2 && j == 0 && res.Item2 == 3)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 3 && j == 0 && res.Item2 == 4)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }

                                    if (i == 4 && j == 0 && res.Item2 == 5)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 5 && j == 0 && res.Item2 == 6)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 6 && j == 0 && res.Item2 == 7)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 7 && j == 0 && res.Item2 == 8)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 8 && j == 0 && res.Item2 == 9)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 9 && j == 0 && res.Item2 == 10)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 10 && j == 0 && res.Item2 == 11)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 11 && j == 0 && res.Item2 == 12)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 12 && j == 0 && res.Item2 == 13)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 13 && j == 0 && res.Item2 == 14)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    if (i == 14 && j == 0 && res.Item2 == 15)
                                    {
                                        Kexp[i, j] = res.Item1;

                                    }
                                    //M[i, j] = int.Parse(Console.ReadLine());
                                }

                            }
                        }
                    }

                    //Console.WriteLine("Kexp Matrix :");
                    //for (i = 0; i < Kexp.GetLength(0); i++)
                    //{

                    //    for (j = 0; j < Kexp.GetLength(1); j++)

                    //        Console.Write(Kexp[i, j] + "\t");

                    //    Console.WriteLine();

                    //}
                    //Console.WriteLine("Kexp : ");
                    //Console.WriteLine(res.Item1);


                    Kmc kmc = new Kmc();

                    Tuple<double, int> resKmc = null;
                    if (R.Item2 == 1)
                    {
                        resKmc = kmc.kmc(res.Item1, v1, ReactionNumber);
                        Console.WriteLine("Reactor 1 Kmc :");
                        Console.WriteLine(resKmc);

                    }
                    if (R.Item2 == 2)
                    {
                        resKmc = kmc.kmc(res.Item1, v2, ReactionNumber);
                        Console.WriteLine("Reactor 2 Kmc :");
                        Console.WriteLine(resKmc);
                    }
                    if (R.Item2 == 3)
                    {
                        resKmc = kmc.kmc(res.Item1, v3, ReactionNumber);
                        Console.WriteLine("Reactor 3 Kmc :");
                        Console.WriteLine(resKmc);
                    }
                    if (R.Item2 == 4)
                    {
                        resKmc = kmc.kmc(res.Item1, v4, ReactionNumber);
                        Console.WriteLine("Reactor 4 Kmc :");
                        Console.WriteLine(resKmc);
                    }
                    //add kmc to matrix
                    if (resKmc != null)
                    {
                        var NullCheck = true;
                        foreach (var item in Kmc)
                        {
                            if (item != 0)
                            {
                                NullCheck = false;
                            }

                        }
                        if (NullCheck == true)
                        {
                            for (i = 0; i < 15; i++)
                            {
                                for (j = 0; j < 1; j++)
                                {

                                    if (i == 0 && j == 0 && resKmc.Item2 == 1)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 1 && j == 0 && resKmc.Item2 == 2)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }

                                    if (i == 2 && j == 0 && resKmc.Item2 == 3)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 3 && j == 0 && resKmc.Item2 == 4)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }

                                    if (i == 4 && j == 0 && resKmc.Item2 == 5)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 5 && j == 0 && resKmc.Item2 == 6)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 6 && j == 0 && resKmc.Item2 == 7)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 7 && j == 0 && resKmc.Item2 == 8)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 8 && j == 0 && resKmc.Item2 == 9)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 9 && j == 0 && resKmc.Item2 == 10)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 10 && j == 0 && resKmc.Item2 == 11)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 11 && j == 0 && resKmc.Item2 == 12)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 12 && j == 0 && resKmc.Item2 == 13)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 13 && j == 0 && resKmc.Item2 == 14)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    if (i == 14 && j == 0 && resKmc.Item2 == 15)
                                    {
                                        Kmc[i, j] = resKmc.Item1;

                                    }
                                    //M[i, j] = int.Parse(Console.ReadLine());
                                }

                            }
                        }
                    }
                    Console.WriteLine("Kmc Matrix :");
                    for (i = 0; i < Kmc.GetLength(0); i++)
                    {

                        for (j = 0; j < Kmc.GetLength(1); j++)

                            Console.Write(Kmc[i, j] + "\t");

                        Console.WriteLine();

                    }


                    //RMC


                    Rmc rmc = new Rmc();

                    Tuple<double, int, double> resRmc = null;
                    if (R.Item2 == 1)
                    {
                        resRmc = rmc.rmc(resKmc.Item1, ReactionNumber, NDprime, NCTA, NIA, NIC, NIS, NP, NPtert, NPsec, NM, NR);
                        Console.WriteLine("Reactor 1 Rmc :");
                        Console.WriteLine(resRmc.Item1);

                    }
                    if (R.Item2 == 2)
                    {
                        resRmc = rmc.rmc(resKmc.Item1, ReactionNumber, NDprime, NCTA, NIA, NIC, NIS, NP, NPtert, NPsec, NM, NR);
                        Console.WriteLine("Reactor 2 Rmc :");
                        Console.WriteLine(resRmc.Item1);
                    }
                    if (R.Item2 == 3)
                    {
                        resRmc = rmc.rmc(resKmc.Item1, ReactionNumber, NDprime, NCTA, NIA, NIC, NIS, NP, NPtert, NPsec, NM, NR);
                        Console.WriteLine("Reactor 3 Rmc :");
                        Console.WriteLine(resRmc.Item1);
                    }
                    if (R.Item2 == 4)
                    {
                        resRmc = rmc.rmc(resKmc.Item1, ReactionNumber, NDprime, NCTA, NIA, NIC, NIS, NP, NPtert, NPsec, NM, NR);
                        Console.WriteLine("Reactor 4 Rmc :");
                        Console.WriteLine(resRmc.Item1);
                    }

                    //add RMC to matrix
                    if (resRmc != null)
                    {
                        var NullCheck = true;

                        if (NullCheck == true)
                        {
                            for (i = 0; i < 15; i++)
                            {
                                for (j = 0; j < 1; j++)
                                {

                                    if (i == 0 && j == 0 && resRmc.Item2 == 1)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 1 && j == 0 && resRmc.Item2 == 2)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }

                                    if (i == 2 && j == 0 && resRmc.Item2 == 3)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 3 && j == 0 && resRmc.Item2 == 4)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }

                                    if (i == 4 && j == 0 && resRmc.Item2 == 5)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 5 && j == 0 && resRmc.Item2 == 6)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 6 && j == 0 && resRmc.Item2 == 7)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 7 && j == 0 && resRmc.Item2 == 8)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 8 && j == 0 && resRmc.Item2 == 9)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 9 && j == 0 && resRmc.Item2 == 10)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 10 && j == 0 && resRmc.Item2 == 11)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 11 && j == 0 && resRmc.Item2 == 12)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 12 && j == 0 && resRmc.Item2 == 13)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 13 && j == 0 && resRmc.Item2 == 14)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    if (i == 14 && j == 0 && resRmc.Item2 == 15)
                                    {
                                        RmcMatrix[i, j] = resRmc.Item1;

                                    }
                                    //M[i, j] = int.Parse(Console.ReadLine());
                                }

                            }
                        }
                    }
                    Console.WriteLine("Rmc Matrix :");
                    for (i = 0; i < RmcMatrix.GetLength(0); i++)
                    {

                        for (j = 0; j < RmcMatrix.GetLength(1); j++)

                            Console.Write(RmcMatrix[i, j] + "\t");

                        Console.WriteLine();

                    }

                    //PRK


                    Prk prk = new Prk();

                    Tuple<double, int> resPrk = null;

                    resPrk = prk.prk(ReactionNumber);
                    Console.WriteLine("Reactor 1 prk :");
                    Console.WriteLine(resPrk.Item1);



                    //add prk to matrix
                    if (resPrk != null)
                    {
                        var NullCheck = true;


                        if (NullCheck == true)
                        {
                            for (i = 0; i < 15; i++)
                            {
                                for (j = 0; j < 1; j++)
                                {

                                    if (i == 0 && j == 0 && resPrk.Item2 == 1)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 1 && j == 0 && resPrk.Item2 == 2)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }

                                    if (i == 2 && j == 0 && resPrk.Item2 == 3)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 3 && j == 0 && resPrk.Item2 == 4)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }

                                    if (i == 4 && j == 0 && resPrk.Item2 == 5)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 5 && j == 0 && resPrk.Item2 == 6)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 6 && j == 0 && resPrk.Item2 == 7)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 7 && j == 0 && resPrk.Item2 == 8)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 8 && j == 0 && resPrk.Item2 == 9)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 9 && j == 0 && resPrk.Item2 == 10)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 10 && j == 0 && resPrk.Item2 == 11)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 11 && j == 0 && resPrk.Item2 == 12)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 12 && j == 0 && resPrk.Item2 == 13)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 13 && j == 0 && resPrk.Item2 == 14)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    if (i == 14 && j == 0 && resPrk.Item2 == 15)
                                    {
                                        PrK[i, j] = resPrk.Item1;

                                    }
                                    //M[i, j] = int.Parse(Console.ReadLine());
                                }

                            }
                        }
                    }
                    Console.WriteLine("prk Matrix :");
                    for (i = 0; i < PrK.GetLength(0); i++)
                    {

                        for (j = 0; j < PrK.GetLength(1); j++)

                            Console.Write(PrK[i, j] + "\t");

                        Console.WriteLine();

                    }

                }
                catch (Exception)
                {

                    throw;
                }



           

            }
        }
    }
}
