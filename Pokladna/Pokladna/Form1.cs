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
        List<PokladniZaznam> pokladna;
        IRepos repositar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbRok.SelectedIndex = cbRok.Items.IndexOf(DateTime.Now.Year.ToString());
            cbMes.SelectedIndex = DateTime.Now.Month - 1;
            JsonRepos jsonRepos = new JsonRepos("data.json");
            jsonRepos.VytvorTestData();
            repositar = jsonRepos;

            
            //repositar = new SqlRepos();
            //repositar = new XmlRepos();
            //pokladna = repositar.NactiVse();
            //foreach (var p in pokladna)
            //{
            //    lvData.Items.Add(p.DoLvItem());
            //}
        }

        private void cbRok_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbRok.SelectedIndex >= 0)
            {
                pokladna = repositar.NactiMesic(int.Parse(cbRok.SelectedItem.ToString()), cbMes.SelectedIndex + 1);
                lvData.Items.Clear();
                foreach (var p in pokladna)
                {
                    lvData.Items.Add(p.DoLvItem());
                }
            }
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pokladna = repositar.NactiMesic(int.Parse(cbRok.SelectedText), cbMes.SelectedIndex + 1);
            if (cbRok.SelectedIndex >= 0)
                foreach (var p in pokladna)
                {
                    lvData.Items.Add(p.DoLvItem());
                }
        }
    }
}
