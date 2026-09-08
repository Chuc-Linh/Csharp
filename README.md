# Bài tập C#

Chào mừng! Đây là kho lưu trữ chứa các bài tập C# do thầy giao, phục vụ cho môn học. Mỗi bài tập được tổ chức thành thư mục riêng, kèm mô tả, yêu cầu và hướng dẫn chạy (nếu có).

## Mục lục

- [Giới thiệu](#giới-thiệu)
- [Nội dung](#nội-dung)
- [Cấu trúc thư mục](#cấu-trúc-thư-mục)
- [Yêu cầu môi trường](#yêu-cầu-môi-trường)
- [Cách chạy bài tập](#cách-chạy-bài-tập)
- [Góp ý & Liên hệ](#góp-ý--liên-hệ)

---

## Giới thiệu

Kho này chứa các bài tập lập trình C# do thầy giao trong kỳ học. Mục tiêu là giúp ôn tập, thực hành kỹ năng lập trình hướng đối tượng, giải thuật cơ bản và làm quen với công cụ .NET.

## Nội dung

Các bài tập bao gồm (khung chung):

- Bài toán xử lý dữ liệu (file, chuỗi, mảng)
- Lập trình hướng đối tượng (class, kế thừa, interface)
- Thuật toán và cấu trúc dữ liệu cơ bản (sắp xếp, tìm kiếm, danh sách, ngăn xếp)
- Ứng dụng console / Windows Forms / các bài tập nhỏ

Mỗi thư mục bài tập thường có:
- `README.md`: mô tả đề bài và yêu cầu
- `Source/` hoặc project .NET: mã nguồn
- `Input/` (nếu có): dữ liệu mẫu để kiểm thử

## Cấu trúc thư mục (ví dụ)

- BaiTap01-Strings/
  - README.md
  - BaiTap01.csproj
  - Program.cs
- BaiTap02-OOP/
  - README.md
  - BaiTap02.sln

(Hãy xem từng thư mục để biết hướng dẫn cụ thể của mỗi bài)

## Yêu cầu môi trường

- .NET SDK (phiên bản 6.0+ khuyến nghị)
- Visual Studio hoặc Visual Studio Code (có cài extension C#)

## Cách chạy bài tập

1. Mở thư mục bài tập bằng Visual Studio hoặc Visual Studio Code.
2. Nếu dùng CLI, chuyển vào thư mục chứa file `.csproj` và chạy:

```bash
dotnet restore
dotnet run
```

3. Làm theo hướng dẫn từng bài trong README của bài tập (nếu có test case hoặc input mẫu sẽ nêu rõ).

## Góp ý & Liên hệ

Nếu bạn có đề xuất cải thiện cấu trúc repo, muốn sửa lỗi trong mã hoặc thêm tài liệu, vui lòng mở issue hoặc gửi pull request.

Chúc bạn học tốt và hoàn thành các bài tập!