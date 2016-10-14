create proc B1_PSP_NhanVien_SelectAll
as
	select * from GYM_NhanVien where TinhTrang = 1
go
alter proc B1_PSP_NhanVien_Insert
@TenNhanVien nvarchar(50),
@Phai bit,
@NamSinh date,
@DienThoai nchar(20),
@TenDangNhap varchar(50),
@MaTaiKhoan int,
@MatKhau varchar(100),
@TinhTrang bit,
@PhongTap int
as
	insert into GYM_NhanVien(TenNhanVien,GioiTinh,NamSinh,DienThoai,TenDangNhap,MatKhau,MaTaiKhoan,PhongTap,TinhTrang) values (@TenNhanVien,@Phai,@NamSinh,@DienThoai,@TenDangNhap,pwdencrypt(@MatKhau),@MaTaiKhoan,@PhongTap,@TinhTrang)
go
create proc B1_PSP_PhongTap_SelectAll
as
	select MaPhongTap,TenPhongTap from GYM_PhongTap where TinhTrang = 1
go
alter proc B1_PSP_NhanVien_Update_MaNhanVien
@MaNhanVien int,
@TenNhanVien nvarchar(50),
@Phai bit,
@NamSinh date,
@DienThoai nchar(20),
@TenDangNhap varchar(50),
@MaTaiKhoan int,
@TinhTrang bit,
@PhongTap int
as
	update GYM_NhanVien
	set TenNhanVien = @TenNhanVien,
		GioiTinh = @Phai,
		NamSinh = @NamSinh,
		DienThoai = @DienThoai,
		TenDangNhap = @TenDangNhap,
		MaTaiKhoan = @MaTaiKhoan,
		TinhTrang = @TinhTrang,
		PhongTap = @PhongTap
	where MaNhanVien = @MaNhanVien
go
create proc B1_PSP_NhanVien_Delete_MaNhanVien
@MaNhanVien int
as
	update GYM_NhanVien
	set TinhTrang = 0
	where MaNhanVien = @MaNhanVien
go
ALTER proc [dbo].[B1_PSP_LayThongTinDangNhap]
@taikhoan varchar(30),
@matkhau varchar(30)
as
	select MaNhanVien,TenNhanVien,TenDangNhap,MatKhau,MaTaiKhoan  
	from GYM_NhanVien
	where TenDangNhap=@taikhoan and PWDCOMPARE(@matkhau,MatKhau)=1 and TinhTrang = 1
go
create proc B1_PSP_NhanVien_Select_MaNhanVien
@MaNhanVien int
as
	select * from GYM_NhanVien where MaNhanVien = @MaNhanVien
go
create proc B1_PSP_NhanVien_Update_MaNhanVien_MK
@MaNhanVien int,
@TenNhanVien nvarchar(50),
@Phai bit,
@NamSinh date,
@DienThoai nchar(20),
@TenDangNhap varchar(50),
@MaTaiKhoan int,
@TinhTrang bit,
@PhongTap int,
@MatKhau varchar(100)
as
	update GYM_NhanVien
	set TenNhanVien = @TenNhanVien,
		GioiTinh = @Phai,
		NamSinh = @NamSinh,
		DienThoai = @DienThoai,
		TenDangNhap = @TenDangNhap,
		MaTaiKhoan = @MaTaiKhoan,
		TinhTrang = @TinhTrang,
		PhongTap = @PhongTap,
		MatKhau = PWDENCRYPT(@MatKhau)
	where MaNhanVien = @MaNhanVien
go
alter proc B1_HSP_CheckOldPassword --4,'mon'
@MaNhanVien int,
@MatKhau varchar(100)
as
	select 1 from GYM_NhanVien where MaNhanVien = @MaNhanVien and pwdcompare(@MatKhau,MatKhau) = 1
go
create proc B1_HSP_GetAllPractice
as
	select MaMonTap,TenMonTap
	from GYM_MonTap
	where TinhTrang = 1
go
create proc B1_HSP_DeletePractice
@PracticeId int
as
	update GYM_MonTap
	set TinhTrang = 0
	where MaMonTap = @PracticeId
go
create proc B1_HSP_UpdatePractice
@PracticeId int,
@PracticeName nvarchar(50)
as
	update GYM_MonTap
	set TenMonTap = @PracticeName
	where MaMonTap = @PracticeId
go
alter proc B1_HSP_AddPractice
@PracticeName nvarchar(50)
as
	insert into GYM_MonTap(TenMonTap,TinhTrang) values (@PracticeName,1)