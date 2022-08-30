using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadTaheri
{
    class Reactors
    {
        // bare aval ke vared in reactor mishe n taqir kone va update beshe(2,3,4)
        public Tuple<double,int,double[,]> reactors(double[,] N,double Time,Double Temperature,int MATRIX_ROWS,int MATRIX_COLUMNS,double la2Original,double lc2Original,double la3Original,double la4Original)
        {
            double[,] NewN = new double[MATRIX_ROWS, MATRIX_COLUMNS];
            int i, j,flag;
            int ReactorNumber = 0;

            if (Time >= 0 && Time <= 100)
            {
                Temperature = 1.35 * Time + 165;
                Console.WriteLine("temperature : ");
                Console.WriteLine(Temperature);
                ReactorNumber = 1;
                try
                {

                return Tuple.Create(Temperature,ReactorNumber,N);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            if (Time >= 101 && Time <= 270)
            {
                Temperature = Math.Pow((-0.0037 * Time), 2) + 0.8 * Time + 254.1;
                Console.WriteLine("temperature : ");
                Console.WriteLine(Temperature);
                ReactorNumber = 1;
                try
                {

                return Tuple.Create(Temperature, ReactorNumber, N);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            if (Time >= 271 && Time <= 310)
            {
                Temperature = 2.4 * Time - 447.2;
                Console.WriteLine("temperature : ");
                Console.WriteLine(Temperature);
                ReactorNumber = 2;

                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        flag = 0;
                        if (i == 0 && j == 0 && flag == 0)
                        {
                            NewN[i, j] = la2Original;
                            flag = +1;
                        }
                        if (i == 1 && j == 0 && flag == 0)
                        {
                            NewN[i, j] = lc2Original;
                            flag = +1;
                        }
                        else if (flag == 0)
                        {
                            NewN[i, j] = 0;
                        }
                        //M[i, j] = int.Parse(Console.ReadLine());
                    }

                }
                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        N[i, j] = N[i, j] + NewN[i, j];

                    }
                }
                return Tuple.Create(Temperature, ReactorNumber, NewN);

            }

            if (Time >= 311 && Time <= 470)
            {
                Temperature = Math.Pow((-0.0038 * Time), 2) + 2.5 * Time - 113.1;
                ReactorNumber = 2;
                Console.WriteLine("temperature : ");
                Console.WriteLine(Temperature);
                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        flag = 0;
                        if (i == 0 && j == 0 && flag == 0)
                        {
                            NewN[i, j] = la2Original;
                            flag = +1;
                        }
                        if (i == 1 && j == 0 && flag == 0)
                        {
                            NewN[i, j] = lc2Original;
                            flag = +1;
                        }
                        else if (flag == 0)
                        {
                            NewN[i, j] = 0;
                        }
                        //M[i, j] = int.Parse(Console.ReadLine());
                    }

                }
                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        N[i, j] = N[i, j] + NewN[i, j];

                    }
                }
                return Tuple.Create(Temperature, ReactorNumber, NewN);

            }


            if (Time >= 471 && Time <= 520)
            {
                Temperature = 1.43 * Time - 442.9;
                Console.WriteLine("temperature : ");
                Console.WriteLine(Temperature);
                ReactorNumber = 3;

                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        flag = 0;
                        if (i == 0 && j == 0 && flag == 0)
                        {
                            NewN[i, j] = la3Original;
                            flag = +1;
                        }
                        else if (flag == 0)
                        {
                            NewN[i, j] = 0;
                        }
                        //M[i, j] = int.Parse(Console.ReadLine());
                    }

                }
                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        N[i, j] = N[i, j] + NewN[i, j];

                    }
                }
                return Tuple.Create(Temperature, ReactorNumber, NewN);


            }

            if (Time >= 521 && Time <= 650)
            {
                Temperature = Math.Pow((-0.0048 * Time), 2) + 5.2 * Time - 1110;
                ReactorNumber = 3;
                Console.WriteLine("temperature : ");
                Console.WriteLine(Temperature);
                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        flag = 0;
                        if (i == 0 && j == 0 && flag == 0)
                        {
                            NewN[i, j] = la3Original;
                            flag = +1;
                        }
                        else if (flag == 0)
                        {
                            NewN[i, j] = 0;
                        }
                        //M[i, j] = int.Parse(Console.ReadLine());
                    }

                }
                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        N[i, j] = N[i, j] + NewN[i, j];

                    }
                }
                return Tuple.Create(Temperature, ReactorNumber, NewN);

            }


            if (Time >= 651 && Time <= 670)
            {
                Temperature = 2.63 * Time - 1463;
                Console.WriteLine("temperature : ");
                ReactorNumber = 4;
                Console.WriteLine(Temperature);
                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        flag = 0;
                        if (i == 0 && j == 0 && flag == 0)
                        {
                            NewN[i, j] = la4Original;
                            flag = +1;
                        }
                        else if (flag == 0)
                        {
                            NewN[i, j] = 0;
                        }
                        //M[i, j] = int.Parse(Console.ReadLine());
                    }

                }
                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        N[i, j] = N[i, j] + NewN[i, j];

                    }
                }
                return Tuple.Create(Temperature, ReactorNumber, NewN);


            }

            if (Time >= 671 && Time <= 840)
            {
                ReactorNumber = 4;
                Temperature = Math.Pow((-0.002 * Time), 2) + 2.35 * Time - 497.6;
                Console.WriteLine("temperature : ");
                Console.WriteLine(Temperature);
                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        flag = 0;
                        if (i == 0 && j == 0 && flag == 0)
                        {
                            NewN[i, j] = la4Original;
                            flag = +1;
                        }
                        else if (flag == 0)
                        {
                            NewN[i, j] = 0;
                        }
                        //M[i, j] = int.Parse(Console.ReadLine());
                    }

                }
                for (i = 0; i < MATRIX_ROWS; i++)
                {
                    for (j = 0; j < MATRIX_COLUMNS; j++)
                    {
                        N[i, j] = N[i, j] + NewN[i, j];

                    }
                }
                return Tuple.Create(Temperature, ReactorNumber, NewN);


            }
            else
            {
                return Tuple.Create(Temperature, ReactorNumber, N);

            }

        }

    }
}
