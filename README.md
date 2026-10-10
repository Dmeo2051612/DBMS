Bài Tập Lớn Cuối Kỳ môn Hệ quản trị Cơ sở dữ liệu: Ứng Dụng Quản Lý Bằng C# WinForms & SQL Server
Dự án này là bài tập lớn cuối kỳ môn Hệ Quản Trị Cơ Sở Dữ Liệu, được phát triển nhằm mục đích củng cố và áp dụng các kỹ năng lập trình giao diện (C# WinForms) kết hợp xử lý logic trực tiếp dưới cơ sở dữ liệu (SQL Server). Báo cáo dự án đã đạt kết quả 9/10.

Dự án tập hợp 10 bài toán thực tế trải dài qua nhiều nghiệp vụ quản lý khác nhau (Thư viện, Đề án công ty, Gara sửa xe, Phân công coi thi), tuân thủ nghiêm ngặt nguyên tắc tách biệt logic xử lý dữ liệu và giao diện người dùng.

🛠 Công Nghệ Sử Dụng
Ngôn ngữ lập trình: C#

Framework UI: Windows Forms (.NET Framework / .NET Core)

Môi trường phát triển: Visual Studio 2022

Hệ quản trị CSDL: Microsoft SQL Server

Công cụ quản trị CSDL: SQL Server Management Studio (SSMS)

📌 Tính Năng Cốt Lõi & Kỹ Thuật Triển Khai
Giao diện chính được thiết kế dạng menu điều hướng với các nút chức năng (command buttons). Mỗi bài tập hoặc phân hệ được mở ra trong một Form con. Hệ thống cung cấp cơ chế cấu hình chuỗi kết nối (Connection String) động, cho phép người dùng kết nối, tạo CSDL và khởi tạo dữ liệu mẫu (Mock Data) trực tiếp từ UI trước khi thực thi nghiệp vụ.

1. Kiến trúc Cơ Sở Dữ Liệu (DDL & DML)
Tạo và tinh chỉnh CSDL: Sử dụng thành thạo CREATE TABLE, ALTER TABLE để định nghĩa cấu trúc lưu trữ cho 4 hệ thống nghiệp vụ (Quản lý Thư viện, Đề án, Gara, Trường học).

Ràng buộc dữ liệu (Constraints): Áp dụng triệt để PRIMARY KEY, FOREIGN KEY, CHECK, UNIQUE và DEFAULT để đảm bảo tính toàn vẹn dữ liệu. Ví dụ: Ràng buộc số tiết học và thời gian thi (Bài 10), ràng buộc nhóm trưởng phải thuộc danh sách thợ (Bài 9).

Thao tác CRUD: Thực hiện đầy đủ các lệnh INSERT, UPDATE, DELETE, SELECT thông qua truy vấn trực tiếp và Stored Procedures.

2. Lập Trình Cơ Sở Dữ Liệu (T-SQL)
Stored Procedures (Thủ tục lưu trữ): Đóng gói toàn bộ logic xử lý phức tạp. Tối ưu hóa các thao tác như giải phương trình (bậc 1, bậc 2) trực tiếp trên SQL, phân loại đối tượng độc giả (người lớn/trẻ em) để xuất báo cáo tương ứng.

User-Defined Functions (Hàm):

Sử dụng Scalar-valued functions để tính tuổi, tính tổng lương, tiền thưởng theo giờ làm việc.

Sử dụng Table-valued functions (cả Inline và Multi-statement) để trả về các tập kết quả dạng bảng phục vụ cho báo cáo tổng hợp.

Triggers: Tự động hóa các luồng nghiệp vụ ngầm. Tiêu biểu:

FOR INSERT, FOR DELETE, FOR UPDATE để tự động đồng bộ trạng thái "đang mượn" của cuốn sách và đầu sách (Bài 6).

Bắt lỗi và in thông báo bằng tiếng Việt khi có thay đổi dữ liệu tác giả/tựa sách, kết hợp sử dụng khối lệnh BEGIN TRAN ... COMMIT/ROLLBACK để test trigger mà không làm rác CSDL.

3. Kỹ Thuật Truy Vấn Nâng Cao
Truy vấn lồng (Nested Queries) & Cấu trúc điều kiện: Sử dụng IN, EXISTS, NOT EXISTS kết hợp với các phép JOIN để lọc dữ liệu phức tạp (VD: Tìm thợ không tham gia hợp đồng nào, độc giả người lớn có trẻ em bảo lãnh đang mượn sách).

Xử lý chuỗi & Ép kiểu: Sử dụng CAST, CONVERT để ép kiểu dữ liệu an toàn. Xử lý chuỗi rỗng từ UI truyền xuống bằng hàm LEN(), RTRIM(), LTRIM() và bắt lỗi logic khi tham số không hợp lệ.

Xử lý NULL: Áp dụng ISNULL() và COALESCE() để kiểm soát các giá trị thiếu hụt (VD: Tổng tiền thanh toán khi chưa có hóa đơn, giáo viên không chủ nhiệm môn học).

Xử lý Số & Ngày tháng: Sử dụng DATEDIFF, DATEADD, GETDATE() để tính tuổi, kiểm tra sách mượn quá hạn (14 ngày), và kiểm soát các mốc thời gian hoàn tất hợp đồng Gara trước 31/12/2002.

🚀 Hướng Dẫn Cài Đặt Và Chạy Ứng Dụng
Clone repository:

Bash
git clone <https://github.com/Dmeo2051612/DBMS.git>
Thiết lập Cơ Sở Dữ Liệu:

Mở SSMS (SQL Server Management Studio).

Mở file script Database_Schema_MockData.sql đính kèm trong thư mục /Database.

Bôi đen toàn bộ lệnh và nhấn F5 (Execute) để tạo 4 Database cùng toàn bộ Table, Constraint, Procedures, Functions, Triggers và dữ liệu mẫu. Dữ liệu mẫu đã được thiết kế để bao phủ toàn bộ các test case (biên, null, hợp lệ, không hợp lệ).

Khởi chạy Ứng Dụng:

Mở solution file (.sln) bằng Visual Studio 2022.

Tại giao diện khởi động, nhập Server Name của máy bạn (ví dụ: .\SQLEXPRESS hoặc localhost) và nhấn Kết Nối & Khởi Tạo.

Click vào từng nút bài tập để mở giao diện thao tác tương ứng.