using Buoi08;

while (true)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1. Bai tap 1");
    Console.WriteLine("2. Bai tap 2");
    Console.WriteLine("3. Bai tap 3");
    Console.WriteLine("4. Bai tap 4");
    Console.WriteLine("0. Thoat");
    Console.Write("Chon bai: ");

    int chon = int.Parse(Console.ReadLine());

    switch (chon)
    {
        case 1:
            Baitap1.Giaibai1(args);
            break;

        case 2:
            Baitap2.Giaibai2(args);
            break;

        case 3:
            Baitap3.Giaibai3(args);
            break;

        case 4:
            Baitap4.Giaibai4(args);
            break;

        case 0:
            return;

        default:
            Console.WriteLine("Lua chon khong hop le!");
            break;
    }
}
