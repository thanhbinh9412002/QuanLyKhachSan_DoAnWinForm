create database QuanLyKhachSan
go
use QuanLyKhachSan
go
create table dbo.hethong
(
		username varchar(30) PRIMARY KEY,
		manhanvien char(5) NULL,
		machucvu char(5) NULL,  --loc them
		passwordtk varchar(30) NULL
)
go
	insert into hethong Values('thanha@', 'NV01','NV' ,'04521386')
	insert into hethong Values('nguyenha@', 'NV02', 'NV','07425386')
	insert into hethong Values('vanb@', 'NV03', 'NV','04584386')
	insert into hethong Values('lenguyen@', 'NV04', 'NV','07191386')
	insert into hethong Values('levan@', 'NV05', 'NV','09421386')
	insert into hethong Values('pvtquang@', 'NV06', 'QL','0123456')
	insert into hethong Values('loc@', 'NV07', 'QL','123')
	insert into hethong Values('thanhab@', 'NV08', 'QL','7542153')
	insert into hethong Values('ntbinh@', 'NV09', 'NV','3456789')
	insert into hethong Values('hothanh@', 'NV10', 'NV','4751439')
go


create table dbo.nhanvien
(
		manhanvien char(5) PRIMARY KEY,
		tennhanvien varchar(40) NULL,
		ngaysinh date NULL,
		phai varchar(5),
		diachi varchar(50) NULL,
		phone varchar(20) NULL,
		chucvu varchar(20) NULL
)
go
	insert into nhanvien Values('NV01', 'nguyen a', '2000-05-10', 'nam', 'ho chi minh', '0423578169', 'le tan')
	insert into nhanvien Values('NV02', 'le b', '2002-03-15', 'nu', 'binh dinh', '0447568169', 'bao ve')
	insert into nhanvien Values('NV03', 'ho c', '1999-10-25', 'nam', 'binh thuan', '0484308169', 've sinh')
	insert into nhanvien Values('NV04', 'bui d', '1997-02-03', 'nu', 'phu yen', '0752378169', 'bao ve')
	insert into nhanvien Values('NV05', 'quach e', '2001-04-05', 'nu', 'quang ngai', '9457578169', 'quan li')
	insert into nhanvien Values('NV06', 'tran f', '2000-12-05', 'nam', 'ca mau', '8453278169', 've sinh')
	insert into nhanvien Values('NV07', 'van q', '2001-09-09', 'nam', 'dong nai', '0754378169', 'bao ve')
	insert into nhanvien Values('NV08', 'ho x', '2002-01-04', 'nu', 'lam dong', '0426978169', 'le tan')
	insert into nhanvien Values('NV09', 'nguyen n', '2000-07-08', 'nu', 'binh dinh', '7513578169', 'quan li')
	insert into nhanvien Values('NV10', 'le n', '2000-06-15', 'nam', 'dong thap', '4268578169', 'le tan')
go
Alter table hethong WITH CHECK ADD FOREIGN KEY(manhanvien) REFERENCES nhanvien(manhanvien)
go


create table dbo.loaiphong
(
		maloai char(10) PRIMARY KEY,
		gia int NULL,
		songuoi int NULL
)
go
	insert into loaiphong Values('L-Vip', '500000', 4)
	insert into loaiphong Values('L-Normal', '250000', 2)
	insert into loaiphong Values('L-Cheap', '150000', 1)
go

create table dbo.phong
(
		maphong char(5) PRIMARY KEY,
		maloai char(10) NULL,
		dadat char(5) NULL,
		danhan char(5) NULL
)
go
insert into phong Values('P101', 'L-Normal', 'khong', 'khong')
insert into phong Values('P102', 'L-Vip', 'co', 'co')
insert into phong Values('P103', 'L-Vip', 'khong', 'khong')
insert into phong Values('P104', 'L-Cheap', 'khong', 'khong')
insert into phong Values('P105', 'L-Cheap', 'co', 'co')
insert into phong Values('P106', 'L-Normal', 'khong', 'khong')


insert into phong Values('P201', 'L-Cheap', 'khong', 'khong')
insert into phong Values('P202', 'L-Normal', 'co', 'khong')
insert into phong Values('P203', 'L-Vip', 'khong', 'khong')
insert into phong Values('P204', 'L-Cheap', 'khong', 'khong')
insert into phong Values('P205', 'L-Normal', 'khong', 'khong')
insert into phong Values('P206', 'L-Vip', 'co', 'co')

