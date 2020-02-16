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
    public partial class formOS : Form {
        public formOS() {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        Controller control = new Controller();
        private double valorItem = 0;
        private double valorTotalItem = 0;
        private int totalItens = 0;



        private void PictureBox5_Click(object sender, EventArgs e) {
            MessageBox.Show("Ordem de serviço registrada com sucesso.");
            txtCPF.Text = "";

        }



        private void PictureBox7_Click(object sender, EventArgs e) {

            int repetidos = 0;


            if (gridItem.RowCount > 0) {

                for (int j = 0; j < gridItem.RowCount; j++) {
                    if (cmbServico.Text == gridItem.Rows[j].Cells[0].Value.ToString()) {
                        repetidos++;
                    }
                }
                if (repetidos > 0) {
                    MessageBox.Show("Serviço já incluso.");
                } else {
                    gridItem.Rows.Add(cmbServico.Text, txtValor.Text);
                    totalItens++;
                    valorItem = double.Parse(txtValor.Text);
                    valorTotalItem += valorItem;
                    lbTotal.Text = valorTotalItem.ToString();
                }

            } else {
                gridItem.Rows.Add(cmbServico.Text, txtValor.Text);
                totalItens++;
                valorItem = double.Parse(txtValor.Text);
                valorTotalItem += valorItem;
                lbTotal.Text = valorTotalItem.ToString();
            }


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Double auxiliar;
            try {
                if (e.ColumnIndex == gridItem.Columns["Excluir"].Index) {
                    auxiliar = Convert.ToDouble(gridItem.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value);
                    valorTotalItem -= auxiliar;
                    lbTotal.Text = valorTotalItem.ToString();
                    gridItem.Rows.RemoveAt(e.RowIndex);
                    totalItens--;
                }
            } catch (Exception) {
                MessageBox.Show("Não há item para remover.\n :)");
            }

            try {
                if (e.ColumnIndex == gridItem.Columns["Editar"].Index) {

                    int repetidos = 0;

                    if (gridItem.RowCount > 0) {

                        for (int j = 0; j < gridItem.RowCount; j++) {
                            if (cmbServico.Text == gridItem.Rows[j].Cells[0].Value.ToString()) {
                                repetidos++;
                            }
                        }
                        if (repetidos > 0) {
                            MessageBox.Show("Serviço já incluso.");
                        } else {

                            Double valorItem;

                            valorItem = Convert.ToDouble(gridItem.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value);
                            valorTotalItem -= valorItem;

                            gridItem.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value = cmbServico.Text;
                            gridItem.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value = txtValor.Text;

                            valorItem = Convert.ToDouble(gridItem.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value);
                            valorTotalItem += valorItem;
                            lbTotal.Text = valorTotalItem.ToString();

                        }
                    }
                }
            } catch (Exception) { }
        }

        private void PictureBox4_Click(object sender, EventArgs e) {
            // Botão para testes.
            /*
                          ArrayList resultado =  control.consultarOS(516);
                        foreach (var item in resultado) {
                            MessageBox.Show("Contém: "+item);
                        } */
        }

        private void TxtNomeCli_TextChanged(object sender, EventArgs e) {
            try {
                if (txtCPF.Text != "") {
                    Controller control = new Controller();
                    control.exibirTabela(long.Parse(txtCPF.Text));
                    txtNomeCliente.Text = control.getNome();
                } else {
                    txtNomeCliente.Text = "";
                }

            } catch (Exception) {
                txtCPF.Text = "";
                MessageBox.Show("Digite apenas números!");
            }
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e) {
            if (txtCPF.Text != "") {
                Controller control = new Controller();
                control.exibirTabela(long.Parse(txtCPF.Text));
                txtNomeCliente.Text = control.getNome();
                this.cmbAnimal.DataSource = control.listarAnimais(long.Parse(txtCPF.Text));
                this.cmbAnimal.ValueMember = "nomeAni";
                this.cmbAnimal.DisplayMember = "nomeAni";
                this.cmbServico.DataSource = control.listarServico();
                this.cmbServico.ValueMember = "descr";
                this.cmbServico.DisplayMember = "descr";

            } else {
                txtNomeCliente.Text = "";
                cmbAnimal.DataSource = null;
                cmbServico.DataSource = null;
                txtValor.Text = "";
            }
        }

        private void CmbServico_TextChanged(object sender, EventArgs e) {

            control.consultaValor(cmbServico.Text);
            txtValor.Text = control.getValor().ToString();

            if (cmbServico.Text == "Selecione o serviço") {
                txtValor.Text = "0";
            }


        }
        private void BtGerarOS_Click(object sender, EventArgs e) {

            long CPF = long.Parse(txtCPF.Text);
            String nomeAnimal = cmbAnimal.Text.ToString();
            String[] servicos = new String[totalItens];
            for (int i = 0; i < totalItens; i++) {
                servicos[i] = gridItem.Rows[i].Cells[0].Value.ToString();
            }
            double valorTotal = double.Parse(lbTotal.Text);
            int idAnimal = control.consultaIdAnimal(CPF, nomeAnimal);
            control.gerarOS(CPF, idAnimal, servicos, valorTotal);
            gridItem.Rows.Clear();
            totalItens = 0;
            valorTotalItem = 0;
            lbTotal.Text = "0";
            txtCPF.Text = null;
            MessageBox.Show(control.getMensagem());
        }

        private void BtGerarOSnovo_Click(object sender, EventArgs e) {
            try {
                long CPF = long.Parse(txtCPF.Text);
                String nomeAnimal = cmbAnimal.Text.ToString();
                String[] servicos = new String[totalItens];
                for (int i = 0; i < totalItens; i++) {
                    servicos[i] = gridItem.Rows[i].Cells[0].Value.ToString();
                }
                double valorTotal = double.Parse(lbTotal.Text);
                int idAnimal = control.consultaIdAnimal(CPF, nomeAnimal);
                if (lbTotal.Text == "" || lbTotal.Text == "0") {
                    MessageBox.Show("Não há serviço selecionado");

                } else {
                    control.gerarOS(CPF, idAnimal, servicos, valorTotal);
                    gridItem.Rows.Clear();
                    totalItens = 0;
                    valorTotalItem = 0;
                    lbTotal.Text = "0";
                    txtCPF.Text = null;
                    MessageBox.Show(control.getMensagem());
                }


            } catch (Exception) {
                MessageBox.Show("Nenhum cliente/animal ou serviço selecionado.");
            }

        }

        private void LbGerarOS_Click(object sender, EventArgs e) {

            long CPF = long.Parse(txtCPF.Text);
            String nomeAnimal = cmbAnimal.Text.ToString();
            String[] servicos = new String[totalItens];
            for (int i = 0; i < totalItens; i++) {
                servicos[i] = gridItem.Rows[i].Cells[0].Value.ToString();
            }
            double valorTotal = double.Parse(lbTotal.Text);
            int idAnimal = control.consultaIdAnimal(CPF, nomeAnimal);
            control.gerarOS(CPF, idAnimal, servicos, valorTotal);
            gridItem.Rows.Clear();
            totalItens = 0;
            valorTotalItem = 0;
            lbTotal.Text = "0";
            txtCPF.Text = null;
            MessageBox.Show(control.getMensagem());
        }

        private void CmbAnimal_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void CmbServico_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
