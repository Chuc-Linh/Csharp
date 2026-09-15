/*
* CHƯƠNG TRÌNH in chữ I và U  
* Tác giả : Nguyễn Ngọc Xuân Trúc
* Ngày viết: 10/9/2026
*
* Phát biểu đề bài: Nhập chiều cao h là số nguyên dương. In ra màn hình U và I có độ cao tương ứng với chiều cao đã nhập
* Ý tưởng: Chữ I gồm 3 phần: nét ngang trên là một hàng toàn dấu *, thân là một cột toàn dấu * ở giữa, nét ngang dưới là một hàng toàn dấu *
Chữ U gồm 2 phần : 2 cạnh bên là hai cột * ở 2 bên, đáy là một hàng toàn dấu *
Cả 2 chữ đều có chiều rộng = h kí tự nên ta có thể vẽ từng dòng một 
Mỗi dòng = chữ I + khoảng cách + U 
In ra bằng Console.WriteLine() 
Chọn cách dùng chuỗi String vì dễ căn chỉnh
* Mã giả:
BẮT ĐẦU
// Bước 1: Nhập liệu
LẶP:
    In "Nhap chieu cao h: "
    Đọc h từ bàn phím
    NẾU h không phải số nguyên HOẶC h < 2:
         In "Nhap sai! Vui long nhap lai"
    LẶP LẠI
NGƯỢC LẠI:
    Thoát vòng lặp
// Bước 2: In tiêu đề
    In "Chu I va U ung voi h = " + h + " la:"
// Bước 3: Vẽ từng dòng
    VỚI i TỪ 1 ĐẾN h:
        dongI = TaoDongI(i, h)
        dongU = TaoDongU(i, h)
        In (dongI + "   " + dongU)   // 3 khoảng trắng ở giữa
    HẾT VỚI

    Dừng màn hình chờ Enter
KẾT THÚC
HÀM TaoDongI(i, h):   // Tạo 1 dòng chữ I
    NẾU i == 1 HOẶC i == h:
// Dòng đầu hoặc dòng cuối: in toàn dấu *
    TRẢ VỀ chuỗi gồm h dấu '*'
    NGƯỢC LẠI:
// Dòng giữa: căn giữa dấu *
    soKhoangTrai = (h - 1) / 2
    soKhoangPhai = h - soKhoangTrai - 1
    TRẢ VỀ (soKhoangTrai khoảng trắng) + "*" + (soKhoangPhai khoảng trắng)
HẾT HÀM
HÀM TaoDongU(i, h):   // Tạo 1 dòng chữ U
    NẾU i == h:
// Dòng cuối: đáy chữ U
    TRẢ VỀ chuỗi gồm h dấu '*'
    NGƯỢC LẠI:
// Dòng trên: 2 dấu * ở 2 bên, giữa là khoảng trắng
    soKhoangGiua = h - 2
    TRẢ VỀ "*" + (soKhoangGiua khoảng trắng) + "*"
HẾT HÀM
Nhập h
In "Chu I va U ung voi h = h la:"
For i từ 1 đến h:
    Nếu i = 1 hoặc i = h:
        In h dấu *
    Ngược lại:
        In khoảng trắng + dấu *
    In khoảng cách giữa chữ I và chữ U
    Nếu i < h:
        In dấu * bên trái
        In khoảng trắng
        In dấu * bên phải
    Ngược lại:
        In h dấu *
*/ 
using System;

namespace BUOI6
{    class InraIvaU
{  public static void Main(string[] args)
 {
    int chieuCao;
//Bước 1: Nhập số liệu
    Console.Write("Nhap chieu cao h: ");
     while (!int.TryParse(Console.ReadLine(), out chieuCao) || chieuCao < 2)
        {
                Console.Write("Nhap sai! Vui long nhap so nguyen >= 2: ");
        }
//Bước 2: In ra màn hình
     Console.WriteLine("Chu I va U ung voi chieu cao h = " + chieuCao + " la:");
//Bước 3: Vẽ từng dòng//
     for (int dong = 1; dong <= chieuCao; dong++)
    {
        string dongI = TaoDongI(dong, chieuCao);
        string dongU = TaoDongU(dong, chieuCao);
        Console.WriteLine(dongI + "   " + dongU);
            }
            Console.ReadLine();
        }
 // HÀM TẠO 1 DÒNG CỦA CHỮ I //
          static string TaoDongI(int dong, int chieuCao)
    {
     if (dong == 1 || dong == chieuCao)
      {
            return new string('*', chieuCao); }
            int soKhoangTrai = (chieuCao - 1) / 2;
            int soKhoangPhai = chieuCao - soKhoangTrai - 1;
            return new string(' ', soKhoangTrai) + "*" + new string(' ', soKhoangPhai);
    }

 //HÀM TẠO 1 DÒNG CỦA CHỮ U//
        static string TaoDongU(int dong, int chieuCao)
    { if (dong == chieuCao)
         {
                return new string('*', chieuCao);
         }
         int soKhoangGiua = chieuCao - 2;
            return "*" + new string(' ', soKhoangGiua) + "*";
     }
    }
}