insert into phong Values('P301', 'L-Normal', 'co', 'khong')
insert into phong Values('P302', 'L-Normal', 'co', 'khong')
insert into phong Values('P303', 'L-Vip', 'khong', 'khong')
insert into phong Values('P304', 'L-Cheap', 'khong', 'khong')
insert into phong Values('P305', 'L-Cheap', 'co', 'khong')
insert into phong Values('P306', 'L-Vip', 'khong', 'khong')

insert into phong Values('P401', 'L-Vip', 'co', 'co')
insert into phong Values('P402', 'L-Normal', 'khong', 'khong')
insert into phong Values('P403', 'L-Vip', 'khong', 'khong')
insert into phong Values('P404', 'L-Cheap', 'khong', 'khong')
insert into phong Values('P405', 'L-Cheap', 'co', 'co')
insert into phong Values('P406', 'L-Normal', 'khong', 'khong')
go
Alter table phong WITH CHECK ADD FOREIGN KEY(maloai) REFERENCES loaiphong(maloai)
go

create table dbo.trangthaiphong
(
		maphong char(5) references phong(maphong),
		trangthai varchar(50),
		PRIMARY KEY(maphong, trangthai)
)
go
	insert into trangthaiphong Values('P101', 'tot')
	insert into trangthaiphong Values('P102', 'tot')
	insert into trangthaiphong Values('P103', 'tot')
	insert into trangthaiphong Values('P104', 'tot')
	insert into trangthaiphong Values('P105', 'tot')
	insert into trangthaiphong Values('P106', 'tot')

	insert into trangthaiphong Values('P201', 'tot')
	insert into trangthaiphong Values('P202', 'tot')
	insert into trangthaiphong Values('P203', 'tot')
	insert into trangthaiphong Values('P204', 'tot')
	insert into trangthaiphong Values('P205', 'tot')
	insert into trangthaiphong Values('P206', 'tot')

	insert into trangthaiphong Values('P301', 'tot')
	insert into trangthaiphong Values('P302', 'tot')
	insert into trangthaiphong Values('P303', 'tot')
	insert into trangthaiphong Values('P304', 'tot')
	insert into trangthaiphong Values('P305', 'tot')
	insert into trangthaiphong Values('P306', 'tot')
	
	insert into trangthaiphong Values('P401', 'tot')
	insert into trangthaiphong Values('P402', 'tot')
	insert into trangthaiphong Values('P403', 'tot')
	insert into trangthaiphong Values('P404', 'tot')
	insert into trangthaiphong Values('P405', 'tot')
	insert into trangthaiphong Values('P406', 'tot')
go


create table dbo.vattu
(
		mavattu char(5) PRIMARY KEY,
		tenvattu varchar(20) NULL
)
go
	insert into vattu Values('VT01','nem')
	insert into vattu Values('VT02','goi')
	insert into vattu Values('VT03','ghe')
	insert into vattu Values('VT04','tivi')
	insert into vattu Values('VT05','quat tran')
	insert into vattu Values('VT06','khan')
	insert into vattu Values('VT07','kem danh rang')
	insert into vattu Values('VT08','luoc')
	insert into vattu Values('VT09','coc')
	insert into vattu Values('VT10','ao')
go

create table dbo.chitietvattu
(
		mavattu char(5) references vattu(mavattu), 
		maloai char(10) references loaiphong(maloai),
		soluong int NULL,
		PRIMARY KEY (mavattu)
)
go
	insert into chitietvattu Values('VT01', 'L-Vip', 4)
	insert into chitietvattu Values('VT02', 'L-Vip', 2)
	insert into chitietvattu Values('VT03', 'L-Vip', 3)
	insert into chitietvattu Values('VT04', 'L-Normal', 7)
	insert into chitietvattu Values('VT05', 'L-Normal', 5)
	insert into chitietvattu Values('VT06', 'L-Normal', 4)
	insert into chitietvattu Values('VT07', 'L-Normal', 6)
	insert into chitietvattu Values('VT08', 'L-Cheap', 1)
	insert into chitietvattu Values('VT09', 'L-Cheap', 2)
	insert into chitietvattu Values('VT10', 'L-Cheap', 3)
go


create table dbo.phieuthuephong
(
		maphieuthue char(5) PRIMARY KEY,
		maphong char(5) references phong(maphong),
		username varchar(30) NULL
)
go
	insert into phieuthuephong Values('PT01', 'P301', 'thanha@')
	insert into phieuthuephong Values('PT02', 'P406', 'nguyenha@')
	insert into phieuthuephong Values('PT03', 'P401', 'vanb@')
	insert into phieuthuephong Values('PT04', 'P305', 'lenguyen@')
	insert into phieuthuephong Values('PT05', 'P202', 'levan@')
