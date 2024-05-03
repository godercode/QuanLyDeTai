CREATE DATABASE QuanLyDeTai;
GO

CREATE TABLE tblGiangVien
(
    sMaGV NVARCHAR(50) NOT NULL PRIMARY KEY,
    sTenGV NVARCHAR(100) NOT NULL,
    sGioiTinh NVARCHAR(10),
    sSDT NVARCHAR(12),
    sEmail NVARCHAR(50),
    sChucVu NVARCHAR(50),
    sNgaySinh DATE
);
GO

CREATE TABLE tblNhom
(
    sMaN NVARCHAR(10) NOT NULL PRIMARY KEY,
    iSoSV INT
);
GO

CREATE TABLE tblLinhVuc
(
    sMaLV NVARCHAR(10) NOT NULL PRIMARY KEY,
    sTenLV NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE tblDeTai
(
    sMaDT NVARCHAR(10) NOT NULL PRIMARY KEY,
    sTenDT NVARCHAR(50) NOT NULL,
    sMaLV NVARCHAR(10),
    sNamTH NVARCHAR(10),
    sMaN NVARCHAR(10),
    sMaGV NVARCHAR(50),
    sDiem FLOAT,
    CONSTRAINT fk_DT_LV FOREIGN KEY (sMaLV) REFERENCES tblLinhVuc(sMaLV),
    CONSTRAINT fk_DT_N FOREIGN KEY (sMaN) REFERENCES tblNhom(sMaN),
    CONSTRAINT fk_DT_GV FOREIGN KEY (sMaGV) REFERENCES tblGiangVien(sMaGV)
);
GO

CREATE TABLE tblSinhVien
(
    sMaSV NVARCHAR(50) NOT NULL PRIMARY KEY,
    sTenSV NVARCHAR(100) NOT NULL,
    sGioiTinh NVARCHAR(10),
    sLopHC NVARCHAR(10),
    sEmail NVARCHAR(50),
    sSDT NVARCHAR(12),
    sMaN NVARCHAR(10),
    CONSTRAINT fk_SV_N FOREIGN KEY (sMaN) REFERENCES tblNhom(sMaN)
);
GO

CREATE PROCEDURE Select_tblSinhVien
AS
BEGIN
    SELECT * FROM tblSinhVien;
END
GO

CREATE PROCEDURE Insert_tblSinhVien
    @sMaSV NVARCHAR(50),
    @sTenSV NVARCHAR(100),
    @sGioiTinh NVARCHAR(10),
    @sLopHC NVARCHAR(10),
    @sEmail NVARCHAR(50),
    @sSDT NVARCHAR(12),
    @sMaN NVARCHAR(10)
AS
BEGIN
    INSERT INTO tblSinhVien VALUES (@sMaSV, @sTenSV, @sGioiTinh, @sLopHC, @sEmail, @sSDT, @sMaN);
END
GO

CREATE PROCEDURE Delete_tblSinhVien
    @sMaSV NVARCHAR(50)
AS
BEGIN
    DELETE FROM tblSinhVien WHERE sMaSV = @sMaSV;
END
GO

CREATE PROCEDURE Update_tblSinhVien
    @sMaSV NVARCHAR(50),
    @sTenSV NVARCHAR(100),
    @sGioiTinh NVARCHAR(10),
    @sLopHC NVARCHAR(10),
    @sEmail NVARCHAR(50),
    @sSDT NVARCHAR(12),
    @sMaN NVARCHAR(10)
AS
BEGIN
    UPDATE tblSinhVien
    SET
        sTenSV = @sTenSV,
        sGioiTinh = @sGioiTinh,
        sLopHC = @sLopHC,
        sEmail = @sEmail,
        sSDT = @sSDT,
        sMaN = @sMaN
    WHERE sMaSV = @sMaSV;
END
GO

CREATE PROCEDURE Insert_tblGiangVien
    @sMaGV NVARCHAR(50),
    @sTenGV NVARCHAR(100),
    @sGioiTinh NVARCHAR(10),
    @sSDT NVARCHAR(12),
    @sEmail NVARCHAR(50),
    @sChucVu NVARCHAR(50),
    @sNgaySinh DATE
AS
BEGIN
    INSERT INTO tblGiangVien VALUES (@sMaGV, @sTenGV, @sGioiTinh, @sSDT, @sEmail, @sChucVu, @sNgaySinh);
END
GO

CREATE PROCEDURE Delete_tblGiangVien
    @sMaGV NVARCHAR(50)
AS
BEGIN
    DELETE FROM tblGiangVien WHERE sMaGV = @sMaGV;
END
GO

CREATE PROCEDURE Update_tblGiangVien
    @sMaGV NVARCHAR(50),
    @sTenGV NVARCHAR(100),
    @sGioiTinh NVARCHAR(10),
    @sSDT NVARCHAR(12),
    @sEmail NVARCHAR(50),
    @sChucVu NVARCHAR(50),
    @sNgaySinh DATE
AS
BEGIN
    UPDATE tblGiangVien
    SET
        sTenGV = @sTenGV,
        sGioiTinh = @sGioiTinh,
        sSDT = @sSDT,
        sEmail = @sEmail,
        sChucVu = @sChucVu,
        sNgaySinh = @sNgaySinh
    WHERE sMaGV = @sMaGV;
END
GO

CREATE PROCEDURE Insert_tblNhom
    @sMaN NVARCHAR(10),
    @iSoSV INT
AS
BEGIN
    INSERT INTO tblNhom VALUES (@sMaN, @iSoSV);
END
GO

CREATE PROCEDURE Delete_tblNhom
    @sMaN NVARCHAR(10)
AS
BEGIN
    DELETE FROM tblNhom WHERE sMaN = @sMaN;
END
GO

CREATE PROCEDURE Update_tblNhom
    @sMaN NVARCHAR(10),
    @iSoSV INT
AS
BEGIN
    UPDATE tblNhom SET iSoSV = @iSoSV WHERE sMaN = @sMaN;
END
GO

CREATE PROCEDURE Insert_tblLinhVuc
    @sMaLV NVARCHAR(10),
    @sTenLV NVARCHAR(50)
AS
BEGIN
    INSERT INTO tblLinhVuc VALUES (@sMaLV, @sTenLV);
END
GO

CREATE PROCEDURE Delete_tblLinhVuc
    @sMaLV NVARCHAR(10)
AS
BEGIN
    DELETE FROM tblLinhVuc WHERE sMaLV = @sMaLV;
END
GO

CREATE PROCEDURE Update_tblLinhVuc
    @sMaLV NVARCHAR(10),
    @sTenLV NVARCHAR(50)
AS
BEGIN
    UPDATE tblLinhVuc SET sTenLV = @sTenLV WHERE sMaLV = @sMaLV;
END
GO

CREATE PROCEDURE Select_TongHop1
AS
BEGIN
    SELECT * FROM tblGiangVien JOIN tblDeTai ON tblGiangVien.sMaGV = tblDeTai.sMaGV;
END
GO

Create database QuanLyDeTai
go 
create table tblGiangVien
	(
	sMaGV nvarchar(50) not null primary key,
	sTenGV nvarchar(100) not null,
	sGioiTinh nvarchar(10),
	sSDT nvarchar(12),
	sEmail nvarchar(20),
	sChucVu nvarchar(20),
	sNgaySinh date
	);
go
create table tblNhom
(
	 sMaN nvarchar(10) not null primary key,
	 iSoSV int
	 
);
go
create table tblLinhVuc
( 
	sMaLV nvarchar(10) not null primary key,
	sTenLV nvarchar(50)  not null
	);
go
create table tblDeTai
(
	sMaDT nvarchar(10) not null primary key,
	sTenDT nvarchar(50) not null,
	sMaLV nvarchar(10),
	sNamTH nvarchar(10),
	sMaN nvarchar(10),
	sMaGV nvarchar(50),
	sDiem float,
	CONSTRAINT fk_DT_LV FOREIGN KEY (sMaLV) REFERENCES tblLinhVuc(sMaLV),
	CONSTRAINT fk_DT_N FOREIGN KEY (sMaN) REFERENCES tblNhom(sMaN),
	CONSTRAINT fk_DT_GV FOREIGN KEY (sMaGV) REFERENCES tblGiangVien(sMaGV)
);
go
create table tblSinhVien
(
sMaSV nvarchar(50) not null primary key,
sTenSV nvarchar(100) not null,
sGioiTinh nvarchar(10),
sLopHC nvarchar(10),
sEmail nvarchar(20),
sSDT nvarchar(12),
sMaN nvarchar(10),

CONSTRAINT fk_SV_N FOREIGN KEY (sMaN) REFERENCES tblNhom(sMaN),
);
go
 Create proc FK_tblSinhVien
@sMaN nvarchar(10)
as
begin 
select sMaN from tblDeTai
where sMaN= @sMaN
end
go
Create proc FK_tblGiangVien
@sMaGV nvarchar(50)
as
begin
select sMaGV from tblDeTai
where sMaGV =@sMaGV
end
go
insert into tblLinhVuc
	values
	('LV001',N'An ninh và b?o m?t d? li?u'),
	('LV002',N'Công ngh? ph?n m?m');	
go
insert into tblGiangVien
	values
	('GV01',N'V? Xuân H?nh','Nam','0147258369','hanh@hou.edu.vn',N'Gi?ng viên','1985/05/05'),
	('GV02',N'Lê H?u D?ng','Nam','0123456789','dung@hou.edu.vn',N'Phó ch? nhi?m','1982/02/01'),
	('GV03',N'Nguy?n Th? Tâm',N'N?','0789456111','tam@hou.edu.vn',N'Gi?ng viên','1981/02/02'),
	('GV04',N'Tr?nh Th? Xuân',N'N?','0789456123','trinhxuan@hou.edu.vn',N'Gi?ng viên','1979/05/02'),
	('GV05',N'Tr?n Duy Hùng','Nam','0456123789','hung@hou.edu.vn',N'Gi?ng viên','1984/05/01'); 
go
insert into tblNhom
	 values('N001',2),('N002',2),('N003',2),('N004',2),('N005',2),('N006',2),('N007',2),('N008',2),
	 ('N009',2),('N0010',2),('N0011',2),('N0012',2),('N0013',2),('N0014',2),('N0015',2),('N0016',2),('N0017',2);
go
insert into tblDeTai
	values
	('DT001',N'Mã hóa và gi?i mã d? li?u','LV001','2021-2022','N001','GV01','75'),
	('DT002',N'Forensics và ?ng d?ng','LV001','2022-2023','N002','GV01','80'),
	('DT003',N'Tìm hi?u Framework C++','LV002','2022-2023','N003','GV04','62'),
	('DT004',N'Tìm hi?u Framework Flutter','LV002','2022-2023','N004','GV04','85'),
	('DT005',N'Tìm hi?u công ngh? ADO.NET','LV002','2022-2023','N0017','GV02','65');
go
insert into tblSinhVien
VALUES
('16A10025311','Lê Vi?t Thành','Nam','1610A04','thnah@gmail.com','0953145723','N006'),
('16A10025312','Lê Vi?t Long','Nam','1610A04','long@gmail.com','0953145921','N003'),
('17A10010245','?àm Ph??ng Dung','N?','1710A01','dung123@gmail.com','0845123456','N0010'),
('17A10010255','Nguy?n Minh Ánh','N?','1710A04','anh1@gmail.com','0456852691','N006'),
('18A10010025','?oàn Thu Th?o','N?','1810A03','thao1@gmail.com','0124579210','N005'),
('18A10010222','Bùi Th? H?i','Nam','1810A01','haiuuu@gmail.com','0321562310','N0015');
GO
/*SELECT* FROM tblDeTai
SELECT*FROM tblGiangVien
Select* from tblLinhVuc
select*from tblNhom
select* from tblSinhVien*/
Create proc Select_tblSinhVien
as
begin 
Select * from tblSinhVien 
end
go
Create proc Insert_tblSinhVien
 @sMaSV nvarchar(50), @sTenSV nvarchar(100), @sGioiTinh nvarchar(10), @sLopHC nvarchar(10), @sEmail nvarchar(20),@sSDT nvarchar(12), @sMaN nvarchar(10)
 as
 begin 
 Insert into tblSinhVien Values (@sMaSV, @sTenSV, @sGioitinh, @sLopHC, @sEmail,@sSDT, @sMaN) 
 end
 go
 Create proc Delete_tblSinhVien
 @sMaSV nvarchar(50)
 as
 begin
 Delete tblSinhVien where sMaSV= @sMaSV
 end
 go
 create proc Update_tblSinhVien
 @sMaSV nvarchar(50), @sTenSV nvarchar(100), @sGioiTinh nvarchar(10), @sLopHC nvarchar(10), @sEmail nvarchar(20),@sSDT nvarchar(12), @sMaN nvarchar(10)
 as
 begin
 update tblSinhVien
 set
 sTenSV=@sTenSV,
 sGioiTinh=@sEmail,
 sLopHC=@sLopHC,
 sEmail=@sEmail,
 sSDT=@sSDT,
 sMaN=@sMaN
 WHERE sMaSV= @sMaSV
 end
 go
 Create proc Insert_tblGiangVien
    @sMaGV NVARCHAR(50),
    @sTenGV NVARCHAR(100),
    @sGioiTinh nVarchar(10),
    @sSDT NCHAR(12),
    @sEmail NVARCHAR(50),
    @sChucVu NVARCHAR(50),
    @sNgaySinh date
 as
 begin 
 Insert into tblGiangVien
 values (@sMaGV, @sTenGV, @sGioiTinh, @sSDT, @sEmail, @sChucVu, @sNgaySinh)
end
go
create proc Select_TongHop1
as
begin
select* from tblGiangVien join tblDeTai
on tblGiangVien.sMaGV =tblDeTai.sMaGV
end
go
exec Select_TongHop1
go
CREATE proc Select_TongHop2
as
begin
select * from tblSinhVien join tblDeTai on tblSinhVien.sMaN=tblDeTai.sMaN join tblGiangVien on tblGiangVien.sMaGV =tblDeTai.sMaGV
end
go
Create proc Select_tblGiangVien
as
begin
select* from tblGiangVien
end
go
create proc Delete_tblGiangVien
@sMaGV nvarchar(50)
as
begin
delete from tblGIANGVIEN where sMaGV=@sMaGV
end
go
Create proc Select_tblDeTai
as
begin
Select * from tblDeTai
end
go
CREATE proc Update_tblGiangVien
 @sMaGV NVARCHAR(50),
    @sTenGV NVARCHAR(100),
    @sGioiTinh nVarchar(10),
    @sSDT NCHAR(12),
    @sEmail NVARCHAR(50),
    @sChucVu NVARCHAR(50),
    @sNgaySinh date
	as
	begin
	update tblGiangVien
	set
	sTenGV=@sTenGV,
	sGioiTinh=@sGioiTinh,
	sSDT =@sSDT,
	sEmail= @sEmail,
	sChucVu=@sChucVu,
	sNgaySinh=@sNgaySinh
	WHERE sMaGV=@sMaGV
	end
	go
Create proc Insert_tblDeTai
@sMaDT nvarchar(10), @sTenDT nvarchar(50), @sMaLV nvarchar(10),@sMaGV nvarchar(50), @sNamTH nvarchar(10),@sMaN nvarchar(10), @sDiem float
as
BEGIN		
		INSERT INTO tblDeTai(sMaDT,sTenDT,sMaLV,sMaGV,sNamTH,sMaN, sDiem)
		VALUES (@sMaDT, @sTenDT, @sMaLV,@sMaGV, @sNamTH,@sMaN, @sDiem)
end
go
Create proc Delect_tblDeTai
@sMaDT nvarchar(10)
as 
begin
delete tblDeTai where sMaDT= @sMaDT
end
go
create proc Update_tblDeTai
@sMaDT nvarchar(10), @sTenDT nvarchar(50), @sMaLV nvarchar(10),@sMaGV nvarchar(50), @sNamTH nvarchar(10),@sMaN nvarchar(10), @sDiem float
as
begin
UPDATE tblDeTai
    SET
        sTenDT = @sTenDT,
        sMaLV = @sMaLV,
        sMaGV = @sMaGV,
        sNamTH = @sNamTH,
		sMaN= @sMaN,
		sDiem=@sMaDT
    WHERE sMaDT = @sMaDT
end
go
Create proc Select_tblNhom
as
begin
select* from tblNhom
end
GO
create proc Insert_tblNhom
@sMaN nvarchar(10), @iSoSV int
as
begin
insert into tblNhom 
values(@sMaN, @iSoSV)
end
go
create proc Delete_tblNhom
@sMaN nvarchar(10)
as
begin
delete tblNhom where sMaN= @sMaN
end
go
create proc Update_tblNhom
@sMaN nvarchar(10), @iSoSV int
AS
begin
update tblNhom
set
iSoSV=@iSoSV
where sMaN=@sMaN
end
go
create proc Select_tblLinhVuc
as
begin
select*from tblLinhVuc
end
go
create proc Insert_tblLinhVuc
@sMaLV nvarchar(10), @sTenLV nvarchar(50)
as
begin
insert tblLinhVuc 
values(@sMaLV, @sTenLV)
end
go
CREATE pROC Delete_tblLinhVuc
@sMaLV nvarchar(10)
as
begin
delete tblLinhVuc WHERE sMaLV= @sMaLV
end
go
CREATE PROC Update_tblLinhVuc
@sMaLV nvarchar(10), @sTenLV nvarchar(50)
as
begin
update tblLinhVuc
SET
sTenLV=@sTenLV
where sMaLV=@sMaLV
end
go

create proc [dbo].[Update_tblDeTai]
@sMaDT nvarchar(10), @sTenDT nvarchar(50), @sMaLV nvarchar(10),@sMaGV nvarchar(50), @sNamTH nvarchar(10),@sMaN nvarchar(10), @sDiem float
as
begin
UPDATE tblDeTai
    SET
        sTenDT = @sTenDT,
        sMaLV = @sMaLV,
        sMaGV = @sMaGV,
        sNamTH = @sNamTH,
		sMaN= @sMaN,
		sDiem=@sDiem
    WHERE sMaDT = @sMaDT
end
go
Create proc [dbo].[sp_tenDTtheoKhoa]
 @madt varchar(10)
 AS
 Begin select sMaDT from tblDeTai
 Where @madt = sMaDT
 ENd
 go
 create proc FK_tblNhom
 @sMaN nvarchar(10)
 as
 begin
 select sMaN from tblDeTai where sMaN =  @sMaN
 end
 go
 create proc PK_tblNhom
  @sMaN nvarchar(10)
 as
 begin
 select count (*) from tblNhom where sMaN =@sMaN
 end
go
create proc Select_TongHop1
as
begin
select* from tblGiangVien join tblDeTai
on tblGiangVien.sMaGV =tblDeTai.sMaGV
end
go
exec Select_TongHop1
go
CREATE proc Select_TongHop2
as
begin
select * from tblSinhVien join tblDeTai on tblSinhVien.sMaN=tblDeTai.sMaN join tblGiangVien on tblGiangVien.sMaGV =tblDeTai.sMaGV
end
go
Create proc FK_tblGiangVien
@sMaGV nvarchar(50)
as
begin
select sMaGV from tblDeTai
where sMaGV =@sMaGV
end
go
Create proc FK_tblSinhVien
@sMaN nvarchar(10)
as
begin 
select sMaN from tblDeTai
where sMaN= @sMaN
end
go
create proc PK_tblSinhVien
@sMaSV nvarchar(50)
as
begin
select count(*) from tblSinhVien where sMaSV= @sMaSV
end
go
create proc PK_tblGiangVien
@sMaGV nvarchar(50)
as 
begin
select count(* ) from tblGiangVien
where sMaGV=@sMaGV
end
go
create proc Count_tblSinhVien
@sMaN nvarchar(10)
as
begin
select count (*)from tblSinhVien
where sMaN=@sMaN
end
go
create proc Select_TongHop3
as
begin
select* from tblLinhVuc join tblDeTai on tblLinhVuc.sMaLV=tblDeTai.sMaLV join tblNhom on tblNhom.sMaN= tblDeTai.sMaN
join tblGiangVien on tblGiangVien.sMaGV = tblDeTai.sMaGV join tblSinhVien on tblSinhVien.sMaN = tblDeTai.sMaN
end
exec Select_TongHop3
go
create proc FK_tblLinhVuc
@sMaLV nvarchar(10)
as
begin
select sMaLV from tblDeTai where sMaLV =@sMaLV
end
go
create proc PK_tblLinhVuc
@sMaLV nvarchar(10)
as
begin
select count(*) from tblLinhVuc where sMaLV =@sMaLV
end
