using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace advanced
{
    public interface IClass { public void Beep(){} };
    // public class ClassA : IClass;

    public class Honk: IClass { public void Beep() => Console.WriteLine("Peep"); }

    public class Shout: IClass { public void Beep() => Console.WriteLine("Call"); }

    class Car
    {
        private IClass honk;
        public Car(IClass _honk) => honk = _honk;
        public void Beep() { honk.Beep(); }
    }

    public class DepenencyInjection
    {
        public void Honky()
        {
            Honk honk = new Honk();
            Shout shout = new Shout();
            Car car = new Car(shout);
            car.Beep();
        }
    }
}