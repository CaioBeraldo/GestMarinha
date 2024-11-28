using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestMarinha
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Sobrescreve a borda de foco para impedir o desenho do retângulo pontilhado
            ControlPaint.DrawFocusRectangle(e.Graphics, ClientRectangle, Color.Transparent, Color.Transparent);
        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
