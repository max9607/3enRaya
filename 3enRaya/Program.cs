﻿// See https://aka.ms/new-console-template for more information


using System;

public class TresEnRaya1
{



    static int[,] tablero = new int[3, 3];
    static char[] simbolo = { ' ', 'O', 'X' };


 
    public static void Main()
    {
        bool partida = false;
        char[,] tablero = new char[3, 3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
        //int[,] tablero = new int[3, 3] { { 1,2,3}, { 4,5,6}, { 7,8,9 } };
        while(partida == false)
        {
            int x = 0;
            int y = 0;
            DibujarTablero(tablero);

            do
            {
                Console.WriteLine("Escriba Coordenadas X");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba Coordenadas Y");
                y = Convert.ToInt32(Console.ReadLine());

            } while (x > 2 || y > 2);
            llenado(x, y, tablero);



        }
       
    }
    static void llenado(int x,int y, char[,] m)
    {
        
            
                m[x, y]='x';
            
            

        

    }
    static void DibujarTablero(char[,] m)
    {
        Console.WriteLine("0----1----2");
        for(int i= 0; i < 3; i++)
        {
            for(int j= 0; j < 3; j++)
            {
                Console.Write("| ");
                Console.Write(m[i,j]);
            }
            Console.Write(" | "+i);
            Console.WriteLine();
            

        }
        
    }
    


}