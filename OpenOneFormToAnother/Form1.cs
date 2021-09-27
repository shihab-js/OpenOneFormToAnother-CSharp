﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenOneFormToAnother
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Hide();

            //create second form object
            Form2 secondForm = new Form2();

            //show the second form
            secondForm.Show();
        }
    }
}
