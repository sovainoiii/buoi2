using bai1;

// Bai lam cua Pham Duc Minh
// Khai bao bien slides
int slides;
// Khoi tao doi tuong dice
Dice dice = new Dice();

// Nhap va gan gia tri cho bien slide
Console.Write("Nhap so mat cua xuc xac: ");
while (!int.TryParse(Console.ReadLine(), out slides))
{
    Console.Write("Nhap sai dinh dang hay nhap lai: ");
}
// Tao so mat cho xuc xac va chay ham Roll
try
{
    dice.Slides = slides;
    dice.Roll();
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}