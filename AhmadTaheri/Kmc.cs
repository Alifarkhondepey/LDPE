using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    class Kmc
    {

        public Tuple <double,int> kmc(double Kexpp , double Vs,int RNum )
        {
            AhmadTaheri.Model.PolymersMatrices db = new Model.PolymersMatrices();
            var Kexp = db.Kexps.FirstOrDefault();
            var K = db.KMCs.FirstOrDefault();
            var NAV = 6 * Math.Pow(10, 8);
            if(RNum==1)
            { 
            double KMC1 = Kexp.Kexp1.Value;
                K.KMC1 = KMC1;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC1,1);

            }
            if (RNum == 2)
            {
                double KMC2 = Kexp.Kexp2.Value;

                K.KMC2 = KMC2;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC2, 2);
            }
            if (RNum == 3)
            {
                double KMC3 = Kexp.Kexp3.Value;

                K.KMC3 = KMC3;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC3, 3);
            }
            if (RNum == 4)
            {
                double KMC4 = Kexp.Kexp4.Value / (NAV * Vs);

                K.KMC4 = KMC4;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC4, 4);
            }
            if (RNum == 5)
            {
                double KMC5 = Kexp.Kexp5.Value / (NAV * Vs);

                K.KMC5 = KMC5;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC5, 5);
            }
            if (RNum == 6)
            {
                double KMC6 = Kexp.Kexp6.Value / (NAV * Vs);

                K.KMC6 = KMC6;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC6, 6);
            }
            if (RNum == 7)
            {
                double KMC7 = Kexp.Kexp7.Value / (NAV * Vs);

                K.KMC7 = KMC7;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC7, 7);
            }
            if (RNum == 8)
            {
                double KMC8 = Kexp.Kexp8.Value / (NAV * Vs);

                K.KMC8 = KMC8;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC8, 8);
            }
            if (RNum == 9)
            {
                double KMC9 = Kexp.Kexp9.Value / (NAV * Vs);

                K.KMC9 = KMC9;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC9, 19);
            }
            if (RNum == 10)
            {
                double KMC10 = Kexp.Kexp10.Value / (NAV * Vs);

                K.KMC10 = KMC10;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC10, 10);
            }
            if (RNum == 11)
            {
                double KMC11 = Kexp.Kexp11.Value;

                K.KMC11 = KMC11;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC11, 11);
            }
            if (RNum == 12)
            {
                double KMC12 = Kexp.Kexp12.Value;

                K.KMC12 = KMC12;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC12, 12);
            }
            if (RNum == 13)
            {
                double KMC13 = Kexp.Kexp13.Value;

                K.KMC13 = KMC13;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC13, 13);
            }
            if (RNum == 14)
            {
                double KMC14 = 2 * Kexp.Kexp14.Value / (NAV * Vs);

                K.KMC14 = KMC14;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC14, 14);
            }
            if (RNum == 15)
            {
                double KMC15 = 2 * Kexp.Kexp15.Value / (NAV * Vs);

                K.KMC15 = KMC15;
                db.KMCs.Attach(K);
                db.Entry(K).State = EntityState.Modified;
                db.SaveChanges();
                return Tuple.Create(KMC15, 15);
            }
            else
            {
                return null;
            }

        }

    }
}
