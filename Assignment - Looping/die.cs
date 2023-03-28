using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___Looping
{
    public class die
    {
        private Random _generator;
        private int _roll;

        public die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }
        public int Roll { get { return _roll; } }
        public override string ToString()
        {
            return _roll.ToString();
        }
        public void RollDie2()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 3);
        }
        public void RollDie3()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 4);
        }
        public void RollDie4()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 5);
        }
        public void RollDie5()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 6);
        }
        public void RollDie6()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }
        public void RollDie7()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 8);
        }
        public void RollDie8()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 9);
        }
        public void RollDie9()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 10);
        }

        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("|     |");
                Console.WriteLine("|  o  |");
                Console.WriteLine("|     |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 2)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o   |");
                Console.WriteLine("|     |");
                Console.WriteLine("|   o |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 3)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o   |");
                Console.WriteLine("|  o  |");
                Console.WriteLine("|   o |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 4)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o o |");
                Console.WriteLine("|     |");
                Console.WriteLine("| o o |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 5)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o o |");
                Console.WriteLine("|  o  |");
                Console.WriteLine("| o o |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 6)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o o |");
                Console.WriteLine("| o o |");
                Console.WriteLine("| o o |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 7)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("| o o |");
                Console.WriteLine("|o o o|");
                Console.WriteLine("| o o |");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 8)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("|o o o|");
                Console.WriteLine("| o o |");
                Console.WriteLine("|o o o|");
                Console.WriteLine(" ----- ");
            }
            else if (_roll == 9)
            {
                Console.WriteLine(" _____ ");
                Console.WriteLine("|o o o|");
                Console.WriteLine("|o o o|");
                Console.WriteLine("|o o o|");
                Console.WriteLine(" ----- ");
            }
        }
    }
}
    
