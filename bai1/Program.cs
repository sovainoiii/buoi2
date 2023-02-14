using bai1;

Dice dice = new Dice();

Console.Write("Nhap so mat cua xuc xac: ");
int slides = Convert.ToInt32(Console.ReadLine());

try
{
    dice.Slides = slides;
    dice.Roll();
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}