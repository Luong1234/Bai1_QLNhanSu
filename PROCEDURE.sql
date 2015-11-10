USE QLCT_2
GO
-- Xóa
CREATE PROCEDURE Xoa_NV (@MaNV varchar(10))
AS
BEGIN
	DELETE FROM tblNhanVien WHERE MaNV = @MaNV
END

CREATE PROC Xoa_DV (@MaDV varchar(10))
AS
BEGIN
	DELETE FROM tblDonVi WHERE MaDV=@MaDV
END
-- Tìm kiếm
CREATE PROCEDURE TK_MaNV(@MaNV varchar(10))
AS
BEGIN
	SELECT * FROM tblNhanVien WHERE MaNV = @MaNV
END

CREATE PROCEDURE TK_TenNV(@TenNV nvarchar(50))
AS
BEGIN
	SELECT * FROM tblNhanVien WHERE TenNV LIKE '%' + @TenNV + '%'
END
--dung tien
