using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ReportHopDong_Vaccine;

[Serializable]
[XmlRoot("rep_HopDong_Vaccine")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[HelpKeyword("vs.data.DataSet")]
[DesignerCategory("code")]
public class rep_HopDong_Vaccine : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Table1RowChangeEventHandler(object sender, Table1RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Table2RowChangeEventHandler(object sender, Table2RowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Table1DataTable : TypedTableBase<Table1Row>
	{
		private DataColumn columnFacID;

		private DataColumn columnID;

		private DataColumn columnPatientID;

		private DataColumn columnPatientHospitalID;

		private DataColumn columnHopDongID;

		private DataColumn columnNguoiLienHeID;

		private DataColumn columnSoHDong;

		private DataColumn columnTenNguoiDKy;

		private DataColumn columnDob_NguoiDKy;

		private DataColumn columnSex_F;

		private DataColumn columnSex_M;

		private DataColumn columnQuocTich_NguoiDKy;

		private DataColumn columnCMND_NguoiDKy;

		private DataColumn columnNgayCapCMND_DD_NguoiDKy;

		private DataColumn columnNgayCapCMND_MM_NguoiDKy;

		private DataColumn columnNgayCapCMND_YYYY_NguoiDKy;

		private DataColumn columnDiaChi;

		private DataColumn columnDiaChi_NguoiDKy;

		private DataColumn columnDTCoDinh_NguoiDKy;

		private DataColumn columnDTDD_NguoiDKy;

		private DataColumn columnTenNguoiTiem;

		private DataColumn columnDob_NguoiTiem;

		private DataColumn columnQuocTich_NguoiTiem;

		private DataColumn columnTenGoi;

		private DataColumn columnTenGoi_Check;

		private DataColumn columnGoi_0_12_1A;

		private DataColumn columnGoi_0_12_1B;

		private DataColumn columnGoi_0_24_2A;

		private DataColumn columnGoi_0_24_2B;

		private DataColumn columnGoi_PN_MangThai;

		private DataColumn columnGoi_TruongThanh;

		private DataColumn columnddMMyyyy_Text;

		private DataColumn columnDiaChiFacility;

		private DataColumn columnReportName;

		private DataColumn columnLogo;

		private DataColumn columnDiaChiHoKhau;

		private DataColumn columnDiaChiNoiCap;

		private DataColumn columnNgayThangNoiCap;

		private DataColumn columnDiaChiCongTyTiem;

		private DataColumn columnNamHien;

		private DataColumn columnTTVaccineShort;

		private DataColumn columnNameofTT;

		private DataColumn columnTAX;

		private DataColumn columnChucVu;

		private DataColumn columnNguoiDaiDien;

		private DataColumn columnDayHD;

		private DataColumn columnMonthHD;

		private DataColumn columnYearHD;

		private DataColumn columnVNVCPhone;

		private DataColumn columnFax;

		private DataColumn columnDiaChiTTT;

		private DataColumn columnHTML;

		private DataColumn columnHTMLDiaDiem;

		private DataColumn columnDiaChiTT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FacIDColumn => columnFacID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IDColumn => columnID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PatientIDColumn => columnPatientID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PatientHospitalIDColumn => columnPatientHospitalID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn HopDongIDColumn => columnHopDongID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NguoiLienHeIDColumn => columnNguoiLienHeID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SoHDongColumn => columnSoHDong;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TenNguoiDKyColumn => columnTenNguoiDKy;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Dob_NguoiDKyColumn => columnDob_NguoiDKy;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Sex_FColumn => columnSex_F;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Sex_MColumn => columnSex_M;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QuocTich_NguoiDKyColumn => columnQuocTich_NguoiDKy;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CMND_NguoiDKyColumn => columnCMND_NguoiDKy;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NgayCapCMND_DD_NguoiDKyColumn => columnNgayCapCMND_DD_NguoiDKy;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NgayCapCMND_MM_NguoiDKyColumn => columnNgayCapCMND_MM_NguoiDKy;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NgayCapCMND_YYYY_NguoiDKyColumn => columnNgayCapCMND_YYYY_NguoiDKy;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DiaChiColumn => columnDiaChi;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DiaChi_NguoiDKyColumn => columnDiaChi_NguoiDKy;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DTCoDinh_NguoiDKyColumn => columnDTCoDinh_NguoiDKy;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DTDD_NguoiDKyColumn => columnDTDD_NguoiDKy;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TenNguoiTiemColumn => columnTenNguoiTiem;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Dob_NguoiTiemColumn => columnDob_NguoiTiem;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QuocTich_NguoiTiemColumn => columnQuocTich_NguoiTiem;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TenGoiColumn => columnTenGoi;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TenGoi_CheckColumn => columnTenGoi_Check;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Goi_0_12_1AColumn => columnGoi_0_12_1A;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Goi_0_12_1BColumn => columnGoi_0_12_1B;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Goi_0_24_2AColumn => columnGoi_0_24_2A;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Goi_0_24_2BColumn => columnGoi_0_24_2B;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Goi_PN_MangThaiColumn => columnGoi_PN_MangThai;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Goi_TruongThanhColumn => columnGoi_TruongThanh;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ddMMyyyy_TextColumn => columnddMMyyyy_Text;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DiaChiFacilityColumn => columnDiaChiFacility;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ReportNameColumn => columnReportName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LogoColumn => columnLogo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DiaChiHoKhauColumn => columnDiaChiHoKhau;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DiaChiNoiCapColumn => columnDiaChiNoiCap;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NgayThangNoiCapColumn => columnNgayThangNoiCap;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DiaChiCongTyTiemColumn => columnDiaChiCongTyTiem;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NamHienColumn => columnNamHien;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TTVaccineShortColumn => columnTTVaccineShort;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NameofTTColumn => columnNameofTT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TAXColumn => columnTAX;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ChucVuColumn => columnChucVu;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NguoiDaiDienColumn => columnNguoiDaiDien;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DayHDColumn => columnDayHD;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MonthHDColumn => columnMonthHD;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn YearHDColumn => columnYearHD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VNVCPhoneColumn => columnVNVCPhone;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FaxColumn => columnFax;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DiaChiTTTColumn => columnDiaChiTTT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn HTMLColumn => columnHTML;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HTMLDiaDiemColumn => columnHTMLDiaDiem;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DiaChiTTColumn => columnDiaChiTT;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1Row this[int index] => (Table1Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1DataTable()
		{
			base.TableName = "Table1";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table1DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected Table1DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddTable1Row(Table1Row row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1Row AddTable1Row(string FacID, int ID, string PatientID, string PatientHospitalID, string HopDongID, string NguoiLienHeID, string SoHDong, string TenNguoiDKy, string Dob_NguoiDKy, string Sex_F, string Sex_M, string QuocTich_NguoiDKy, string CMND_NguoiDKy, string NgayCapCMND_DD_NguoiDKy, string NgayCapCMND_MM_NguoiDKy, string NgayCapCMND_YYYY_NguoiDKy, string DiaChi, string DiaChi_NguoiDKy, string DTCoDinh_NguoiDKy, string DTDD_NguoiDKy, string TenNguoiTiem, string Dob_NguoiTiem, string QuocTich_NguoiTiem, string TenGoi, string TenGoi_Check, string Goi_0_12_1A, string Goi_0_12_1B, string Goi_0_24_2A, string Goi_0_24_2B, string Goi_PN_MangThai, string Goi_TruongThanh, string ddMMyyyy_Text, string DiaChiFacility, string ReportName, string Logo, string DiaChiHoKhau, string DiaChiNoiCap, string NgayThangNoiCap, string DiaChiCongTyTiem, int NamHien, string TTVaccineShort, string NameofTT, string TAX, string ChucVu, string NguoiDaiDien, string DayHD, string MonthHD, string YearHD, string VNVCPhone, string Fax, string DiaChiTTT, string HTML, string HTMLDiaDiem, string DiaChiTT)
		{
			Table1Row table1Row = (Table1Row)NewRow();
			object[] itemArray = new object[54]
			{
				FacID, ID, PatientID, PatientHospitalID, HopDongID, NguoiLienHeID, SoHDong, TenNguoiDKy, Dob_NguoiDKy, Sex_F,
				Sex_M, QuocTich_NguoiDKy, CMND_NguoiDKy, NgayCapCMND_DD_NguoiDKy, NgayCapCMND_MM_NguoiDKy, NgayCapCMND_YYYY_NguoiDKy, DiaChi, DiaChi_NguoiDKy, DTCoDinh_NguoiDKy, DTDD_NguoiDKy,
				TenNguoiTiem, Dob_NguoiTiem, QuocTich_NguoiTiem, TenGoi, TenGoi_Check, Goi_0_12_1A, Goi_0_12_1B, Goi_0_24_2A, Goi_0_24_2B, Goi_PN_MangThai,
				Goi_TruongThanh, ddMMyyyy_Text, DiaChiFacility, ReportName, Logo, DiaChiHoKhau, DiaChiNoiCap, NgayThangNoiCap, DiaChiCongTyTiem, NamHien,
				TTVaccineShort, NameofTT, TAX, ChucVu, NguoiDaiDien, DayHD, MonthHD, YearHD, VNVCPhone, Fax,
				DiaChiTTT, HTML, HTMLDiaDiem, DiaChiTT
			};
			table1Row.ItemArray = itemArray;
			base.Rows.Add(table1Row);
			return table1Row;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Table1DataTable table1DataTable = (Table1DataTable)base.Clone();
			table1DataTable.InitVars();
			return table1DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Table1DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnFacID = base.Columns["FacID"];
			columnID = base.Columns["ID"];
			columnPatientID = base.Columns["PatientID"];
			columnPatientHospitalID = base.Columns["PatientHospitalID"];
			columnHopDongID = base.Columns["HopDongID"];
			columnNguoiLienHeID = base.Columns["NguoiLienHeID"];
			columnSoHDong = base.Columns["SoHDong"];
			columnTenNguoiDKy = base.Columns["TenNguoiDKy"];
			columnDob_NguoiDKy = base.Columns["Dob_NguoiDKy"];
			columnSex_F = base.Columns["Sex_F"];
			columnSex_M = base.Columns["Sex_M"];
			columnQuocTich_NguoiDKy = base.Columns["QuocTich_NguoiDKy"];
			columnCMND_NguoiDKy = base.Columns["CMND_NguoiDKy"];
			columnNgayCapCMND_DD_NguoiDKy = base.Columns["NgayCapCMND_DD_NguoiDKy"];
			columnNgayCapCMND_MM_NguoiDKy = base.Columns["NgayCapCMND_MM_NguoiDKy"];
			columnNgayCapCMND_YYYY_NguoiDKy = base.Columns["NgayCapCMND_YYYY_NguoiDKy"];
			columnDiaChi = base.Columns["DiaChi"];
			columnDiaChi_NguoiDKy = base.Columns["DiaChi_NguoiDKy"];
			columnDTCoDinh_NguoiDKy = base.Columns["DTCoDinh_NguoiDKy"];
			columnDTDD_NguoiDKy = base.Columns["DTDD_NguoiDKy"];
			columnTenNguoiTiem = base.Columns["TenNguoiTiem"];
			columnDob_NguoiTiem = base.Columns["Dob_NguoiTiem"];
			columnQuocTich_NguoiTiem = base.Columns["QuocTich_NguoiTiem"];
			columnTenGoi = base.Columns["TenGoi"];
			columnTenGoi_Check = base.Columns["TenGoi_Check"];
			columnGoi_0_12_1A = base.Columns["Goi_0_12_1A"];
			columnGoi_0_12_1B = base.Columns["Goi_0_12_1B"];
			columnGoi_0_24_2A = base.Columns["Goi_0_24_2A"];
			columnGoi_0_24_2B = base.Columns["Goi_0_24_2B"];
			columnGoi_PN_MangThai = base.Columns["Goi_PN_MangThai"];
			columnGoi_TruongThanh = base.Columns["Goi_TruongThanh"];
			columnddMMyyyy_Text = base.Columns["ddMMyyyy_Text"];
			columnDiaChiFacility = base.Columns["DiaChiFacility"];
			columnReportName = base.Columns["ReportName"];
			columnLogo = base.Columns["Logo"];
			columnDiaChiHoKhau = base.Columns["DiaChiHoKhau"];
			columnDiaChiNoiCap = base.Columns["DiaChiNoiCap"];
			columnNgayThangNoiCap = base.Columns["NgayThangNoiCap"];
			columnDiaChiCongTyTiem = base.Columns["DiaChiCongTyTiem"];
			columnNamHien = base.Columns["NamHien"];
			columnTTVaccineShort = base.Columns["TTVaccineShort"];
			columnNameofTT = base.Columns["NameofTT"];
			columnTAX = base.Columns["TAX"];
			columnChucVu = base.Columns["ChucVu"];
			columnNguoiDaiDien = base.Columns["NguoiDaiDien"];
			columnDayHD = base.Columns["DayHD"];
			columnMonthHD = base.Columns["MonthHD"];
			columnYearHD = base.Columns["YearHD"];
			columnVNVCPhone = base.Columns["VNVCPhone"];
			columnFax = base.Columns["Fax"];
			columnDiaChiTTT = base.Columns["DiaChiTTT"];
			columnHTML = base.Columns["HTML"];
			columnHTMLDiaDiem = base.Columns["HTMLDiaDiem"];
			columnDiaChiTT = base.Columns["DiaChiTT"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnFacID = new DataColumn("FacID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFacID);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnPatientID = new DataColumn("PatientID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPatientID);
			columnPatientHospitalID = new DataColumn("PatientHospitalID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPatientHospitalID);
			columnHopDongID = new DataColumn("HopDongID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHopDongID);
			columnNguoiLienHeID = new DataColumn("NguoiLienHeID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNguoiLienHeID);
			columnSoHDong = new DataColumn("SoHDong", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoHDong);
			columnTenNguoiDKy = new DataColumn("TenNguoiDKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenNguoiDKy);
			columnDob_NguoiDKy = new DataColumn("Dob_NguoiDKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDob_NguoiDKy);
			columnSex_F = new DataColumn("Sex_F", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSex_F);
			columnSex_M = new DataColumn("Sex_M", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSex_M);
			columnQuocTich_NguoiDKy = new DataColumn("QuocTich_NguoiDKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnQuocTich_NguoiDKy);
			columnCMND_NguoiDKy = new DataColumn("CMND_NguoiDKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCMND_NguoiDKy);
			columnNgayCapCMND_DD_NguoiDKy = new DataColumn("NgayCapCMND_DD_NguoiDKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgayCapCMND_DD_NguoiDKy);
			columnNgayCapCMND_MM_NguoiDKy = new DataColumn("NgayCapCMND_MM_NguoiDKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgayCapCMND_MM_NguoiDKy);
			columnNgayCapCMND_YYYY_NguoiDKy = new DataColumn("NgayCapCMND_YYYY_NguoiDKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgayCapCMND_YYYY_NguoiDKy);
			columnDiaChi = new DataColumn("DiaChi", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChi);
			columnDiaChi_NguoiDKy = new DataColumn("DiaChi_NguoiDKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChi_NguoiDKy);
			columnDTCoDinh_NguoiDKy = new DataColumn("DTCoDinh_NguoiDKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDTCoDinh_NguoiDKy);
			columnDTDD_NguoiDKy = new DataColumn("DTDD_NguoiDKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDTDD_NguoiDKy);
			columnTenNguoiTiem = new DataColumn("TenNguoiTiem", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenNguoiTiem);
			columnDob_NguoiTiem = new DataColumn("Dob_NguoiTiem", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDob_NguoiTiem);
			columnQuocTich_NguoiTiem = new DataColumn("QuocTich_NguoiTiem", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnQuocTich_NguoiTiem);
			columnTenGoi = new DataColumn("TenGoi", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenGoi);
			columnTenGoi_Check = new DataColumn("TenGoi_Check", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenGoi_Check);
			columnGoi_0_12_1A = new DataColumn("Goi_0_12_1A", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnGoi_0_12_1A);
			columnGoi_0_12_1B = new DataColumn("Goi_0_12_1B", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnGoi_0_12_1B);
			columnGoi_0_24_2A = new DataColumn("Goi_0_24_2A", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnGoi_0_24_2A);
			columnGoi_0_24_2B = new DataColumn("Goi_0_24_2B", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnGoi_0_24_2B);
			columnGoi_PN_MangThai = new DataColumn("Goi_PN_MangThai", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnGoi_PN_MangThai);
			columnGoi_TruongThanh = new DataColumn("Goi_TruongThanh", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnGoi_TruongThanh);
			columnddMMyyyy_Text = new DataColumn("ddMMyyyy_Text", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnddMMyyyy_Text);
			columnDiaChiFacility = new DataColumn("DiaChiFacility", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChiFacility);
			columnReportName = new DataColumn("ReportName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnReportName);
			columnLogo = new DataColumn("Logo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLogo);
			columnDiaChiHoKhau = new DataColumn("DiaChiHoKhau", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChiHoKhau);
			columnDiaChiNoiCap = new DataColumn("DiaChiNoiCap", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChiNoiCap);
			columnNgayThangNoiCap = new DataColumn("NgayThangNoiCap", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgayThangNoiCap);
			columnDiaChiCongTyTiem = new DataColumn("DiaChiCongTyTiem", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChiCongTyTiem);
			columnNamHien = new DataColumn("NamHien", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnNamHien);
			columnTTVaccineShort = new DataColumn("TTVaccineShort", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTTVaccineShort);
			columnNameofTT = new DataColumn("NameofTT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNameofTT);
			columnTAX = new DataColumn("TAX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTAX);
			columnChucVu = new DataColumn("ChucVu", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnChucVu);
			columnNguoiDaiDien = new DataColumn("NguoiDaiDien", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNguoiDaiDien);
			columnDayHD = new DataColumn("DayHD", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDayHD);
			columnMonthHD = new DataColumn("MonthHD", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMonthHD);
			columnYearHD = new DataColumn("YearHD", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnYearHD);
			columnVNVCPhone = new DataColumn("VNVCPhone", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnVNVCPhone);
			columnFax = new DataColumn("Fax", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFax);
			columnDiaChiTTT = new DataColumn("DiaChiTTT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChiTTT);
			columnHTML = new DataColumn("HTML", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHTML);
			columnHTMLDiaDiem = new DataColumn("HTMLDiaDiem", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHTMLDiaDiem);
			columnDiaChiTT = new DataColumn("DiaChiTT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChiTT);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1Row NewTable1Row()
		{
			return (Table1Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Table1Row(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Table1Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Table1RowChanged != null)
			{
				this.Table1RowChanged(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Table1RowChanging != null)
			{
				this.Table1RowChanging(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Table1RowDeleted != null)
			{
				this.Table1RowDeleted(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Table1RowDeleting != null)
			{
				this.Table1RowDeleting(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveTable1Row(Table1Row row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_HopDong_Vaccine rep_HopDong_Vaccine2 = new rep_HopDong_Vaccine();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_HopDong_Vaccine2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Table1DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_HopDong_Vaccine2.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Table2DataTable : TypedTableBase<Table2Row>
	{
		private DataColumn columnImage;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ImageColumn => columnImage;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2Row this[int index] => (Table2Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2DataTable()
		{
			base.TableName = "Table2";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table2DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected Table2DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddTable2Row(Table2Row row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table2Row AddTable2Row(string Image)
		{
			Table2Row table2Row = (Table2Row)NewRow();
			object[] itemArray = new object[1] { Image };
			table2Row.ItemArray = itemArray;
			base.Rows.Add(table2Row);
			return table2Row;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Table2DataTable table2DataTable = (Table2DataTable)base.Clone();
			table2DataTable.InitVars();
			return table2DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Table2DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnImage = base.Columns["Image"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnImage = new DataColumn("Image", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnImage);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table2Row NewTable2Row()
		{
			return (Table2Row)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Table2Row(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Table2Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Table2RowChanged != null)
			{
				this.Table2RowChanged(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Table2RowChanging != null)
			{
				this.Table2RowChanging(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Table2RowDeleted != null)
			{
				this.Table2RowDeleted(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Table2RowDeleting != null)
			{
				this.Table2RowDeleting(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveTable2Row(Table2Row row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_HopDong_Vaccine rep_HopDong_Vaccine2 = new rep_HopDong_Vaccine();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_HopDong_Vaccine2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Table2DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_HopDong_Vaccine2.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	public class Table1Row : DataRow
	{
		private Table1DataTable tableTable1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string FacID
		{
			get
			{
				try
				{
					return (string)base[tableTable1.FacIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'FacID' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.FacIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int ID
		{
			get
			{
				try
				{
					return (int)base[tableTable1.IDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ID' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PatientID
		{
			get
			{
				try
				{
					return (string)base[tableTable1.PatientIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PatientID' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.PatientIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string PatientHospitalID
		{
			get
			{
				try
				{
					return (string)base[tableTable1.PatientHospitalIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PatientHospitalID' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.PatientHospitalIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HopDongID
		{
			get
			{
				try
				{
					return (string)base[tableTable1.HopDongIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HopDongID' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.HopDongIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NguoiLienHeID
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NguoiLienHeIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NguoiLienHeID' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NguoiLienHeIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SoHDong
		{
			get
			{
				try
				{
					return (string)base[tableTable1.SoHDongColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoHDong' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.SoHDongColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TenNguoiDKy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TenNguoiDKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TenNguoiDKy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TenNguoiDKyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Dob_NguoiDKy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.Dob_NguoiDKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Dob_NguoiDKy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.Dob_NguoiDKyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Sex_F
		{
			get
			{
				try
				{
					return (string)base[tableTable1.Sex_FColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Sex_F' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.Sex_FColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Sex_M
		{
			get
			{
				try
				{
					return (string)base[tableTable1.Sex_MColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Sex_M' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.Sex_MColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string QuocTich_NguoiDKy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.QuocTich_NguoiDKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'QuocTich_NguoiDKy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.QuocTich_NguoiDKyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CMND_NguoiDKy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.CMND_NguoiDKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CMND_NguoiDKy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.CMND_NguoiDKyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NgayCapCMND_DD_NguoiDKy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NgayCapCMND_DD_NguoiDKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayCapCMND_DD_NguoiDKy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NgayCapCMND_DD_NguoiDKyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NgayCapCMND_MM_NguoiDKy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NgayCapCMND_MM_NguoiDKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayCapCMND_MM_NguoiDKy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NgayCapCMND_MM_NguoiDKyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NgayCapCMND_YYYY_NguoiDKy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NgayCapCMND_YYYY_NguoiDKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayCapCMND_YYYY_NguoiDKy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NgayCapCMND_YYYY_NguoiDKyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChi
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChi' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DiaChi_NguoiDKy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChi_NguoiDKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChi_NguoiDKy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChi_NguoiDKyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DTCoDinh_NguoiDKy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DTCoDinh_NguoiDKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DTCoDinh_NguoiDKy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DTCoDinh_NguoiDKyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DTDD_NguoiDKy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DTDD_NguoiDKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DTDD_NguoiDKy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DTDD_NguoiDKyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TenNguoiTiem
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TenNguoiTiemColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TenNguoiTiem' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TenNguoiTiemColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Dob_NguoiTiem
		{
			get
			{
				try
				{
					return (string)base[tableTable1.Dob_NguoiTiemColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Dob_NguoiTiem' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.Dob_NguoiTiemColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string QuocTich_NguoiTiem
		{
			get
			{
				try
				{
					return (string)base[tableTable1.QuocTich_NguoiTiemColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'QuocTich_NguoiTiem' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.QuocTich_NguoiTiemColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TenGoi
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TenGoiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TenGoi' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TenGoiColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TenGoi_Check
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TenGoi_CheckColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TenGoi_Check' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TenGoi_CheckColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Goi_0_12_1A
		{
			get
			{
				try
				{
					return (string)base[tableTable1.Goi_0_12_1AColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Goi_0_12_1A' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.Goi_0_12_1AColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Goi_0_12_1B
		{
			get
			{
				try
				{
					return (string)base[tableTable1.Goi_0_12_1BColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Goi_0_12_1B' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.Goi_0_12_1BColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Goi_0_24_2A
		{
			get
			{
				try
				{
					return (string)base[tableTable1.Goi_0_24_2AColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Goi_0_24_2A' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.Goi_0_24_2AColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Goi_0_24_2B
		{
			get
			{
				try
				{
					return (string)base[tableTable1.Goi_0_24_2BColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Goi_0_24_2B' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.Goi_0_24_2BColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Goi_PN_MangThai
		{
			get
			{
				try
				{
					return (string)base[tableTable1.Goi_PN_MangThaiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Goi_PN_MangThai' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.Goi_PN_MangThaiColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Goi_TruongThanh
		{
			get
			{
				try
				{
					return (string)base[tableTable1.Goi_TruongThanhColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Goi_TruongThanh' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.Goi_TruongThanhColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ddMMyyyy_Text
		{
			get
			{
				try
				{
					return (string)base[tableTable1.ddMMyyyy_TextColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ddMMyyyy_Text' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.ddMMyyyy_TextColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChiFacility
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiFacilityColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChiFacility' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiFacilityColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ReportName
		{
			get
			{
				try
				{
					return (string)base[tableTable1.ReportNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ReportName' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.ReportNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Logo
		{
			get
			{
				try
				{
					return (string)base[tableTable1.LogoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Logo' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.LogoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChiHoKhau
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiHoKhauColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChiHoKhau' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiHoKhauColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChiNoiCap
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiNoiCapColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChiNoiCap' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiNoiCapColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NgayThangNoiCap
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NgayThangNoiCapColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayThangNoiCap' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NgayThangNoiCapColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChiCongTyTiem
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiCongTyTiemColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChiCongTyTiem' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiCongTyTiemColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int NamHien
		{
			get
			{
				try
				{
					return (int)base[tableTable1.NamHienColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NamHien' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NamHienColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TTVaccineShort
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TTVaccineShortColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TTVaccineShort' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TTVaccineShortColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NameofTT
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NameofTTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NameofTT' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NameofTTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TAX
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TAXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TAX' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TAXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ChucVu
		{
			get
			{
				try
				{
					return (string)base[tableTable1.ChucVuColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ChucVu' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.ChucVuColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NguoiDaiDien
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NguoiDaiDienColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NguoiDaiDien' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NguoiDaiDienColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DayHD
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DayHDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DayHD' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DayHDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string MonthHD
		{
			get
			{
				try
				{
					return (string)base[tableTable1.MonthHDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'MonthHD' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.MonthHDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string YearHD
		{
			get
			{
				try
				{
					return (string)base[tableTable1.YearHDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'YearHD' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.YearHDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string VNVCPhone
		{
			get
			{
				try
				{
					return (string)base[tableTable1.VNVCPhoneColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'VNVCPhone' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.VNVCPhoneColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Fax
		{
			get
			{
				try
				{
					return (string)base[tableTable1.FaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Fax' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.FaxColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChiTTT
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiTTTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChiTTT' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiTTTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HTML
		{
			get
			{
				try
				{
					return (string)base[tableTable1.HTMLColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HTML' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.HTMLColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HTMLDiaDiem
		{
			get
			{
				try
				{
					return (string)base[tableTable1.HTMLDiaDiemColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HTMLDiaDiem' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.HTMLDiaDiemColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChiTT
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiTTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChiTT' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiTTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table1Row(DataRowBuilder rb)
			: base(rb)
		{
			tableTable1 = (Table1DataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFacIDNull()
		{
			return IsNull(tableTable1.FacIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFacIDNull()
		{
			base[tableTable1.FacIDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsIDNull()
		{
			return IsNull(tableTable1.IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetIDNull()
		{
			base[tableTable1.IDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPatientIDNull()
		{
			return IsNull(tableTable1.PatientIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPatientIDNull()
		{
			base[tableTable1.PatientIDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPatientHospitalIDNull()
		{
			return IsNull(tableTable1.PatientHospitalIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPatientHospitalIDNull()
		{
			base[tableTable1.PatientHospitalIDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHopDongIDNull()
		{
			return IsNull(tableTable1.HopDongIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetHopDongIDNull()
		{
			base[tableTable1.HopDongIDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNguoiLienHeIDNull()
		{
			return IsNull(tableTable1.NguoiLienHeIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNguoiLienHeIDNull()
		{
			base[tableTable1.NguoiLienHeIDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSoHDongNull()
		{
			return IsNull(tableTable1.SoHDongColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSoHDongNull()
		{
			base[tableTable1.SoHDongColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTenNguoiDKyNull()
		{
			return IsNull(tableTable1.TenNguoiDKyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTenNguoiDKyNull()
		{
			base[tableTable1.TenNguoiDKyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDob_NguoiDKyNull()
		{
			return IsNull(tableTable1.Dob_NguoiDKyColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDob_NguoiDKyNull()
		{
			base[tableTable1.Dob_NguoiDKyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSex_FNull()
		{
			return IsNull(tableTable1.Sex_FColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSex_FNull()
		{
			base[tableTable1.Sex_FColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSex_MNull()
		{
			return IsNull(tableTable1.Sex_MColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSex_MNull()
		{
			base[tableTable1.Sex_MColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsQuocTich_NguoiDKyNull()
		{
			return IsNull(tableTable1.QuocTich_NguoiDKyColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetQuocTich_NguoiDKyNull()
		{
			base[tableTable1.QuocTich_NguoiDKyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCMND_NguoiDKyNull()
		{
			return IsNull(tableTable1.CMND_NguoiDKyColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCMND_NguoiDKyNull()
		{
			base[tableTable1.CMND_NguoiDKyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNgayCapCMND_DD_NguoiDKyNull()
		{
			return IsNull(tableTable1.NgayCapCMND_DD_NguoiDKyColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNgayCapCMND_DD_NguoiDKyNull()
		{
			base[tableTable1.NgayCapCMND_DD_NguoiDKyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNgayCapCMND_MM_NguoiDKyNull()
		{
			return IsNull(tableTable1.NgayCapCMND_MM_NguoiDKyColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNgayCapCMND_MM_NguoiDKyNull()
		{
			base[tableTable1.NgayCapCMND_MM_NguoiDKyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNgayCapCMND_YYYY_NguoiDKyNull()
		{
			return IsNull(tableTable1.NgayCapCMND_YYYY_NguoiDKyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNgayCapCMND_YYYY_NguoiDKyNull()
		{
			base[tableTable1.NgayCapCMND_YYYY_NguoiDKyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDiaChiNull()
		{
			return IsNull(tableTable1.DiaChiColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDiaChiNull()
		{
			base[tableTable1.DiaChiColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDiaChi_NguoiDKyNull()
		{
			return IsNull(tableTable1.DiaChi_NguoiDKyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDiaChi_NguoiDKyNull()
		{
			base[tableTable1.DiaChi_NguoiDKyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDTCoDinh_NguoiDKyNull()
		{
			return IsNull(tableTable1.DTCoDinh_NguoiDKyColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDTCoDinh_NguoiDKyNull()
		{
			base[tableTable1.DTCoDinh_NguoiDKyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDTDD_NguoiDKyNull()
		{
			return IsNull(tableTable1.DTDD_NguoiDKyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDTDD_NguoiDKyNull()
		{
			base[tableTable1.DTDD_NguoiDKyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTenNguoiTiemNull()
		{
			return IsNull(tableTable1.TenNguoiTiemColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTenNguoiTiemNull()
		{
			base[tableTable1.TenNguoiTiemColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDob_NguoiTiemNull()
		{
			return IsNull(tableTable1.Dob_NguoiTiemColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDob_NguoiTiemNull()
		{
			base[tableTable1.Dob_NguoiTiemColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQuocTich_NguoiTiemNull()
		{
			return IsNull(tableTable1.QuocTich_NguoiTiemColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQuocTich_NguoiTiemNull()
		{
			base[tableTable1.QuocTich_NguoiTiemColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTenGoiNull()
		{
			return IsNull(tableTable1.TenGoiColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTenGoiNull()
		{
			base[tableTable1.TenGoiColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTenGoi_CheckNull()
		{
			return IsNull(tableTable1.TenGoi_CheckColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTenGoi_CheckNull()
		{
			base[tableTable1.TenGoi_CheckColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsGoi_0_12_1ANull()
		{
			return IsNull(tableTable1.Goi_0_12_1AColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetGoi_0_12_1ANull()
		{
			base[tableTable1.Goi_0_12_1AColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsGoi_0_12_1BNull()
		{
			return IsNull(tableTable1.Goi_0_12_1BColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetGoi_0_12_1BNull()
		{
			base[tableTable1.Goi_0_12_1BColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsGoi_0_24_2ANull()
		{
			return IsNull(tableTable1.Goi_0_24_2AColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetGoi_0_24_2ANull()
		{
			base[tableTable1.Goi_0_24_2AColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsGoi_0_24_2BNull()
		{
			return IsNull(tableTable1.Goi_0_24_2BColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetGoi_0_24_2BNull()
		{
			base[tableTable1.Goi_0_24_2BColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsGoi_PN_MangThaiNull()
		{
			return IsNull(tableTable1.Goi_PN_MangThaiColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetGoi_PN_MangThaiNull()
		{
			base[tableTable1.Goi_PN_MangThaiColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsGoi_TruongThanhNull()
		{
			return IsNull(tableTable1.Goi_TruongThanhColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetGoi_TruongThanhNull()
		{
			base[tableTable1.Goi_TruongThanhColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsddMMyyyy_TextNull()
		{
			return IsNull(tableTable1.ddMMyyyy_TextColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetddMMyyyy_TextNull()
		{
			base[tableTable1.ddMMyyyy_TextColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDiaChiFacilityNull()
		{
			return IsNull(tableTable1.DiaChiFacilityColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDiaChiFacilityNull()
		{
			base[tableTable1.DiaChiFacilityColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsReportNameNull()
		{
			return IsNull(tableTable1.ReportNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetReportNameNull()
		{
			base[tableTable1.ReportNameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsLogoNull()
		{
			return IsNull(tableTable1.LogoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLogoNull()
		{
			base[tableTable1.LogoColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDiaChiHoKhauNull()
		{
			return IsNull(tableTable1.DiaChiHoKhauColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDiaChiHoKhauNull()
		{
			base[tableTable1.DiaChiHoKhauColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDiaChiNoiCapNull()
		{
			return IsNull(tableTable1.DiaChiNoiCapColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDiaChiNoiCapNull()
		{
			base[tableTable1.DiaChiNoiCapColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNgayThangNoiCapNull()
		{
			return IsNull(tableTable1.NgayThangNoiCapColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNgayThangNoiCapNull()
		{
			base[tableTable1.NgayThangNoiCapColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDiaChiCongTyTiemNull()
		{
			return IsNull(tableTable1.DiaChiCongTyTiemColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDiaChiCongTyTiemNull()
		{
			base[tableTable1.DiaChiCongTyTiemColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNamHienNull()
		{
			return IsNull(tableTable1.NamHienColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNamHienNull()
		{
			base[tableTable1.NamHienColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTTVaccineShortNull()
		{
			return IsNull(tableTable1.TTVaccineShortColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTTVaccineShortNull()
		{
			base[tableTable1.TTVaccineShortColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNameofTTNull()
		{
			return IsNull(tableTable1.NameofTTColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNameofTTNull()
		{
			base[tableTable1.NameofTTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTAXNull()
		{
			return IsNull(tableTable1.TAXColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTAXNull()
		{
			base[tableTable1.TAXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsChucVuNull()
		{
			return IsNull(tableTable1.ChucVuColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetChucVuNull()
		{
			base[tableTable1.ChucVuColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNguoiDaiDienNull()
		{
			return IsNull(tableTable1.NguoiDaiDienColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNguoiDaiDienNull()
		{
			base[tableTable1.NguoiDaiDienColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDayHDNull()
		{
			return IsNull(tableTable1.DayHDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDayHDNull()
		{
			base[tableTable1.DayHDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMonthHDNull()
		{
			return IsNull(tableTable1.MonthHDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMonthHDNull()
		{
			base[tableTable1.MonthHDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsYearHDNull()
		{
			return IsNull(tableTable1.YearHDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetYearHDNull()
		{
			base[tableTable1.YearHDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsVNVCPhoneNull()
		{
			return IsNull(tableTable1.VNVCPhoneColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetVNVCPhoneNull()
		{
			base[tableTable1.VNVCPhoneColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFaxNull()
		{
			return IsNull(tableTable1.FaxColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFaxNull()
		{
			base[tableTable1.FaxColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDiaChiTTTNull()
		{
			return IsNull(tableTable1.DiaChiTTTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDiaChiTTTNull()
		{
			base[tableTable1.DiaChiTTTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHTMLNull()
		{
			return IsNull(tableTable1.HTMLColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetHTMLNull()
		{
			base[tableTable1.HTMLColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHTMLDiaDiemNull()
		{
			return IsNull(tableTable1.HTMLDiaDiemColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetHTMLDiaDiemNull()
		{
			base[tableTable1.HTMLDiaDiemColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDiaChiTTNull()
		{
			return IsNull(tableTable1.DiaChiTTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDiaChiTTNull()
		{
			base[tableTable1.DiaChiTTColumn] = Convert.DBNull;
		}
	}

	public class Table2Row : DataRow
	{
		private Table2DataTable tableTable2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Image
		{
			get
			{
				try
				{
					return (string)base[tableTable2.ImageColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Image' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ImageColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Table2Row(DataRowBuilder rb)
			: base(rb)
		{
			tableTable2 = (Table2DataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsImageNull()
		{
			return IsNull(tableTable2.ImageColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetImageNull()
		{
			base[tableTable2.ImageColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Table1RowChangeEvent : EventArgs
	{
		private Table1Row eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1Row Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1RowChangeEvent(Table1Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Table2RowChangeEvent : EventArgs
	{
		private Table2Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table2Row Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2RowChangeEvent(Table2Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private Table1DataTable tableTable1;

	private Table2DataTable tableTable2;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public Table1DataTable Table1 => tableTable1;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Table2DataTable Table2 => tableTable2;

	[DebuggerNonUserCode]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public new DataTableCollection Tables => base.Tables;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public rep_HopDong_Vaccine()
	{
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected rep_HopDong_Vaccine(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = (string)info.GetValue("XmlSchema", typeof(string));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["Table1"] != null)
			{
				base.Tables.Add(new Table1DataTable(dataSet.Tables["Table1"]));
			}
			if (dataSet.Tables["Table2"] != null)
			{
				base.Tables.Add(new Table2DataTable(dataSet.Tables["Table2"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public override DataSet Clone()
	{
		rep_HopDong_Vaccine rep_HopDong_Vaccine2 = (rep_HopDong_Vaccine)base.Clone();
		rep_HopDong_Vaccine2.InitVars();
		rep_HopDong_Vaccine2.SchemaSerializationMode = SchemaSerializationMode;
		return rep_HopDong_Vaccine2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["Table1"] != null)
			{
				base.Tables.Add(new Table1DataTable(dataSet.Tables["Table1"]));
			}
			if (dataSet.Tables["Table2"] != null)
			{
				base.Tables.Add(new Table2DataTable(dataSet.Tables["Table2"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal void InitVars(bool initTable)
	{
		tableTable1 = (Table1DataTable)base.Tables["Table1"];
		if (initTable && tableTable1 != null)
		{
			tableTable1.InitVars();
		}
		tableTable2 = (Table2DataTable)base.Tables["Table2"];
		if (initTable && tableTable2 != null)
		{
			tableTable2.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		base.DataSetName = "rep_HopDong_Vaccine";
		base.Prefix = "";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableTable1 = new Table1DataTable();
		base.Tables.Add(tableTable1);
		tableTable2 = new Table2DataTable();
		base.Tables.Add(tableTable2);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeTable1()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeTable2()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		rep_HopDong_Vaccine rep_HopDong_Vaccine2 = new rep_HopDong_Vaccine();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = rep_HopDong_Vaccine2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = rep_HopDong_Vaccine2.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
