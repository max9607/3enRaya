// See https://aka.ms/new-console-template for more information


using System;

public class TresEnRaya1
{

  
    static int[,] tablero = new int[3, 3];
    static char[] simbolo = { ' ', 'O', 'X' };


 
    public static void Main()
    {
        bool terminado = false;

      
        DibujarTablero();
        do
        {
          
          
           
            
        } while (!terminado);
    }
    
    static void llenado (int jugador)
    {
        int fila, columna;
       
    }
 

    static void DibujarTablero()
    {
        Console.WriteLine();
        Console.WriteLine("-------------");
        for (int fila = 0; fila < 3; fila++)
        {
            Console.Write("|");
            for (int columna = 0; columna < 3; columna++)
                Console.Write(" {0} |", simbolo[tablero[fila, columna]]);
            Console.WriteLine();
            Console.WriteLine("-------------");
        }
    }



}