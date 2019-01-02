using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace IMB_Analyzer
{
	public partial class IMBAnalyzer : Form
	{
		Dictionary<string, string> stids = new Dictionary<string, string>();

		public IMBAnalyzer()
		{
			InitializeComponent();

			var lines = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"References", "stid grid.txt"));

			foreach (var s in lines)
			{
				var pieces = s.Split('|');
				string stid = pieces[0];
				StringBuilder sb = new StringBuilder();

				for (int x = 1; x < pieces.Length; x++)
				{
					sb.Append($"{pieces[x]}, ");
				}
				
				stids.Add(s.Split('|')[0], sb.ToString().TrimEnd(new char[] { ',', ' ' }));
			}
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

				stids.TryGetValue(tb_Service_Type_ID.Text, out string desc);
				lbl_Service_Type_ID_Desc.Text = desc;
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