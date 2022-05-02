create database QuanLyKhachSan
use QuanLyKhachSan
go
create table dbo.phieuthuephong(
		maphieuthue char(5) PRIMARY KEY,
		maphieudat char(5) NULL,
		username varchar(30) NULL
)
go
insert into phieuthuephong Values('PT01', 'PD01', 'thanha@')
insert into phieuthuephong Values('PT02', 'PD02', 'nguyenha@')
insert into phieuthuephong Values('PT03', 'PD03', 'vanb@')
insert into phieuthuephong Values('PT04', 'PD04', 'lenguyen@')
insert into phieuthuephong Values('PT05', 'PD05', 'levan@')
insert into phieuthuephong Values('PT06', 'PD06', 'pvtquang@')
insert into phieuthuephong Values('PT07', 'PD07', 'thloc@')
insert into phieuthuephong Values('PT08', 'PD08', 'thanha@')
insert into phieuthuephong Values('PT09', 'PD09', 'ntbinh@')
insert into phieuthuephong Values('PT10', 'PD10', 'hothanh@')
go
create table dbo.hethong(
		username varchar(30) PRIMARY KEY,
		manhanvien char(5) NULL,
		passwordtk varchar(30) NULL
)
go
insert into hethong Values('thanha@', 'NV01', '04521386')
insert into hethong Values('nguyenha@', 'NV02', '07425386')
insert into hethong Values('vanb@', 'NV03', '04584386')
insert into hethong Values('lenguyen@', 'NV04', '07191386')
insert into hethong Values('levan@', 'NV05', '09421386')
insert into hethong Values('pvtquang@', 'NV06', '0123456')
insert into hethong Values('thloc@', 'NV07', '0123456')
insert into hethong Values('thanha@', 'NV08', '7542153')
insert into hethong Values('ntbinh@', 'NV09', '3456789')
insert into hethong Values('hothanh@', 'NV10', '4751439')
go
Alter table phieuthuephong WITH CHECK ADD FOREIGN KEY(username) REFERENCES hethong(username)
go
create table dbo.phieudatphong(
		maphieudat char(5) PRIMARY KEY,
		makhachhang char(5) NULL,
		ngayden date NULL,
		ngaydi date NULL,
		sotiendatcoc char(30) NULL,
		username varchar(30) NULL,
		tinhtrang varchar(30) NULL,
		songuoi int NULL
)
go
insert into phieudatphong Values('PD01', 'KH01', '2021-10-04', '2021-10-14', '100000', 'thanha@', 'tot', 2)
insert into phieudatphong Values('PD02', 'KH02', '2022-04-20', '2022-04-30', '500000', 'nguyenha@', 'binh thuong', 3)
insert into phieudatphong Values('PD03', 'KH03', '2022-01-10', '2022-01-14', '240000', 'vanb@', 'tot', 4)
insert into phieudatphong Values('PD04', 'KH04', '2022-03-05', '2022-03-20', '150000', 'lenguyen@', 'binh thuong', 6)
insert into phieudatphong Values('PD05', 'KH05', '2022-04-29', '2022-05-01', '250000', 'levan@', 'tot', 4)
insert into phieudatphong Values('PD06', 'KH06', '2022-02-15', '2022-02-20', '300000', 'pvtquang@', 'cuc ki tot', 5)
insert into phieudatphong Values('PD07', 'KH07', '2022-03-09', '2022-03-12', '150000', 'thloc@', 'tot', 2)
insert into phieudatphong Values('PD08', 'KH08', '2022-01-07', '2022-01-10', '120000', 'thanha@', 'kem', 1)
insert into phieudatphong Values('PD09', 'KH09', '2021-12-22', '2021-12-29', '300000', 'tbinh@', 'tot', 4)
insert into phieudatphong Values('PD10', 'KH10', '2021-10-19', '2021-10-25', '200000', 'hothanh@', 'binh thuong', 3)
go
Alter table phieuthuephong WITH CHECK ADD FOREIGN KEY(maphieudat) REFERENCES phieudatphong(maphieudat)
go
create table dbo.hoadon(
		mahoadon char(5) PRIMARY KEY,
		ngaythanhtoan date NULL,
		tongtien varchar(30) NULL,
		maphieuthue char(5) NULL,
		makhachang char(5) NULL,
		username varchar(30) NULL
)
go
insert into hoadon Values('HD01','2021-10-14', '300000' , 'PT01', 'KHO1', 'thanha@')
insert into hoadon Values('HD02','2022-04-30','450000' , 'PT02', 'KHO2', 'nguyenha@')
insert into hoadon Values('HD03','2022-01-14', '600000' , 'PT03', 'KHO3', 'vanb@')
insert into hoadon Values('HD04','2022-03-20', '350000' , 'PT04', 'KHO4', 'lenguyen@')
insert into hoadon Values('HD05','2022-05-01', '450000' , 'PT05', 'KHO5', 'levan@')
insert into hoadon Values('HD06','2022-02-20', '700000' , 'PT06', 'KHO6', 'pvtquang@')
insert into hoadon Values('HD07','2022-03-12', '250000' , 'PT07', 'KHO7', 'thloc@')
insert into hoadon Values('HD08','2022-01-10', '650000' , 'PT08', 'KHO8', 'thanha@')
insert into hoadon Values('HD09','2021-12-29', '550000' , 'PT09', 'KHO9', 'tbinh@')
insert into hoadon Values('HD10','2021-10-19', '460000' , 'PT10', 'KH10', 'hothanh@')
go
Alter table hoadon WITH CHECK ADD FOREIGN KEY(maphieuthue) REFERENCES phieuthuephong(maphieuthue)
go
Alter table hoadon WITH CHECK ADD FOREIGN KEY(username) REFERENCES hethong(username)
go
create table dbo.nhanvien(
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
create table dbo.khachhang(
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
Alter table hoadon WITH CHECK ADD FOREIGN KEY(makhachhang) REFERENCES khachhang(makhachhang)
go
Alter table phieudatphong WITH CHECK ADD FOREIGN KEY(makhachhang) REFERENCES khachhang(makhachhang)
go
create table dbo.dichvu(
		madichvu char(5) PRIMARY KEY,
		tendichvu varchar(30) NULL,
		gia char(20) NULL,
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
create table dbo.phong(
		maphong char(5) PRIMARY KEY,
		maloai char(5) NULL,
		dadat char(5) NULL,
		danhan char(5) NULL
)
go
insert into phong Values('P102', 'L01', 'co', 'co')
insert into phong Values('P302', 'L02', 'co', 'khong')
insert into phong Values('P105', 'L03', 'co', 'co')
insert into phong Values('P206', 'L01', 'co', 'co')
insert into phong Values('P405', 'L03', 'co', 'co')
insert into phong Values('P301', 'L02', 'co', 'khong')
insert into phong Values('P406', 'L02', 'khong', 'khong')
insert into phong Values('P401', 'L01', 'co', 'co')
insert into phong Values('P305', 'L03', 'co', 'khong')
insert into phong Values('P202', 'L02', 'co', 'khong')
go
create table dbo.chitietthuephong(
		maphieuthue char(5) references phieuthuephong(maphieuthue),
		maphong char(5) references phong(maphong),
		ngay date ,
		madichvu char(5) references dichvu(madichvu),
		soluong int NULL,
		PRIMARY KEY(maphieuthue, maphong, ngay, madichvu)
)
go
insert into chitietthuephong Values('PT01', 'P102', '2021-10-04', 'DV01', 4)
insert into chitietthuephong Values('PT02', 'P302', '2022-04-20', 'DV02', 3)
insert into chitietthuephong Values('PT03', 'P105', '2022-01-10', 'DV03', 1)
insert into chitietthuephong Values('PT04', 'P206', '2022-03-05', 'DV04', 4)
insert into chitietthuephong Values('PT05', 'P405', '2022-04-29', 'DV05', 3)
insert into chitietthuephong Values('PT06', 'P301', '2022-02-15', 'DV06', 2)
insert into chitietthuephong Values('PT07', 'P406', '2022-03-09', 'DV07', 1)
insert into chitietthuephong Values('PT08', 'P401', '2022-01-07', 'DV08', 3)
insert into chitietthuephong Values('PT09', 'P305', '2021-12-22', 'DV09', 4)
insert into chitietthuephong Values('PT10', 'P202', '2021-10-19', 'DV10', 1)
go
create table dbo.chitietdatphong(
		maphieudat char(5) references phieudatphong(maphieudat),
		maphong char(5) references phong(maphong),
		PRIMARY KEY(maphieudat, maphong)
)
go
insert into chitietdatphong Values('PD01', 'P102')
insert into chitietdatphong Values('PD02', 'P302')
insert into chitietdatphong Values('PD03', 'P105')
insert into chitietdatphong Values('PD04', 'P206')
insert into chitietdatphong Values('PD05', 'P405')
insert into chitietdatphong Values('PD06', 'P301')
insert into chitietdatphong Values('PD07', 'P406')
insert into chitietdatphong Values('PD08', 'P401')
insert into chitietdatphong Values('PD09', 'P305')
insert into chitietdatphong Values('PD10', 'P202')
go
create table dbo.loaiphong(
		maloai char(5) PRIMARY KEY,
		gia char(20) NULL,
		songuoi int NULL
)
go
insert into loaiphong Values('L01', '500000', 4)
insert into loaiphong Values('L02', '250000', 2)
insert into loaiphong Values('L03', '150000', 1)
insert into loaiphong Values('L01', '500000', 4)
insert into loaiphong Values('L03', '150000', 1)
insert into loaiphong Values('L02', '250000', 2)
insert into loaiphong Values('L02', '250000', 2)
insert into loaiphong Values('L01', '500000', 4)
insert into loaiphong Values('L03', '150000', 1)
insert into loaiphong Values('L02', '250000', 2)
go
Alter table phong WITH CHECK ADD FOREIGN KEY(maloai) REFERENCES loaiphong(maloai)
go
create table dbo.trangthaiphong(
		maphong char(5) references Phong(maphong),
		trangthai varchar(10),
		PRIMARY KEY(maphong, trangthai)
)
go
insert into trangthaiphong Values('P102', 'tot')
insert into trangthaiphong Values('P302', 'tot')
insert into trangthaiphong Values('P105', 'tot')
insert into trangthaiphong Values('P206', 'tot')
insert into trangthaiphong Values('P405', 'tot')
insert into trangthaiphong Values('P301', 'tot')
insert into trangthaiphong Values('P406', 'tot')
insert into trangthaiphong Values('P401', 'tot')
insert into trangthaiphong Values('P305', 'tot')
insert into trangthaiphong Values('P202', 'tot')
go
create table dbo.vattu(
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
create table dbo.chitietvattu(
		mavattu char(5), 
		maloaiphong char(5) references loaiphong(maloai),
		soluong int NULL,
		PRIMARY KEY (mavattu, maloaiphong)
)
go
insert into chitietvattu Values('VT01', 'L01', 4)
insert into chitietvattu Values('VT02', 'L02', 2)
insert into chitietvattu Values('VT03', 'L03', 3)
insert into chitietvattu Values('VT04', 'L01', 7)
insert into chitietvattu Values('VT05', 'L03', 5)
insert into chitietvattu Values('VT06', 'L02', 4)
insert into chitietvattu Values('VT07', 'L02', 6)
insert into chitietvattu Values('VT08', 'L01', 1)
insert into chitietvattu Values('VT09', 'L03', 2)
insert into chitietvattu Values('VT10', 'L02', 3)
go
Alter table chitietvattu WITH CHECK ADD FOREIGN KEY(maloaiphong) REFERENCES loaiphong(maloai)
go
