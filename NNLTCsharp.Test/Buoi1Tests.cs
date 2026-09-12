using System;
using System.Globalization;
using System.IO;
using Xunit;
using NNLTBuoi1;
// Các test đều thay đổi Console.In và Console.Out.
// Console là tài nguyên dùng chung nên không được chạy test song song.
[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace NNLTBuoi1.Tests
{
    public class ConsoleTestHelper
    {
        public static string RunWithInput(Action action, string input)
        {
            TextReader oldIn = Console.In;
            TextWriter oldOut = Console.Out;
            CultureInfo oldCulture = CultureInfo.CurrentCulture;

            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

                using StringReader reader = new StringReader(input);
                using StringWriter writer = new StringWriter();

                Console.SetIn(reader);
                Console.SetOut(writer);

                action();

                return writer.ToString().Replace("\r\n", "\n");
            }
            finally
            {
                Console.SetIn(oldIn);
                Console.SetOut(oldOut);
                CultureInfo.CurrentCulture = oldCulture;
            }
        }
    }

    
    // BÀI 1: HÌNH TRÒN
    
    public class HinhTronTests
    {
        [Fact]
        public void HinhTron_BanKinh2_TinhDung()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.HinhTron,
                "2\n"
            );

            Assert.Contains("Dien tich S = 12.56", output);
            Assert.Contains("Chu vi P = 12.6", output);
        }

        [Theory]
        [InlineData("0\n2\n")]
        [InlineData("-5\n2\n")]
        [InlineData("abc\n2\n")]
        [InlineData("\n2\n")]
        public void HinhTron_InputKhongHopLe_PhaiBaoLoiVaNhapLai(string input)
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.HinhTron,
                input
            );

            Assert.Contains("Ban kinh khong hop le!", output);
            Assert.Contains("Dien tich S = 12.56", output);
        }
    }

    
    // BÀI 2: ĐỔI GIỜ:PHÚT:GIÂY -> GIÂY
    
    public class DoiSangGiayTests
    {
        [Fact]
        public void DoiSangGiay_1Gio1Phut1Giay_TraVe3661()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGiay,
                "1\n1\n1\n"
            );

            Assert.Contains("Tong so giay cua 1:1:1 la 3661", output);
        }

        [Fact]
        public void DoiSangGiay_BienTren_24_59_59_TinhDung()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGiay,
                "24\n59\n59\n"
            );

            Assert.Contains("Tong so giay cua 24:59:59 la 89999", output);
        }

        [Fact]
        public void DoiSangGiay_Gio25_PhaiBaoLoiVaNhapLai()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGiay,
                "25\n2\n30\n15\n"
            );

            Assert.Contains("Gio khong hop le!", output);
            Assert.Contains("Tong so giay cua 2:30:15 la 9015", output);
        }

        [Fact]
        public void DoiSangGiay_Phut60_PhaiBaoLoiVaNhapLai()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGiay,
                "2\n60\n30\n15\n"
            );

            Assert.Contains("Phut khong hop le!", output);
            Assert.Contains("Tong so giay cua 2:30:15 la 9015", output);
        }

        [Fact]
        public void DoiSangGiay_Giay60_PhaiBaoLoiVaNhapLai()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGiay,
                "2\n30\n60\n15\n"
            );

            Assert.Contains("Giay  khong hop le!", output);
            Assert.Contains("Tong so giay cua 2:30:15 la 9015", output);
        }

        [Fact]
        public void DoiSangGiay_NhapChu_PhaiBaoLoi()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGiay,
                "abc\n2\nxyz\n30\nhello\n15\n"
            );

            Assert.Contains("Gio khong hop le!", output);
            Assert.Contains("Phut khong hop le!", output);
            Assert.Contains("Giay  khong hop le!", output);
            Assert.Contains("Tong so giay cua 2:30:15 la 9015", output);
        }

        // Test này dựa trên cách biểu diễn thời gian thông thường:
        // 0 giờ, 0 phút, 0 giây là các giá trị hợp lệ.
        // Code hiện tại của bạn dùng <= 0 nên test này sẽ FAIL.
        [Fact]
        public void DoiSangGiay_ChoPhepGiaTri0()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGiay,
                "0\n0\n0\n"
            );

            Assert.Contains("Tong so giay cua 0:0:0 la 0", output);
        }
    }

    // =========================
    // BÀI 3: ĐỔI GIÂY -> GIỜ:PHÚT:GIÂY
    // =========================
    public class DoiSangGioPhutGiayTests
    {
        [Fact]
        public void DoiSangGioPhutGiay_9010Giay_TraVe2_30_10()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGioPhutGiay,
                "9010\n"
            );

            Assert.Contains("9010 giay co dang 2:30:10", output);
        }

        [Fact]
        public void DoiSangGioPhutGiay_3661Giay_TraVe1_1_1()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGioPhutGiay,
                "3661\n"
            );

            Assert.Contains("3661 giay co dang 1:1:1", output);
        }

        [Fact]
        public void DoiSangGioPhutGiay_59Giay_TraVe0_0_59()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGioPhutGiay,
                "59\n"
            );

            Assert.Contains("59 giay co dang 0:0:59", output);
        }

        [Fact]
        public void DoiSangGioPhutGiay_InputSai_PhaiBaoLoiVaNhapLai()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.DoiSangGioPhutGiay,
                "abc\n-1\n9010\n"
            );

            Assert.Contains("Giay khong hop le!", output);
            Assert.Contains("9010 giay co dang 2:30:10", output);
        }
    }

    // =========================
    // BÀI 4: TÍNH A^N
    // =========================
    public class TinhMuTests
    {
        [Fact]
        public void TinhMu_2Mu3_TraVe8()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.TinhMu,
                "2\n3\n"
            );

            Assert.Contains("Ket qua 2 ^ 3 = 8", output);
        }

        [Fact]
        public void TinhMu_SoMu0_TraVe1()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.TinhMu,
                "5\n0\n"
            );

            Assert.Contains("Ket qua 5 ^ 0 = 1", output);
        }

        [Fact]
        public void TinhMu_SoMuAm_PhaiBaoLoiVaNhapLai()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.TinhMu,
                "2\n-1\n3\n"
            );

            Assert.Contains("n khong hop le!", output);
            Assert.Contains("Ket qua 2 ^ 3 = 8", output);
        }

        [Fact]
        public void TinhMu_NhapChu_PhaiBaoLoi()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.TinhMu,
                "abc\n2\nxyz\n3\n"
            );

            Assert.Contains("a khong hop le!", output);
            Assert.Contains("n khong hop le!", output);
            Assert.Contains("Ket qua 2 ^ 3 = 8", output);
        }

        // Đề/console ghi "Nhap so duong a".
        // Nếu a phải > 0 thì a = 0 phải bị từ chối.
        // Code hiện tại dùng a < 0 nên test này sẽ FAIL.
        [Fact]
        public void TinhMu_A0_PhaiBaoLoiNeuDeYeuCauSoDuong()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi1.TinhMu,
                "0\n2\n2\n"
            );

            Assert.Contains("a khong hop le!", output);
            Assert.Contains("Ket qua 2 ^ 2 = 4", output);
        }
    }
}
