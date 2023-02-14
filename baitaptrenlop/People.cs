namespace baitaptrenlop
{
    internal class People
    {
        private int age;

        public People(){}
        public People(int age, string name)
        {
            this.age = age;
            Name = name;
        }

        public string Name { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new Exception("Tuoi lon hon 0");

            }
        }

        public void Print()
        {
            Console.WriteLine($"Ten: {Name}\nTuoi: {age}");
        }
    }
}
