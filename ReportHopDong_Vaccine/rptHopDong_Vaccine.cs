using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;
using ServerShared;

namespace ReportHopDong_Vaccine;

public class rptHopDong_Vaccine : XtraReport, IReport
{
	private DataSet dset = new DataSet();

	private IContainer components = null;

	private DetailBand Detail;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private ReportHeaderBand ReportHeader;

	private rep_HopDong_Vaccine rep_HopDong_Vaccine1;

	private PageFooterBand PageFooter;

	private XRTable xrTable1;

	private XRTableRow xrTableRow1;

	private XRTableCell xrTableCell1;

	private XRLabel xrLabel67;

	private XRLabel xrLabel89;

	private XRLabel xrLabel74;

	private XRLabel xrLabel75;

	private XRLabel xrLabel76;

	private XRLabel xrLabel80;

	private XRLabel xrLabel86;

	private XRLabel xrLabel88;

	private XRLabel xrLabel68;

	private XRPageInfo xrPageInfo2;

	private XRLabel xrLabel85;

	private XRLabel xrLabel84;

	private XRLabel xrLabel82;

	private XRLabel xrLabel81;

	private XRLabel xrLabel79;

	private XRLabel xrLabel78;

	private XRLabel xrLabel77;

	private XRLabel xrLabel73;

	private XRLabel xrLabel72;

	private XRLabel xrLabel71;

	private XRLabel xrLabel70;

	private XRLabel xrLabel69;

	private XRBarCode xrBarCode2;

	private XRLabel xrLabel34;

	private XRLabel xrLabel56;

	private XRLabel xrLabel49;

	private XRLabel xrLabel14;

	private XRLabel xrLabel13;

	private XRLabel xrLabel12;

	private XRLabel xrLabel11;

	private XRLabel xrLabel10;

	private XRLabel xrLabel9;

	private XRLabel xrLabel15;

	private XRLabel xrLabel7;

	private XRLabel xrLabel6;

	private XRLabel xrLabel3;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private XRLabel xrLabel8;

	private XRLabel xrLabel17;

	private XRLabel xrLabel22;

	private XRLabel xrLabel20;

	private XRLabel xrLabel19;

	private XRLabel xrLabel18;

	private XRPictureBox xrPictureBox1;

	private PageHeaderBand PageHeader;

	private XRLabel xrLabel23;

	private XRLabel xrLabel4;

	private XRLabel xrLabel25;

	private XRLabel xrLabel24;

	private XRLabel xrLabel26;

	private XRLabel xrLabel27;

	private XRLabel xrLabel29;

	private XRLabel xrLabel28;

	private XRLabel xrLabel16;

	private XRLabel xrLabel53;

	private XRLabel xrLabel52;

	private XRLabel xrLabel51;

	private XRLabel xrLabel50;

	private XRLabel xrLabel48;

	private XRLabel xrLabel47;

	private XRLabel xrLabel46;

	private XRLabel xrLabel45;

	private XRLabel xrLabel44;

	private XRLabel xrLabel43;

	private XRLabel xrLabel42;

	private XRLabel xrLabel41;

	private XRLabel xrLabel40;

	private XRLabel xrLabel39;

	private XRLabel xrLabel37;

	private XRLabel xrLabel38;

	private XRLabel xrLabel36;

	private XRLabel xrLabel35;

	private XRLabel xrLabel33;

	private XRLabel xrLabel32;

	private XRLabel xrLabel31;

	private XRLabel xrLabel30;

	private XRLabel xrLabel109;

	private XRLabel xrLabel108;

	private XRLabel xrLabel107;

	private XRLabel xrLabel106;

	private XRLabel xrLabel105;

	private XRLabel xrLabel104;

	private XRLabel xrLabel103;

	private XRLabel xrLabel102;

	private XRLabel xrLabel101;

	private XRLabel xrLabel100;

	private XRLabel xrLabel99;

	private XRLabel xrLabel98;

	private XRLabel xrLabel97;

	private XRLabel xrLabel96;

	private XRLabel xrLabel95;

	private XRLabel xrLabel94;

	private XRLabel xrLabel93;

	private XRLabel xrLabel92;

	private XRLabel xrLabel91;

	private XRLabel xrLabel90;

	private XRLabel xrLabel66;

	private XRLabel xrLabel65;

	private XRLabel xrLabel64;

	private XRLabel xrLabel63;

	private XRLabel xrLabel62;

	private XRLabel xrLabel57;

	private XRLabel xrLabel55;

	private XRLabel xrLabel54;

	private ReportFooterBand ReportFooter;

	private XRLabel xrLabel61;

	private XRLabel xrLabel60;

	private XRLabel xrLabel59;

	private XRLabel xrLabel58;

	private XRLabel xrLabel110;

	private XRLabel xrLabel87;

	private XRLabel xrLabel115;

	private XRLabel xrLabel114;

	private XRLabel xrLabel116;

	private XRLabel xrLabel5;

	private XRLabel xrLabel83;

	public rptHopDong_Vaccine()
	{
		InitializeComponent();
	}

