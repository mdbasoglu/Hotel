using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTEL254
{
    public partial class surumNotlari : Form
    {
        public surumNotlari()
        {
            InitializeComponent();
        }

        private void surumNotlari_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
            label1.Text = "\nProgram adı : " + programAyarlari.pAdi + "\nSürümü : " + programAyarlari.pSurumu + "\nYapımcısı : " + programAyarlari.pYapimci + "\nYapımcısı Telefon : " + programAyarlari.pYapimciTel + "\nWeb sitesi : " + programAyarlari.pWebSite +"\n\nYenilikler : " + programAyarlari.pYenilikler;
        }

        private void surumNotlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }
    }
}
