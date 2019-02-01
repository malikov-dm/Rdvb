namespace StateExercise
{
    public class StateObject : BaseObject
    {
        public AbstractState AbstractState { get; set; }

        private void Init()
        {
            AbstractState = new ConcreteState1(this);
        }

        public StateObject(string name) : base(name)
        {
            Init();
        }
        public StateObject()
        {
            Init();
        }
    }
}