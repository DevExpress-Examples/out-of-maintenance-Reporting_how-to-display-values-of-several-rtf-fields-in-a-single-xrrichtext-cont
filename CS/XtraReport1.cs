using DevExpress.XtraRichEdit;

namespace RepConcatRtfFields {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        private RichEditDocumentServer richEditDocumentServer;
        
        public XtraReport1() {
            InitializeComponent();
            
            richEditDocumentServer = new RichEditDocumentServer();
        }

        private void XtraReport1_DataSourceDemanded(object sender, System.EventArgs e) {
            this.DataSource = ManualDataSet.CreateData();
        }

        private void xrRichText1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            string rtfColumn1 = GetCurrentColumnValue("RtfColumn1").ToString();
            string rtfColumn2 = GetCurrentColumnValue("RtfColumn2").ToString();

            richEditDocumentServer.RtfText = rtfColumn1;
            richEditDocumentServer.Document.AppendText(" ");
            richEditDocumentServer.Document.AppendRtfText(rtfColumn2);

            xrRichText1.Rtf = richEditDocumentServer.RtfText;
        }
    }
}
