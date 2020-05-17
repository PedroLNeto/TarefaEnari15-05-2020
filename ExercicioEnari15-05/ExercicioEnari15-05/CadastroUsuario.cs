using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioEnari15_05
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ArrayList Logins = new ArrayList();

            Logins.Add(txtNome.Text);
            Logins.Add(txtEmail.Text);
            Logins.Add(txtSenha.Text);
            Logins.Add(txtTel.Text);

            

            if (Logins.Contains(txtEmail.Text))
            {
                MessageBox.Show("Usuario já cadastro!");
            }
            else
            {
                MessageBox.Show("Dados Gravados com sucesso" +
                    "Dados Nome:" + Logins[0] + " Email: " + Logins[1]);
            }

        }
    }
}
