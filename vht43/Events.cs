using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace VHT
{
    public delegate void InputEvent(int x);

    public class UserInput
    {
        public InputEvent inputevent { set; get; }

        public void Input()
        {
            do
            {
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                inputevent?.Invoke(i);
            }
            while (true);
        }
    }

    public class Square
    {
        public void Sub(UserInput input)
        {
            input.inputevent = CalSquare;    
        }

        public void CalSquare(int x){
            Console.WriteLine(Math.Sqrt(x)); 
        }
    }

}