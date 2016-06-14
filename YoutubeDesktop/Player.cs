using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDesktop
{

	public partial class Player : Form
	{
		const string htmlPrefix = "<!DOCTYPE html><html><body>";
		const string htmlSuffix = "</body></html>";


		string video = "fWRISvgAygU";
		int width = 480;
		int height = 270;

		bool OPTautoplay = true;
		bool OPTkeyboard = true;
		bool OPTfullscreen = false;
		bool OPTannotations = false;
		bool OPTrelated = false;
		bool OPTcaptions = false;
		


		public Player()
		{
			InitializeComponent();

			DisplayHtml(iFrameHtml());
			
		}




		private void DisplayHtml(string html)
		{
			webBrowser1.DocumentText = "0";
			webBrowser1.Document.OpenNew(true);
			webBrowser1.Document.Write(html);
			webBrowser1.Refresh();
		}

		private string iFrameOptions()
		{
			string options = "?enablejsapi=1&amp;controls=2";

			if (OPTautoplay) {
				options += "&amp;autoplay=1";
			}
			if (OPTkeyboard) {
				options += "&amp;disablekb=1";
			}
			if (!OPTfullscreen) {
				options += "&amp;fs=0";
			}
			if (!OPTannotations) {
				options += "&amp;iv_load_policy=3";
			}
			if (!OPTrelated) {
				options += "&amp;rel=0";
			}
			if (OPTcaptions) {
				options += "&amp;cc_load_policy=1";
			}

			//options += "&amp;origin=http%3A%2F%2Flocalhost";
			options += "&amp;widgetid=1";

			return options;
		}

		private string iFrameHtml() {
			string html = "<iframe id=\"ytplayer\" type=\"text/html\" width=" + width + " height=" + height + "\n";
			html += "src = \"https://www.youtube.com/embed/" + video + iFrameOptions() + "\n";
			html +=	"frameborder = \"0\" /> ";
            return htmlPrefix + html + htmlSuffix;
		}

	}
}
