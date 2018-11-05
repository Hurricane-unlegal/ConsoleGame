using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_1
{
    class Program
    {
        
        static int frames = 0;
        static int[,] map = new int [11,11];
        static int x = 5;
        static int y = 5;
        static int floor = 1;
        static void Main(string[] args)
        {
            int a = 0;
            mapGen();
            renderMap();
            do
            {
                Input();
            } while (a != 1);             
            Console.WriteLine("This is the end");
            Console.ReadKey();
        }
        static void mapGen()
        {
            Random r = new Random();
            for (int i = 0; i < 11; i++)
            {
                for(int j = 0; j < 11; j++)
                {
                    map[i, j] = r.Next(0, 4);
                    if (i == 5 && j == 5)
                    {
                        map[i, j] = 99;
                    }
                    if (i == 0 || j == 0 || i == 10 || j == 10)
                    {
                        map[i, j] = 0;
                    }
                }
            }
        }
        static void renderMap ()
        {
            frames++;
            Console.Clear();
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {                   
                    switch (map[i, j])
                    {
                        case 0: Console.Write('#'); break;
                        case 1: Console.Write('.'); break;
                        case 2: Console.Write('.'); break;
                        case 3: Console.Write('*'); break;
                        case 99: Console.Write('@'); break;
                    }                    
                }
                Console.WriteLine("");
            }
            Console.WriteLine(frames);
        }
        static void movement(int dx,int dy)
        {
            if (map[x + dx, y + dy] != 0)
            {               
                map[x, y] = floor;          
                floor = map[x + dx, y + dy];
                map[x + dx, y + dy] = 99;                
                x += dx;y += dy;
                renderMap();
            }
        }
        static void Input()
        {
            char b;           
            b = Convert.ToChar(Console.ReadKey().KeyChar);
            Contact barbar = new Contact();
            switch (b)
            {
                case '0': barbar.Barbarian(); break;
                case '5': mapGen(); break;
                case '8': movement(-1, 0); break;
                case '2': movement(1, 0); break;
                case '6': movement(0, 1); break;
                case '4': movement(0, -1); break;
                case '7': movement(-1, -1); break;
                case '9': movement(-1, 1); break;
                case '3': movement(1, 1); break;
                case '1': movement(1, -1); break;
            }            
        }
        static void Events()
        {
            Contact barbar = new Contact();
            switch (floor)
            {
                case 3: barbar.Barbarian(); break;
            }
        }
    }   
}
