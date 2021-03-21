create database DoAnNet
use DoAnNet
create table LoaiSanPham(
	MaLoai int identity primary key,
	TenLoai nvarchar(50),
	ThuongHieu nvarchar(50)
) 
go
create table SanPham(
	MaLoai int,
	MaSp  int identity primary key,
	TenSanPham nvarchar(50),
	SoLuong int,
	MoTa nvarchar(50),
	GiaNhap float,
	GiaBan float,
	HinhAnh nvarchar(90),
	foreign key (MaLoai) references LoaiSanPham(MaLoai)
)
go
create table CTSanPham(
	MaSp int ,
	MaCTSp int identity primary key,
	KichCo float ,
	MaSac nvarchar(50),
	ChatLieu nvarchar(50),
	SoLuong int 
	foreign key (MaSp) references SanPham(MaSp)
)
go
create table KhachHang(
	MaKH int identity primary key,
	TenKH nvarchar(50),
	SoDienThoai float,
	DiaChi nvarchar(50)
)
go
create table DonHang(
	MaDonHang int identity primary key,
	MaKH int,
	NgayMua date ,
	SoLuong int ,
	TongTien float,
	foreign key (MaKH) references KhachHang(MaKH),
)
go
create table CTDonHang(
	MaDonHang int ,
	MaCTDonHang int identity primary key,
	MaCTSp int,
	SoLuong int, 
	GiaTien float,
	TongTien float,
	foreign key (MaCTSp) references CTSanPham(MaCTSp),
	foreign key (MaDonHang) references DonHang(MaDonHang),
)
go
create table NhaCungCap(
	MaNcc int identity primary key,
	TenNcc nvarchar(50),
	DiaChi nvarchar(50),
	SoDienThoai nvarchar(50)	
)
go
create table PhieuNhap(
	MaPhieuNhap int identity primary key,
	MaNcc int,
	SoLuong int,
	TongTien float,
	NgayNhap date,
	foreign key (MaNcc) references NhaCungCap(MaNcc),
)
go
create table CTPhieuNhap(
	MaPhieuNhap int ,
	MaCTPhieuNhap int identity primary key,
	MaCTSp int,
	SoLuong int,
	GiaNhap float,
	foreign key (MaCTSp) references CTSanPham(MaCTSp),
	foreign key (MaPhieuNhap) references PhieuNhap(MaPhieuNhap),
)
go
create table ChucVu(
	MaChucVu int identity primary key,
	TenChucVu nvarchar(50),
)
go
create table NhanVien(
	MaNV int identity primary key,
	TenNV nvarchar(50),
	SDT float,
	DiaChi nvarchar(50),
	NgaySinh date,
	HinhAnh nvarchar(50),
	MaChucVu int,
	foreign key (MaChucVu) references ChucVu(MaChucVu),
)
go
create table TaiKhoan(
	TaiKhoan nvarchar(50) primary key,
	MatKhau nvarchar(50) ,
	MaNV int,
	foreign key (MaNV) references NhanVien(MaNV)
)
go
create table ChamCong(
	MaNV int,
	NgayCham date, 
	Cham bit,
	constraint khoa_chinh primary key(MaNV,Cham),
	foreign key(MaNV) references NhanVien(MaNV)
)
go

 create table PhieuXuat(
	MaPhieuXuat int identity primary key,
	MaDonHang int,
	NgayXuat date 
	foreign key(MaDonHang) references DonHang(MaDonHang)
 )
go

                                                     -----viết trigger----- 


					---------------------trigger cập nhật tổng tiền tại bảng ct đơn hàng-----------------------------------
create trigger tongtien on CTDonHang 
for insert, update
as
begin 
	update CTDonHang 
	set TongTien = GiaTien * SoLuong
end
drop trigger tongtien

				------------------------trigger cập nhật tổng tiền tại bảng ct phiếu nhập---------------------------------
create trigger tong_tien_nhap on CTPhieuNhap
for insert, update
as
begin 
	update CTPhieuNhap 
	set TongTien = GiaNhap * SoLuong
end
drop trigger tong_tien_nhap



					-------------------------trigger cập nhật tổng tiền cho bảng phiếu nhập-------------------------------------