	public ReportResult Generate(DataSet ds, string type)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		rep_HopDong_Vaccine rep_HopDong_Vaccine2 = new rep_HopDong_Vaccine();
		DataSetExtensions.ApplyDataSet((DataSet)rep_HopDong_Vaccine2, ds);
		dset = rep_HopDong_Vaccine2;
		base.DataSource = rep_HopDong_Vaccine2;
		MemoryStream memoryStream = new MemoryStream();
		if (type.ToUpper() == "PDF")
		{
			ExportToPdf(memoryStream);
		}
		if (type.ToUpper() == "XLS")
		{
			ExportToXls(memoryStream);
		}
		if (type.ToUpper() == "HTML")
		{
			ExportToHtml(memoryStream);
		}
		if (type.ToUpper() == "REPX")
		{
			CreateDocument();
			base.PrintingSystem.SaveDocument(memoryStream);
		}
		return new ReportResult(type, memoryStream.ToArray());
	}

	private void rptHopDong_Vaccine_BeforePrint(object sender, PrintEventArgs e)
	{
		string s = DataExtensions.FirstRow(dset.Tables[1])["Image"].ToString();
		byte[] buffer = Convert.FromBase64String(s);
		Stream stream = new MemoryStream(buffer);
		Image image = Image.FromStream(stream);
		xrPictureBox1.Image = image;
	}

	private void xrBarCode2_PrintOnPage(object sender, PrintOnPageEventArgs e)
	{
		if (e.PageCount > 0 && e.PageIndex != 0)
		{
			e.Cancel = true;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(rptHopDong_Vaccine));
		Code128Generator code128Generator = new Code128Generator();
		Detail = new DetailBand();
		xrLabel5 = new XRLabel();
		xrLabel116 = new XRLabel();
		xrLabel115 = new XRLabel();
		xrLabel114 = new XRLabel();
		xrLabel110 = new XRLabel();
		xrLabel87 = new XRLabel();
		xrLabel109 = new XRLabel();
		xrLabel108 = new XRLabel();
		xrLabel107 = new XRLabel();
		xrLabel106 = new XRLabel();
		xrLabel105 = new XRLabel();
		xrLabel104 = new XRLabel();
		xrLabel103 = new XRLabel();
		xrLabel102 = new XRLabel();
		xrLabel101 = new XRLabel();
		xrLabel100 = new XRLabel();
		xrLabel99 = new XRLabel();
		xrLabel98 = new XRLabel();
		xrLabel97 = new XRLabel();
		xrLabel96 = new XRLabel();
		xrLabel95 = new XRLabel();
		xrLabel94 = new XRLabel();
		xrLabel93 = new XRLabel();
		xrLabel92 = new XRLabel();
		xrLabel91 = new XRLabel();
		xrLabel90 = new XRLabel();
		xrLabel66 = new XRLabel();
		xrLabel65 = new XRLabel();
		xrLabel64 = new XRLabel();
		xrLabel63 = new XRLabel();
		xrLabel62 = new XRLabel();
		xrLabel57 = new XRLabel();
		xrLabel55 = new XRLabel();
		xrLabel54 = new XRLabel();
		xrLabel53 = new XRLabel();
		xrLabel52 = new XRLabel();
		xrLabel51 = new XRLabel();
		xrLabel50 = new XRLabel();
		xrLabel48 = new XRLabel();
		xrLabel47 = new XRLabel();
		xrLabel46 = new XRLabel();
		xrLabel45 = new XRLabel();
		xrLabel44 = new XRLabel();
		xrLabel43 = new XRLabel();
		xrLabel42 = new XRLabel();
		xrLabel41 = new XRLabel();
		xrLabel40 = new XRLabel();
		xrLabel39 = new XRLabel();
		xrLabel37 = new XRLabel();
		xrLabel38 = new XRLabel();
		xrLabel36 = new XRLabel();
		xrLabel35 = new XRLabel();
		xrLabel33 = new XRLabel();
		xrLabel32 = new XRLabel();
		xrLabel31 = new XRLabel();
		xrLabel30 = new XRLabel();
		xrLabel29 = new XRLabel();
		xrLabel28 = new XRLabel();
		xrLabel16 = new XRLabel();
		xrLabel27 = new XRLabel();
		xrLabel26 = new XRLabel();
		xrLabel25 = new XRLabel();
		xrLabel24 = new XRLabel();
		xrLabel23 = new XRLabel();
		xrLabel85 = new XRLabel();
		xrLabel84 = new XRLabel();
		xrLabel83 = new XRLabel();
		xrLabel82 = new XRLabel();
		xrLabel81 = new XRLabel();
		xrLabel78 = new XRLabel();
		xrLabel77 = new XRLabel();
		xrLabel73 = new XRLabel();
		xrLabel72 = new XRLabel();
		xrLabel71 = new XRLabel();
		xrLabel70 = new XRLabel();
		xrLabel69 = new XRLabel();
		xrLabel56 = new XRLabel();
		xrLabel49 = new XRLabel();
		xrLabel14 = new XRLabel();
		xrLabel13 = new XRLabel();
		xrLabel12 = new XRLabel();
		xrLabel11 = new XRLabel();
		xrLabel10 = new XRLabel();
		xrLabel9 = new XRLabel();
		xrLabel15 = new XRLabel();
		xrLabel7 = new XRLabel();
		xrLabel6 = new XRLabel();
		xrLabel3 = new XRLabel();
		xrLabel2 = new XRLabel();
		xrLabel1 = new XRLabel();
		xrLabel8 = new XRLabel();
		xrLabel17 = new XRLabel();
		xrLabel22 = new XRLabel();
		xrLabel20 = new XRLabel();
		xrLabel19 = new XRLabel();
		xrLabel18 = new XRLabel();
		xrLabel79 = new XRLabel();
		xrLabel34 = new XRLabel();
		xrLabel4 = new XRLabel();
		TopMargin = new TopMarginBand();
		xrBarCode2 = new XRBarCode();
		BottomMargin = new BottomMarginBand();
		ReportHeader = new ReportHeaderBand();
		xrPictureBox1 = new XRPictureBox();
		rep_HopDong_Vaccine1 = new rep_HopDong_Vaccine();
		PageFooter = new PageFooterBand();
		xrPageInfo2 = new XRPageInfo();
		xrTable1 = new XRTable();
		xrTableRow1 = new XRTableRow();
		xrTableCell1 = new XRTableCell();
		xrLabel67 = new XRLabel();
		xrLabel89 = new XRLabel();
		xrLabel74 = new XRLabel();
		xrLabel75 = new XRLabel();
		xrLabel76 = new XRLabel();
		xrLabel80 = new XRLabel();
		xrLabel86 = new XRLabel();
		xrLabel88 = new XRLabel();
		xrLabel68 = new XRLabel();
		PageHeader = new PageHeaderBand();
		ReportFooter = new ReportFooterBand();
		xrLabel61 = new XRLabel();
		xrLabel60 = new XRLabel();
		xrLabel59 = new XRLabel();
		xrLabel58 = new XRLabel();
		((ISupportInitialize)rep_HopDong_Vaccine1).BeginInit();
		((ISupportInitialize)xrTable1).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[100]
		{
			xrLabel5, xrLabel116, xrLabel115, xrLabel114, xrLabel110, xrLabel87, xrLabel109, xrLabel108, xrLabel107, xrLabel106,
			xrLabel105, xrLabel104, xrLabel103, xrLabel102, xrLabel101, xrLabel100, xrLabel99, xrLabel98, xrLabel97, xrLabel96,
			xrLabel95, xrLabel94, xrLabel93, xrLabel92, xrLabel91, xrLabel90, xrLabel66, xrLabel65, xrLabel64, xrLabel63,
			xrLabel62, xrLabel57, xrLabel55, xrLabel54, xrLabel53, xrLabel52, xrLabel51, xrLabel50, xrLabel48, xrLabel47,
			xrLabel46, xrLabel45, xrLabel44, xrLabel43, xrLabel42, xrLabel41, xrLabel40, xrLabel39, xrLabel37, xrLabel38,
			xrLabel36, xrLabel35, xrLabel33, xrLabel32, xrLabel31, xrLabel30, xrLabel29, xrLabel28, xrLabel16, xrLabel27,
			xrLabel26, xrLabel25, xrLabel24, xrLabel23, xrLabel85, xrLabel84, xrLabel83, xrLabel82, xrLabel81, xrLabel78,
			xrLabel77, xrLabel73, xrLabel72, xrLabel71, xrLabel70, xrLabel69, xrLabel56, xrLabel49, xrLabel14, xrLabel13,
			xrLabel12, xrLabel11, xrLabel10, xrLabel9, xrLabel15, xrLabel7, xrLabel6, xrLabel3, xrLabel2, xrLabel1,
			xrLabel8, xrLabel17, xrLabel22, xrLabel20, xrLabel19, xrLabel18, xrLabel79, xrLabel34, xrLabel4, xrBarCode2
		});
		Detail.HeightF = 1276.667f;
		Detail.Name = "Detail";
		Detail.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		Detail.TextAlignment = TextAlignment.TopLeft;
		xrLabel5.Font = new Font("Times New Roman", 11.5f);
		xrLabel5.LocationFloat = new PointFloat(413.9185f, 270.6667f);
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.SizeF = new SizeF(70.58322f, 25f);
		xrLabel5.StylePriority.UseFont = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.Text = "Chức vụ: ";
		xrLabel5.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel116.Font = new Font("Times New Roman", 11.5f);
		xrLabel116.LocationFloat = new PointFloat(0.3751119f, 178.6667f);
		xrLabel116.Multiline = true;
		xrLabel116.Name = "xrLabel116";
		xrLabel116.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel116.SizeF = new SizeF(229.0208f, 22f);
		xrLabel116.StylePriority.UseFont = false;
		xrLabel116.StylePriority.UseTextAlignment = false;
		xrLabel116.Text = "Mã số doanh nghiệp/ mã số thuế: ";
		xrLabel116.TextAlignment = TextAlignment.TopLeft;
		xrLabel115.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.Fax", "Fax: {0}")
		});
		xrLabel115.Font = new Font("Times New Roman", 11.5f);
		xrLabel115.LocationFloat = new PointFloat(374.0417f, 223.6667f);
		xrLabel115.Name = "xrLabel115";
		xrLabel115.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel115.SizeF = new SizeF(375.9388f, 25f);
		xrLabel115.StylePriority.UseFont = false;
		xrLabel115.StylePriority.UseTextAlignment = false;
		xrLabel115.Text = "xrLabel115";
		xrLabel115.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel114.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.VNVCPhone", "Điện thoại: {0}")
		});
		xrLabel114.Font = new Font("Times New Roman", 11.5f);
		xrLabel114.LocationFloat = new PointFloat(0f, 223.6667f);
		xrLabel114.Name = "xrLabel114";
		xrLabel114.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel114.SizeF = new SizeF(374.0418f, 25f);
		xrLabel114.StylePriority.UseFont = false;
		xrLabel114.StylePriority.UseTextAlignment = false;
		xrLabel114.Text = "xrLabel114";
		xrLabel114.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel110.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.ChucVu")
		});
		xrLabel110.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel110.LocationFloat = new PointFloat(484.5018f, 270.6667f);
		xrLabel110.Name = "xrLabel110";
		xrLabel110.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel110.SizeF = new SizeF(266.2698f, 25f);
		xrLabel110.StylePriority.UseFont = false;
		xrLabel110.StylePriority.UseTextAlignment = false;
		xrLabel110.Text = "xrLabel110";
		xrLabel110.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel87.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.NguoiDaiDien")
		});
		xrLabel87.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel87.LocationFloat = new PointFloat(107.313f, 270.6667f);
		xrLabel87.Name = "xrLabel87";
		xrLabel87.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel87.SizeF = new SizeF(306.6054f, 25f);
		xrLabel87.StylePriority.UseFont = false;
		xrLabel87.StylePriority.UseTextAlignment = false;
		xrLabel87.Text = "xrLabel87";
		xrLabel87.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel109.Font = new Font("Times New Roman", 11.5f);
		xrLabel109.LocationFloat = new PointFloat(34.60468f, 1192.375f);
		xrLabel109.Name = "xrLabel109";
		xrLabel109.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel109.SizeF = new SizeF(711.4581f, 23f);
		xrLabel109.StylePriority.UseFont = false;
		xrLabel109.StylePriority.UseTextAlignment = false;
		xrLabel109.Text = componentResourceManager.GetString("xrLabel109.Text");
		xrLabel109.TextAlignment = TextAlignment.TopJustify;
		xrLabel108.Font = new Font("Times New Roman", 11.5f);
		xrLabel108.LocationFloat = new PointFloat(35.3132f, 1244.375f);
		xrLabel108.Name = "xrLabel108";
		xrLabel108.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel108.SizeF = new SizeF(711.4581f, 23f);
		xrLabel108.StylePriority.UseFont = false;
		xrLabel108.StylePriority.UseTextAlignment = false;
		xrLabel108.Text = "Bản xác nhận này được lập thành 02 (hai) bản có giá trị pháp lý như nhau, mỗi Bên giữ 01 (một) bản.";
		xrLabel108.TextAlignment = TextAlignment.TopJustify;
		xrLabel107.Font = new Font("Times New Roman", 11.5f);
		xrLabel107.LocationFloat = new PointFloat(0f, 1244.375f);
		xrLabel107.Name = "xrLabel107";
		xrLabel107.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel107.SizeF = new SizeF(34.375f, 23f);
		xrLabel107.StylePriority.UseFont = false;
		xrLabel107.Text = "7. ";
		xrLabel106.Font = new Font("Times New Roman", 11.5f);
		xrLabel106.LocationFloat = new PointFloat(0f, 1218.375f);
		xrLabel106.Name = "xrLabel106";
		xrLabel106.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel106.SizeF = new SizeF(34.375f, 23f);
		xrLabel106.StylePriority.UseFont = false;
		xrLabel106.Text = "6. ";
		xrLabel105.Font = new Font("Times New Roman", 11.5f);
		xrLabel105.LocationFloat = new PointFloat(34.60494f, 1218.375f);
		xrLabel105.Name = "xrLabel105";
		xrLabel105.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel105.SizeF = new SizeF(711.4581f, 23f);
		xrLabel105.StylePriority.UseFont = false;
		xrLabel105.StylePriority.UseTextAlignment = false;
		xrLabel105.Text = "Bản xác nhận này có hiệu lực kể từ ngày hai Bên ký bản xác nhận này và Bên B đã thanh toán phí dịch vụ theo quy định trong bản xác nhận này.";
		xrLabel105.TextAlignment = TextAlignment.TopJustify;
		xrLabel104.Font = new Font("Times New Roman", 11.5f);
		xrLabel104.LocationFloat = new PointFloat(0f, 1192.375f);
		xrLabel104.Name = "xrLabel104";
		xrLabel104.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel104.SizeF = new SizeF(34.375f, 23f);
		xrLabel104.StylePriority.UseFont = false;
		xrLabel104.Text = "5. ";
		xrLabel103.Font = new Font("Times New Roman", 11.5f);
		xrLabel103.LocationFloat = new PointFloat(72.60462f, 1114.125f);
		xrLabel103.Name = "xrLabel103";
		xrLabel103.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel103.SizeF = new SizeF(675.0213f, 23f);
		xrLabel103.StylePriority.UseFont = false;
		xrLabel103.StylePriority.UseTextAlignment = false;
		xrLabel103.Text = "Bên B thanh toán phí dịch vụ cho Bên A bằng tiền Việt Nam đồng bằng tiền mặt hoặc chuyển khoản vào tài khoản của Bên A. ";
		xrLabel103.TextAlignment = TextAlignment.TopJustify;
		xrLabel102.Font = new Font("Times New Roman", 11.5f);
		xrLabel102.LocationFloat = new PointFloat(73.31314f, 1166.125f);
		xrLabel102.Name = "xrLabel102";
		xrLabel102.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel102.SizeF = new SizeF(673.7498f, 23f);
		xrLabel102.StylePriority.UseFont = false;
		xrLabel102.StylePriority.UseTextAlignment = false;
		xrLabel102.Text = componentResourceManager.GetString("xrLabel102.Text");
		xrLabel102.TextAlignment = TextAlignment.TopJustify;
		xrLabel101.Font = new Font("Times New Roman", 11.5f);
		xrLabel101.LocationFloat = new PointFloat(38f, 1166.125f);
		xrLabel101.Name = "xrLabel101";
		xrLabel101.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel101.SizeF = new SizeF(34.375f, 23f);
		xrLabel101.StylePriority.UseFont = false;
		xrLabel101.Text = "c. ";
		xrLabel100.Font = new Font("Times New Roman", 11.5f);
		xrLabel100.LocationFloat = new PointFloat(38f, 1140.125f);
		xrLabel100.Name = "xrLabel100";
		xrLabel100.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel100.SizeF = new SizeF(34.375f, 23f);
		xrLabel100.StylePriority.UseFont = false;
		xrLabel100.Text = "b. ";
		xrLabel99.Font = new Font("Times New Roman", 11.5f);
		xrLabel99.LocationFloat = new PointFloat(72.60488f, 1140.125f);
		xrLabel99.Name = "xrLabel99";
		xrLabel99.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel99.SizeF = new SizeF(675.0212f, 23f);
		xrLabel99.StylePriority.UseFont = false;
		xrLabel99.StylePriority.UseTextAlignment = false;
		xrLabel99.Text = "Bên B thanh toán 100% phí dịch vụ cho Bên A ngay khi ký bản xác nhận này.";
		xrLabel99.TextAlignment = TextAlignment.TopJustify;
		xrLabel98.Font = new Font("Times New Roman", 11.5f);
		xrLabel98.LocationFloat = new PointFloat(38f, 1114.125f);
		xrLabel98.Name = "xrLabel98";
		xrLabel98.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel98.SizeF = new SizeF(34.375f, 23f);
		xrLabel98.StylePriority.UseFont = false;
		xrLabel98.Text = "a. ";
		xrLabel97.Font = new Font("Times New Roman", 11.5f);
		xrLabel97.LocationFloat = new PointFloat(1f, 1087.708f);
		xrLabel97.Name = "xrLabel97";
		xrLabel97.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel97.SizeF = new SizeF(34.375f, 23f);
		xrLabel97.StylePriority.UseFont = false;
		xrLabel97.Text = "4. ";
		xrLabel96.Font = new Font("Times New Roman", 11.5f);
		xrLabel96.LocationFloat = new PointFloat(35.4582f, 1087.708f);
		xrLabel96.Name = "xrLabel96";
		xrLabel96.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel96.SizeF = new SizeF(711.4581f, 23f);
		xrLabel96.StylePriority.UseFont = false;
		xrLabel96.StylePriority.UseTextAlignment = false;
		xrLabel96.Text = "Hình thức, thời hạn, điều kiện thanh toán:";
		xrLabel96.TextAlignment = TextAlignment.TopJustify;
		xrLabel95.Font = new Font("Times New Roman", 11.5f);
		xrLabel95.LocationFloat = new PointFloat(72.45966f, 957.6251f);
		xrLabel95.Name = "xrLabel95";
		xrLabel95.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel95.SizeF = new SizeF(673.7499f, 23f);
		xrLabel95.StylePriority.UseFont = false;
		xrLabel95.StylePriority.UseTextAlignment = false;
		xrLabel95.Text = "Tuân thủ các quy trình, tiêu chuẩn của Bộ Y tế và các quy định pháp luật có liên quan trong quá trình cung cấp dịch vụ cho Bên B.";
		xrLabel95.TextAlignment = TextAlignment.TopJustify;
		xrLabel94.Font = new Font("Times New Roman", 11.5f);
		xrLabel94.LocationFloat = new PointFloat(38f, 1061.708f);
		xrLabel94.Name = "xrLabel94";
		xrLabel94.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel94.SizeF = new SizeF(34.375f, 23f);
		xrLabel94.StylePriority.UseFont = false;
		xrLabel94.Text = "e. ";
		xrLabel93.Font = new Font("Times New Roman", 11.5f);
		xrLabel93.LocationFloat = new PointFloat(73.31314f, 1035.667f);
		xrLabel93.Name = "xrLabel93";
		xrLabel93.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel93.SizeF = new SizeF(673.7499f, 23f);
		xrLabel93.StylePriority.UseFont = false;
		xrLabel93.StylePriority.UseTextAlignment = false;
		xrLabel93.Text = componentResourceManager.GetString("xrLabel93.Text");
		xrLabel93.TextAlignment = TextAlignment.TopJustify;
		xrLabel92.Font = new Font("Times New Roman", 11.5f);
		xrLabel92.LocationFloat = new PointFloat(38f, 1035.667f);
		xrLabel92.Name = "xrLabel92";
		xrLabel92.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel92.SizeF = new SizeF(34.375f, 23f);
		xrLabel92.StylePriority.UseFont = false;
		xrLabel92.Text = "d. ";
		xrLabel91.Font = new Font("Times New Roman", 11.5f);
		xrLabel91.LocationFloat = new PointFloat(73.16818f, 1009.625f);
		xrLabel91.Name = "xrLabel91";
		xrLabel91.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel91.SizeF = new SizeF(673.7498f, 23f);
		xrLabel91.StylePriority.UseFont = false;
		xrLabel91.StylePriority.UseTextAlignment = false;
		xrLabel91.Text = "Làm hết khả năng trong phạm vi chuyên môn để đảm bảo chất lượng dịch vụ cung cấp cho Bên B theo bản xác nhận này.";
		xrLabel91.TextAlignment = TextAlignment.TopJustify;
		xrLabel90.Font = new Font("Times New Roman", 11.5f);
		xrLabel90.LocationFloat = new PointFloat(38f, 1009.625f);
		xrLabel90.Name = "xrLabel90";
		xrLabel90.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel90.SizeF = new SizeF(34.375f, 23f);
		xrLabel90.StylePriority.UseFont = false;
		xrLabel90.Text = "c. ";
		xrLabel66.Font = new Font("Times New Roman", 11.5f);
		xrLabel66.LocationFloat = new PointFloat(38f, 983.625f);
		xrLabel66.Name = "xrLabel66";
		xrLabel66.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel66.SizeF = new SizeF(34.375f, 23f);
		xrLabel66.StylePriority.UseFont = false;
		xrLabel66.Text = "b. ";
		xrLabel65.Font = new Font("Times New Roman", 11.5f);
		xrLabel65.LocationFloat = new PointFloat(72.45992f, 983.6251f);
		xrLabel65.Name = "xrLabel65";
		xrLabel65.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel65.SizeF = new SizeF(673.7499f, 22.99994f);
		xrLabel65.StylePriority.UseFont = false;
		xrLabel65.StylePriority.UseTextAlignment = false;
		xrLabel65.Text = "Thực hiện kiểm tra sàng lọc trước và sau tiêm chủng nhằm đảm bảo an toàn cho người được tiêm chủng theo quy định của Bộ Y tế và các quy định pháp luật có liên quan.";
		xrLabel65.TextAlignment = TextAlignment.TopJustify;
		xrLabel64.Font = new Font("Times New Roman", 11.5f);
		xrLabel64.LocationFloat = new PointFloat(38f, 957.625f);
		xrLabel64.Name = "xrLabel64";
		xrLabel64.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel64.SizeF = new SizeF(34.375f, 23f);
		xrLabel64.StylePriority.UseFont = false;
		xrLabel64.Text = "a. ";
		xrLabel63.Font = new Font("Times New Roman", 11.5f);
		xrLabel63.LocationFloat = new PointFloat(73.31314f, 1061.708f);
		xrLabel63.Name = "xrLabel63";
		xrLabel63.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel63.SizeF = new SizeF(673.7499f, 23.00012f);
		xrLabel63.StylePriority.UseFont = false;
		xrLabel63.StylePriority.UseTextAlignment = false;
		xrLabel63.Text = "Được nhận phí dịch vụ đúng và đầy đủ theo quy định trong bản xác nhận này.";
		xrLabel63.TextAlignment = TextAlignment.TopJustify;
		xrLabel62.Font = new Font("Times New Roman", 11.5f);
		xrLabel62.LocationFloat = new PointFloat(1f, 931.2083f);
		xrLabel62.Name = "xrLabel62";
		xrLabel62.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel62.SizeF = new SizeF(34.375f, 23f);
		xrLabel62.StylePriority.UseFont = false;
		xrLabel62.Text = "3. ";
		xrLabel57.Font = new Font("Times New Roman", 11.5f);
		xrLabel57.LocationFloat = new PointFloat(36.3132f, 931.2083f);
		xrLabel57.Name = "xrLabel57";
		xrLabel57.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel57.SizeF = new SizeF(711.4581f, 23f);
		xrLabel57.StylePriority.UseFont = false;
		xrLabel57.StylePriority.UseTextAlignment = false;
		xrLabel57.Text = "Các quyền và nghĩa vụ của Bên A:";
		xrLabel57.TextAlignment = TextAlignment.TopJustify;
		xrLabel55.Font = new Font("Times New Roman", 11.5f);
		xrLabel55.LocationFloat = new PointFloat(38.77097f, 905.2083f);
		xrLabel55.Name = "xrLabel55";
		xrLabel55.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel55.SizeF = new SizeF(34.375f, 23f);
		xrLabel55.StylePriority.UseFont = false;
		xrLabel55.Text = "h. ";
		xrLabel54.Font = new Font("Times New Roman", 11.5f);
		xrLabel54.LocationFloat = new PointFloat(73.3757f, 905.2083f);
		xrLabel54.Name = "xrLabel54";
		xrLabel54.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel54.SizeF = new SizeF(675.1672f, 23f);
		xrLabel54.StylePriority.UseFont = false;
		xrLabel54.StylePriority.UseTextAlignment = false;
		xrLabel54.Text = "Thanh toán phí dịch vụ cho Bên A đúng và đầy đủ theo quy định trong bản xác nhận này.";
		xrLabel54.TextAlignment = TextAlignment.TopJustify;
		xrLabel53.Font = new Font("Times New Roman", 11.5f);
		xrLabel53.LocationFloat = new PointFloat(38.77097f, 878.125f);
		xrLabel53.Name = "xrLabel53";
		xrLabel53.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel53.SizeF = new SizeF(34.375f, 23f);
		xrLabel53.StylePriority.UseFont = false;
		xrLabel53.Text = "g. ";
		xrLabel52.Font = new Font("Times New Roman", 11.5f);
		xrLabel52.LocationFloat = new PointFloat(73.37595f, 878.125f);
		xrLabel52.Name = "xrLabel52";
		xrLabel52.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel52.SizeF = new SizeF(675.1671f, 23f);
		xrLabel52.StylePriority.UseFont = false;
		xrLabel52.StylePriority.UseTextAlignment = false;
		xrLabel52.Text = "Tuân thủ đúng và đầy đủ các hướng dẫn, quy định của Bên A trong quá trình sử dụng dịch vụ. Thực hiện đúng các bước trước và sau tiêm chủng theo quy trình, quy định chuyên môn của Bên A. ";
		xrLabel52.TextAlignment = TextAlignment.TopJustify;
		xrLabel51.Font = new Font("Times New Roman", 11.5f);
		xrLabel51.LocationFloat = new PointFloat(38.77097f, 852.125f);
		xrLabel51.Name = "xrLabel51";
		xrLabel51.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel51.SizeF = new SizeF(34.375f, 23f);
		xrLabel51.StylePriority.UseFont = false;
		xrLabel51.Text = "f. ";
		xrLabel50.Font = new Font("Times New Roman", 11.5f);
		xrLabel50.LocationFloat = new PointFloat(73.3757f, 852.1251f);
		xrLabel50.Name = "xrLabel50";
		xrLabel50.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel50.SizeF = new SizeF(675.1672f, 23f);
		xrLabel50.StylePriority.UseFont = false;
		xrLabel50.StylePriority.UseTextAlignment = false;
		xrLabel50.Text = "Cung cấp đầy đủ các thông tin cần thiết theo yêu cầu của Bên A và đảm bảo tính chính xác của các thông tin đã cung cấp.";
		xrLabel50.TextAlignment = TextAlignment.TopJustify;
		xrLabel48.Font = new Font("Times New Roman", 11.5f);
		xrLabel48.LocationFloat = new PointFloat(107.313f, 826.1251f);
		xrLabel48.Name = "xrLabel48";
		xrLabel48.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel48.SizeF = new SizeF(640.5215f, 23f);
		xrLabel48.StylePriority.UseFont = false;
		xrLabel48.StylePriority.UseTextAlignment = false;
		xrLabel48.Text = "CMND người sử dụng dịch vụ";
		xrLabel48.TextAlignment = TextAlignment.TopJustify;
		xrLabel47.Font = new Font("Times New Roman", 11.5f);
		xrLabel47.LocationFloat = new PointFloat(72f, 826.125f);
		xrLabel47.Name = "xrLabel47";
		xrLabel47.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel47.SizeF = new SizeF(34.375f, 23f);
		xrLabel47.StylePriority.UseFont = false;
		xrLabel47.Text = "-";
		xrLabel46.Font = new Font("Times New Roman", 11.5f);
		xrLabel46.LocationFloat = new PointFloat(107.313f, 800.125f);
		xrLabel46.Name = "xrLabel46";
		xrLabel46.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel46.SizeF = new SizeF(640.5216f, 23f);
		xrLabel46.StylePriority.UseFont = false;
		xrLabel46.StylePriority.UseTextAlignment = false;
		xrLabel46.Text = "Biên lai thu tiền";
		xrLabel46.TextAlignment = TextAlignment.TopJustify;
		xrLabel45.Font = new Font("Times New Roman", 11.5f);
		xrLabel45.LocationFloat = new PointFloat(72f, 800.125f);
		xrLabel45.Name = "xrLabel45";
		xrLabel45.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel45.SizeF = new SizeF(34.375f, 23f);
		xrLabel45.StylePriority.UseFont = false;
		xrLabel45.Text = "-";
		xrLabel44.Font = new Font("Times New Roman", 11.5f);
		xrLabel44.LocationFloat = new PointFloat(107.313f, 774.125f);
		xrLabel44.Name = "xrLabel44";
		xrLabel44.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel44.SizeF = new SizeF(640.5216f, 23f);
		xrLabel44.StylePriority.UseFont = false;
		xrLabel44.StylePriority.UseTextAlignment = false;
		xrLabel44.Text = "Sổ tiêm chủng";
		xrLabel44.TextAlignment = TextAlignment.TopJustify;
		xrLabel43.Font = new Font("Times New Roman", 11.5f);
		xrLabel43.LocationFloat = new PointFloat(72f, 774.125f);
		xrLabel43.Name = "xrLabel43";
		xrLabel43.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel43.SizeF = new SizeF(34.375f, 23f);
		xrLabel43.StylePriority.UseFont = false;
		xrLabel43.Text = "-";
		xrLabel42.Font = new Font("Times New Roman", 11.5f);
		xrLabel42.LocationFloat = new PointFloat(73.3757f, 748.0833f);
		xrLabel42.Name = "xrLabel42";
		xrLabel42.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel42.SizeF = new SizeF(674.312f, 23f);
		xrLabel42.StylePriority.UseFont = false;
		xrLabel42.StylePriority.UseTextAlignment = false;
		xrLabel42.Text = "Được sử dụng dịch vụ tiêm chủng tại tất cả các Trung tâm tiêm chủng trực thuộc Bên A trên lãnh thổ Việt Nam khi xuất trình đầy đủ các giấy tờ sau:";
		xrLabel42.TextAlignment = TextAlignment.TopJustify;
		xrLabel41.Font = new Font("Times New Roman", 11.5f);
		xrLabel41.LocationFloat = new PointFloat(37.39527f, 748.0833f);
		xrLabel41.Name = "xrLabel41";
		xrLabel41.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel41.SizeF = new SizeF(34.375f, 23f);
		xrLabel41.StylePriority.UseFont = false;
		xrLabel41.Text = "e. ";
		xrLabel40.Font = new Font("Times New Roman", 11.5f);
		xrLabel40.LocationFloat = new PointFloat(72.70838f, 722.0416f);
		xrLabel40.Name = "xrLabel40";
		xrLabel40.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel40.SizeF = new SizeF(674.9794f, 23f);
		xrLabel40.StylePriority.UseFont = false;
		xrLabel40.StylePriority.UseTextAlignment = false;
		xrLabel40.Text = "Được nhắc lịch tiêm miễn phí.";
		xrLabel40.TextAlignment = TextAlignment.TopJustify;
		xrLabel39.Font = new Font("Times New Roman", 11.5f);
		xrLabel39.LocationFloat = new PointFloat(37.39527f, 722.0416f);
		xrLabel39.Name = "xrLabel39";
		xrLabel39.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel39.SizeF = new SizeF(34.375f, 23f);
		xrLabel39.StylePriority.UseFont = false;
		xrLabel39.Text = "d. ";
		xrLabel37.Font = new Font("Times New Roman", 11.5f);
		xrLabel37.LocationFloat = new PointFloat(72.70838f, 696f);
		xrLabel37.Name = "xrLabel37";
		xrLabel37.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel37.SizeF = new SizeF(675.8344f, 23f);
		xrLabel37.StylePriority.UseFont = false;
		xrLabel37.StylePriority.UseTextAlignment = false;
		xrLabel37.Text = "Được miễn phí khám và tư vấn về tiêm chủng trước khi tiêm.";
		xrLabel37.TextAlignment = TextAlignment.TopJustify;
		xrLabel38.Font = new Font("Times New Roman", 11.5f);
		xrLabel38.LocationFloat = new PointFloat(37.39527f, 696f);
		xrLabel38.Name = "xrLabel38";
		xrLabel38.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel38.SizeF = new SizeF(34.375f, 23f);
		xrLabel38.StylePriority.UseFont = false;
		xrLabel38.Text = "c. ";
		xrLabel36.Font = new Font("Times New Roman", 11.5f);
		xrLabel36.LocationFloat = new PointFloat(37.39527f, 670f);
		xrLabel36.Name = "xrLabel36";
		xrLabel36.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel36.SizeF = new SizeF(34.375f, 23f);
		xrLabel36.StylePriority.UseFont = false;
		xrLabel36.Text = "b. ";
		xrLabel35.Font = new Font("Times New Roman", 11.5f);
		xrLabel35.LocationFloat = new PointFloat(72.00037f, 670f);
		xrLabel35.Name = "xrLabel35";
		xrLabel35.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel35.SizeF = new SizeF(675.8344f, 23f);
		xrLabel35.StylePriority.UseFont = false;
		xrLabel35.StylePriority.UseTextAlignment = false;
		xrLabel35.Text = "Được giữ nguyên giá/ phí dịch vụ trong trường hợp thị trường có biến động về giá.";
		xrLabel35.TextAlignment = TextAlignment.TopJustify;
		xrLabel33.Font = new Font("Times New Roman", 11.5f);
		xrLabel33.LocationFloat = new PointFloat(37.39527f, 644f);
		xrLabel33.Name = "xrLabel33";
		xrLabel33.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel33.SizeF = new SizeF(34.375f, 23f);
		xrLabel33.StylePriority.UseFont = false;
		xrLabel33.Text = "a. ";
		xrLabel32.Font = new Font("Times New Roman", 11.5f);
		xrLabel32.LocationFloat = new PointFloat(72.00012f, 644f);
		xrLabel32.Name = "xrLabel32";
		xrLabel32.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel32.SizeF = new SizeF(675.8344f, 23f);
		xrLabel32.StylePriority.UseFont = false;
		xrLabel32.StylePriority.UseTextAlignment = false;
		xrLabel32.Text = "Được cung cấp dịch vụ tuân thủ theo quy trình, tiêu chuẩn của Bộ Y tế và quy định của pháp luật.";
		xrLabel32.TextAlignment = TextAlignment.TopJustify;
		xrLabel31.Font = new Font("Times New Roman", 11.5f);
		xrLabel31.LocationFloat = new PointFloat(1f, 618f);
		xrLabel31.Name = "xrLabel31";
		xrLabel31.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel31.SizeF = new SizeF(34.375f, 23f);
		xrLabel31.StylePriority.UseFont = false;
		xrLabel31.Text = "2. ";
		xrLabel30.Font = new Font("Times New Roman", 11.5f);
		xrLabel30.LocationFloat = new PointFloat(35.60473f, 618f);
		xrLabel30.Name = "xrLabel30";
		xrLabel30.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel30.SizeF = new SizeF(711.4581f, 23f);
		xrLabel30.StylePriority.UseFont = false;
		xrLabel30.StylePriority.UseTextAlignment = false;
		xrLabel30.Text = "Các quyền và nghĩa vụ của Bên B:";
		xrLabel30.TextAlignment = TextAlignment.TopJustify;
		xrLabel29.Font = new Font("Times New Roman", 11.5f);
		xrLabel29.LocationFloat = new PointFloat(1f, 591.9999f);
		xrLabel29.Name = "xrLabel29";
		xrLabel29.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel29.SizeF = new SizeF(34.375f, 23f);
		xrLabel29.StylePriority.UseFont = false;
		xrLabel29.Text = "1. ";
		xrLabel28.Font = new Font("Times New Roman", 11.5f);
		xrLabel28.LocationFloat = new PointFloat(36.3132f, 592f);
		xrLabel28.Name = "xrLabel28";
		xrLabel28.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel28.SizeF = new SizeF(711.4581f, 23f);
		xrLabel28.StylePriority.UseFont = false;
		xrLabel28.StylePriority.UseTextAlignment = false;
		xrLabel28.Text = componentResourceManager.GetString("xrLabel28.Text");
		xrLabel28.TextAlignment = TextAlignment.TopJustify;
		xrLabel16.Font = new Font("Times New Roman", 11.5f);
		xrLabel16.LocationFloat = new PointFloat(35.31295f, 563.875f);
		xrLabel16.Name = "xrLabel16";
		xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel16.SizeF = new SizeF(712.3133f, 23f);
		xrLabel16.StylePriority.UseFont = false;
		xrLabel16.StylePriority.UseTextAlignment = false;
		xrLabel16.Text = "Hai Bên xác nhận nội dung cung cấp và sử dụng dịch vụ gói tiêm chủng vaccine như sau:";
		xrLabel16.TextAlignment = TextAlignment.TopJustify;
		xrLabel27.Font = new Font("Times New Roman", 11.5f);
		xrLabel27.LocationFloat = new PointFloat(0f, 295.6667f);
		xrLabel27.Name = "xrLabel27";
		xrLabel27.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel27.SizeF = new SizeF(192.8744f, 21.99997f);
		xrLabel27.StylePriority.UseFont = false;
		xrLabel27.Text = "(Sau đây gọi tắt là Bên A).";
		xrLabel26.Font = new Font("Times New Roman", 11.5f);
		xrLabel26.LocationFloat = new PointFloat(0.3751119f, 270.6667f);
		xrLabel26.Name = "xrLabel26";
		xrLabel26.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel26.SizeF = new SizeF(105.9999f, 25f);
		xrLabel26.StylePriority.UseFont = false;
		xrLabel26.StylePriority.UseTextAlignment = false;
		xrLabel26.Text = "Người đại diện:";
		xrLabel26.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel25.Font = new Font("Times New Roman", 11.5f);
		xrLabel25.LocationFloat = new PointFloat(0.3751831f, 248.6667f);
		xrLabel25.Name = "xrLabel25";
		xrLabel25.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel25.SizeF = new SizeF(751.6248f, 22f);
		xrLabel25.StylePriority.UseFont = false;
		xrLabel25.Text = "Số tài khoản:........................................, tại Ngân hàng:..................................................................................................";
		xrLabel24.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.TAX", "{0}")
		});
		xrLabel24.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel24.LocationFloat = new PointFloat(229.3961f, 178.6667f);
		xrLabel24.Multiline = true;
		xrLabel24.Name = "xrLabel24";
		xrLabel24.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel24.SizeF = new SizeF(520.1465f, 22f);
		xrLabel24.StylePriority.UseFont = false;
		xrLabel24.StylePriority.UseTextAlignment = false;
		xrLabel24.Text = "xrLabel24";
		xrLabel24.TextAlignment = TextAlignment.TopLeft;
		xrLabel23.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.NameofTT")
		});
		xrLabel23.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel23.LocationFloat = new PointFloat(0f, 156.6667f);
		xrLabel23.Multiline = true;
		xrLabel23.Name = "xrLabel23";
		xrLabel23.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel23.SizeF = new SizeF(752f, 22.00002f);
		xrLabel23.StylePriority.UseFont = false;
		xrLabel23.StylePriority.UseTextAlignment = false;
		xrLabel23.Text = "xrLabel23";
		xrLabel23.TextAlignment = TextAlignment.TopLeft;
		xrLabel85.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.QuocTich_NguoiTiem")
		});
		xrLabel85.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel85.LocationFloat = new PointFloat(597.5193f, 509.5f);
		xrLabel85.Name = "xrLabel85";
		xrLabel85.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel85.SizeF = new SizeF(151.4807f, 22.99997f);
		xrLabel85.StylePriority.UseFont = false;
		xrLabel85.Text = "xrLabel85";
		xrLabel84.Font = new Font("Times New Roman", 11.5f);
		xrLabel84.LocationFloat = new PointFloat(366.4771f, 509.4999f);
		xrLabel84.Name = "xrLabel84";
		xrLabel84.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel84.SizeF = new SizeF(75f, 23f);
		xrLabel84.StylePriority.UseFont = false;
		xrLabel84.Text = "Ngày sinh:";
		xrLabel83.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.DTDD_NguoiDKy")
		});
		xrLabel83.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel83.LocationFloat = new PointFloat(80.99991f, 459.4999f);
		xrLabel83.Name = "xrLabel83";
		xrLabel83.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel83.SizeF = new SizeF(667.9999f, 22.99988f);
		xrLabel83.StylePriority.UseFont = false;
		xrLabel83.Text = "xrLabel83";
		xrLabel82.Font = new Font("Times New Roman", 11.5f);
		xrLabel82.LocationFloat = new PointFloat(1.000038f, 436.4998f);
		xrLabel82.Name = "xrLabel82";
		xrLabel82.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel82.SizeF = new SizeF(110f, 23.00003f);
		xrLabel82.StylePriority.UseFont = false;
		xrLabel82.Text = "Địa chỉ liên lạc:";
		xrLabel81.Font = new Font("Times New Roman", 11.5f);
		xrLabel81.LocationFloat = new PointFloat(1.000038f, 459.4999f);
		xrLabel81.Name = "xrLabel81";
		xrLabel81.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel81.SizeF = new SizeF(80f, 23f);
		xrLabel81.StylePriority.UseFont = false;
		xrLabel81.Text = "Điện thoại: ";
		xrLabel78.Font = new Font("Times New Roman", 11.5f);
		xrLabel78.LocationFloat = new PointFloat(1.000038f, 410.4998f);
		xrLabel78.Name = "xrLabel78";
		xrLabel78.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel78.SizeF = new SizeF(130f, 22.99997f);
		xrLabel78.StylePriority.UseFont = false;
		xrLabel78.Text = "Địa chỉ thường trú:";
		xrLabel77.Font = new Font("Times New Roman", 11.5f);
		xrLabel77.LocationFloat = new PointFloat(0.3751068f, 509.4999f);
		xrLabel77.Name = "xrLabel77";
		xrLabel77.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel77.SizeF = new SizeF(75f, 23f);
		xrLabel77.StylePriority.UseFont = false;
		xrLabel77.Text = "Họ và tên:";
		xrLabel73.Font = new Font("Times New Roman", 11.5f);
		xrLabel73.LocationFloat = new PointFloat(357.7484f, 358.2916f);
		xrLabel73.Name = "xrLabel73";
		xrLabel73.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel73.SizeF = new SizeF(75f, 23f);
		xrLabel73.StylePriority.UseFont = false;
		xrLabel73.Text = "Ngày sinh:";
		xrLabel72.Font = new Font("Times New Roman", 11.5f);
		xrLabel72.LocationFloat = new PointFloat(0.9999593f, 358.2916f);
		xrLabel72.Name = "xrLabel72";
		xrLabel72.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel72.SizeF = new SizeF(72.37572f, 22f);
		xrLabel72.StylePriority.UseFont = false;
		xrLabel72.Text = "Họ và tên:";
		xrLabel71.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.QuocTich_NguoiDKy")
		});
		xrLabel71.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel71.LocationFloat = new PointFloat(588.7907f, 358.2916f);
		xrLabel71.Name = "xrLabel71";
		xrLabel71.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel71.SizeF = new SizeF(162.4821f, 23f);
		xrLabel71.StylePriority.UseFont = false;
		xrLabel71.Text = "xrLabel71";
		xrLabel70.Font = new Font("Times New Roman", 11.5f);
		xrLabel70.LocationFloat = new PointFloat(0.9999593f, 384.7917f);
		xrLabel70.Name = "xrLabel70";
		xrLabel70.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel70.SizeF = new SizeF(188.1875f, 23f);
		xrLabel70.StylePriority.UseFont = false;
		xrLabel70.Text = "CMND/CCCD/Hộ chiếu số:";
		xrLabel69.Font = new Font("Times New Roman", 11.5f);
		xrLabel69.LocationFloat = new PointFloat(0.375239f, 200.6667f);
		xrLabel69.Name = "xrLabel69";
		xrLabel69.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel69.SizeF = new SizeF(60f, 23f);
		xrLabel69.StylePriority.UseFont = false;
		xrLabel69.Text = "Địa chỉ:";
		xrLabel56.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel56.LocationFloat = new PointFloat(60.99994f, 200.6667f);
		xrLabel56.Name = "xrLabel56";
		xrLabel56.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel56.SizeF = new SizeF(691f, 23f);
		xrLabel56.StylePriority.UseFont = false;
		xrLabel56.Text = "[DiaChiCongTyTiem]";
		xrLabel49.Font = new Font("Times New Roman", 14f, FontStyle.Bold);
		xrLabel49.LocationFloat = new PointFloat(0.3751755f, 29.25005f);
		xrLabel49.Multiline = true;
		xrLabel49.Name = "xrLabel49";
		xrLabel49.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel49.SizeF = new SizeF(727.6664f, 22f);
		xrLabel49.StylePriority.UseFont = false;
		xrLabel49.StylePriority.UseTextAlignment = false;
		xrLabel49.Text = "GÓI TIÊM CHỦNG VACCINE";
		xrLabel49.TextAlignment = TextAlignment.TopCenter;
		xrLabel14.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.DiaChi_NguoiDKy")
		});
		xrLabel14.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel14.LocationFloat = new PointFloat(111.0001f, 436.4998f);
		xrLabel14.Name = "xrLabel14";
		xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.SizeF = new SizeF(638.9801f, 23.00003f);
		xrLabel14.StylePriority.UseFont = false;
		xrLabel14.Text = "xrLabel14";
		xrLabel13.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.DiaChiHoKhau")
		});
		xrLabel13.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel13.LocationFloat = new PointFloat(131f, 410.4998f);
		xrLabel13.Name = "xrLabel13";
		xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel13.SizeF = new SizeF(618.9803f, 23.00003f);
		xrLabel13.StylePriority.UseFont = false;
		xrLabel13.Text = "xrLabel13";
		xrLabel12.Font = new Font("Times New Roman", 11.5f);
		xrLabel12.LocationFloat = new PointFloat(497.522f, 384.7917f);
		xrLabel12.Name = "xrLabel12";
		xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel12.SizeF = new SizeF(57.72757f, 23f);
		xrLabel12.StylePriority.UseFont = false;
		xrLabel12.StylePriority.UseTextAlignment = false;
		xrLabel12.Text = "nơi cấp:";
		xrLabel12.TextAlignment = TextAlignment.TopLeft;
		xrLabel11.Font = new Font("Times New Roman", 11.5f);
		xrLabel11.LocationFloat = new PointFloat(332.5221f, 384.7915f);
		xrLabel11.Name = "xrLabel11";
		xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.SizeF = new SizeF(70f, 23.00003f);
		xrLabel11.StylePriority.UseFont = false;
		xrLabel11.StylePriority.UseTextAlignment = false;
		xrLabel11.Text = "ngày cấp: ";
		xrLabel11.TextAlignment = TextAlignment.TopLeft;
		xrLabel10.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.CMND_NguoiDKy")
		});
		xrLabel10.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel10.LocationFloat = new PointFloat(189.1875f, 384.7916f);
		xrLabel10.Name = "xrLabel10";
		xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel10.SizeF = new SizeF(143.3346f, 23f);
		xrLabel10.StylePriority.UseFont = false;
		xrLabel10.Text = "[CMND_NguoiDKy]";
		xrLabel9.Font = new Font("Times New Roman", 11.5f);
		xrLabel9.LocationFloat = new PointFloat(513.7906f, 358.2916f);
		xrLabel9.Name = "xrLabel9";
		xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel9.SizeF = new SizeF(75f, 23f);
		xrLabel9.StylePriority.UseFont = false;
		xrLabel9.Text = "Quốc tịch: ";
		xrLabel15.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.DTCoDinh_NguoiDKy")
		});
		xrLabel15.Font = new Font("Times New Roman", 14f, FontStyle.Bold);
		xrLabel15.LocationFloat = new PointFloat(344.5208f, 311.2916f);
		xrLabel15.Name = "xrLabel15";
		xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel15.SizeF = new SizeF(199.9171f, 23f);
		xrLabel15.StylePriority.UseFont = false;
		xrLabel15.Text = "xrLabel15";
		xrLabel15.Visible = false;
		xrLabel7.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.TenNguoiDKy")
		});
		xrLabel7.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel7.LocationFloat = new PointFloat(73.3756f, 358.2916f);
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel7.SizeF = new SizeF(284.3727f, 23f);
		xrLabel7.StylePriority.UseFont = false;
		xrLabel7.Text = "xrLabel7";
		xrLabel6.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold | FontStyle.Underline);
		xrLabel6.LocationFloat = new PointFloat(0.3751119f, 331.2916f);
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel6.SizeF = new SizeF(191.7905f, 23.00003f);
		xrLabel6.StylePriority.UseFont = false;
		xrLabel6.StylePriority.UseTextAlignment = false;
		xrLabel6.Text = "BÊN SỬ DỤNG DỊCH VỤ:";
		xrLabel3.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold | FontStyle.Underline);
		xrLabel3.LocationFloat = new PointFloat(0.3751119f, 123.5834f);
		xrLabel3.Multiline = true;
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel3.SizeF = new SizeF(751.6249f, 22f);
		xrLabel3.StylePriority.UseFont = false;
		xrLabel3.StylePriority.UseTextAlignment = false;
		xrLabel3.Text = "BÊN CUNG CẤP DỊCH VỤ:";
		xrLabel3.TextAlignment = TextAlignment.TopLeft;
		xrLabel2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.SoHDong")
		});
		xrLabel2.Font = new Font("Times New Roman", 13f);
		xrLabel2.LocationFloat = new PointFloat(0f, 51.25005f);
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.SizeF = new SizeF(751.6248f, 23f);
		xrLabel2.StylePriority.UseFont = false;
		xrLabel2.StylePriority.UseTextAlignment = false;
		xrLabel2.Text = "[SoHDong]";
		xrLabel2.TextAlignment = TextAlignment.TopCenter;
		xrLabel1.Font = new Font("Times New Roman", 14f, FontStyle.Bold);
		xrLabel1.LocationFloat = new PointFloat(0.3751119f, 0f);
		xrLabel1.Multiline = true;
		xrLabel1.Name = "xrLabel1";
		xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel1.SizeF = new SizeF(727.6665f, 22f);
		xrLabel1.StylePriority.UseFont = false;
		xrLabel1.StylePriority.UseTextAlignment = false;
		xrLabel1.Text = "XÁC NHẬN CUNG CẤP VÀ SỬ DỤNG DỊCH VỤ \r\n";
		xrLabel1.TextAlignment = TextAlignment.TopCenter;
		xrLabel8.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.Dob_NguoiDKy")
		});
		xrLabel8.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel8.LocationFloat = new PointFloat(432.7484f, 358.2916f);
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.SizeF = new SizeF(81.04224f, 23f);
		xrLabel8.StylePriority.UseFont = false;
		xrLabel8.Text = "xrLabel8";
		xrLabel17.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel17.LocationFloat = new PointFloat(1.000016f, 484.4999f);
		xrLabel17.Name = "xrLabel17";
		xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.SizeF = new SizeF(748.5427f, 23f);
		xrLabel17.StylePriority.UseFont = false;
		xrLabel17.StylePriority.UseTextAlignment = false;
		xrLabel17.Text = "  *Thông tin người được tiêm vaccine:";
		xrLabel22.Font = new Font("Times New Roman", 11.5f);
		xrLabel22.LocationFloat = new PointFloat(0.9999593f, 532.4999f);
		xrLabel22.Name = "xrLabel22";
		xrLabel22.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel22.SizeF = new SizeF(192.8744f, 23f);
		xrLabel22.StylePriority.UseFont = false;
		xrLabel22.Text = "(Sau đây gọi tắt là Bên B).";
		xrLabel20.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.Dob_NguoiTiem")
		});
		xrLabel20.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel20.LocationFloat = new PointFloat(441.4771f, 509.4999f);
		xrLabel20.Name = "xrLabel20";
		xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel20.SizeF = new SizeF(81.04218f, 23f);
		xrLabel20.StylePriority.UseFont = false;
		xrLabel20.Text = "xrLabel20";
		xrLabel19.Font = new Font("Times New Roman", 11.5f);
		xrLabel19.LocationFloat = new PointFloat(522.5193f, 509.4999f);
		xrLabel19.Name = "xrLabel19";
		xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel19.SizeF = new SizeF(75f, 23f);
		xrLabel19.StylePriority.UseFont = false;
		xrLabel19.Text = "Quốc tịch: ";
		xrLabel18.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.TenNguoiTiem")
		});
		xrLabel18.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel18.LocationFloat = new PointFloat(75.37509f, 509.4999f);
		xrLabel18.Name = "xrLabel18";
		xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel18.SizeF = new SizeF(291.102f, 22.99997f);
		xrLabel18.StylePriority.UseFont = false;
		xrLabel18.Text = "xrLabel18";
		xrLabel79.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.NgayThangNoiCap")
		});
		xrLabel79.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel79.LocationFloat = new PointFloat(402.522f, 384.7916f);
		xrLabel79.Name = "xrLabel79";
		xrLabel79.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel79.SizeF = new SizeF(95f, 23.00012f);
		xrLabel79.StylePriority.UseFont = false;
		xrLabel79.StylePriority.UseTextAlignment = false;
		xrLabel79.Text = "xrLabel79";
		xrLabel79.TextAlignment = TextAlignment.TopLeft;
		xrLabel34.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.DiaChiNoiCap")
		});
		xrLabel34.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel34.LocationFloat = new PointFloat(555.2495f, 384.7917f);
		xrLabel34.Name = "xrLabel34";
		xrLabel34.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel34.SizeF = new SizeF(194.7307f, 22.99991f);
		xrLabel34.StylePriority.UseFont = false;
		xrLabel34.StylePriority.UseTextAlignment = false;
		xrLabel34.Text = "xrLabel34";
		xrLabel34.TextAlignment = TextAlignment.TopLeft;
		xrLabel4.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.DiaChiTTT")
		});
		xrLabel4.Font = new Font("Times New Roman", 11.5f);
		xrLabel4.LocationFloat = new PointFloat(0.3751119f, 94.41669f);
		xrLabel4.Multiline = true;
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel4.SizeF = new SizeF(751.6249f, 29.16668f);
		xrLabel4.StylePriority.UseFont = false;
		xrLabel4.Text = "xrLabel4";
		TopMargin.HeightF = 98f;
		TopMargin.Name = "TopMargin";
		TopMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		TopMargin.TextAlignment = TextAlignment.TopLeft;
		xrBarCode2.AutoModule = true;
		xrBarCode2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.PatientHospitalID")
		});
		xrBarCode2.LocationFloat = new PointFloat(585.2729f, 0f);
		xrBarCode2.Name = "xrBarCode2";
		xrBarCode2.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		xrBarCode2.SizeF = new SizeF(165.9999f, 42.12506f);
		xrBarCode2.StylePriority.UsePadding = false;
		xrBarCode2.StylePriority.UseTextAlignment = false;
		code128Generator.CharacterSet = Code128Charset.CharsetAuto;
		xrBarCode2.Symbology = code128Generator;
		xrBarCode2.TextAlignment = TextAlignment.MiddleCenter;
		xrBarCode2.PrintOnPage += xrBarCode2_PrintOnPage;
		BottomMargin.HeightF = 98f;
		BottomMargin.Name = "BottomMargin";
		BottomMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		BottomMargin.TextAlignment = TextAlignment.TopLeft;
		ReportHeader.HeightF = 0f;
		ReportHeader.Name = "ReportHeader";
		xrPictureBox1.LocationFloat = new PointFloat(0.3751068f, 0f);
		xrPictureBox1.Name = "xrPictureBox1";
		xrPictureBox1.SizeF = new SizeF(220.6876f, 77.61165f);
		xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
		rep_HopDong_Vaccine1.DataSetName = "rep_HopDong_Vaccine";
		rep_HopDong_Vaccine1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		PageFooter.Controls.AddRange(new XRControl[2] { xrPageInfo2, xrTable1 });
		PageFooter.HeightF = 84.79173f;
		PageFooter.Name = "PageFooter";
		PageFooter.Visible = false;
		xrPageInfo2.Format = "{0}";
		xrPageInfo2.LocationFloat = new PointFloat(0f, 0f);
		xrPageInfo2.Name = "xrPageInfo2";
		xrPageInfo2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo2.SizeF = new SizeF(750.7711f, 23f);
		xrPageInfo2.StylePriority.UseTextAlignment = false;
		xrPageInfo2.TextAlignment = TextAlignment.TopCenter;
		xrTable1.LocationFloat = new PointFloat(0f, 22.99995f);
		xrTable1.Name = "xrTable1";
		xrTable1.Rows.AddRange(new XRTableRow[1] { xrTableRow1 });
		xrTable1.SizeF = new SizeF(752f, 61.79173f);
		xrTableRow1.Cells.AddRange(new XRTableCell[1] { xrTableCell1 });
		xrTableRow1.Name = "xrTableRow1";
		xrTableRow1.Weight = 1.0;
		xrTableCell1.BackColor = Color.FromArgb(40, 56, 144);
		xrTableCell1.Controls.AddRange(new XRControl[9] { xrLabel67, xrLabel89, xrLabel74, xrLabel75, xrLabel76, xrLabel80, xrLabel86, xrLabel88, xrLabel68 });
		xrTableCell1.ForeColor = Color.Black;
		xrTableCell1.Name = "xrTableCell1";
		xrTableCell1.StylePriority.UseBackColor = false;
		xrTableCell1.StylePriority.UseForeColor = false;
		xrTableCell1.Weight = 3.0;
		xrLabel67.BorderColor = Color.Black;
		xrLabel67.Font = new Font("Times New Roman", 11f, FontStyle.Bold);
		xrLabel67.ForeColor = Color.White;
		xrLabel67.LocationFloat = new PointFloat(7f, 11.99997f);
		xrLabel67.Name = "xrLabel67";
		xrLabel67.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel67.SizeF = new SizeF(608.4161f, 23f);
		xrLabel67.StylePriority.UseBorderColor = false;
		xrLabel67.StylePriority.UseFont = false;
		xrLabel67.StylePriority.UseForeColor = false;
		xrLabel67.Text = "CÔNG TY CỔ PHẦN VACXIN VIỆT NAM - CHI NHÁNH THÀNH PHỐ HỒ CHÍ MINH.";
		xrLabel89.Font = new Font("Times New Roman", 8.5f);
		xrLabel89.ForeColor = Color.White;
		xrLabel89.LocationFloat = new PointFloat(674.7505f, 34.99997f);
		xrLabel89.Name = "xrLabel89";
		xrLabel89.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel89.SizeF = new SizeF(74.24945f, 23f);
		xrLabel89.StylePriority.UseFont = false;
		xrLabel89.StylePriority.UseForeColor = false;
		xrLabel89.Text = "www.vnvc.vn";
		xrLabel74.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Table1.DiaChiCongTyTiem")
		});
		xrLabel74.Font = new Font("Times New Roman", 8.5f);
		xrLabel74.ForeColor = Color.White;
		xrLabel74.LocationFloat = new PointFloat(49.08295f, 34.99997f);
		xrLabel74.Name = "xrLabel74";
		xrLabel74.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel74.SizeF = new SizeF(324.9589f, 23f);
		xrLabel74.StylePriority.UseFont = false;
		xrLabel74.StylePriority.UseForeColor = false;
		xrLabel74.Text = "xrLabel74";
		xrLabel75.Font = new Font("Times New Roman", 8.5f, FontStyle.Bold);
		xrLabel75.ForeColor = Color.White;
		xrLabel75.LocationFloat = new PointFloat(374.0418f, 34.99997f);
		xrLabel75.Name = "xrLabel75";
		xrLabel75.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel75.SizeF = new SizeF(60.12573f, 23f);
		xrLabel75.StylePriority.UseFont = false;
		xrLabel75.StylePriority.UseForeColor = false;
		xrLabel75.Text = "Điện thoại:";
		xrLabel76.Font = new Font("Times New Roman", 8.5f);
		xrLabel76.ForeColor = Color.White;
		xrLabel76.LocationFloat = new PointFloat(432.7485f, 34.99997f);
		xrLabel76.Name = "xrLabel76";
		xrLabel76.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel76.SizeF = new SizeF(72.04199f, 23f);
		xrLabel76.StylePriority.UseFont = false;
		xrLabel76.StylePriority.UseForeColor = false;
		xrLabel76.Text = "028.93372138";
		xrLabel80.Font = new Font("Times New Roman", 8.5f, FontStyle.Bold);
		xrLabel80.ForeColor = Color.White;
		xrLabel80.LocationFloat = new PointFloat(509.7905f, 34.99997f);
		xrLabel80.Name = "xrLabel80";
		xrLabel80.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel80.SizeF = new SizeF(45.45905f, 23f);
		xrLabel80.StylePriority.UseFont = false;
		xrLabel80.StylePriority.UseForeColor = false;
		xrLabel80.Text = "Hotline:";
		xrLabel86.Font = new Font("Times New Roman", 8.5f);
		xrLabel86.ForeColor = Color.White;
		xrLabel86.LocationFloat = new PointFloat(553.2495f, 34.99997f);
		xrLabel86.Name = "xrLabel86";
		xrLabel86.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel86.SizeF = new SizeF(75.04199f, 23f);
		xrLabel86.StylePriority.UseFont = false;
		xrLabel86.StylePriority.UseForeColor = false;
		xrLabel86.Text = "028.93372138.";
		xrLabel88.Font = new Font("Times New Roman", 8.5f, FontStyle.Bold);
		xrLabel88.ForeColor = Color.White;
		xrLabel88.LocationFloat = new PointFloat(628.2915f, 34.99997f);
		xrLabel88.Name = "xrLabel88";
		xrLabel88.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel88.SizeF = new SizeF(49.45905f, 23f);
		xrLabel88.StylePriority.UseFont = false;
		xrLabel88.StylePriority.UseForeColor = false;
		xrLabel88.Text = "Website:";
		xrLabel68.Font = new Font("Times New Roman", 8.5f, FontStyle.Bold);
		xrLabel68.ForeColor = Color.White;
		xrLabel68.LocationFloat = new PointFloat(7f, 34.99997f);
		xrLabel68.Name = "xrLabel68";
		xrLabel68.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel68.SizeF = new SizeF(44.08289f, 23f);
		xrLabel68.StylePriority.UseFont = false;
		xrLabel68.StylePriority.UseForeColor = false;
		xrLabel68.Text = "Địa chỉ:";
		PageHeader.Controls.AddRange(new XRControl[1] { xrPictureBox1 });
		PageHeader.HeightF = 77.61165f;
		PageHeader.Name = "PageHeader";
		PageHeader.Visible = false;
		ReportFooter.Controls.AddRange(new XRControl[4] { xrLabel61, xrLabel60, xrLabel59, xrLabel58 });
		ReportFooter.HeightF = 147.9167f;
		ReportFooter.Name = "ReportFooter";
		xrLabel61.Font = new Font("Times New Roman", 11.5f, FontStyle.Italic);
		xrLabel61.LocationFloat = new PointFloat(61f, 34.99997f);
		xrLabel61.Name = "xrLabel61";
		xrLabel61.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel61.SizeF = new SizeF(163.5417f, 19.79167f);
		xrLabel61.StylePriority.UseFont = false;
		xrLabel61.StylePriority.UseTextAlignment = false;
		xrLabel61.Text = "(Ký, ghi rõ họ tên)";
		xrLabel61.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel60.Font = new Font("Times New Roman", 11.5f, FontStyle.Italic);
		xrLabel60.LocationFloat = new PointFloat(526.6678f, 36.24999f);
		xrLabel60.Name = "xrLabel60";
		xrLabel60.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel60.SizeF = new SizeF(163.5417f, 19.79167f);
		xrLabel60.StylePriority.UseFont = false;
		xrLabel60.StylePriority.UseTextAlignment = false;
		xrLabel60.Text = "(Ký, ghi rõ họ tên)";
		xrLabel60.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel59.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel59.LocationFloat = new PointFloat(569.2915f, 11.25f);
		xrLabel59.Name = "xrLabel59";
		xrLabel59.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel59.SizeF = new SizeF(80.20834f, 25f);
		xrLabel59.StylePriority.UseFont = false;
		xrLabel59.StylePriority.UseTextAlignment = false;
		xrLabel59.Text = "BÊN B";
		xrLabel59.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel58.Font = new Font("Times New Roman", 11.5f, FontStyle.Bold);
		xrLabel58.LocationFloat = new PointFloat(97.3132f, 9.999974f);
		xrLabel58.Name = "xrLabel58";
		xrLabel58.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel58.SizeF = new SizeF(80.20834f, 25f);
		xrLabel58.StylePriority.UseFont = false;
		xrLabel58.StylePriority.UseTextAlignment = false;
		xrLabel58.Text = "BÊN A";
		xrLabel58.TextAlignment = TextAlignment.MiddleCenter;
		base.Bands.AddRange(new Band[7] { ReportHeader, Detail, TopMargin, BottomMargin, PageFooter, PageHeader, ReportFooter });
		base.DataMember = "Table1";
		base.DataSource = rep_HopDong_Vaccine1;
		base.Margins = new Margins(59, 39, 98, 98);
		base.Version = "12.2";
		BeforePrint += rptHopDong_Vaccine_BeforePrint;
		((ISupportInitialize)rep_HopDong_Vaccine1).EndInit();
		((ISupportInitialize)xrTable1).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
