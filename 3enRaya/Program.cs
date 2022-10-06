// See https://aka.ms/new-console-template for more information


using System;
using System.Text.RegularExpressions;

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
            Console.Clear();
            DibujarTablero(tablero);
           

            do
            {
                Console.WriteLine("Escriba Coordenadas X");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba Coordenadas Y");
                x = Convert.ToInt32(Console.ReadLine());

            } while (x > 2 && y > 2);
            llenado(x, y, tablero);
            movimiento(tablero);
          
        }
        partida = ComprobarGanador();
        if (partida)
            Console.WriteLine("gano x");


    }
    static void movimiento(char[,] m)
    {
        bool turno = false;
        Random rd = new Random();
        while (turno == false)
        {
            
            int x = rd.Next(0, 3);
            int y = rd.Next(0, 3);
            if (m[x, y] == '-' && m[x, y] != '0')
            {
                m[x, y] = '0';
                turno = true;
            }
        }
        
    }
    static void llenado(int x,int y, char[,] m)
    {
           m[x, y]='x';
    }
    static void DibujarTablero(char[,] m)
    {
        Console.WriteLine("X 0--1--2   Y");
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
    static bool ComprobarGanador()
    {
        bool hay3enRaya = false;

        for(int fila=0; fila<3; fila++)
            if ((tablero[fila,0]== tablero[fila,1])
                && (tablero[fila,0]== tablero[fila,2])
                && (tablero[fila,0]!=0))
                hay3enRaya=true;

        for (int columna = 0; columna < 3; columna++)
            if ((tablero[0, columna] == tablero[1, columna])
                    && (tablero[0, columna] == tablero[2, columna])
                    && (tablero[0, columna] != 0))
                hay3enRaya = true;

        // Y finalmente miro las dos diagonales
        if ((tablero[0, 0] == tablero[1, 1])
                && (tablero[0, 0] == tablero[2, 2])
                && (tablero[0, 0] != 0))
            hay3enRaya = true;
        if ((tablero[0, 2] == tablero[1, 1])
                && (tablero[0, 2] == tablero[2, 0])
                && (tablero[0, 2] != 0))
            hay3enRaya = true;



        return hay3enRaya;


    }
    


}