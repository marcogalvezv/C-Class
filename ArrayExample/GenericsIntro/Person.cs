namespace GenericsIntro
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

        public static bool operator ==(Person p1, Person p2)
        {
            return true;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}