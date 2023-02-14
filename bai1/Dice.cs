namespace bai1
{
    internal class Dice
    {
        int slides;

        public Dice() { }

        public Dice(int slides)
        {
            this.slides = slides;
        }

        public int Slides
        {
            get => slides; 
            set
            {
                if (value > 0)
                    slides = value;
                else
                    throw new Exception("So mat phai lon hon 0");
            }
        }

        public void Roll()
        {
            Random rd = new Random();
            int result = rd.Next(1, this.slides + 1);
            Console.WriteLine($"Ket qua la: {result}");
        }
    }
}
