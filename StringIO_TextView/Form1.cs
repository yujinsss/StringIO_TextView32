﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringIO_TextView
{
    public partial class Form1 : Form
    {
        string OrgStr = ""; // "결과 : " 문자열 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblresult.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.lblresult.Text = this.OrgStr + this.txtEdit.Text;
        }
    }
}
