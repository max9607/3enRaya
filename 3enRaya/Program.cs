// See https://aka.ms/new-console-template for more information


using System;

public class TresEnRaya1
{

  
    

    static char[] simbolo = { ' ', 'O', 'X' };


 
    public static void Main()
    {
        bool partida = false;
        char[,] tablero = new char[3, 3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
        DibujarTablero(tablero);

        ///magno le gusta la pinga

        DibujarTablero();
        do
        {
          
          
           
            
        } while (!terminado);
    }
    
    static void DibujarTablero(char[,] m)
    {
        int fila, columna;
       
    }
 

    static void DibujarTablero(char[,] m)
    {
        /*Console.WriteLine();
        Console.WriteLine("-------------");
        for (int fila = 0; fila < 3; fila++)
        {
            Console.Write("|");
            for (int columna = 0; columna < 3; columna++)
                Console.Write(" {0} |", simbolo[tablero[fila, columna]]);
            Console.WriteLine();
            Console.WriteLine("-------------");
        }*/
        for(int i= 0; i < 3; i++)
        {
            for(int j= 0; j < 3; j++)
            {
                Console.Write("| ");
                Console.Write(m[i,j]);
            }
            Console.Write(" |");
            Console.WriteLine();
            //hola
        }
    }



}