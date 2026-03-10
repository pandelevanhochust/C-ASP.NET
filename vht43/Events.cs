using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace VHT
{
    // public delegate void InputEvent(int x);

    public class InputEventArgs: EventArgs
    {
        public int value {set; get;}

        public InputEventArgs(int x) => value = x;
    }

    public class UserInput
    {
        // Publisher
        // public event InputEvent inputevent;

        public event EventHandler inputevent;

        public void Input()
        {
            do
            {   Console.Write("Nhap so: ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                inputevent?.Invoke(this, new InputEventArgs(i));
                // inputevent = null;
            }
            while (true);
        }
    }

    public class Square
    {
        //Subscriber
        public void Sub(UserInput input)
        {
            input.inputevent += CalSquare;    
        }

        public void CalSquare(object sender, EventArgs x){
            InputEventArgs value = (InputEventArgs) x;
            Console.WriteLine(Math.Sqrt(value.value)); 
        }
    }

    public class Plus
    {
        public void Sub(UserInput input)
        {
            input.inputevent += CalPlus;
        }

        public void CalPlus(object sender, EventArgs x)
        {
            InputEventArgs value = (InputEventArgs) x;
            Console.WriteLine(value.value + 2);
        }
    }
}