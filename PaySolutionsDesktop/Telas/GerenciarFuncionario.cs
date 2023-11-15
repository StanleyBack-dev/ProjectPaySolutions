using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaySolutionsDesktop.Telas
{
    public partial class GerenciarFuncionario : Form
    {
        public GerenciarFuncionario()
        {
            InitializeComponent();
        }

        private void lvlFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GerenciarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void GerenciarFuncionario_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 10;
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            buttonPath.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90);
            buttonPath.AddArc(btnAddFunc.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);
            buttonPath.AddArc(btnAddFunc.Width - borderRadius * 2, btnAddFunc.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            buttonPath.AddArc(0, btnAddFunc.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            btnAddFunc.Region = new Region(buttonPath);
        }

        private void btnAddFunc_Click(object sender, EventArgs e)
        {
            AddFuncionario addFuncionario = new AddFuncionario();
            addFuncionario.Show();
        }
    }
}
