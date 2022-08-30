using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    //Type all Returns
    class ReactionCalculates
    {
        //Update All N
        AhmadTaheri.Model.PolymersMatrices db = new Model.PolymersMatrices();
        public void ReactCal(int Num)
        {

            var IdentityNoP = 0;
            if (db.P.Count() != 0)
            {
                IdentityNoP = db.P.OrderByDescending(x => x.IdentityNo).FirstOrDefault().IdentityNo;
                var count = db.P.Count() + 1;
                var P = db.P.OrderByDescending(x => x.IdentityNo).ToList();
                for (int i = 0; i <= P.Count(); i++)
                {
                    if (i + 1 < P.Count())
                    {
                        var p = P[i];
                        var p1 = P[i + 1];
                        var Mines = p.IdentityNo - p1.IdentityNo;
                        if ((Mines) > 1)
                        {
                            p.IdentityNo = p.IdentityNo - (Mines - 1);
                            db.P.Attach(p);
                            db.Entry(p).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                }
            }

            var IdentityNoPsec = 0;
            if (db.Psecs.Count() != 0)
            {
                IdentityNoPsec = db.Psecs.OrderByDescending(x => x.IdentityNo).FirstOrDefault().IdentityNo;
                var P = db.Psecs.OrderByDescending(x => x.IdentityNo).ToList();

                for (int i = 0; i <= P.Count(); i++)
                {
                    if (i + 1 < P.Count())
                    {
                        var p = P[i];
                        var p1 = P[i + 1];
                        var Mines = p.IdentityNo - p1.IdentityNo;
                        if ((Mines) > 1)
                        {
                            p.IdentityNo = p.IdentityNo - (Mines - 1);
                            db.Psecs.Attach(p1);
                            db.Entry(p1).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                }
            }

            var IdentityNoPtert = 0;
            if (db.Pterts.Count() != 0)
            {

                IdentityNoPtert = db.Pterts.OrderByDescending(x => x.IdentityNo).FirstOrDefault().IdentityNo;
                var P = db.Pterts.OrderByDescending(x => x.IdentityNo).ToList();

                for (int i = 0; i <= P.Count(); i++)
                {
                    if (i + 1 < P.Count())
                    {
                        var p = P[i];
                        var p1 = P[i + 1];
                        var Mines = p.IdentityNo - p1.IdentityNo;
                        if ((Mines) > 1)
                        {
                            p.IdentityNo = p.IdentityNo - (Mines - 1);
                            db.Pterts.Attach(p1);
                            db.Entry(p1).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                }
            }

            var IdentityNoD = 0;
            if (db.D.Count() != 0)
            {
                IdentityNoD = db.D.OrderByDescending(x => x.IdentityNo).FirstOrDefault().IdentityNo;
                var P = db.D.OrderByDescending(x => x.IdentityNo).ToList();

                for (int i = 0; i <= P.Count(); i++)
                {
                    if (i + 1 < P.Count())
                    {
                        var p = P[i];
                        var p1 = P[i + 1];
                        var Mines = p.IdentityNo - p1.IdentityNo;
                        if ((Mines) > 1)
                        {
                            p.IdentityNo = p.IdentityNo - (Mines - 1);
                            db.D.Attach(p1);
                            db.Entry(p1).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                }
            }

            var IdentityNoDprime = 0;
            if (db.Dprimes.Count() != 0)
            {
                IdentityNoDprime = db.Dprimes.OrderByDescending(x => x.IdentityNo).FirstOrDefault().IdentityNo;
                var P = db.Dprimes.OrderByDescending(x => x.IdentityNo).ToList();

                for (int i = 0; i <= P.Count(); i++)
                {
                    if (i + 1 < P.Count())
                    {
                        var p = P[i];
                        var p1 = P[i + 1];
                        var Mines = p.IdentityNo - p1.IdentityNo;
                        if ((Mines) > 1)
                        {
                            p.IdentityNo = p.IdentityNo - (Mines - 1);
                            db.Dprimes.Attach(p1);
                            db.Entry(p1).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                }
            }


            var NP = db.N.Select(x => x.NP).FirstOrDefault();

            var NPsec = db.N.Select(x => x.NPsec).FirstOrDefault();

            var NPtert = db.N.Select(x => x.NPtert).FirstOrDefault();


            double Ntotal = NP.Value + NPsec.Value + NPtert.Value;

            if (Num == 1)
            {
                var NIA = db.N.Select(x => x.NIA).FirstOrDefault();
                var NR = db.N.Select(x => x.NR).FirstOrDefault();

                double NIARet = NIA.Value - 1;
                double NRret = NR.Value + 2;
                //update N
                var MatrixN = db.N.FirstOrDefault();
                MatrixN.NIA = Convert.ToInt32(NIARet);
                MatrixN.NR = Convert.ToInt32(NRret);
                db.N.Attach(MatrixN);
                db.Entry(MatrixN).State = EntityState.Modified;
                db.SaveChanges();

            }
            if (Num == 2)
            {
                var NIC = db.N.Select(x => x.NIC).FirstOrDefault();
                var NR = db.N.Select(x => x.NR).FirstOrDefault();


                double NICRet = NIC.Value - 1;
                double NRRet = NR.Value + 2;
                //Update
                var MatrixN = db.N.FirstOrDefault();
                MatrixN.NIC = NICRet;
                MatrixN.NR = NRRet;
                db.N.Attach(MatrixN);
                db.Entry(MatrixN).State = EntityState.Modified;
                db.SaveChanges();

            }
            if (Num == 3)
            {
                var NIS = db.N.Select(x => x.NIS).FirstOrDefault();
                var NR = db.N.Select(x => x.NR).FirstOrDefault();

                double NISret = NIS.Value - 1;
                double NRRet = NR.Value + 2;
                //Update
                var MatrixN = db.N.FirstOrDefault();
                MatrixN.NIS = NISret;
                MatrixN.NR = NRRet;
                db.N.Attach(MatrixN);
                db.Entry(MatrixN).State = EntityState.Modified;
                db.SaveChanges();

            }
            if (Num == 4)
            {
                Tuple<int, double[,], double[,], double[,]> MatrixRet = new Tuple<int, double[,], double[,], double[,]>(0, null, null, null);

                var NM = db.N.Select(x => x.NM).FirstOrDefault();
                var NR = db.N.Select(x => x.NR).FirstOrDefault();

                double NMret = NM.Value - 1;
                double NPret = NP.Value + 1;
                double NRRet = NR.Value - 1;

                var MatrixN = db.N.FirstOrDefault();
                MatrixN.NM = NMret;
                MatrixN.NR = NRRet;
                MatrixN.NP = NPret;
                db.N.Attach(MatrixN);
                db.Entry(MatrixN).State = EntityState.Modified;
                db.SaveChanges();



                double[,] P = new double[3, 1];
                int i = 0;
                int j = 0;
                double IdentityNoPNew = 0;
                double CLPNew = 0;
                double NBPNew = 0;

                for (i = 0; i < P.GetLength(0); i++)
                {
                    for (j = 0; j < P.GetLength(0); j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            P[i, j] = IdentityNoP + 1;
                            IdentityNoPNew = P[i, j];
                        }
                        if (i == 1 && j == 0)
                        {
                            if (P[i, j] == 0)
                            {
                                P[i, j] = 1;
                                CLPNew = P[i, j];

                            }

                        }
                        if (i == 2 && j == 0)
                        {
                            P[i, j] = 0;
                            NBPNew = P[i, j];
                        }
                    }

                }
                Model.P Mp = new Model.P()
                {
                    IdentityNo = (Int32)IdentityNoPNew,
                    CL = (Int32)CLPNew,
                    NB = (Int32)NBPNew

                };

                db.P.Add(Mp);
                db.SaveChanges();

                if (Mp.NB == 0)
                {
                    Model.Branch B = new Model.Branch()
                    {
                        BL = 0,
                        BP = 0,
                        CC = 0,
                        MatId = Mp.Id
                    };
                    db.Branches.Add(B);
                    db.SaveChanges();
                    Model.BranchOnBranch BoB = new Model.BranchOnBranch()
                    {
                        bl = 0,
                        bp = 0,
                        IdBranch = B.Id
                    };
                    db.BranchOnBranches.Add(BoB);
                    db.SaveChanges();
                }



            }
            #region File
            #region If 5
            if (Num == 5)
            {
                Random rnd = new Random();
                int r3 = 0;
                int rtest = 0;
                int Max = (Int32)Ntotal;
                if (Max == 1)
                {
                    Max += 1;
                }
                do
                {
                    rtest = rnd.Next(0, Convert.ToInt32(Max));
                    if (rtest != 0)
                        r3 = rtest;
                } while (rtest == 0);
                double[,] PNew = new double[3, 1];
                if (r3 > 0 && r3 <= NP)
                {
                    int r5 = 0;
                    int rtest5 = 0;
                    int max1 = (Int32)IdentityNoP;
                    if (max1 == 1)
                    {
                        max1 += 1;
                    }
                    do
                    {
                        rtest5 = rnd.Next(0, Convert.ToInt32(max1));
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);

                    var MatrixP = db.P.Where(x => x.IdentityNo == r5).FirstOrDefault();
                    Model.P Mp = new Model.P()
                    {
                        IdentityNo = (Int32)MatrixP.IdentityNo,
                        CL = (Int32)MatrixP.CL + 1,
                        NB = (Int32)MatrixP.NB

                    };




                    db.P.Add(Mp);
                    db.SaveChanges();

                    var BranchesP = db.Branches.Where(x => x.MatId == MatrixP.Id).ToList();

                    foreach (var item in BranchesP)
                    {

                        var BranchOnBranchesP = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        item.MatId = Mp.Id;

                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();

                        foreach (var item2 in BranchOnBranchesP)
                        {
                            item2.IdBranch = item.Id;



                            db.BranchOnBranches.Attach(item2);
                            db.Entry(item2).State = EntityState.Modified;
                            db.SaveChanges();


                        }

                    }



                    //delete  p with Idn
                    db.P.Remove(MatrixP);
                    db.SaveChanges();
                    //for (int i = MatrixP.IdentityNo; i <= db.P.Count()+1; i++)
                    //{
                    //    var identity = db.P.Where(x => x.IdentityNo == i).FirstOrDefault();
                    //    identity.IdentityNo = identity.IdentityNo - 1;
                    //    db.P.Attach(identity);
                    //    db.Entry(identity).State = EntityState.Modified;
                    //    db.SaveChanges();
                    //}


                    var NM = db.N.Select(x => x.NM).FirstOrDefault();
                    double NMret = NM.Value - 1;
                    double NPret = NP.Value;
                    //update N
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NM = NMret;
                    MatrixN.NP = NPret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();




                }
                else if (r3 > NP && r3 <= NP + NPsec)
                {

                    int r5 = 0;
                    int rtest5 = 0;
                    int max2 = IdentityNoPsec;
                    if (max2 == 1)
                    {
                        max2 += 1;
                    }
                    do
                    {
                        rtest5 = rnd.Next(0, Convert.ToInt32(max2));
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);


                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r5).FirstOrDefault();
                    Model.P Mp = new Model.P()
                    {
                        IdentityNo = IdentityNoP + 1,
                        CL = (Int32)MatrixPsec.CL + 1,
                        NB = (Int32)MatrixPsec.NB

                    };




                    db.P.Add(Mp);
                    db.SaveChanges();

                    var BranchesPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();

                    foreach (var item in BranchesPsec)
                    {

                        var BranchOnBranchesPsec = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        Model.Branch Bp = new Model.Branch()
                        {
                            MatId = Mp.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC

                        };


                        db.Branches.Attach(Bp);
                        db.Entry(Bp).State = EntityState.Modified;
                        db.SaveChanges();

                        foreach (var item2 in BranchOnBranchesPsec)
                        {
                            Model.BranchOnBranch BOBp = new Model.BranchOnBranch()
                            {
                                IdBranch = Bp.Id,
                                bl = item2.bl,
                                bp = item2.bp

                            };

                            db.BranchOnBranches.Attach(BOBp);
                            db.Entry(BOBp).State = EntityState.Modified;
                            db.SaveChanges();

                        }
                    }



                    //delete  p with Idn
                    db.Psecs.Remove(MatrixPsec);
                    db.SaveChanges();
                    for (int i = MatrixPsec.IdentityNo; i <= db.Psecs.Count() + 1; i++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == i).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }


                    var NM = db.N.Select(x => x.NM).FirstOrDefault();
                    double NMret = NM.Value - 1;
                    double NPret = NP.Value + 1;
                    double NpSecret = NPsec.Value - 1;
                    //Update N
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NM = NMret;
                    MatrixN.NPsec = NpSecret;
                    MatrixN.NP = NPret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();

                }// all if checking 
                else
                {
                    int r5 = 0;
                    int rtest5 = 0;
                    int max3 = IdentityNoPtert;
                    if (max3 == 1)
                    {
                        max3 += 1;
                    }
                    do
                    {
                        rtest5 = rnd.Next(0, Convert.ToInt32(max3));
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);


                    var MatrixPtert = db.Pterts.Where(x => x.IdentityNo == r5).FirstOrDefault();
                    Model.P Mp = new Model.P()
                    {
                        IdentityNo = IdentityNoP + 1,
                        CL = (Int32)MatrixPtert.CL + 1,
                        NB = (Int32)MatrixPtert.NB

                    };




                    db.P.Add(Mp);
                    db.SaveChanges();

                    var BranchesPtert = db.Branches.Where(x => x.MatId == MatrixPtert.Id).ToList();

                    foreach (var item in BranchesPtert)
                    {

                        var BranchOnBranchesPtert = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        Model.Branch Bp = new Model.Branch()
                        {
                            MatId = Mp.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC

                        };

                        db.Branches.Attach(Bp);
                        db.Entry(Bp).State = EntityState.Modified;
                        db.SaveChanges();

                        foreach (var item2 in BranchOnBranchesPtert)
                        {
                            Model.BranchOnBranch BOBp = new Model.BranchOnBranch()
                            {
                                IdBranch = Bp.Id,
                                bl = item2.bl,
                                bp = item2.bp

                            };

                            db.BranchOnBranches.Attach(BOBp);
                            db.Entry(BOBp).State = EntityState.Modified;
                            db.SaveChanges();

                        }

                    }



                    //delete  p with Idn
                    db.Pterts.Remove(MatrixPtert);
                    db.SaveChanges();
                    for (int i = MatrixPtert.IdentityNo; i <= db.Pterts.Count() + 1; i++)
                    {
                        var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == i).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Pterts.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }


                    //Update N
                    var NM = db.N.Select(x => x.NM).FirstOrDefault();
                    double NMret = NM.Value - 1;
                    double NPret = NP.Value + 1;
                    double NPtertret = NPtert.Value - 1;

                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NM = NMret;
                    MatrixN.NPtert = NPtertret;
                    MatrixN.NP = NPret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();

                }

            }
            #endregion
            #region If 6 , 7
            if (Num == 6)
            {
                Random rnd = new Random();
                int r3 = 0;
                int rtest = 0;
                int max4 = IdentityNoP;
                if (max4 == 1)
                {
                    max4 += 1;
                }
                do
                {
                    rtest = rnd.Next(0, Convert.ToInt32(max4));
                    if (rtest != 0)
                        r3 = rtest;
                } while (rtest == 0);


                double[,] P = new double[3, 1];

                if (r3 > 0 && r3 <= NP)
                {

                    int r6 = 0;
                    int rtest6 = 0;
                    int max5 = IdentityNoP;
                    if (max5 == 1)
                    {
                        max5 += 1;
                    }
                    do
                    {
                        rtest6 = rnd.Next(0, Convert.ToInt32(max5));
                        if (rtest6 != 0)
                            r6 = rtest6;
                    } while (rtest6 == 0);

                    var MatrixP = db.P.Where(x => x.IdentityNo == r6).FirstOrDefault();
                    Model.D Mp = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = (Int32)MatrixP.CL,
                        NB = (Int32)MatrixP.NB

                    };

                    db.D.Add(Mp);
                    db.SaveChanges();

                    var BranchesP = db.Branches.Where(x => x.MatId == MatrixP.Id).ToList();

                    foreach (var item in BranchesP)
                    {

                        var BranchOnBranchesP = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        item.MatId = Mp.Id;



                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in BranchOnBranchesP)
                        {
                            item2.IdBranch = item.Id;



                            db.BranchOnBranches.Attach(item2);
                            db.Entry(item2).State = EntityState.Modified;
                            db.SaveChanges();


                        }

                    }



                    //delete  p with Idn
                    db.P.Remove(MatrixP);
                    db.SaveChanges();
                    for (int i = MatrixP.IdentityNo; i <= db.P.Count() + 1; i++)
                    {
                        var count = db.P.Count() + 1;
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == i).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }


                    var NM = db.N.Select(x => x.NM).FirstOrDefault();
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    double NMret = NM.Value - 1;
                    double NPret = NP.Value;
                    double NDret = ND.Value + 1;


                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NM = NMret;
                    MatrixN.ND = NDret;
                    MatrixN.NP = NPret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();




                }
                else if (r3 > NP && r3 <= NP + NPsec)
                {
                    int i = 0;
                    int j = 0;
                    int r6 = 0;
                    int rtest6 = 0;
                    int max6 = IdentityNoPsec;
                    if (max6 == 1)
                    {
                        max6 += 1;
                    }
                    do
                    {
                        rtest6 = rnd.Next(0, Convert.ToInt32(max6));
                        if (rtest6 != 0)
                            r6 = rtest6;
                    } while (rtest6 == 0);

                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r6).FirstOrDefault();

                    var LastBranchesPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).FirstOrDefault();
                    var BoBLastBPsec = db.BranchOnBranches.Where(x => x.IdBranch == LastBranchesPsec.Id).FirstOrDefault();
                    var BranchesPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();

                    var AllBranch = db.Branches.ToList();
                    var AllBOB = db.BranchOnBranches.ToList();
                    var AllBranchPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();
                    var BoBLastBPsecList = db.BranchOnBranches.Where(x => x.IdBranch == LastBranchesPsec.Id).ToList();
                    foreach (var item in BranchesPsec)
                    {

                        foreach (var item2 in BoBLastBPsecList)
                        {
                            if (item.BP == item2.bp)
                            {
                                i += 1;
                            }
                        }

                    }
                    if (i < 2)
                    {
                        Model.D Mp = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = (Int32)MatrixPsec.CL,
                            NB = (Int32)MatrixPsec.NB + LastBranchesPsec.CC

                        };

                        db.D.Add(Mp);
                        db.SaveChanges();
                        db.Branches.Remove(LastBranchesPsec);
                        db.SaveChanges();


                        Model.Branch Bpsec = new Model.Branch()
                        {
                            MatId = Mp.Id,
                            BP = BoBLastBPsec.bp,
                            BL = BoBLastBPsec.bl,
                            CC = 0

                        };

                        db.Branches.Add(Bpsec);
                        db.SaveChanges();



                        foreach (var item in BranchesPsec)
                        {

                            var BranchOnBranchesPsec = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                            item.MatId = Mp.Id;
                            db.Branches.Attach(item);
                            db.Entry(item).State = EntityState.Modified;
                            db.SaveChanges();

                            foreach (var item2 in BranchOnBranchesPsec)
                            {
                                item2.IdBranch = item.Id;
                                db.BranchOnBranches.Attach(item2);
                                db.Entry(item2).State = EntityState.Modified;
                                db.SaveChanges();

                            }
                        }






                        //delete  p with Idn
                        db.Psecs.Remove(MatrixPsec);
                        db.SaveChanges();
                        for (i = MatrixPsec.IdentityNo; i <= db.Psecs.Count() + 1; i++)
                        {
                            var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == i).FirstOrDefault();
                            if (identity != null)
                            {
                                identity.IdentityNo = identity.IdentityNo - 1;
                                db.Psecs.Attach(identity);
                                db.Entry(identity).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }


                        var NM = db.N.Select(x => x.NM).FirstOrDefault();
                        var ND = db.N.Select(x => x.ND).FirstOrDefault();
                        double NMret = NM.Value - 1;
                        double NPret = NP.Value + 1;
                        double NDret = ND.Value + 1;
                        double NPsecret = NPsec.Value - 1;

                        var MatrixN = db.N.FirstOrDefault();
                        MatrixN.NM = NMret;
                        MatrixN.NPsec = NPsecret;
                        MatrixN.NP = NPret;
                        MatrixN.ND = NDret;
                        db.N.Attach(MatrixN);
                        db.Entry(MatrixN).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                }
                else
                {
                    int j = 0;
                    int r9 = 0;
                    int rtest9 = 0;
                    do
                    {
                        rtest9 = rnd.Next(0, Convert.ToInt32(IdentityNoPtert));
                        if (rtest9 != 0)
                            r9 = rtest9;
                    } while (rtest9 == 0);

                    var MatrixPtert = db.Pterts.Where(x => x.IdentityNo == r9).FirstOrDefault();
                    var LastBPtert = db.Branches.Where(x => x.MatId == MatrixPtert.Id).FirstOrDefault();
                    var BPtert = db.Branches.Where(x => x.MatId == MatrixPtert.Id).ToList();
                    var BoBLastBPtertList = db.BranchOnBranches.Where(x => x.IdBranch == LastBPtert.Id).ToList();
                    foreach (var item in BPtert)
                    {

                        foreach (var item2 in BoBLastBPtertList)
                        {
                            if (item.BP == item2.bp)
                            {
                                j += 1;
                            }
                        }

                    }
                    if (j < 2)
                    {

                        Model.Branch SecLastBPtert = new Model.Branch();

                        if (BPtert.Count >= 2)
                            SecLastBPtert = BPtert[BPtert.Count - 2];
                        if (LastBPtert.BL > SecLastBPtert.BL)
                        {
                            Model.D Mp = new Model.D()
                            {
                                IdentityNo = IdentityNoD + 1,
                                CL = (Int32)MatrixPtert.CL,
                                NB = (Int32)MatrixPtert.NB + LastBPtert.CC

                            };
                            db.D.Add(Mp);
                            db.SaveChanges();
                            var BranchOnBranchesLastBPtert = db.BranchOnBranches.Where(x => x.IdBranch == LastBPtert.Id).ToList();

                            db.Branches.Remove(LastBPtert);
                            db.SaveChanges();
                            foreach (var item in BPtert)
                            {

                                var BranchOnBranchesBPtert = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                                item.MatId = Mp.Id;
                               

                                db.Branches.Attach(item);
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                                foreach (var item2 in BranchOnBranchesBPtert)
                                {
                                    item2.IdBranch = item.Id;
                                  

                                    db.BranchOnBranches.Attach(item2);
                                    db.Entry(item2).State = EntityState.Modified;
                                    db.SaveChanges();

                                }
                            }
                            foreach (var item in BranchOnBranchesLastBPtert)
                            {
                                Model.Branch Bp = new Model.Branch()
                                {
                                    MatId = Mp.Id,
                                    BP = item.bp,
                                    BL = item.bp,
                                    CC = 0

                                };
                                db.Branches.Add(Bp);
                                db.SaveChanges();


                            }




                        }
                        else if (LastBPtert.BL < SecLastBPtert.BL)
                        {

                            Model.D Mp = new Model.D()
                            {
                                IdentityNo = IdentityNoD + 1,
                                CL = (Int32)MatrixPtert.CL,
                                NB = (Int32)MatrixPtert.NB + LastBPtert.CC

                            };
                            db.D.Add(Mp);
                            db.SaveChanges();
                            var BranchOnBranchesSecLastBPtert = db.BranchOnBranches.Where(x => x.IdBranch == SecLastBPtert.Id).ToList();

                            db.Branches.Remove(SecLastBPtert);
                            db.SaveChanges();
                            foreach (var item in BPtert)
                            {

                                var BranchOnBranchesBPtert = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                                item.MatId = Mp.Id;
                              
                                db.Branches.Attach(item);
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();

                                foreach (var item2 in BranchOnBranchesBPtert)
                                {
                                    item2.IdBranch = item.Id;
                                   

                                    db.BranchOnBranches.Attach(item2);
                                    db.Entry(item2).State = EntityState.Modified;
                                    db.SaveChanges();

                                }
                            }
                            foreach (var item in BranchOnBranchesSecLastBPtert)
                            {
                                Model.Branch Bp = new Model.Branch()
                                {
                                    MatId = Mp.Id,
                                    BP = item.bp,
                                    BL = item.bp,
                                    CC = 0

                                };
                                db.Branches.Add(Bp);
                                    db.SaveChanges();

                            }






                        }
                        db.Pterts.Remove(MatrixPtert);
                        db.SaveChanges();
                        for (int ii = MatrixPtert.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                        {
                            var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                            if (identity != null)
                            {
                                identity.IdentityNo = identity.IdentityNo - 1;
                                db.Pterts.Attach(identity);
                                db.Entry(identity).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }
                        var NM = db.N.Select(x => x.NM).FirstOrDefault();
                        var ND = db.N.Select(x => x.ND).FirstOrDefault();
                        double NMret = NM.Value - 1;
                        double NPret = NP.Value + 1;
                        double NDret = ND.Value + 1;
                        double NPsectert = NPtert.Value - 1;


                        var MatrixN = db.N.FirstOrDefault();
                        MatrixN.NM = NMret;
                        MatrixN.NPtert = NPsectert;
                        MatrixN.NP = NPret;
                        MatrixN.ND = NDret;
                        db.N.Attach(MatrixN);
                        db.Entry(MatrixN).State = EntityState.Modified;
                        db.SaveChanges();


                    }

                }

                Model.P PNew = new Model.P()
                {
                    IdentityNo = IdentityNoP + 1,
                    CL = 1,
                    NB = 0
                };
                db.P.Add(PNew);
                db.SaveChanges();
                if (PNew.NB == 0)
                {
                    Model.Branch B = new Model.Branch()
                    {
                        BL = 0,
                        BP = 0,
                        CC = 0,
                        MatId = PNew.Id
                    };
                    db.Branches.Add(B);
                    db.SaveChanges();
                    Model.BranchOnBranch BoB = new Model.BranchOnBranch()
                    {
                        bl = 0,
                        bp = 0,
                        IdBranch = B.Id
                    };
                    db.BranchOnBranches.Add(BoB);
                    db.SaveChanges();
                }

            }
            if (Num == 7)
            {
                Random rnd = new Random();
                int r3 = 0;
                int rtest = 0;
                int max7 = IdentityNoP;
                if (max7 == 1)
                {
                    max7 += 1;
                }

                do
                {
                    rtest = rnd.Next(0, Convert.ToInt32(max7));
                    if (rtest != 0)
                        r3 = rtest;
                } while (rtest == 0);
                double[,] P = new double[3, 1];

                if (r3 > 0 && r3 <= NP)
                {

                    int r6 = 0;
                    int rtest6 = 0;
                    int max8 = IdentityNoP;
                    if (max8 == 1)
                    {
                        max8 += 1;
                    }
                    do
                    {
                        rtest6 = rnd.Next(0, Convert.ToInt32(max8));
                        if (rtest6 != 0)
                            r6 = rtest6;
                    } while (rtest6 == 0);

                    var MatrixP = db.P.Where(x => x.IdentityNo == r6).FirstOrDefault();
                    Model.D Mp = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = (Int32)MatrixP.CL,
                        NB = (Int32)MatrixP.NB

                    };

                    db.D.Add(Mp);
                    db.SaveChanges();

                    var BranchesP = db.Branches.Where(x => x.MatId == MatrixP.Id).ToList();

                    foreach (var item in BranchesP)
                    {

                        var BranchOnBranchesP = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        item.MatId = Mp.Id;


                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in BranchOnBranchesP)
                        {
                            item2.IdBranch = item.Id;


                            db.BranchOnBranches.Attach(item2);
                            db.Entry(item2).State = EntityState.Modified;
                            db.SaveChanges();

                        }

                    }



                    //delete  p with Idn
                    db.P.Remove(MatrixP);
                    db.SaveChanges();
                    for (int i = MatrixP.IdentityNo; i <= db.P.Count() + 1; i++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == i).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }


                    var NCTA = db.N.Select(x => x.NCTA).FirstOrDefault();
                    var count = db.P.Count() + 1;
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    double NCTAret = NCTA.Value - 1;
                    double NPret = NP.Value;
                    double NDret = ND.Value + 1;

                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NCTA = NCTAret;
                    MatrixN.NP = NPret;
                    MatrixN.ND = NDret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                }
                else if (r3 > NP && r3 <= NP + NPsec)
                {
                    int i = 0;
                    int j = 0;

                    int r6 = 0;
                    int rtest6 = 0;
                    int max9 = IdentityNoPsec;
                    if (max9 == 1)
                    {
                        max9 += 1;
                    }
                    do
                    {
                        rtest6 = rnd.Next(0, Convert.ToInt32(max9));
                        if (rtest6 != 0)
                            r6 = rtest6;
                    } while (rtest6 == 0);

                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r6).FirstOrDefault();

                    var LastBranchesPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).FirstOrDefault();
                    var BoBLastBPsec = db.BranchOnBranches.Where(x => x.IdBranch == LastBranchesPsec.Id).FirstOrDefault();
                    var BranchesPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();

                    var AllBranch = db.Branches.ToList();
                    var AllBOB = db.BranchOnBranches.ToList();
                    var AllBranchPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();
                    var BoBLastBPsecList = db.BranchOnBranches.Where(x => x.IdBranch == LastBranchesPsec.Id).ToList();
                    foreach (var item in BranchesPsec)
                    {

                        foreach (var item2 in BoBLastBPsecList)
                        {
                            if (item.BP == item2.bp)
                            {
                                i += 1;
                            }
                        }

                    }
                    if (i < 2)
                    {
                        Model.D Mp = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = (Int32)MatrixPsec.CL,
                            NB = (Int32)MatrixPsec.NB + LastBranchesPsec.CC

                        };

                        db.D.Add(Mp);
                        db.SaveChanges();
                        db.Branches.Remove(LastBranchesPsec);
                        db.SaveChanges();


                        Model.Branch Bpsec = new Model.Branch()
                        {
                            MatId = Mp.Id,
                            BP = BoBLastBPsec.bp,
                            BL = BoBLastBPsec.bl,
                            CC = 0

                        };

                        db.Branches.Add(Bpsec);
                        db.SaveChanges();



                        foreach (var item in BranchesPsec)
                        {

                            var BranchOnBranchesPsec = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                            item.MatId = Mp.Id;


                            db.Branches.Attach(item);
                            db.Entry(item).State = EntityState.Modified;
                            db.SaveChanges();

                            foreach (var item2 in BranchOnBranchesPsec)
                            {
                                item2.IdBranch = item.Id;


                                db.BranchOnBranches.Attach(item2);
                                db.Entry(item2).State = EntityState.Modified;
                                db.SaveChanges();

                            }
                        }






                        //delete  p with Idn
                        db.Psecs.Remove(MatrixPsec);
                        db.SaveChanges();
                        for (i = MatrixPsec.IdentityNo; i <= db.Psecs.Count() + 1; i++)
                        {
                            var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == i).FirstOrDefault();
                            if (identity != null)
                            {
                                identity.IdentityNo = identity.IdentityNo - 1;
                                db.Psecs.Attach(identity);
                                db.Entry(identity).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }


                        var NCTA = db.N.Select(x => x.NCTA).FirstOrDefault();
                        var ND = db.N.Select(x => x.ND).FirstOrDefault();
                        double NCTAret = NCTA.Value - 1;
                        double NPret = NP.Value + 1;
                        double NDret = ND.Value + 1;
                        double NPsecret = NPsec.Value - 1;

                        var MatrixN = db.N.FirstOrDefault();
                        MatrixN.NCTA = NCTAret;
                        MatrixN.NPsec = NPsecret;
                        MatrixN.NP = NPret;
                        MatrixN.ND = NDret;
                        db.N.Attach(MatrixN);
                        db.Entry(MatrixN).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                }
                else
                {
                    int j = 0;

                    int r9 = 0;
                    int rtest9 = 0;
                    int max10 = IdentityNoPtert;
                    if (max10 == 1)
                    {
                        max10 += 1;
                    }
                    do
                    {
                        rtest9 = rnd.Next(0, Convert.ToInt32(max10));
                        if (rtest9 != 0)
                            r9 = rtest9;
                    } while (rtest9 == 0);

                    var MatrixPtert = db.Pterts.Where(x => x.IdentityNo == r9).FirstOrDefault();
                    var LastBPtert = db.Branches.Where(x => x.MatId == MatrixPtert.Id).FirstOrDefault();
                    var BPtert = db.Branches.Where(x => x.MatId == MatrixPtert.Id).ToList();
                    var BoBLastBPtertList = db.BranchOnBranches.Where(x => x.IdBranch == LastBPtert.Id).ToList();
                    foreach (var item in BPtert)
                    {

                        foreach (var item2 in BoBLastBPtertList)
                        {
                            if (item.BP == item2.bp)
                            {
                                j += 1;
                            }
                        }

                    }
                    if (j < 2)
                    {

                        Model.Branch SecLastBPtert = new Model.Branch();

                        if (BPtert.Count >= 2)
                            SecLastBPtert = BPtert[BPtert.Count - 2];
                        if (LastBPtert.BL > SecLastBPtert.BL)
                        {
                            Model.D Mp = new Model.D()
                            {
                                IdentityNo = IdentityNoD + 1,
                                CL = (Int32)MatrixPtert.CL,
                                NB = (Int32)MatrixPtert.NB + LastBPtert.CC

                            };
                            db.D.Add(Mp);
                            db.SaveChanges();
                            var BranchOnBranchesLastBPtert = db.BranchOnBranches.Where(x => x.IdBranch == LastBPtert.Id).ToList();

                            db.Branches.Remove(LastBPtert);
                            db.SaveChanges();
                            foreach (var item in BPtert)
                            {

                                var BranchOnBranchesBPtert = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                                item.MatId = Mp.Id;


                                db.Branches.Attach(item);
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                                foreach (var item2 in BranchOnBranchesBPtert)
                                {

                                    item2.IdBranch = item.Id;

                                    db.BranchOnBranches.Attach(item2);
                                    db.Entry(item2).State = EntityState.Modified;
                                    db.SaveChanges();

                                }
                            }
                            foreach (var item in BranchOnBranchesLastBPtert)
                            {

                                Model.Branch Bp = new Model.Branch()
                                {
                                    MatId = Mp.Id,
                                    BP = item.bp,
                                    BL = item.bp,
                                    CC = 0

                                };
                                db.Branches.Add(Bp);
                                db.SaveChanges();


                            }




                        }
                        else if (LastBPtert.BL < SecLastBPtert.BL)
                        {

                            Model.D Mp = new Model.D()
                            {
                                IdentityNo = IdentityNoD + 1,
                                CL = (Int32)MatrixPtert.CL,
                                NB = (Int32)MatrixPtert.NB + LastBPtert.CC

                            };
                            db.D.Add(Mp);
                            db.SaveChanges();
                            var BranchOnBranchesSecLastBPtert = db.BranchOnBranches.Where(x => x.IdBranch == SecLastBPtert.Id).ToList();

                            db.Branches.Remove(SecLastBPtert);
                            db.SaveChanges();
                            foreach (var item in BPtert)
                            {

                                var BranchOnBranchesBPtert = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                                item.MatId = Mp.Id;

                                db.Branches.Attach(item);
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();

                                foreach (var item2 in BranchOnBranchesBPtert)
                                {
                                    item2.IdBranch = item.Id;

                                    db.BranchOnBranches.Attach(item2);
                                    db.Entry(item2).State = EntityState.Modified;
                                    db.SaveChanges();

                                }
                            }
                            foreach (var item in BranchOnBranchesSecLastBPtert)
                            {
                                Model.Branch Bp = new Model.Branch()
                                {
                                    MatId = Mp.Id,
                                    BP = item.bp,
                                    BL = item.bp,
                                    CC = 0

                                };
                                db.Branches.Add(Bp);
                                db.SaveChanges();

                            }
                        }
                        db.Pterts.Remove(MatrixPtert);
                        db.SaveChanges();
                        for (int ii = MatrixPtert.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                        {
                            var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                            if (identity != null)
                            {
                                identity.IdentityNo = identity.IdentityNo - 1;
                                db.Pterts.Attach(identity);
                                db.Entry(identity).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }
                        var NCTA = db.N.Select(x => x.NCTA).FirstOrDefault();
                        var ND = db.N.Select(x => x.ND).FirstOrDefault();
                        double NCTAret = NCTA.Value - 1;
                        double NPret = NP.Value + 1;
                        double NDret = ND.Value + 1;
                        double NPsectert = NPtert.Value - 1;

                        var MatrixN = db.N.FirstOrDefault();
                        MatrixN.NCTA = NCTAret;
                        MatrixN.NPtert = NPsectert;
                        MatrixN.NP = NPret;
                        MatrixN.ND = NDret;
                        db.N.Attach(MatrixN);
                        db.Entry(MatrixN).State = EntityState.Modified;
                        db.SaveChanges();


                    }
                }

                Model.P PNew = new Model.P()
                {
                    IdentityNo = IdentityNoP + 1,
                    CL = 1,
                    NB = 0
                };
                db.P.Add(PNew);
                db.SaveChanges();
                if (PNew.NB == 0)
                {
                    Model.Branch B = new Model.Branch()
                    {
                        BL = 0,
                        BP = 0,
                        CC = 0,
                        MatId = PNew.Id
                    };
                    db.Branches.Add(B);
                    db.SaveChanges();
                    Model.BranchOnBranch BoB = new Model.BranchOnBranch()
                    {
                        bl = 0,
                        bp = 0,
                        IdBranch = B.Id
                    };
                    db.BranchOnBranches.Add(BoB);
                    db.SaveChanges();
                }
            }
            #endregion
            if (Num == 8)
            {
                Random rnd = new Random();

                int r7 = 0;
                int rtest7 = 0;
                int max11 = IdentityNoD;
                if (max11 == 1)
                {
                    max11 += 1;
                }
                do
                {
                    rtest7 = rnd.Next(0, Convert.ToInt32(max11));
                    if (rtest7 != 0)
                        r7 = rtest7;
                } while (rtest7 == 0);


                var D = db.D.Where(x => x.IdentityNo == r7).FirstOrDefault();
                //BL,BP branches D     
                var BLSum = 0;
                var BranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                foreach (var item in BranchesD)
                {
                    BLSum += item.BL;
                }
                int r8 = 0;
                int rtest8 = 0;
                int max12 = (D.CL - BLSum);
                if (max12 == 1)
                {
                    max12 += 1;
                }

                do
                {
                    rtest8 = rnd.Next(0, max12);
                    if (rtest8 != 0)
                        r8 = rtest8;
                } while (rtest8 == 0);

                int r3 = 0;
                int rtest = 0;
                int max13 = (Int32)Ntotal;
                if (max13 == 1)
                {
                    max13 += 1;
                }
                do
                {
                    rtest = rnd.Next(0, Convert.ToInt32(max13));
                    if (rtest != 0)
                        r3 = rtest;
                } while (rtest == 0);

                if (r3 > 0 && r3 <= NP)
                {
                    var NLcb = db.N.Select(x => x.NLCB).FirstOrDefault();

                    double NLcbret = NLcb.Value + 1;
                    double NPret = NP.Value - 1;


                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NLCB = NLcbret;
                    MatrixN.NP = NPret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                    int r4 = 0;
                    int rtest4 = 0;
                    int max14 = IdentityNoP;
                    if (max14 == 1)
                    {
                        max14 += 1;
                    }
                    do
                    {
                        rtest4 = rnd.Next(0, Convert.ToInt32(max14));
                        if (rtest4 != 0)
                            r4 = rtest4;
                    } while (rtest4 == 0);


                    var P = db.P.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    Model.D MD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = P.CL,
                        NB = P.NB
                    };

                    var BranchesP = db.Branches.Where(x => x.MatId == P.Id).ToList();

                    foreach (var item in BranchesP)
                    {

                        var BranchOnBranchesP = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        item.MatId = MD.Id;
                      
                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in BranchOnBranchesP)
                        {
                            item2.IdBranch = item.Id;
                         
                            db.BranchOnBranches.Attach(item2);
                            db.Entry(item2).State = EntityState.Modified;
                            db.SaveChanges();

                        }
                    }

                    db.P.Remove(P);
                    db.SaveChanges();
                    for (int ii = P.IdentityNo; ii <= db.P.Count() + 1; ii++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }

                    var BPCounter = 0;
                    int i = 0;
                    foreach (var item in BranchesD)
                    {
                        if (r8 == item.BP)
                        {
                            i += 1;
                        }
                    }
                    foreach (var item in BranchesD)
                    {


                        if (r8 != item.BP)
                        {
                            double NPsecret = NPsec.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                            }
                            Model.Psec MPsec = new Model.Psec()
                            {
                                IdentityNo = IdentityNoPsec + 1,
                                CL = D.CL,
                                NB = BPCounter + 1
                            };
                            db.Psecs.Add(MPsec);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {

                                item.MatId = MPsec.Id;
                               
                                db.Branches.Attach(item);
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                                var PsecNewBranch = db.Branches.Where(x => x.MatId == MPsec.Id).ToList();

                                BLSum = 0;
                                foreach (var Bl in PsecNewBranch)
                                {
                                    BLSum += Bl.BL;
                                }
                                Model.Branch PluseBPsec = new Model.Branch()
                                {
                                    MatId = MPsec.Id,
                                    BL = D.CL - BLSum - r8,
                                    BP = r8,
                                    CC = D.NB - MPsec.NB


                                };
                                db.Branches.Add(PluseBPsec);
                                db.SaveChanges();

                                var RemainBD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                                foreach (var item3 in RemainBD)
                                {


                                    Model.BranchOnBranch BOBPsec = new Model.BranchOnBranch()
                                    {
                                        IdBranch = MPsec.Id,
                                        bl = item3.BL,
                                        bp = item3.BP,
                                    };
                                    db.BranchOnBranches.Add(BOBPsec);
                                    db.SaveChanges();
                                    db.Branches.Remove(item3);
                                    db.SaveChanges();

                                }
                            }


                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }

                            for (i = D.IdentityNo; i <= db.D.Count(); i++)
                            {
                                var identity = db.D.Where(x => x.IdentityNo == i).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }

                        }
                        else if (i == 1)
                        {
                            var NPtertret = NPtert + 1;
                            if (r8 == item.BP)
                            {
                                if (item.BP <= r8)
                                {
                                    BPCounter += 1;
                                }
                                Model.Ptert MPtert = new Model.Ptert()
                                {
                                    IdentityNo = IdentityNoPtert + 1,
                                    CL = D.CL,
                                    NB = BPCounter + 1
                                };
                                db.Pterts.Add(MPtert);
                                db.SaveChanges();

                                if (D.NB <= BPCounter)
                                {
                                    item.MatId = MPtert.Id;
                                   
                                    db.Branches.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                    db.SaveChanges();
                                    var PtertNewBranch = db.Branches.Where(x => x.MatId == MPtert.Id).ToList();

                                    BLSum = 0;
                                    foreach (var Bl in PtertNewBranch)
                                    {
                                        BLSum += Bl.BL;
                                    }
                                    Model.Branch PluseBPtert = new Model.Branch()
                                    {
                                        MatId = MPtert.Id,
                                        BL = D.CL - BLSum - r8,
                                        BP = r8,
                                        CC = D.NB - MPtert.NB


                                    };
                                    db.Branches.Add(PluseBPtert);
                                    db.SaveChanges();

                                    var RemainBD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                                    foreach (var item3 in RemainBD)
                                    {


                                        Model.BranchOnBranch BOBPtert = new Model.BranchOnBranch()
                                        {
                                            IdBranch = MPtert.Id,
                                            bl = item3.BL,
                                            bp = item3.BP,
                                        };
                                        db.BranchOnBranches.Add(BOBPtert);
                                        db.SaveChanges();
                                        db.Branches.Remove(item3);
                                        db.SaveChanges();

                                    }
                                }


                                db.D.Remove(D);
                                db.SaveChanges();
                                for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                                {
                                    var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                    if (identity != null)
                                    {
                                        identity.IdentityNo = identity.IdentityNo - 1;
                                        db.D.Attach(identity);
                                        db.Entry(identity).State = EntityState.Modified;
                                        db.SaveChanges();
                                    }
                                }
                            }

                        }
                    }
                }
                else if (r3 > NP && r3 <= NP + NPsec)
                {
                    var NLCB = db.N.Select(x => x.NLCB).FirstOrDefault();
                    double NLcbret = NLCB.Value + 1;
                    double NPsecret = NPsec.Value - 1;
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NLCB = NLcbret;
                    MatrixN.NPsec = NPsecret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                    int r4 = 0;
                    int rtest4 = 0;
                    int max15 = IdentityNoPsec;
                    if (max15 == 1)
                    {
                        max15 += 1;
                    }
                    do
                    {
                        rtest4 = rnd.Next(0, Convert.ToInt32(max15));
                        if (rtest4 != 0)
                            r4 = rtest4;
                    } while (rtest4 == 0);


                    var Psec = db.Psecs.Where(x => x.IdentityNo == r4).FirstOrDefault();


                    Model.D MD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = Psec.CL,
                        NB = Psec.NB
                    };

                    var BranchesPsec = db.Branches.Where(x => x.MatId == Psec.Id).ToList();

                    foreach (var item in BranchesPsec)
                    {

                        var BranchOnBranchesPsec = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        item.MatId = MD.Id;
                      

                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in BranchOnBranchesPsec)
                        {
                            item2.IdBranch = item.Id;
                          
                            db.BranchOnBranches.Attach(item2);
                            db.Entry(item2).State = EntityState.Modified;
                            db.SaveChanges();

                        }
                    }

                    db.Psecs.Remove(Psec);
                    db.SaveChanges();
                    for (int ii = Psec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }

                    var BPCounter = 0;
                    int i = 0;
                    foreach (var item in BranchesD)
                    {
                        if (r8 == item.BP)
                        {
                            i += 1;
                        }
                    }
                    foreach (var item in BranchesD)
                    {


                        if (r8 != item.BP)
                        {
                            NPsecret = NPsec.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                            }
                            Model.Psec MPsec = new Model.Psec()
                            {
                                IdentityNo = IdentityNoPsec + 1,
                                CL = D.CL,
                                NB = BPCounter + 1
                            };
                            db.Psecs.Add(MPsec);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {
                                item.MatId = MPsec.Id;
                               
                                db.Branches.Attach(item);
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                                var PsecNewBranch = db.Branches.Where(x => x.MatId == MPsec.Id).ToList();

                                BLSum = 0;
                                foreach (var Bl in PsecNewBranch)
                                {
                                    BLSum += Bl.BL;
                                }
                                Model.Branch PluseBPsec = new Model.Branch()
                                {
                                    MatId = MPsec.Id,
                                    BL = D.CL - BLSum - r8,
                                    BP = r8,
                                    CC = D.NB - MPsec.NB


                                };
                                db.Branches.Add(PluseBPsec);
                                db.SaveChanges();

                                var RemainBD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                                foreach (var item3 in RemainBD)
                                {


                                    Model.BranchOnBranch BOBPsec = new Model.BranchOnBranch()
                                    {
                                        IdBranch = MPsec.Id,
                                        bl = item3.BL,
                                        bp = item3.BP,
                                    };
                                    db.BranchOnBranches.Add(BOBPsec);
                                    db.SaveChanges();
                                    db.Branches.Remove(item3);
                                    db.SaveChanges();

                                }
                            }


                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }
                        }
                        else if (i == 1)
                        {
                            var NPtertret = NPtert + 1;
                            if (r8 == item.BP)
                            {
                                if (item.BP <= r8)
                                {
                                    BPCounter += 1;
                                }
                                Model.Ptert MPtert = new Model.Ptert()
                                {
                                    IdentityNo = IdentityNoPtert + 1,
                                    CL = D.CL,
                                    NB = BPCounter + 1
                                };
                                db.Pterts.Add(MPtert);
                                db.SaveChanges();

                                if (D.NB <= BPCounter)
                                {
                                    item.MatId = MPtert.Id;
                                   
                                    db.Branches.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                    db.SaveChanges();
                                    var PtertNewBranch = db.Branches.Where(x => x.MatId == MPtert.Id).ToList();

                                    BLSum = 0;
                                    foreach (var Bl in PtertNewBranch)
                                    {
                                        BLSum += Bl.BL;
                                    }
                                    Model.Branch PluseBPtert = new Model.Branch()
                                    {
                                        MatId = MPtert.Id,
                                        BL = D.CL - BLSum - r8,
                                        BP = r8,
                                        CC = D.NB - MPtert.NB


                                    };
                                    db.Branches.Add(PluseBPtert);
                                    db.SaveChanges();

                                    var RemainBD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                                    foreach (var item3 in RemainBD)
                                    {


                                        Model.BranchOnBranch BOBPtert = new Model.BranchOnBranch()
                                        {
                                            IdBranch = MPtert.Id,
                                            bl = item3.BL,
                                            bp = item3.BP,
                                        };
                                        db.BranchOnBranches.Add(BOBPtert);
                                        db.SaveChanges();
                                        db.Branches.Remove(item3);
                                        db.SaveChanges();

                                    }
                                }


                                db.D.Remove(D);
                                db.SaveChanges();
                                for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                                {
                                    var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                    if (identity != null)
                                    {
                                        identity.IdentityNo = identity.IdentityNo - 1;
                                        db.D.Attach(identity);
                                        db.Entry(identity).State = EntityState.Modified;
                                        db.SaveChanges();
                                    }
                                }
                            }

                        }
                    }
                }
                else
                {
                    var NLCB = db.N.Select(x => x.NLCB).FirstOrDefault();

                    double NLcbret = NLCB.Value + 1;
                    double NPtertret = NPtert.Value - 1;
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NLCB = NLcbret;
                    MatrixN.NPtert = NPtertret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                    int r4 = 0;
                    int rtest4 = 0;
                    int max16 = IdentityNoPtert;
                    if (max16 == 1)
                    {
                        max16 += 1;
                    }
                    do
                    {
                        rtest4 = rnd.Next(0, Convert.ToInt32(max16));
                        if (rtest4 != 0)
                            r4 = rtest4;
                    } while (rtest4 == 0);


                    var Ptert = db.Pterts.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    Model.D MD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = Ptert.CL,
                        NB = Ptert.NB
                    };

                    var BranchesPtert = db.Branches.Where(x => x.MatId == Ptert.Id).ToList();

                    foreach (var item in BranchesPtert)
                    {

                        var BranchOnBranchesPtert = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        item.MatId = MD.Id;
                      

                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in BranchOnBranchesPtert)
                        {
                            item2.IdBranch = item.Id;
                           
                            db.BranchOnBranches.Attach(item2);
                            db.Entry(item2).State = EntityState.Modified;
                            db.SaveChanges();

                        }
                    }

                    db.Pterts.Remove(Ptert);
                    db.SaveChanges();
                    for (int ii = Ptert.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                    {
                        var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Pterts.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    var BPCounter = 0;
                    int i = 0;
                    foreach (var item in BranchesD)
                    {
                        if (r8 == item.BP)
                        {
                            i += 1;
                        }
                    }
                    foreach (var item in BranchesD)
                    {


                        if (r8 != item.BP)
                        {
                            double NPsecret = NPsec.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                            }
                            Model.Psec MPsec = new Model.Psec()
                            {
                                IdentityNo = IdentityNoPsec + 1,
                                CL = D.CL,
                                NB = BPCounter + 1
                            };
                            db.Psecs.Add(MPsec);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {
                                item.MatId = MPsec.Id;
                              
                                db.Branches.Attach(item);
                                db.Entry(item).State = EntityState.Modified;
                                db.SaveChanges();
                                var PsecNewBranch = db.Branches.Where(x => x.MatId == MPsec.Id).ToList();

                                BLSum = 0;
                                foreach (var Bl in PsecNewBranch)
                                {
                                    BLSum += Bl.BL;
                                }
                                Model.Branch PluseBPsec = new Model.Branch()
                                {
                                    MatId = MPsec.Id,
                                    BL = D.CL - BLSum - r8,
                                    BP = r8,
                                    CC = D.NB - MPsec.NB


                                };
                                db.Branches.Add(PluseBPsec);
                                db.SaveChanges();

                                var RemainBD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                                foreach (var item3 in RemainBD)
                                {


                                    Model.BranchOnBranch BOBPsec = new Model.BranchOnBranch()
                                    {
                                        IdBranch = MPsec.Id,
                                        bl = item3.BL,
                                        bp = item3.BP,
                                    };
                                    db.BranchOnBranches.Add(BOBPsec);
                                    db.SaveChanges();
                                    db.Branches.Remove(item3);
                                    db.SaveChanges();

                                }
                            }


                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }
                        }
                        else if (i == 1)
                        {
                            NPtertret = NPtert.Value + 1;
                            if (r8 == item.BP)
                            {
                                if (item.BP <= r8)
                                {
                                    BPCounter += 1;
                                }
                                Model.Ptert MPtert = new Model.Ptert()
                                {
                                    IdentityNo = IdentityNoPtert + 1,
                                    CL = D.CL,
                                    NB = BPCounter + 1
                                };
                                db.Pterts.Add(MPtert);
                                db.SaveChanges();

                                if (D.NB <= BPCounter)
                                {
                                    item.MatId = MPtert.Id;
                                 
                                    db.Branches.Attach(item);
                                    db.Entry(item).State = EntityState.Modified;
                                    db.SaveChanges();
                                    var PtertNewBranch = db.Branches.Where(x => x.MatId == MPtert.Id).ToList();

                                    BLSum = 0;
                                    foreach (var Bl in PtertNewBranch)
                                    {
                                        BLSum += Bl.BL;
                                    }
                                    Model.Branch PluseBPtert = new Model.Branch()
                                    {
                                        MatId = MPtert.Id,
                                        BL = D.CL - BLSum - r8,
                                        BP = r8,
                                        CC = D.NB - MPtert.NB


                                    };
                                    db.Branches.Add(PluseBPtert);
                                    db.SaveChanges();

                                    var RemainBD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                                    foreach (var item3 in RemainBD)
                                    {


                                        Model.BranchOnBranch BOBPtert = new Model.BranchOnBranch()
                                        {
                                            IdBranch = MPtert.Id,
                                            bl = item3.BL,
                                            bp = item3.BP,
                                        };
                                        db.BranchOnBranches.Add(BOBPtert);
                                        db.SaveChanges();
                                        db.Branches.Remove(item3);
                                        db.SaveChanges();

                                    }
                                }


                                db.D.Remove(D);
                                db.SaveChanges();
                                for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                                {
                                    var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                    if (identity != null)
                                    {
                                        identity.IdentityNo = identity.IdentityNo - 1;
                                        db.D.Attach(identity);
                                        db.Entry(identity).State = EntityState.Modified;
                                        db.SaveChanges();
                                    }
                                }
                            }

                        }
                    }



                }

            }
            if (Num == 9)
            {
                Random rnd = new Random();
                int r7 = 0;
                int rtest7 = 0;
                int max17 = IdentityNoD;
                if (max17 == 1)
                {
                    max17 += 1;
                }
                do
                {
                    rtest7 = rnd.Next(0, Convert.ToInt32(max17));
                    if (rtest7 != 0)
                        r7 = rtest7;
                } while (rtest7 == 0);

                var D = db.D.Where(x => x.IdentityNo == r7).FirstOrDefault();
                //BL,BP branches D     
                var BLSum = 0;
                var BranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                foreach (var item in BranchesD)
                {
                    BLSum += item.BL;
                }
                int r8 = 0;
                int rtest8 = 0;
                int max18 = (D.CL - BLSum);
                if (max18 == 1)
                {
                    max18 += 1;
                }
                do
                {
                    rtest8 = rnd.Next(0, max18);
                    if (rtest8 != 0)
                        r8 = rtest8;
                } while (rtest8 == 0);

                int r3 = 0;
                int rtest = 0;
                int max19 = (Int32)Ntotal;
                if (max19 == 1)
                {
                    max19 += 1;
                }
                do
                {
                    rtest = rnd.Next(0, Convert.ToInt32(max19));
                    if (rtest != 0)
                        r3 = rtest;
                } while (rtest == 0);

                if (r3 > 0 && r3 <= NP)
                {
                    var NLcb = db.N.Select(x => x.NLCB).FirstOrDefault();
                    var NDprime = db.N.Select(x => x.NDprime).FirstOrDefault();
                    double NLcbret = NLcb.Value + 1;
                    double NPret = NP.Value - 1;
                    double NDprimeret = NDprime.Value + 1;

                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NLCB = NLcbret;
                    MatrixN.NP = NPret;
                    MatrixN.NDprime = NDprimeret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                    int r4 = 0;
                    int rtest4 = 0;
                    int max20 = IdentityNoP;
                    if (max20 == 1)
                    {
                        max20 += 1;
                    }
                    do
                    {
                        rtest4 = rnd.Next(0, Convert.ToInt32(max20));
                        if (rtest4 != 0)
                            r4 = rtest4;
                    } while (rtest4 == 0);


                    var P = db.P.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    Model.D MD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = P.CL,
                        NB = P.NB
                    };
                    db.D.Add(MD);
                    db.SaveChanges();
                    var BranchesP = db.Branches.Where(x => x.MatId == P.Id).ToList();

                    foreach (var item in BranchesP)
                    {

                        var BranchOnBranchesP = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC

                        };

                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in BranchOnBranchesP)
                        {
                            Model.BranchOnBranch BoBD = new Model.BranchOnBranch()
                            {
                                IdBranch = BD.Id,
                                bl = item2.bl,
                                bp = item2.bp
                            };
                            db.BranchOnBranches.Attach(BoBD);
                            db.Entry(BoBD).State = EntityState.Modified;
                            db.SaveChanges();

                        }
                    }

                    db.P.Remove(P);
                    db.SaveChanges();
                    for (int ii = P.IdentityNo; ii <= db.P.Count() + 1; ii++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    var BPCounter = 0;
                    var SumCL = 0;
                    int i = 0;
                    foreach (var item in BranchesD)
                    {
                        if (r8 == item.BP)
                        {
                            i += 1;
                        }
                    }
                    foreach (var item in BranchesD)
                    {

                        if (i == 1)
                        {
                            double NPsecret = NPsec.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                                SumCL += item.BL;
                            }

                            Model.Psec MPsec = new Model.Psec()
                            {
                                IdentityNo = IdentityNoPsec + 1,
                                CL = SumCL + r8,
                                NB = BPCounter + 1
                            };
                            db.Psecs.Add(MPsec);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {

                                Model.Branch BPsec = new Model.Branch()
                                {
                                    MatId = MPsec.Id,
                                    BL = item.BL,
                                    BP = item.BP,
                                    CC = item.CC


                                };

                                db.Branches.Attach(BPsec);
                                db.Entry(BPsec).State = EntityState.Modified;
                                db.SaveChanges();
                                var PsecNewBranch = db.Branches.Where(x => x.MatId == MPsec.Id).ToList();


                            }


                            Model.Dprime MDprime = new Model.Dprime()
                            {
                                IdentityNo = IdentityNoDprime + 1,
                                CL = D.CL - MPsec.CL,
                                NB = D.NB - MPsec.NB
                            };
                            db.Dprimes.Add(MDprime);
                            db.SaveChanges();
                            var RemainBranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                            foreach (var item4 in RemainBranchesD)
                            {
                                Model.Branch BDprime = new Model.Branch()
                                {
                                    MatId = MDprime.Id,
                                    BP = item4.BP,
                                    BL = item4.BL,
                                    CC = item4.CC
                                };
                                db.Branches.Attach(BDprime);
                                db.Entry(BDprime).State = EntityState.Modified;
                                db.SaveChanges();


                            }

                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }


                            Model.Branch BnewPsec = new Model.Branch()
                            {
                                MatId = MPsec.Id,
                                BL = r8,
                                BP = 1,
                                CC = 0


                            };
                            db.Branches.Add(BnewPsec);
                            db.SaveChanges();
                            if (BnewPsec.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = BnewPsec.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }

                        }

                        else if (i == 2)
                        {
                            double NPtertret = NPtert.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                                SumCL += item.BL;
                            }

                            Model.Ptert MPtert = new Model.Ptert()
                            {
                                IdentityNo = IdentityNoPtert + 1,
                                CL = SumCL + r8,
                                NB = BPCounter + 1
                            };
                            db.Pterts.Add(MPtert);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {

                                Model.Branch BPtert = new Model.Branch()
                                {
                                    MatId = MPtert.Id,
                                    BL = item.BL,
                                    BP = item.BP,
                                    CC = item.CC


                                };

                                db.Branches.Attach(BPtert);
                                db.Entry(BPtert).State = EntityState.Modified;
                                db.SaveChanges();
                                var PtertNewBranch = db.Branches.Where(x => x.MatId == MPtert.Id).ToList();


                            }


                            Model.Dprime MDprime = new Model.Dprime()
                            {
                                IdentityNo = IdentityNoDprime + 1,
                                CL = D.CL - MPtert.CL,
                                NB = D.NB - MPtert.NB
                            };
                            db.Dprimes.Add(MDprime);
                            db.SaveChanges();
                            var RemainBranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                            foreach (var item4 in RemainBranchesD)
                            {
                                Model.Branch BDprime = new Model.Branch()
                                {
                                    MatId = MDprime.Id,
                                    BP = item4.BP,
                                    BL = item4.BL,
                                    CC = item4.CC
                                };
                                db.Branches.Attach(BDprime);
                                db.Entry(BDprime).State = EntityState.Modified;
                                db.SaveChanges();


                            }

                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }


                            Model.Branch BnewPtert = new Model.Branch()
                            {
                                MatId = MPtert.Id,
                                BL = r8,
                                BP = 1,
                                CC = 0


                            };
                            db.Branches.Add(BnewPtert);
                            db.SaveChanges();
                            if (BnewPtert.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = BnewPtert.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }

                        }

                        else if (i == 0)
                        {
                            NPret = NP.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                                SumCL += item.BL;
                            }

                            Model.P MP = new Model.P()
                            {
                                IdentityNo = IdentityNoP + 1,
                                CL = SumCL + r8,
                                NB = BPCounter + 1
                            };
                            db.P.Add(MP);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {

                                Model.Branch BP = new Model.Branch()
                                {
                                    MatId = MP.Id,
                                    BL = item.BL,
                                    BP = item.BP,
                                    CC = item.CC


                                };

                                db.Branches.Attach(BP);
                                db.Entry(BP).State = EntityState.Modified;
                                db.SaveChanges();
                                var PNewBranch = db.Branches.Where(x => x.MatId == MP.Id).ToList();


                            }


                            Model.Dprime MDprime = new Model.Dprime()
                            {
                                IdentityNo = IdentityNoDprime + 1,
                                CL = D.CL - MP.CL,
                                NB = D.NB - MP.NB
                            };
                            db.Dprimes.Add(MDprime);
                            db.SaveChanges();
                            var RemainBranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                            foreach (var item4 in RemainBranchesD)
                            {
                                Model.Branch BDprime = new Model.Branch()
                                {
                                    MatId = MDprime.Id,
                                    BP = item4.BP,
                                    BL = item4.BL,
                                    CC = item4.CC
                                };
                                db.Branches.Attach(BDprime);
                                db.Entry(BDprime).State = EntityState.Modified;
                                db.SaveChanges();


                            }

                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }


                            Model.Branch BnewP = new Model.Branch()
                            {
                                MatId = MP.Id,
                                BL = r8,
                                BP = 1,
                                CC = 0


                            };
                            db.Branches.Add(BnewP);
                            db.SaveChanges();
                            if (BnewP.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = BnewP.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }

                        }
                    }
                }
                else if (r3 > NP && r3 <= NP + NPsec)
                {
                    var NLCB = db.N.Select(x => x.NLCB).FirstOrDefault();
                    double NLcbret = NLCB.Value + 1;
                    double NPsecret = NPsec.Value - 1;
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NLCB = NLcbret;
                    MatrixN.NPsec = NPsecret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                    int r4 = 0;
                    int rtest4 = 0;
                    int max21 = IdentityNoPsec;
                    if (max21 == 1)
                    {
                        max21 += 1;
                    }
                    do
                    {
                        rtest4 = rnd.Next(0, Convert.ToInt32(max21));
                        if (rtest4 != 0)
                            r4 = rtest4;
                    } while (rtest4 == 0);

                    var Psec = db.Psecs.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    Model.D MD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = Psec.CL,
                        NB = Psec.NB
                    };

                    var BranchesPsec = db.Branches.Where(x => x.MatId == Psec.Id).ToList();

                    foreach (var item in BranchesPsec)
                    {

                        var BranchOnBranchesPsec = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC

                        };

                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in BranchOnBranchesPsec)
                        {
                            Model.BranchOnBranch BoBD = new Model.BranchOnBranch()
                            {
                                IdBranch = BD.Id,
                                bl = item2.bl,
                                bp = item2.bp
                            };
                            db.BranchOnBranches.Attach(BoBD);
                            db.Entry(BoBD).State = EntityState.Modified;
                            db.SaveChanges();

                        }
                    }

                    db.Psecs.Remove(Psec);
                    db.SaveChanges();
                    for (int ii = Psec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    var BPCounter = 0;
                    var SumCL = 0;
                    int i = 0;
                    foreach (var item in BranchesD)
                    {
                        if (r8 == item.BP)
                        {
                            i += 1;
                        }
                    }
                    foreach (var item in BranchesD)
                    {

                        if (i == 1)
                        {
                            NPsecret = NPsec.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                                SumCL += item.BL;
                            }

                            Model.Psec MPsec = new Model.Psec()
                            {
                                IdentityNo = IdentityNoPsec + 1,
                                CL = SumCL + r8,
                                NB = BPCounter + 1
                            };
                            db.Psecs.Add(MPsec);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {

                                Model.Branch BPsec = new Model.Branch()
                                {
                                    MatId = MPsec.Id,
                                    BL = item.BL,
                                    BP = item.BP,
                                    CC = item.CC


                                };

                                db.Branches.Attach(BPsec);
                                db.Entry(BPsec).State = EntityState.Modified;
                                db.SaveChanges();
                                var PsecNewBranch = db.Branches.Where(x => x.MatId == MPsec.Id).ToList();


                            }


                            Model.Dprime MDprime = new Model.Dprime()
                            {
                                IdentityNo = IdentityNoDprime + 1,
                                CL = D.CL - MPsec.CL,
                                NB = D.NB - MPsec.NB
                            };
                            db.Dprimes.Add(MDprime);
                            db.SaveChanges();
                            var RemainBranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                            foreach (var item4 in RemainBranchesD)
                            {
                                Model.Branch BDprime = new Model.Branch()
                                {
                                    MatId = MDprime.Id,
                                    BP = item4.BP,
                                    BL = item4.BL,
                                    CC = item4.CC
                                };
                                db.Branches.Attach(BDprime);
                                db.Entry(BDprime).State = EntityState.Modified;
                                db.SaveChanges();


                            }

                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }

                            Model.Branch BnewPsec = new Model.Branch()
                            {
                                MatId = MPsec.Id,
                                BL = r8,
                                BP = 1,
                                CC = 0


                            };
                            db.Branches.Add(BnewPsec);
                            db.SaveChanges();
                            if (BnewPsec.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = BnewPsec.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }


                        }

                        else if (i == 2)
                        {
                            double NPtertret = NPtert.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                                SumCL += item.BL;
                            }

                            Model.Ptert MPtert = new Model.Ptert()
                            {
                                IdentityNo = IdentityNoPtert + 1,
                                CL = SumCL + r8,
                                NB = BPCounter + 1
                            };
                            db.Pterts.Add(MPtert);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {

                                Model.Branch BPtert = new Model.Branch()
                                {
                                    MatId = MPtert.Id,
                                    BL = item.BL,
                                    BP = item.BP,
                                    CC = item.CC


                                };

                                db.Branches.Attach(BPtert);
                                db.Entry(BPtert).State = EntityState.Modified;
                                db.SaveChanges();
                                var PtertNewBranch = db.Branches.Where(x => x.MatId == MPtert.Id).ToList();


                            }


                            Model.Dprime MDprime = new Model.Dprime()
                            {
                                IdentityNo = IdentityNoDprime + 1,
                                CL = D.CL - MPtert.CL,
                                NB = D.NB - MPtert.NB
                            };
                            db.Dprimes.Add(MDprime);
                            db.SaveChanges();
                            var RemainBranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                            foreach (var item4 in RemainBranchesD)
                            {
                                Model.Branch BDprime = new Model.Branch()
                                {
                                    MatId = MDprime.Id,
                                    BP = item4.BP,
                                    BL = item4.BL,
                                    CC = item4.CC
                                };
                                db.Branches.Attach(BDprime);
                                db.Entry(BDprime).State = EntityState.Modified;
                                db.SaveChanges();


                            }

                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }

                            Model.Branch BnewPtert = new Model.Branch()
                            {
                                MatId = MPtert.Id,
                                BL = r8,
                                BP = 1,
                                CC = 0


                            };
                            db.Branches.Add(BnewPtert);
                            db.SaveChanges();
                            if (BnewPtert.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = BnewPtert.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }

                        }

                        else if (i == 0)
                        {
                            var NPret = NP.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                                SumCL += item.BL;
                            }

                            Model.P MP = new Model.P()
                            {
                                IdentityNo = IdentityNoP + 1,
                                CL = SumCL + r8,
                                NB = BPCounter + 1
                            };
                            db.P.Add(MP);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {

                                Model.Branch BP = new Model.Branch()
                                {
                                    MatId = MP.Id,
                                    BL = item.BL,
                                    BP = item.BP,
                                    CC = item.CC


                                };

                                db.Branches.Attach(BP);
                                db.Entry(BP).State = EntityState.Modified;
                                db.SaveChanges();
                                var PNewBranch = db.Branches.Where(x => x.MatId == MP.Id).ToList();


                            }


                            Model.Dprime MDprime = new Model.Dprime()
                            {
                                IdentityNo = IdentityNoDprime + 1,
                                CL = D.CL - MP.CL,
                                NB = D.NB - MP.NB
                            };
                            db.Dprimes.Add(MDprime);
                            db.SaveChanges();
                            var RemainBranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                            foreach (var item4 in RemainBranchesD)
                            {
                                Model.Branch BDprime = new Model.Branch()
                                {
                                    MatId = MDprime.Id,
                                    BP = item4.BP,
                                    BL = item4.BL,
                                    CC = item4.CC
                                };
                                db.Branches.Attach(BDprime);
                                db.Entry(BDprime).State = EntityState.Modified;
                                db.SaveChanges();


                            }

                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }

                            Model.Branch BnewP = new Model.Branch()
                            {
                                MatId = MP.Id,
                                BL = r8,
                                BP = 1,
                                CC = 0


                            };
                            db.Branches.Add(BnewP);
                            db.SaveChanges();
                            if (BnewP.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = BnewP.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }

                        }
                    }
                }
                else
                {
                    var NLCB = db.N.Select(x => x.NLCB).FirstOrDefault();

                    double NLcbret = NLCB.Value + 1;
                    double NPtertret = NPtert.Value - 1;
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.NLCB = NLcbret;
                    MatrixN.NPtert = NPtertret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                    int r4 = 0;
                    int rtest4 = 0;
                    int max22 = IdentityNoPtert;
                    if (max22 == 1)
                    {
                        max22 += 1;
                    }
                    do
                    {
                        rtest4 = rnd.Next(0, Convert.ToInt32(max22));
                        if (rtest4 != 0)
                            r4 = rtest4;
                    } while (rtest4 == 0);

                    var Ptert = db.Pterts.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    Model.D MD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = Ptert.CL,
                        NB = Ptert.NB
                    };

                    var BranchesPtert = db.Branches.Where(x => x.MatId == Ptert.Id).ToList();

                    foreach (var item in BranchesPtert)
                    {

                        var BranchOnBranchesPtert = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC

                        };

                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in BranchOnBranchesPtert)
                        {
                            Model.BranchOnBranch BoBD = new Model.BranchOnBranch()
                            {
                                IdBranch = BD.Id,
                                bl = item2.bl,
                                bp = item2.bp
                            };
                            db.BranchOnBranches.Attach(BoBD);
                            db.Entry(BoBD).State = EntityState.Modified;
                            db.SaveChanges();

                        }
                    }

                    db.Pterts.Remove(Ptert);
                    db.SaveChanges();
                    for (int ii = Ptert.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                    {
                        var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Pterts.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    var BPCounter = 0;
                    var SumCL = 0;
                    int i = 0;
                    foreach (var item in BranchesD)
                    {
                        if (r8 == item.BP)
                        {
                            i += 1;
                        }
                    }
                    foreach (var item in BranchesD)
                    {

                        if (i == 1)
                        {
                            double NPsecret = NPsec.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                                SumCL += item.BL;
                            }

                            Model.Psec MPsec = new Model.Psec()
                            {
                                IdentityNo = IdentityNoPsec + 1,
                                CL = SumCL + r8,
                                NB = BPCounter + 1
                            };
                            db.Psecs.Add(MPsec);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {

                                Model.Branch BPsec = new Model.Branch()
                                {
                                    MatId = MPsec.Id,
                                    BL = item.BL,
                                    BP = item.BP,
                                    CC = item.CC


                                };

                                db.Branches.Attach(BPsec);
                                db.Entry(BPsec).State = EntityState.Modified;
                                db.SaveChanges();
                                var PsecNewBranch = db.Branches.Where(x => x.MatId == MPsec.Id).ToList();


                            }


                            Model.Dprime MDprime = new Model.Dprime()
                            {
                                IdentityNo = IdentityNoDprime + 1,
                                CL = D.CL - MPsec.CL,
                                NB = D.NB - MPsec.NB
                            };
                            db.Dprimes.Add(MDprime);
                            db.SaveChanges();
                            var RemainBranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                            foreach (var item4 in RemainBranchesD)
                            {
                                Model.Branch BDprime = new Model.Branch()
                                {
                                    MatId = MDprime.Id,
                                    BP = item4.BP,
                                    BL = item4.BL,
                                    CC = item4.CC
                                };
                                db.Branches.Attach(BDprime);
                                db.Entry(BDprime).State = EntityState.Modified;
                                db.SaveChanges();


                            }

                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }

                            Model.Branch BnewPsec = new Model.Branch()
                            {
                                MatId = MPsec.Id,
                                BL = r8,
                                BP = 1,
                                CC = 0


                            };
                            db.Branches.Add(BnewPsec);
                            db.SaveChanges();
                            if (BnewPsec.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = BnewPsec.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }


                        }

                        else if (i == 2)
                        {
                            NPtertret = NPtert.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                                SumCL += item.BL;
                            }

                            Model.Ptert MPtert = new Model.Ptert()
                            {
                                IdentityNo = IdentityNoPtert + 1,
                                CL = SumCL + r8,
                                NB = BPCounter + 1
                            };
                            db.Pterts.Add(MPtert);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {

                                Model.Branch BPtert = new Model.Branch()
                                {
                                    MatId = MPtert.Id,
                                    BL = item.BL,
                                    BP = item.BP,
                                    CC = item.CC


                                };

                                db.Branches.Attach(BPtert);
                                db.Entry(BPtert).State = EntityState.Modified;
                                db.SaveChanges();
                                var PtertNewBranch = db.Branches.Where(x => x.MatId == MPtert.Id).ToList();


                            }


                            Model.Dprime MDprime = new Model.Dprime()
                            {
                                IdentityNo = IdentityNoDprime + 1,
                                CL = D.CL - MPtert.CL,
                                NB = D.NB - MPtert.NB
                            };
                            db.Dprimes.Add(MDprime);
                            db.SaveChanges();
                            var RemainBranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                            foreach (var item4 in RemainBranchesD)
                            {
                                Model.Branch BDprime = new Model.Branch()
                                {
                                    MatId = MDprime.Id,
                                    BP = item4.BP,
                                    BL = item4.BL,
                                    CC = item4.CC
                                };
                                db.Branches.Attach(BDprime);
                                db.Entry(BDprime).State = EntityState.Modified;
                                db.SaveChanges();


                            }

                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }

                            Model.Branch BnewPtert = new Model.Branch()
                            {
                                MatId = MPtert.Id,
                                BL = r8,
                                BP = 1,
                                CC = 0


                            };
                            db.Branches.Add(BnewPtert);
                            db.SaveChanges();
                            if (BnewPtert.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = BnewPtert.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }

                        }

                        else if (i == 0)
                        {
                            var NPret = NP.Value + 1;
                            if (item.BP <= r8)
                            {
                                BPCounter += 1;
                                SumCL += item.BL;
                            }

                            Model.P MP = new Model.P()
                            {
                                IdentityNo = IdentityNoP + 1,
                                CL = SumCL + r8,
                                NB = BPCounter + 1
                            };
                            db.P.Add(MP);
                            db.SaveChanges();

                            if (D.NB <= BPCounter)
                            {

                                Model.Branch BP = new Model.Branch()
                                {
                                    MatId = MP.Id,
                                    BL = item.BL,
                                    BP = item.BP,
                                    CC = item.CC


                                };

                                db.Branches.Attach(BP);
                                db.Entry(BP).State = EntityState.Modified;
                                db.SaveChanges();
                                var PNewBranch = db.Branches.Where(x => x.MatId == MP.Id).ToList();


                            }


                            Model.Dprime MDprime = new Model.Dprime()
                            {
                                IdentityNo = IdentityNoDprime + 1,
                                CL = D.CL - MP.CL,
                                NB = D.NB - MP.NB
                            };
                            db.Dprimes.Add(MDprime);
                            db.SaveChanges();
                            var RemainBranchesD = db.Branches.Where(x => x.MatId == D.Id).ToList();
                            foreach (var item4 in RemainBranchesD)
                            {
                                Model.Branch BDprime = new Model.Branch()
                                {
                                    MatId = MDprime.Id,
                                    BP = item4.BP,
                                    BL = item4.BL,
                                    CC = item4.CC
                                };
                                db.Branches.Attach(BDprime);
                                db.Entry(BDprime).State = EntityState.Modified;
                                db.SaveChanges();


                            }

                            db.D.Remove(D);
                            db.SaveChanges();
                            for (int ii = D.IdentityNo; ii <= db.D.Count(); ii++)
                            {
                                var identity = db.D.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.D.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }

                            Model.Branch BnewP = new Model.Branch()
                            {
                                MatId = MP.Id,
                                BL = r8,
                                BP = 1,
                                CC = 0


                            };
                            db.Branches.Add(BnewP);
                            db.SaveChanges();
                            if (BnewP.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = BnewP.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }


                        }
                    }

                }

            }
            if (Num == 10)
            {


                Random rnd = new Random();
                int r4 = 0;
                int rtest4 = 0;
                int max23 = (Int32)(NP + NPsec);
                if (max23 == 1)
                { max23 += 1; }
                do
                {
                    rtest4 = rnd.Next(0, Convert.ToInt32(max23));
                    if (rtest4 != 0)
                        r4 = rtest4;
                } while (rtest4 == 0);


                if (r4 > 0 && r4 <= NP)
                {
                    int r5 = 0;
                    int rtest5 = 0;
                    int max24 = IdentityNoP;
                    if (max24 == 1)
                    {
                        max24 += 1;
                    }
                    do
                    {
                        rtest5 = rnd.Next(0, Convert.ToInt32(max24));
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);

                    int r7 = 0;
                    int rtest7 = 0;
                    int max25 = IdentityNoDprime;
                    if (max25 == 1)
                    {
                        max25 += 1;
                    }
                    do
                    {
                        rtest7 = rnd.Next(0, Convert.ToInt32(max25));
                        if (rtest7 != 0)
                            r7 = rtest7;
                    } while (rtest7 == 0);

                    var MatrixP = db.P.Where(x => x.IdentityNo == r5).FirstOrDefault();
                    var MatrixDprime = db.Dprimes.Where(x => x.IdentityNo == r7).FirstOrDefault();
                    var BranchP = db.Branches.Where(x => x.MatId == MatrixP.Id).ToList();
                    var BranchDprime = db.Branches.Where(x => x.MatId == MatrixDprime.Id).ToList();
                    int i = 0;
                    int SumBL = 0;
                    foreach (var item in BranchP)
                    {
                        SumBL += item.BL;
                    }
                    foreach (var item in BranchP)
                    {

                        if (MatrixP.CL - SumBL == item.BP)
                            i += 1;


                    }
                    if (i <= 2)
                    {

                        Model.Psec MatrixPsec = new Model.Psec()
                        {
                            IdentityNo = IdentityNoPsec + 1,
                            CL = MatrixP.CL + MatrixDprime.CL,
                            NB = MatrixP.NB + 1
                        };
                        var BLSum = 0;
                        foreach (var item in BranchP)
                        {
                            BLSum += item.BL;
                            var BranchOfBranchesP = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                            Model.Branch Bp = new Model.Branch()
                            {
                                MatId = MatrixPsec.Id,
                                BP = item.BP,
                                CC = item.CC,
                                BL = item.BL
                            };
                            db.Branches.Attach(Bp);
                            db.Entry(Bp).State = EntityState.Modified;
                            db.SaveChanges();
                            foreach (var item2 in BranchOfBranchesP)
                            {


                                Model.BranchOnBranch BOBp = new Model.BranchOnBranch()
                                {
                                    IdBranch = Bp.Id,
                                    bl = item2.bl,
                                    bp = item2.bp
                                };
                                db.BranchOnBranches.Attach(BOBp);
                                db.Entry(BOBp).State = EntityState.Modified;
                                db.SaveChanges();

                            }
                        }
                        Model.Branch NewBPsec = new Model.Branch()
                        {
                            MatId = MatrixPsec.Id,
                            BP = MatrixP.CL - BLSum,
                            BL = MatrixDprime.CL,
                            CC = MatrixDprime.NB
                        };
                        db.Branches.Add(NewBPsec);
                        db.SaveChanges();
                        foreach (var item in BranchDprime)
                        {
                            Model.BranchOnBranch BOBnewPsec = new Model.BranchOnBranch()
                            {
                                IdBranch = NewBPsec.Id,
                                bp = item.BP,
                                bl = item.BL
                            };
                            db.Branches.Remove(item);
                            db.SaveChanges();
                            db.BranchOnBranches.Add(BOBnewPsec);
                            db.SaveChanges();
                            db.P.Remove(MatrixP);
                            db.SaveChanges();
                            for (int ii = MatrixP.IdentityNo; ii <= db.P.Count() + 1; ii++)
                            {
                                var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.P.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }
                            db.Dprimes.Remove(MatrixDprime);
                            db.SaveChanges();
                            for (int ii = MatrixDprime.IdentityNo; ii <= db.Dprimes.Count(); ii++)
                            {
                                var identity = db.Dprimes.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.Dprimes.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }
                        }

                        var NLcb = db.N.Select(x => x.NLCB).FirstOrDefault();
                        var NDPrime = db.N.Select(x => x.NDprime).FirstOrDefault();
                        double NLcbret = NLcb.Value + 1;
                        double NPret = NP.Value - 1;
                        double NDPrimeret = NDPrime.Value - 1;
                        double NpsecRet = NPsec.Value + 1;

                        var MatrixN = db.N.FirstOrDefault();
                        MatrixN.NLCB = NLcbret;
                        MatrixN.NP = NPret;
                        MatrixN.NDprime = NDPrimeret;
                        MatrixN.NPsec = NpsecRet;
                        db.N.Attach(MatrixN);
                        db.Entry(MatrixN).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                }
                else
                {
                    int r5 = 0;
                    int rtest5 = 0;
                    int max26 = IdentityNoPsec;
                    if (max26 == 1)
                    {
                        max26 += 1;
                    }
                    do
                    {
                        rtest5 = rnd.Next(0, Convert.ToInt32(max26));
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);

                    int r7 = 0;
                    int rtest7 = 0;
                    int max27 = IdentityNoDprime;
                    if (max27 == 1)
                    {
                        max27 += 1;

                    }
                    do
                    {
                        rtest7 = rnd.Next(0, Convert.ToInt32(max27));
                        if (rtest7 != 0)
                            r7 = rtest7;
                    } while (rtest7 == 0);

                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r5).FirstOrDefault();
                    var MatrixDprime = db.Dprimes.Where(x => x.IdentityNo == r7).FirstOrDefault();
                    var BranchPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();
                    var BranchDprime = db.Branches.Where(x => x.MatId == MatrixDprime.Id).ToList();
                    int i = 0;

                    var BLSum = 0;
                    foreach (var item in BranchPsec)
                    {
                        BLSum += item.BL;
                    }
                    foreach (var item2 in BranchPsec)
                    {
                        if (MatrixPsec.CL - BLSum == item2.BP)
                            i += 1;
                    }

                    if (i <= 2)
                    {
                        Model.Ptert MatrixPtert = new Model.Ptert()
                        {
                            IdentityNo = IdentityNoPtert + 1,
                            CL = MatrixPsec.CL + MatrixDprime.CL,
                            NB = MatrixPsec.NB + 1
                        };
                        foreach (var item in BranchPsec)
                        {
                            var BranchOfBranchesP = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                            Model.Branch Bp = new Model.Branch()
                            {
                                MatId = MatrixPtert.Id,
                                BP = item.BP,
                                CC = item.CC,
                                BL = item.BL
                            };
                            db.Branches.Attach(Bp);
                            db.Entry(Bp).State = EntityState.Modified;
                            db.SaveChanges();
                            foreach (var item2 in BranchOfBranchesP)
                            {


                                Model.BranchOnBranch BOBp = new Model.BranchOnBranch()
                                {
                                    IdBranch = Bp.Id,
                                    bl = item2.bl,
                                    bp = item2.bp
                                };
                                db.BranchOnBranches.Attach(BOBp);
                                db.Entry(BOBp).State = EntityState.Modified;
                                db.SaveChanges();

                            }
                        }
                        Model.Branch NewBPtert = new Model.Branch()
                        {
                            MatId = MatrixPtert.Id,
                            BP = MatrixPsec.CL - BLSum,
                            BL = MatrixDprime.CL,
                            CC = MatrixDprime.NB
                        };
                        db.Branches.Add(NewBPtert);
                        db.SaveChanges();
                        foreach (var item in BranchDprime)
                        {
                            Model.BranchOnBranch BOBnewPtert = new Model.BranchOnBranch()
                            {
                                IdBranch = NewBPtert.Id,
                                bp = item.BP,
                                bl = item.BL
                            };
                            db.Branches.Remove(item);
                            db.SaveChanges();
                            db.BranchOnBranches.Add(BOBnewPtert);
                            db.SaveChanges();
                            db.Psecs.Remove(MatrixPsec);
                            db.SaveChanges();
                            for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                            {
                                var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.Psecs.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }
                            db.Dprimes.Remove(MatrixDprime);
                            db.SaveChanges();
                            for (int ii = MatrixDprime.IdentityNo; ii <= db.Dprimes.Count(); ii++)
                            {
                                var identity = db.Dprimes.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.Dprimes.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }
                        }




                        var NLcb = db.N.Select(x => x.NLCB).FirstOrDefault();
                        var NDPrime = db.N.Select(x => x.NDprime).FirstOrDefault();
                        double NLcbret = NLcb.Value + 1;
                        double NPsecret = NPsec.Value - 1;
                        double NDPrimeret = NDPrime.Value - 1;
                        double NptertRet = NPtert.Value + 1;


                        var MatrixN = db.N.FirstOrDefault();
                        MatrixN.NLCB = NLcbret;
                        MatrixN.NPsec = NPsecret;
                        MatrixN.NDprime = NDPrimeret;
                        MatrixN.NPtert = NptertRet;
                        db.N.Attach(MatrixN);
                        db.Entry(MatrixN).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                }


            }
            if (Num == 11)
            {
                Random rnd = new Random();
                int r4 = 0;
                int rtest4 = 0;
                int max28 = (Int32)(NP + NPsec);
                if (max28 == 1)
                {
                    max28 += 1;

                }
                do
                {
                    rtest4 = rnd.Next(0, Convert.ToInt32(max28));
                    if (rtest4 != 0)
                        r4 = rtest4;
                } while (rtest4 == 0);




                if (r4 > 0 && r4 <= NP)
                {
                    int r5 = 0;
                    int rtest5 = 0;
                    int max29 = IdentityNoP;
                    if (max29 == 1)
                    {
                        max29 += 1;
                    }
                    do
                    {
                        rtest5 = rnd.Next(0, Convert.ToInt32(max29));
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);

                    var MatrixP = db.P.Where(x => x.IdentityNo == r5).FirstOrDefault();
                    var BMatrixP = db.Branches.Where(x => x.MatId == MatrixP.Id).ToList();
                    var Bl = db.Branches.Where(x => x.MatId == MatrixP.Id).ToList();
                    var SumBl = 0;
                    foreach (var item in Bl)
                    {
                        SumBl += item.BL;
                    }
                    int r6 = 0;
                    int rtest6 = 0;
                    if ((MatrixP.CL - SumBl >= 7))
                    {
                        do
                        {
                            rtest6 = rnd.Next(0, 6);
                            if (rtest6 != 0)
                                r6 = rtest6;
                        } while (rtest6 == 0);
                    }
                    else
                    {
                        do
                        {
                            rtest6 = rnd.Next(0, MatrixP.CL - SumBl);
                            if (rtest6 != 0)
                                r6 = rtest6;
                        } while (rtest6 == 0);
                    }
                    var i = 0;
                    foreach (var item in BMatrixP)
                    {
                        if (item.BP == (MatrixP.CL - r6))
                        {
                            i += 1;
                        }
                    }

                    if (i <= 2)
                    {
                        if (i == 0)
                        {
                            Model.Psec MatrixPsec = new Model.Psec()
                            {
                                IdentityNo = IdentityNoPsec + 1,
                                CL = MatrixP.CL,
                                NB = MatrixP.NB + 1
                            };
                            db.Psecs.Add(MatrixPsec);
                            db.SaveChanges();
                            foreach (var item in BMatrixP)
                            {
                                Model.Branch BMatrixPsec = new Model.Branch()
                                {
                                    MatId = MatrixPsec.Id,
                                    BP = item.BP,
                                    BL = item.BL,
                                    CC = item.CC
                                };
                                db.Branches.Attach(BMatrixPsec);
                                db.Entry(BMatrixPsec).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            Model.Branch NewBPsec = new Model.Branch()
                            {
                                MatId = MatrixPsec.Id,
                                BP = MatrixP.CL - r6,
                                BL = r6,
                                CC = 0
                            };

                            db.Branches.Add(NewBPsec);
                            db.SaveChanges();
                            if (NewBPsec.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = NewBPsec.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }

                            NPsec = NPsec + 1;

                            var MatrixN1 = db.N.FirstOrDefault();
                            MatrixN1.NPsec = NPsec;
                            db.N.Attach(MatrixN1);
                            db.Entry(MatrixN1).State = EntityState.Modified;
                            db.SaveChanges();

                        }

                        else if (i == 1)
                        {
                            Model.Ptert MatrixPtert = new Model.Ptert()
                            {
                                IdentityNo = IdentityNoPtert + 1,
                                CL = MatrixP.CL,
                                NB = MatrixP.NB + 1
                            };
                            db.Pterts.Add(MatrixPtert);
                            db.SaveChanges();
                            foreach (var item in BMatrixP)
                            {
                                Model.Branch BMatrixPtert = new Model.Branch()
                                {
                                    MatId = MatrixPtert.Id,
                                    BP = item.BP,
                                    BL = item.BL,
                                    CC = item.CC
                                };
                                db.Branches.Attach(BMatrixPtert);
                                db.Entry(BMatrixPtert).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            Model.Branch NewBPtert = new Model.Branch()
                            {
                                MatId = MatrixPtert.Id,
                                BP = MatrixP.CL - r6,
                                BL = r6,
                                CC = 0
                            };

                            db.Branches.Add(NewBPtert);
                            db.SaveChanges();
                            if (NewBPtert.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = NewBPtert.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }

                            NPtert = NPtert + 1;

                            var MatrixN1 = db.N.FirstOrDefault();
                            MatrixN1.NPtert = NPtert;
                            db.N.Attach(MatrixN1);
                            db.Entry(MatrixN1).State = EntityState.Modified;
                            db.SaveChanges();

                        }
                        db.P.Remove(MatrixP);
                        db.SaveChanges();
                        for (int ii = MatrixP.IdentityNo; ii <= db.P.Count() + 1; ii++)
                        {
                            var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                            if (identity != null)
                            {
                                identity.IdentityNo = identity.IdentityNo - 1;
                                db.P.Attach(identity);
                                db.Entry(identity).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }

                        var Nscb = db.N.Select(x => x.NSCB).FirstOrDefault();
                        double NScbRet = Nscb.Value + 1;
                        double NPret = NP.Value - 1;

                        var MatrixN = db.N.FirstOrDefault();
                        MatrixN.NSCB = NScbRet;
                        MatrixN.NP = NPret;
                        db.N.Attach(MatrixN);
                        db.Entry(MatrixN).State = EntityState.Modified;
                        db.SaveChanges();

                    }

                }
                else
                {
                    int r5 = 0;
                    int rtest5 = 0;
                    int max30 = IdentityNoPsec;
                    if (max30 == 1)
                    {
                        max30 += 1;
                    }
                    do
                    {
                        rtest5 = rnd.Next(0, Convert.ToInt32(max30));
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);

                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r5).FirstOrDefault();
                    var BMatrixPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();
                    var Bl = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();
                    var SumBl = 0;
                    foreach (var item in Bl)
                    {
                        SumBl += item.BL;
                    }
                    int r6 = 0;
                    int rtest6 = 0;
                    if ((MatrixPsec.CL - SumBl >= 7))
                    {
                        do
                        {
                            rtest6 = rnd.Next(0, 6);
                            if (rtest6 != 0)
                                r6 = rtest6;
                        } while (rtest6 == 0);
                    }
                    else
                    {
                        do
                        {
                            rtest6 = rnd.Next(0, MatrixPsec.CL - SumBl);
                            if (rtest6 != 0)
                                r6 = rtest6;
                        } while (rtest6 == 0);
                    }
                    var i = 0;
                    foreach (var item in BMatrixPsec)
                    {
                        if (item.BP == (MatrixPsec.CL - r6))
                        {
                            i += 1;
                        }
                    }

                    if (i <= 2)
                    {
                        if (i == 0)
                        {
                            Model.Psec MatrixNewPsec = new Model.Psec()
                            {
                                IdentityNo = IdentityNoPsec,
                                CL = MatrixPsec.CL,
                                NB = MatrixPsec.NB + 1
                            };
                            db.Psecs.Add(MatrixNewPsec);
                            db.SaveChanges();
                            foreach (var item in BMatrixPsec)
                            {
                                Model.Branch BMatrixNewPsec = new Model.Branch()
                                {
                                    MatId = MatrixPsec.Id,
                                    BP = item.BP,
                                    BL = item.BL,
                                    CC = item.CC
                                };
                                db.Branches.Attach(BMatrixNewPsec);
                                db.Entry(BMatrixNewPsec).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            Model.Branch NewBPsec = new Model.Branch()
                            {
                                MatId = MatrixPsec.Id,
                                BP = MatrixPsec.CL - r6,
                                BL = r6,
                                CC = 0
                            };

                            db.Branches.Add(NewBPsec);
                            db.SaveChanges();
                            if (NewBPsec.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = NewBPsec.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }

                            NPsec = NPsec + 1;
                            db.Psecs.Remove(MatrixPsec);
                            db.SaveChanges();

                            var MatrixN1 = db.N.FirstOrDefault();
                            MatrixN1.NPsec = NPsec;
                            db.N.Attach(MatrixN1);
                            db.Entry(MatrixN1).State = EntityState.Modified;
                            db.SaveChanges();

                        }
                        else if (i == 1)
                        {
                            Model.Ptert MatrixPtert = new Model.Ptert()
                            {
                                IdentityNo = IdentityNoPtert + 1,
                                CL = MatrixPsec.CL,
                                NB = MatrixPsec.NB + 1
                            };
                            db.Pterts.Add(MatrixPtert);
                            db.SaveChanges();
                            foreach (var item in BMatrixPsec)
                            {
                                Model.Branch BMatrixPtert = new Model.Branch()
                                {
                                    MatId = MatrixPtert.Id,
                                    BP = item.BP,
                                    BL = item.BL,
                                    CC = item.CC
                                };
                                db.Branches.Attach(BMatrixPtert);
                                db.Entry(BMatrixPtert).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            Model.Branch NewBPtert = new Model.Branch()
                            {
                                MatId = MatrixPtert.Id,
                                BP = MatrixPsec.CL - r6,
                                BL = r6,
                                CC = 0
                            };

                            db.Branches.Add(NewBPtert);
                            db.SaveChanges();
                            if (NewBPtert.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = NewBPtert.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }
                            db.Psecs.Remove(MatrixPsec);
                            db.SaveChanges();
                            for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                            {
                                var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                                if (identity != null)
                                {
                                    identity.IdentityNo = identity.IdentityNo - 1;
                                    db.Psecs.Attach(identity);
                                    db.Entry(identity).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }
                            NPtert = NPtert + 1;

                            var MatrixN1 = db.N.FirstOrDefault();
                            MatrixN1.NPtert = NPtert;
                            db.N.Attach(MatrixN1);
                            db.Entry(MatrixN1).State = EntityState.Modified;
                            db.SaveChanges();

                        }


                        var Nscb = db.N.Select(x => x.NSCB).FirstOrDefault();
                        double NScbRet = Nscb.Value + 1;
                        double NPsecret = NPsec.Value - 1;


                        var MatrixN = db.N.FirstOrDefault();
                        MatrixN.NSCB = NScbRet;
                        MatrixN.NPsec = NPsecret;
                        db.N.Attach(MatrixN);
                        db.Entry(MatrixN).State = EntityState.Modified;
                        db.SaveChanges();


                        db.Psecs.Remove(MatrixPsec);
                        db.SaveChanges();
                        for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                        {
                            var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                            if (identity != null)
                            {
                                identity.IdentityNo = identity.IdentityNo - 1;
                                db.Psecs.Attach(identity);
                                db.Entry(identity).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }
                    }
                }

            }
            if (Num == 12)
            {
                Random rnd = new Random();
                int r4 = 0;
                int rtest4 = 0;
                int max31 = IdentityNoPsec;
                if (max31 == 1)
                {
                    max31 += 1;
                }
                do
                {
                    rtest4 = rnd.Next(0, Convert.ToInt32(max31));
                    if (rtest4 != 0)
                        r4 = rtest4;
                } while (rtest4 == 0);


                var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r4).FirstOrDefault();
                var BMatrixPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();
                var BOBMatrixPsec = db.BranchOnBranches.Where(x => x.IdBranch == BMatrixPsec.Last().Id).ToList();
                int r5 = 0;
                int rtest5 = 0;
                do
                {
                    rtest5 = rnd.Next(0, 2);
                    if (rtest5 != 0)
                        r5 = rtest5;
                } while (rtest5 == 0);

                if (r5 == 1)
                {
                    Model.Dprime MatrixDprime = new Model.Dprime()
                    {
                        IdentityNo = IdentityNoDprime + 1,
                        CL = BMatrixPsec.Last().BL + 2,
                        NB = BMatrixPsec.Last().CC
                    };
                    db.Dprimes.Add(MatrixDprime);
                    db.SaveChanges();

                    foreach (var item in BOBMatrixPsec)
                    {


                        Model.Branch BMatrixDprime = new Model.Branch()
                        {
                            MatId = MatrixDprime.Id,
                            BP = item.bp + 2,
                            BL = item.bl,
                            CC = 0
                        };
                        db.Branches.Attach(BMatrixDprime);
                        db.Entry(BMatrixDprime).State = EntityState.Modified;
                        db.SaveChanges();
                        if (BMatrixDprime.CC == 0)
                        {
                            Model.BranchOnBranch bob = new Model.BranchOnBranch()
                            {
                                bl = 0,
                                bp = 0,
                                IdBranch = BMatrixDprime.Id
                            };
                            db.BranchOnBranches.Add(bob);
                            db.SaveChanges();
                        }
                        db.Branches.Remove(BMatrixPsec.Last());
                        db.SaveChanges();

                    }
                    Model.P MatrixP = new Model.P()
                    {
                        IdentityNo = IdentityNoP + 1,
                        CL = MatrixPsec.CL - MatrixDprime.CL,
                        NB = MatrixPsec.NB - 1
                    };
                    db.P.Add(MatrixP);
                    db.SaveChanges();
                    foreach (var item in BMatrixPsec)
                    {
                        var RemainBOBMatrixPsec = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        Model.Branch BMatrixP = new Model.Branch()
                        {
                            MatId = MatrixP.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };
                        db.Branches.Attach(BMatrixP);
                        db.Entry(BMatrixP).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in RemainBOBMatrixPsec)
                        {
                            Model.BranchOnBranch BoBMatrixP = new Model.BranchOnBranch()
                            {
                                IdBranch = item.Id,
                                bl = item2.bl,
                                bp = item2.bp
                            };

                            db.BranchOnBranches.Attach(BoBMatrixP);
                            db.Entry(BoBMatrixP).State = EntityState.Modified;
                            db.SaveChanges();
                        }

                    }

                }
                else
                {
                    Model.P MatrixP = new Model.P()
                    {
                        IdentityNo = IdentityNoP + 1,
                        CL = BMatrixPsec.Last().BL - 1,
                        NB = BMatrixPsec.Last().CC
                    };
                    db.P.Add(MatrixP);
                    db.SaveChanges();
                    foreach (var item in BOBMatrixPsec)
                    {


                        Model.Branch BMatrixP = new Model.Branch()
                        {
                            MatId = MatrixP.Id,
                            BP = item.bp - 1,
                            BL = item.bl,
                            CC = 0
                        };
                        db.Branches.Attach(BMatrixP);
                        db.Entry(BMatrixP).State = EntityState.Modified;
                        db.SaveChanges();
                        if (BMatrixP.CC == 0)
                        {
                            Model.BranchOnBranch bob = new Model.BranchOnBranch()
                            {
                                bl = 0,
                                bp = 0,
                                IdBranch = BMatrixP.Id
                            };
                            db.BranchOnBranches.Add(bob);
                            db.SaveChanges();
                        }
                        db.Branches.Remove(BMatrixPsec.Last());
                        db.SaveChanges();

                    }
                    Model.Dprime MatrixDprime = new Model.Dprime()
                    {
                        IdentityNo = IdentityNoDprime + 1,
                        CL = MatrixPsec.CL - MatrixP.CL,
                        NB = MatrixPsec.NB - 1
                    };
                    db.Dprimes.Add(MatrixDprime);
                    db.SaveChanges();
                    foreach (var item in BMatrixPsec)
                    {
                        var RemainBOBMatrixPsec = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        Model.Branch BMatrixDprime = new Model.Branch()
                        {
                            MatId = MatrixDprime.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };
                        db.Branches.Attach(BMatrixDprime);
                        db.Entry(BMatrixDprime).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in RemainBOBMatrixPsec)
                        {
                            Model.BranchOnBranch BoBMatrixDprime = new Model.BranchOnBranch()
                            {
                                IdBranch = item.Id,
                                bl = item2.bl,
                                bp = item2.bp
                            };

                            db.BranchOnBranches.Attach(BoBMatrixDprime);
                            db.Entry(BoBMatrixDprime).State = EntityState.Modified;
                            db.SaveChanges();
                        }

                    }

                }
                db.Psecs.Remove(MatrixPsec);
                db.SaveChanges();
                for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                {
                    var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                    if (identity != null)
                    {
                        identity.IdentityNo = identity.IdentityNo - 1;
                        db.Psecs.Attach(identity);
                        db.Entry(identity).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                var NDPrime = db.N.Select(x => x.NDprime).FirstOrDefault();
                double NDprimeret = NDPrime.Value + 1;
                double NPret = NP.Value + 1;
                double NPsecret = NPsec.Value - 1;


                var MatrixN = db.N.FirstOrDefault();
                MatrixN.NP = NPret;
                MatrixN.NDprime = NDprimeret;
                MatrixN.NPsec = NPsecret;
                db.N.Attach(MatrixN);
                db.Entry(MatrixN).State = EntityState.Modified;
                db.SaveChanges();

            }
            if (Num == 13)
            {
                Random rnd = new Random();
                int r4 = 0;
                int rtest4 = 0;
                int max32 = IdentityNoPtert;
                if (max32 == 1)
                {
                    max32 += 1;
                }
                do
                {
                    rtest4 = rnd.Next(0, Convert.ToInt32(max32));
                    if (rtest4 != 0)
                        r4 = rtest4;
                } while (rtest4 == 0);

                var MatrixPtert = db.Pterts.Where(x => x.IdentityNo == r4).FirstOrDefault();
                var BMatrixPtert = db.Branches.Where(x => x.MatId == MatrixPtert.Id).ToList();
                var BOBLastMatrixPtert = db.BranchOnBranches.Where(x => x.IdBranch == BMatrixPtert.Last().Id).ToList();
                var BOBSecLastMatrixPtert = db.BranchOnBranches.Where(x => x.IdBranch == BMatrixPtert.ElementAt(BMatrixPtert.Count - 1).Id).ToList();
                int r5 = 0;
                int rtest5 = 0;
                do
                {
                    rtest5 = rnd.Next(0, 3);
                    if (rtest5 != 0)
                        r5 = rtest5;
                } while (rtest5 == 0);

                if (r5 == 1)
                {
                    foreach (var item in BOBLastMatrixPtert)
                    {
                        item.bp += 2;
                        db.BranchOnBranches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    int i = 0;
                    foreach (var item in BOBLastMatrixPtert)
                    {
                        if (item.bp == 2)
                            i += 1;
                    }
                    foreach (var item in BOBLastMatrixPtert)
                    {
                        item.bp -= 2;
                        db.BranchOnBranches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    if (i <= 2)
                    {
                        Model.Dprime MatrixDprime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = BMatrixPtert.Last().BL + BMatrixPtert.ElementAt(BMatrixPtert.Count - 1).BL + 2,
                            NB = BMatrixPtert.Last().CC + 1,
                        };
                        db.Dprimes.Add(MatrixDprime);
                        db.SaveChanges();
                        foreach (var item in BOBLastMatrixPtert)
                        {
                            Model.Branch BMatrixDprime = new Model.Branch()
                            {
                                MatId = MatrixDprime.Id,
                                BP = item.bp + 2,
                                BL = item.bl,
                                CC = 0

                            };
                            db.Branches.Attach(BMatrixDprime);
                            db.Entry(BMatrixDprime).State = EntityState.Modified;
                            db.SaveChanges();
                            if (BMatrixDprime.CC == 0)
                            {
                                Model.BranchOnBranch bob = new Model.BranchOnBranch()
                                {
                                    bl = 0,
                                    bp = 0,
                                    IdBranch = BMatrixDprime.Id
                                };
                                db.BranchOnBranches.Add(bob);
                                db.SaveChanges();
                            }

                            db.Branches.Remove(BMatrixPtert.Last());
                            db.SaveChanges();
                        }
                        Model.Branch PluseBMatrixDprime = new Model.Branch()
                        {
                            MatId = MatrixDprime.Id,
                            BP = 2,
                            BL = BMatrixPtert.ElementAt(BMatrixPtert.Count - 1).BL,
                            CC = BMatrixPtert.ElementAt(BMatrixPtert.Count - 1).CC
                        };
                        db.Branches.Add(PluseBMatrixDprime);
                        db.SaveChanges();

                        db.Branches.Remove(BMatrixPtert.ElementAt(BMatrixPtert.Count - 1));
                        db.SaveChanges();


                        foreach (var item in BMatrixPtert)
                        {
                            var ReaminBOBMatrixPtert = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                            Model.Branch BMatrixPluseDprime = new Model.Branch()
                            {
                                MatId = PluseBMatrixDprime.Id,
                                BP = item.BP,
                                BL = item.BL,
                                CC = item.CC
                            };
                            db.Branches.Attach(BMatrixPluseDprime);
                            db.Entry(BMatrixPluseDprime).State = EntityState.Modified;
                            db.SaveChanges();
                            foreach (var item2 in ReaminBOBMatrixPtert)
                            {
                                Model.BranchOnBranch BOBMatrixPluseDprime = new Model.BranchOnBranch()
                                {
                                    IdBranch = item.Id,
                                    bl = item2.bl,
                                    bp = item2.bp
                                };

                                db.BranchOnBranches.Attach(BOBMatrixPluseDprime);
                                db.Entry(BOBMatrixPluseDprime).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }
                    }
                }
                else if (r5 == 2)
                {
                    Model.P MatrixP = new Model.P()
                    {
                        IdentityNo = IdentityNoP + 1,
                        CL = BMatrixPtert.Last().BL - 1,
                        NB = BMatrixPtert.Last().CC
                    };
                    db.P.Add(MatrixP);
                    db.SaveChanges();
                    foreach (var item in BOBLastMatrixPtert)
                    {
                        Model.Branch BMatrixP = new Model.Branch()
                        {
                            MatId = MatrixP.Id,
                            BL = item.bl,
                            BP = item.bp - 1,
                            CC = 0
                        };
                        db.Branches.Attach(BMatrixP);
                        db.Entry(BMatrixP).State = EntityState.Modified;
                        db.SaveChanges();
                        if (BMatrixP.CC == 0)
                        {
                            Model.BranchOnBranch bob = new Model.BranchOnBranch()
                            {
                                bl = 0,
                                bp = 0,
                                IdBranch = BMatrixP.Id
                            };
                            db.BranchOnBranches.Add(bob);
                            db.SaveChanges();
                        }


                    }
                    db.Branches.Remove(BMatrixPtert.Last());
                    db.SaveChanges();
                    Model.Dprime MatrixDprime = new Model.Dprime()
                    {
                        IdentityNo = IdentityNoDprime + 1,
                        CL = MatrixPtert.CL - MatrixP.CL,
                        NB = MatrixPtert.NB - 1
                    };
                    db.Dprimes.Add(MatrixDprime);
                    db.SaveChanges();
                    foreach (var item in BMatrixPtert)
                    {
                        var BOBMatrixPtert = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        Model.Branch BMatrixDprime = new Model.Branch()
                        {
                            MatId = MatrixDprime.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };
                        db.Branches.Attach(BMatrixDprime);
                        db.Entry(BMatrixDprime).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in BOBMatrixPtert)
                        {
                            Model.BranchOnBranch BOBMatrixDprime = new Model.BranchOnBranch()
                            {
                                IdBranch = item.Id,
                                bl = item2.bl,
                                bp = item2.bp
                            };

                            db.BranchOnBranches.Attach(BOBMatrixDprime);
                            db.Entry(BOBMatrixDprime).State = EntityState.Modified;
                            db.SaveChanges();
                        }

                    }
                }
                else
                {
                    Model.P MatrixP = new Model.P()
                    {
                        IdentityNo = IdentityNoP + 1,
                        CL = BMatrixPtert.ElementAt(BMatrixPtert.Count - 1).BL - 1,
                        NB = BMatrixPtert.ElementAt(BMatrixPtert.Count - 1).CC
                    };
                    db.P.Add(MatrixP);
                    db.SaveChanges();
                    foreach (var item in BOBLastMatrixPtert)
                    {
                        Model.Branch BMatrixP = new Model.Branch()
                        {
                            MatId = MatrixP.Id,
                            BL = item.bl,
                            BP = item.bp - 1,
                            CC = 0
                        };
                        db.Branches.Attach(BMatrixP);
                        db.Entry(BMatrixP).State = EntityState.Modified;
                        db.SaveChanges();
                        if (BMatrixP.CC == 0)
                        {
                            Model.BranchOnBranch bob = new Model.BranchOnBranch()
                            {
                                bl = 0,
                                bp = 0,
                                IdBranch = BMatrixP.Id
                            };
                            db.BranchOnBranches.Add(bob);
                            db.SaveChanges();
                        }

                    }
                    db.Branches.Remove(BMatrixPtert.ElementAt(BMatrixPtert.Count - 1));
                    db.SaveChanges();
                    Model.Dprime MatrixDprime = new Model.Dprime()
                    {
                        IdentityNo = IdentityNoDprime + 1,
                        CL = MatrixPtert.CL - MatrixP.CL,
                        NB = MatrixPtert.NB - 1
                    };
                    db.Dprimes.Add(MatrixDprime);
                    db.SaveChanges();
                    foreach (var item in BMatrixPtert)
                    {
                        var BOBMatrixPtert = db.BranchOnBranches.Where(x => x.IdBranch == item.Id).ToList();
                        Model.Branch BMatrixDprime = new Model.Branch()
                        {
                            MatId = MatrixDprime.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };
                        db.Branches.Attach(BMatrixDprime);
                        db.Entry(BMatrixDprime).State = EntityState.Modified;
                        db.SaveChanges();
                        foreach (var item2 in BOBMatrixPtert)
                        {
                            Model.BranchOnBranch BOBMatrixDprime = new Model.BranchOnBranch()
                            {
                                IdBranch = item.Id,
                                bl = item2.bl,
                                bp = item2.bp
                            };

                            db.BranchOnBranches.Attach(BOBMatrixDprime);
                            db.Entry(BOBMatrixDprime).State = EntityState.Modified;
                            db.SaveChanges();
                        }

                    }

                }

                db.Pterts.Remove(MatrixPtert);
                db.SaveChanges();
                for (int ii = MatrixPtert.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                {
                    var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                    if (identity != null)
                    {
                        identity.IdentityNo = identity.IdentityNo - 1;
                        db.Pterts.Attach(identity);
                        db.Entry(identity).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                var NDPrime = db.N.Select(x => x.NDprime).FirstOrDefault();
                double NDprimeret = NDPrime.Value + 1;
                double NPret = NP.Value + 1;
                double NPtertret = NPtert.Value - 1;


                var MatrixN = db.N.FirstOrDefault();
                MatrixN.NP = NPret;
                MatrixN.NDprime = NDprimeret;
                MatrixN.NPtert = NPtertret;
                db.N.Attach(MatrixN);
                db.Entry(MatrixN).State = EntityState.Modified;
                db.SaveChanges();

            }
            if (Num == 14)//ta inja neveshtam edamash hanoz naneveshtam
            {

                var Ndouble = NP.Value + NPsec.Value;
                Random rnd = new Random();
                int r3 = 0;
                int rtest = 0;
                int max33 = (Int32)(Ntotal);
                if (max33 == 1)
                {
                    max33 += 1;
                }
                do
                {
                    rtest = rnd.Next(0, Convert.ToInt32(max33));
                    if (rtest != 0)
                        r3 = rtest;
                } while (rtest == 0);

                int r3_1 = 0;
                int rtest3_1 = 0;
                int max34 = (Int32)(Ntotal);
                if (max34 == 1)
                {
                    max34 += 1;
                }
                do
                {
                    rtest3_1 = rnd.Next(0, Convert.ToInt32(max34));
                    if (rtest3_1 != 0)
                        r3_1 = rtest3_1;
                } while (rtest3_1 == 0);

                if (r3 > 0 && r3 <= NP && r3_1 > 0 && r3_1 <= NP)
                {
                    var r4_1 = 0;
                    var r4 = rnd.Next(0, (Int32)IdentityNoP);
                    do
                    {
                        r4_1 = rnd.Next(0, (Int32)IdentityNoP);

                    } while (r4_1 == r4);

                    var MatrixP = db.P.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixP_1 = db.P.Where(x => x.IdentityNo == r4_1).FirstOrDefault();
                    var BMatrixP = db.Branches.Where(x => x.MatId == MatrixP.Id).ToList();
                    var BMatrixP_1 = db.Branches.Where(x => x.MatId == MatrixP_1.Id).ToList();
                    var SumBl = 0;
                    foreach (var item in BMatrixP)
                    {
                        SumBl += item.BL;
                    }
                    MatrixP.CL = MatrixP.CL - SumBl;
                    foreach (var item in BMatrixP_1)
                    {
                        item.BP += MatrixP.CL;

                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    Model.D MatrixD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = MatrixP.CL + MatrixP_1.CL,
                        NB = MatrixP.NB + MatrixP_1.NB
                    };
                    db.D.Add(MatrixD);
                    db.SaveChanges();
                    foreach (var item in BMatrixP)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };
                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                    foreach (var item in BMatrixP_1)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP + SumBl,
                            BL = item.BL,
                            CC = item.CC
                        };

                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    db.P.Remove(MatrixP);
                    db.SaveChanges();
                    for (int ii = MatrixP.IdentityNo; ii <= db.P.Count() + 1; ii++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.P.Remove(MatrixP_1);
                    db.SaveChanges();
                    for (int ii = MatrixP_1.IdentityNo; ii <= db.P.Count() + 1; ii++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    double NPret = NP.Value - 2;
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    double NDret = ND.Value + 2;

                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NP = NPret;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();



                }
                else if (r3 > 0 && r3 <= NP && r3_1 > NP && r3_1 <= NP + NPsec)
                {

                    var r4_1 = 0;
                    int r4 = 0;
                    int rtest4 = 0;
                    int rtest4_1 = 0;
                    int max35 = IdentityNoP;
                    if (max35 == 1)
                    {
                        max35 += 1;
                    }
                    do
                    {
                        rtest4 = rnd.Next(0, Convert.ToInt32(max35));
                        if (rtest4 != 0)
                            r4 = rtest4;
                    } while (rtest4 == 0);

                    do
                    {
                        rtest4_1 = rnd.Next(0, Convert.ToInt32(IdentityNoPsec));
                        if (rtest4_1 != 0)
                            r4_1 = rtest4_1;
                    } while (rtest4_1 == 0);



                    var MatrixP = db.P.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r4_1).FirstOrDefault();
                    var BMatrixP = db.Branches.Where(x => x.MatId == MatrixP.Id).ToList();
                    var BMatrixPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();

                    var SumBl = 0;
                    foreach (var item in BMatrixP)
                    {
                        SumBl += item.BL;
                    }
                    MatrixP.CL = MatrixP.CL - SumBl;
                    foreach (var item in BMatrixPsec)
                    {
                        item.BP += MatrixP.CL;

                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    Model.D MatrixD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = MatrixP.CL + MatrixPsec.CL,
                        NB = MatrixP.NB + MatrixPsec.NB
                    };
                    db.D.Add(MatrixD);
                    db.SaveChanges();
                    foreach (var item in BMatrixP)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };
                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                    foreach (var item in BMatrixPsec)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };

                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    db.P.Remove(MatrixP);
                    db.SaveChanges();
                    for (int ii = MatrixP.IdentityNo; ii <= db.P.Count() + 1; ii++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.Psecs.Remove(MatrixPsec);
                    db.SaveChanges();
                    for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }

                    double NPret = NP.Value - 1;
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    double NDret = ND.Value + 2;
                    double NpSecRet = NPsec.Value - 1;

                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NP = NPret;
                    MatrixN.NPsec = NpSecRet;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();



                }
                else if (r3_1 > 0 && r3_1 <= NP && r3 > NP + NPsec && r3 <= Ntotal)
                {

                    var r4_1 = 0;
                    int r4 = 0;
                    var rtest4_1 = 0;
                    int rtest4 = 0;
                    do
                    {
                        rtest4 = rnd.Next(0, Convert.ToInt32(IdentityNoP));
                        if (rtest4 != 0)
                            r4 = rtest4;
                    } while (rtest4 == 0);

                    do
                    {
                        rtest4_1 = rnd.Next(0, Convert.ToInt32(IdentityNoPtert));
                        if (rtest4_1 != 0)
                            r4_1 = rtest4_1;
                    } while (rtest4_1 == 0);
                    var MatrixP = db.P.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixPtert = db.Pterts.Where(x => x.IdentityNo == r4_1).FirstOrDefault();
                    var BMatrixP = db.Branches.Where(x => x.MatId == MatrixP.Id).ToList();
                    var BMatrixPtert = db.Branches.Where(x => x.MatId == MatrixPtert.Id).ToList();
                    var SumBl = 0;
                    foreach (var item in BMatrixP)
                    {
                        SumBl += item.BL;
                    }
                    MatrixP.CL = MatrixP.CL - SumBl;
                    foreach (var item in BMatrixPtert)
                    {
                        item.BP += MatrixP.CL;

                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    Model.D MatrixD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = MatrixP.CL + MatrixPtert.CL,
                        NB = MatrixP.NB + MatrixPtert.NB
                    };
                    db.D.Add(MatrixD);
                    db.SaveChanges();
                    foreach (var item in BMatrixP)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };
                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                    foreach (var item in BMatrixPtert)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };

                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    db.P.Remove(MatrixP);
                    db.SaveChanges();
                    for (int ii = MatrixP.IdentityNo; ii <= db.P.Count() + 1; ii++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.Pterts.Remove(MatrixPtert);
                    db.SaveChanges();
                    for (int ii = MatrixPtert.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                    {
                        var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Pterts.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }

                    double NPret = NP.Value - 1;
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    double NDret = ND.Value + 2;
                    double NptertRet = NPtert.Value - 1;
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NP = NPret;
                    MatrixN.NPtert = NptertRet;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                }
                else if (r3 > NP && r3 <= NP + NPsec && r3_1 > NP && r3_1 <= NP + NPsec)
                {
                    var r4_1 = 0;
                    var r4 = rnd.Next(0, (Int32)IdentityNoPsec);
                    do
                    {
                        r4_1 = rnd.Next(0, (Int32)IdentityNoPsec);

                    } while (r4_1 == r4);

                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixPsec_1 = db.Psecs.Where(x => x.IdentityNo == r4_1).FirstOrDefault();
                    var BMatrixPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();
                    var BMatrixPsec_1 = db.Branches.Where(x => x.MatId == MatrixPsec_1.Id).ToList();
                    var SumBl = 0;
                    foreach (var item in BMatrixPsec)
                    {
                        SumBl += item.BL;
                    }
                    MatrixPsec.CL = MatrixPsec.CL - SumBl;
                    foreach (var item in BMatrixPsec_1)
                    {
                        item.BP += MatrixPsec.CL;

                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    Model.D MatrixD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = MatrixPsec.CL + MatrixPsec_1.CL,
                        NB = MatrixPsec.NB + MatrixPsec_1.NB
                    };
                    db.D.Add(MatrixD);
                    db.SaveChanges();
                    foreach (var item in BMatrixPsec)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };
                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                    foreach (var item in BMatrixPsec_1)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };

                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    db.Psecs.Remove(MatrixPsec);
                    db.SaveChanges();
                    for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.Psecs.Remove(MatrixPsec_1);
                    db.SaveChanges();
                    for (int ii = MatrixPsec_1.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }

                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    double NDret = ND.Value + 2;
                    double NpSecRet = NPsec.Value - 2;
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NPsec = NpSecRet;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                }
                else if (r3_1 > NP && r3_1 <= NP + NPsec && r3 > NP + NPsec && r3 <= Ntotal)
                {


                    var r4_1 = 0;
                    int r4 = 0;
                    var rtest4_1 = 0;
                    int rtest4 = 0;
                    do
                    {
                        rtest4 = rnd.Next(0, Convert.ToInt32(IdentityNoPsec));
                        if (rtest4 != 0)
                            r4 = rtest4;
                    } while (rtest4 == 0);

                    do
                    {
                        rtest4_1 = rnd.Next(0, Convert.ToInt32(IdentityNoPtert));
                        if (rtest4_1 != 0)
                            r4_1 = rtest4_1;
                    } while (rtest4_1 == 0);

                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixPtert = db.Pterts.Where(x => x.IdentityNo == r4_1).FirstOrDefault();
                    var BMatrixPsec = db.Branches.Where(x => x.MatId == MatrixPsec.Id).ToList();
                    var BMatrixPtert = db.Branches.Where(x => x.MatId == MatrixPtert.Id).ToList();
                    var SumBl = 0;
                    foreach (var item in BMatrixPsec)
                    {
                        SumBl += item.BL;
                    }
                    MatrixPsec.CL = MatrixPsec.CL - SumBl;
                    foreach (var item in BMatrixPtert)
                    {
                        item.BP += MatrixPsec.CL;

                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    Model.D MatrixD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = MatrixPsec.CL + MatrixPtert.CL,
                        NB = MatrixPsec.NB + MatrixPtert.NB
                    };
                    db.D.Add(MatrixD);
                    db.SaveChanges();
                    foreach (var item in BMatrixPsec)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };
                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                    foreach (var item in BMatrixPtert)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };

                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    db.Psecs.Remove(MatrixPsec);
                    db.SaveChanges();
                    for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.Pterts.Remove(MatrixPtert);
                    db.SaveChanges();
                    for (int ii = MatrixPtert.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                    {
                        var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Pterts.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }

                    double NPSecRet = NPsec.Value - 1;
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    double NDret = ND.Value + 2;
                    double NpTertRet = NPtert.Value - 1;
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NPtert = NpTertRet;
                    MatrixN.NPsec = NPSecRet;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                }
                else if (r3 > NP + NPsec && r3 <= Ntotal && r3_1 > NP + NPsec && r3_1 <= Ntotal)
                {
                    var r4_1 = 0;
                    var r4 = rnd.Next(0, (Int32)IdentityNoP);
                    do
                    {
                        r4_1 = rnd.Next(0, (Int32)IdentityNoP);

                    } while (r4_1 == r4);

                    var MatrixPtert = db.Pterts.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixPtert_1 = db.Pterts.Where(x => x.IdentityNo == r4_1).FirstOrDefault();
                    var BMatrixPtert = db.Branches.Where(x => x.MatId == MatrixPtert.Id).ToList();
                    var BMatrixPtert_1 = db.Branches.Where(x => x.MatId == MatrixPtert_1.Id).ToList();
                    var SumBl = 0;
                    foreach (var item in BMatrixPtert)
                    {
                        SumBl += item.BL;
                    }
                    MatrixPtert.CL = MatrixPtert.CL - SumBl;
                    foreach (var item in BMatrixPtert_1)
                    {
                        item.BP += MatrixPtert.CL;

                        db.Branches.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    Model.D MatrixD = new Model.D()
                    {
                        IdentityNo = IdentityNoD + 1,
                        CL = MatrixPtert.CL + MatrixPtert_1.CL,
                        NB = MatrixPtert.NB + MatrixPtert_1.NB
                    };
                    db.D.Add(MatrixD);
                    db.SaveChanges();
                    foreach (var item in BMatrixPtert)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };
                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                    foreach (var item in BMatrixPtert_1)
                    {
                        Model.Branch BD = new Model.Branch()
                        {
                            MatId = MatrixD.Id,
                            BP = item.BP,
                            BL = item.BL,
                            CC = item.CC
                        };

                        db.Branches.Attach(BD);
                        db.Entry(BD).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    db.Pterts.Remove(MatrixPtert);
                    db.SaveChanges();
                    for (int ii = MatrixPtert.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                    {
                        var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Pterts.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.Pterts.Remove(MatrixPtert_1);
                    db.SaveChanges();
                    for (int ii = MatrixPtert_1.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                    {
                        var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Pterts.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }

                    double NPtertRet = NPtert.Value - 2;
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    double NDret = ND.Value + 2;

                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NPtert = NPtertRet;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                }


            }
            if (Num == 15)
            {

                double Ndouble = NP.Value + NPsec.Value;
                Random rnd = new Random();
                int r3 = 0;
                int rtest = 0;
                do
                {
                    rtest = rnd.Next(0, Convert.ToInt32(Ntotal));
                    if (rtest != 0)
                        r3 = rtest;
                } while (rtest == 0);
                int r3_1 = 0;
                int rtest3_1 = 0;
                do
                {
                    rtest3_1 = rnd.Next(0, Convert.ToInt32(Ntotal));
                    if (rtest3_1 != 0)
                        r3_1 = rtest3_1;
                } while (rtest3_1 == 0);
                if (r3 > 0 && r3 <= NP && r3_1 > 0 && r3_1 <= NP)
                {
                    int r5 = 0;
                    int rtest5 = 0;

                    do
                    {
                        rtest5 = rnd.Next(0, 2);
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);
                    var r4 = 0;
                    int rtest4 = 0;
                    do
                    {
                        rtest4 = rnd.Next(0, (Int32)IdentityNoP);
                        if (rtest4 != 0)
                            r4 = rtest4;

                    } while (rtest4 == 0);
                    var r4_1 = 0;

                    do
                    {
                        r4_1 = rnd.Next(0, (Int32)IdentityNoP);

                    } while (r4_1 == r4);

                    var MatrixP = db.P.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixP_1 = db.P.Where(x => x.IdentityNo == r4_1).FirstOrDefault();

                    if (r5 == 1)
                    {
                        Model.D MatrixD = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = MatrixP.CL,
                            NB = MatrixP.NB
                        };
                        db.D.Add(MatrixD);
                        db.SaveChanges();

                        Model.Dprime MatrixDprime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = MatrixP_1.CL,
                            NB = MatrixP_1.NB
                        };
                        db.Dprimes.Add(MatrixDprime);
                        db.SaveChanges();
                    }
                    else
                    {

                        Model.D MatrixD = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = MatrixP_1.CL,
                            NB = MatrixP_1.NB
                        };
                        db.D.Add(MatrixD);
                        db.SaveChanges();

                        Model.Dprime MatrixDprime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = MatrixP.CL,
                            NB = MatrixP.NB
                        };
                        db.Dprimes.Add(MatrixDprime);
                        db.SaveChanges();
                    }

                    db.P.Remove(MatrixP);
                    db.SaveChanges();
                    for (int ii = MatrixP.IdentityNo; ii <= db.P.Count() + 1; ii++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.P.Remove(MatrixP_1);
                    db.SaveChanges();
                    for (int ii = MatrixP_1.IdentityNo; ii <= db.P.Count() + 1; ii++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    double NPret = NP.Value - 2;
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    var NDPrime = db.N.Select(x => x.NDprime).FirstOrDefault();
                    double NDret = ND.Value + 1;
                    double NDPrimeRet = NDPrime.Value + 1;

                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NDprime = NDPrimeRet;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                }
                else if (r3 > 0 && r3 <= NP && r3_1 > NP && r3_1 <= NP + NPsec)
                {
                    int r5 = 0;
                    int rtest5 = 0;
                    do
                    {
                        rtest5 = rnd.Next(0, 2);
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);
                    var r4 = 0;
                    int rtest4 = 0;
                    do
                    {
                        rtest4 = rnd.Next(0, (Int32)IdentityNoP);
                        if (rtest4 != 0)
                            r4 = rtest4;

                    } while (rtest4 == 0);
                    var r4_1 = 0;

                    do
                    {
                        r4_1 = rnd.Next(0, (Int32)IdentityNoPsec);

                    } while (r4_1 == r4);



                    var MatrixP = db.P.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r4_1).FirstOrDefault();

                    if (r5 == 1)
                    {
                        Model.D MatrixD = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = MatrixP.CL,
                            NB = MatrixP.NB
                        };
                        db.D.Add(MatrixD);
                        db.SaveChanges();

                        Model.Dprime MatrixDprime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = MatrixPsec.CL,
                            NB = MatrixPsec.NB
                        };
                        db.Dprimes.Add(MatrixDprime);
                        db.SaveChanges();
                    }
                    else
                    {

                        Model.D MatrixD = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = MatrixPsec.CL,
                            NB = MatrixPsec.NB
                        };
                        db.D.Add(MatrixD);
                        db.SaveChanges();

                        Model.Dprime MatrixDprime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = MatrixP.CL,
                            NB = MatrixP.NB
                        };
                        db.Dprimes.Add(MatrixDprime);
                        db.SaveChanges();
                    }

                    db.P.Remove(MatrixP);
                    db.SaveChanges();
                    for (int ii = MatrixP.IdentityNo; ii <= db.P.Count() + 1; ii++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.Psecs.Remove(MatrixPsec);
                    db.SaveChanges();
                    for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.Where(x => x.IdentityNo == ii).FirstOrDefault();
                        identity.IdentityNo = identity.IdentityNo - 1;
                        db.Psecs.Attach(identity);
                        db.Entry(identity).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    double NPret = NP.Value - 1;
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    var NDPrime = db.N.Select(x => x.NDprime).FirstOrDefault();
                    double NDret = ND.Value + 1;
                    double NDPrimeRet = NDPrime.Value + 1;
                    double NpSecRet = NPsec.Value - 1;

                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NDprime = NDPrimeRet;
                    MatrixN.NPsec = NpSecRet;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();



                }
                else if (r3_1 > 0 && r3_1 <= NP && r3 > NP + NPsec && r3 <= Ntotal)
                {

                    int r5 = 0;
                    int rtest5 = 0;
                    do
                    {
                        rtest5 = rnd.Next(0, 2);
                        if (rtest5 != 0)
                            r5 = rtest5;

                    } while (rtest5 == 0);
                    var r4 = 0;
                    int rtest4 = 0;
                    do
                    {
                        rtest4 = rnd.Next(0, (Int32)IdentityNoP);
                        if (rtest4 != 0)
                            r4 = rtest4;

                    } while (rtest4 == 0);
                    var r4_1 = 0;

                    do
                    {
                        r4_1 = rnd.Next(0, (Int32)IdentityNoPtert);

                    } while (r4_1 == 0);



                    var MatrixP = db.P.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixPtert = db.Pterts.Where(x => x.IdentityNo == r4_1).FirstOrDefault();

                    if (r5 == 1)
                    {
                        Model.D MatrixD = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = MatrixP.CL,
                            NB = MatrixP.NB
                        };
                        db.D.Add(MatrixD);
                        db.SaveChanges();

                        Model.Dprime MatrixDprime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = MatrixPtert.CL,
                            NB = MatrixPtert.NB
                        };
                        db.Dprimes.Add(MatrixDprime);
                        db.SaveChanges();
                    }
                    else
                    {

                        Model.D MatrixD = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = MatrixPtert.CL,
                            NB = MatrixPtert.NB
                        };
                        db.D.Add(MatrixD);
                        db.SaveChanges();

                        Model.Dprime MatrixDprime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = MatrixP.CL,
                            NB = MatrixP.NB
                        };
                        db.Dprimes.Add(MatrixDprime);
                        db.SaveChanges();
                    }

                    db.P.Remove(MatrixP);
                    db.SaveChanges();
                    for (int ii = MatrixP.IdentityNo; ii <= db.P.Count() + 1; ii++)
                    {
                        var identity = db.P.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.P.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.Pterts.Remove(MatrixPtert);
                    db.SaveChanges();
                    for (int ii = MatrixPtert.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                    {
                        var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Pterts.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    var NDPrime = db.N.Select(x => x.NDprime).FirstOrDefault();

                    double NPret = NP.Value - 1;
                    double NDret = ND.Value + 1;
                    double NDPrimeRet = NDPrime.Value + 1;
                    double NptertRet = NPtert.Value - 1;

                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NDprime = NDPrimeRet;
                    MatrixN.NPtert = NptertRet;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();


                }
                else if (r3 > NP && r3 <= NP + NPsec && r3_1 > NP && r3_1 <= NP + NPsec)
                {
                    int r5 = 0;
                    int rtest5 = 0;
                    do
                    {
                        rtest5 = rnd.Next(0, 2);
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);
                    var r4 = 0;
                    int rtest4 = 0;
                    do
                    {
                        rtest4 = rnd.Next(0, (Int32)IdentityNoPsec);
                        if (rtest4 != 0)
                            r4 = rtest4;

                    } while (rtest4 == 0);
                    var r4_1 = 0;

                    do
                    {
                        r4_1 = rnd.Next(0, (Int32)IdentityNoPsec);

                    } while (r4_1 == r4);


                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixPsec_1 = db.Psecs.Where(x => x.IdentityNo == r4_1).FirstOrDefault();

                    if (r5 == 1)
                    {
                        Model.D MatrixD = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = MatrixPsec.CL,
                            NB = MatrixPsec.NB
                        };
                        db.D.Add(MatrixD);
                        db.SaveChanges();

                        Model.Dprime MatrixDPrime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = MatrixPsec_1.CL,
                            NB = MatrixPsec_1.NB
                        };
                        db.Dprimes.Add(MatrixDPrime);
                        db.SaveChanges();
                    }
                    else
                    {

                        Model.D MatrixD = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = MatrixPsec_1.CL,
                            NB = MatrixPsec_1.NB
                        };
                        db.D.Add(MatrixD);
                        db.SaveChanges();

                        Model.Dprime MatrixDPrime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = MatrixPsec.CL,
                            NB = MatrixPsec.NB
                        };
                        db.Dprimes.Add(MatrixDPrime);
                        db.SaveChanges();
                    }

                    db.Psecs.Remove(MatrixPsec);
                    db.SaveChanges();
                    for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.Psecs.Remove(MatrixPsec_1);
                    db.SaveChanges();
                    for (int ii = MatrixPsec_1.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    var NDPrime = db.N.Select(x => x.NDprime).FirstOrDefault();

                    double NDret = ND.Value + 1;
                    double NDPrimeRet = NDPrime.Value + 1;
                    double NpSecRet = NPsec.Value - 2;
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NDprime = NDPrimeRet;
                    MatrixN.NPsec = NpSecRet;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();



                }
                else if (r3_1 > NP && r3_1 <= NP + NPsec && r3 > NP + NPsec && r3 <= Ntotal)
                {


                    int r5 = 0;
                    int rtest5 = 0;

                    do
                    {
                        rtest5 = rnd.Next(0, 2);
                        if (rtest5 != 0)
                            r5 = rtest5;
                    } while (rtest5 == 0);
                    var r4 = 0;
                    int rtest4 = 0;
                    do
                    {
                        rtest4 = rnd.Next(0, (Int32)IdentityNoPtert);
                        if (rtest4 != 0)
                            r4 = rtest4;
                    } while (rtest4 == 0);
                    var r4_1 = 0;
                    int rtest4_1 = 0;

                    do
                    {
                        rtest4_1 = rnd.Next(0, (Int32)IdentityNoPsec);
                        if (rtest4_1 != 0)
                            r4_1 = rtest4_1;

                    } while (rtest4_1 == 0);


                    var MatrixPtert = db.Pterts.Where(x => x.IdentityNo == r4).FirstOrDefault();
                    var MatrixPsec = db.Psecs.Where(x => x.IdentityNo == r4_1).FirstOrDefault();

                    if (r5 == 1)
                    {
                        Model.D MatrixD = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = MatrixPtert.CL,
                            NB = MatrixPtert.NB
                        };
                        db.D.Add(MatrixD);
                        db.SaveChanges();

                        Model.Dprime MatrixDprime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = MatrixPsec.CL,
                            NB = MatrixPsec.NB
                        };
                        db.Dprimes.Add(MatrixDprime);
                        db.SaveChanges();
                    }
                    else
                    {

                        Model.D MatrixD = new Model.D()
                        {
                            IdentityNo = IdentityNoD + 1,
                            CL = MatrixPsec.CL,
                            NB = MatrixPsec.NB
                        };
                        db.D.Add(MatrixD);
                        db.SaveChanges();

                        Model.Dprime MatrixDprime = new Model.Dprime()
                        {
                            IdentityNo = IdentityNoDprime + 1,
                            CL = MatrixPtert.CL,
                            NB = MatrixPtert.NB
                        };
                        db.Dprimes.Add(MatrixDprime);
                        db.SaveChanges();
                    }

                    db.Pterts.Remove(MatrixPtert);
                    db.SaveChanges();
                    for (int ii = MatrixPtert.IdentityNo; ii <= db.Pterts.Count() + 1; ii++)
                    {
                        var identity = db.Pterts.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Pterts.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.Psecs.Remove(MatrixPsec);
                    db.SaveChanges();
                    for (int ii = MatrixPsec.IdentityNo; ii <= db.Psecs.Count() + 1; ii++)
                    {
                        var identity = db.Psecs.OrderBy(x => x.IdentityNo).Where(x => x.IdentityNo == ii).FirstOrDefault();
                        if (identity != null)
                        {
                            identity.IdentityNo = identity.IdentityNo - 1;
                            db.Psecs.Attach(identity);
                            db.Entry(identity).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }

                    var ND = db.N.Select(x => x.ND).FirstOrDefault();
                    var NDPrime = db.N.Select(x => x.NDprime).FirstOrDefault();

                    double NDret = ND.Value + 1;
                    double NDPrimeRet = NDPrime.Value + 1;
                    double NpTertRet = NPtert.Value - 1;
                    double NpSecRet = NPsec.Value - 1;
                    var MatrixN = db.N.FirstOrDefault();
                    MatrixN.ND = NDret;
                    MatrixN.NDprime = NDPrimeRet;
                    MatrixN.NPsec = NpSecRet;
                    MatrixN.NPtert = NpTertRet;
                    db.N.Attach(MatrixN);
                    db.Entry(MatrixN).State = EntityState.Modified;
                    db.SaveChanges();



                }

            }
            #endregion
            ////else
            ////{
            ////    return null;
            ////}
        }
    }
}

