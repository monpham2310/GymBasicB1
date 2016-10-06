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
