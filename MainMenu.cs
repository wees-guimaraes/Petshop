using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Drawing.Design;
using System.Drawing.Configuration;


namespace Petshop {
    public partial class MainMenu : Form {
        public MainMenu() {

            InitializeComponent();
        }
        public formOS menu1 = new formOS();
        public formServico formServ = new formServico();
        public formConsulta formCon = new formConsulta();
        public Controller control = new Controller();

        private void btMenu_Click_1(object sender, EventArgs e) {
            if (pnlEsquerdo.Width == 283) {

                pnlEsquerdo.Width = 54;
                btOS.Visible = false;
                btServico.Visible = false;
            } else {
                // btMenu.Visible = false;
                pnlEsquerdo.Width = 283;
                btOS.Visible = true;
                btServico.Visible = true;
                btBuscarOS.Visible = true;

            }
        }


        public void btOS_Click(object sender, EventArgs e) {


            menu1.TopLevel = false;
            pnlPrincipal.Controls.Remove(formServ);
            pnlPrincipal.Controls.Remove(formCon);
            pnlPrincipal.Controls.Add(menu1);

            menu1.Show();
            btMenu.Show();
            btMenu.Visible = true;
            btMenu.BackColor = System.Drawing.Color.FromArgb(56, 167, 185);
            pnlEsquerdo.Width = 54;
            btOS.Visible = false;
            btServico.Visible = false;
            btBuscarOS.Visible = false;
        }


        private void ImgMyPetshop_Click(object sender, EventArgs e) {
            if (pnlEsquerdo.Width == 283) {
                pnlEsquerdo.Width = 54;
                btOS.Visible = false;
                btServico.Visible = false;
                btMenu.Show();
                btMenu.Visible = true;
                btBuscarOS.Visible = false;
            }
        }

        private void imgIcone_Click(object sender, EventArgs e) {
            if (pnlEsquerdo.Width == 283) {
                pnlEsquerdo.Width = 54;
                btOS.Visible = false;
                btServico.Visible = false;
                btMenu.Show();
                btMenu.Visible = true;
                btBuscarOS.Visible = false;
            }
            pnlPrincipal.Controls.Remove(menu1);
            pnlPrincipal.Controls.Remove(formServ);
            pnlPrincipal.Controls.Remove(formCon);
            btMenu.BackColor = System.Drawing.Color.Transparent;
            btMenu.Show();
            btMenu.Visible = true;
        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e) {
            if (pnlEsquerdo.Width == 283) {
                pnlEsquerdo.Width = 54;
                btOS.Visible = false;
                btServico.Visible = false;

                btBuscarOS.Visible = false;
                btMenu.Show();
                btMenu.Visible = true;
            }
        }

        private void PnlEsquerdo_MouseClick(object sender, MouseEventArgs e) {
            if (pnlEsquerdo.Width == 54) {
                btMenu.Show();
                btMenu.Visible = true;
                pnlEsquerdo.Width = 283;
                btOS.Visible = true;
                btServico.Visible = true;
            }
        }

        private void PnlPrincipal_MouseClick(object sender, MouseEventArgs e) {
            if (pnlEsquerdo.Width == 283) {
                pnlEsquerdo.Width = 54;
                btOS.Visible = false;
                btServico.Visible = false;
                btMenu.Show();
                btMenu.Visible = true;
                btBuscarOS.Visible = false;
            }
            pnlPrincipal.Controls.Remove(menu1);
            btMenu.BackColor = System.Drawing.Color.Transparent;
            btMenu.Show();
            btMenu.Visible = true;

        }

        private void BtServico_Click(object sender, EventArgs e) {
            formServ.TopLevel = false;
            pnlPrincipal.Controls.Remove(menu1);
            pnlPrincipal.Controls.Remove(formCon);
            pnlPrincipal.Controls.Add(formServ);
            formServ.Show();
            btMenu.Show();
            btMenu.Visible = true;
            btMenu.BackColor = System.Drawing.Color.FromArgb(56, 167, 185);
            pnlEsquerdo.Width = 54;
            btOS.Visible = false;
            btServico.Visible = false;
            btBuscarOS.Visible = false;

        }

