using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    class Rmc
    {
        AhmadTaheri.Model.PolymersMatrices db = new Model.PolymersMatrices();
        
        //monde ke to db save update beshe
        public Tuple<double, int,double> rmc(double KMCc, int Rnum, double ND,double NCTA,double NIA,double NIC , double NIS,double NP , double NPtert , double NPsec,double NM,double NR)
        {
            var KMC = db.KMCs.FirstOrDefault();
            var N = db.N.FirstOrDefault();
            double SumRmc = 0.0;
            var R = db.RMCs.FirstOrDefault();
                double RMC1 = KMC.KMC1.Value * N.NIA.Value;
                SumRmc += RMC1;
                R.RMC1 = RMC1;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();

            double RMC2 = KMC.KMC2.Value * N.NIC.Value;
                SumRmc += RMC2;

                R.RMC2 = RMC2;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();

            double RMC3 = KMC.KMC3.Value * N.NIS.Value;
                SumRmc += RMC3;

                R.RMC3 = RMC3;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();
            
                double RMC4 = KMC.KMC4.Value * N.NM.Value * N.NR.Value;
                SumRmc += RMC4;

                R.RMC4 = RMC4;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();
           
                double RMC5 = KMC.KMC5.Value * N.NM.Value * (N.NP.Value + N.NPsec.Value + N.NPtert.Value);
                SumRmc += RMC5;

                R.RMC5 = RMC5;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();
                double RMC6 = KMC.KMC6.Value * N.NM.Value * (N.NP.Value + N.NPsec.Value + N.NPtert.Value);
                SumRmc += RMC6;

                R.RMC6 = RMC6;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();
                double RMC7 = KMC.KMC7.Value * N.NCTA.Value * (N.NP.Value + N.NPsec.Value + N.NPtert.Value);
                SumRmc += RMC7;

                R.RMC7 = RMC7;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();
              
                    double RMC8 = KMC.KMC8.Value *N.ND.Value * (N.NP.Value + N.NPsec.Value + N.NPtert.Value);
                SumRmc += RMC8;

                R.RMC8 = RMC8;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();

                double RMC9 = KMC.KMC9.Value * N.ND.Value * (N.NP.Value + N.NPsec.Value + N.NPtert.Value);
                SumRmc += RMC9;

                R.RMC9 = RMC9;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();

                double RMC10 = KMC.KMC10.Value * N.NDprime.Value * (N.NP.Value + N.NPsec.Value );
                SumRmc += RMC10;

                R.RMC10 = RMC10;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();

                double RMC11 = KMC.KMC11.Value * (N.NP.Value + N.NPsec.Value);
                SumRmc += RMC11;

                R.RMC11 = RMC11;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();
      
                double RMC12 = KMC.KMC12.Value * N.NPsec.Value;
                SumRmc += RMC12;

                R.RMC12 = RMC12;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();
                
                double RMC13 = KMC.KMC13.Value * N.NPtert.Value;
                SumRmc += RMC13;

                R.RMC13 = RMC13;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();
        
                double RMC14 = KMC.KMC14.Value * (N.NP.Value + N.NPsec.Value + N.NPtert.Value) * (((N.NP.Value + N.NPsec.Value + N.NPtert.Value) - 1) / 2);
                SumRmc += RMC14;

                R.RMC14 = RMC14;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();
          
                double RMC15 = KMC.KMC15.Value * (N.NP.Value + N.NPsec.Value + N.NPtert.Value) * (((N.NP.Value + N.NPsec.Value + N.NPtert.Value) - 1) / 2);
                SumRmc += RMC15;

                R.RMC15 = RMC15;
                db.RMCs.Attach(R);
                db.Entry(R).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(RMC15, 15,SumRmc);          
        }
    }
}
