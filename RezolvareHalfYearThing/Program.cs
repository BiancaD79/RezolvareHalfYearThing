using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezolvareHalfYearThing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Randul 1
            //P1();
            //P2();
            //P3();
            Console.ReadKey();
        }

        private static void P3()
        {
            /*List<float> list = new List<float>();
            TextReader reader = new StreamReader(@"..\..\data3.in");
            string buffer;
            double[,] values = new double[101, 4];
            string[] data_buffer, content_buffer;
            int i;
            double d;
            while ((buffer = reader.ReadLine()) != null)
            {
                content_buffer = buffer.Split('.');
                foreach (string line in content_buffer)
                {
                    data_buffer = line.Split(' ');
                    i = int.Parse(data_buffer[0]);
                    d = double.Parse(data_buffer[1]);
                    values[i, 0]++;
                    values[i, 1] += d;
                    values[i, 2] = values[i, 2] > d ? d : values[i, 2];
                    values[i, 3] = values[i, 3] > d ? d : values[i, 3];
                }
            }*/
            
            TextReader load = new StreamReader(@"..\..\data3.in");
            string buffer;
            string[] content_buffer, data_buffer;
            int i; double d;

            double[,] values = new double[101, 4];

            while ((buffer = load.ReadLine()) != null)
            {
                content_buffer = buffer.Split(',');
                foreach (string entry in content_buffer)
                {
                    data_buffer = entry.Split(' ');
                    i = int.Parse(data_buffer[0]);
                    d = double.Parse(data_buffer[1]);

                    values[i, 0]++;
                    values[i, 1] += d;
                    values[i, 2] = values[i, 2] > d ? d : values[i, 2];
                    values[i, 3] = values[i, 3] < d ? d : values[i, 3];
                }
            }
            TextWriter save = new StreamWriter("data3.out");
            for (i = 0; i < 101; i++)
            {
                if (values[i, 0] == 0)
                    continue;
                save.WriteLine($"dataId: {i}, med: {values[i, 1] / values[i, 0]}" + $", dataId: {i}, med: {values[i, 3] / values[i, 2]}");
            }
        }
        private static void P2()
        {
            List<float> list = new List<float>();
            TextReader reader = new StreamReader(@"..\..\data2.in");
            string buffer;
            while ((buffer = reader.ReadLine()) != null)
            {
                // Asta afiseaza backwards
                /*byte t = byte.Parse(buffer);
                while(t!=0)
                {
                    if(t%2 == 0) Console.Write("0");
                    else
                        Console.Write("X");
                    t /= 2;
                }
                Console.WriteLine();*/
                
                byte t = byte.Parse(buffer);
                bool[] v = new bool[8];
                int i = 0;

                while (t != 0)
                {
                    if (t % 2 == 1) v[i] = true;
                    t /= 2;
                    i++;
                }
                for (i = 7; i >= 0 ; i--)
                {
                    if (v[i]) Console.Write("X");
                    else
                        Console.Write("0");
                }
                Console.WriteLine();
            }
        }

        static void P1()
        {   
            //Citire din fisier
            List<float> list = new List<float>();
            TextReader reader = new StreamReader(@"..\..\data.in");
            string buffer;
            while((buffer = reader.ReadLine()) != null)
            {
                foreach(string s in buffer.Split(' '))
                    list.Add(float.Parse(s));
            }

            //Convertirea in vector
            int n = list.Count;
            float[] floats = new float[n];
            for(int i = 0;i < n; i++)
            {
                floats[i] = list[i];
            }

            reader.Close();

            floats = BubbleSort(floats);
            //pt verificare
            for (int i = 0; i < floats.Length; i++)
            {
                Console.Write(floats[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(floats[floats.Length/2]);
        }

        static float[] BubbleSort(float[] v)
        {
            for (int i = 0; i < v.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[min] > v[j]) min = j;
                }
                if(min != i)
                {
                    float aux = v[min];
                    v[min] = v[i];
                    v[i] = aux;
                }
            }
            return v;
        }
    }
}
