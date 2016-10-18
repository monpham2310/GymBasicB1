alter proc HSP_GetMemberList
as
	select row_number() over (order by (select 1)) as STT, MaHoiVien,Ho,Ten,Gioitinh,NamSinh,DiaChi,CMND,DienThoai,Email,MaThe,HinhAnh
	from GYM_HoiVien
	where TinhTrang = 1
go
create proc HSP_DeleteMember
@MemberId int
as
	update GYM_HoiVien
	set TinhTrang = 0
	where MaHoiVien = @MemberId
go
create proc HSP_UpdateMemberData
@MemberId int,
@LastName nvarchar(50),
@FirstName nvarchar(20),
@Barcode nvarchar(20),
@Gender bit,
@IdCard nchar(20),
@Birthday date,
@Phone nchar(15),
@Email nvarchar(100),
@Address nvarchar(500),
@Image varbinary(max)
as
	update GYM_HoiVien
	set Ho = @LastName,
		Ten = @FirstName,
		Gioitinh = @Gender,
		NamSinh = @Birthday,
		DiaChi = @Address,
		CMND = @IdCard,
		DienThoai = @Phone,
		Email = @Email,
		MaThe = @Barcode,
		HinhAnh = @Image
	where MaHoiVien = @MemberId
go
create proc HSP_UpdateMemberDataNoneImg
@MemberId int,
@LastName nvarchar(50),
@FirstName nvarchar(20),
@Barcode nvarchar(20),
@Gender bit,
@IdCard nchar(20),
@Birthday date,
@Phone nchar(15),
@Email nvarchar(100),
@Address nvarchar(500)
as
	update GYM_HoiVien
	set Ho = @LastName,
		Ten = @FirstName,
		Gioitinh = @Gender,
		NamSinh = @Birthday,
		DiaChi = @Address,
		CMND = @IdCard,
		DienThoai = @Phone,
		Email = @Email,
		MaThe = @Barcode		
	where MaHoiVien = @MemberId
go
create proc HSP_AddMemberData
@LastName nvarchar(50),
@FirstName nvarchar(20),
@Barcode nvarchar(20),
@Gender bit,
@IdCard nchar(20),
@Birthday date,
@Phone nchar(15),
@Email nvarchar(100),
@Address nvarchar(500),
@Image varbinary(max)
as
	insert into GYM_HoiVien(Ho, Ten, Gioitinh, NamSinh, DiaChi, CMND, DienThoai, Email, MaThe, HinhAnh)
	values (@LastName, @FirstName, @Gender, @Birthday, @Address, @IdCard, @Phone, @Email, @Barcode, @Image)
go
create proc HSP_AddMemberDataNoneImg
@LastName nvarchar(50),
@FirstName nvarchar(20),
@Barcode nvarchar(20),
@Gender bit,
@IdCard nchar(20),
@Birthday date,
@Phone nchar(15),
@Email nvarchar(100),
@Address nvarchar(500)
as
	insert into GYM_HoiVien(Ho, Ten, Gioitinh, NamSinh, DiaChi, CMND, DienThoai, Email, MaThe)
	values (@LastName, @FirstName, @Gender, @Birthday, @Address, @IdCard, @Phone, @Email, @Barcode)
go
ALTER proc [dbo].[B1_PSP_LayThongTinDangNhap]
@taikhoan varchar(30),
@matkhau varchar(30)
as
	select MaNhanVien,TenNhanVien,TenDangNhap,MatKhau,MaTaiKhoan,PhongTap  
	from GYM_NhanVien
	where TenDangNhap=@taikhoan and PWDCOMPARE(@matkhau,MatKhau)=1 and TinhTrang = 1
go
create proc [dbo].[B1_PSP_HienThiThongTinCheckin] 
@maphongtap int
as
select distinct
 ROW_NUMBER() over (order by (select 1)) as STT,
 a.MaHoiVien,
a.MaVach 
,TenHoiVien
,Convert(nvarchar(10),NamSinh,103) as NamSinh
,GioVao
,GioRa
,DaRa
,NgayMuon,GiaTien
from (((HoiVien a inner join hoadon b on a.mahoivien =b.mahoivien)inner join the c on b.mahd=c.mahd)inner join chitietvaophong d on c.mathe=d.mathe)left join muonkhan e on e.mahoivien=a.mahoivien
where day(giovao)=day(getdate()) and month(giovao)=month(getdate())and year(giovao)=year(getdate()) and MaPhongTap = @maphongtap
order by GioVao desc