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
alter table PhieuNhap with check add constraint fk_phieunhap_sach foreign key (MaSach) 
references Sach(MaSach)
ON UPDATE CASCADE
ON DELETE CASCADE

alter table HoaDon
add constraint fk_hoadon_KhachHang foreign key (MaKH) references KhachHang(MaKH)

alter table HoaDon
add constraint fk_hoadon_sach foreign key (MaSach) references Sach(MaSach)

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
VALUES ('S01', 'Tuoi tre dang gia bao nhieu', 'Tu truyen', 'Rosie Nguyen', 99000, 0, 300, 5, 295);

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S02', 'Cay cam ngot cua toi', 'Tieu thuyet', 'Jose Mauro De Vasconcelos', 120000, 0, 200, 10, 190);

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S03', 'Nha gia kim', 'Ki su', 'Paulo Coelho', 80000, 0, 100, 4, 96);

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S04', 'Doi thay doi khi chung ta thay doi', 'Xa hoi', 'Andrew Matthews', 150000, 0, 200, 12, 188);

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S05', 'Dac nhan tam', 'Self-help', 'Dale Carnegie', 200000, 0, 150, 15, 135);

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, DonGia, TonDau, TongNhap, TongBan, TonCuoi)
VALUES ('S06', 'Cho toi mot ve di tuoi tho', 'Truyen ngan', 'Nguyen Nhat Anh', 180000, 0, 160, 6, 154);

---PHIEU NHAP
INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien)
VALUES ('PN1', 'S01', 300, 99000, 29700000);

INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien)
VALUES ('PN1', 'S02', 200, 120000, 24000000);

INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien)
VALUES ('PN2', 'S03', 100, 80000, 8000000);

INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien)
VALUES ('PN2', 'S04', 200, 150000, 30000000);

INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien)
VALUES ('PN3', 'S05', 150, 200000, 30000000);

INSERT INTO PhieuNhap (MaPhieuNhap, MaSach, SoLuong, DonGia, TongTien)
VALUES ('PN4', 'S06', 160, 180000, 28800000);



---NHAN VIEN
INSERT INTO NhanVien (Email, HoTen, DiaChi, Sdt, Password)
VALUES ('huyn@gmail.com', 'Truong Nhut Huy', 'Long An', '01286445314', 'nhuthuy02');

INSERT INTO NhanVien (Email, HoTen, DiaChi, Sdt, Password)
VALUES ('phath@gmail.com', 'Huynh Phuong Thanh Phat', 'TPHCM', '03424233411', 'phathuynh01');

---HOA DON
INSERT INTO HoaDon
VALUES ('HD01', 'KH01', 'Dinh Thi My', 'S01', 'Tuoi tre dang gia bao nhieu', '10-05-2023', 2, 198000);

INSERT INTO HoaDon
VALUES ('HD02', 'KH02', 'Tran Ngoc Trang', 'S02', 'Cay cam ngot cua toi', '10-05-2023', 3, 360000);

INSERT INTO HoaDon
VALUES ('HD03', 'KH04', 'Dao Vu Luan', 'S03', 'Nha gia kim', '11-05-2023', 4, 320000);


