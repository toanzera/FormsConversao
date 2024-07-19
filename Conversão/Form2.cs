using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TauanMaciel
{
    public partial class Form2 : Form, Iview
    {
        private Controller controller;
        public void SetController(Controller controller)
        {
            this.controller = controller;
        }
        public double Valor
        {
            get { return double.Parse(txtRef.Text); }
            set { txtRef.Text = value.ToString(); }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            controller.Converter();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
