USE QLCT
GO
-- Xóa
CREATE PROCEDURE Xoa (@MaNV char(10))
AS
BEGIN
	DELETE FROM tblNhanVien WHERE MaNV = @MaNV
END

-- Tìm kiếm
CREATE PROCEDURE TK_MaNV(@MaNV nchar(10))
AS
BEGIN
	SELECT * FROM tblNhanVien WHERE MaNV = @MaNV
END

ALTER PROCEDURE TK_TenNV(@TenNV nvarchar(50))
AS
BEGIN
	SELECT * FROM tblNhanVien WHERE TenNV LIKE '%' + @TenNV + '%'
END
