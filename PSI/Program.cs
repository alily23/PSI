using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Media;
using System.Diagnostics;
using System.IO;

namespace PSI
{
    class Program
    {
        static void Main(string[] args)
        {

            byte[] myfile = File.ReadAllBytes("coco.bmp");

            Console.WriteLine("\n Header \n");
            for (int i = 0; i < 14; i++)
            {
                Console.Write(myfile[i] + " ");
            }
            Console.WriteLine("\n HEADER INFO \n");
            for (int i = 14; i < 54; i++)
            {
                Console.Write(myfile[i] + " ");
            }
            /*
            Console.WriteLine("\n IMAGE \n");
            for(int i = 54; i<myfile.Length; i=i+60)
            {
                for (int j = i; j < i + 60; j++)
                {
                    Console.Write(myfile[j] + " ");
                }
                Console.WriteLine();
            }        */

            //File.WriteAllBytes("./Image/Sortie.bmp", myfile);
            Rotation(myfile);
        }

        public static void Rotation(byte[] myfile)
        {
            Console.WriteLine("\n IMAGE ROTATION \n");
            for (int i = myfile.Length; i > 54; i = i - 60)
            {
                for (int j = i + 60; j < i; j--)
                {
                    Console.Write(myfile[j] + " ");
                }
                Console.WriteLine();
            }
            File.WriteAllBytes("./Image/Rotation.bmp", myfile);
        }
    }
}