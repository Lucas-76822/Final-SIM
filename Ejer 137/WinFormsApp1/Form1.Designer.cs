namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            textBoxHasta = new TextBox();
            label7 = new Label();
            textBoxDesde = new TextBox();
            label8 = new Label();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            demanda = new DataGridViewTextBoxColumn();
            probabilidad = new DataGridViewTextBoxColumn();
            limIneferior = new DataGridViewTextBoxColumn();
            limSuperiror = new DataGridViewTextBoxColumn();
            textBoxValorPolitica = new TextBox();
            label6 = new Label();
            cbx_Politica = new ComboBox();
            label4 = new Label();
            textBoxCostoOportunidad = new TextBox();
            label5 = new Label();
            textBoxRetorno = new TextBox();
            label2 = new Label();
            textBoxPrecioVenta = new TextBox();
            label3 = new Label();
            textBoxCosto = new TextBox();
            label1 = new Label();
            textBoxIteraciones = new TextBox();
            lblIteraciones = new Label();
            dataGridView2 = new DataGridView();
            iteracion = new DataGridViewTextBoxColumn();
            stockDisponible = new DataGridViewTextBoxColumn();
            costoCompra = new DataGridViewTextBoxColumn();
            rnd = new DataGridViewTextBoxColumn();
            cantDemanda = new DataGridViewTextBoxColumn();
            ventasRealziadas = new DataGridViewTextBoxColumn();
            ganacias = new DataGridViewTextBoxColumn();
            stockRestante = new DataGridViewTextBoxColumn();
            gananaciasDevolucion = new DataGridViewTextBoxColumn();
            demandaNoSatisfecha = new DataGridViewTextBoxColumn();
            costoOportunidad = new DataGridViewTextBoxColumn();
            gananciaNeta = new DataGridViewTextBoxColumn();
            acumuladorVentas = new DataGridViewTextBoxColumn();
            ventasPromedio = new DataGridViewTextBoxColumn();
            acumuladorGananciasTotales = new DataGridViewTextBoxColumn();
            acumuladorGananciaDevolucion = new DataGridViewTextBoxColumn();
            acumuladorCostoAdquisicion = new DataGridViewTextBoxColumn();
            acumuladorGananciaNeta = new DataGridViewTextBoxColumn();
            gananciaNetaPromedio = new DataGridViewTextBoxColumn();
            acumCostoOprotunidad = new DataGridViewTextBoxColumn();
            costoOprtunidadProm = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textBoxValorPolitica);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbx_Politica);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxCostoOportunidad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxRetorno);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxPrecioVenta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxCosto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxIteraciones);
            groupBox1.Controls.Add(lblIteraciones);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(915, 403);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametros";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxHasta);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBoxDesde);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(625, 137);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(273, 256);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filas a mostrar";
            groupBox3.Enter += groupBox3_Enter_1;
            // 
            // textBoxHasta
            // 
            textBoxHasta.Location = new Point(142, 59);
            textBoxHasta.Name = "textBoxHasta";
            textBoxHasta.Size = new Size(125, 27);
            textBoxHasta.TabIndex = 20;
            textBoxHasta.Text = "99";
            textBoxHasta.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 65);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 19;
            label7.Text = "Hasta Fila Nro";
            label7.Click += label7_Click;
            // 
            // textBoxDesde
            // 
            textBoxDesde.Location = new Point(142, 27);
            textBoxDesde.Name = "textBoxDesde";
            textBoxDesde.Size = new Size(125, 27);
            textBoxDesde.TabIndex = 18;
            textBoxDesde.Text = "0";
            textBoxDesde.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 32);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 17;
            label8.Text = "Desde Fila Nro";
            label8.Click += label8_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 211);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 16;
            button2.Text = "Simular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(23, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(595, 256);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Demanda y Probabilidades";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(453, 221);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 15;
            button1.Text = "Actualziar Tabla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { demanda, probabilidad, limIneferior, limSuperiror });
            dataGridView1.Location = new Point(17, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(560, 188);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // demanda
            // 
            demanda.HeaderText = "Demanda";
            demanda.MinimumWidth = 6;
            demanda.Name = "demanda";
            demanda.Width = 125;
            // 
            // probabilidad
            // 
            probabilidad.HeaderText = "Probabilidad";
            probabilidad.MinimumWidth = 6;
            probabilidad.Name = "probabilidad";
            probabilidad.Width = 125;
            // 
            // limIneferior
            // 
            limIneferior.HeaderText = "Limite Inferiror";
            limIneferior.MinimumWidth = 6;
            limIneferior.Name = "limIneferior";
            limIneferior.ReadOnly = true;
            limIneferior.Width = 125;
            // 
            // limSuperiror
            // 
            limSuperiror.HeaderText = "Limite Superior";
            limSuperiror.MinimumWidth = 6;
            limSuperiror.Name = "limSuperiror";
            limSuperiror.ReadOnly = true;
            limSuperiror.Width = 125;
            // 
            // textBoxValorPolitica
            // 
            textBoxValorPolitica.Location = new Point(746, 101);
            textBoxValorPolitica.Name = "textBoxValorPolitica";
            textBoxValorPolitica.Size = new Size(151, 27);
            textBoxValorPolitica.TabIndex = 13;
            textBoxValorPolitica.Text = "20";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(586, 105);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 12;
            label6.Text = "Periódicos a Adquirir";
            label6.Click += label6_Click;
            // 
            // cbx_Politica
            // 
            cbx_Politica.FormattingEnabled = true;
            cbx_Politica.Location = new Point(746, 65);
            cbx_Politica.Name = "cbx_Politica";
            cbx_Politica.Size = new Size(151, 28);
            cbx_Politica.TabIndex = 11;
            cbx_Politica.SelectedIndexChanged += cbxPolitica_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 68);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 10;
            label4.Text = "Política de Adquisición";
            // 
            // textBoxCostoOportunidad
            // 
            textBoxCostoOportunidad.Location = new Point(746, 27);
            textBoxCostoOportunidad.Name = "textBoxCostoOportunidad";
            textBoxCostoOportunidad.Size = new Size(151, 27);
            textBoxCostoOportunidad.TabIndex = 9;
            textBoxCostoOportunidad.Text = "0,5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(586, 32);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 8;
            label5.Text = "Costo de Oportunidad";
            // 
            // textBoxRetorno
            // 
            textBoxRetorno.Location = new Point(425, 59);
            textBoxRetorno.Name = "textBoxRetorno";
            textBoxRetorno.Size = new Size(125, 27);
            textBoxRetorno.TabIndex = 7;
            textBoxRetorno.Text = "0,3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 65);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 6;
            label2.Text = "Valor por devolución ";
            // 
            // textBoxPrecioVenta
            // 
            textBoxPrecioVenta.Location = new Point(425, 27);
            textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            textBoxPrecioVenta.Size = new Size(125, 27);
            textBoxPrecioVenta.TabIndex = 5;
            textBoxPrecioVenta.Text = "2,8";
            textBoxPrecioVenta.TextChanged += textBoxPrecioVenta_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 32);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Precio Venta";
            // 
            // textBoxCosto
            // 
            textBoxCosto.Location = new Point(115, 59);
            textBoxCosto.Name = "textBoxCosto";
            textBoxCosto.Size = new Size(125, 27);
            textBoxCosto.TabIndex = 3;
            textBoxCosto.Text = "2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 65);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Costo Unitario";
            // 
            // textBoxIteraciones
            // 
            textBoxIteraciones.Location = new Point(115, 25);
            textBoxIteraciones.Name = "textBoxIteraciones";
            textBoxIteraciones.Size = new Size(125, 27);
            textBoxIteraciones.TabIndex = 1;
            textBoxIteraciones.Text = "100";
            // 
            // lblIteraciones
            // 
            lblIteraciones.AutoSize = true;
            lblIteraciones.Location = new Point(6, 32);
            lblIteraciones.Name = "lblIteraciones";
            lblIteraciones.Size = new Size(81, 20);
            lblIteraciones.TabIndex = 0;
            lblIteraciones.Text = "Iteraciones";
            lblIteraciones.Click += label1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { iteracion, stockDisponible, costoCompra, rnd, cantDemanda, ventasRealziadas, ganacias, stockRestante, gananaciasDevolucion, demandaNoSatisfecha, costoOportunidad, gananciaNeta, acumuladorVentas, ventasPromedio, acumuladorGananciasTotales, acumuladorGananciaDevolucion, acumuladorCostoAdquisicion, acumuladorGananciaNeta, gananciaNetaPromedio, acumCostoOprotunidad, costoOprtunidadProm });
            dataGridView2.Location = new Point(11, 439);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1617, 428);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // iteracion
            // 
            iteracion.HeaderText = "Iteracion";
            iteracion.MinimumWidth = 6;
            iteracion.Name = "iteracion";
            iteracion.Width = 125;
            // 
            // stockDisponible
            // 
            stockDisponible.HeaderText = "Stock Disponible";
            stockDisponible.MinimumWidth = 6;
            stockDisponible.Name = "stockDisponible";
            stockDisponible.Width = 125;
            // 
            // costoCompra
            // 
            costoCompra.HeaderText = "Costo de Compra";
            costoCompra.MinimumWidth = 6;
            costoCompra.Name = "costoCompra";
            costoCompra.Width = 125;
            // 
            // rnd
            // 
            rnd.HeaderText = "RND";
            rnd.MinimumWidth = 6;
            rnd.Name = "rnd";
            rnd.Width = 125;
            // 
            // cantDemanda
            // 
            cantDemanda.HeaderText = "Demanda";
            cantDemanda.MinimumWidth = 6;
            cantDemanda.Name = "cantDemanda";
            cantDemanda.Width = 125;
            // 
            // ventasRealziadas
            // 
            ventasRealziadas.HeaderText = "Ventas Realziadas";
            ventasRealziadas.MinimumWidth = 6;
            ventasRealziadas.Name = "ventasRealziadas";
            ventasRealziadas.Width = 125;
            // 
            // ganacias
            // 
            ganacias.HeaderText = "Ganancias por Ventas";
            ganacias.MinimumWidth = 6;
            ganacias.Name = "ganacias";
            ganacias.Width = 125;
            // 
            // stockRestante
            // 
            stockRestante.HeaderText = "Stock Restante";
            stockRestante.MinimumWidth = 6;
            stockRestante.Name = "stockRestante";
            stockRestante.Width = 125;
            // 
            // gananaciasDevolucion
            // 
            gananaciasDevolucion.HeaderText = "Ganacias P/Devolucion";
            gananaciasDevolucion.MinimumWidth = 6;
            gananaciasDevolucion.Name = "gananaciasDevolucion";
            gananaciasDevolucion.Width = 125;
            // 
            // demandaNoSatisfecha
            // 
            demandaNoSatisfecha.HeaderText = "Demanda no Satisfecha";
            demandaNoSatisfecha.MinimumWidth = 6;
            demandaNoSatisfecha.Name = "demandaNoSatisfecha";
            demandaNoSatisfecha.Width = 125;
            // 
            // costoOportunidad
            // 
            costoOportunidad.HeaderText = "Costo de Oportunidad";
            costoOportunidad.MinimumWidth = 6;
            costoOportunidad.Name = "costoOportunidad";
            costoOportunidad.Width = 125;
            // 
            // gananciaNeta
            // 
            gananciaNeta.HeaderText = "Ganancia Neta";
            gananciaNeta.MinimumWidth = 6;
            gananciaNeta.Name = "gananciaNeta";
            gananciaNeta.Width = 125;
            // 
            // acumuladorVentas
            // 
            acumuladorVentas.HeaderText = "Acumulador Ventas";
            acumuladorVentas.MinimumWidth = 6;
            acumuladorVentas.Name = "acumuladorVentas";
            acumuladorVentas.Width = 125;
            // 
            // ventasPromedio
            // 
            ventasPromedio.HeaderText = "Ventas Promedio";
            ventasPromedio.MinimumWidth = 6;
            ventasPromedio.Name = "ventasPromedio";
            ventasPromedio.Width = 125;
            // 
            // acumuladorGananciasTotales
            // 
            acumuladorGananciasTotales.HeaderText = "Acumulador de Ganancia P/Ventas Totales";
            acumuladorGananciasTotales.MinimumWidth = 6;
            acumuladorGananciasTotales.Name = "acumuladorGananciasTotales";
            acumuladorGananciasTotales.Width = 125;
            // 
            // acumuladorGananciaDevolucion
            // 
            acumuladorGananciaDevolucion.HeaderText = "Acumulador de Ganancia P/Devolucion";
            acumuladorGananciaDevolucion.MinimumWidth = 6;
            acumuladorGananciaDevolucion.Name = "acumuladorGananciaDevolucion";
            acumuladorGananciaDevolucion.Width = 125;
            // 
            // acumuladorCostoAdquisicion
            // 
            acumuladorCostoAdquisicion.HeaderText = "Acumulador de Costo P/Adquisicion";
            acumuladorCostoAdquisicion.MinimumWidth = 6;
            acumuladorCostoAdquisicion.Name = "acumuladorCostoAdquisicion";
            acumuladorCostoAdquisicion.Width = 125;
            // 
            // acumuladorGananciaNeta
            // 
            acumuladorGananciaNeta.HeaderText = "Acumulador Ganancia Neta";
            acumuladorGananciaNeta.MinimumWidth = 6;
            acumuladorGananciaNeta.Name = "acumuladorGananciaNeta";
            acumuladorGananciaNeta.Width = 125;
            // 
            // gananciaNetaPromedio
            // 
            gananciaNetaPromedio.HeaderText = "Ganancia Neta Promedio";
            gananciaNetaPromedio.MinimumWidth = 6;
            gananciaNetaPromedio.Name = "gananciaNetaPromedio";
            gananciaNetaPromedio.Width = 125;
            // 
            // acumCostoOprotunidad
            // 
            acumCostoOprotunidad.HeaderText = "Acumulador de Costo de Oprotunidad";
            acumCostoOprotunidad.MinimumWidth = 6;
            acumCostoOprotunidad.Name = "acumCostoOprotunidad";
            acumCostoOprotunidad.Width = 125;
            // 
            // costoOprtunidadProm
            // 
            costoOprtunidadProm.HeaderText = "Costo de Oprtunidad Promedio";
            costoOprtunidadProm.MinimumWidth = 6;
            costoOprtunidadProm.Name = "costoOprtunidadProm";
            costoOprtunidadProm.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1642, 881);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblIteraciones;
        private ComboBox cbx_Politica;
        private Label label4;
        private TextBox textBoxCostoOportunidad;
        private Label label5;
        private TextBox textBoxRetorno;
        private Label label2;
        private TextBox textBoxPrecioVenta;
        private Label label3;
        private TextBox textBoxCosto;
        private Label label1;
        private TextBox textBoxIteraciones;
        private TextBox textBoxValorPolitica;
        private Label label6;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn demanda;
        private DataGridViewTextBoxColumn probabilidad;
        private DataGridViewTextBoxColumn limIneferior;
        private DataGridViewTextBoxColumn limSuperiror;
        private GroupBox groupBox3;
        private TextBox textBoxHasta;
        private Label label7;
        private TextBox textBoxDesde;
        private Label label8;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn iteracion;
        private DataGridViewTextBoxColumn stockDisponible;
        private DataGridViewTextBoxColumn costoCompra;
        private DataGridViewTextBoxColumn rnd;
        private DataGridViewTextBoxColumn cantDemanda;
        private DataGridViewTextBoxColumn ventasRealziadas;
        private DataGridViewTextBoxColumn ganacias;
        private DataGridViewTextBoxColumn stockRestante;
        private DataGridViewTextBoxColumn gananaciasDevolucion;
        private DataGridViewTextBoxColumn demandaNoSatisfecha;
        private DataGridViewTextBoxColumn costoOportunidad;
        private DataGridViewTextBoxColumn gananciaNeta;
        private DataGridViewTextBoxColumn acumuladorVentas;
        private DataGridViewTextBoxColumn ventasPromedio;
        private DataGridViewTextBoxColumn acumuladorGananciasTotales;
        private DataGridViewTextBoxColumn acumuladorGananciaDevolucion;
        private DataGridViewTextBoxColumn acumuladorCostoAdquisicion;
        private DataGridViewTextBoxColumn acumuladorGananciaNeta;
        private DataGridViewTextBoxColumn gananciaNetaPromedio;
        private DataGridViewTextBoxColumn acumCostoOprotunidad;
        private DataGridViewTextBoxColumn costoOprtunidadProm;
    }
}