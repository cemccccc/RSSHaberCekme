using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.WebRequestMethods;

namespace RSSVeriCekme
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public string rssBbcAkis()
		{
			return "https://feeds.bbci.co.uk/turkce/rss.xml";
		}

		public string rssHabertrukAkis()
		{
			return "https://www.haberturk.com/rss/manset.xml";
		}

		public void rssOku(string gazeteRss)
		{
			XmlTextReader xmlOku = new XmlTextReader(gazeteRss);
			while (xmlOku.Read())
			{
				if (xmlOku.Name == "title")
				{
					listBox1.Items.Add(xmlOku.ReadString());
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			rssOku(rssBbcAkis());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			rssOku(rssHabertrukAkis());

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.BackColor = ColorTranslator.FromHtml("0xffeda0");
		}
	}
}
