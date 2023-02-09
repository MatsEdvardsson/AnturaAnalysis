using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnturaAnalysis
{
    internal class Animation
    {

        private static void ConsoleDraw(IEnumerable<string> lines, int x, int y)
        {
            if (x > Console.WindowWidth) return;
            if (y > Console.WindowHeight) return;

            var trimLeft = x < 0 ? -x : 0;
            int index = y;

            x = x < 0 ? 0 : x;
            y = y < 0 ? 0 : y;

            var linesToPrint =
                from line in lines
                let currentIndex = index++
                where currentIndex > 0 && currentIndex < Console.WindowHeight
                select new
                {
                    Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x, line.Length - trimLeft)).ToArray()),
                    X = x,
                    Y = y++
                };

            Console.Clear();
            foreach (var line in linesToPrint)
            {
                Console.SetCursorPosition(line.X, line.Y);
                Console.Write(line.Text);
            }
        }

        public void StartAni()
        {
            Console.CursorVisible = false;




            var arrExit = new[]
            {
            @"           ,ggg,",
            @"          dP""8I                            ,dPYb,               I8",
            @"         dP   88                            IP'`Yb               I8",
            @"        dP    88                            I8  8I            88888888",
            @"       ,8'    88                            I8  8'               I8",
            @"       d88888888      ggg    gg,     g,     I8 dP  gg      gg    I8,     gggg,gg,    gggggg,",
            @"    __,8      88     d8 Yb   88bg  ,8 8,    I8dP   I8      8I    I8     dP    Y8I   dP    8I",
            @"dP   ,8P      Y8    dP  I8   8I   ,8'  Yb   I8P    I8,    ,8I   ,I8,   i8'    ,8I  ,8'    8I",
            @"Yb,_,dP       `8b,,dP   I8, ,8I  ,8'_   8) ,d8b,_ ,d8b,  ,d8b, ,d88b, ,d8,   ,d8b,,dP     Y8,",
            @"  Y8P          `Y88       Y8P    P'  YY8P8P8P' Y888P' Y88P `Y888P  Y88P Y8888P `Y88P      `Y8"
        };

            var maxLength = arrExit.Aggregate(0, (max, line) => Math.Max(max, line.Length));
            var x = Console.BufferWidth / 2 - maxLength / 2;
            for (int y = -arrExit.Length; y < Console.WindowHeight + arrExit.Length; y++)
            {
                ConsoleDraw(arrExit, x, y);
                Thread.Sleep(20);
            }
        }

    }
  
    
}