        private void BtBuscarOS_Click(object sender, EventArgs e) {

            formCon.TopLevel = false;
            pnlPrincipal.Controls.Remove(formServ);
            pnlPrincipal.Controls.Remove(menu1);
            pnlPrincipal.Controls.Add(formCon);

            formCon.Show();
            btMenu.Show();
            btMenu.Visible = true;
            btMenu.BackColor = System.Drawing.Color.FromArgb(56, 167, 185);
            pnlEsquerdo.Width = 54;
            btOS.Visible = false;
            btServico.Visible = false;
            btBuscarOS.Visible = false;

        }

        private void LbOS_MouseEnter(object sender, EventArgs e) {
            lbOS.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);

        }

        private void LbOS_MouseLeave(object sender, EventArgs e) {
            lbOS.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }

        private void LbOS_Click(object sender, EventArgs e) {

            menu1.TopLevel = false;
            pnlPrincipal.Controls.Remove(formServ);
            pnlPrincipal.Controls.Remove(formCon);
            pnlPrincipal.Controls.Add(menu1);

            menu1.Show();
            btMenu.Show();
            btMenu.Visible = true;
            btMenu.BackColor = System.Drawing.Color.FromArgb(56, 167, 185);
            pnlEsquerdo.Width = 54;
            btOS.Visible = false;
            btServico.Visible = false;
            btBuscarOS.Visible = false;
        }

        private void LbServiço_Click(object sender, EventArgs e) {
            formServ.TopLevel = false;
            pnlPrincipal.Controls.Remove(menu1);
            pnlPrincipal.Controls.Remove(formCon);
            pnlPrincipal.Controls.Add(formServ);
            formServ.Show();
            btMenu.Show();
            btMenu.Visible = true;
            btMenu.BackColor = System.Drawing.Color.FromArgb(56, 167, 185);
            pnlEsquerdo.Width = 54;
            btOS.Visible = false;
            btServico.Visible = false;
            btBuscarOS.Visible = false;
        }

        private void LbBuscarOS_Click(object sender, EventArgs e) {
            formCon.TopLevel = false;
            pnlPrincipal.Controls.Remove(formServ);
            pnlPrincipal.Controls.Remove(menu1);
            pnlPrincipal.Controls.Add(formCon);

            formCon.Show();
            btMenu.Show();
            btMenu.Visible = true;
            btMenu.BackColor = System.Drawing.Color.FromArgb(56, 167, 185);
            pnlEsquerdo.Width = 54;
            btOS.Visible = false;
            btServico.Visible = false;
            btBuscarOS.Visible = false;
        }

        private void LbServiço_MouseEnter(object sender, EventArgs e) {
            lbServiço.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);
        }

        private void LbServiço_MouseLeave(object sender, EventArgs e) {

            lbServiço.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }

        private void LbBuscarOS_MouseEnter(object sender, EventArgs e) {
            lbBuscarOS.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);
        }

        private void LbBuscarOS_MouseLeave(object sender, EventArgs e) {
            lbBuscarOS.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }

        private void BtOS_MouseEnter(object sender, EventArgs e) {
            btOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void BtOS_MouseLeave(object sender, EventArgs e) {
            btOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void BtServico_MouseEnter(object sender, EventArgs e) {
            btServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void BtServico_MouseLeave(object sender, EventArgs e) {
            btServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void BtBuscarOS_MouseEnter(object sender, EventArgs e) {
            btBuscarOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void BtBuscarOS_MouseLeave(object sender, EventArgs e) {
            btBuscarOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void ImgMyPetshop_MouseEnter(object sender, EventArgs e) {
            imgMyPetshop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void ImgMyPetshop_MouseLeave(object sender, EventArgs e) {
            imgMyPetshop.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void MainMenu_Load(object sender, EventArgs e) {

        }
    }
}