go
Alter table phieuthuephong WITH CHECK ADD FOREIGN KEY(username) REFERENCES hethong(username)
go


create table dbo.phieudatphong
(
		maphieudat char(5) PRIMARY KEY,
		maphong char(5) references phong(maphong),
		username varchar(30) NULL,
)
go
	insert into phieudatphong Values('PD01', 'P102', 'pvtquang@')
	insert into phieudatphong Values('PD02', 'P302', 'pvtquang@')
	insert into phieudatphong Values('PD03', 'P105', 'pvtquang@')
	insert into phieudatphong Values('PD04', 'P206', 'loc@')
	insert into phieudatphong Values('PD05', 'P405', 'loc@')
go
Alter table phieudatphong WITH CHECK ADD FOREIGN KEY(username) REFERENCES hethong(username)
go


create table dbo.khachhang
(
		makhachhang char(5) PRIMARY KEY,
		tenkhachhang varchar(40) NULL,
		gioitinh char(5) NULL,
		cmnd_passport varchar(20) NULL,
		diachi varchar(50) NULL,
		coquan varchar(30) NULL,
		sodienthoai varchar(20) NULL,
		email varchar(20) NULL
)
go
	insert into khachhang Values('KH01', 'van a', 'nam', '124255356258', 'lam dong', 'abdc', '046621368433', '489afv@gmail.com')
	insert into khachhang Values('KH02', 'thi b', 'nu', '1242452428', 'hai phong', 'efgh', '04662136745', '123abc@gmail.com')
	insert into khachhang Values('KH03', 'nguyen c', 'nam', '12421125458', 'ha noi', 'dgvg', '04662475213', '758adr@gmail.com')
	insert into khachhang Values('KH04', 'bui d', 'nam', '124255310108', 'hue', 'thfg', '046621387542', '4582awdd@gmail.com')
	insert into khachhang Values('KH05', 'le thi e', 'nu', '124255540058', 'da nang', 'fdrrf', '04662175285', 'ajdu14@gmail.com')
	insert into khachhang Values('KH06', 'minh thu', 'nu', '124214201258', 'binhy dinh', 'ythnv', '04662138464', 'qs425@gmail.com')
	insert into khachhang Values('KH07', 'bui g', 'nu', '1245225400258', 'ninh thuan', 'tfhfd', '046621348856', 'awch45@gmail.com')
	insert into khachhang Values('KH08', 'nguyen d', 'nam', '1242144235258', 'tien giang', 'tghvfc', '046621347532', 'awbc45@gmail.com')
	insert into khachhang Values('KH09', 'ho z', 'nam', '1242541258', 'long an', 'thfhv', '0466214775', 'qjdjc@gmail.com')
	insert into khachhang Values('KH10', 'le q', 'nam', '12445116258', 'kien giang', 'awqdx', '046621384754', 'thmfjb42@gmail.com')
go


create table dbo.dichvu
(
		madichvu char(5) PRIMARY KEY,
		tendichvu varchar(30) NULL,
		gia int NULL,
		donvitinh char(5) NULL
)
go
	insert into dichvu Values('DV01', 'nuoc loc', '5000', 'dong')
	insert into dichvu Values('DV02', 'nuoc pepsi', '20000', 'dong')
	insert into dichvu Values('DV03', 'banh quy', '50000', 'dong')
	insert into dichvu Values('DV04', 'bia', '300000', 'dong')
	insert into dichvu Values('DV05', 'giac ui', '70000', 'dong')
	insert into dichvu Values('DV06', 've sinh', '20000', 'dong')
	insert into dichvu Values('DV07', 'khan giay', '10000', 'dong')
	insert into dichvu Values('DV08', 'banh gao', '30000', 'dong')
	insert into dichvu Values('DV09', 'ga ran', '100000', 'dong')
	insert into dichvu Values('DV10', 'sua', '20000', 'dong')
go


create table dbo.chitietthuephong
(
		maphieuthue char(5) references phieuthuephong(maphieuthue),
		makhachhang char(5) references khachhang(makhachhang),
		ngaythuephong date NULL,
		sotiencoc int NULL,
		songuoi int NULL,
		PRIMARY KEY(maphieuthue)
)
go
	insert into chitietthuephong Values('PT01', 'KH01', '2021-10-04','100000', 2)
	insert into chitietthuephong Values('PT02', 'KH02', '2022-04-20','150000', 3)
	insert into chitietthuephong Values('PT03', 'KH03', '2022-01-10','100000', 4)
	insert into chitietthuephong Values('PT04', 'KH04', '2022-03-05','200000', 6)
	insert into chitietthuephong Values('PT05', 'KH05', '2022-04-29','150000', 4)
