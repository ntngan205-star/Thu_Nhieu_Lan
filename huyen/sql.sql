select SanPham.MaSP,SanPham.TenSP,SanPham.DonGia, SUM(Kho.SoLuongNhap)-SUM(Kho.SoLuongXuat) as TonKho from SanPham inner join Kho on SanPham.MaSP=Kho.MaSP Group by SanPham.MaSP,SanPham.TenSP,SanPham.DonGia
select SanPham.MaSP,SanPham.TenSP,SanPham.DonGia,DanhMuc.TenDM SUM(Kho.SoLuongNhap)-SUM(Kho.SoLuongXuat) as TonKho from SanPham
inner join Kho on SanPham.MaDM=DanhMuc.MaDM 
inner join Kho on SanPham.MaSP=Kho.MaSP 
Group by SanPham.MaSP,SanPham.TenSP,SanPham.DonGia,DanhMuc.TenDM