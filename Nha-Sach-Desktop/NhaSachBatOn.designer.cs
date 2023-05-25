﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nha_Sach_Desktop
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BatOnBookStore")]
	public partial class NhaSachBatOnDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDangNhap(DangNhap instance);
    partial void UpdateDangNhap(DangNhap instance);
    partial void DeleteDangNhap(DangNhap instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertPhieuBan(PhieuBan instance);
    partial void UpdatePhieuBan(PhieuBan instance);
    partial void DeletePhieuBan(PhieuBan instance);
    partial void InsertPhieuNhap(PhieuNhap instance);
    partial void UpdatePhieuNhap(PhieuNhap instance);
    partial void DeletePhieuNhap(PhieuNhap instance);
    partial void InsertSach(Sach instance);
    partial void UpdateSach(Sach instance);
    partial void DeleteSach(Sach instance);
    #endregion
		
		public NhaSachBatOnDataContext() : 
				base(global::Nha_Sach_Desktop.Properties.Settings.Default.BatOnBookStoreConnectionString5, mappingSource)
		{
			OnCreated();
		}
		
		public NhaSachBatOnDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NhaSachBatOnDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NhaSachBatOnDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NhaSachBatOnDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DangNhap> DangNhaps
		{
			get
			{
				return this.GetTable<DangNhap>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<PhieuBan> PhieuBans
		{
			get
			{
				return this.GetTable<PhieuBan>();
			}
		}
		
		public System.Data.Linq.Table<PhieuNhap> PhieuNhaps
		{
			get
			{
				return this.GetTable<PhieuNhap>();
			}
		}
		
		public System.Data.Linq.Table<Sach> Saches
		{
			get
			{
				return this.GetTable<Sach>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangNhap")]
	public partial class DangNhap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TaiKhoan;
		
		private string _MatKhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public DangNhap()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHD;
		
		private string _MaKH;
		
		private string _TenKH;
		
		private string _MaSach;
		
		private string _TenSach;
		
		private System.DateTime _NgayLap;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<int> _TongTien;
		
		private EntitySet<PhieuBan> _PhieuBans;
		
		private EntityRef<KhachHang> _KhachHang;
		
		private EntityRef<Sach> _Sach;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(string value);
    partial void OnMaHDChanged();
    partial void OnMaKHChanging(string value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnMaSachChanging(string value);
    partial void OnMaSachChanged();
    partial void OnTenSachChanging(string value);
    partial void OnTenSachChanged();
    partial void OnNgayLapChanging(System.DateTime value);
    partial void OnNgayLapChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnTongTienChanging(System.Nullable<int> value);
    partial void OnTongTienChanged();
    #endregion
		
		public HoaDon()
		{
			this._PhieuBans = new EntitySet<PhieuBan>(new Action<PhieuBan>(this.attach_PhieuBans), new Action<PhieuBan>(this.detach_PhieuBans));
			this._KhachHang = default(EntityRef<KhachHang>);
			this._Sach = default(EntityRef<Sach>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					if (this._Sach.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSach", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenSach
		{
			get
			{
				return this._TenSach;
			}
			set
			{
				if ((this._TenSach != value))
				{
					this.OnTenSachChanging(value);
					this.SendPropertyChanging();
					this._TenSach = value;
					this.SendPropertyChanged("TenSach");
					this.OnTenSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLap", DbType="DateTime NOT NULL")]
		public System.DateTime NgayLap
		{
			get
			{
				return this._NgayLap;
			}
			set
			{
				if ((this._NgayLap != value))
				{
					this.OnNgayLapChanging(value);
					this.SendPropertyChanging();
					this._NgayLap = value;
					this.SendPropertyChanged("NgayLap");
					this.OnNgayLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Int")]
		public System.Nullable<int> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_PhieuBan", Storage="_PhieuBans", ThisKey="MaHD", OtherKey="MaPhieuBan")]
		public EntitySet<PhieuBan> PhieuBans
		{
			get
			{
				return this._PhieuBans;
			}
			set
			{
				this._PhieuBans.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDon", Storage="_KhachHang", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(string);
					}
					this.SendPropertyChanged("KhachHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sach_HoaDon", Storage="_Sach", ThisKey="MaSach", OtherKey="MaSach", IsForeignKey=true)]
		public Sach Sach
		{
			get
			{
				return this._Sach.Entity;
			}
			set
			{
				Sach previousValue = this._Sach.Entity;
				if (((previousValue != value) 
							|| (this._Sach.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sach.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._Sach.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaSach = value.MaSach;
					}
					else
					{
						this._MaSach = default(string);
					}
					this.SendPropertyChanged("Sach");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PhieuBans(PhieuBan entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = this;
		}
		
		private void detach_PhieuBans(PhieuBan entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKH;
		
		private string _HoTen;
		
		private string _Sdt;
		
		private string _DiaChi;
		
		private string _Email;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(string value);
    partial void OnMaKHChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnSdtChanging(string value);
    partial void OnSdtChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public KhachHang()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sdt", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Sdt
		{
			get
			{
				return this._Sdt;
			}
			set
			{
				if ((this._Sdt != value))
				{
					this.OnSdtChanging(value);
					this.SendPropertyChanging();
					this._Sdt = value;
					this.SendPropertyChanged("Sdt");
					this.OnSdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDon", Storage="_HoaDons", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Email;
		
		private string _HoTen;
		
		private string _DiaChi;
		
		private string _Sdt;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSdtChanging(string value);
    partial void OnSdtChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public NhanVien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sdt", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Sdt
		{
			get
			{
				return this._Sdt;
			}
			set
			{
				if ((this._Sdt != value))
				{
					this.OnSdtChanging(value);
					this.SendPropertyChanging();
					this._Sdt = value;
					this.SendPropertyChanged("Sdt");
					this.OnSdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhieuBan")]
	public partial class PhieuBan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaPhieuBan;
		
		private string _MaSach;
		
		private int _SoLuong;
		
		private EntityRef<HoaDon> _HoaDon;
		
		private EntityRef<Sach> _Sach;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPhieuBanChanging(string value);
    partial void OnMaPhieuBanChanged();
    partial void OnMaSachChanging(string value);
    partial void OnMaSachChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    #endregion
		
		public PhieuBan()
		{
			this._HoaDon = default(EntityRef<HoaDon>);
			this._Sach = default(EntityRef<Sach>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhieuBan", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaPhieuBan
		{
			get
			{
				return this._MaPhieuBan;
			}
			set
			{
				if ((this._MaPhieuBan != value))
				{
					if (this._HoaDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPhieuBanChanging(value);
					this.SendPropertyChanging();
					this._MaPhieuBan = value;
					this.SendPropertyChanged("MaPhieuBan");
					this.OnMaPhieuBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					if (this._Sach.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_PhieuBan", Storage="_HoaDon", ThisKey="MaPhieuBan", OtherKey="MaHD", IsForeignKey=true)]
		public HoaDon HoaDon
		{
			get
			{
				return this._HoaDon.Entity;
			}
			set
			{
				HoaDon previousValue = this._HoaDon.Entity;
				if (((previousValue != value) 
							|| (this._HoaDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HoaDon.Entity = null;
						previousValue.PhieuBans.Remove(this);
					}
					this._HoaDon.Entity = value;
					if ((value != null))
					{
						value.PhieuBans.Add(this);
						this._MaPhieuBan = value.MaHD;
					}
					else
					{
						this._MaPhieuBan = default(string);
					}
					this.SendPropertyChanged("HoaDon");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sach_PhieuBan", Storage="_Sach", ThisKey="MaSach", OtherKey="MaSach", IsForeignKey=true)]
		public Sach Sach
		{
			get
			{
				return this._Sach.Entity;
			}
			set
			{
				Sach previousValue = this._Sach.Entity;
				if (((previousValue != value) 
							|| (this._Sach.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sach.Entity = null;
						previousValue.PhieuBans.Remove(this);
					}
					this._Sach.Entity = value;
					if ((value != null))
					{
						value.PhieuBans.Add(this);
						this._MaSach = value.MaSach;
					}
					else
					{
						this._MaSach = default(string);
					}
					this.SendPropertyChanged("Sach");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhieuNhap")]
	public partial class PhieuNhap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaPhieuNhap;
		
		private string _MaSach;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<int> _DonGia;
		
		private System.Nullable<int> _TongTien;
		
		private EntityRef<Sach> _Sach;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPhieuNhapChanging(string value);
    partial void OnMaPhieuNhapChanged();
    partial void OnMaSachChanging(string value);
    partial void OnMaSachChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaChanging(System.Nullable<int> value);
    partial void OnDonGiaChanged();
    partial void OnTongTienChanging(System.Nullable<int> value);
    partial void OnTongTienChanged();
    #endregion
		
		public PhieuNhap()
		{
			this._Sach = default(EntityRef<Sach>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhieuNhap", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaPhieuNhap
		{
			get
			{
				return this._MaPhieuNhap;
			}
			set
			{
				if ((this._MaPhieuNhap != value))
				{
					this.OnMaPhieuNhapChanging(value);
					this.SendPropertyChanging();
					this._MaPhieuNhap = value;
					this.SendPropertyChanged("MaPhieuNhap");
					this.OnMaPhieuNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					if (this._Sach.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Int")]
		public System.Nullable<int> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Int")]
		public System.Nullable<int> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sach_PhieuNhap", Storage="_Sach", ThisKey="MaSach", OtherKey="MaSach", IsForeignKey=true)]
		public Sach Sach
		{
			get
			{
				return this._Sach.Entity;
			}
			set
			{
				Sach previousValue = this._Sach.Entity;
				if (((previousValue != value) 
							|| (this._Sach.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sach.Entity = null;
						previousValue.PhieuNhaps.Remove(this);
					}
					this._Sach.Entity = value;
					if ((value != null))
					{
						value.PhieuNhaps.Add(this);
						this._MaSach = value.MaSach;
					}
					else
					{
						this._MaSach = default(string);
					}
					this.SendPropertyChanged("Sach");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sach")]
	public partial class Sach : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSach;
		
		private string _TenSach;
		
		private string _TheLoai;
		
		private string _TacGia;
		
		private int _DonGia;
		
		private System.Nullable<int> _TonDau;
		
		private System.Nullable<int> _TongNhap;
		
		private int _TongBan;
		
		private System.Nullable<int> _TonCuoi;
		
		private EntitySet<HoaDon> _HoaDons;
		
		private EntitySet<PhieuBan> _PhieuBans;
		
		private EntitySet<PhieuNhap> _PhieuNhaps;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSachChanging(string value);
    partial void OnMaSachChanged();
    partial void OnTenSachChanging(string value);
    partial void OnTenSachChanged();
    partial void OnTheLoaiChanging(string value);
    partial void OnTheLoaiChanged();
    partial void OnTacGiaChanging(string value);
    partial void OnTacGiaChanged();
    partial void OnDonGiaChanging(int value);
    partial void OnDonGiaChanged();
    partial void OnTonDauChanging(System.Nullable<int> value);
    partial void OnTonDauChanged();
    partial void OnTongNhapChanging(System.Nullable<int> value);
    partial void OnTongNhapChanged();
    partial void OnTongBanChanging(int value);
    partial void OnTongBanChanged();
    partial void OnTonCuoiChanging(System.Nullable<int> value);
    partial void OnTonCuoiChanged();
    #endregion
		
		public Sach()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			this._PhieuBans = new EntitySet<PhieuBan>(new Action<PhieuBan>(this.attach_PhieuBans), new Action<PhieuBan>(this.detach_PhieuBans));
			this._PhieuNhaps = new EntitySet<PhieuNhap>(new Action<PhieuNhap>(this.attach_PhieuNhaps), new Action<PhieuNhap>(this.detach_PhieuNhaps));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSach", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenSach
		{
			get
			{
				return this._TenSach;
			}
			set
			{
				if ((this._TenSach != value))
				{
					this.OnTenSachChanging(value);
					this.SendPropertyChanging();
					this._TenSach = value;
					this.SendPropertyChanged("TenSach");
					this.OnTenSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TheLoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TheLoai
		{
			get
			{
				return this._TheLoai;
			}
			set
			{
				if ((this._TheLoai != value))
				{
					this.OnTheLoaiChanging(value);
					this.SendPropertyChanging();
					this._TheLoai = value;
					this.SendPropertyChanged("TheLoai");
					this.OnTheLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TacGia", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TacGia
		{
			get
			{
				return this._TacGia;
			}
			set
			{
				if ((this._TacGia != value))
				{
					this.OnTacGiaChanging(value);
					this.SendPropertyChanging();
					this._TacGia = value;
					this.SendPropertyChanged("TacGia");
					this.OnTacGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Int NOT NULL")]
		public int DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TonDau", DbType="Int")]
		public System.Nullable<int> TonDau
		{
			get
			{
				return this._TonDau;
			}
			set
			{
				if ((this._TonDau != value))
				{
					this.OnTonDauChanging(value);
					this.SendPropertyChanging();
					this._TonDau = value;
					this.SendPropertyChanged("TonDau");
					this.OnTonDauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongNhap", DbType="Int")]
		public System.Nullable<int> TongNhap
		{
			get
			{
				return this._TongNhap;
			}
			set
			{
				if ((this._TongNhap != value))
				{
					this.OnTongNhapChanging(value);
					this.SendPropertyChanging();
					this._TongNhap = value;
					this.SendPropertyChanged("TongNhap");
					this.OnTongNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongBan", DbType="Int NOT NULL")]
		public int TongBan
		{
			get
			{
				return this._TongBan;
			}
			set
			{
				if ((this._TongBan != value))
				{
					this.OnTongBanChanging(value);
					this.SendPropertyChanging();
					this._TongBan = value;
					this.SendPropertyChanged("TongBan");
					this.OnTongBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TonCuoi", DbType="Int")]
		public System.Nullable<int> TonCuoi
		{
			get
			{
				return this._TonCuoi;
			}
			set
			{
				if ((this._TonCuoi != value))
				{
					this.OnTonCuoiChanging(value);
					this.SendPropertyChanging();
					this._TonCuoi = value;
					this.SendPropertyChanged("TonCuoi");
					this.OnTonCuoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sach_HoaDon", Storage="_HoaDons", ThisKey="MaSach", OtherKey="MaSach")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sach_PhieuBan", Storage="_PhieuBans", ThisKey="MaSach", OtherKey="MaSach")]
		public EntitySet<PhieuBan> PhieuBans
		{
			get
			{
				return this._PhieuBans;
			}
			set
			{
				this._PhieuBans.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sach_PhieuNhap", Storage="_PhieuNhaps", ThisKey="MaSach", OtherKey="MaSach")]
		public EntitySet<PhieuNhap> PhieuNhaps
		{
			get
			{
				return this._PhieuNhaps;
			}
			set
			{
				this._PhieuNhaps.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Sach = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Sach = null;
		}
		
		private void attach_PhieuBans(PhieuBan entity)
		{
			this.SendPropertyChanging();
			entity.Sach = this;
		}
		
		private void detach_PhieuBans(PhieuBan entity)
		{
			this.SendPropertyChanging();
			entity.Sach = null;
		}
		
		private void attach_PhieuNhaps(PhieuNhap entity)
		{
			this.SendPropertyChanging();
			entity.Sach = this;
		}
		
		private void detach_PhieuNhaps(PhieuNhap entity)
		{
			this.SendPropertyChanging();
			entity.Sach = null;
		}
	}
}
#pragma warning restore 1591
