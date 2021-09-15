using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            VIewModel.DisparaConsultaDato();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = VIewModel.NombrePasado;
            label2.Text = VIewModel.ApellidoPasado;
            label3.Text = VIewModel.FechaPasado;
            label4.Text = VIewModel.EdadPasado;
            label5.Text = VIewModel.SexoPasado;
            label6.Text = VIewModel.TelefonoPasado;
            label7.Text = VIewModel.CorreoPasado;
            label8.Text = VIewModel.EstadoPasado;
            label9.Text = VIewModel.MunicipioPasado;

        }

        private void label1_Click(object sender, EventArgs e)
        {
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
