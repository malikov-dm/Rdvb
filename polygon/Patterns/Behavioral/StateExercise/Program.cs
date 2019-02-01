using System;

namespace StateExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var stateObject = new StateObject("State Object");

            Console.WriteLine(stateObject.AbstractState);

            stateObject.AbstractState.ToConcreteState1();
            Console.WriteLine(stateObject.AbstractState);

            stateObject.AbstractState.ToConcreteState2();
            Console.WriteLine(stateObject.AbstractState);

            stateObject.AbstractState.ToConcreteState2();
            Console.WriteLine(stateObject.AbstractState);

            stateObject.AbstractState.ToConcreteState1();
            Console.WriteLine(stateObject.AbstractState);
        }
    }
}
