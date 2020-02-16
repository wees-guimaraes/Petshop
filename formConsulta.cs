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

namespace Petshop {
    public partial class formConsulta : Form {
        public formConsulta() {
            InitializeComponent();
        }

        Controller control = new Controller();
        ArrayList resultado = new ArrayList();

        private void Bt_Click(object sender, EventArgs e) {
            pnlPesquisa.Visible = true;
        }

        private void CmbOS_TextChanged(object sender, EventArgs e) {
            if (rbOS.Checked) {
                if (cmbOS.Text != "" && cmbOS.Text != "Selecione a OS") {
                    int OS = int.Parse(cmbOS.Text);

                    ArrayList resultado = new ArrayList();
                    resultado = control.consultarOS(OS);


                    if (resultado != null) {


                        String dataOS = Convert.ToDateTime(resultado[0]).ToString("dd/MM/yyyy");
                        txtData.Text = dataOS;
                        txtNomeCliente.Text = resultado[1].ToString();
                        txtCPF.Text = resultado[2].ToString();
                        txtAnimal.Text = resultado[3].ToString();
                        txtCor.Text = resultado[4].ToString();
                        txtPorte.Text = resultado[5].ToString();
                        lbTotal.Text = resultado[6].ToString();
                        gridConsulta.DataSource = control.consultaServicosPorOS(OS);

                    } else {
                        esvaziarCampos();
                    }

                    //os.dataOS, c.nomeCli, c.CPF, a.nomeAni, a.cor, a.porte, os.valorTotal
                } else {
                    esvaziarCampos();
                }

            } else {
                if (rbCPF.Checked) {
                    if (cmbOS.Text != "Selecione a OS") {
                        int OS = int.Parse(cmbOS.Text);

                        ArrayList resultado = new ArrayList();
                        resultado = control.consultarOS(OS);


                        if (resultado != null) {


                            String dataOS = Convert.ToDateTime(resultado[0]).ToString("dd/MM/yyyy");
                            txtData.Text = dataOS;
                            txtNomeCliente.Text = resultado[1].ToString();
                            txtCPF.Text = resultado[2].ToString();
                            txtAnimal.Text = resultado[3].ToString();
                            txtCor.Text = resultado[4].ToString();
                            txtPorte.Text = resultado[5].ToString();
                            lbTotal.Text = resultado[6].ToString();
                            gridConsulta.DataSource = control.consultaServicosPorOS(OS);
                        }
                    } else {
                        esvaziarCampos();
                    }
                }

            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e) {

            try {
                if (rbOS.Checked) {
                    if (txtPesquisa.Text != "") {
                        resultado = new ArrayList();
                        int OS = int.Parse(txtPesquisa.Text);
                        resultado = control.consultarOS(OS);
                        if (resultado != null) {
                            cmbOS.Text = txtPesquisa.Text;
                        } else {
                            cmbOS.Text = "Selecione a OS";
                        }
                    }
                } else { }
                if (rbCPF.Checked) {
                    if (txtPesquisa.Text != "") {
                        resultado = new ArrayList();
                        long cpf = long.Parse(txtPesquisa.Text);
                        resultado = control.consultarOSporCPF(cpf);
                        if (resultado != null) {
                            cmbOS.Items.AddRange(resultado.ToArray());
                        } else {

                            cmbOS.Text = "Selecione a OS";
                        }

                    }
                }

            } catch (Exception) {
                MessageBox.Show("Digite apenas números");
                txtPesquisa.Text = "";
            }


        }



        private void CmbOS_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void esvaziarCampos() {

            txtData.Text = "";
            txtNomeCliente.Text = "";
            txtCPF.Text = "";
            txtAnimal.Text = "";
            txtCor.Text = "";
            txtPorte.Text = "";
            lbTotal.Text = "";
            gridConsulta.DataSource = null;
            cmbOS.Items.Clear();
            cmbOS.Text = "Selecione a OS";
        }

        private void BtOS_Click(object sender, EventArgs e) {

        }

        private void btLixeiraCheia_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja Excluir a OS?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if (cmbOS.Text != "" && cmbOS.Text != "Selecione a OS") {
                    int OS = int.Parse(cmbOS.Text);
                    control.deletarOS(OS);
                    MessageBox.Show(control.getMensagem());
                    cmbOS.Text = "Selecione a OS";
                    txtPesquisa.Text = "";

                    esvaziarCampos();
                } else {
                    MessageBox.Show("Não há OS para Excluir.");
                }

            }

        }

        private void RbOS_CheckedChanged(object sender, EventArgs e) {
            esvaziarCampos();
            txtPesquisa.Text = "";
        }
    } //class
}// namespace
