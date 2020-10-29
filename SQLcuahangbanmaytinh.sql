create database QLCuaHangMayTinh
use QLCuaHangMayTinh
--Bang 3
create table tblNhaCC(MaNCC char(10) primary key, TenNCC varchar(50),Diachi nvarchar(50),sdt int)
--Bang 1
create table tblThongtinMT(MaMT char(10) primary key, tenmt varchar(50), MaNCC char(10) foreign key (MaNCC) references tblNhaCC(MaNCC) on delete cascade on update cascade
, soluong int, giaban int)
--Bang 2
create table tblNhanvien(MaNV char(10) primary key, TenNV varchar(50), GioiTinh nvarchar(50), DiaChi nvarchar(50),sdt int)
--Bang 4
create table tblKhachhang(MaKH char(10) primary key, TenKH varchar(50), GioiTinh nvarchar(50), DiaChi nvarchar(50), sdt int)
--Bang 5
create table tblHoadonnhap(MaHDN char(10) primary key,MaNV char(10) foreign key (MaNV) references tblNhanvien(MaNV) on delete cascade on update cascade
,MaMT char(10) foreign key (MaMT) references tblThongtinMT(MaMT) on delete cascade on update cascade
,MaNCC char(10) foreign key (MaNCC) references tblNhaCC(MaNCC) on delete no action on update no action
,Soluong int,Ngayban date,Diachi varchar(50),sdt int, Dongia float,Tongtien float)
--Bang 6
create table tblHoadonban(MaHDB char(10) primary key,MaNV char(10) foreign key (MaNV)references tblNhanvien(MaNV) on delete cascade on update cascade
,MaKH char(10) foreign key (MaKH) references tblKhachhang(MaKH) on delete cascade on update cascade
,MaMT char(10)foreign key (MaMT) references tblThongtinMT(MaMT) on delete cascade on update cascade
,Soluong int,Ngayban date,Diachi varchar(50),sdt int, Dongia float,Tongtien float)

--Them thong tin nha cung cap
insert into tblNhaCC values('NCC01','TRANTUYEN','HY','1659939186')
insert into tblNhaCC values('NCC02','TRINHTHUY','HY','122345')

--Them thong tin may tinh
insert into tblThongTinMT values('MT01','DELL','NCC01','2','1200')
insert into tblThongTinMT values('MT02','ASUS','NCC01','2','1200')

--Them thong tin nhan vien
insert into tblNhanvien values('NV01', 'NGOCKHA', 'NAM', 'TPHCM', 0123456789)
insert into tblNhanvien values('NV02', 'VANCUONG', 'NAM', 'PHUYEN', 0123456789)

--Them thong tin khach hang
insert into tblKhachhang values('KH01', 'NGOCPHIEN', 'NAM', 'TPHCM', 0123456769)
insert into tblKhachhang values('KH02', 'MINHKHANG', 'NAM', 'TPHCM', 0123456779)

--Them thong tin hoa don ban
insert into tblHoadonban values ('HDB01','NV01','KH01','MT01','1200','2014-01-01','HY','1659939285','120','144000')
insert into tblHoadonban values ('HDB02','NV01','KH01','MT01','12','2014-01-03','HY','1356789','100','1200')

--Them thong tin hoa don nhap
insert into tblHoadonnhap values ('HDN01','NV01','MT01','NCC01','125','2014-01-10','HN','1465676778','1005','125625')
insert into tblHoadonnhap values ('HDN02','NV01','MT01','NCC01','23','2014-01-01','HY','2132456','12000','276000')








