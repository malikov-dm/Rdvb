namespace StateExercise
{
    public class ConcreteState2 : AbstractState
    {
        public ConcreteState2(AbstractState abstractState)
        {
            this.StateObject = abstractState.StateObject;
            Init();
        }
        public ConcreteState2(StateObject stateObject)
        {
            this.StateObject = stateObject;
            Init();
        }
        public void Init()
        {
            this.Name = "ConcreteState2";
        }
        public override void ToConcreteState1()
        {
            this.StateObject.AbstractState = new ConcreteState1(this);
        }
        public override void ToConcreteState2()
        {
            // do nothing
        }
    }
}