create trigger cap_nhat_tong_tien on CTPhieuNhap
for insert, update
as
begin 
	update PhieuNhap 
	set TongTien = (select sum(CTPhieuNhap.TongTien) 
					from CTPhieuNhap
					where CTPhieuNhap.MaPhieuNhap = PhieuNhap.MaPhieuNhap)
end
drop trigger cap_nhat_tong_tien
			-------------------------trigger cập nhật so luong  cho bảng phiếu nhập-------------------------------------
create trigger cap_nhat_so_luong_phieu_nhap on CTPhieuNhap
for insert, update
as
begin 
	update PhieuNhap 
	set SoLuong = (select sum(CTPhieuNhap.SoLuong) 
					from CTPhieuNhap
					where CTPhieuNhap.MaPhieuNhap = PhieuNhap.MaPhieuNhap)
end
drop trigger cap_nhat_so_luong_phieu_nhap

				-------------------------trigger cập nhật số lượng sản phẩm tại bảng đơn hàng---------------------------------
create trigger cap_nhat_so_luong on CTDonHang
for insert, update,delete
as
begin 
	update DonHang
	set SoLuong = (select sum(inserted.SoLuong) 
					from  inserted 
					where inserted.MaDonHang = DonHang.MaDonHang )
end
drop trigger cap_nhat_so_luong


					-----------------------------------Viết trigger cập nhật tổng tiền cho bảng đơn hàng--------------------------------------------
create trigger cap_nhat_so_luong_spdonhang on CTDonHang
for insert, update,delete
as
begin 
	update DonHang
	set TongTien = (select sum(CTDonHang.TongTien) 
					from CTDonHang
					where CTDonHang.MaDonHang = DonHang.MaDonHang )
end
drop trigger cap_nhat_so_luong_spdonhang



						-------------------------trigger cập nhật bảng số lượng sản phẩm tại bảng sản phẩm theo bảng chi tiết sản phẩm----------------------------------
create trigger cap_nhat_so_luong_sanpham on CTSanPham
for insert, update,delete
as
begin 
	update SanPham
	set SoLuong = (select sum(CTSanPham.SoLuong) 
					from CTSanPham 
					where  CTSanPham.MaSp = SanPham.MaSp)
					
end
drop trigger cap_nhat_so_luong_sanpham



					-------------------------trigger cập nhật số lượng sản phẩm tại bảng ct sản phẩm theo bảng xuất------------------------------------
create trigger cap_nhat_so_luong_ctsanpham on CTDonHang
for insert,update
as
begin 
	update CTSanPham
	set SoLuong = SoLuong - (select sum(CTDonHang.SoLuong) 
					from CTDonHang
					where CTDonHang.MaCTSp = CTSanPham.MaCTSp)
end
drop trigger cap_nhat_so_luong_ctsanpham


				------------------------trigger cập nhật số lượng sản phẩm tại bảng ct sản phẩm theo bảng nhập---------------------------------------
create trigger so_luong_ctsanpham on CTPhieuNhap
for insert
as
begin 
	update CTSanPham
	set SoLuong = SoLuong + (select sum(CTPhieuNhap.SoLuong) 
					from CTPhieuNhap
					where CTPhieuNhap.MaCTSp = CTSanPham.MaCTSp)
end
drop trigger so_luong_ctsanpham


					-----------------------------trigger cập nhật số lượng sản phẩm tại bảng sản phẩm theo bảng nhập (BỎ) ---------------------------------------
--create trigger so_luong_sanpham on CTPhieuNhap
--for insert, update,delete
--as
--begin 
--	update SanPham
--	set SoLuong = (select sum(CTPhieuNhap.SoLuong) 
--					from CTPhieuNhap,CTSanPham 
--					where CTPhieuNhap.MaCTSp = CTSanPham.MaCTSp and CTSanPham.MaSp = SanPham.MaSp)
--end
--drop trigger so_luong_sanpham


						----------------------------trigger cập nhật ngày bán của bảng đơn hàng ------------------------------------------------
create trigger ngay_ban on DonHang
for insert,update,delete
as
begin 
	update DonHang
	set NgayMua = getdate()
	WHERE MaDonHang =  (select top(1) DonHang.MaDonHang from DonHang order by DonHang.MaDonHang DESC )
end
drop trigger ngay_ban

							--------------------------Viết trigger cập nhật Lương cho từng nhân viên(không làm chức năng này)-------------------------------------

