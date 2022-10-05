// See https://aka.ms/new-console-template for more information


using System;

public class TresEnRaya1
{

  
    static int[,] tablero = new int[3, 3];
    static char[] simbolo = { ' ', 'O', 'X' };


 
    public static void Main()
    {
        bool terminado = false;

 

    }
    
    static void llenado (int jugador)
    {
        int fila, columna;
       
    }
 

    static void DibujarTablero()
    {
     
        for (int i=0; i<3; i++)
        {
            for(int j=0; j<3; j++)
            {
                Console.WriteLine();
                Console.WriteLine(tablero[i,j]);
            }

        }
    }



}