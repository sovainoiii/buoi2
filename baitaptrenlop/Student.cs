namespace baitaptrenlop
{
    internal class Student : People
    {
        private string university;
        public Student() { }
        public Student(int age, string name) : base(age, name)
        {
        }
        public Student(int age, string name, string university) : base(age, name) 
        {
            this.university = university;
        }
        public string University { get => university; set => university = value; }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Truong: {university}");
        }
    }
}
