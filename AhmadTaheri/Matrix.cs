using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    class Matrix
    {
        public Tuple<int, double[,], double[,], double[,]> P(int IdentityNoP)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];

            int CL = 0;
            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\";
            int i, j;
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoP;
                    }
                    if (IdentityNoP != 0)
                    {

                        if (i == 1 && j == 0)
                        {
                            Main[i, j] = CL + 1;
                        }
                    }
                    if (i == 2 && j == 0)
                    {
                        Main[i, j] = NB;
                    }

                    if (NB != 0)
                    {
                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(1); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = BP;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = BL;
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = CC;
                                }

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(path + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            tw.Write(Branch[i, j] + " ");
                                        }
                                        tw.WriteLine();
                                    }
                                }


                                if (CC != 0)
                                {
                                    for (i = 0; i < BranchOnBranch.GetLength(0); i++)
                                    {
                                        for (j = 0; j < BranchOnBranch.GetLength(1); j++)
                                        {

                                            if (i == 0 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bp;
                                            }
                                            if (i == 1 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bl;
                                            }

                                            //write in file txt
                                            using (TextWriter tw = new StreamWriter(path + "BranchOnBranch"[i]))
                                            {
                                                for (j = 0; j < BranchOnBranch.GetLength(0); j++)
                                                {
                                                    for (i = 0; i < BranchOnBranch.GetLength(1); i++)
                                                    {
                                                        tw.Write(BranchOnBranch[i, j] + " ");
                                                    }
                                                    tw.WriteLine();
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }


                    //write in file txt
                    using (TextWriter tw = new StreamWriter(path + "Main" + i))
                    {
                        for (i = 0; i < Main.GetLength(0); i++)
                        {
                            for (j = 0; j < Main.GetLength(1); j++)
                            {
                                tw.Write(Main[i, j] + " ");
                            }
                            tw.WriteLine();
                        }
                    }



                }

            }




            return Tuple.Create(IdentityNoP, Main, Branch, BranchOnBranch);


        }
        public Tuple<int, double[,], double[,], double[,]> Pnew(int IdentityNoP)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];

            int CL = 0;
            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\P\P" + IdentityNoP;
            if (!Directory.Exists(path))
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            int i, j;
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoP;
                    }
                    if (IdentityNoP != 0)
                    {

                        if (i == 1 && j == 0)
                        {
                            Main[i, j] = 1;
                        }
                    }
                    if (i == 2 && j == 0)
                    {
                        Main[i, j] = 0;
                    }

                    if (NB != 0)
                    {
                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(1); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = BP;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = BL;
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = CC;
                                }

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(path + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            tw.Write(Branch[i, j] + " ");
                                        }
                                        tw.WriteLine();
                                    }
                                }


                                if (CC != 0)
                                {
                                    for (i = 0; i < BranchOnBranch.GetLength(0); i++)
                                    {
                                        for (j = 0; j < BranchOnBranch.GetLength(1); j++)
                                        {

                                            if (i == 0 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bp;
                                            }
                                            if (i == 1 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bl;
                                            }

                                            //write in file txt
                                            using (TextWriter tw = new StreamWriter(path + "BranchOnBranch"[i]))
                                            {
                                                for (j = 0; j < BranchOnBranch.GetLength(0); j++)
                                                {
                                                    for (i = 0; i < BranchOnBranch.GetLength(1); i++)
                                                    {
                                                        tw.Write(BranchOnBranch[i, j] + " ");
                                                    }
                                                    tw.WriteLine();
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }


                    //write in file txt
                    using (TextWriter tw = new StreamWriter(path + "Main" + i))
                    {
                        for (i = 0; i < Main.GetLength(0); i++)
                        {
                            for (j = 0; j < Main.GetLength(1); j++)
                            {
                                tw.Write(Main[i, j] + " ");
                            }
                            tw.WriteLine();
                        }
                    }



                }

            }




            return Tuple.Create(IdentityNoP, Main, Branch, BranchOnBranch);


        }

        public Tuple<int, double[,], double[,], double[,]> Psec(int IdentityNoPsec)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];

            int CL = 0;
            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\";
            int i, j;
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {

                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoPsec;
                    }
                    if (i == 1 && j == 0)
                    {
                        Main[i, j] = CL;
                    }
                    if (i == 2 && j == 0)
                    {
                        Main[i, j] = NB;
                    }

                    if (NB != 0)
                    {
                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(1); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = BP;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = BL;
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = CC;
                                }

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(path + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            tw.Write(Branch[i, j] + " ");
                                        }
                                        tw.WriteLine();
                                    }
                                }


                                if (CC != 0)
                                {
                                    for (i = 0; i < BranchOnBranch.GetLength(0); i++)
                                    {
                                        for (j = 0; j < BranchOnBranch.GetLength(1); j++)
                                        {

                                            if (i == 0 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bp;
                                            }
                                            if (i == 1 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bl;
                                            }

                                            //write in file txt
                                            using (TextWriter tw = new StreamWriter(path + "BranchOnBranch"[i]))
                                            {
                                                for (j = 0; j < BranchOnBranch.GetLength(0); j++)
                                                {
                                                    for (i = 0; i < BranchOnBranch.GetLength(1); i++)
                                                    {
                                                        tw.Write(BranchOnBranch[i, j] + " ");
                                                    }
                                                    tw.WriteLine();
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }


                    //write in file txt
                    using (TextWriter tw = new StreamWriter(path + "Main" + i))
                    {
                        for (i = 0; i < Main.GetLength(0); i++)
                        {
                            for (j = 0; j < Main.GetLength(1); j++)
                            {
                                tw.Write(Main[i, j] + " ");
                            }
                            tw.WriteLine();
                        }
                    }



                }

            }




            //   return IdentityNo;
            return Tuple.Create(IdentityNoPsec, Main, Branch, BranchOnBranch);

        }
        public Tuple<int, double[,], double[,], double[,]> Psec9New(int IdentityNoPsec, List<double> BPList, int r8, double CL, double NBD, int? IdentityDprime)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] NewDprime = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];


            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            int BPCounter = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec;
            int i, j;
            List<string> folders = new List<string>();
            List<string> foldersNeed = new List<string>();
            var BLSum = 0.0;
            double[,] result = new double[3, 1];



            string BranchPathName = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec;
            string BranchPathNameNeed = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec;
            //get dir names
            foreach (var d in System.IO.Directory.GetDirectories(BranchPathName))
            {
                var dir = new DirectoryInfo(d);
                var dirName = dir.Name;

                folders.Add(dirName);
            }
            foreach (var d in System.IO.Directory.GetDirectories(BranchPathNameNeed))
            {
                var dir = new DirectoryInfo(d);
                var dirName = dir.Name;
                var resultString = Regex.Match(dirName, @"\d+").Value;

                if (Convert.ToInt32(resultString) <= r8)
                {
                    foldersNeed.Add(dirName);
                }
            }
            foreach (var itemneed in foldersNeed)
            {

                string pathBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\" + itemneed;
                String input = File.ReadAllText(pathBranch);

                int i2 = 0, j2 = 0;
                foreach (var row in input.Split('\n'))
                {
                    j2 = 0;
                    if (i2 <= 2)
                    {
                        foreach (var col in row.Trim().Split(' '))
                        {
                            result[i2, j2] = int.Parse(col.Trim());
                            j2++;
                        }
                    }
                    i2++;
                }

                for (int ii = 0; ii < result.GetLength(0); ii++)
                {
                    for (int jj = 0; jj < result.GetLength(0); jj++)
                    {
                        if (ii == 1 && jj == 0)
                        {
                            BLSum += result[ii, jj];
                        }
                    }

                }

            }

            //main
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {

                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoPsec;
                    }
                    if (i == 1 && j == 0)
                    {
                        Main[i, j] = BLSum + r8;
                    }
                    if (i == 2 && j == 0)
                    {
                        for (int ii = 0; ii <= BPList.Count; ii++)
                        {
                            foreach (var item in BPList)
                            {
                                if (r8 <= item)
                                {
                                    BPCounter += 1;
                                }

                            }
                        }
                        NB = BPCounter + 1;

                        Main[i, j] = NB;
                    }


                    string BranchPath = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\Branch" + (NB + 1);
                    // var directory2 = new DirectoryInfo(pathBranch);
                    var directoryInfo = new System.IO.DirectoryInfo(BranchPath);
                    int directoryCount = directoryInfo.GetDirectories().Length;
                    //end
                    if (NB != 0)
                    {



                        foreach (var item in folders)
                        {
                            foreach (var item2 in foldersNeed)
                            {
                                if (item != item2)
                                {
                                    string NewPathOfBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\BranchDeleted";

                                    System.IO.Directory.CreateDirectory(NewPathOfBranch);
                                    string p = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\" + item2; // your code goes here
                                    var dir = new DirectoryInfo(p);
                                    dir.MoveTo(NewPathOfBranch);
                                    //move
                                }
                            }
                        }

                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(0); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = r8;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = ((CL - BLSum) - r8);
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = NBD - NB;
                                }

                                string NewPathBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\Branch" + (foldersNeed.Count + 1);

                                System.IO.Directory.CreateDirectory(NewPathBranch);

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(NewPathBranch + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            if (i == 0 && j == 0)
                                            {
                                                Branch[i, j] = r8;
                                                tw.Write(Branch[i, j] + " ");

                                            }
                                            if (i == 1 && j == 0)
                                            {
                                                Branch[i, j] = 1;
                                                tw.Write(Branch[i, j] + " ");
                                            }
                                            if (i == 2 && j == 0)
                                            {
                                                Branch[i, j] = 0;
                                                tw.Write(Branch[i, j] + " ");

                                            }
                                        }
                                        tw.WriteLine();
                                    }
                                }



                                string NewPathDPrime = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Dprime\Dprime" + IdentityNoPsec + "\\Dprime" + (foldersNeed.Count + 1) + "\\Dprime";
                                var dir = System.IO.Directory.CreateDirectory(NewPathDPrime);
                                //write in file txt
                                using (TextWriter tw = new StreamWriter(NewPathDPrime + "Dprime"[i]))
                                {
                                    for (j = 0; j < NewDprime.GetLength(0); j++)
                                    {
                                        for (i = 0; i < NewDprime.GetLength(1); i++)
                                        {
                                            if (i == 0 && j == 0)
                                            {
                                                NewDprime[i, j] = Convert.ToDouble(IdentityDprime + 1);
                                                tw.Write(Branch[i, j] + " ");

                                            }
                                            if (i == 1 && j == 0)
                                            {
                                                NewDprime[i, j] = CL - (BLSum + r8);
                                                tw.Write(Branch[i, j] + " ");
                                            }
                                            if (i == 2 && j == 0)
                                            {
                                                NewDprime[i, j] = NBD - (NBD - NB);
                                                tw.Write(Branch[i, j] + " ");

                                            }
                                        }
                                        tw.WriteLine();
                                    }
                                }

                                if (CC != 0)
                                {

                                    string NewDprimeBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Dprime\Dprime" + IdentityNoPsec + "\\Branch" + (foldersNeed.Count + 1) + "\\";

                                    string BranchDelete = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\BranchDeleted";

                                    System.IO.Directory.CreateDirectory(NewDprimeBranch);
                                    //  string p = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\" + item2; // your code goes here
                                    var dir2 = new DirectoryInfo(BranchDelete);
                                    dir2.MoveTo(NewDprimeBranch);

                                    //move Branch Delete to Branch On Branch branch new
                                }

                            }

                        }
                    }

                }



            }

            //write in file txt
            using (TextWriter tw = new StreamWriter(path + "Main" + i))
            {
                for (i = 0; i < Main.GetLength(0); i++)
                {
                    for (j = 0; j < Main.GetLength(1); j++)
                    {
                        tw.Write(Main[i, j] + " ");
                    }
                    tw.WriteLine();
                }
            }

            return Tuple.Create(IdentityNoPsec, Main, Branch, BranchOnBranch);


        }
        public Tuple<int, double[,], double[,], double[,]> Ptert9New(int IdentityNoPtert, List<double> BPList, int r8, double CL, double NBD, int? IdentityDprime)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] NewDprime = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];


            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            int BPCounter = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert;
            int i, j;
            List<string> folders = new List<string>();
            List<string> foldersNeed = new List<string>();
            var BLSum = 0.0;
            double[,] result = new double[3, 1];



            string BranchPathName = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert;
            string BranchPathNameNeed = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert;
            //get dir names
            foreach (var d in System.IO.Directory.GetDirectories(BranchPathName))
            {
                var dir = new DirectoryInfo(d);
                var dirName = dir.Name;

                folders.Add(dirName);
            }
            foreach (var d in System.IO.Directory.GetDirectories(BranchPathNameNeed))
            {
                var dir = new DirectoryInfo(d);
                var dirName = dir.Name;
                var resultString = Regex.Match(dirName, @"\d+").Value;

                if (Convert.ToInt32(resultString) <= r8)
                {
                    foldersNeed.Add(dirName);
                }
            }
            foreach (var itemneed in foldersNeed)
            {

                string pathBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\" + itemneed;
                String input = File.ReadAllText(pathBranch);

                int i2 = 0, j2 = 0;
                foreach (var row in input.Split('\n'))
                {
                    j2 = 0;
                    if (i2 <= 2)
                    {
                        foreach (var col in row.Trim().Split(' '))
                        {
                            result[i2, j2] = int.Parse(col.Trim());
                            j2++;
                        }
                    }
                    i2++;
                }

                for (int ii = 0; ii < result.GetLength(0); ii++)
                {
                    for (int jj = 0; jj < result.GetLength(0); jj++)
                    {
                        if (ii == 1 && jj == 0)
                        {
                            BLSum += result[ii, jj];
                        }
                    }

                }

            }

            //main
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {

                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoPtert;
                    }
                    if (i == 1 && j == 0)
                    {
                        Main[i, j] = BLSum + r8;
                    }
                    if (i == 2 && j == 0)
                    {
                        for (int ii = 0; ii <= BPList.Count; ii++)
                        {
                            foreach (var item in BPList)
                            {
                                if (r8 <= item)
                                {
                                    BPCounter += 1;
                                }

                            }
                        }
                        NB = BPCounter + 1;

                        Main[i, j] = NB;
                    }


                    string BranchPath = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\Branch" + (NB + 1);
                    // var directory2 = new DirectoryInfo(pathBranch);
                    var directoryInfo = new System.IO.DirectoryInfo(BranchPath);
                    int directoryCount = directoryInfo.GetDirectories().Length;
                    //end
                    if (NB != 0)
                    {



                        foreach (var item in folders)
                        {
                            foreach (var item2 in foldersNeed)
                            {
                                if (item != item2)
                                {
                                    string NewPathOfBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\BranchDeleted";

                                    System.IO.Directory.CreateDirectory(NewPathOfBranch);
                                    string p = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\" + item2; // your code goes here
                                    var dir = new DirectoryInfo(p);
                                    dir.MoveTo(NewPathOfBranch);
                                    //move
                                }
                            }
                        }

                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(0); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = r8;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = ((CL - BLSum) - r8);
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = NBD - NB;
                                }

                                string NewPathBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\Branch" + (foldersNeed.Count + 1);

                                System.IO.Directory.CreateDirectory(NewPathBranch);

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(NewPathBranch + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            if (i == 0 && j == 0)
                                            {
                                                Branch[i, j] = r8;
                                                tw.Write(Branch[i, j] + " ");

                                            }
                                            if (i == 1 && j == 0)
                                            {
                                                Branch[i, j] = 1;
                                                tw.Write(Branch[i, j] + " ");
                                            }
                                            if (i == 2 && j == 0)
                                            {
                                                Branch[i, j] = 0;
                                                tw.Write(Branch[i, j] + " ");

                                            }
                                        }
                                        tw.WriteLine();
                                    }
                                }



                                string NewPathDPrime = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Dprime\Dprime" + IdentityNoPtert + "\\Dprime" + (foldersNeed.Count + 1) + "\\Dprime";
                                var dir = System.IO.Directory.CreateDirectory(NewPathDPrime);
                                //write in file txt
                                using (TextWriter tw = new StreamWriter(NewPathDPrime + "Dprime"[i]))
                                {
                                    for (j = 0; j < NewDprime.GetLength(0); j++)
                                    {
                                        for (i = 0; i < NewDprime.GetLength(1); i++)
                                        {
                                            if (i == 0 && j == 0)
                                            {
                                                NewDprime[i, j] = Convert.ToDouble(IdentityDprime + 1);
                                                tw.Write(Branch[i, j] + " ");

                                            }
                                            if (i == 1 && j == 0)
                                            {
                                                NewDprime[i, j] = CL - (BLSum + r8);
                                                tw.Write(Branch[i, j] + " ");
                                            }
                                            if (i == 2 && j == 0)
                                            {
                                                NewDprime[i, j] = NBD - (NBD - NB);
                                                tw.Write(Branch[i, j] + " ");

                                            }
                                        }
                                        tw.WriteLine();
                                    }
                                }

                                if (CC != 0)
                                {

                                    string NewDprimeBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Dprime\Dprime" + IdentityNoPtert + "\\Branch" + (foldersNeed.Count + 1) + "\\";

                                    string BranchDelete = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\BranchDeleted";

                                    System.IO.Directory.CreateDirectory(NewDprimeBranch);
                                    //  string p = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\" + item2; // your code goes here
                                    var dir2 = new DirectoryInfo(BranchDelete);
                                    dir2.MoveTo(NewDprimeBranch);

                                    //move Branch Delete to Branch On Branch branch new
                                }

                            }

                        }
                    }

                }



            }

            //write in file txt
            using (TextWriter tw = new StreamWriter(path + "Main" + i))
            {
                for (i = 0; i < Main.GetLength(0); i++)
                {
                    for (j = 0; j < Main.GetLength(1); j++)
                    {
                        tw.Write(Main[i, j] + " ");
                    }
                    tw.WriteLine();
                }
            }

            return Tuple.Create(IdentityNoPtert, Main, Branch, BranchOnBranch);


        }

        public Tuple<int, double[,], double[,], double[,]> Ptert8New(int IdentityNoPtert, List<double> BPList, int r8, double CL, double NBD)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];


            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            int BPCounter = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert;
            int i, j;
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {

                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoPtert;
                    }
                    if (i == 1 && j == 0)
                    {
                        Main[i, j] = CL;
                    }
                    if (i == 2 && j == 0)
                    {
                        for (int ii = 0; ii <= BPList.Count; ii++)
                        {
                            foreach (var item in BPList)
                            {
                                if (r8 <= item)
                                {
                                    BPCounter += 1;
                                }

                            }
                        }
                        NB = BPCounter + 1;

                        Main[i, j] = NB;
                    }


                    string BranchPath = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\Branch" + (NB + 1);
                    // var directory2 = new DirectoryInfo(pathBranch);
                    var directoryInfo = new System.IO.DirectoryInfo(BranchPath);
                    int directoryCount = directoryInfo.GetDirectories().Length;
                    List<string> folders = new List<string>();
                    List<string> foldersNeed = new List<string>();

                    string BranchPathName = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert;
                    string BranchPathNameNeed = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert;
                    //get dir names
                    foreach (var d in System.IO.Directory.GetDirectories(BranchPathName))
                    {
                        var dir = new DirectoryInfo(d);
                        var dirName = dir.Name;

                        folders.Add(dirName);
                    }
                    foreach (var d in System.IO.Directory.GetDirectories(BranchPathNameNeed))
                    {
                        var dir = new DirectoryInfo(d);
                        var dirName = dir.Name;
                        var resultString = Regex.Match(dirName, @"\d+").Value;

                        if (Convert.ToInt32(resultString) <= r8)
                        {
                            foldersNeed.Add(dirName);
                        }
                    }
                    //end
                    if (NB != 0)
                    {



                        foreach (var item in folders)
                        {
                            foreach (var item2 in foldersNeed)
                            {


                                if (item != item2)
                                {
                                    string NewPathOfBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\BranchDeleted";

                                    System.IO.Directory.CreateDirectory(NewPathOfBranch);
                                    string p = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\" + item2; // your code goes here
                                    var dir = new DirectoryInfo(p);
                                    dir.MoveTo(NewPathOfBranch);
                                    //move
                                }
                            }
                        }
                        var BLSum = 0.0;
                        double[,] result = new double[3, 1];

                        foreach (var itemneed in foldersNeed)
                        {

                            string pathBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\" + itemneed;
                            String input = File.ReadAllText(pathBranch);

                            int i2 = 0, j2 = 0;
                            foreach (var row in input.Split('\n'))
                            {
                                j2 = 0;
                                if (i2 <= 2)
                                {
                                    foreach (var col in row.Trim().Split(' '))
                                    {
                                        result[i2, j2] = int.Parse(col.Trim());
                                        j2++;
                                    }
                                }
                                i2++;
                            }

                            for (int ii = 0; ii < result.GetLength(0); ii++)
                            {
                                for (int jj = 0; jj < result.GetLength(0); jj++)
                                {
                                    if (ii == 1 && jj == 0)
                                    {
                                        BLSum += result[ii, jj];
                                    }
                                }

                            }

                        }
                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(0); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = r8;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = ((CL - BLSum) - r8);
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = NBD - NB;
                                }

                                string NewPathBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\Branch" + (foldersNeed.Count + 1);

                                System.IO.Directory.CreateDirectory(NewPathBranch);

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(NewPathBranch + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            tw.Write(Branch[i, j] + " ");
                                        }
                                        tw.WriteLine();
                                    }
                                }


                                if (CC != 0)
                                {

                                    string NewPathBranchOnBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\Branch" + (foldersNeed.Count + 1) + "\\BranchOnBranch";

                                    string BranchDelete = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\BranchDeleted";

                                    System.IO.Directory.CreateDirectory(NewPathBranchOnBranch);
                                    //  string p = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\" + item2; // your code goes here
                                    var dir = new DirectoryInfo(BranchDelete);
                                    dir.MoveTo(NewPathBranchOnBranch);

                                    //move Branch Delete to Branch On Branch branch new
                                }
                            }

                        }
                    }

                }



            }

            //write in file txt
            using (TextWriter tw = new StreamWriter(path + "Ptert" + i))
            {
                for (i = 0; i < Main.GetLength(0); i++)
                {
                    for (j = 0; j < Main.GetLength(1); j++)
                    {
                        tw.Write(Main[i, j] + " ");
                    }
                    tw.WriteLine();
                }
            }

            return Tuple.Create(IdentityNoPtert, Main, Branch, BranchOnBranch);


        }
        public Tuple<int, double[,], double[,], double[,]> Psec8New(int IdentityNoPsec, List<double> BPList, int r8, double CL, double NBD)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];


            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            int BPCounter = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec;
            int i, j;
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {

                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoPsec;
                    }
                    if (i == 1 && j == 0)
                    {
                        Main[i, j] = CL;
                    }
                    if (i == 2 && j == 0)
                    {
                        for (int ii = 0; ii <= BPList.Count; ii++)
                        {
                            foreach (var item in BPList)
                            {
                                if (r8 <= item)
                                {
                                    BPCounter += 1;
                                }

                            }
                        }
                        NB = BPCounter + 1;

                        Main[i, j] = NB;
                    }


                    string BranchPath = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\Branch" + (NB + 1);
                    // var directory2 = new DirectoryInfo(pathBranch);
                    var directoryInfo = new System.IO.DirectoryInfo(BranchPath);
                    int directoryCount = directoryInfo.GetDirectories().Length;
                    List<string> folders = new List<string>();
                    List<string> foldersNeed = new List<string>();

                    string BranchPathName = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec;
                    string BranchPathNameNeed = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec;
                    //get dir names
                    foreach (var d in System.IO.Directory.GetDirectories(BranchPathName))
                    {
                        var dir = new DirectoryInfo(d);
                        var dirName = dir.Name;

                        folders.Add(dirName);
                    }
                    foreach (var d in System.IO.Directory.GetDirectories(BranchPathNameNeed))
                    {
                        var dir = new DirectoryInfo(d);
                        var dirName = dir.Name;
                        var resultString = Regex.Match(dirName, @"\d+").Value;

                        if (Convert.ToInt32(resultString) <= r8)
                        {
                            foldersNeed.Add(dirName);
                        }
                    }
                    //end
                    if (NB != 0)
                    {



                        foreach (var item in folders)
                        {
                            foreach (var item2 in foldersNeed)
                            {


                                if (item != item2)
                                {
                                    string NewPathOfBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\BranchDeleted";

                                    System.IO.Directory.CreateDirectory(NewPathOfBranch);
                                    string p = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\" + item2; // your code goes here
                                    var dir = new DirectoryInfo(p);
                                    dir.MoveTo(NewPathOfBranch);
                                    //move
                                }
                            }
                        }
                        var BLSum = 0.0;
                        double[,] result = new double[3, 1];

                        foreach (var itemneed in foldersNeed)
                        {

                            string pathBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\" + itemneed;
                            String input = File.ReadAllText(pathBranch);

                            int i2 = 0, j2 = 0;
                            foreach (var row in input.Split('\n'))
                            {
                                j2 = 0;
                                if (i2 <= 2)
                                {
                                    foreach (var col in row.Trim().Split(' '))
                                    {
                                        result[i2, j2] = int.Parse(col.Trim());
                                        j2++;
                                    }
                                }
                                i2++;
                            }

                            for (int ii = 0; ii < result.GetLength(0); ii++)
                            {
                                for (int jj = 0; jj < result.GetLength(0); jj++)
                                {
                                    if (ii == 1 && jj == 0)
                                    {
                                        BLSum += result[ii, jj];
                                    }
                                }

                            }

                        }
                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(0); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = r8;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = ((CL - BLSum) - r8);
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = NBD - NB;
                                }

                                string NewPathBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\Branch" + (foldersNeed.Count + 1);

                                System.IO.Directory.CreateDirectory(NewPathBranch);

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(NewPathBranch + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            tw.Write(Branch[i, j] + " ");
                                        }
                                        tw.WriteLine();
                                    }
                                }


                                if (CC != 0)
                                {

                                    string NewPathBranchOnBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\Branch" + (foldersNeed.Count + 1) + "\\BranchOnBranch";

                                    string BranchDelete = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Psec\Psec" + IdentityNoPsec + "\\BranchDeleted";

                                    System.IO.Directory.CreateDirectory(NewPathBranchOnBranch);
                                    //  string p = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoPtert + "\\" + item2; // your code goes here
                                    var dir = new DirectoryInfo(BranchDelete);
                                    dir.MoveTo(NewPathBranchOnBranch);

                                    //move Branch Delete to Branch On Branch branch new
                                }
                            }

                        }
                    }

                }



            }

            //write in file txt
            using (TextWriter tw = new StreamWriter(path + "Psec" + i))
            {
                for (i = 0; i < Main.GetLength(0); i++)
                {
                    for (j = 0; j < Main.GetLength(1); j++)
                    {
                        tw.Write(Main[i, j] + " ");
                    }
                    tw.WriteLine();
                }
            }

            return Tuple.Create(IdentityNoPsec, Main, Branch, BranchOnBranch);


        }
        public Tuple<int, double[,], double[,], double[,]> P9New(int IdentityNoP, List<double> BPList, int r8, double CL, double NBD)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];


            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            int BPCounter = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP;
            int i, j;
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {

                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoP;
                    }
                    if (i == 1 && j == 0)
                    {
                        Main[i, j] = CL;
                    }
                    if (i == 2 && j == 0)
                    {
                        for (int ii = 0; ii <= BPList.Count; ii++)
                        {
                            foreach (var item in BPList)
                            {
                                if (r8 <= item)
                                {
                                    BPCounter += 1;
                                }

                            }
                        }
                        NB = BPCounter + 1;

                        Main[i, j] = NB;
                    }


                    string BranchPath = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP + "\\Branch" + (NB + 1);
                    // var directory2 = new DirectoryInfo(pathBranch);
                    var directoryInfo = new System.IO.DirectoryInfo(BranchPath);
                    int directoryCount = directoryInfo.GetDirectories().Length;
                    List<string> folders = new List<string>();
                    List<string> foldersNeed = new List<string>();

                    string BranchPathName = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP;
                    string BranchPathNameNeed = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP;
                    //get dir names
                    foreach (var d in System.IO.Directory.GetDirectories(BranchPathName))
                    {
                        var dir = new DirectoryInfo(d);
                        var dirName = dir.Name;

                        folders.Add(dirName);
                    }
                    foreach (var d in System.IO.Directory.GetDirectories(BranchPathNameNeed))
                    {
                        var dir = new DirectoryInfo(d);
                        var dirName = dir.Name;
                        var resultString = Regex.Match(dirName, @"\d+").Value;

                        if (Convert.ToInt32(resultString) <= r8)
                        {
                            foldersNeed.Add(dirName);
                        }
                    }
                    //end
                    if (NB != 0)
                    {



                        foreach (var item in folders)
                        {
                            foreach (var item2 in foldersNeed)
                            {


                                if (item != item2)
                                {
                                    string NewPathOfBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP + "\\BranchDeleted";

                                    System.IO.Directory.CreateDirectory(NewPathOfBranch);
                                    string p = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP + "\\" + item2; // your code goes here
                                    var dir = new DirectoryInfo(p);
                                    dir.MoveTo(NewPathOfBranch);
                                    //move
                                }
                            }
                        }
                        var BLSum = 0.0;
                        double[,] result = new double[3, 1];

                        foreach (var itemneed in foldersNeed)
                        {

                            string pathBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP + "\\" + itemneed;
                            String input = File.ReadAllText(pathBranch);

                            int i2 = 0, j2 = 0;
                            foreach (var row in input.Split('\n'))
                            {
                                j2 = 0;
                                if (i2 <= 2)
                                {
                                    foreach (var col in row.Trim().Split(' '))
                                    {
                                        result[i2, j2] = int.Parse(col.Trim());
                                        j2++;
                                    }
                                }
                                i2++;
                            }

                            for (int ii = 0; ii < result.GetLength(0); ii++)
                            {
                                for (int jj = 0; jj < result.GetLength(0); jj++)
                                {
                                    if (ii == 1 && jj == 0)
                                    {
                                        BLSum += result[ii, jj];
                                    }
                                }

                            }

                        }
                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(0); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = r8;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = ((CL - BLSum) - r8);
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = NBD - NB;
                                }

                                string NewPathBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP + "\\Branch" + (foldersNeed.Count + 1);

                                System.IO.Directory.CreateDirectory(NewPathBranch);

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(NewPathBranch + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            tw.Write(Branch[i, j] + " ");
                                        }
                                        tw.WriteLine();
                                    }
                                }


                                if (CC != 0)
                                {

                                    string NewPathBranchOnBranch = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP + "\\Branch" + (foldersNeed.Count + 1) + "\\BranchOnBranch";

                                    string BranchDelete = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP + "\\BranchDeleted";

                                    System.IO.Directory.CreateDirectory(NewPathBranchOnBranch);
                                    //  string p = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\Ptert\Ptert" + IdentityNoP + "\\" + item2; // your code goes here
                                    var dir = new DirectoryInfo(BranchDelete);
                                    dir.MoveTo(NewPathBranchOnBranch);

                                    //move Branch Delete to Branch On Branch branch new
                                }
                            }

                        }
                    }

                }



            }

            //write in file txt
            using (TextWriter tw = new StreamWriter(path + "Main" + i))
            {
                for (i = 0; i < Main.GetLength(0); i++)
                {
                    for (j = 0; j < Main.GetLength(1); j++)
                    {
                        tw.Write(Main[i, j] + " ");
                    }
                    tw.WriteLine();
                }
            }

            return Tuple.Create(IdentityNoP, Main, Branch, BranchOnBranch);


        }





        //   return IdentityNo;



        public Tuple<int, double[,], double[,], double[,]> Ptert(int IdentityNoPtert)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];

            int CL = 0;
            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\";
            int i, j;
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {

                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoPtert;
                    }
                    if (i == 1 && j == 0)
                    {
                        Main[i, j] = CL;
                    }
                    if (i == 2 && j == 0)
                    {
                        Main[i, j] = NB;
                    }

                    if (NB != 0)
                    {
                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(1); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = BP;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = BL;
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = CC;
                                }

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(path + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            tw.Write(Branch[i, j] + " ");
                                        }
                                        tw.WriteLine();
                                    }
                                }


                                if (CC != 0)
                                {
                                    for (i = 0; i < BranchOnBranch.GetLength(0); i++)
                                    {
                                        for (j = 0; j < BranchOnBranch.GetLength(1); j++)
                                        {

                                            if (i == 0 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bp;
                                            }
                                            if (i == 1 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bl;
                                            }

                                            //write in file txt
                                            using (TextWriter tw = new StreamWriter(path + "BranchOnBranch"[i]))
                                            {
                                                for (j = 0; j < BranchOnBranch.GetLength(0); j++)
                                                {
                                                    for (i = 0; i < BranchOnBranch.GetLength(1); i++)
                                                    {
                                                        tw.Write(BranchOnBranch[i, j] + " ");
                                                    }
                                                    tw.WriteLine();
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }


                    //write in file txt
                    using (TextWriter tw = new StreamWriter(path + "Main" + i))
                    {
                        for (i = 0; i < Main.GetLength(0); i++)
                        {
                            for (j = 0; j < Main.GetLength(1); j++)
                            {
                                tw.Write(Main[i, j] + " ");
                            }
                            tw.WriteLine();
                        }
                    }



                }

            }




            return Tuple.Create(IdentityNoPtert, Main, Branch, BranchOnBranch);


        }

        public Tuple<int, double[,], double[,], double[,]> D(int IdentityNoD)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];

            int CL = 0;
            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\";
            int i, j;
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {

                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoD;
                    }
                    if (i == 1 && j == 0)
                    {
                        Main[i, j] = CL;
                    }
                    if (i == 2 && j == 0)
                    {
                        Main[i, j] = NB;
                    }

                    if (NB != 0)
                    {
                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(1); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = BP;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = BL;
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = CC;
                                }

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(path + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            tw.Write(Branch[i, j] + " ");
                                        }
                                        tw.WriteLine();
                                    }
                                }


                                if (CC != 0)
                                {
                                    for (i = 0; i < BranchOnBranch.GetLength(0); i++)
                                    {
                                        for (j = 0; j < BranchOnBranch.GetLength(1); j++)
                                        {

                                            if (i == 0 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bp;
                                            }
                                            if (i == 1 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bl;
                                            }

                                            //write in file txt
                                            using (TextWriter tw = new StreamWriter(path + "BranchOnBranch"[i]))
                                            {
                                                for (j = 0; j < BranchOnBranch.GetLength(0); j++)
                                                {
                                                    for (i = 0; i < BranchOnBranch.GetLength(1); i++)
                                                    {
                                                        tw.Write(BranchOnBranch[i, j] + " ");
                                                    }
                                                    tw.WriteLine();
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }


                    //write in file txt
                    using (TextWriter tw = new StreamWriter(path + "Main" + i))
                    {
                        for (i = 0; i < Main.GetLength(0); i++)
                        {
                            for (j = 0; j < Main.GetLength(1); j++)
                            {
                                tw.Write(Main[i, j] + " ");
                            }
                            tw.WriteLine();
                        }
                    }



                }

            }




            return Tuple.Create(IdentityNoD, Main, Branch, BranchOnBranch);


        }

        public Tuple<int, double[,], double[,], double[,]> Dprime(int IdentityNoDprime)
        {
            double[,] Main = new double[3, 1];
            double[,] Branch = new double[3, 1];
            double[,] BranchOnBranch = new double[2, 1];

            int CL = 0;
            int NB = 0;
            int BP = 0;
            int BL = 0;
            int CC = 0;
            int bl = 0;
            int bp = 0;
            string path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\";
            int i, j;
            for (i = 0; i < Main.GetLength(0); i++)
            {
                for (j = 0; j < Main.GetLength(1); j++)
                {

                    if (i == 0 && j == 0)
                    {
                        Main[i, j] = IdentityNoDprime;
                    }
                    if (i == 1 && j == 0)
                    {
                        Main[i, j] = CL;
                    }
                    if (i == 2 && j == 0)
                    {
                        Main[i, j] = NB;
                    }

                    if (NB != 0)
                    {
                        for (i = 0; i < Branch.GetLength(0); i++)
                        {
                            for (j = 0; j < Branch.GetLength(1); j++)
                            {

                                if (i == 0 && j == 0)
                                {
                                    Branch[i, j] = BP;
                                }
                                if (i == 1 && j == 0)
                                {
                                    Branch[i, j] = BL;
                                }
                                if (i == 2 && j == 0)
                                {
                                    Branch[i, j] = CC;
                                }

                                //write in file txt
                                using (TextWriter tw = new StreamWriter(path + "Branch"[i]))
                                {
                                    for (j = 0; j < Branch.GetLength(0); j++)
                                    {
                                        for (i = 0; i < Branch.GetLength(1); i++)
                                        {
                                            tw.Write(Branch[i, j] + " ");
                                        }
                                        tw.WriteLine();
                                    }
                                }


                                if (CC != 0)
                                {
                                    for (i = 0; i < BranchOnBranch.GetLength(0); i++)
                                    {
                                        for (j = 0; j < BranchOnBranch.GetLength(1); j++)
                                        {

                                            if (i == 0 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bp;
                                            }
                                            if (i == 1 && j == 0)
                                            {
                                                BranchOnBranch[i, j] = bl;
                                            }

                                            //write in file txt
                                            using (TextWriter tw = new StreamWriter(path + "BranchOnBranch"[i]))
                                            {
                                                for (j = 0; j < BranchOnBranch.GetLength(0); j++)
                                                {
                                                    for (i = 0; i < BranchOnBranch.GetLength(1); i++)
                                                    {
                                                        tw.Write(BranchOnBranch[i, j] + " ");
                                                    }
                                                    tw.WriteLine();
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }


                    //write in file txt
                    using (TextWriter tw = new StreamWriter(path + "Main" + i))
                    {
                        for (i = 0; i < Main.GetLength(0); i++)
                        {
                            for (j = 0; j < Main.GetLength(1); j++)
                            {
                                tw.Write(Main[i, j] + " ");
                            }
                            tw.WriteLine();
                        }
                    }



                }

            }




            return Tuple.Create(IdentityNoDprime, Main, Branch, BranchOnBranch);


        }





        public double[,] SearchMatrix(int? IdentityNo, string Name)
        {
            double[,] list = new double[3, 1];
            double[,] result = new double[3, 1];
            if (Name != null)
            {
                string Path = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\" + Name + "\\" + Name + IdentityNo.Value + ".txt";
                String input = File.ReadAllText(Path);

                int i = 0, j = 0;
                foreach (var row in input.Split('\n'))
                {
                    j = 0;
                    if (i <= 2)
                    {
                        foreach (var col in row.Trim().Split(' '))
                        {
                            result[i, j] = int.Parse(col.Trim());
                            j++;
                        }
                    }
                    i++;
                }

                //string input = @"F:\work staff\MyProjects\AhmadTaheri\Matrix\" + Name+0+".txt";
                //StreamReader reader = new StreamReader(input);

                //int i = 0, j = 0;
                //foreach (var row in reader.ToString())
                //{
                //    var t = row;
                //    j = 0;
                //    //foreach (var col in row.Trim())
                //    //{
                //    //    list[i, j] = int.Parse(col.ToString());
                //    //}
                //    i++;
                //}


                //char[] unwanted = new char[] { ' ' };
                //using (reader)
                //{
                //    int row = 0;
                //    int column = 0;
                //    string line = reader.ReadLine();

                //    while (line != null)
                //    {
                //        string[] numbersString = line.Split(unwanted);
                //        int[,] numbersInt = new int[row, numbersString.Length];
                //        foreach (string a in numbersString)
                //        {

                //            Console.Write("{0} ", a);// this is to check that the array was read in the right order
                //            numbersInt[row, column] = int.Parse(a);
                //            column++;
                //        }
                //        line = reader.ReadLine();
                //        Console.WriteLine();
                //        row++;
                //    }
                //}
            }
            return result;
        }


        public FileInfo GetLastFile(DirectoryInfo directoryInfo)
        {
            if (directoryInfo == null || !directoryInfo.Exists)
                return null;

            FileInfo[] files = directoryInfo.GetFiles();
            DateTime lastWrite = DateTime.MinValue;
            FileInfo lastWritenFile = null;

            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastWrite)
                {
                    lastWrite = file.LastWriteTime;
                    lastWritenFile = file;
                }
            }
            return lastWritenFile;
        }

    }
}
