create proc dbo.HSP_GetMemberPackageList
as
	select row_number() over (order by(select 1)) as STT,  MaGoiTap,TenGoiTap,SoNgay,SoLanTap,GioBD,GioKT,DonGia,HinhThucTap,LoaiGoiTap,TenLoai,MonTap,TenMonTap,PhongTap,TenPhongTap 
	from GYM_GoiTap a join GYM_LoaiGoiTap b on a.LoaiGoiTap = b.MaLoai join GYM_MonTap c on a.MonTap = c.MaMonTap join GYM_PhongTap d on a.PhongTap = d.MaPhongTap
	where a.TinhTrang = 1
go
create proc dbo.HSP_DeleteMemberPackage
@packageId int
as
	delete from GYM_GoiTap where MaGoiTap = @packageId
go
create proc dbo.HSP_GetAllRooms
as
	select MaPhongTap,TenPhongTap
	from GYM_PhongTap
	where TinhTrang = 1
go
create proc dbo.HSP_GetAllSubjects
as
	select MaMonTap,TenMonTap
	from GYM_MonTap
	where TinhTrang = 1
go
create proc dbo.HSP_GetAllPackageType
as
	select MaLoai,TenLoai
	from GYM_LoaiGoiTap
	where TinhTrang = 1
go
alter table GYM_GoiTap alter column SoLanTap int
go
create proc dbo.HSP_UpdateMemberPackage
@packageId int,
@packageName nvarchar(50),
@roomId int,
@subjectId int,
@packageType int,
@dayNumber int,
@price float,
@startTime time,
@endTime time,
@type int,
@turnNumber int
as
	update GYM_GoiTap
	set LoaiGoiTap = @packageType,
		MonTap = @subjectId,
		PhongTap = @roomId,
		TenGoiTap = @packageName,
		SoNgay = @dayNumber,
		SoLanTap = @turnNumber,
		GioBD = @startTime,
		GioKT = @endTime,
		DonGia = @price,
		HinhThucTap = @type
	where MaGoiTap = @packageId
go
create proc dbo.HSP_AddMemberPackage
@packageName nvarchar(50),
@roomId int,
@subjectId int,
@packageType int,
@dayNumber int,
@price float,
@startTime time,
@endTime time,
@type int,
@turnNumber int
as
	insert into GYM_GoiTap(LoaiGoiTap, MonTap, PhongTap, TenGoiTap, SoNgay, SoLanTap, GioBD, GioKT, DonGia, HinhThucTap) values(@packageType, @subjectId, @roomId, @packageName, @dayNumber, @turnNumber, @startTime, @endTime, @price, @type)