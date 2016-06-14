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

		private string iFrameHtml() {
			string html = "<iframe id=\"ytplayer\" type=\"text/html\" width=" + width + " height=" + height + "\n";
			html += "src = \"https://www.youtube.com/embed/" + video + "?autoplay=1\"\n";
			html +=	"frameborder = \"0\" /> ";
            return htmlPrefix + html + htmlSuffix;
		}

	}
}
