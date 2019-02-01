namespace StateExercise
{
    public class BaseObject
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public BaseObject()
        {
        }
        public BaseObject(string name)
        {
            Name = name;
        }
    }
}