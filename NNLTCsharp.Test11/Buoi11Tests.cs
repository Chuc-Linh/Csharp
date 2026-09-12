using System;
using System.Globalization;
using System.IO;
using Xunit;
using NNLTBuoi11;

// Các test đều thay đổi Console.In và Console.Out.
// Console là tài nguyên dùng chung nên không được chạy test song song.
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace NNLTBuoi11.Tests
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
    // BÀI 1: SẮP CHẴN LẺ
    // =========================
    public class SapChanLeTests
    {
        [Fact]
        public void SapChanLe_ViDuDeBai_DungKetQua()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.SapChanLe,
                "8\n2 4 3 4 2 8 2 5\n"
            );

            Assert.Contains("Day so co 8 phan tu: 2 4 3 4 2 8 2 5", output);
            Assert.Contains("Day so co 8 phan tu: 2 2 2 4 4 8 5 3", output);
        }

        [Fact]
        public void SapChanLe_ToanSoChan_SapTangDan()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.SapChanLe,
                "5\n8 2 6 4 10\n"
            );

            Assert.Contains("Day so co 5 phan tu: 2 4 6 8 10", output);
        }

        [Fact]
        public void SapChanLe_ToanSoLe_SapGiamDan()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.SapChanLe,
                "5\n1 9 3 7 5\n"
            );

            Assert.Contains("Day so co 5 phan tu: 9 7 5 3 1", output);
        }

        [Fact]
        public void SapChanLe_CoSoAm_VanSapDung()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.SapChanLe,
                "6\n-3 -4 7 2 -1 0\n"
            );

            Assert.Contains("Day so co 6 phan tu: -4 0 2 7 -1 -3", output);
        }

        [Fact]
        public void SapChanLe_NKhongHopLe_PhaiNhapLai()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.SapChanLe,
                "0\n501\n4\n4 3 2 1\n"
            );

            Assert.Contains("So luong phan tu khong hop le!", output);
            Assert.Contains("Day so co 4 phan tu: 2 4 3 1", output);
        }
    }

    // =========================
    // BÀI 2: XÓA PHẦN TỬ CHẴN
    // =========================
    public class XoaChanTests
    {
        [Fact]
        public void XoaChan_ViDuDeBai_DungKetQua()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.XoaChan,
                "8\n2 4 3 4 2 8 2 5\n"
            );

            Assert.Contains("Day so co 2 phan tu: 3 5", output);
        }

        [Fact]
        public void XoaChan_ToanSoChan_MangRong()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.XoaChan,
                "4\n2 4 6 8\n"
            );

            Assert.Contains("Day so co 0 phan tu:", output);
        }

        [Fact]
        public void XoaChan_ToanSoLe_GiuNguyen()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.XoaChan,
                "4\n1 3 5 7\n"
            );

            Assert.Contains("Day so co 4 phan tu: 1 3 5 7", output);
        }

        [Fact]
        public void XoaChan_CoSoAm_XoaChanDung()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.XoaChan,
                "6\n-4 -3 -2 -1 0 5\n"
            );

            Assert.Contains("Day so co 3 phan tu: -3 -1 5", output);
        }
    }

    // =========================
    // BÀI 3: THÊM CHẴN LẺ
    // =========================
    public class ThemChanLeTests
    {
        [Fact]
        public void ThemChanLe_ViDuDeBai_DungKetQua()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.ThemChanLe,
                "8\n2 4 3 4 2 8 2 5\n"
            );

            Assert.Contains("Day so co 12 phan tu: 2 3 4 3 4 5 2 3 8 9 2 5", output);
        }

        [Fact]
        public void ThemChanLe_KhongCoHaiSoChanLienTiep_KhongThem()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.ThemChanLe,
                "5\n2 3 4 5 6\n"
            );

            Assert.Contains("Day so co 5 phan tu: 2 3 4 5 6", output);
        }

        [Fact]
        public void ThemChanLe_BaSoChanLienTiep_ThemHaiSoLe()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.ThemChanLe,
                "3\n2 4 6\n"
            );

            Assert.Contains("Day so co 5 phan tu: 2 3 4 5 6", output);
        }

        [Fact]
        public void ThemChanLe_ToanSoChan_ThemGiuaMoiCapLienTiep()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.ThemChanLe,
                "4\n2 8 4 10\n"
            );

            Assert.Contains("Day so co 7 phan tu: 2 3 8 9 4 5 10", output);
        }

        [Fact]
        public void ThemChanLe_CoSoAmChan_VanThemSoLe()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.ThemChanLe,
                "4\n-4 -2 3 6\n"
            );

            Assert.Contains("Day so co 5 phan tu: -4 -3 -2 3 6", output);
        }


    // =========================
    // BÀI 4: ĐẢO DÃY
    // =========================
    public class DaoDayTests
    {
        [Fact]
        public void DaoDay_ViDuDeBai_DungKetQua()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.DaoDay,
                "8\n2 4 3 4 2 8 2 5\n"
            );

            Assert.Contains("Day so co 8 phan tu: 2 4 3 4 2 8 2 5", output);
            Assert.Contains("Day so co 8 phan tu: 5 2 8 2 4 3 4 2", output);
        }

        [Fact]
        public void DaoDay_MotPhanTu_GiuNguyen()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.DaoDay,
                "1\n7\n"
            );

            Assert.Contains("Day so co 1 phan tu: 7", output);
        }

        [Fact]
        public void DaoDay_SoAmVaSo0_DaoDung()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.DaoDay,
                "5\n-2 0 3 -7 9\n"
            );

            Assert.Contains("Day so co 5 phan tu: 9 -7 3 0 -2", output);
        }
    }

    // =========================
    // BÀI 5: TRỘN DÃY
    // =========================
    public class TronDayTests
    {
        [Fact]
        public void TronDay_ViDuDeBai_DungKetQua()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.TronDay,
                "4\n1 5 8 10\n4\n2 3 7 9\n"
            );

            Assert.Contains("Day so co 4 phan tu: 1 5 8 10", output);
            Assert.Contains("Day so co 4 phan tu: 2 3 7 9", output);
            Assert.Contains("Day so co 8 phan tu: 1 2 3 5 7 8 9 10", output);
        }

        [Fact]
        public void TronDay_CoPhanTuTrungNhau_GiuDuTatCa()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.TronDay,
                "4\n1 3 5 7\n4\n1 2 5 8\n"
            );

            Assert.Contains("Day so co 8 phan tu: 1 1 2 3 5 5 7 8", output);
        }

        [Fact]
        public void TronDay_CoSoAm_TronDung()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.TronDay,
                "3\n-5 -1 4\n4\n-3 0 2 10\n"
            );

            Assert.Contains("Day so co 7 phan tu: -5 -3 -1 0 2 4 10", output);
        }

        [Fact]
        public void TronDay_MotDayNamHoanToanTruocDayKia()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.TronDay,
                "3\n1 2 3\n3\n7 8 9\n"
            );

            Assert.Contains("Day so co 6 phan tu: 1 2 3 7 8 9", output);
        }

        [Fact]
        public void TronDay_NKhongHopLe_PhaiNhapLai()
        {
            string output = ConsoleTestHelper.RunWithInput(
                Buoi4.TronDay,
                "0\n3\n1 3 5\n2\n2 4\n"
            );

            Assert.Contains("So luong phan tu khong hop le!", output);
            Assert.Contains("Day so co 5 phan tu: 1 2 3 4 5", output);
        }
    }

    }
}
