using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnit
{
    class Trans
    {
        // поля
        public float R { get; set; }// радиус
        public int N { get; set; }// число пакетов
        public int min { get; set; } // минимальная ширина пакетов (в нашей задаче 200)
        public int max { get; set; } // макимальная ширина пакетов (в нашей задаче 480)
        public int maxL { get; set; } // максимальная толщина верхней половины пакетов  

        public float[] MAXpach { get; set; }// максимальные значения ширины пакетов
        public float[] MAXpacl { get; set; }// максимальные значения длины пакетов

        float[] pach { get; set; }// ширина текущих (рассчитываемых) пакетов
        float[] pacl { get; set; } // длина текущих (рассчитываемых) пакетов

        public float maxS { get; set; }// максимальная площадь пакетов
        public int count { get; set; }// счетчик итераций (по приколу)

        // конструктор
        public Trans(int r, int n, int maxl)
        {
            R = r;
            N = n;
            max = 2 * (r - r % 10);
            min = 100;
            maxL = maxl;
            MAXpach = new float[N];
            MAXpacl = new float[N];
            pach = new float[N];
            pacl = new float[N];
            maxS = 0;
            count = 0;
        }

        //деструктор TODO
        ~Trans()
        {
            Array.Clear(MAXpach, 0, MAXpach.Length);
            Array.Clear(MAXpacl, 0, MAXpacl.Length);
            Array.Clear(pach, 0, pach.Length);
            Array.Clear(pacl, 0, pacl.Length);
        }

        // методы
        float F(float h, int i)// формула рассчета длин пакетов
        {
            if (i == 0)
            {
                return (float)Math.Sqrt(R * R - (h * h / 4)); ;  // формула для 1 пакета ///////////// <------- добавил деление h/4 согласно формуле
            }
            else
            {
                float sum = 0;
                for (int j = 0; j < i; j++)
                {
                    sum += pacl[j];
                }
                return (float)Math.Sqrt(1 - (float)Math.Pow((h / 2) / R, 2)) * R - sum;// формула для 2-5 пакетов ///////////// <------- добавил деление h/2 согласно формуле
            }
        }


        void Sqd()// рассчет площади пакетов и поиск наибольшего (используется для метода search1)
        {
            float S = 0;
            float E = 0; ///////////// <-------
            for (int i = 0; i < N; i++)
            {
                S += pacl[i] * pach[i]; // рассчет площади N пакетов
                E += pacl[i]; /////////////// <------- 
            }
            if (S > maxS & E <= maxL)               /////////////// <------- условие
            {
                maxS = S;
                for (int i = 0; i < N; i++)
                {
                    MAXpach[i] = pach[i];
                    MAXpacl[i] = pacl[i];
                }
            }
        }
        public void search1(int i)// прогонка по всем возможным значениям
        {
            // вычисление пределов перебора ширины пакетов
            int maxloc;
            int minloc;
            if (i == 0)
            {
                maxloc = max;
                minloc = min + 80;
            }
            else
            {
                maxloc = (int)pach[i - 1] - 20;
                minloc = min + (N - 1 - i) * 20;
            }

            // тело перебора ширины пакетов
            for (int j = maxloc; j >= minloc; j -= 20)/*	1 пакет - от 480 до 280
												2 пакет - от 460 до 260
												3 пакет - от 440 до 240
												4 пакет - от 420 до 220
												5 пакет - от 400 до 200*/
            {
                pach[i] = j;
                pacl[i] = F(j, i);


                if (i != N - 1)
                {
                    //cout << "\t" << maxS;
                    search1(i + 1);

                }
                else
                {
                    Sqd();
                    count++;
                }
            }
        }
        public void printARRAY()// вывод габаритов пакетов в консоль
        {
            float e = 0; ///////////// <-------
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("{0} пакетик:\t Ширина = {1} \tТолщина = {2}", i + 1, Math.Round(MAXpach[i], 2), Math.Round(MAXpacl[i], 2));
                e += MAXpacl[i]; ///////////// <-------
            }
            Console.WriteLine("\t Толщина верхней половины пакетов ={0}", e); ///////////// <-------
        }
    }
}
