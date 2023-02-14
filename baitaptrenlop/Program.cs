using baitaptrenlop;

Console.Write("Nhap ten: ");
string name = Console.ReadLine();
Console.Write("Nhap tuoi: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap truong: ");
string uni = Console.ReadLine();

try
{
    Student st = new Student(age: age, name: name, university: uni);
    st.Print();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}