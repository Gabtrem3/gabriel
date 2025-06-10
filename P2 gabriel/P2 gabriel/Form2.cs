using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_gabriel
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void Formulário_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            form3 form3 = new form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3 form3 = new form3();
            form3.Show();
            
        }
    }
}
