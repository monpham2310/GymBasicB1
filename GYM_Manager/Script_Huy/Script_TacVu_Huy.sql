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
go
create proc HSP_CheckExistsBarcode
@Barcode nvarchar(20)
as
	if exists (select * from HoiVien where MaThe = @Barcode and TinhTrang = 1)
	begin
		select 1
	end
	else
	begin
		select 0
	end
go
alter table GYM_HoaDon add TinhTrangTapLan bit default 0
alter table GYM_HoaDon add GioBD time
alter table GYM_HoaDon add GioKT time
go
alter proc HSP_GetDataFollowBarcodeOfMember --'0000001'
@Barcode nvarchar(20)
as
	select Ho + ' ' + Ten as TenHoiVien,Convert(nvarchar(10),NamSinh,103)as NamSinh ,Convert(int,(NgayHHTap-getdate())) as songayconlai,Convert(nvarchar(10),NgayHHTap,103) as NgayHetHan,HinhAnh,TenGoiTap,SoLanTapConLai,
DienThoai as SoDienThoai, MaPhongTap, TinhTrangNo, b.DonGia, GiamGia, TienDaTra, TinhTrangBaoLuu, NgayBDTap, b.MaGoiTap, MaThe, GhiChu, TinhTrangTapLan,b.GioBD,b.GioKT, MaHD,TenMonTap
	from GYM_HoiVien a left join GYM_HoaDon b on a.MaHoiVien = b.MaHoiVien left join GYM_GoiTap c on b.MaGoiTap = c.MaGoiTap left join GYM_MonTap d on c.MonTap = d.MaMonTap
	where MaThe = @Barcode and a.TinhTrang = 1
go
alter proc HSP_InsertNumberOfTurnInRoom
@Shift int,
@Bill nchar(10)
as	
	if exists (select MaCTVP from GYM_ChiTietVaoPhong where MaCTLV = @Shift and MaHD = @Bill and DaRa = 0)
	begin
		declare @Id int
		set @Id = (select MaCTVP from GYM_ChiTietVaoPhong where MaCTLV = @Shift and MaHD = @Bill and DaRa = 0)
		update GYM_ChiTietVaoPhong
		set DaRa = 1,
			GioRa = GETDATE()
		where MaCTVP = @Id
	end	
	insert into GYM_ChiTietVaoPhong(MaCTLV, MaHD) values (@Shift, @Bill)	
go
create proc HSP_InsertNumberOfTurnInRoom2
@Shift int,
@Bill nchar(10)
as	
	if exists (select MaCTVP from GYM_ChiTietVaoPhong where MaCTLV = @Shift and MaHD = @Bill and DaRa = 0)
	begin
		declare @Id int
		set @Id = (select MaCTVP from GYM_ChiTietVaoPhong where MaCTLV = @Shift and MaHD = @Bill and DaRa = 0)
		update GYM_ChiTietVaoPhong
		set DaRa = 1,
			GioRa = GETDATE()
		where MaCTVP = @Id
	end	
	insert into GYM_ChiTietVaoPhong(MaCTLV, MaHD) values (@Shift, @Bill)
	update GYM_HoaDon
	set SoLanTapConLai -= 1
	where MaHD = @Bill	
go
create proc HSP_CheckCardIsFirstTimeUse
@Bill nchar(10)
as
	declare @numberOfTurn int
	set @numberOfTurn = (select count(MaHD)
							from GYM_ChiTietVaoPhong
							where MaHD = @Bill)
	if(@numberOfTurn = 1)
	begin
		declare @numberOfDate int
		declare @packageId int
		set @packageId = (select MaGoiTap from GYM_HoaDon where MaHD = @Bill)
		set @numberOfDate = (select SoNgay from GYM_GoiTap where MaGoiTap = @packageId)
		update GYM_HoaDon
		set NgayBDTap = getdate(),
			NgayHHTap = Dateadd(dd, @numberOfDate, getdate())
		where MaHD = @Bill 
	end
go
create proc HSP_CheckRemainNumberOfTurnOfMember
@BillId nchar(10)
as
	declare @remainTurn int
	set @remainTurn = (select SoLanTapConLai from GYM_HoaDon where MaHD = @BillId)
	if(@remainTurn > 0)
		select 1
	else
		select 0