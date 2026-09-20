using System;
using System.Globalization;
using System.IO;
using Xunit;
using NNLTBuoi12;

// Các test đều thay đổi Console.In và Console.Out.
// Console là tài nguyên dùng chung nên không được chạy test song song.
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace NNLTBuoi12.Tests
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

    // =========================
    // BÀI 1: TỔNG CÁC SỐ CHẴN, LẺ
    // =========================
    public class TongChanLeMang2CTests
    {
        [Fact]
        public void ViDuDeBai_DungKetQua()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.TongChanLeMang2C,
                "2\n3\n2 4 5\n8 10 15\n"
            );

            Assert.Contains("Tong cac so chan la 24 va tong so le la 20.", output);
        }

        [Fact]
        public void CoSoAmVaSo0_DungKetQua()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.TongChanLeMang2C,
                "2\n3\n-2 -3 0\n4 5 -7\n"
            );

            Assert.Contains("Tong cac so chan la 2 va tong so le la -5.", output);
        }

        [Fact]
        public void ToanSoLe_TongChanBang0()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.TongChanLeMang2C,
                "2\n2\n1 3\n5 7\n"
            );

            Assert.Contains("Tong cac so chan la 0 va tong so le la 16.", output);
        }
    }

    // =========================
    // BÀI 2: ĐẾM SỐ TRÊN BIÊN
    // =========================
    public class DemSoTrenBienTests
    {
        [Fact]
        public void ViDuDeBai_DungKetQua()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.DemSoTrenBienMang2C,
                "3\n4\n1.5 -3.2 4.8 0\n-1.8 3.9 2.7 4.5\n3.3 9.6 -2.8 -4.9\n"
            );

            Assert.Contains(
                "Tren duong bien co 5 so duong, 3 so am va 1 so khong.",
                output
            );
        }

        [Fact]
        public void KhongDemPhanTuBenTrong()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.DemSoTrenBienMang2C,
                "3\n3\n1 1 1\n1 -100 1\n1 1 1\n"
            );

            Assert.Contains(
                "Tren duong bien co 8 so duong, 0 so am va 0 so khong.",
                output
            );
        }

        [Fact]
        public void MaTranMotDong_MoiPhanTuChiDemMotLan()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.DemSoTrenBienMang2C,
                "1\n4\n1 -2 0 3\n"
            );

            Assert.Contains(
                "Tren duong bien co 2 so duong, 1 so am va 1 so khong.",
                output
            );
        }
    }

    // =========================
    // BÀI 3: MA TRẬN TOÀN LẺ
    // =========================
    public class MaTranToanLeTests
    {
        [Fact]
        public void ViDuDeBai_ToanLe()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.MaTranToanLe,
                "2\n3\n1 7 9\n5 3 15\n"
            );

            Assert.Contains("Mang A toan le!", output);
        }

        [Fact]
        public void CoMotSoChan_KhongToanLe()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.MaTranToanLe,
                "2\n3\n1 7 9\n5 2 15\n"
            );

            Assert.Contains("Mang A khong toan le!", output);
        }

        [Fact]
        public void SoLeAm_VanLaSoLe()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.MaTranToanLe,
                "2\n2\n-1 -3\n5 7\n"
            );

            Assert.Contains("Mang A toan le!", output);
        }
    }

    // =========================
    // BÀI 4: LIỆT KÊ DÒNG TĂNG DẦN
    // =========================
    public class DongTangDanTests
    {
        [Fact]
        public void ViDuDeBai_DungDong0Va2()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.DongTangDan,
                "3\n3\n1 7 9\n5 3 15\n3 4 8\n"
            );

            Assert.Contains("Cac dong tao thanh day tang: 0 2", output);
        }

        [Fact]
        public void HaiGiaTriBangNhau_KhongTangNghiemNgat()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.DongTangDan,
                "2\n3\n1 1 2\n2 3 4\n"
            );

            Assert.Contains("Cac dong tao thanh day tang: 1", output);
        }

        [Fact]
        public void MaTranMotCot_MoiDongDeuTang()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.DongTangDan,
                "3\n1\n9\n4\n-2\n"
            );

            Assert.Contains("Cac dong tao thanh day tang: 0 1 2", output);
        }
    }

    // =========================
    // BÀI 5: CỘT CÓ TỔNG LỚN NHẤT
    // =========================
    public class CotTongLonNhatTests
    {
        [Fact]
        public void ViDuDeBai_DungCot1Va2()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.CotTongLonNhat,
                "3\n3\n1 11 9\n5 5 15\n3 16 8\n"
            );

            Assert.Contains("Cac cot co tong lon nhat: 1 2", output);
        }

        [Fact]
        public void ChiMotCotLonNhat()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.CotTongLonNhat,
                "2\n3\n1 10 3\n2 20 4\n"
            );

            Assert.Contains("Cac cot co tong lon nhat: 1", output);
        }

        [Fact]
        public void TatCaCotBangNhau_LietKeTatCa()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.CotTongLonNhat,
                "2\n3\n1 2 3\n5 4 3\n"
            );

            Assert.Contains("Cac cot co tong lon nhat: 0 1 2", output);
        }

        [Fact]
        public void CoSoAm_VanTimDung()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.CotTongLonNhat,
                "2\n3\n-10 -2 -5\n-1 -3 -4\n"
            );

            Assert.Contains("Cac cot co tong lon nhat: 1", output);
        }
    }

    // =========================
    // KIỂM TRA INPUT
    // =========================
    public class InputTests
    {
        [Fact]
        public void KichThuocNgoai1Den100_PhaiBaoLoi()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.MaTranToanLe,
                "0\n101\n2\n3\n1 3 5\n7 9 11\n"
            );

            Assert.Contains("Kich thuoc khong hop le!", output);
            Assert.Contains("Mang A toan le!", output);
        }

        [Fact]
        public void PhanTuNguyenSaiDinhDang_PhaiBaoLoi()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi12.TongChanLeMang2C,
                "2\n2\n2 abc 3\n4 5\n"
            );

            Assert.Contains("Phan tu khong hop le!", output);
            Assert.Contains("Tong cac so chan la 6 va tong so le la 8.", output);
        }
    }
}
