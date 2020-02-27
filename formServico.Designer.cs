namespace Petshop {
    partial class formServico {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formServico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbDescrServ = new System.Windows.Forms.Label();
            this.txtDescrServ = new System.Windows.Forms.TextBox();
            this.lbValorServ = new System.Windows.Forms.Label();
            this.txtValorServ = new System.Windows.Forms.TextBox();
            this.dataGridViewServ = new System.Windows.Forms.DataGridView();
            this.IDServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditarServ = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExcluirServ = new System.Windows.Forms.DataGridViewImageColumn();
            this.flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btConsServ = new System.Windows.Forms.PictureBox();
            this.btIncServ = new System.Windows.Forms.PictureBox();
            this.txtConsServ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdServ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btConsServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btIncServ)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDescrServ
            // 
            this.lbDescrServ.AutoSize = true;
            this.lbDescrServ.BackColor = System.Drawing.Color.Transparent;
            this.lbDescrServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrServ.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbDescrServ.Location = new System.Drawing.Point(495, 38);
            this.lbDescrServ.Name = "lbDescrServ";
            this.lbDescrServ.Size = new System.Drawing.Size(105, 25);
            this.lbDescrServ.TabIndex = 18;
            this.lbDescrServ.Text = "Descrição:";
            // 
            // txtDescrServ
            // 
            this.txtDescrServ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDescrServ.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrServ.Location = new System.Drawing.Point(613, 41);
            this.txtDescrServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescrServ.Name = "txtDescrServ";
            this.txtDescrServ.Size = new System.Drawing.Size(311, 28);
            this.txtDescrServ.TabIndex = 17;
            // 
            // lbValorServ
            // 
            this.lbValorServ.AutoSize = true;
            this.lbValorServ.BackColor = System.Drawing.Color.Transparent;
            this.lbValorServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorServ.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbValorServ.Location = new System.Drawing.Point(540, 105);
            this.lbValorServ.Name = "lbValorServ";
            this.lbValorServ.Size = new System.Drawing.Size(64, 25);
            this.lbValorServ.TabIndex = 21;
            this.lbValorServ.Text = "Valor:";
            // 
            // txtValorServ
            // 
            this.txtValorServ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtValorServ.Location = new System.Drawing.Point(613, 107);
            this.txtValorServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorServ.Name = "txtValorServ";
            this.txtValorServ.Size = new System.Drawing.Size(65, 22);
            this.txtValorServ.TabIndex = 20;
            // 
            // dataGridViewServ
            // 
            this.dataGridViewServ.AllowUserToAddRows = false;
            this.dataGridViewServ.AllowUserToOrderColumns = true;
            this.dataGridViewServ.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewServ.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServ.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewServ.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewServ.ColumnHeadersHeight = 29;
            this.dataGridViewServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDServ,
            this.Serv,
            this.ValorServ,
            this.EditarServ,
            this.ExcluirServ,
            this.flag});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewServ.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewServ.EnableHeadersVisualStyles = false;
            this.dataGridViewServ.GridColor = System.Drawing.Color.Black;
            this.dataGridViewServ.Location = new System.Drawing.Point(500, 289);
            this.dataGridViewServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewServ.MultiSelect = false;
            this.dataGridViewServ.Name = "dataGridViewServ";
            this.dataGridViewServ.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServ.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewServ.RowHeadersVisible = false;
            this.dataGridViewServ.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.MediumBlue;
            this.dataGridViewServ.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewServ.Size = new System.Drawing.Size(549, 165);
            this.dataGridViewServ.TabIndex = 22;
            this.dataGridViewServ.Visible = false;
            this.dataGridViewServ.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServ_CellClick);
            // 
            // IDServ
            // 
            this.IDServ.DataPropertyName = "idServ";
            this.IDServ.HeaderText = "ID";
            this.IDServ.MinimumWidth = 6;
            this.IDServ.Name = "IDServ";
            this.IDServ.ReadOnly = true;
            this.IDServ.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDServ.Visible = false;
            // 
            // Serv
            // 
            this.Serv.DataPropertyName = "descr";
            this.Serv.FillWeight = 165.2862F;
            this.Serv.HeaderText = "Serviço";
            this.Serv.MinimumWidth = 8;
            this.Serv.Name = "Serv";
            this.Serv.ReadOnly = true;
            this.Serv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ValorServ
            // 
            this.ValorServ.DataPropertyName = "valorServ";
            this.ValorServ.FillWeight = 106.9519F;
            this.ValorServ.HeaderText = "Valor";
            this.ValorServ.MinimumWidth = 6;
            this.ValorServ.Name = "ValorServ";
            this.ValorServ.ReadOnly = true;
            this.ValorServ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // EditarServ
            // 
            this.EditarServ.FillWeight = 59.62226F;
            this.EditarServ.HeaderText = "Editar";
            this.EditarServ.Image = ((System.Drawing.Image)(resources.GetObject("EditarServ.Image")));
            this.EditarServ.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarServ.MinimumWidth = 8;
            this.EditarServ.Name = "EditarServ";
            this.EditarServ.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ExcluirServ
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = null;
            this.ExcluirServ.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExcluirServ.FillWeight = 68.13972F;
            this.ExcluirServ.HeaderText = "Excluir";
            this.ExcluirServ.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirServ.Image")));
            this.ExcluirServ.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ExcluirServ.MinimumWidth = 8;
            this.ExcluirServ.Name = "ExcluirServ";
            this.ExcluirServ.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // flag
            // 
            this.flag.DataPropertyName = "flag";
            this.flag.HeaderText = "flag";
            this.flag.MinimumWidth = 6;
            this.flag.Name = "flag";
            this.flag.Visible = false;
            // 
            // btConsServ
            // 
            this.btConsServ.BackColor = System.Drawing.Color.Transparent;
            this.btConsServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConsServ.Image = ((System.Drawing.Image)(resources.GetObject("btConsServ.Image")));
            this.btConsServ.Location = new System.Drawing.Point(1319, 41);
            this.btConsServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConsServ.Name = "btConsServ";
            this.btConsServ.Size = new System.Drawing.Size(31, 31);
            this.btConsServ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btConsServ.TabIndex = 23;
            this.btConsServ.TabStop = false;
            this.btConsServ.Click += new System.EventHandler(this.BtConsServ_Click);
            // 
            // btIncServ
            // 
            this.btIncServ.BackColor = System.Drawing.Color.Transparent;
            this.btIncServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIncServ.Image = ((System.Drawing.Image)(resources.GetObject("btIncServ.Image")));
            this.btIncServ.Location = new System.Drawing.Point(916, 111);
            this.btIncServ.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btIncServ.Name = "btIncServ";
            this.btIncServ.Size = new System.Drawing.Size(32, 33);
            this.btIncServ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btIncServ.TabIndex = 27;
            this.btIncServ.TabStop = false;
            this.btIncServ.Click += new System.EventHandler(this.BtIncServ_Click);
            // 
            // txtConsServ
            // 
            this.txtConsServ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtConsServ.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtConsServ.Location = new System.Drawing.Point(1149, 43);
            this.txtConsServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConsServ.Name = "txtConsServ";
            this.txtConsServ.Size = new System.Drawing.Size(145, 22);
            this.txtConsServ.TabIndex = 28;
            this.txtConsServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(597, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 39);
            this.label5.TabIndex = 29;
            this.label5.Text = "Serviços disponíveis:";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(1100, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // txtIdServ
            // 
            this.txtIdServ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdServ.Location = new System.Drawing.Point(1149, 111);
            this.txtIdServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdServ.Name = "txtIdServ";
            this.txtIdServ.ReadOnly = true;
            this.txtIdServ.Size = new System.Drawing.Size(65, 22);
            this.txtIdServ.TabIndex = 30;
            this.txtIdServ.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(975, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Buscar serviços:";
            // 
            // formServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1392, 770);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdServ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConsServ);
            this.Controls.Add(this.btIncServ);
            this.Controls.Add(this.btConsServ);
            this.Controls.Add(this.dataGridViewServ);
            this.Controls.Add(this.lbValorServ);
            this.Controls.Add(this.txtValorServ);
            this.Controls.Add(this.lbDescrServ);
            this.Controls.Add(this.txtDescrServ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btConsServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btIncServ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescrServ;
        private System.Windows.Forms.TextBox txtDescrServ;
        private System.Windows.Forms.Label lbValorServ;
        private System.Windows.Forms.TextBox txtValorServ;
        private System.Windows.Forms.DataGridView dataGridViewServ;
        private System.Windows.Forms.PictureBox btConsServ;
        private System.Windows.Forms.PictureBox btIncServ;
        private System.Windows.Forms.TextBox txtConsServ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdServ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorServ;
        private System.Windows.Forms.DataGridViewImageColumn EditarServ;
        private System.Windows.Forms.DataGridViewImageColumn ExcluirServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn flag;
    }
}