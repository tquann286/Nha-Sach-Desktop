create database BatOnBookStore
go
use BatOnBookStore
go
CREATE TABLE DangNhap (
    TaiKhoan nvarchar(50) primary key not null,
    MatKhau nvarchar(50) not null
);

CREATE TABLE KhachHang (
    MaKH nvarchar(50) primary key not null,
    HoTen nvarchar(100) not null,
    Sdt nvarchar(50) not null,
    DiaChi nvarchar(50) not null,
    Email nvarchar(50) not null
);

CREATE TABLE Sach (
    MaSach nvarchar(50) primary key not null,
    TenSach nvarchar(100) not null,
    TheLoai nvarchar(50) not null,
    TacGia nvarchar(50) not null,
    DonGia int not null,
    TonDau int,
    TongNhap int,
    TongBan int not null,
    TonCuoi int
);

CREATE TABLE NhanVien(
    Email nvarchar(50) primary key not null,
    HoTen nvarchar(50) not null,
    DiaChi nvarchar(50) not null,
    Sdt nvarchar(50) not null,
    Password nvarchar(50) not null
);

CREATE TABLE PhieuBan (
    MaPhieuBan nvarchar(50) not null,
    MaSach nvarchar(50) not null,
    SoLuong int not null
	primary key (MaPhieuBan, MaSach)
);

CREATE TABLE PhieuNhap (
    MaPhieuNhap nvarchar(50) not null,
    MaSach nvarchar(50) not null,
    SoLuong int,
    DonGia int,
    TongTien int,   
	primary key(MaPhieuNhap, MaSach)
);

CREATE TABLE HoaDon (
    MaHD nvarchar(50) primary key not null,
    MaKH nvarchar(50) not null,
    TenKH nvarchar(100) not null,
    MaSach nvarchar(50) not null,
    TenSach nvarchar(100) not null,
    NgayLap datetime not null,
    SoLuong int,
    TongTien int
);
go
alter table PhieuNhap
add constraint fk_phieunhap_sach foreign key (MaSach) references Sach(MaSach)

alter table HoaDon
add constraint fk_hoadon_KhachHang foreign key (MaKH) references KhachHang(MaKH)

alter table HoaDon
add constraint fk_hoadon_sach foreign key (MaSach) references Sach(MaSach)

alter table PhieuBan
add constraint fk_phieuban_sach foreign key (MaSach) references Sach(MaSach)

alter table PhieuBan
add constraint fk_phieuban_hoadon foreign key (MaPhieuBan) references HoaDon(MaHD)

alter table PhieuNhap
add constraint fk_email_phieunhap foreign key (Email) references NhanVien(Email)
go
---DANG NHAP
INSERT INTO DangNhap (TaiKhoan, MatKhau)
VALUES ('hphat456', '1234');

INSERT INTO DangNhap (TaiKhoan, MatKhau)
VALUES ('hphuoc789', '1234');

INSERT INTO DangNhap (TaiKhoan, MatKhau)
VALUES ('mtan141', '1234');

INSERT INTO DangNhap (TaiKhoan, MatKhau)
VALUES ('nhuy553', '1234');

INSERT INTO DangNhap (TaiKhoan, MatKhau)
VALUES ('tquan123', '1234');


---KHACH HANG
INSERT INTO KhachHang (MaKH, HoTen, Sdt, DiaChi, Email)
VALUES ('KH01', 'Dinh Thi My', '06281926738', 'TPHCM', 'mmy992@gmail.com');

INSERT INTO KhachHang (MaKH, HoTen, Sdt, DiaChi, Email)
VALUES ('KH02', 'Tran Ngoc Trang', '07281723721', 'Vung Tau', 'ntrang012@gmail.com');

INSERT INTO KhachHang (MaKH, HoTen, Sdt, DiaChi, Email)
VALUES ('KH03', 'Nguyen Van Tai', '07298123123', 'Da Nang', 'taing233@gmail.com');

INSERT INTO KhachHang (MaKH, HoTen, Sdt, DiaChi, Email)
VALUES ('KH04', 'Dao Vu Luan', '02213481231', 'Vinh Long', 'lluan962@gmail.com');

INSERT INTO KhachHang (MaKH, HoTen, Sdt, DiaChi, Email)
VALUES ('KH05', 'Vu Hoang Kiet', '03748347344', 'TPHCM', 'kiethg483@gmail.com');


---Sach
INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S01', 'Tuoi tre dang gia bao nhieu', 'Tu truyen', 'Rosie Nguyen', 99000, 0, 200, 6, 194);

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S02', 'Cay cam ngot cua toi', 'Tieu thuyet', 'Jose Mauro De Vasconcelos', 120000, 0, 200, 10, 190);

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S03', 'Nha gia kim', 'Ki su', 'Paulo Coelho', 80000, 0, 100, 4, 96);

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S04', 'Doi thay doi khi chung ta thay doi', 'Xa hoi', 'Andrew Matthews', 150000, 0, 300, 12, 288);

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S05', 'Dac nhan tam', 'Self-help', 'Dale Carnegie', 200000, 0, 250, 7, 243);

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S06', 'Cho toi mot ve di tuoi tho', 'Truyen ngan', 'Nguyen Nhat Anh', 180000, 0, 300, 6, 294);

---NHAN VIEN
INSERT INTO NhanVien (Email, HoTen, DiaChi, Sdt, Password)
VALUES ('huyn@gmail.com', 'Truong Nhut Huy', 'Long An', '01286445314', 'nhuthuy02');

INSERT INTO NhanVien (Email, HoTen, DiaChi, Sdt, Password)
VALUES ('phath@gmail.com', 'Huynh Phuong Thanh Phat', 'TPHCM', '03424233411', 'phathuynh01');

---HOA DON
INSERT INTO HoaDon
VALUES ('HD01', 'KH01', 'Dinh Thi My', 'S01', 'Tuoi tre dang gia bao nhieu', '10-05-2023', 2, 180000);

INSERT INTO HoaDon
VALUES ('HD02', 'KH02', 'Tran Ngoc Trang', 'S02', 'Cay cam ngot cua toi', '10-05-2023', 3, 350000);

INSERT INTO HoaDon
VALUES ('HD03', 'KH04', 'Dao Vu Luan', 'S03', 'Nha gia kim', '11-05-2023', 4, 260000);


---PHIEU BAN
INSERT INTO PhieuBan (MaPhieuBan, MaSach, SoLuong)
VALUES ('HD01', 'S06', 1);

INSERT INTO PhieuBan (MaPhieuBan, MaSach, SoLuong)
VALUES ('HD02', 'S04', 1);

INSERT INTO PhieuBan (MaPhieuBan, MaSach, SoLuong)
VALUES ('HD02', 'S05', 1);

INSERT INTO PhieuBan (MaPhieuBan, MaSach, SoLuong)
VALUES ('HD03', 'S03', 2);

---PHIEU NHAP
INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien)
VALUES ('PN1', 'S01', 200, 99000, 19800000);

INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien)
VALUES ('PN1', 'S02', 200, 120000, 24000000);

INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien)
VALUES ('PN2', 'S03', 100, 80000, 8000000);
INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien)
VALUES ('PN2', 'S04', 200, 120000, 24000000);

INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien, Email)
VALUES ('PN2', 'S06', 5, 180000, 900000, 'huyn@gmail.com');
