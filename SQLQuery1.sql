-- 1. Tạo bảng lưu danh sách môn học
CREATE TABLE Courses (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CourseCode NVARCHAR(20) NOT NULL,
    CourseName NVARCHAR(100) NOT NULL,
    Credits NVARCHAR(10) NOT NULL,
    CourseType NVARCHAR(50) NOT NULL,
    TagBgColor NVARCHAR(20) DEFAULT '#F0FDFA',
    TagTextColor NVARCHAR(20) DEFAULT '#004D53'
);
GO

-- 2. Chèn dữ liệu môn học ban đầu
INSERT INTO Courses (CourseCode, CourseName, Credits, CourseType, TagBgColor, TagTextColor)
VALUES 
(N'BIT503001', N'Lập trình Di động (.NET)', N'4 TC', N'Dự án môn học', '#F0FDFA', '#004D53'),
(N'ECO501001', N'Kinh tế vĩ mô', N'3 TC', N'BTL / Tiểu luận', '#FFFBEB', '#B45309'),
(N'RES502002', N'Phương pháp Nghiên cứu Kinh tế', N'3 TC', N'Đề án NCKH', '#F0F9FF', '#0369A1');
GO
