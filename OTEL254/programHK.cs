﻿using System;
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
    public partial class programHK : Form
    {
        public programHK()
        {
            InitializeComponent();
        }

        private void programHK_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);
        }

        private void programHK_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            programAyarlari.fsurumNotlari.Show();
            this.Hide();
        }
    }
}
