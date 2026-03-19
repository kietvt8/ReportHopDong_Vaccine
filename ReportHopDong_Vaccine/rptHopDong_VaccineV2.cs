using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using ServerShared;

namespace ReportHopDong_Vaccine;

public class rptHopDong_VaccineV2 : XtraReport, IReport
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

	private XRBarCode xrBarCode2;

	private XRLabel xrLabel49;

	private XRLabel xrLabel3;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private XRPictureBox xrPictureBox1;

	private PageHeaderBand PageHeader;

	private XRLabel xrLabel4;

	private ReportFooterBand ReportFooter;

	private XRLabel xrLabel61;

	private XRLabel xrLabel60;

	private XRLabel xrLabel59;

	private XRLabel xrLabel58;

	private XRTable tableHTML;

	private XRTableRow xrTableRow2;

	private XRTableCell HTML;

	private XRPanel PanelDetail;

	private XRLabel xrLabel34;

	private XRLabel xrLabel87;

	private XRLabel xrLabel71;

	private XRLabel xrLabel70;

	private XRLabel xrLabel14;

	private XRLabel xrLabel13;

	private XRLabel xrLabel12;

	private XRLabel xrLabel11;

	private XRLabel xrLabel10;

	private XRLabel xrLabel9;

	private XRLabel xrLabel72;

	private XRLabel xrLabel15;

	private XRLabel xrLabel6;

	private XRLabel xrLabel8;

	private XRLabel xrLabel17;

	private XRLabel xrLabel22;

	private XRLabel xrLabel20;

	private XRLabel xrLabel19;

	private XRLabel xrLabel18;

	private XRLabel xrLabel79;

	private XRLabel xrLabel7;

	private XRLabel xrLabel110;

	private XRLabel xrLabel73;

	private XRLabel xrLabel78;

	private XRLabel xrLabel77;

	private XRLabel xrLabel27;

	private XRLabel xrLabel26;

	private XRLabel xrLabel85;

	private XRLabel xrLabel84;

	private XRLabel xrLabel83;

	private XRLabel xrLabel82;

	private XRLabel xrLabel81;

	private XRLabel xrLabel5;

	private XRLabel xrLabel23;

	private XRLabel xrLabel21;

	private XRLabel xrLabel56;

	private XRLabel xrLabel16;

	private XRLabel xrLabel33;

	private XRLabel xrLabel32;

	private XRLabel xrLabel31;

	private XRLabel xrLabel30;

	private XRLabel xrLabel29;

	private XRLabel xrLabel28;

	private XRLabel xrLabel128;

	private XRLabel xrLabel127;

	private XRLabel xrLabel126;

	private XRLabel xrLabel125;

	private XRLabel xrLabel124;

	private XRLabel xrLabel123;

	private XRLabel xrLabel122;

	private XRLabel xrLabel121;

	private XRLabel xrLabel120;

	private XRLabel xrLabel119;

	private XRLabel xrLabel118;

	private XRLabel xrLabel117;

	private XRLabel xrLabel116;

	private XRLabel xrLabel115;

	private XRLabel xrLabel114;

	private XRLabel xrLabel113;

	private XRLabel xrLabel112;

	private XRLabel xrLabel111;

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

	private XRLabel xrLabel69;

	private XRLabel xrLabel66;

	private XRLabel xrLabel65;

	private XRLabel xrLabel64;

	private XRLabel xrLabel63;

	private XRLabel xrLabel62;

	private XRLabel xrLabel57;

	private XRLabel xrLabel55;

	private XRLabel xrLabel54;

	private XRLabel xrLabel38;

	private XRLabel xrLabel35;

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

	private XRLabel xrLabel132;

	private XRLabel xrLabel129;

	private XRLabel xrLabel130;

	private XRLabel xrLabel36;

	private XRLabel xrLabel133;

	private XRLabel xrLabel135;

	private XRLabel xrLabel134;

	private XRLabel xrLabel37;

	private XRLabel xrLabel25;
	private XRLabel xrLabel131;
	private XRLabel xrLabel136;
	private XRLabel xrLabel137;
	private XRLabel xrLabel138;
	private XRLabel xrLabel139;
	private XRLabel xrLabel140;
	private XRLabel xrLabel24;

	public rptHopDong_VaccineV2()
	{
		InitializeComponent();
		BeforePrint += rptHopDong_Vaccine_BeforePrint;
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
		string text = dset.Tables["Table1"].Rows[0]["Logo"].ToString();
		if (text != "")
		{
			byte[] buffer = Convert.FromBase64String(text);
			Stream stream = new MemoryStream(buffer);
			Image image = Image.FromStream(stream);
			xrPictureBox1.Image = image;
		}
	}

	private void xrBarCode2_PrintOnPage(object sender, PrintOnPageEventArgs e)
	{
		if (e.PageCount > 0 && e.PageIndex != 0)
		{
			e.Cancel = true;
		}
	}

	private void Detail_BeforePrint(object sender, PrintEventArgs e)
	{
		float num = 0f;
		DetailBand detailBand = (DetailBand)sender;
		if (dset.Tables[0].Rows.Count > 0 && dset.Tables[0].Rows[0]["HTMLDiaDiem"].ToString() == "")
		{
			xrLabel21.Visible = false;
			xrLabel23.Visible = false;
			xrLabel24.Visible = false;
			xrLabel25.Visible = false;
			PanelDetail.LocationF = xrLabel21.LocationF;
			foreach (XRControl control in detailBand.Controls)
			{
				if (control.Visible)
				{
					control.LocationF = new PointF(control.LocationF.X, num);
				}
				if (!control.Visible)
				{
					control.SizeF = new SizeF(control.WidthF, 0f);
				}
				else
				{
					num += control.HeightF + 0f;
				}
			}
		}
		detailBand.HeightF = 0f;
	}

	private string GetFixedRtf(string html)
	{
		RichEditDocumentServer richEditDocumentServer = new RichEditDocumentServer();
		richEditDocumentServer.LoadDocument(new MemoryStream(Encoding.Default.GetBytes(html)), DocumentFormat.Rtf);
		richEditDocumentServer.Document.Paragraphs[richEditDocumentServer.Document.Paragraphs.Count - 1].LineSpacingType = ParagraphLineSpacing.Exactly;
		richEditDocumentServer.Document.Paragraphs[richEditDocumentServer.Document.Paragraphs.Count - 1].SpacingAfter = 0f;
		return richEditDocumentServer.RtfText;
	}

	private void HTML_BeforePrint(object sender, PrintEventArgs e)
	{
		XRTableCell xRTableCell = (XRTableCell)sender;
		string text = xRTableCell.Tag.ToString();
		string html = xRTableCell.Text;
		XRRichText xRRichText = new XRRichText();
		xRRichText.Html = html;
		XRRichText xRRichText2 = xRRichText;
		string fixedRtf = GetFixedRtf(xRRichText2.Rtf);
		XRRichText xRRichText3 = new XRRichText();
		xRRichText3.Rtf = fixedRtf;
		XRRichText xRRichText4 = xRRichText3;
		xRRichText4.SizeF = new SizeF(HTML.SizeF.Width, 0f);
		xRRichText4.Borders = BorderSide.None;
		xRRichText4.Padding = new PaddingInfo(0, 0, 0, 0);
		xRTableCell.Controls.Clear();
		xRTableCell.Controls.Add(xRRichText4);
	}

	private void tableHTML_BeforePrint(object sender, PrintEventArgs e)
	{
		XRTable xRTable = (XRTable)sender;
		xRTable.SizeF = new SizeF(xRTable.SizeF.Width, xRTable.SizeF.Height - 24f);
	}

	private void PanelDetail_BeforePrint(object sender, PrintEventArgs e)
	{
		XRPanel xRPanel = (XRPanel)sender;
	}

	private void rptHopDong_VaccineV2_AfterPrint(object sender, EventArgs e)
	{
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptHopDong_VaccineV2));
			DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.tableHTML = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.HTML = new DevExpress.XtraReports.UI.XRTableCell();
			this.PanelDetail = new DevExpress.XtraReports.UI.XRPanel();
			this.xrLabel139 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel138 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel137 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel136 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel131 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel135 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel134 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel133 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel132 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel130 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel129 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel128 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel127 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel126 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel125 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel124 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel123 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel122 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel121 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel120 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel119 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel118 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel117 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel116 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel115 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel114 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel113 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel112 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel111 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel109 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel108 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel107 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel106 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel105 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel104 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel103 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel102 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel101 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel100 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel99 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel98 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel97 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel96 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel95 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel94 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel93 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel92 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel91 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel90 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel69 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel87 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel79 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel110 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel78 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel83 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel82 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel81 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel77 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel85 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel84 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.xrBarCode2 = new DevExpress.XtraReports.UI.XRBarCode();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
			this.rep_HopDong_Vaccine1 = new ReportHopDong_Vaccine.rep_HopDong_Vaccine();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel89 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel74 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel75 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel76 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel80 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel86 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel88 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel140 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this.tableHTML)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rep_HopDong_Vaccine1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tableHTML,
            this.PanelDetail,
            this.xrLabel21,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel25});
			this.Detail.HeightF = 1730.833F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// tableHTML
			// 
			this.tableHTML.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.tableHTML.LocationFloat = new DevExpress.Utils.PointFloat(0.7386208F, 0F);
			this.tableHTML.Name = "tableHTML";
			this.tableHTML.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
			this.tableHTML.SizeF = new System.Drawing.SizeF(748.1678F, 25.24992F);
			this.tableHTML.StylePriority.UseBorders = false;
			// 
			// xrTableRow2
			// 
			this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.HTML});
			this.xrTableRow2.Name = "xrTableRow2";
			this.xrTableRow2.Weight = 1D;
			// 
			// HTML
			// 
			this.HTML.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HTML]")});
			this.HTML.Name = "HTML";
			this.HTML.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
			this.HTML.StylePriority.UsePadding = false;
			this.HTML.StylePriority.UseTextAlignment = false;
			this.HTML.Text = "HTML";
			this.HTML.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.HTML.Weight = 3D;
			// 
			// PanelDetail
			// 
			this.PanelDetail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel140,
            this.xrLabel139,
            this.xrLabel138,
            this.xrLabel137,
            this.xrLabel136,
            this.xrLabel131,
            this.xrLabel135,
            this.xrLabel134,
            this.xrLabel133,
            this.xrLabel132,
            this.xrLabel130,
            this.xrLabel129,
            this.xrLabel128,
            this.xrLabel127,
            this.xrLabel126,
            this.xrLabel125,
            this.xrLabel124,
            this.xrLabel123,
            this.xrLabel122,
            this.xrLabel121,
            this.xrLabel120,
            this.xrLabel119,
            this.xrLabel118,
            this.xrLabel117,
            this.xrLabel116,
            this.xrLabel115,
            this.xrLabel114,
            this.xrLabel113,
            this.xrLabel112,
            this.xrLabel111,
            this.xrLabel109,
            this.xrLabel108,
            this.xrLabel107,
            this.xrLabel106,
            this.xrLabel105,
            this.xrLabel104,
            this.xrLabel103,
            this.xrLabel102,
            this.xrLabel101,
            this.xrLabel100,
            this.xrLabel99,
            this.xrLabel98,
            this.xrLabel97,
            this.xrLabel96,
            this.xrLabel95,
            this.xrLabel94,
            this.xrLabel93,
            this.xrLabel92,
            this.xrLabel91,
            this.xrLabel90,
            this.xrLabel69,
            this.xrLabel66,
            this.xrLabel65,
            this.xrLabel64,
            this.xrLabel63,
            this.xrLabel62,
            this.xrLabel57,
            this.xrLabel55,
            this.xrLabel54,
            this.xrLabel38,
            this.xrLabel35,
            this.xrLabel53,
            this.xrLabel52,
            this.xrLabel51,
            this.xrLabel50,
            this.xrLabel48,
            this.xrLabel47,
            this.xrLabel46,
            this.xrLabel45,
            this.xrLabel44,
            this.xrLabel43,
            this.xrLabel42,
            this.xrLabel41,
            this.xrLabel40,
            this.xrLabel39,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel33,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel56,
            this.xrLabel34,
            this.xrLabel87,
            this.xrLabel71,
            this.xrLabel70,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel72,
            this.xrLabel15,
            this.xrLabel6,
            this.xrLabel8,
            this.xrLabel79,
            this.xrLabel7,
            this.xrLabel110,
            this.xrLabel73,
            this.xrLabel78,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel83,
            this.xrLabel82,
            this.xrLabel81,
            this.xrLabel5,
            this.xrLabel17,
            this.xrLabel77,
            this.xrLabel85,
            this.xrLabel20,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel84,
            this.xrLabel22,
            this.xrLabel16});
			this.PanelDetail.KeepTogether = false;
			this.PanelDetail.LocationFloat = new DevExpress.Utils.PointFloat(0F, 125.25F);
			this.PanelDetail.Name = "PanelDetail";
			this.PanelDetail.SizeF = new System.Drawing.SizeF(750F, 1605.583F);
			this.PanelDetail.StylePriority.UseBorders = false;
			// 
			// xrLabel139
			// 
			this.xrLabel139.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel139.LocationFloat = new DevExpress.Utils.PointFloat(28.14034F, 1465.768F);
			this.xrLabel139.Name = "xrLabel139";
			this.xrLabel139.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel139.SizeF = new System.Drawing.SizeF(719.6825F, 77.43347F);
			this.xrLabel139.StylePriority.UseFont = false;
			this.xrLabel139.StylePriority.UseTextAlignment = false;
			this.xrLabel139.Text = resources.GetString("xrLabel139.Text");
			this.xrLabel139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel138
			// 
			this.xrLabel138.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel138.LocationFloat = new DevExpress.Utils.PointFloat(53.26012F, 1252.062F);
			this.xrLabel138.Name = "xrLabel138";
			this.xrLabel138.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel138.SizeF = new System.Drawing.SizeF(696.2602F, 59.27319F);
			this.xrLabel138.StylePriority.UseFont = false;
			this.xrLabel138.StylePriority.UseTextAlignment = false;
			this.xrLabel138.Text = resources.GetString("xrLabel138.Text");
			this.xrLabel138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel137
			// 
			this.xrLabel137.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel137.LocationFloat = new DevExpress.Utils.PointFloat(53.12327F, 684.6036F);
			this.xrLabel137.Name = "xrLabel137";
			this.xrLabel137.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel137.SizeF = new System.Drawing.SizeF(695.9062F, 63.1662F);
			this.xrLabel137.StylePriority.UseFont = false;
			this.xrLabel137.StylePriority.UseTextAlignment = false;
			this.xrLabel137.Text = resources.GetString("xrLabel137.Text");
			this.xrLabel137.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel136
			// 
			this.xrLabel136.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel136.LocationFloat = new DevExpress.Utils.PointFloat(53.12322F, 539.6041F);
			this.xrLabel136.Name = "xrLabel136";
			this.xrLabel136.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel136.SizeF = new System.Drawing.SizeF(695.9062F, 82F);
			this.xrLabel136.StylePriority.UseFont = false;
			this.xrLabel136.StylePriority.UseTextAlignment = false;
			this.xrLabel136.Text = resources.GetString("xrLabel136.Text");
			this.xrLabel136.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel131
			// 
			this.xrLabel131.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel131.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 297.8125F);
			this.xrLabel131.Name = "xrLabel131";
			this.xrLabel131.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel131.SizeF = new System.Drawing.SizeF(721.9478F, 40F);
			this.xrLabel131.StylePriority.UseFont = false;
			this.xrLabel131.StylePriority.UseTextAlignment = false;
			this.xrLabel131.Text = resources.GetString("xrLabel131.Text");
			this.xrLabel131.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel135
			// 
			this.xrLabel135.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel135.LocationFloat = new DevExpress.Utils.PointFloat(53.26335F, 463.0886F);
			this.xrLabel135.Name = "xrLabel135";
			this.xrLabel135.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel135.SizeF = new System.Drawing.SizeF(694.643F, 76.51563F);
			this.xrLabel135.StylePriority.UseFont = false;
			this.xrLabel135.StylePriority.UseTextAlignment = false;
			this.xrLabel135.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel134
			// 
			this.xrLabel134.CanGrow = false;
			this.xrLabel134.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel134.LocationFloat = new DevExpress.Utils.PointFloat(153.2634F, 442.0886F);
			this.xrLabel134.Multiline = true;
			this.xrLabel134.Name = "xrLabel134";
			this.xrLabel134.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel134.SizeF = new System.Drawing.SizeF(594.643F, 21F);
			this.xrLabel134.StylePriority.UseFont = false;
			this.xrLabel134.StylePriority.UseTextAlignment = false;
			this.xrLabel134.Text = "(khấu trừ 100% tiền đặt cọc). Trong thời hạn thanh toán này, nếu Bên A nhận được " +
    "thông ";
			this.xrLabel134.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel133
			// 
			this.xrLabel133.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel133.LocationFloat = new DevExpress.Utils.PointFloat(150.2634F, 337.8125F);
			this.xrLabel133.Name = "xrLabel133";
			this.xrLabel133.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel133.SizeF = new System.Drawing.SizeF(100F, 21F);
			this.xrLabel133.StylePriority.UseFont = false;
			this.xrLabel133.Text = "đính kèm.";
			// 
			// xrLabel132
			// 
			this.xrLabel132.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrLabel132.LocationFloat = new DevExpress.Utils.PointFloat(190.5511F, 1399.768F);
			this.xrLabel132.Name = "xrLabel132";
			this.xrLabel132.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel132.SizeF = new System.Drawing.SizeF(76.38855F, 21F);
			this.xrLabel132.StylePriority.UseFont = false;
			this.xrLabel132.Text = "Phụ lục I";
			// 
			// xrLabel130
			// 
			this.xrLabel130.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrLabel130.LocationFloat = new DevExpress.Utils.PointFloat(84.1248F, 442.0886F);
			this.xrLabel130.Name = "xrLabel130";
			this.xrLabel130.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel130.SizeF = new System.Drawing.SizeF(70.13855F, 21F);
			this.xrLabel130.StylePriority.UseFont = false;
			this.xrLabel130.Text = "Phụ lục I";
			// 
			// xrLabel129
			// 
			this.xrLabel129.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrLabel129.LocationFloat = new DevExpress.Utils.PointFloat(53.12322F, 379.4374F);
			this.xrLabel129.Name = "xrLabel129";
			this.xrLabel129.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel129.SizeF = new System.Drawing.SizeF(66F, 20.99994F);
			this.xrLabel129.StylePriority.UseFont = false;
			this.xrLabel129.Text = "Đặt cọc:";
			// 
			// xrLabel128
			// 
			this.xrLabel128.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrLabel128.LocationFloat = new DevExpress.Utils.PointFloat(80.1248F, 337.8125F);
			this.xrLabel128.Name = "xrLabel128";
			this.xrLabel128.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel128.SizeF = new System.Drawing.SizeF(70.13855F, 21F);
			this.xrLabel128.StylePriority.UseFont = false;
			this.xrLabel128.Text = "Phụ lục I";
			// 
			// xrLabel127
			// 
			this.xrLabel127.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel127.LocationFloat = new DevExpress.Utils.PointFloat(25.34421F, 1543.201F);
			this.xrLabel127.Name = "xrLabel127";
			this.xrLabel127.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel127.SizeF = new System.Drawing.SizeF(722.4786F, 60.18237F);
			this.xrLabel127.StylePriority.UseFont = false;
			this.xrLabel127.StylePriority.UseTextAlignment = false;
			this.xrLabel127.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel126
			// 
			this.xrLabel126.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel126.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1543.201F);
			this.xrLabel126.Name = "xrLabel126";
			this.xrLabel126.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel126.SizeF = new System.Drawing.SizeF(25.30305F, 21.93213F);
			this.xrLabel126.StylePriority.UseFont = false;
			this.xrLabel126.Text = "7.";
			// 
			// xrLabel125
			// 
			this.xrLabel125.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel125.LocationFloat = new DevExpress.Utils.PointFloat(1.363548F, 1465.768F);
			this.xrLabel125.Name = "xrLabel125";
			this.xrLabel125.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel125.SizeF = new System.Drawing.SizeF(25.30305F, 21.93213F);
			this.xrLabel125.StylePriority.UseFont = false;
			this.xrLabel125.Text = "6.";
			// 
			// xrLabel124
			// 
			this.xrLabel124.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel124.KeepTogether = true;
			this.xrLabel124.LocationFloat = new DevExpress.Utils.PointFloat(27.23878F, 1465.769F);
			this.xrLabel124.Name = "xrLabel124";
			this.xrLabel124.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel124.SizeF = new System.Drawing.SizeF(722.2817F, 77.43225F);
			this.xrLabel124.StylePriority.UseFont = false;
			this.xrLabel124.StylePriority.UseTextAlignment = false;
			this.xrLabel124.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel123
			// 
			this.xrLabel123.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel123.LocationFloat = new DevExpress.Utils.PointFloat(52.68647F, 1443.768F);
			this.xrLabel123.Name = "xrLabel123";
			this.xrLabel123.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel123.SizeF = new System.Drawing.SizeF(695.7401F, 22.00012F);
			this.xrLabel123.StylePriority.UseFont = false;
			this.xrLabel123.StylePriority.UseTextAlignment = false;
			this.xrLabel123.Text = "Trường hợp     khác do luật quy định.";
			this.xrLabel123.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel122
			// 
			this.xrLabel122.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel122.LocationFloat = new DevExpress.Utils.PointFloat(25.70782F, 1443.768F);
			this.xrLabel122.Name = "xrLabel122";
			this.xrLabel122.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel122.SizeF = new System.Drawing.SizeF(26.97866F, 22F);
			this.xrLabel122.StylePriority.UseFont = false;
			this.xrLabel122.Text = "e.";
			// 
			// xrLabel121
			// 
			this.xrLabel121.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel121.LocationFloat = new DevExpress.Utils.PointFloat(25.70782F, 1421.768F);
			this.xrLabel121.Name = "xrLabel121";
			this.xrLabel121.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel121.SizeF = new System.Drawing.SizeF(26.97866F, 22F);
			this.xrLabel121.StylePriority.UseFont = false;
			this.xrLabel121.Text = "d.";
			// 
			// xrLabel120
			// 
			this.xrLabel120.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel120.LocationFloat = new DevExpress.Utils.PointFloat(52.68647F, 1421.768F);
			this.xrLabel120.Name = "xrLabel120";
			this.xrLabel120.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel120.SizeF = new System.Drawing.SizeF(695.7401F, 22.00012F);
			this.xrLabel120.StylePriority.UseFont = false;
			this.xrLabel120.StylePriority.UseTextAlignment = false;
			this.xrLabel120.Text = "Hai bên thống nhất chấm dứt dịch vụ này trước thời hạn.";
			this.xrLabel120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel119
			// 
			this.xrLabel119.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel119.LocationFloat = new DevExpress.Utils.PointFloat(53.08295F, 1399.768F);
			this.xrLabel119.Name = "xrLabel119";
			this.xrLabel119.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel119.SizeF = new System.Drawing.SizeF(695.7401F, 22.00012F);
			this.xrLabel119.StylePriority.UseFont = false;
			this.xrLabel119.StylePriority.UseTextAlignment = false;
			this.xrLabel119.Text = "Hết thời hạn nêu tại                  đính kèm.";
			this.xrLabel119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel118
			// 
			this.xrLabel118.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel118.LocationFloat = new DevExpress.Utils.PointFloat(25.70782F, 1399.768F);
			this.xrLabel118.Name = "xrLabel118";
			this.xrLabel118.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel118.SizeF = new System.Drawing.SizeF(26.97866F, 22F);
			this.xrLabel118.StylePriority.UseFont = false;
			this.xrLabel118.Text = "c.";
			// 
			// xrLabel117
			// 
			this.xrLabel117.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel117.LocationFloat = new DevExpress.Utils.PointFloat(25.70782F, 1377.768F);
			this.xrLabel117.Name = "xrLabel117";
			this.xrLabel117.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel117.SizeF = new System.Drawing.SizeF(26.97866F, 22F);
			this.xrLabel117.StylePriority.UseFont = false;
			this.xrLabel117.Text = "b.";
			// 
			// xrLabel116
			// 
			this.xrLabel116.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel116.LocationFloat = new DevExpress.Utils.PointFloat(52.68647F, 1377.768F);
			this.xrLabel116.Name = "xrLabel116";
			this.xrLabel116.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel116.SizeF = new System.Drawing.SizeF(695.7401F, 22.00012F);
			this.xrLabel116.StylePriority.UseFont = false;
			this.xrLabel116.StylePriority.UseTextAlignment = false;
			this.xrLabel116.Text = "Theo quy định tại Khoản c, Điều 2 của Giấy xác nhận này.";
			this.xrLabel116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel115
			// 
			this.xrLabel115.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel115.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 1355.768F);
			this.xrLabel115.Name = "xrLabel115";
			this.xrLabel115.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel115.SizeF = new System.Drawing.SizeF(26.97866F, 22F);
			this.xrLabel115.StylePriority.UseFont = false;
			this.xrLabel115.Text = "a.";
			// 
			// xrLabel114
			// 
			this.xrLabel114.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel114.LocationFloat = new DevExpress.Utils.PointFloat(53.08295F, 1355.768F);
			this.xrLabel114.Name = "xrLabel114";
			this.xrLabel114.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel114.SizeF = new System.Drawing.SizeF(694.9066F, 22.00012F);
			this.xrLabel114.StylePriority.UseFont = false;
			this.xrLabel114.StylePriority.UseTextAlignment = false;
			this.xrLabel114.Text = "Các Bên đã hoàn thành xong các quyền và nghĩa vụ theo Giấy xác nhận này.";
			this.xrLabel114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel113
			// 
			this.xrLabel113.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel113.LocationFloat = new DevExpress.Utils.PointFloat(26.64555F, 1333.336F);
			this.xrLabel113.Name = "xrLabel113";
			this.xrLabel113.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel113.SizeF = new System.Drawing.SizeF(721.7812F, 21.93237F);
			this.xrLabel113.StylePriority.UseFont = false;
			this.xrLabel113.StylePriority.UseTextAlignment = false;
			this.xrLabel113.Text = "Dịch vụ này sẽ chấm dứt theo một trong các trường hợp sau đây:";
			this.xrLabel113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel112
			// 
			this.xrLabel112.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel112.LocationFloat = new DevExpress.Utils.PointFloat(0.7386208F, 1333.836F);
			this.xrLabel112.Name = "xrLabel112";
			this.xrLabel112.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel112.SizeF = new System.Drawing.SizeF(25.30305F, 21.93213F);
			this.xrLabel112.StylePriority.UseFont = false;
			this.xrLabel112.Text = "5.";
			// 
			// xrLabel111
			// 
			this.xrLabel111.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel111.LocationFloat = new DevExpress.Utils.PointFloat(26.19839F, 1311.335F);
			this.xrLabel111.Name = "xrLabel111";
			this.xrLabel111.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel111.SizeF = new System.Drawing.SizeF(26.97866F, 22F);
			this.xrLabel111.StylePriority.UseFont = false;
			this.xrLabel111.Text = "e.";
			// 
			// xrLabel109
			// 
			this.xrLabel109.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel109.LocationFloat = new DevExpress.Utils.PointFloat(53.26335F, 1311.336F);
			this.xrLabel109.Name = "xrLabel109";
			this.xrLabel109.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel109.SizeF = new System.Drawing.SizeF(695.82F, 22F);
			this.xrLabel109.StylePriority.UseFont = false;
			this.xrLabel109.StylePriority.UseTextAlignment = false;
			this.xrLabel109.Text = "Được nhận phí dịch vụ đúng và đầy đủ theo quy định trong Giấy xác nhận này.";
			this.xrLabel109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel108
			// 
			this.xrLabel108.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel108.LocationFloat = new DevExpress.Utils.PointFloat(26.1354F, 1252.062F);
			this.xrLabel108.Name = "xrLabel108";
			this.xrLabel108.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel108.SizeF = new System.Drawing.SizeF(26.97867F, 59.27307F);
			this.xrLabel108.StylePriority.UseFont = false;
			this.xrLabel108.Text = "d.";
			// 
			// xrLabel107
			// 
			this.xrLabel107.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel107.LocationFloat = new DevExpress.Utils.PointFloat(53.26012F, 1252.062F);
			this.xrLabel107.Name = "xrLabel107";
			this.xrLabel107.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel107.SizeF = new System.Drawing.SizeF(695.8232F, 59.27344F);
			this.xrLabel107.StylePriority.UseFont = false;
			this.xrLabel107.StylePriority.UseTextAlignment = false;
			this.xrLabel107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel106
			// 
			this.xrLabel106.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel106.LocationFloat = new DevExpress.Utils.PointFloat(26.13496F, 1211.062F);
			this.xrLabel106.Name = "xrLabel106";
			this.xrLabel106.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel106.SizeF = new System.Drawing.SizeF(26.97866F, 41F);
			this.xrLabel106.StylePriority.UseFont = false;
			this.xrLabel106.Text = "c.";
			// 
			// xrLabel105
			// 
			this.xrLabel105.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel105.LocationFloat = new DevExpress.Utils.PointFloat(53.26012F, 1211.062F);
			this.xrLabel105.Name = "xrLabel105";
			this.xrLabel105.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel105.SizeF = new System.Drawing.SizeF(696.2602F, 41.00012F);
			this.xrLabel105.StylePriority.UseFont = false;
			this.xrLabel105.StylePriority.UseTextAlignment = false;
			this.xrLabel105.Text = "Thực hiện hết khả năng trong phạm vi chuyên môn để đảm bảo chất lượng dịch vụ cun" +
    "g cấp cho Bên B theo Giấy xác nhận này.";
			this.xrLabel105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel104
			// 
			this.xrLabel104.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel104.LocationFloat = new DevExpress.Utils.PointFloat(26.13496F, 1170.062F);
			this.xrLabel104.Name = "xrLabel104";
			this.xrLabel104.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel104.SizeF = new System.Drawing.SizeF(26.97866F, 40.99988F);
			this.xrLabel104.StylePriority.UseFont = false;
			this.xrLabel104.Text = "b.";
			// 
			// xrLabel103
			// 
			this.xrLabel103.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel103.LocationFloat = new DevExpress.Utils.PointFloat(53.26012F, 1170.062F);
			this.xrLabel103.Name = "xrLabel103";
			this.xrLabel103.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel103.SizeF = new System.Drawing.SizeF(695.8231F, 40.99988F);
			this.xrLabel103.StylePriority.UseFont = false;
			this.xrLabel103.StylePriority.UseTextAlignment = false;
			this.xrLabel103.Text = "Thực hiện  kiểm tra sàng lọc trước và sau tiêm chủng nhằm đảm bảo an toàn cho ngư" +
    "ời được tiêm chủng theo quy định của Bộ Y tế và các quy định pháp luật có liên q" +
    "uan.";
			this.xrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel102
			// 
			this.xrLabel102.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel102.LocationFloat = new DevExpress.Utils.PointFloat(26.19838F, 1129.062F);
			this.xrLabel102.Name = "xrLabel102";
			this.xrLabel102.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel102.SizeF = new System.Drawing.SizeF(26.97867F, 40.99988F);
			this.xrLabel102.StylePriority.UseFont = false;
			this.xrLabel102.Text = "a.";
			// 
			// xrLabel101
			// 
			this.xrLabel101.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel101.LocationFloat = new DevExpress.Utils.PointFloat(53.17704F, 1129.062F);
			this.xrLabel101.Name = "xrLabel101";
			this.xrLabel101.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel101.SizeF = new System.Drawing.SizeF(696.3434F, 41F);
			this.xrLabel101.StylePriority.UseFont = false;
			this.xrLabel101.StylePriority.UseTextAlignment = false;
			this.xrLabel101.Text = "Tuân thủ các quy trình, tiêu chuẩn của Bộ Y tế và các quy định pháp luật có liên " +
    "quan trong quá trình cung cấp dịch vụ cho Bên B.";
			this.xrLabel101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel100
			// 
			this.xrLabel100.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel100.LocationFloat = new DevExpress.Utils.PointFloat(27.13539F, 1107.13F);
			this.xrLabel100.Name = "xrLabel100";
			this.xrLabel100.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel100.SizeF = new System.Drawing.SizeF(721.7812F, 21.93225F);
			this.xrLabel100.StylePriority.UseFont = false;
			this.xrLabel100.StylePriority.UseTextAlignment = false;
			this.xrLabel100.Text = "Các quyền và nghĩa vụ của Bên A:";
			this.xrLabel100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel99
			// 
			this.xrLabel99.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel99.LocationFloat = new DevExpress.Utils.PointFloat(1.832347F, 1107.13F);
			this.xrLabel99.Name = "xrLabel99";
			this.xrLabel99.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel99.SizeF = new System.Drawing.SizeF(25.30305F, 21.93213F);
			this.xrLabel99.StylePriority.UseFont = false;
			this.xrLabel99.Text = "4.";
			// 
			// xrLabel98
			// 
			this.xrLabel98.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel98.LocationFloat = new DevExpress.Utils.PointFloat(53.26012F, 1085.13F);
			this.xrLabel98.Name = "xrLabel98";
			this.xrLabel98.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel98.SizeF = new System.Drawing.SizeF(695.7399F, 21.99988F);
			this.xrLabel98.StylePriority.UseFont = false;
			this.xrLabel98.StylePriority.UseTextAlignment = false;
			this.xrLabel98.Text = "Thanh toán phí dịch vụ cho Bên A đúng và đầy đủ theo quy định trong Giấy xác nhận" +
    " này. ";
			this.xrLabel98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel97
			// 
			this.xrLabel97.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel97.LocationFloat = new DevExpress.Utils.PointFloat(27.07363F, 1085.13F);
			this.xrLabel97.Name = "xrLabel97";
			this.xrLabel97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel97.SizeF = new System.Drawing.SizeF(26.04F, 22F);
			this.xrLabel97.StylePriority.UseFont = false;
			this.xrLabel97.Text = "h.";
			// 
			// xrLabel96
			// 
			this.xrLabel96.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel96.LocationFloat = new DevExpress.Utils.PointFloat(28.13729F, 1044.062F);
			this.xrLabel96.Name = "xrLabel96";
			this.xrLabel96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel96.SizeF = new System.Drawing.SizeF(26.04F, 41.06787F);
			this.xrLabel96.StylePriority.UseFont = false;
			this.xrLabel96.Text = "g.";
			// 
			// xrLabel95
			// 
			this.xrLabel95.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel95.LocationFloat = new DevExpress.Utils.PointFloat(54.26031F, 1044.062F);
			this.xrLabel95.Name = "xrLabel95";
			this.xrLabel95.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel95.SizeF = new System.Drawing.SizeF(695.74F, 41.06787F);
			this.xrLabel95.StylePriority.UseFont = false;
			this.xrLabel95.StylePriority.UseTextAlignment = false;
			this.xrLabel95.Text = "Tuân thủ đúng và đầy đủ các hướng dẫn, quy định của Bên A trong quá trình sử dụng" +
    " dịch vụ. Thực hiện đúng các bước trước và sau tiêm chủng theo quy trình, quy đị" +
    "nh chuyên môn của Bên A.";
			this.xrLabel95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel94
			// 
			this.xrLabel94.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel94.LocationFloat = new DevExpress.Utils.PointFloat(54.26031F, 1002.994F);
			this.xrLabel94.Name = "xrLabel94";
			this.xrLabel94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel94.SizeF = new System.Drawing.SizeF(695.74F, 41.06787F);
			this.xrLabel94.StylePriority.UseFont = false;
			this.xrLabel94.StylePriority.UseTextAlignment = false;
			this.xrLabel94.Text = "Cung cấp đầy đủ các thông tin cần thiết theo yêu cầu của Bên A và đảm bảo tính ch" +
    "ính xác của các thông tin đã cung cấp.";
			this.xrLabel94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel93
			// 
			this.xrLabel93.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel93.LocationFloat = new DevExpress.Utils.PointFloat(28.13729F, 1002.994F);
			this.xrLabel93.Name = "xrLabel93";
			this.xrLabel93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel93.SizeF = new System.Drawing.SizeF(26.04F, 41.06787F);
			this.xrLabel93.StylePriority.UseFont = false;
			this.xrLabel93.Text = "f.";
			// 
			// xrLabel92
			// 
			this.xrLabel92.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel92.LocationFloat = new DevExpress.Utils.PointFloat(81.13562F, 937.5704F);
			this.xrLabel92.Multiline = true;
			this.xrLabel92.Name = "xrLabel92";
			this.xrLabel92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel92.SizeF = new System.Drawing.SizeF(668.8647F, 21.58887F);
			this.xrLabel92.StylePriority.UseFont = false;
			this.xrLabel92.StylePriority.UseTextAlignment = false;
			this.xrLabel92.Text = "Sổ tiêm chủng; \r\n";
			this.xrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel91
			// 
			this.xrLabel91.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel91.LocationFloat = new DevExpress.Utils.PointFloat(81.13562F, 959.1596F);
			this.xrLabel91.Name = "xrLabel91";
			this.xrLabel91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel91.SizeF = new System.Drawing.SizeF(668.8647F, 21.58899F);
			this.xrLabel91.StylePriority.UseFont = false;
			this.xrLabel91.StylePriority.UseTextAlignment = false;
			this.xrLabel91.Text = "Biên lai thu tiền; ";
			this.xrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel90
			// 
			this.xrLabel90.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel90.LocationFloat = new DevExpress.Utils.PointFloat(81.19843F, 981.4054F);
			this.xrLabel90.Name = "xrLabel90";
			this.xrLabel90.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel90.SizeF = new System.Drawing.SizeF(668.8019F, 21.58887F);
			this.xrLabel90.StylePriority.UseFont = false;
			this.xrLabel90.StylePriority.UseTextAlignment = false;
			this.xrLabel90.Text = "CMND/CCCD người sử dụng dịch vụ.";
			this.xrLabel90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel69
			// 
			this.xrLabel69.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel69.LocationFloat = new DevExpress.Utils.PointFloat(54.26032F, 981.4053F);
			this.xrLabel69.Name = "xrLabel69";
			this.xrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel69.SizeF = new System.Drawing.SizeF(26.04167F, 21.58893F);
			this.xrLabel69.StylePriority.UseFont = false;
			this.xrLabel69.Text = "c.";
			// 
			// xrLabel66
			// 
			this.xrLabel66.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(54.26031F, 959.1596F);
			this.xrLabel66.Name = "xrLabel66";
			this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel66.SizeF = new System.Drawing.SizeF(26.04167F, 21.58893F);
			this.xrLabel66.StylePriority.UseFont = false;
			this.xrLabel66.Text = "b.";
			// 
			// xrLabel65
			// 
			this.xrLabel65.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(54.26031F, 937.5703F);
			this.xrLabel65.Name = "xrLabel65";
			this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel65.SizeF = new System.Drawing.SizeF(26.04167F, 21.58893F);
			this.xrLabel65.StylePriority.UseFont = false;
			this.xrLabel65.Text = "a.";
			// 
			// xrLabel64
			// 
			this.xrLabel64.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(54.26031F, 894.3248F);
			this.xrLabel64.Name = "xrLabel64";
			this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel64.SizeF = new System.Drawing.SizeF(695.74F, 42.24579F);
			this.xrLabel64.StylePriority.UseFont = false;
			this.xrLabel64.StylePriority.UseTextAlignment = false;
			this.xrLabel64.Text = "Được sử dụng dịch vụ tiêm chủng tại tất cả các Trung tâm tiêm chủng trực thuộc Bê" +
    "n A trên lãnh thổ Việt Nam khi xuất trình đầy đủ các giấy tờ sau:";
			this.xrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel63
			// 
			this.xrLabel63.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(28.13729F, 894.3249F);
			this.xrLabel63.Name = "xrLabel63";
			this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel63.SizeF = new System.Drawing.SizeF(26.04F, 108.6693F);
			this.xrLabel63.StylePriority.UseFont = false;
			this.xrLabel63.Text = "e.";
			// 
			// xrLabel62
			// 
			this.xrLabel62.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(54.26031F, 872.7356F);
			this.xrLabel62.Name = "xrLabel62";
			this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel62.SizeF = new System.Drawing.SizeF(695.74F, 21.58899F);
			this.xrLabel62.StylePriority.UseFont = false;
			this.xrLabel62.StylePriority.UseTextAlignment = false;
			this.xrLabel62.Text = "Được nhắc lịch tiêm miễn phí.";
			this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel57
			// 
			this.xrLabel57.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel57.LocationFloat = new DevExpress.Utils.PointFloat(28.13562F, 872.7356F);
			this.xrLabel57.Name = "xrLabel57";
			this.xrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel57.SizeF = new System.Drawing.SizeF(26.04167F, 21.58893F);
			this.xrLabel57.StylePriority.UseFont = false;
			this.xrLabel57.Text = "d.";
			// 
			// xrLabel55
			// 
			this.xrLabel55.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel55.LocationFloat = new DevExpress.Utils.PointFloat(28.13562F, 851.147F);
			this.xrLabel55.Name = "xrLabel55";
			this.xrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel55.SizeF = new System.Drawing.SizeF(26.04167F, 21.58893F);
			this.xrLabel55.StylePriority.UseFont = false;
			this.xrLabel55.Text = "c.";
			// 
			// xrLabel54
			// 
			this.xrLabel54.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(54.26031F, 851.147F);
			this.xrLabel54.Name = "xrLabel54";
			this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel54.SizeF = new System.Drawing.SizeF(695.74F, 21.58899F);
			this.xrLabel54.StylePriority.UseFont = false;
			this.xrLabel54.StylePriority.UseTextAlignment = false;
			this.xrLabel54.Text = "Được miễn phí khám và tư vấn về tiêm chủng trước khi tiêm.";
			this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel38
			// 
			this.xrLabel38.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(54.26031F, 828.9012F);
			this.xrLabel38.Name = "xrLabel38";
			this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel38.SizeF = new System.Drawing.SizeF(695.74F, 21.58899F);
			this.xrLabel38.StylePriority.UseFont = false;
			this.xrLabel38.StylePriority.UseTextAlignment = false;
			this.xrLabel38.Text = "Được giữ nguyên giá/phí dịch vụ trong trường hợp thị trường có biến động về giá.";
			this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel35
			// 
			this.xrLabel35.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(28.13562F, 828.9012F);
			this.xrLabel35.Name = "xrLabel35";
			this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel35.SizeF = new System.Drawing.SizeF(26.04167F, 21.58893F);
			this.xrLabel35.StylePriority.UseFont = false;
			this.xrLabel35.Text = "b.";
			// 
			// xrLabel53
			// 
			this.xrLabel53.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(54.26031F, 807.3121F);
			this.xrLabel53.Name = "xrLabel53";
			this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel53.SizeF = new System.Drawing.SizeF(695.74F, 21.58899F);
			this.xrLabel53.StylePriority.UseFont = false;
			this.xrLabel53.StylePriority.UseTextAlignment = false;
			this.xrLabel53.Text = "Được cung cấp dịch vụ tuân thủ theo quy trình, tiêu chuẩn của Bộ Y tế và quy định" +
    " của pháp luật.";
			this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel52
			// 
			this.xrLabel52.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(28.13562F, 807.3121F);
			this.xrLabel52.Name = "xrLabel52";
			this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel52.SizeF = new System.Drawing.SizeF(26.04167F, 21.58893F);
			this.xrLabel52.StylePriority.UseFont = false;
			this.xrLabel52.Text = "a.";
			// 
			// xrLabel51
			// 
			this.xrLabel51.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(28.14034F, 786.3121F);
			this.xrLabel51.Name = "xrLabel51";
			this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel51.SizeF = new System.Drawing.SizeF(721.86F, 21F);
			this.xrLabel51.StylePriority.UseFont = false;
			this.xrLabel51.StylePriority.UseTextAlignment = false;
			this.xrLabel51.Text = "Các quyền và nghĩa vụ của Bên B:";
			this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel50
			// 
			this.xrLabel50.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(1.893871F, 786.3121F);
			this.xrLabel50.Name = "xrLabel50";
			this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel50.SizeF = new System.Drawing.SizeF(25.30297F, 42.58899F);
			this.xrLabel50.StylePriority.UseFont = false;
			this.xrLabel50.Text = "3.";
			// 
			// xrLabel48
			// 
			this.xrLabel48.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(54.17728F, 747.7699F);
			this.xrLabel48.Name = "xrLabel48";
			this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel48.SizeF = new System.Drawing.SizeF(695.74F, 38.54218F);
			this.xrLabel48.StylePriority.UseFont = false;
			this.xrLabel48.StylePriority.UseTextAlignment = false;
			this.xrLabel48.Text = "Các chi phí phát sinh ngoài gói dịch vụ đã thỏa thuận trong Giấy xác nhận này sẽ " +
    "được thanh toán theo quy định của Bên A tại thời điểm thanh toán.";
			this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel47
			// 
			this.xrLabel47.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(27.07363F, 747.7698F);
			this.xrLabel47.Name = "xrLabel47";
			this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel47.SizeF = new System.Drawing.SizeF(26.98F, 38.54224F);
			this.xrLabel47.StylePriority.UseFont = false;
			this.xrLabel47.Text = "g.";
			// 
			// xrLabel46
			// 
			this.xrLabel46.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(52.08333F, 684.6036F);
			this.xrLabel46.Name = "xrLabel46";
			this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel46.SizeF = new System.Drawing.SizeF(695.7396F, 63.1662F);
			this.xrLabel46.StylePriority.UseFont = false;
			this.xrLabel46.StylePriority.UseTextAlignment = false;
			this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel45
			// 
			this.xrLabel45.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(25.10335F, 684.6036F);
			this.xrLabel45.Name = "xrLabel45";
			this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel45.SizeF = new System.Drawing.SizeF(26.98001F, 63.1662F);
			this.xrLabel45.StylePriority.UseFont = false;
			this.xrLabel45.Text = "f.";
			// 
			// xrLabel44
			// 
			this.xrLabel44.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(52.08332F, 661.6042F);
			this.xrLabel44.Name = "xrLabel44";
			this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel44.SizeF = new System.Drawing.SizeF(695.9062F, 22F);
			this.xrLabel44.StylePriority.UseFont = false;
			this.xrLabel44.StylePriority.UseTextAlignment = false;
			this.xrLabel44.Text = "Bên A sẽ không hoàn trả phí dịch vụ trong các trường hợp thay đổi dịch vụ từ phía" +
    " Bên B. ";
			this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel43
			// 
			this.xrLabel43.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(25.10334F, 661.6042F);
			this.xrLabel43.Name = "xrLabel43";
			this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel43.SizeF = new System.Drawing.SizeF(26.98F, 22F);
			this.xrLabel43.StylePriority.UseFont = false;
			this.xrLabel43.Text = "e.";
			// 
			// xrLabel42
			// 
			this.xrLabel42.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(52.08332F, 621.6042F);
			this.xrLabel42.Name = "xrLabel42";
			this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel42.SizeF = new System.Drawing.SizeF(695.9062F, 40F);
			this.xrLabel42.StylePriority.UseFont = false;
			this.xrLabel42.StylePriority.UseTextAlignment = false;
			this.xrLabel42.Text = "Bên B đặt cọc, thanh toán phí dịch vụ cho Bên A bằng tiền Việt Nam đồng bằng tiền" +
    " mặt hoặc chuyển khoản vào tài khoản của Bên A.";
			this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel41
			// 
			this.xrLabel41.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(25.10334F, 621.6042F);
			this.xrLabel41.Name = "xrLabel41";
			this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel41.SizeF = new System.Drawing.SizeF(26.98F, 40F);
			this.xrLabel41.StylePriority.UseFont = false;
			this.xrLabel41.Text = "d.";
			// 
			// xrLabel40
			// 
			this.xrLabel40.CanShrink = true;
			this.xrLabel40.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel40.KeepTogether = true;
			this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(52.08332F, 539.6041F);
			this.xrLabel40.Name = "xrLabel40";
			this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel40.SizeF = new System.Drawing.SizeF(695.9062F, 82F);
			this.xrLabel40.StylePriority.UseFont = false;
			this.xrLabel40.StylePriority.UseTextAlignment = false;
			this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel39
			// 
			this.xrLabel39.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(25.04167F, 539.6041F);
			this.xrLabel39.Name = "xrLabel39";
			this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel39.SizeF = new System.Drawing.SizeF(26.98F, 82.00006F);
			this.xrLabel39.StylePriority.UseFont = false;
			this.xrLabel39.Text = "c.";
			// 
			// xrLabel37
			// 
			this.xrLabel37.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(52.08332F, 423.6041F);
			this.xrLabel37.Name = "xrLabel37";
			this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel37.SizeF = new System.Drawing.SizeF(695.8231F, 116F);
			this.xrLabel37.StylePriority.UseFont = false;
			this.xrLabel37.StylePriority.UseTextAlignment = false;
			this.xrLabel37.Text = "Trong vòng 30 (ba mươi) ngày kể từ ngày đặt cọc, Bên B phải thanh toán cho Bên A " +
    "100% phí dịch vụ theo \t ";
			this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel36
			// 
			this.xrLabel36.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(25.10333F, 423.1459F);
			this.xrLabel36.Name = "xrLabel36";
			this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel36.SizeF = new System.Drawing.SizeF(26.98F, 116.4583F);
			this.xrLabel36.StylePriority.UseFont = false;
			this.xrLabel36.Text = "b.";
			// 
			// xrLabel33
			// 
			this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(52.08334F, 380.4374F);
			this.xrLabel33.Multiline = true;
			this.xrLabel33.Name = "xrLabel33";
			this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel33.SizeF = new System.Drawing.SizeF(695.9062F, 42.70837F);
			this.xrLabel33.StylePriority.UseFont = false;
			this.xrLabel33.StylePriority.UseTextAlignment = false;
			this.xrLabel33.Text = "               Bên B đặt cọc cho Bên A số tiền: ___________ đồng (Bằng chữ: _____" +
    "_________________) ngay khi ký Giấy xác nhận này để đảm bảo sử dụng dịch vụ gói " +
    "tiêm chủng vắc xin của Bên A. ";
			this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel32
			// 
			this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 380.4374F);
			this.xrLabel32.Name = "xrLabel32";
			this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel32.SizeF = new System.Drawing.SizeF(26.04167F, 42.7084F);
			this.xrLabel32.StylePriority.UseFont = false;
			this.xrLabel32.Text = "a.";
			// 
			// xrLabel31
			// 
			this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 358.8126F);
			this.xrLabel31.Name = "xrLabel31";
			this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel31.SizeF = new System.Drawing.SizeF(721.86F, 21.62482F);
			this.xrLabel31.StylePriority.UseFont = false;
			this.xrLabel31.Text = "Đặt cọc và thanh toán: ";
			// 
			// xrLabel30
			// 
			this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(0F, 358.8126F);
			this.xrLabel30.Name = "xrLabel30";
			this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel30.SizeF = new System.Drawing.SizeF(26.04167F, 64.33322F);
			this.xrLabel30.StylePriority.UseFont = false;
			this.xrLabel30.Text = "2.";
			// 
			// xrLabel29
			// 
			this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 299.6877F);
			this.xrLabel29.Name = "xrLabel29";
			this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel29.SizeF = new System.Drawing.SizeF(721.8647F, 59.12494F);
			this.xrLabel29.StylePriority.UseFont = false;
			this.xrLabel29.StylePriority.UseTextAlignment = false;
			this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel28
			// 
			this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(0F, 299.6876F);
			this.xrLabel28.Name = "xrLabel28";
			this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel28.SizeF = new System.Drawing.SizeF(26.04167F, 59.12491F);
			this.xrLabel28.StylePriority.UseFont = false;
			this.xrLabel28.Text = "1.";
			// 
			// xrLabel56
			// 
			this.xrLabel56.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46.99996F);
			this.xrLabel56.Name = "xrLabel56";
			this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel56.SizeF = new System.Drawing.SizeF(75F, 22.00002F);
			this.xrLabel56.StylePriority.UseFont = false;
			this.xrLabel56.StylePriority.UseTextAlignment = false;
			this.xrLabel56.Text = "Và";
			this.xrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel34
			// 
			this.xrLabel34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiaChiNoiCap]")});
			this.xrLabel34.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(586.4263F, 115.6875F);
			this.xrLabel34.Name = "xrLabel34";
			this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel34.SizeF = new System.Drawing.SizeF(161.4801F, 22.99992F);
			this.xrLabel34.StylePriority.UseFont = false;
			this.xrLabel34.StylePriority.UseTextAlignment = false;
			this.xrLabel34.Text = "xrLabel34";
			this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel87
			// 
			this.xrLabel87.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NguoiDaiDien]")});
			this.xrLabel87.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel87.LocationFloat = new DevExpress.Utils.PointFloat(107.6766F, 0F);
			this.xrLabel87.Name = "xrLabel87";
			this.xrLabel87.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel87.SizeF = new System.Drawing.SizeF(306.6054F, 25F);
			this.xrLabel87.StylePriority.UseFont = false;
			this.xrLabel87.StylePriority.UseTextAlignment = false;
			this.xrLabel87.Text = "xrLabel87";
			this.xrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel71
			// 
			this.xrLabel71.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuocTich_NguoiDKy]")});
			this.xrLabel71.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel71.LocationFloat = new DevExpress.Utils.PointFloat(589.1542F, 92.68755F);
			this.xrLabel71.Name = "xrLabel71";
			this.xrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel71.SizeF = new System.Drawing.SizeF(159.2724F, 22.99998F);
			this.xrLabel71.StylePriority.UseFont = false;
			this.xrLabel71.Text = "xrLabel71";
			// 
			// xrLabel70
			// 
			this.xrLabel70.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(1.363546F, 115.6875F);
			this.xrLabel70.Name = "xrLabel70";
			this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel70.SizeF = new System.Drawing.SizeF(188.1875F, 23F);
			this.xrLabel70.StylePriority.UseFont = false;
			this.xrLabel70.Text = "CMND/CCCD/Hộ chiếu số:";
			// 
			// xrLabel14
			// 
			this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiaChi_NguoiDKy]")});
			this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(111.3637F, 161.6876F);
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(637.0629F, 23.00003F);
			this.xrLabel14.StylePriority.UseFont = false;
			this.xrLabel14.Text = "xrLabel14";
			// 
			// xrLabel13
			// 
			this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiaChiHoKhau]")});
			this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(131.3636F, 138.6876F);
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(616.626F, 23F);
			this.xrLabel13.StylePriority.UseFont = false;
			this.xrLabel13.Text = "xrLabel13";
			// 
			// xrLabel12
			// 
			this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(514.1542F, 115.6875F);
			this.xrLabel12.Name = "xrLabel12";
			this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel12.SizeF = new System.Drawing.SizeF(72.27216F, 23.00002F);
			this.xrLabel12.StylePriority.UseFont = false;
			this.xrLabel12.StylePriority.UseTextAlignment = false;
			this.xrLabel12.Text = "Nơi cấp:";
			this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel11
			// 
			this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(345.4917F, 115.6873F);
			this.xrLabel11.Name = "xrLabel11";
			this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel11.SizeF = new System.Drawing.SizeF(70F, 23.00003F);
			this.xrLabel11.StylePriority.UseFont = false;
			this.xrLabel11.StylePriority.UseTextAlignment = false;
			this.xrLabel11.Text = "Ngày cấp: ";
			this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel10
			// 
			this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CMND_NguoiDKy]")});
			this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(189.5511F, 115.6875F);
			this.xrLabel10.Name = "xrLabel10";
			this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel10.SizeF = new System.Drawing.SizeF(155.9406F, 23F);
			this.xrLabel10.StylePriority.UseFont = false;
			this.xrLabel10.Text = "[CMND_NguoiDKy]";
			// 
			// xrLabel9
			// 
			this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(514.1542F, 92.68755F);
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(75F, 23F);
			this.xrLabel9.StylePriority.UseFont = false;
			this.xrLabel9.Text = "Quốc tịch: ";
			// 
			// xrLabel72
			// 
			this.xrLabel72.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(1.363546F, 92.68755F);
			this.xrLabel72.Name = "xrLabel72";
			this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel72.SizeF = new System.Drawing.SizeF(72.37572F, 22F);
			this.xrLabel72.StylePriority.UseFont = false;
			this.xrLabel72.Text = "Họ và tên:";
			// 
			// xrLabel15
			// 
			this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DTCoDinh_NguoiDKy]")});
			this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
			this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(344.8844F, 25F);
			this.xrLabel15.Name = "xrLabel15";
			this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel15.SizeF = new System.Drawing.SizeF(199.9171F, 23F);
			this.xrLabel15.StylePriority.UseFont = false;
			this.xrLabel15.Text = "xrLabel15";
			this.xrLabel15.Visible = false;
			// 
			// xrLabel6
			// 
			this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 11.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0.7386984F, 68.99997F);
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(191.7905F, 23.00003F);
			this.xrLabel6.StylePriority.UseFont = false;
			this.xrLabel6.StylePriority.UseTextAlignment = false;
			this.xrLabel6.Text = "BÊN SỬ DỤNG DỊCH VỤ:";
			// 
			// xrLabel8
			// 
			this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dob_NguoiDKy]")});
			this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(420.4917F, 92.68752F);
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(93.66254F, 22.99998F);
			this.xrLabel8.StylePriority.UseFont = false;
			this.xrLabel8.Text = "xrLabel8";
			// 
			// xrLabel79
			// 
			this.xrLabel79.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NgayThangNoiCap]")});
			this.xrLabel79.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel79.LocationFloat = new DevExpress.Utils.PointFloat(415.4917F, 115.6875F);
			this.xrLabel79.Name = "xrLabel79";
			this.xrLabel79.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel79.SizeF = new System.Drawing.SizeF(98.66245F, 23.00012F);
			this.xrLabel79.StylePriority.UseFont = false;
			this.xrLabel79.StylePriority.UseTextAlignment = false;
			this.xrLabel79.Text = "xrLabel79";
			this.xrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel7
			// 
			this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TenNguoiDKy]")});
			this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(73.73918F, 92.68737F);
			this.xrLabel7.Name = "xrLabel7";
			this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel7.SizeF = new System.Drawing.SizeF(271.7525F, 22.99998F);
			this.xrLabel7.StylePriority.UseFont = false;
			this.xrLabel7.Text = "xrLabel7";
			// 
			// xrLabel110
			// 
			this.xrLabel110.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ChucVu]")});
			this.xrLabel110.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel110.LocationFloat = new DevExpress.Utils.PointFloat(484.8653F, 0F);
			this.xrLabel110.Name = "xrLabel110";
			this.xrLabel110.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel110.SizeF = new System.Drawing.SizeF(264.1346F, 24.99998F);
			this.xrLabel110.StylePriority.UseFont = false;
			this.xrLabel110.StylePriority.UseTextAlignment = false;
			this.xrLabel110.Text = "xrLabel110";
			this.xrLabel110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel73
			// 
			this.xrLabel73.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(345.4917F, 92.68735F);
			this.xrLabel73.Name = "xrLabel73";
			this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel73.SizeF = new System.Drawing.SizeF(75F, 23F);
			this.xrLabel73.StylePriority.UseFont = false;
			this.xrLabel73.Text = "Ngày sinh:";
			// 
			// xrLabel78
			// 
			this.xrLabel78.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel78.LocationFloat = new DevExpress.Utils.PointFloat(1.363595F, 138.6875F);
			this.xrLabel78.Name = "xrLabel78";
			this.xrLabel78.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel78.SizeF = new System.Drawing.SizeF(130F, 22.99997F);
			this.xrLabel78.StylePriority.UseFont = false;
			this.xrLabel78.Text = "Địa chỉ thường trú:";
			// 
			// xrLabel27
			// 
			this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(0.3635837F, 25.00002F);
			this.xrLabel27.Name = "xrLabel27";
			this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel27.SizeF = new System.Drawing.SizeF(220.6991F, 21.99997F);
			this.xrLabel27.StylePriority.UseFont = false;
			this.xrLabel27.Text = "(Sau đây viết tắt là Bên A).";
			// 
			// xrLabel26
			// 
			this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(0.7386984F, 0F);
			this.xrLabel26.Name = "xrLabel26";
			this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel26.SizeF = new System.Drawing.SizeF(105.9999F, 25F);
			this.xrLabel26.StylePriority.UseFont = false;
			this.xrLabel26.StylePriority.UseTextAlignment = false;
			this.xrLabel26.Text = "Người đại diện:";
			this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel83
			// 
			this.xrLabel83.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DTDD_NguoiDKy]")});
			this.xrLabel83.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel83.LocationFloat = new DevExpress.Utils.PointFloat(81.36358F, 184.6876F);
			this.xrLabel83.Name = "xrLabel83";
			this.xrLabel83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel83.SizeF = new System.Drawing.SizeF(666.6261F, 22.99988F);
			this.xrLabel83.StylePriority.UseFont = false;
			this.xrLabel83.Text = "xrLabel83";
			// 
			// xrLabel82
			// 
			this.xrLabel82.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel82.LocationFloat = new DevExpress.Utils.PointFloat(1.363624F, 161.6876F);
			this.xrLabel82.Name = "xrLabel82";
			this.xrLabel82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel82.SizeF = new System.Drawing.SizeF(110F, 23.00003F);
			this.xrLabel82.StylePriority.UseFont = false;
			this.xrLabel82.Text = "Địa chỉ liên lạc:";
			// 
			// xrLabel81
			// 
			this.xrLabel81.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel81.LocationFloat = new DevExpress.Utils.PointFloat(1.363624F, 184.6876F);
			this.xrLabel81.Name = "xrLabel81";
			this.xrLabel81.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel81.SizeF = new System.Drawing.SizeF(80F, 23F);
			this.xrLabel81.StylePriority.UseFont = false;
			this.xrLabel81.Text = "Điện thoại: ";
			// 
			// xrLabel5
			// 
			this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(414.2821F, 0F);
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(70.58322F, 25F);
			this.xrLabel5.StylePriority.UseFont = false;
			this.xrLabel5.StylePriority.UseTextAlignment = false;
			this.xrLabel5.Text = "Chức vụ: ";
			this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel17
			// 
			this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(1.363541F, 207.6876F);
			this.xrLabel17.Name = "xrLabel17";
			this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel17.SizeF = new System.Drawing.SizeF(746.6262F, 23F);
			this.xrLabel17.StylePriority.UseFont = false;
			this.xrLabel17.StylePriority.UseTextAlignment = false;
			this.xrLabel17.Text = "  *Thông tin người được tiêm vắc xin:";
			// 
			// xrLabel77
			// 
			this.xrLabel77.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel77.LocationFloat = new DevExpress.Utils.PointFloat(1.363627F, 230.6876F);
			this.xrLabel77.Name = "xrLabel77";
			this.xrLabel77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel77.SizeF = new System.Drawing.SizeF(75F, 23F);
			this.xrLabel77.StylePriority.UseFont = false;
			this.xrLabel77.Text = "Họ và tên:";
			// 
			// xrLabel85
			// 
			this.xrLabel85.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuocTich_NguoiTiem]")});
			this.xrLabel85.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel85.LocationFloat = new DevExpress.Utils.PointFloat(598.5078F, 230.6877F);
			this.xrLabel85.Name = "xrLabel85";
			this.xrLabel85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel85.SizeF = new System.Drawing.SizeF(149.4819F, 22.99994F);
			this.xrLabel85.StylePriority.UseFont = false;
			this.xrLabel85.Text = "xrLabel85";
			// 
			// xrLabel20
			// 
			this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dob_NguoiTiem]")});
			this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(442.4657F, 230.6876F);
			this.xrLabel20.Name = "xrLabel20";
			this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel20.SizeF = new System.Drawing.SizeF(81.04218F, 23F);
			this.xrLabel20.StylePriority.UseFont = false;
			this.xrLabel20.Text = "xrLabel20";
			// 
			// xrLabel18
			// 
			this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TenNguoiTiem]")});
			this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(76.36361F, 230.6876F);
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(291.102F, 22.99997F);
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.Text = "xrLabel18";
			// 
			// xrLabel19
			// 
			this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(523.5078F, 230.6876F);
			this.xrLabel19.Name = "xrLabel19";
			this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel19.SizeF = new System.Drawing.SizeF(75F, 23F);
			this.xrLabel19.StylePriority.UseFont = false;
			this.xrLabel19.Text = "Quốc tịch: ";
			// 
			// xrLabel84
			// 
			this.xrLabel84.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel84.LocationFloat = new DevExpress.Utils.PointFloat(367.4657F, 230.6876F);
			this.xrLabel84.Name = "xrLabel84";
			this.xrLabel84.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel84.SizeF = new System.Drawing.SizeF(75F, 23F);
			this.xrLabel84.StylePriority.UseFont = false;
			this.xrLabel84.Text = "Ngày sinh:";
			// 
			// xrLabel22
			// 
			this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(1.363627F, 253.6876F);
			this.xrLabel22.Name = "xrLabel22";
			this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel22.SizeF = new System.Drawing.SizeF(219.6991F, 23F);
			this.xrLabel22.StylePriority.UseFont = false;
			this.xrLabel22.Text = "(Sau đây viết tắt là Bên B).";
			// 
			// xrLabel16
			// 
			this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(0F, 276.6876F);
			this.xrLabel16.Multiline = true;
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(747.9897F, 23F);
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.StylePriority.UseTextAlignment = false;
			this.xrLabel16.Text = "Hai Bên xác nhận nội dung cung cấp và sử dụng dịch vụ gói tiêm chủng vắc xin theo" +
    " các điều khoản và điều kiện như sau:";
			this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// xrLabel21
			// 
			this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 11.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
			this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(1.363627F, 25.24993F);
			this.xrLabel21.Name = "xrLabel21";
			this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel21.SizeF = new System.Drawing.SizeF(745.0629F, 25F);
			this.xrLabel21.StylePriority.UseFont = false;
			this.xrLabel21.StylePriority.UseTextAlignment = false;
			this.xrLabel21.Text = "ĐỊA ĐIỂM THỰC HIỆN DỊCH VỤ:";
			this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel23
			// 
			this.xrLabel23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HTMLDiaDiem]")});
			this.xrLabel23.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(0.6552696F, 50.24993F);
			this.xrLabel23.Name = "xrLabel23";
			this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel23.SizeF = new System.Drawing.SizeF(745.7713F, 25F);
			this.xrLabel23.StylePriority.UseFont = false;
			this.xrLabel23.StylePriority.UseTextAlignment = false;
			this.xrLabel23.Text = "xrLabel23";
			this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel24
			// 
			this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TAX]")});
			this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(0.3635724F, 75.24992F);
			this.xrLabel24.Name = "xrLabel24";
			this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel24.SizeF = new System.Drawing.SizeF(746.063F, 25F);
			this.xrLabel24.StylePriority.UseFont = false;
			this.xrLabel24.StylePriority.UseTextAlignment = false;
			this.xrLabel24.Text = "xrLabel24";
			this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel24.TextFormatString = "Mã số doanh nghiệp/ mã số thuế: {0}";
			// 
			// xrLabel25
			// 
			this.xrLabel25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiaChiTT]")});
			this.xrLabel25.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(0.8323352F, 100.25F);
			this.xrLabel25.Multiline = true;
			this.xrLabel25.Name = "xrLabel25";
			this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel25.SizeF = new System.Drawing.SizeF(729.2822F, 25F);
			this.xrLabel25.StylePriority.UseFont = false;
			this.xrLabel25.StylePriority.UseTextAlignment = false;
			this.xrLabel25.Text = "xrLabel25";
			this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel25.TextFormatString = "Địa chỉ: {0}";
			// 
			// xrLabel49
			// 
			this.xrLabel49.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
			this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(0.7386525F, 29.25008F);
			this.xrLabel49.Multiline = true;
			this.xrLabel49.Name = "xrLabel49";
			this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel49.SizeF = new System.Drawing.SizeF(717.2208F, 22F);
			this.xrLabel49.StylePriority.UseFont = false;
			this.xrLabel49.StylePriority.UseTextAlignment = false;
			this.xrLabel49.Text = "GÓI TIÊM CHỦNG VẮC XIN";
			this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrLabel3
			// 
			this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 11.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 131.7917F);
			this.xrLabel3.Multiline = true;
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(751.6249F, 22F);
			this.xrLabel3.StylePriority.UseFont = false;
			this.xrLabel3.StylePriority.UseTextAlignment = false;
			this.xrLabel3.Text = "BÊN CUNG CẤP DỊCH VỤ:";
			this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel2
			// 
			this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SoHDong]")});
			this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 13F);
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0.3751119F, 57.41666F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(717.5844F, 23F);
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.StylePriority.UseTextAlignment = false;
			this.xrLabel2.Text = "[SoHDong]";
			this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrLabel1
			// 
			this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0.3751119F, 0F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(717.5844F, 22F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "XÁC NHẬN CUNG CẤP VÀ SỬ DỤNG DỊCH VỤ \r\n";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrLabel4
			// 
			this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiaChiTTT]")});
			this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 11.5F);
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0.3751119F, 94.41668F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(751.6249F, 29.16668F);
			this.xrLabel4.StylePriority.UseFont = false;
			this.xrLabel4.Text = "xrLabel4";
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 110F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrBarCode2
			// 
			this.xrBarCode2.AutoModule = true;
			this.xrBarCode2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PatientHospitalID]")});
			this.xrBarCode2.LocationFloat = new DevExpress.Utils.PointFloat(585.625F, 0F);
			this.xrBarCode2.Name = "xrBarCode2";
			this.xrBarCode2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrBarCode2.SizeF = new System.Drawing.SizeF(165.9999F, 42.12506F);
			this.xrBarCode2.StylePriority.UsePadding = false;
			this.xrBarCode2.StylePriority.UseTextAlignment = false;
			code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto;
			this.xrBarCode2.Symbology = code128Generator1;
			this.xrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// BottomMargin
			// 
			this.BottomMargin.HeightF = 87F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel49,
            this.xrLabel3,
            this.xrBarCode2});
			this.ReportHeader.HeightF = 153.7917F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrPictureBox1
			// 
			this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0.3751068F, 0F);
			this.xrPictureBox1.Name = "xrPictureBox1";
			this.xrPictureBox1.SizeF = new System.Drawing.SizeF(220.6876F, 77.61165F);
			this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
			// 
			// rep_HopDong_Vaccine1
			// 
			this.rep_HopDong_Vaccine1.DataSetName = "rep_HopDong_Vaccine";
			this.rep_HopDong_Vaccine1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrTable1});
			this.PageFooter.HeightF = 84.79173F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Visible = false;
			// 
			// xrPageInfo2
			// 
			this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrPageInfo2.Name = "xrPageInfo2";
			this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo2.SizeF = new System.Drawing.SizeF(750.7711F, 23F);
			this.xrPageInfo2.StylePriority.UseTextAlignment = false;
			this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			this.xrPageInfo2.TextFormatString = "{0}";
			// 
			// xrTable1
			// 
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.99995F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(752F, 61.79173F);
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 1D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(144)))));
			this.xrTableCell1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel67,
            this.xrLabel89,
            this.xrLabel74,
            this.xrLabel75,
            this.xrLabel76,
            this.xrLabel80,
            this.xrLabel86,
            this.xrLabel88,
            this.xrLabel68});
			this.xrTableCell1.ForeColor = System.Drawing.Color.Black;
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.StylePriority.UseBackColor = false;
			this.xrTableCell1.StylePriority.UseForeColor = false;
			this.xrTableCell1.Weight = 3D;
			// 
			// xrLabel67
			// 
			this.xrLabel67.BorderColor = System.Drawing.Color.Black;
			this.xrLabel67.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrLabel67.ForeColor = System.Drawing.Color.White;
			this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(7F, 11.99997F);
			this.xrLabel67.Name = "xrLabel67";
			this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel67.SizeF = new System.Drawing.SizeF(608.4161F, 23F);
			this.xrLabel67.StylePriority.UseBorderColor = false;
			this.xrLabel67.StylePriority.UseFont = false;
			this.xrLabel67.StylePriority.UseForeColor = false;
			this.xrLabel67.Text = "CÔNG TY CỔ PHẦN VACXIN VIỆT NAM - CHI NHÁNH THÀNH PHỐ HỒ CHÍ MINH.";
			// 
			// xrLabel89
			// 
			this.xrLabel89.Font = new System.Drawing.Font("Times New Roman", 8.5F);
			this.xrLabel89.ForeColor = System.Drawing.Color.White;
			this.xrLabel89.LocationFloat = new DevExpress.Utils.PointFloat(674.7505F, 34.99997F);
			this.xrLabel89.Name = "xrLabel89";
			this.xrLabel89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel89.SizeF = new System.Drawing.SizeF(74.24945F, 23F);
			this.xrLabel89.StylePriority.UseFont = false;
			this.xrLabel89.StylePriority.UseForeColor = false;
			this.xrLabel89.Text = "www.vnvc.vn";
			// 
			// xrLabel74
			// 
			this.xrLabel74.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiaChiCongTyTiem]")});
			this.xrLabel74.Font = new System.Drawing.Font("Times New Roman", 8.5F);
			this.xrLabel74.ForeColor = System.Drawing.Color.White;
			this.xrLabel74.LocationFloat = new DevExpress.Utils.PointFloat(49.08295F, 34.99997F);
			this.xrLabel74.Name = "xrLabel74";
			this.xrLabel74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel74.SizeF = new System.Drawing.SizeF(324.9589F, 23F);
			this.xrLabel74.StylePriority.UseFont = false;
			this.xrLabel74.StylePriority.UseForeColor = false;
			this.xrLabel74.Text = "xrLabel74";
			// 
			// xrLabel75
			// 
			this.xrLabel75.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel75.ForeColor = System.Drawing.Color.White;
			this.xrLabel75.LocationFloat = new DevExpress.Utils.PointFloat(374.0418F, 34.99997F);
			this.xrLabel75.Name = "xrLabel75";
			this.xrLabel75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel75.SizeF = new System.Drawing.SizeF(60.12573F, 23F);
			this.xrLabel75.StylePriority.UseFont = false;
			this.xrLabel75.StylePriority.UseForeColor = false;
			this.xrLabel75.Text = "Điện thoại:";
			// 
			// xrLabel76
			// 
			this.xrLabel76.Font = new System.Drawing.Font("Times New Roman", 8.5F);
			this.xrLabel76.ForeColor = System.Drawing.Color.White;
			this.xrLabel76.LocationFloat = new DevExpress.Utils.PointFloat(432.7485F, 34.99997F);
			this.xrLabel76.Name = "xrLabel76";
			this.xrLabel76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel76.SizeF = new System.Drawing.SizeF(72.04199F, 23F);
			this.xrLabel76.StylePriority.UseFont = false;
			this.xrLabel76.StylePriority.UseForeColor = false;
			this.xrLabel76.Text = "028.93372138";
			// 
			// xrLabel80
			// 
			this.xrLabel80.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel80.ForeColor = System.Drawing.Color.White;
			this.xrLabel80.LocationFloat = new DevExpress.Utils.PointFloat(509.7905F, 34.99997F);
			this.xrLabel80.Name = "xrLabel80";
			this.xrLabel80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel80.SizeF = new System.Drawing.SizeF(45.45905F, 23F);
			this.xrLabel80.StylePriority.UseFont = false;
			this.xrLabel80.StylePriority.UseForeColor = false;
			this.xrLabel80.Text = "Hotline:";
			// 
			// xrLabel86
			// 
			this.xrLabel86.Font = new System.Drawing.Font("Times New Roman", 8.5F);
			this.xrLabel86.ForeColor = System.Drawing.Color.White;
			this.xrLabel86.LocationFloat = new DevExpress.Utils.PointFloat(553.2495F, 34.99997F);
			this.xrLabel86.Name = "xrLabel86";
			this.xrLabel86.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel86.SizeF = new System.Drawing.SizeF(75.04199F, 23F);
			this.xrLabel86.StylePriority.UseFont = false;
			this.xrLabel86.StylePriority.UseForeColor = false;
			this.xrLabel86.Text = "028.93372138.";
			// 
			// xrLabel88
			// 
			this.xrLabel88.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel88.ForeColor = System.Drawing.Color.White;
			this.xrLabel88.LocationFloat = new DevExpress.Utils.PointFloat(628.2915F, 34.99997F);
			this.xrLabel88.Name = "xrLabel88";
			this.xrLabel88.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel88.SizeF = new System.Drawing.SizeF(49.45905F, 23F);
			this.xrLabel88.StylePriority.UseFont = false;
			this.xrLabel88.StylePriority.UseForeColor = false;
			this.xrLabel88.Text = "Website:";
			// 
			// xrLabel68
			// 
			this.xrLabel68.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel68.ForeColor = System.Drawing.Color.White;
			this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(7F, 34.99997F);
			this.xrLabel68.Name = "xrLabel68";
			this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel68.SizeF = new System.Drawing.SizeF(44.08289F, 23F);
			this.xrLabel68.StylePriority.UseFont = false;
			this.xrLabel68.StylePriority.UseForeColor = false;
			this.xrLabel68.Text = "Địa chỉ:";
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Visible = false;
			// 
			// ReportFooter
			// 
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel61,
            this.xrLabel60,
            this.xrLabel59,
            this.xrLabel58});
			this.ReportFooter.HeightF = 215.4546F;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// xrLabel61
			// 
			this.xrLabel61.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Italic);
			this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(61F, 34.99997F);
			this.xrLabel61.Name = "xrLabel61";
			this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel61.SizeF = new System.Drawing.SizeF(163.5417F, 19.79167F);
			this.xrLabel61.StylePriority.UseFont = false;
			this.xrLabel61.StylePriority.UseTextAlignment = false;
			this.xrLabel61.Text = "(Ký, ghi rõ họ tên)";
			this.xrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel60
			// 
			this.xrLabel60.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Italic);
			this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(526.6678F, 36.24999F);
			this.xrLabel60.Name = "xrLabel60";
			this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel60.SizeF = new System.Drawing.SizeF(163.5417F, 19.79167F);
			this.xrLabel60.StylePriority.UseFont = false;
			this.xrLabel60.StylePriority.UseTextAlignment = false;
			this.xrLabel60.Text = "(Ký, ghi rõ họ tên)";
			this.xrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel59
			// 
			this.xrLabel59.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(569.2915F, 11.25F);
			this.xrLabel59.Name = "xrLabel59";
			this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel59.SizeF = new System.Drawing.SizeF(80.20834F, 25F);
			this.xrLabel59.StylePriority.UseFont = false;
			this.xrLabel59.StylePriority.UseTextAlignment = false;
			this.xrLabel59.Text = "BÊN B";
			this.xrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel58
			// 
			this.xrLabel58.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(97.3132F, 9.999974F);
			this.xrLabel58.Name = "xrLabel58";
			this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel58.SizeF = new System.Drawing.SizeF(80.20834F, 25F);
			this.xrLabel58.StylePriority.UseFont = false;
			this.xrLabel58.StylePriority.UseTextAlignment = false;
			this.xrLabel58.Text = "BÊN A";
			this.xrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel140
			// 
			this.xrLabel140.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel140.LocationFloat = new DevExpress.Utils.PointFloat(25.70782F, 1543.201F);
			this.xrLabel140.Name = "xrLabel140";
			this.xrLabel140.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel140.SizeF = new System.Drawing.SizeF(721.7812F, 60.18201F);
			this.xrLabel140.StylePriority.UseFont = false;
			this.xrLabel140.StylePriority.UseTextAlignment = false;
			this.xrLabel140.Text = "Giấy xác nhận này có hiệu lực kể từ ngày hai Bên ký và Bên B đã thanh toán phí dịch vụ theo quy định" +
		" trong Giấy xác nhận này. Giấy xác nhận này được lập thành 02 (hai) bản có giá trị pháp lý như nhau, mỗi" +
		" Bên giữ 01 (một) bản.";
		this.xrLabel140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
			// 
			// rptHopDong_VaccineV2
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter,
            this.PageHeader,
            this.ReportFooter});
			this.DataMember = "Table1";
			this.DataSource = this.rep_HopDong_Vaccine1;
			this.Margins = new System.Drawing.Printing.Margins(59, 39, 110, 87);
			this.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
			this.Version = "21.2";
			((System.ComponentModel.ISupportInitialize)(this.tableHTML)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rep_HopDong_Vaccine1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}
}
