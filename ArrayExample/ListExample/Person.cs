namespace ListExample
{
    internal class Person
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int Age { get; internal set; }
        public override string ToString()
        {
            return $"Name: {FirstName}, LastName: {LastName}, age:{Age}";
        }
    }
}