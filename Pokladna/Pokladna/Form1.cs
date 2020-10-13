using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
 public partial class Form1 : Form
 {
        List<PoklZaznam> pokladna;
        IRepos repositar;
  public Form1()
  {
   InitializeComponent();
  }

        private void Form_Load(object sender,EventArgs e)
        {
            JasonRepos jsonRepos = new JasonRepos("data.json");
            jsonRepos.VytvorData();
            repositar = jsonRepos;
            //repositar = new SqlRepos();
            //repositar = new XmlRepos();
            pokladna = repositar.NactiVse();

            foreach (var p in pokladna)
            {
                listView1.Items.Add(p.DoLvItem());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pokladna = repositar.NactiVse();
        }
    }
}
