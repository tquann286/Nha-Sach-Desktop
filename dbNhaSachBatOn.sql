create database BatOnBookStore
use BatOnBookStore

CREATE TABLE DANGNHAP (
    taikhoan nvarchar(50) primary key not null,
    matkhau nvarchar(50) not null
);

CREATE TABLE KHACHHANG (
    makh nvarchar(50) primary key not null,
    hoten nvarchar(100) not null,
    sdt nvarchar(50) not null,
    diachi nvarchar(50) not null,
    email nvarchar(50) not null
);

CREATE TABLE SACH (
    masach nvarchar(50) primary key not null,
    tensach nvarchar(100) not null,
    theloai nvarchar(50) not null,
    tacgia nvarchar(50) not null,
    dongia int not null,
    tondau int,
    tongnhap int,
    tongban int not null,
    toncuoi int
);

CREATE TABLE NHANVIEN(
    email nvarchar(50) primary key not null,
    hoten nvarchar(50) not null,
    diachi nvarchar(50) not null,
    sdt nvarchar(50) not null,
    password nvarchar(50) not null
);

CREATE TABLE PHIEUBAN (
    maphieuban nvarchar(50) not null,
    masach nvarchar(50) not null,
    soluong int not null
	primary key (maphieuban, masach)
);

CREATE TABLE PHIEUNHAP (
    maphieunhap nvarchar(50) not null,
    masach nvarchar(50) not null,
    soluong int,
    dongia int,
    tongtien int
	primary key(maphieunhap, masach)
);

CREATE TABLE HOADON (
    mahd nvarchar(50) primary key not null,
    makh nvarchar(50) not null,
    tenkh nvarchar(50),
    ngaylap datetime,
    tongtien int
);

alter table PHIEUNHAP
add constraint fk_phieunhap_sach foreign key (masach) references SACH(masach)

alter table HOADON
add constraint fk_hoadon_khachhang foreign key (makh) references KHACHHANG(makh)


alter table PHIEUBAN
add constraint fk_phieuban_sach foreign key (masach) references SACH(masach)

alter table PHIEUBAN
add constraint fk_phieuban_hoadon foreign key (maphieuban) references HOADON(mahd)


---DANG NHAP
INSERT INTO DANGNHAP (taikhoan, matkhau)
VALUES ('hphat456', '1234');

INSERT INTO DANGNHAP (taikhoan, matkhau)
VALUES ('hphuoc789', '1234');

INSERT INTO DANGNHAP (taikhoan, matkhau)
VALUES ('mtan141', '1234');

INSERT INTO DANGNHAP (taikhoan, matkhau)
VALUES ('nhuy553', '1234');

INSERT INTO DANGNHAP (taikhoan, matkhau)
VALUES ('tquan123', '1234');


---KHACH HANG
INSERT INTO KHACHHANG (makh, hoten, sdt, diachi, email)
VALUES ('KH01', 'Dinh Thi My', '06281926738', 'TPHCM', 'mmy992@gmail.com');

INSERT INTO KHACHHANG (makh, hoten, sdt, diachi, email)
VALUES ('KH02', 'Tran Ngoc Trang', '07281723721', 'Vung Tau', 'ntrang012@gmail.com');

INSERT INTO KHACHHANG (makh, hoten, sdt, diachi, email)
VALUES ('KH03', 'Nguyen Van Tai', '07298123123', 'Da Nang', 'taing233@gmail.com');

INSERT INTO KHACHHANG (makh, hoten, sdt, diachi, email)
VALUES ('KH04', 'Dao Vu Luan', '02213481231', 'Vinh Long', 'lluan962@gmail.com');

INSERT INTO KHACHHANG (makh, hoten, sdt, diachi, email)
VALUES ('KH05', 'Vu Hoang Kiet', '03748347344', 'TPHCM', 'kiethg483@gmail.com');


---SACH
INSERT INTO SACH (masach, tensach, theloai, tacgia, dongia, tondau, tongnhap, tongban, toncuoi)
VALUES ('S01', 'Tuoi tre dang gia bao nhieu', 'Tu truyen', 'Rosie Nguyen', 99000, 15, 30, 6, 39);

INSERT INTO SACH (masach, tensach, theloai, tacgia, dongia, tondau, tongnhap, tongban, toncuoi)
VALUES ('S02', 'Cay cam ngot cua toi', 'Tieu thuyet', 'Jose Mauro De Vasconcelos', 120000, 3, 20, 10, 13);

INSERT INTO SACH (masach, tensach, theloai, tacgia, dongia, tondau, tongnhap, tongban, toncuoi)
VALUES ('S03', 'Nha gia kim', 'Ki su', 'Paulo Coelho', 80000, 5, 10, 4, 11);

INSERT INTO SACH (masach, tensach, theloai, tacgia, dongia, tondau, tongnhap, tongban, toncuoi)
VALUES ('S04', 'Doi thay doi khi chung ta thay doi', 'Xa hoi', 'Andrew Matthews', 150000, 7, 20, 12, 15);

INSERT INTO SACH (masach, tensach, theloai, tacgia, dongia, tondau, tongnhap, tongban, toncuoi)
VALUES ('S05', 'Dac nhan tam', 'Self-help', 'Dale Carnegie', 200000, 2, 15, 7, 10);

INSERT INTO SACH (masach, tensach, theloai, tacgia, dongia, tondau, tongnhap, tongban, toncuoi)
VALUES ('S06', 'Cho toi mot ve di tuoi tho', 'Truyen ngan', 'Nguyen Nhat Anh', 180000, 5, 16, 6, 15);

---NHAN VIEN
INSERT INTO NHANVIEN (email, hoten, diachi, sdt, password)
VALUES ('huyn@gmail.com', 'Truong Nhut Huy', 'Long An', '01286445314', 'nhuthuy02');

INSERT INTO NHANVIEN (email, hoten, diachi, sdt, password)
VALUES ('phath@gmail.com', 'Huynh Phuong Thanh Phat', 'TPHCM', '03424233411', 'phathuynh01');

---HOA DON
INSERT INTO HOADON (mahd, makh, tenkh, ngaylap, tongtien)
VALUES ('HD01', 'KH01', 'Dinh Thi My', '10-05-2023', 180000);

INSERT INTO HOADON (mahd, makh, tenkh, ngaylap, tongtien)
VALUES ('HD02', 'KH02', 'Tran Ngoc Trang', '10-05-2023', 350000);

INSERT INTO HOADON (mahd, makh, tenkh, ngaylap, tongtien)
VALUES ('HD03', 'KH04', 'Dao Vu Luan', '11-05-2023', 260000);


---PHIEU BAN
INSERT INTO PHIEUBAN (maphieuban, masach, soluong)
VALUES ('HD01', 'S06', 1);

INSERT INTO PHIEUBAN (maphieuban, masach, soluong)
VALUES ('HD02', 'S04', 1);

INSERT INTO PHIEUBAN (maphieuban, masach, soluong)
VALUES ('HD02', 'S05', 1);

INSERT INTO PHIEUBAN (maphieuban, masach, soluong)
VALUES ('HD03', 'S03', 2);

---PHIEU NHAP
INSERT INTO PHIEUNHAP (maphieunhap, masach, soluong, dongia, tongtien)
VALUES ('PN1', 'S01', 5, 99000, 495000);

INSERT INTO PHIEUNHAP (maphieunhap, masach, soluong, dongia, tongtien)
VALUES ('PN2', 'S06', 5, 180000, 900000);