go


create table dbo.chitietdatphong
(
		maphieudat char(5) references phieudatphong(maphieudat),
		makhachhang char(5) references khachhang(makhachhang),
		ngaythuephong date NULL,
		sotiencoc int NULL,
		songuoi int NULL,
		PRIMARY KEY(maphieudat)
)
go
	insert into chitietdatphong Values('PD01', 'KH01', '2021-10-04', '100000', 2)
	insert into chitietdatphong Values('PD02', 'KH02', '2022-04-20', '150000', 3)
	insert into chitietdatphong Values('PD03', 'KH03', '2022-01-10', '210000', 4)
	insert into chitietdatphong Values('PD04', 'KH04', '2022-03-05', '125000', 6)
	insert into chitietdatphong Values('PD05', 'KH05', '2022-04-29', '130000', 4)
go

create table dbo.hoadon
(
		mahoadon char(5) PRIMARY KEY,
		makhachhang char(5) references khachhang(makhachhang),
		manhanvien char(5) references nhanvien(manhanvien),
		ngaythanhtoan date NULL,
		maphieuthue char(5) references phieuthuephong(maphieuthue),
		sotiencoc int NULL,
		songayo int NULL,
		sotienkhuyenmai int NULL,
		tongtien int NULL,
)
go
insert into hoadon Values('HD01', 'KH01', 'NV01','2021-10-14', 'PT01', '100000', 10, '100000','300000')
insert into hoadon Values('HD02','KH02', 'NV02','2022-04-30' , 'PT02', '150000', 10,'80000','450000')
insert into hoadon Values('HD03','KH03', 'NV03','2022-01-14', 'PT03', '100000', 4,'120000', '600000')
insert into hoadon Values('HD04','KH04', 'NV04','2022-05-02', 'PT04', '200000', 15,'110000', '350000' )
insert into hoadon Values('HD05','KH05', 'NV05','2022-05-01', 'PT05', '150000', 3, '89000', '450000')
go

create table dbo.chitietdichvu
(
		mahoadon char(5) references hoadon(mahoadon),
		maphieuthue char(5) references phieuthuephong(maphieuthue),
		madichvu char(5) references dichvu(madichvu),
		soluong int NULL,
		PRIMARY KEY( mahoadon, maphieuthue, madichvu)
)
go
	insert into chitietdichvu Values('HD01','PT01','DV01', 2)
	insert into chitietdichvu Values('HD01','PT01','DV02', 3)
	insert into chitietdichvu Values('HD01','PT01','DV03', 1)
	insert into chitietdichvu Values('HD01','PT01','DV08', 4)
	insert into chitietdichvu Values('HD01','PT01','DV05', 2)
	insert into chitietdichvu Values('HD01','PT01','DV04', 2)
	insert into chitietdichvu Values('HD01','PT01','DV09', 3)
	insert into chitietdichvu Values('HD02','PT02','DV02', 1)
	insert into chitietdichvu Values('HD02','PT02','DV07', 4)
	insert into chitietdichvu Values('HD02','PT02','DV05', 2)
	insert into chitietdichvu Values('HD02','PT02','DV01', 2)
	insert into chitietdichvu Values('HD02','PT02','DV04', 3)
	insert into chitietdichvu Values('HD03','PT03','DV03', 1)
	insert into chitietdichvu Values('HD03','PT03','DV04', 4)
	insert into chitietdichvu Values('HD03','PT03','DV05', 2)
	insert into chitietdichvu Values('HD03','PT03','DV07', 2)
	insert into chitietdichvu Values('HD04','PT04','DV10', 3)
	insert into chitietdichvu Values('HD04','PT04','DV09', 1)
	insert into chitietdichvu Values('HD04','PT04','DV04', 4)
	insert into chitietdichvu Values('HD04','PT04','DV03', 2)
	insert into chitietdichvu Values('HD04','PT04','DV02', 1)
	insert into chitietdichvu Values('HD05','PT05','DV01', 4)
	insert into chitietdichvu Values('HD05','PT05','DV09', 2)
	insert into chitietdichvu Values('HD05','PT05','DV03', 2)
	insert into chitietdichvu Values('HD05','PT05','DV02', 3)
	insert into chitietdichvu Values('HD05','PT05','DV06', 1)
	insert into chitietdichvu Values('HD05','PT05','DV07', 4)
	insert into chitietdichvu Values('HD05','PT05','DV10', 2)
	insert into chitietdichvu Values('HD05','PT05','DV08', 1)
	insert into chitietdichvu Values('HD05','PT05','DV04', 4)
go