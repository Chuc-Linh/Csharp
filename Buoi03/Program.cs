using Buoi03;

Console.WriteLine("===== MENU BAI TAP =====");
Console.WriteLine("1. Bai tap 1");
Console.WriteLine("2. Bai tap 2");
Console.WriteLine("3. Bai tap 3");
Console.WriteLine("4. Bai tap 4");
Console.Write("Moi ban chon bai: ");

int choice = int.Parse(Console.ReadLine()!);

switch (choice)
{
    case 1:
        Baitap1.Mainbt1();
        break;

    case 2:
        Baitap2.Mainbt2();
        break;

    case 3:
        Baitap3.Mainbt3();
        break;

    case 4:
        Baitap4.Mainbt4();
        break;

    default:
        Console.WriteLine("Lua chon khong hop le!");
        break;
}