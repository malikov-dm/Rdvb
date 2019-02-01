namespace StateExercise
{
    public abstract class AbstractState : BaseObject
    {
        public abstract void ToConcreteState1();
        public abstract void ToConcreteState2();
        protected StateObject _stateObject;
        public StateObject StateObject
        {
            get => _stateObject;
            set => _stateObject = value;
        }

    }
}