using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_93_Tu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(lbSo1.Text);
            b = int.Parse(lbSo2.Text);
            Calculation_93_Tu c = new Calculation_93_Tu(a, b);
            KetQua = c.Execute("+");
            lbResult.Text = KetQua.ToString();
        }

        private void bntTru_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(lbSo1.Text);
            b = int.Parse(lbSo2.Text);
            Calculation_93_Tu c = new Calculation_93_Tu(a, b);
            KetQua = c.Execute("-");
            lbResult.Text = KetQua.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(lbSo1.Text);
            b = int.Parse(lbSo2.Text);
            Calculation_93_Tu c = new Calculation_93_Tu(a, b);
            KetQua = c.Execute("*");
            lbResult.Text = KetQua.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(lbSo1.Text);
            b = int.Parse(lbSo2.Text);
            Calculation_93_Tu c = new Calculation_93_Tu(a, b);
            KetQua = c.Execute("/");
            lbResult.Text = KetQua.ToString();
        }
    }
}
