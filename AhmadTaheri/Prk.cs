using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    class Prk
    {
        AhmadTaheri.Model.PolymersMatrices db = new Model.PolymersMatrices();

        public Tuple<double,int> prk(int Rnum)
        {
            var R = db.RMCs.FirstOrDefault();
            var SumRmc = R.RMC1 + R.RMC2 + R.RMC3 + R.RMC4 + R.RMC5 + R.RMC6 + R.RMC7 + R.RMC8 +
                R.RMC9 + R.RMC10 + R.RMC11 + R.RMC12 + R.RMC13 + R.RMC14 + R.RMC15;
            
            var Prk = db.Prks.FirstOrDefault();
                double Pr1 = R.RMC1.Value / (SumRmc.Value);

            Prk.Prk1 = Pr1;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr2 = R.RMC2.Value / (SumRmc.Value);

                Prk.Prk2 = Pr2;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr3 = R.RMC3.Value / (SumRmc.Value);

                Prk.Prk3 = Pr3;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr4 = R.RMC4.Value / (SumRmc.Value);

                Prk.Prk4 = Pr4;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr5 = R.RMC5.Value / (SumRmc.Value);

                Prk.Prk5 = Pr5;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr6 = R.RMC6.Value / (SumRmc.Value);

                Prk.Prk6 = Pr6;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr7 = R.RMC7.Value / (SumRmc.Value);

                Prk.Prk7 = Pr7;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr8 = R.RMC8.Value / (SumRmc.Value);

                Prk.Prk8 = Pr8;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr9 = R.RMC9.Value / (SumRmc.Value);

                Prk.Prk9 = Pr9;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr10 = R.RMC10.Value / (SumRmc.Value);

                Prk.Prk10 = Pr10;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr11 = R.RMC11.Value / (SumRmc.Value);

                Prk.Prk11 = Pr11;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr12 = R.RMC12.Value / (SumRmc.Value);

                Prk.Prk12 = Pr12;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr13 = R.RMC13.Value / (SumRmc.Value);

                Prk.Prk13 = Pr13;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr14 = R.RMC14.Value / (SumRmc.Value);

                Prk.Prk14 = Pr14;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                double Pr15 = R.RMC15.Value / (SumRmc.Value);

                Prk.Prk15 = Pr15;
                db.Prks.Attach(Prk);
                db.Entry(Prk).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(Pr15, 15);
           

        }

    }
}
