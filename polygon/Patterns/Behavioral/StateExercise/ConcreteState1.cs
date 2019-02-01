namespace StateExercise
{
    public class ConcreteState1 : AbstractState
    {
        public ConcreteState1(AbstractState abstractState)
        {
            this.StateObject = abstractState.StateObject;
            Init();
        }
        public ConcreteState1(StateObject stateObject)
        {
            this.StateObject = stateObject;
            Init();
        }
        public void Init()
        {
            this.Name = "ConcreteState1";
        }
        public override void ToConcreteState1()
        {
            // do nothing
        }
        public override void ToConcreteState2()
        {
            this.StateObject.AbstractState = new ConcreteState2(this);
        }
    }
}