create trigger cap_nhat_luong on NhanVien
for insert,update 
as 
begin 
	update NhanVien
	set Luong = TongNgayCong * (select MucLuong from ChucVu, inserted where ChucVu.MaChucVu = inserted.MaChucVu); 
end
drop trigger cap_nhat_luong

						-------------------------- viết trigger cập nhật số lượng ngày công của bảng nhân viên lấy dữ liệu từ bảng chấm công(không làm chức năng này) --------------------------------

create trigger cap_nhat_tong_ngay_cong on ChamCong
for insert,update 
as
begin 
	update NhanVien
	set TongNgayCong = (select COUNT(ChamCong.Cham) from ChamCong where NhanVien.MaNV = ChamCong.MaNV)
end 
drop trigger cap_nhat_tong_ngay_cong

				----------------------Viết trigger tự động cập nhật gia nhập cho bảng nhập  -------------------------------------------
create trigger cap_nhat_gia_nhap on CTPhieuNhap
for insert,update,delete
as
begin 
	IF TRIGGER_NESTLEVEL() > 1
     RETURN
	 update CTSanPham
	 set GiaNhap = (select CTPhieuNhap.GiaNhap ,CTSanPham.MaCTSp
					from CTPhieuNhap,CTSanPham
					where CTPhieuNhap.MaCTSp = CTSanPham.MaCTSp 
					group by CTPhieuNhap.GiaNhap ,CTSanPham.MaCTSp
					 )
					
end
drop trigger cap_nhat_gia_nhap
				----------------------Viết trigger tự động cập nhật giá tiền cho bảng chi tiết hóa đơn -------------------------------------------
create trigger cap_nhat_tien_bang_hoa_don on CTDonHang
for insert,update,delete
as 
begin
	IF TRIGGER_NESTLEVEL() > 1
     RETURN
	update CTDonHang 
	set GiaTien = (select CTSanPham.GiaBan 
					from CTSanPham
					where  CTSanPham.MaCTSp = CTDonHang.MaCTSp )
					
end
drop trigger cap_nhat_tien_bang_hoa_don

				----------------------Viết trigger tự động cập nhật ngày nhập cho bảng lô hàng -------------------------------------------

				----------------------Viết trigger tự động cập nhật số lượng loại sản phầm theo bảng sản phẩm-------------------------------------------
Create trigger cap_nhat_so_luong_loai_san_pham on SanPham
for insert,update,delete 
as
begin 
	update LoaiSanPham
	set SoLuong = (select sum(SanPham.SoLuong) from SanPham where SanPham.MaLoai = LoaiSanPham.MaLoai)
end
drop trigger cap_nhat_so_luong_loai_san_pham

						-------------------------------tạo rule cập nhật ngày sinh lớn hơn 1-1-1990-----------------------------------------------
CREATE RULE ngay AS @ngay>'1990-1-1'
sp_bindrule ngay,'NhanVien.NgaySinh'




				--------------------Viết procduce cho phần thống kê vì không biết viết trigger(T_T)------------------------------
							------------------------------Viết procdure cập nhật tháng-------------------------------
create procedure capnhat_thang
as
begin 
	update ThongKe 
	SET Thang = MONTH(getdate())
end
drop proc capnhat_thang
capnhat_thang
							-----------------Viết procdure cập nhật số lượng sản phẩm đã nhập trong tháng-------------
create procedure thongke_sanpham_nhap
as
begin 
	update ThongKe 
	SET SoLuongNhap = (select sum(SoLuong) from PhieuNhap WHERE MONTH(PhieuNhap.NgayNhap)=Thang)
end
drop proc thongke_sanpham_nhap
thongke_sanpham_nhap

							-----------------Viết procdure cập nhật số lượng sản phẩm đã bán trong tháng--------------
create procedure capnhat_soluong_ban
as
begin 
	update ThongKe
	set SoLuongXuat = (SELECT SUM(SoLuong) from DonHang where MONTH(DonHang.NgayMua) = thang)
end
drop proc capnhat_soluong_ban
capnhat_soluong_ban
							-----------------Viết procdure cập nhật Tổng doanh thu đã bán trong tháng-----------------
create procedure capnhat_tong_doanhthu
as
begin
	update ThongKe
	set DoanhThu = TongXuat - TongNhap
