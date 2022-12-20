
namespace Maquina_de_Turing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtCadenaEntrada = new System.Windows.Forms.Label();
            this.txtCadenaSalida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtEncabezado = new System.Windows.Forms.Label();
            this.listaColorFondo = new System.Windows.Forms.ComboBox();
            this.txtTEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.Label();
            this.btnAgregarCadena = new System.Windows.Forms.Button();
            this.maquinaTuring = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPasos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaTuring)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(309, 108);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(174, 23);
            this.txtCadena.TabIndex = 0;
            // 
            // txtCadenaEntrada
            // 
            this.txtCadenaEntrada.AutoSize = true;
            this.txtCadenaEntrada.Location = new System.Drawing.Point(83, 286);
            this.txtCadenaEntrada.Name = "txtCadenaEntrada";
            this.txtCadenaEntrada.Size = new System.Drawing.Size(47, 15);
            this.txtCadenaEntrada.TabIndex = 1;
            this.txtCadenaEntrada.Text = "Entrada";
            // 
            // txtCadenaSalida
            // 
            this.txtCadenaSalida.AutoSize = true;
            this.txtCadenaSalida.Location = new System.Drawing.Point(83, 323);
            this.txtCadenaSalida.Name = "txtCadenaSalida";
            this.txtCadenaSalida.Size = new System.Drawing.Size(38, 15);
            this.txtCadenaSalida.TabIndex = 3;
            this.txtCadenaSalida.Text = "Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salida:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(431, 147);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtEncabezado
            // 
            this.txtEncabezado.AutoSize = true;
            this.txtEncabezado.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEncabezado.Location = new System.Drawing.Point(291, 39);
            this.txtEncabezado.Name = "txtEncabezado";
            this.txtEncabezado.Size = new System.Drawing.Size(215, 32);
            this.txtEncabezado.TabIndex = 7;
            this.txtEncabezado.Text = "Máquina de Turing";
            // 
            // listaColorFondo
            // 
            this.listaColorFondo.FormattingEnabled = true;
            this.listaColorFondo.Location = new System.Drawing.Point(601, 350);
            this.listaColorFondo.Name = "listaColorFondo";
            this.listaColorFondo.Size = new System.Drawing.Size(121, 23);
            this.listaColorFondo.TabIndex = 8;
            this.listaColorFondo.SelectedIndexChanged += new System.EventHandler(this.listaColorFondo_SelectedIndexChanged);
            // 
            // txtTEstado
            // 
            this.txtTEstado.AutoSize = true;
            this.txtTEstado.Location = new System.Drawing.Point(27, 398);
            this.txtTEstado.Name = "txtTEstado";
            this.txtTEstado.Size = new System.Drawing.Size(80, 15);
            this.txtTEstado.TabIndex = 9;
            this.txtTEstado.Text = "Estado actual:";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Location = new System.Drawing.Point(113, 398);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(42, 15);
            this.txtEstado.TabIndex = 10;
            this.txtEstado.Text = "Estado";
            // 
            // btnAgregarCadena
            // 
            this.btnAgregarCadena.Location = new System.Drawing.Point(291, 147);
            this.btnAgregarCadena.Name = "btnAgregarCadena";
            this.btnAgregarCadena.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCadena.TabIndex = 11;
            this.btnAgregarCadena.Text = "Agregar";
            this.btnAgregarCadena.UseVisualStyleBackColor = true;
            this.btnAgregarCadena.Click += new System.EventHandler(this.btnAgregarCadena_Click);
            // 
            // maquinaTuring
            // 
            this.maquinaTuring.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maquinaTuring.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.maquinaTuring.Location = new System.Drawing.Point(213, 196);
            this.maquinaTuring.Name = "maquinaTuring";
            this.maquinaTuring.RowTemplate.Height = 25;
            this.maquinaTuring.Size = new System.Drawing.Size(493, 51);
            this.maquinaTuring.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 30;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 30;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 30;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.Width = 30;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.Width = 30;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.Width = 30;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.Width = 30;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column12.Width = 30;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.Column13.Width = 30;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Column14";
            this.Column14.Name = "Column14";
            this.Column14.Width = 30;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.Width = 30;
            // 
            // btnPasos
            // 
            this.btnPasos.Location = new System.Drawing.Point(290, 286);
            this.btnPasos.Name = "btnPasos";
            this.btnPasos.Size = new System.Drawing.Size(75, 23);
            this.btnPasos.TabIndex = 13;
            this.btnPasos.Text = "Pasos";
            this.btnPasos.UseVisualStyleBackColor = true;
            this.btnPasos.Click += new System.EventHandler(this.btnPasos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPasos);
            this.Controls.Add(this.maquinaTuring);
            this.Controls.Add(this.btnAgregarCadena);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtTEstado);
            this.Controls.Add(this.listaColorFondo);
            this.Controls.Add(this.txtEncabezado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadenaSalida);
            this.Controls.Add(this.txtCadenaEntrada);
            this.Controls.Add(this.txtCadena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maquinaTuring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label txtCadenaEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label txtEncabezado;
        public System.Windows.Forms.Label txtCadenaSalida;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox listaColorFondo;
        private System.Windows.Forms.Label txtTEstado;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.Button btnAgregarCadena;
        private System.Windows.Forms.DataGridView maquinaTuring;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Button btnPasos;
    }
}

