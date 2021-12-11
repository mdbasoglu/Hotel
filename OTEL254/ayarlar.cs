using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veriT;

namespace OTEL254
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        private void ayarlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            programAyarlari.fmain.Show();
            e.Cancel = true;
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
        }

        private void bArkaPlan_Click(object sender, EventArgs e)
        {
           colorDialog1.ShowDialog();
        }

        private void bSifirla_Click(object sender, EventArgs e)
        {
            tPAdi.Text = "Otel Takip Programı";
            tSurumu.Text = "V1";
            tYapimci.Text = "254 Groups";
            tTel.Text = "05372921615";
            tWebSite.Text = "www.projevekod.com";
        }

        private void bAyarlariUygula_Click(object sender, EventArgs e)
        {
            islemler.varsaKosulluVeriGuncelle("PROGRAM", "P_ADI = '" + tPAdi.Text + "',P_SURUMU = '" + tSurumu.Text + "',P_YAYIMCISI = '" + tYapimci.Text + "',P_YAYIMCISI_TEL = '" + tTel.Text + "',P_WEBSITE = '" + tWebSite.Text + "'","");
            programAyarlari.pAdi = programAyarlari.fayarlar.tPAdi.Text;
            programAyarlari.pSurumu = programAyarlari.fayarlar.tSurumu.Text;
            programAyarlari.pYapimci = programAyarlari.fayarlar.tYapimci.Text;
            programAyarlari.pYapimciTel = programAyarlari.fayarlar.tTel.Text;
            programAyarlari.pWebSite = programAyarlari.fayarlar.tWebSite.Text;
            MessageBox.Show("Ayarlar güncellendi. Güncelleme başarılı.", "Ayarlar değişti.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            programAyarlari.fmain.Show();
        }
    }
}
