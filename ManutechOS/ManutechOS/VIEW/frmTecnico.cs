﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManutechOS
{
    public partial class frmTecnico : Form
    {
        public frmTecnico()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadTecnico formCadTecnico = new frmCadTecnico();
            //formCadTecnico.TopLevel = false;
            //Adiciona o Form dentro do Container Principal
            //Parent.Controls.Add(formCadTecnico);
            //formCadTecnico.Parent = Parent;
            //Coloca o Form a frente dos outros
            formCadTecnico.BringToFront();
            formCadTecnico.ShowDialog();
        }
    }
}
