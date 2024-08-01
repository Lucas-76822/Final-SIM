using System.Drawing;
using System.Text.RegularExpressions;
using System.Reflection;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbx_Politica.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Politica.Items.Add("Politica A");
            cbx_Politica.Items.Add("Politica B");
            cbx_Politica.Items.Add("Politica C");
            cbx_Politica.Items.Add("Otros");
            cbx_Politica.SelectedIndex = 0;
            textBoxCantidadDocenas.Visible = false;
            textBoxDiaAprobisionamiento.Visible = false;
            label_CantidadDeocenas.Visible = false;
            label_DiasAprobisionamineto.Visible = false;

            int[] demandas = new int[] { 0, 10, 20, 30, 40, 50 };
            double[] probabilidadesDemanda = new double[] { 0.05, 0.12, 0.18, 0.25, 0.22, 0.18 };
            int[] demora = new int[] { 1, 2, 3, 4 };
            double[] probabilidadesDemora = new double[] { 0.15, 0.20, 0.40, 0.25 };
            load_dgv(demandas, probabilidadesDemanda, dataGridViewDemanda);
            load_dgv(demora, probabilidadesDemora, dataGridViewDemora);
        }

        private void load_dgv(int[] demandas, double[] probabilidades, DataGridView dgv)
        {
            dgv.Rows.Clear();
            double valorInferiorSiguinte = 0;
            for (int i = 0; i < demandas.Length; i++)
            {
                if (i < demandas.Length - 1)
                {
                    dgv.Rows.Add();
                }
                dgv.Rows[i].Cells[0].Value = demandas[i].ToString();
                int valor = demandas[i];
                dgv.Rows[i].Cells[1].Value = (Math.Truncate(probabilidades[i] * 10000) / 10000).ToString();
                double valor2 = probabilidades[i];
                dgv.Rows[i].Cells[2].Value = Math.Truncate(valorInferiorSiguinte * 10000) / 10000;
                dgv.Rows[i].Cells[3].Value = (Math.Truncate((valorInferiorSiguinte + probabilidades[i]) * 10000) / 10000).ToString();
                valorInferiorSiguinte = valorInferiorSiguinte + probabilidades[i];
            }

        }

        private void ObtenerValorDgv(Tabla fila, double rnd, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (fila.CalcularCantidadDemanda(rnd, double.Parse(dgv.Rows[i].Cells[2].Value.ToString()), double.Parse(dgv.Rows[i].Cells[3].Value.ToString())))
                {
                    fila.Demanda = int.Parse(dgv.Rows[i].Cells[0].Value.ToString());
                    break;
                }
            }
        }

        private void cbxPolitica_SelectedIndexChanged(object sender, EventArgs e)
        {

            string politica = cbx_Politica.Text.ToString();
            if (politica == "Otros")
            {
                label_CantidadDeocenas.Visible = true;
                label_CantidadDeocenas.Text = "Cantidad Docenas";
                textBoxCantidadDocenas.Visible = true;
                label_DiasAprobisionamineto.Visible = true;
                textBoxDiaAprobisionamiento.Visible = true;
            }
            else if (politica == "Politica B")
            {

                label_CantidadDeocenas.Visible = true;
                label_CantidadDeocenas.Text = "Demanda Acumuladda Inicial";
                textBoxCantidadDocenas.Visible = true;
                label_DiasAprobisionamineto.Visible = false;
                textBoxDiaAprobisionamiento.Visible = false;

            }
            else
            {
                label_CantidadDeocenas.Visible = false;
                textBoxCantidadDocenas.Visible = false;
                label_DiasAprobisionamineto.Visible = false;
                textBoxDiaAprobisionamiento.Visible = false;
                textBoxCantidadDocenas.Text = "";
                textBoxDiaAprobisionamiento.Text = "";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualziarTablaProb(dataGridViewDemanda, "Demanda y Probabilidades");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool realizadoPedido = false;
            bool flag = false;
            flag = ValidarTextBoxInt(textBoxIteraciones, flag);
            if (flag)
            {
                flag = ValidarTextBoxInt(textBox_StockInicial, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxDouble(textBoxCostoAlm, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxDouble(textBoxCostoRupt, flag);
            }
            if (cbx_Politica.Text.ToString() == "Politica B" && flag)
            {
                flag = ValidarTextBoxInt(textBoxCantidadDocenas, flag);
            }

            if (cbx_Politica.Text.ToString() == "Otros" && flag)
            {
                flag = ValidarTextBoxInt(textBoxCantidadDocenas, flag);
                if (flag)
                {
                    flag = ValidarTextBoxInt(textBoxDiaAprobisionamiento, flag);
                }
            }

            if (flag)
            {
                flag = ValidarTextBoxInt(textBox1_DocenaInf, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxInt(textBox1_DocenaSup, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxDouble(textBox1_Costo, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxInt(textBox2_DocenaInf, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxInt(textBox2_DocenaInf, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxDouble(textBox2_Costo, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxInt(textBox3_DocenaInf, flag);
            }
            if (flag)
            {
                flag = ValidarTextBoxDouble(textBox3_Costo, flag);
            }

            if (flag)
            {
                flag = validarRangoInferiorSuperior(textBox1_DocenaInf, textBox1_DocenaSup, flag);
            }
            if (flag)
            {
                flag = validarRangoInferiorSuperior(textBox1_DocenaSup, textBox2_DocenaInf, flag);
            }
            if (flag)
            {
                flag = validarRangoInferiorSuperior(textBox2_DocenaInf, textBox2_DocenaSup, flag);
            }
            if (flag)
            {
                flag = validarRangoInferior(textBox3_DocenaInf, textBox2_DocenaSup, flag);
            }

            if (flag)
            {
                flag = actualziarTablaProb(dataGridViewDemanda, "Demanda y Probabilidades");

                if (flag)
                {
                    flag = actualziarTablaProb(dataGridViewDemora, "Demora y Probabilidades");
                }

            }

            dataGridView2.Rows.Clear();

            int f = 0;
            bool acumularDemanda = false;
            int cantidadReposicion = 0;
            int diaDeRepocision = 0;
            int contadorDiasRepocision = 0;
            int acumuladorDemanda = 0;
            Tabla filaAnterior = new Tabla();
            Tabla filaActual = new Tabla();


            if (flag)
            {
                if (cbx_Politica.Text.ToString() == "Politica A")
                {
                    cantidadReposicion = 180;
                    diaDeRepocision = 7;
                }
                else if (cbx_Politica.Text.ToString() == "Politica B")
                {
                    cantidadReposicion = 0;
                    diaDeRepocision = 15;
                    acumularDemanda = true;
                }
                else if (cbx_Politica.Text.ToString() == "Politica C")
                {
                    cantidadReposicion = 100;
                    diaDeRepocision = 5;
                }
                else if (cbx_Politica.Text.ToString() == "Otros")
                {
                    cantidadReposicion = int.Parse(textBoxCantidadDocenas.Text.ToString());
                    diaDeRepocision = int.Parse(textBoxDiaAprobisionamiento.Text.ToString());
                }
                for (int i = 0; i <= int.Parse(textBoxIteraciones.Text.ToString()); i++)
                {

                    // 0 Iteracion
                    filaActual.Reloj = i;

                    // 1 RND Demanda
                    if (i == 0)
                    {

                    }
                    else if (i > 0)
                    {
                        filaActual.RndDemanda = filaActual.GenerarRnd();
                    }

                    // 2 Demanda
                    if (i == 0)
                    {

                    }
                    else if (i > 0)
                    {
                        filaActual.Demanda = ObtenerValorTablaProb(filaActual, filaActual.RndDemanda, dataGridViewDemanda);
                    }

                    if (realizadoPedido == false)
                    {
                        contadorDiasRepocision++;
                        if (contadorDiasRepocision >= 6 && acumularDemanda == true)
                        {
                            acumuladorDemanda = acumuladorDemanda + filaActual.Demanda;
                        }
                    }
                    // 5 Orden/pedido
                    //if (i == 0)
                    if (i == 1)
                    {
                        filaActual.OrdenPedido = "SI";
                        realizadoPedido = true;
                        if (acumularDemanda == true)
                        {
                            cantidadReposicion = int.Parse(textBoxCantidadDocenas.Text.ToString()) + filaActual.Demanda;
                        }
                    }
                    else if (i > 0 && realizadoPedido == false && contadorDiasRepocision == diaDeRepocision)
                    {
                        filaActual.OrdenPedido = "SI";
                        realizadoPedido = true;
                        if (acumularDemanda == true)
                        {
                            //cantidadReposicion = acumuladorDemanda;
                            cantidadReposicion = acumuladorDemanda;
                        }
                    }

                    if (realizadoPedido == true)
                    {
                        contadorDiasRepocision = 0;
                    }

                    // 3 RND Demora
                    /*if (i == 0)
                    {
                        filaActual.RndDemora = filaActual.GenerarRnd();
                    }
                    else */
                    if (i > 0 && filaActual.OrdenPedido == "SI")
                    {
                        filaActual.RndDemora = filaActual.GenerarRnd();
                    }

                    // 4 Demora
                    if (i == 0 && filaActual.OrdenPedido == "SI")
                    {
                        filaActual.Demora = ObtenerValorTablaProb(filaActual, filaActual.RndDemora, dataGridViewDemora);
                    }
                    else if (i > 0 && filaActual.OrdenPedido == "SI")
                    {
                        filaActual.Demora = ObtenerValorTablaProb(filaActual, filaActual.RndDemora, dataGridViewDemora);
                    }



                    // 6 Llegada Pedido
                    if (i == 0)
                    {
                        filaActual.LlegadaPedido = filaActual.ProximaLlegadaPedido(filaActual.Reloj, filaActual.Demora);
                    }
                    else if (i > 0 && filaActual.OrdenPedido == "SI")
                    {
                        filaActual.LlegadaPedido = filaActual.ProximaLlegadaPedido(filaActual.Reloj, filaActual.Demora);
                    }
                    else if (i > 0 && filaAnterior.LlegadaPedido != 0 && filaActual.Reloj < filaAnterior.LlegadaPedido && realizadoPedido == true && filaActual.OrdenPedido == null)
                    {
                        filaActual.LlegadaPedido = filaAnterior.LlegadaPedido;
                    }
                    else
                    {
                        filaActual.LlegadaPedido = 0;
                    }

                    // 7 Dispopnible
                    if (i == 0)
                    {
                        filaActual.Stock = int.Parse(textBox_StockInicial.Text.ToString());
                    }
                    else if (i > 0 && filaAnterior.LlegadaPedido == filaActual.Reloj && realizadoPedido == true)
                    {
                        filaActual.StockDisponible = filaAnterior.Stock + cantidadReposicion;
                        realizadoPedido = false;
                        acumuladorDemanda = 0;
                        contadorDiasRepocision = 1;
                    }
                    else if (i > 0)
                    {
                        filaActual.StockDisponible = filaAnterior.Stock;
                    }

                    // 8 Stock
                    if (i == 0)
                    {
                        filaActual.Stock = int.Parse(textBox_StockInicial.Text.ToString());
                    }
                    else if (i > 0)
                    {
                        filaActual.Stock = filaActual.CalcularStockRestante(filaActual.StockDisponible, filaActual.Demanda);
                    }

                    // 9 Stock Faltante
                    if (i == 0)
                    {
                        filaActual.StockFaltante = 0;
                    }
                    else if (i > 0)
                    {
                        filaActual.StockFaltante = filaActual.CalcularStockFaltante(filaActual.StockDisponible, filaActual.Demanda);
                    }

                    // 10 Ko
                    if (filaActual.OrdenPedido == "SI")
                    {
                        if (cantidadReposicion >= int.Parse(textBox1_DocenaInf.Text.ToString()) && cantidadReposicion <= int.Parse(textBox1_DocenaSup.Text.ToString()))
                        {
                            filaActual.Ko = int.Parse(textBox1_Costo.Text.ToString());
                        }
                        else if (cantidadReposicion > int.Parse(textBox2_DocenaInf.Text.ToString()) && cantidadReposicion <= int.Parse(textBox2_DocenaSup.Text.ToString()))
                        {
                            filaActual.Ko = int.Parse(textBox2_Costo.Text.ToString());
                        }
                        if (cantidadReposicion > int.Parse(textBox3_DocenaInf.Text.ToString()))
                        {
                            filaActual.Ko = int.Parse(textBox3_Costo.Text.ToString());
                        }
                    }
                    else { filaActual.Ko = 0; }

                    // 11 Km
                    if (filaActual.Reloj > 0)
                    {
                        filaActual.Km = filaActual.CalcularCosto(filaActual.Stock, double.Parse(textBoxCostoAlm.Text.ToString()));
                    }

                    // 12 Ks
                    if (filaActual.Reloj > 0)
                    {
                        filaActual.Ks = filaActual.CalcularCosto(filaActual.StockFaltante, double.Parse(textBoxCostoRupt.Text.ToString()));
                    }
                    

                    // 13 Costo total
                    filaActual.CostoTotal = filaActual.CalcularCostoTotal(filaActual.Ko, filaActual.Km, filaActual.Ks);

                    // 14 Costo Acumulado
                    if (i == 0)
                    {
                        filaActual.CostoAcumulado = filaActual.CostoTotal;
                    }
                    else
                    {
                        filaActual.CostoAcumulado = filaActual.CalcularAcumulacionCosto(filaAnterior.CostoAcumulado, filaActual.CostoTotal);
                    }

                    filaAnterior = filaActual;
                    //Graficar en la Tabla de simulacion
                    if ((i >= int.Parse(textBoxDesde.Text.ToString()) && i <= int.Parse(textBoxHasta.Text.ToString())) || i == int.Parse(textBoxIteraciones.Text.ToString()))
                    {

                        dataGridView2.Rows.Add();
                        cargarTablaSiulacion(filaActual, f);
                        f++;
                    }
                    filaActual = new Tabla();
                }
            }
        }
        private int ObtenerValorTablaProb(Tabla fila, double rnd, DataGridView dgv)
        {
            int valor = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (fila.CalcularCantidadDemanda(rnd, double.Parse(dgv.Rows[i].Cells[2].Value.ToString()), double.Parse(dgv.Rows[i].Cells[3].Value.ToString())))
                {
                    valor = int.Parse(dgv.Rows[i].Cells[0].Value.ToString());
                    break;
                }
            }
            return valor;
        }
        private void cargarTablaSiulacion(Tabla filaActual, int f)
        {
            dataGridView2.Rows[f].Cells[0].Value = filaActual.Reloj;
            dataGridView2.Rows[f].Cells[1].Value = filaActual.RndDemanda;
            dataGridView2.Rows[f].Cells[2].Value = filaActual.Demanda;
            dataGridView2.Rows[f].Cells[3].Value = filaActual.RndDemora;
            dataGridView2.Rows[f].Cells[4].Value = filaActual.Demora;
            dataGridView2.Rows[f].Cells[5].Value = filaActual.OrdenPedido;
            dataGridView2.Rows[f].Cells[6].Value = filaActual.LlegadaPedido;
            dataGridView2.Rows[f].Cells[7].Value = filaActual.StockDisponible;
            dataGridView2.Rows[f].Cells[8].Value = filaActual.Stock;
            dataGridView2.Rows[f].Cells[9].Value = filaActual.StockFaltante;
            dataGridView2.Rows[f].Cells[10].Value = filaActual.Ko;
            dataGridView2.Rows[f].Cells[11].Value = filaActual.Km;
            dataGridView2.Rows[f].Cells[12].Value = filaActual.Ks;
            dataGridView2.Rows[f].Cells[13].Value = filaActual.CostoTotal;
            dataGridView2.Rows[f].Cells[14].Value = filaActual.CostoAcumulado;
        }
        private bool actualziarTablaProb(DataGridView dgv, string nombreTabla)
        {
            bool flag1 = false;
            bool flag2 = false;
            int cantidadDeFilas = dgv.Rows.Count;
            int[] demandas = new int[cantidadDeFilas];
            double[] probabilidades = new double[cantidadDeFilas];
            double probabilidadAcumulada = 0;
            for (int i = 0; i < cantidadDeFilas; i++)
            {
                string valorDemnada = dgv.Rows[i].Cells[0].Value.ToString();
                string valorProbabilidad = dgv.Rows[i].Cells[1].Value.ToString();

                if (valorDemnada == "" || !Regex.IsMatch(valorDemnada, "^[0-9]+$"))
                {
                    MessageBox.Show("Es necesario cargar un valores numericos entero en la tabla '" + nombreTabla + "'");
                    flag1 = false;
                    break;
                }
                else
                {
                    flag1 = true;
                }

                if (valorProbabilidad == "" || !Regex.IsMatch(valorProbabilidad, @"^[0-9]+([,][0-9]+)?$"))
                {
                    MessageBox.Show("Es necesario cargar vaores numericos (separador decimal ',' en la tabla '" + nombreTabla + "')");
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
                MessageBox.Show("Compruba que la suma de las probalidades de 1 en la tabla '" + nombreTabla + "'");
                return false;
            }
            else if (flag1 && flag2)
            {
                load_dgv(demandas, probabilidades, dgv);
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
                MessageBox.Show("Compueba los valores de las docenas pedidas");
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
        private bool validarRangoInferior(TextBox textBoxInf, TextBox textBoxSup, bool flag)
        {
            int sup = int.Parse(textBoxSup.Text.ToString());
            int inf = int.Parse(textBoxInf.Text.ToString());
            if (inf < sup)
            {
                MessageBox.Show("Compueba los valores de las docenas pedidas");
                textBoxSup.Text = string.Empty;
                textBoxInf.Text = string.Empty;
                flag = false;
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
            else if (int.Parse(textBox.Text.ToString()) < 0)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualziarTablaProb(dataGridViewDemora, "Demora y Probabilidades");
        }
    }
}