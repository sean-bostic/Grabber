﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grabber
{
    public partial class Grabber : Form
    {
        MicrosoftSammie sammie = new MicrosoftSammie();
        Scrape scrape = new Scrape();

        public Grabber()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            sammie.Say();
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            scrape.GetSource(urlSource.Text);
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            scrape.SpeedRead();
        }
    }
}