end
drop proc capnhat_tong_doanhthu
capnhat_tong_doanhthu
							-----------------Viết procdure cập nhật Tổng doanh thu đã nhập trong tháng----------------
create procedure thongke_doanhthu_nhap
as
begin 
	update ThongKe 
	SET TongNhap = (select sum(TongTien) from PhieuNhap WHERE MONTH(PhieuNhap.NgayNhap) = Thang)
end
drop proc thongke_doanhthu_nhap
thongke_doanhthu_nhap
							-----------------Viết procdure cập nhật doanh thu bán trong tháng---------------------
create procedure capnhat_doanhthu_ban
as
begin 
	update ThongKe
	set TongXuat = (SELECT SUM(TongTien) from DonHang where MONTH(DonHang.NgayMua) = thang)
end
drop proc capnhat_doanhthu_ban
capnhat_doanhthu_ban
							-----------------Viết procdure cập nhật sản phẩm bán chạy trong tháng---------------------
create proc capnhat_sanpham_banchay
as
begin 
	update ThongKe
	set SanPhamBanChay = (select top(1) SanPham.TenSanPham 
						 from SanPham,CTSanPham,CTDonHang,DonHang
						  where SanPham.MaSp = CTSanPham.MaCTSp and
								CTDonHang.MaCTSp = CTSanPham.MaCTSp and
								DonHang.MaDonHang = CTDonHang.MaDonHang and
								MONTH(DonHang.NgayMua) = Thang
						  group by SanPham.TenSanPham 
						  having count(CTDonHang.MaCTSp)>=  all(select count(CTDonHang.MaCTSp) from CTDonHang,CTSanPham
																								where CTDonHang.MaCTSp =  CTSanPham.MaCTSp
																								group by CTDonHang.MaCTSp)
						  )
end
drop proc capnhat_sanpham_banchay
capnhat_sanpham_banchay
							-----------------Viết procdure cập nhật sản phẩm bán kém trong tháng----------------------
create proc capnhat_sanpham_bancham
as
begin 
	update ThongKe
	set SanPhamTon = (select top(1) SanPham.TenSanPham 
						  from SanPham,CTSanPham,CTDonHang,DonHang
						  where SanPham.MaSp = CTSanPham.MaCTSp and
								CTDonHang.MaCTSp = CTSanPham.MaCTSp and
								DonHang.MaDonHang = CTDonHang.MaDonHang and
								MONTH(DonHang.NgayMua) = Thang
						  group by SanPham.TenSanPham 
						  having count(CTDonHang.MaCTSp) <=  all(select count(CTDonHang.MaCTSp) from CTDonHang,CTSanPham
																								where CTDonHang.MaCTSp =  CTSanPham.MaCTSp
																								group by CTDonHang.MaCTSp)
						  )
end
drop proc capnhat_sanpham_bancham
capnhat_sanpham_bancham
							-----------------Viết procdure cập nhật tổng đơn hàng trong tháng-------------------------

create proc tong_hoadon
as
begin
	update ThongKe
	set SoLuongDonHang = (select COUNT(*) from DonHang WHERE MONTH(DonHang.NgayMua) = thang)
end
tong_hoadon
drop proc tong_hoadon




						-------------------------------Code phần sửa và cập nhật 1 số bảng--------------------------------------------------------






-- Sửa cho bảng chi tiết phiếu nhập -- 
ALTER TABLE CTPhieuNhap  
	ADD TongTien float
-- Sửa cho bảng nhân viên --
alter table NhanVien
	ADD TinhTrang bit 

alter table NhanVien 
	ADD MucLuong float

alter table NhanVien 
	ADD TongNgayCong int

alter table NhanVien
	ADD Luong float

alter table SanPham
	drop column MaLoHang

drop table KhoHang

alter table LoaiSanPham 
	add MaLoHang int 
	foreign key(MaLoHang) references KhoHang(MaLoHang)

alter table LoaiSanPham 
	add SoLuong int 

alter table PhieuNhap
	add MaLoai int 
	foreign key(MaLoai) references LoaiSanPham(MaLoai)
ALTER TABLE PhieuNhap
DROP CONSTRAINT MaLoai;

alter table sanpham 
	add TinhTrang bit
alter table LoaiSanPham
	add TinhTrang bit
ALTER TABLE SanPham MODIFY COLUMN MoTa nvarchar(MAX)