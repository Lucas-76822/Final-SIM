using System.Drawing;
using System.Text.RegularExpressions;
using System.Reflection;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbx_Politica.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Politica.Items.Add("Demanda Anterior");
            cbx_Politica.Items.Add("22");
            cbx_Politica.Items.Add("23");
            cbx_Politica.Items.Add("Otros");
            cbx_Politica.SelectedIndex = 0;
            label6.Text = "Demanda Anterior";
            textBoxValorPolitica.Visible = true;

            int[] demandas = new int[] { 20, 21, 22, 23, 24, 25 };
            double[] probabilidades = new double[] { 0.05, 0.15, 0.22, 0.38, 0.14, 0.06 };
            load_dgvDemanda(demandas, probabilidades);



        }

        private void load_dgvDemanda(int[] demandas, double[] probabilidades)
        {
            dataGridView1.Rows.Clear();
            double valorInferiorSiguinte = 0;
            for (int i = 0; i < demandas.Length; i++)
            {
                if (i < demandas.Length - 1)
                {
                    dataGridView1.Rows.Add();
                }
                dataGridView1.Rows[i].Cells[0].Value = demandas[i].ToString();
                int valor = demandas[i];
                dataGridView1.Rows[i].Cells[1].Value = (Math.Truncate(probabilidades[i] * 10000) / 10000).ToString();
                double valor2 = probabilidades[i];
                dataGridView1.Rows[i].Cells[2].Value = Math.Truncate(valorInferiorSiguinte * 10000) / 10000;
                dataGridView1.Rows[i].Cells[3].Value = (Math.Truncate((valorInferiorSiguinte + probabilidades[i]) * 10000) / 10000).ToString();
                valorInferiorSiguinte = valorInferiorSiguinte + probabilidades[i];
            }

        }
        private void ObtenerDemanda(Tabla fila, double rnd)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (fila.CalcularCantidadDemanda(rnd, double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()), double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString())))
                {
                    fila.Demanda = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    break;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbxPolitica_SelectedIndexChanged(object sender, EventArgs e)
        {

            string politica = cbx_Politica.Text.ToString();
            if (politica == "Otros")
            {
                label6.Visible = true;
                textBoxValorPolitica.Visible = true;
                label6.Text = "Peridicos a Adquirir";
                textBoxValorPolitica.Text = "";
            }
            else if (politica == "Demanda Anterior")
            {
                label6.Visible = true;
                textBoxValorPolitica.Visible = true;
                label6.Text = "Demanda Anterior";
                textBoxValorPolitica.Text = "";
            }
            else
            {
                label6.Visible = false;
                textBoxValorPolitica.Visible = false;
                textBoxValorPolitica.Text = "";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualziarTablaProb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = false;
            flag = ValidarTextBoxInt(textBoxIteraciones, flag);
            if (flag)
            {
                flag = ValidarTextBoxDouble(textBoxCosto, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxDouble(textBoxPrecioVenta, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxDouble(textBoxRetorno, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxDouble(textBoxCostoOportunidad, flag);
            }
            if (cbx_Politica.Text.ToString() == "Demanda Anterior" && flag)
            {
                flag = ValidarTextBoxInt(textBoxValorPolitica, flag);
            }

            if (flag)
            {
                flag = validarRangoInferiorSuperior(textBoxDesde, textBoxHasta, flag);
            }

            if (flag)
            {
                flag = actualziarTablaProb();
            }

            dataGridView2.Rows.Clear();

            int f = 0;
            Tabla filaAnterior = new Tabla();
            Tabla filaActual = new Tabla();


            if (flag)
            {
                if (cbx_Politica.Text.ToString() == "Demanda Anterior")
                {
                    filaAnterior.Demanda = int.Parse(textBoxValorPolitica.Text.ToString());
                }
                for (int i = 0; i <= int.Parse(textBoxIteraciones.Text.ToString()); i++)
                {

                    // 0 Iteracion
                    filaActual.Iteracion = i;

                    // 1 Stock Dsponible

                    if (cbx_Politica.Text.ToString() == "Demanda Anterior")
                    {
                        filaActual.StockDsponible = filaAnterior.Demanda;
                    }
                    else if (cbx_Politica.Text.ToString() == "Otros")
                    {
                        // if (textBoxValorPolitica.Text.ToString() == "" || !Regex.IsMatch(textBoxValorPolitica.Text, @"^[0-9]+([,][0-9]+)?$"))
                        if (textBoxValorPolitica.Text.ToString() == "" || !Regex.IsMatch(textBoxValorPolitica.Text, "^[0-9]+$"))
                        {
                            MessageBox.Show("Es necesario cargar un valor para la politica de adquisicion");
                            textBoxValorPolitica.Text = string.Empty;
                            break;
                        }
                        else if (int.Parse(textBoxValorPolitica.Text.ToString()) <= 0)
                        {
                            MessageBox.Show("\"Es necesario cargar un valor para la politica de adquisicion");
                            textBoxValorPolitica.Text = string.Empty;
                            break;
                        }
                        else
                        {
                            filaActual.StockDsponible = int.Parse(textBoxValorPolitica.Text.ToString());
                        }

                    }
                    else if (cbx_Politica.Text.ToString() == "22")
                    {
                        filaActual.StockDsponible = int.Parse(cbx_Politica.Text.ToString());
                    }
                    else if (cbx_Politica.Text.ToString() == "23")
                    {
                        filaActual.StockDsponible = int.Parse(cbx_Politica.Text.ToString());
                    }


                    // 2 Costo de Adquisicion
                    filaActual.CostoAdquisicion = filaActual.CalcularCostoCompra(filaActual.StockDsponible, double.Parse(textBoxCosto.Text.ToString()));


                    // 3 RND
                    filaActual.Rnd = filaActual.GenerarRnd();


                    // 4 Demanda
                    ObtenerDemanda(filaActual, filaActual.Rnd);

                    // 5 Ventas Realziadas
                    filaActual.VentasRealziadas = filaActual.CalcularVentasRealizadas(filaActual.StockDsponible, filaActual.Demanda);


                    // 6 Ganancias Ventas
                    filaActual.GananciasVentas = filaActual.CalcularGananciasPorVentas(filaActual.VentasRealziadas, double.Parse(textBoxPrecioVenta.Text.ToString()));


                    // 7 Stock Restante
                    filaActual.StockRestante = filaActual.CalcularStockRestante(filaActual.StockDsponible, filaActual.Demanda);


                    // 8 Ganancia Por Devolucion
                    filaActual.GananciaDevolucion = filaActual.CalcularGananciasPorDevolucion(filaActual.StockRestante, double.Parse(textBoxRetorno.Text.ToString()));


                    // 9 Demanda no satisfecha
                    filaActual.DemandaNoSatisfecha = filaActual.CalcularDemandaNoSatisfecha(filaActual.StockDsponible, filaActual.Demanda);


                    // 10 Cosoto de Oportunidad
                    filaActual.CostoOportunidad = filaActual.CalcularCostoOportunidad(filaActual.DemandaNoSatisfecha, double.Parse(textBoxCostoOportunidad.Text.ToString()));


                    // 11 Ganacia Neta
                    filaActual.GananciaNeta = filaActual.CalcularGanaciaNeta(filaActual.GananciasVentas, filaActual.GananciaDevolucion, filaActual.CostoAdquisicion);


                    // 12 Acumulador de Ventas
                    if (i == 0)
                    {
                        filaActual.AcumuladorVentas = filaActual.VentasRealziadas;
                    }
                    else
                    {
                        filaActual.AcumuladorVentas = filaActual.CalcularAcumulacionVentas(filaAnterior.AcumuladorVentas, int.Parse(filaActual.VentasRealziadas.ToString()));
                    }


                    // 13 Ventas Promedio
                    if (i == 0)
                    {
                        filaActual.VentasPromedio = filaActual.VentasRealziadas;
                    }
                    else
                    {
                        filaActual.VentasPromedio = filaActual.PromedioVentasProDia(filaAnterior.AcumuladorVentas, i);
                    }


                    // 14 Acumulador de Ganancias Por Ventas
                    if (i == 0)
                    {
                        filaActual.AcumuladorGanaiasPorVentas = filaActual.GananciasVentas;
                    }
                    else
                    {
                        filaActual.AcumuladorGanaiasPorVentas = filaActual.CalcularAcumulacionGanaciasPorVentas(filaAnterior.AcumuladorGanaiasPorVentas, filaActual.GananciasVentas);
                    }


                    // 15 Acumulador de Ganancias Por Devolucion
                    if (i == 0)
                    {
                        filaActual.AcumuladorGananciasDevolucion = filaActual.GananciaDevolucion;
                    }
                    else
                    {
                        filaActual.AcumuladorGananciasDevolucion = filaActual.CalcularAcumulacionPorDevolucion(filaAnterior.AcumuladorGananciasDevolucion, filaActual.GananciaDevolucion);
                    }


                    // 16 Acumulador de Costo Por Adquisicion
                    if (i == 0)
                    {
                        filaActual.AcumuladorCostoAdquisicion = filaActual.CostoAdquisicion;
                    }
                    else
                    {
                        filaActual.AcumuladorCostoAdquisicion = filaActual.CalcularAcumulacionCostoPorAdquicision(filaAnterior.AcumuladorCostoAdquisicion, filaActual.CostoAdquisicion);
                    }


                    // 17 Acumulador Ganacias Neta
                    if (i == 0)
                    {
                        filaActual.AcumuladorGanaciasNeta = filaActual.GananciaNeta;
                    }
                    else
                    {
                        filaActual.AcumuladorGanaciasNeta = filaActual.CalcularGananciaNetaAcumulada(filaAnterior.AcumuladorGanaciasNeta, filaActual.GananciaNeta);
                    }


                    // 18 Ganacias Neta Promedio
                    if (i == 0)
                    {
                        filaActual.GananciasNetaPromedio = filaActual.GananciaNeta;
                    }
                    else
                    {
                        filaActual.GananciasNetaPromedio = filaActual.CalcularGananciaNetaPromedioPorDia(filaActual.AcumuladorGanaciasNeta, i);
                    }

                    // 19 Acumulador Costos de Oprtunidad
                    if (i == 0)
                    {
                        filaActual.AcumuladorCostosOprtunidad = filaActual.CostoOportunidad;
                    }
                    else
                    {
                        filaActual.AcumuladorCostosOprtunidad = filaActual.CalcularCostoOportunidadAcumulado(filaAnterior.AcumuladorCostosOprtunidad, filaActual.CostoOportunidad);
                    }


                    // 20 Costo de oprtunidad Promedio
                    if (i == 0)
                    {
                        filaActual.CostoOprtunidadPromedio = filaActual.CostoOportunidad;
                    }
                    else
                    {
                        filaActual.CostoOprtunidadPromedio = filaActual.CalcularCostoOportunidadProemdio(filaActual.AcumuladorCostosOprtunidad, i);
                    }

                    filaAnterior = filaActual;

                    if ((i >= int.Parse(textBoxDesde.Text.ToString()) && i <= int.Parse(textBoxHasta.Text.ToString())) || i == int.Parse(textBoxIteraciones.Text.ToString()))
                    {

                        dataGridView2.Rows.Add();
                        cargarTablaSiulacion(filaActual, f);
                        f++;


                    }
                }
            }
        }
        private void cargarTablaSiulacion(Tabla filaActual, int f)
        {
            dataGridView2.Rows[f].Cells[0].Value = filaActual.Iteracion;
            dataGridView2.Rows[f].Cells[1].Value = filaActual.StockDsponible;
            dataGridView2.Rows[f].Cells[2].Value = filaActual.CostoAdquisicion;
            dataGridView2.Rows[f].Cells[3].Value = filaActual.Rnd;
            dataGridView2.Rows[f].Cells[4].Value = filaActual.Demanda;
            dataGridView2.Rows[f].Cells[5].Value = filaActual.VentasRealziadas;
            dataGridView2.Rows[f].Cells[6].Value = filaActual.GananciasVentas;
            dataGridView2.Rows[f].Cells[7].Value = filaActual.StockRestante;
            dataGridView2.Rows[f].Cells[8].Value = filaActual.GananciaDevolucion;
            dataGridView2.Rows[f].Cells[9].Value = filaActual.DemandaNoSatisfecha;
            dataGridView2.Rows[f].Cells[10].Value = filaActual.CostoOportunidad;
            dataGridView2.Rows[f].Cells[11].Value = filaActual.GananciaNeta;
            dataGridView2.Rows[f].Cells[12].Value = filaActual.AcumuladorVentas;
            dataGridView2.Rows[f].Cells[13].Value = filaActual.VentasPromedio;
            dataGridView2.Rows[f].Cells[14].Value = filaActual.AcumuladorGanaiasPorVentas;
            dataGridView2.Rows[f].Cells[15].Value = filaActual.AcumuladorGananciasDevolucion;
            dataGridView2.Rows[f].Cells[16].Value = filaActual.AcumuladorCostoAdquisicion;
            dataGridView2.Rows[f].Cells[17].Value = filaActual.AcumuladorGanaciasNeta;
            dataGridView2.Rows[f].Cells[18].Value = filaActual.GananciasNetaPromedio;
            dataGridView2.Rows[f].Cells[19].Value = filaActual.AcumuladorCostosOprtunidad;
            dataGridView2.Rows[f].Cells[20].Value = filaActual.CostoOprtunidadPromedio;
        }
        private bool actualziarTablaProb()
        {
            bool flag1 = false;
            bool flag2 = false;
            int cantidadDeFilas = dataGridView1.Rows.Count;
            int[] demandas = new int[cantidadDeFilas];
            double[] probabilidades = new double[cantidadDeFilas];
            double probabilidadAcumulada = 0;
            for (int i = 0; i < cantidadDeFilas; i++)
            {
                string valorDemnada = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string valorProbabilidad = dataGridView1.Rows[i].Cells[1].Value.ToString();

                if (valorDemnada == "" || !Regex.IsMatch(valorDemnada, "^[0-9]+$"))
                {
                    MessageBox.Show("Es necesario cargar un valores numericos entero en la tabla 'Demanda y Probabilidades'");
                    flag1 = false;
                    break;
                }
                else
                {
                    flag1 = true;
                }

                if (valorProbabilidad == "" || !Regex.IsMatch(valorProbabilidad, @"^[0-9]+([,][0-9]+)?$"))
                {
                    MessageBox.Show("Es necesario cargar vaores numericos (separador decimal ',' en la tabla 'Demanda y Probabilidades')");
                    flag2 = false;
                    break;
                }
                else
                {
                    flag2 = true;
                }

                demandas[i] = int.Parse(valorDemnada);
                probabilidades[i] = double.Parse(valorProbabilidad);
                probabilidadAcumulada = probabilidadAcumulada + double.Parse(valorProbabilidad);
            }

            if ((probabilidadAcumulada != 1 && flag2) && flag1)
            {
                MessageBox.Show("Compruba que la suma de las probalidades de 1 en la tabla 'Demanda y Probabilidades'");
                return false;
            }
            else if (flag1 && flag2)
            {
                load_dgvDemanda(demandas, probabilidades);
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool validarRangoInferiorSuperior(TextBox textBoxInf, TextBox textBoxSup, bool flag)
        {
            int sup = int.Parse(textBoxSup.Text.ToString());
            int inf = int.Parse(textBoxInf.Text.ToString());

            if (textBoxInf.Text.ToString() == "" || !Regex.IsMatch(textBoxInf.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Es necesario cargar un valor numerico entero");
                textBoxInf.Text = string.Empty;
                flag = false;
            }
            else if (int.Parse(textBoxInf.Text.ToString()) < 0)
            {
                MessageBox.Show("Es necesario cargar un valor numerico no negativo");
                textBoxInf.Text = string.Empty;
                flag = false;
            }
            else if (textBoxSup.Text.ToString() == "" || !Regex.IsMatch(textBoxSup.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Es necesario cargar un valor numerico entero");
                textBoxSup.Text = string.Empty;
                flag = false;
            }
            else if (int.Parse(textBoxSup.Text.ToString()) < 0)
            {
                MessageBox.Show("Es necesario cargar un valor numerico no negativo");
                textBoxSup.Text = string.Empty;
                flag = false;
            }
            if (inf > sup)
            {
                MessageBox.Show("El limite Inferior (desde) no puede ser mayor al limite superior (hasta)");
                textBoxSup.Text = string.Empty;
                textBoxInf.Text = string.Empty;
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        private bool ValidarTextBoxDouble(TextBox textBox, bool flag)
        {
            if (textBox.Text.ToString() == "" || !Regex.IsMatch(textBox.Text, @"^[0-9]+([,][0-9]+)?$"))
            {
                MessageBox.Show("Es necesario cargar un valor numerico (separador decimal ',')");
                textBox.Text = string.Empty;
                flag = false;
            }
            else if (double.Parse(textBox.Text.ToString()) <= 0)
            {
                MessageBox.Show("Es necesario cargar un valor numerico superior a 0");
                textBox.Text = string.Empty;
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private bool ValidarTextBoxInt(TextBox textBox, bool flag)
        {
            if (textBox.Text.ToString() == "" || !Regex.IsMatch(textBox.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Es necesario cargar un valor numerico entero");
                textBox.Text = string.Empty;
                flag = false;
            }
            else if (int.Parse(textBox.Text.ToString()) <= 0)
            {
                MessageBox.Show("Es necesario cargar un valor numerico superior a 0");
                textBox.Text = string.Empty;
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}