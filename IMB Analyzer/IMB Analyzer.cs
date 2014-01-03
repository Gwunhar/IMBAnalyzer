using System;
using System.Windows.Forms;

namespace IMB_Analyzer
{
    public partial class IMBAnalyzer : Form
    {
        public IMBAnalyzer()
        {
            InitializeComponent();
        }

        private void tb_IMB_Value_TextChanged(object sender, EventArgs e)
        {
            if (tb_IMB_Value.Text.Length == 31 || tb_IMB_Value.Text.Length == 25)
            {
                tb_OEL_Option.Text = tb_IMB_Value.Text.Substring(0, 2);
                tb_Service_Type_ID.Text = tb_IMB_Value.Text.Substring(2, 3);
                tb_Mailer_ID.Text = tb_IMB_Value.Text.Substring(5, 6);
                tb_IMB_Sequence_Number.Text = tb_IMB_Value.Text.Substring(11, 9);

                if (tb_IMB_Value.Text.Length == 31)
                {
                    tb_Zip4.Text = tb_IMB_Value.Text.Substring(20, 5) + "-" + tb_IMB_Value.Text.Substring(25, 4);
                    tb_DPB.Text = tb_IMB_Value.Text.Substring(29, 2);
                }
                else
                {
                    tb_Zip4.Text = tb_IMB_Value.Text.Substring(20, 5);
                    tb_DPB.Text = "";
                }

                switch (tb_OEL_Option.Text)
                {
                    case "00":
                        lbl_OEL_Option_Desc.Text = "Default / No OEL Information";
                        break;

                    case "10":
                        lbl_OEL_Option_Desc.Text = "Carrier Route (CR), Enhanced Carrier Route (ECR), and FIRM";
                        break;

                    case "20":
                        lbl_OEL_Option_Desc.Text = "5-Digit/Scheme";
                        break;

                    case "30":
                        lbl_OEL_Option_Desc.Text = "3-Digit/Scheme";
                        break;

                    case "40":
                        lbl_OEL_Option_Desc.Text = "Area Distribution Center (ADC)";
                        break;

                    case "50":
                        lbl_OEL_Option_Desc.Text = "Mixed Area Distribution Center (MADC), Origin Mixed ADC (OMX)";
                        break;
                }

                switch (tb_Service_Type_ID.Text)
                {
                    case "300":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, no Tracking";
                        break;

                    case "700":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, no Tracking";
                        break;

                    case "501":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, no Tracking";
                        break;

                    case "507":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, no Tracking";
                        break;

                    case "517":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, no Tracking";
                        break;

                    case "510":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, no Tracking";
                        break;

                    case "080":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, no Tracking";
                        break;

                    case "082":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, no Tracking";
                        break;

                    case "310":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, with Tracking";
                        break;

                    case "040":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, with Tracking";
                        break;

                    case "500":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, with Tracking";
                        break;

                    case "506":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, with Tracking";
                        break;

                    case "515":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, with Tracking";
                        break;

                    case "530":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, with Tracking";
                        break;

                    case "140":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, with Tracking";
                        break;

                    case "240":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Basic/Nonauto, with Tracking";
                        break;

                    case "260":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, no Tracking";
                        break;

                    case "036":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, no Tracking";
                        break;

                    case "505":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, no Tracking";
                        break;

                    case "509":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, no Tracking";
                        break;

                    case "521":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, no Tracking";
                        break;

                    case "512":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, no Tracking";
                        break;

                    case "081":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, no Tracking";
                        break;

                    case "083":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, no Tracking";
                        break;

                    case "270":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, with Tracking";
                        break;

                    case "041":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, with Tracking";
                        break;

                    case "503":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, with Tracking";
                        break;

                    case "508":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, with Tracking";
                        break;

                    case "519":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, with Tracking";
                        break;

                    case "511":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, with Tracking";
                        break;

                    case "141":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, with Tracking";
                        break;

                    case "241":
                        lbl_Service_Type_ID_Desc.Text = "First Class, Full Service, with Tracking";
                        break;

                    case "704":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Basic/Nonauto, no Tracking";
                        break;

                    case "600":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Basic/Nonauto, no Tracking";
                        break;

                    case "784":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Basic/Nonauto, no Tracking";
                        break;

                    case "044":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Basic/Nonauto, with Tracking";
                        break;

                    case "599":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Basic/Nonauto, with Tracking";
                        break;

                    case "244":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Basic/Nonauto, with Tracking";
                        break;

                    case "264":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Full Service, no Tracking";
                        break;

                    case "602":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Full Service, no Tracking";
                        break;

                    case "038":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Full Service, no Tracking";
                        break;

                    case "274":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Full Service, with Tracking";
                        break;

                    case "601":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Full Service, with Tracking";
                        break;

                    case "045":
                        lbl_Service_Type_ID_Desc.Text = "Periodical, Full Service, with Tracking";
                        break;

                    case "301":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, no Tracking";
                        break;

                    case "702":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, no Tracking";
                        break;

                    case "540":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, no Tracking";
                        break;

                    case "560":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, no Tracking";
                        break;

                    case "090":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, no Tracking";
                        break;

                    case "092":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, no Tracking";
                        break;

                    case "311":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, with Tracking";
                        break;

                    case "042":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, with Tracking";
                        break;

                    case "539":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, with Tracking";
                        break;

                    case "559":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, with Tracking";
                        break;

                    case "142":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, with Tracking";
                        break;

                    case "242":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Basic/Nonauto, with Tracking";
                        break;

                    case "261":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, no Tracking";
                        break;

                    case "037":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, no Tracking";
                        break;

                    case "542":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, no Tracking";
                        break;

                    case "562":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, no Tracking";
                        break;

                    case "091":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, no Tracking";
                        break;

                    case "093":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, no Tracking";
                        break;

                    case "271":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, with Tracking";
                        break;

                    case "043":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, with Tracking";
                        break;

                    case "541":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, with Tracking";
                        break;

                    case "561":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, with Tracking";
                        break;

                    case "143":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, with Tracking";
                        break;

                    case "243":
                        lbl_Service_Type_ID_Desc.Text = "Standard, Full Service, with Tracking";
                        break;

                    case "401":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Basic/Nonauto, no Tracking";
                        break;

                    case "706":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Basic/Nonauto, no Tracking";
                        break;

                    case "603":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Basic/Nonauto, no Tracking";
                        break;

                    case "613":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Basic/Nonauto, no Tracking";
                        break;

                    case "424":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Basic/Nonauto, no Tracking";
                        break;

                    case "431":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Basic/Nonauto, no Tracking";
                        break;

                    case "265":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Full Service, no Tracking";
                        break;

                    case "466":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Full Service, no Tracking";
                        break;

                    case "604":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Full Service, no Tracking";
                        break;

                    case "614":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Full Service, no Tracking";
                        break;

                    case "423":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Full Service, no Tracking";
                        break;

                    case "430":
                        lbl_Service_Type_ID_Desc.Text = "Bound Printed Matter, Full Service, no Tracking";
                        break;

                    case "710":
                        lbl_Service_Type_ID_Desc.Text = "Priority Mail, Basic/Nonauto, no Tracking";
                        break;

                    case "712":
                        lbl_Service_Type_ID_Desc.Text = "Priority Mail Flat Rate, Basic/Nonauto, no Tracking";
                        break;

                    case "060":
                        lbl_Service_Type_ID_Desc.Text = "Critical Mail, Basic/Nonauto, no Tracking";
                        break;

                    case "760":
                        lbl_Service_Type_ID_Desc.Text = "Critical Mail, Basic/Nonauto, with Tracking";
                        break;

                    case "703":
                        lbl_Service_Type_ID_Desc.Text = "Courtesy Reply Mail, Basic/Nonauto, no Tracking";
                        break;

                    case "050":
                        lbl_Service_Type_ID_Desc.Text = "Courtesy Reply Mail, Basic/Nonauto, with Tracking";
                        break;

                    case "708":
                        lbl_Service_Type_ID_Desc.Text = "Business Reply Mail, Basic/Nonauto, no Tracking";
                        break;

                    case "052":
                        lbl_Service_Type_ID_Desc.Text = "Business Reply Mail, Basic/Nonauto, with Tracking";
                        break;

                    case "701":
                        lbl_Service_Type_ID_Desc.Text = "First Class Reply Mail, Basic/Nonauto, no Tracking";
                        break;

                    case "051":
                        lbl_Service_Type_ID_Desc.Text = "First Class Reply Mail, Basic/Nonauto, with Tracking";
                        break;
                }

                switch (tb_Mailer_ID.Text)
                {
                    case "899477":
                        lbl_Mailer_ID_Desc.Text = "No Tracking";
                        break;

                    case "006002":
                        lbl_Mailer_ID_Desc.Text = "Tracking";
                        break;
                }
            }
            else
            {
                lbl_Mailer_ID_Desc.Text = "";
                lbl_OEL_Option_Desc.Text = "";
                lbl_Service_Type_ID_Desc.Text = "";
                tb_IMB_Sequence_Number.Text = "";
                tb_Mailer_ID.Text = "";
                tb_OEL_Option.Text = "";
                tb_Service_Type_ID.Text = "";
                tb_Zip4.Text = "";
                tb_DPB.Text = "";
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_IMB_Value.Text = "";
            tb_IMB_Value.Focus();
        }
    }
}
