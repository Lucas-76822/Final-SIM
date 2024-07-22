using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Tabla
    {
        public int Iteracion { get; set; }
        public int StockDsponible { get; set; }
        public double CostoAdquisicion { get; set; }
        public double Rnd { get; set; }
        public int Demanda { get; set; }
        public int VentasRealziadas { get; set; }
        public double GananciasVentas { get; set; }
        public int StockRestante { get; set; }
        public double GananciaDevolucion { get; set; }
        public int DemandaNoSatisfecha { get; set; }
        public double CostoOportunidad { get; set; }
        public double GananciaNeta { get; set; }



        public double AcumuladorVentas { get; set; }
        public double VentasPromedio { get; set; }
        public double AcumuladorGanaiasPorVentas { get; set; }
        public double AcumuladorGananciasDevolucion { get; set; }
        public double AcumuladorCostoAdquisicion { get; set; }
        public double AcumuladorOportunidad { get; set; }
        public double AcumuladorGanaciasNeta { get; set; }
        public double GananciasNetaPromedio { get; set; }
        public double AcumuladorCostosOprtunidad { get; set; }
        public double CostoOprtunidadPromedio { get; set; }



        public double GenerarRnd()
        {
            Random rnd = new Random();
            return (double)rnd.NextDouble();
        }
        public double CalcularCostoCompra(int stockDisponible, double precioVenta)
        {
            double costoCompra = stockDisponible * precioVenta;
            return costoCompra;
        }
        public bool CalcularCantidadDemanda(double rnd, double limiteInf, double limiteSup)
        {
            if (rnd >= limiteInf && rnd < limiteSup) {
                return true;
            }
            return false;
        }
        public int CalcularVentasRealizadas(int stockDisponible, int demanda)
        {
            if (stockDisponible - demanda <= 0) {
                return stockDisponible;
            }
            else
            {
                return demanda;
            }
        }
        public double CalcularGananciasPorVentas(int ventasRealizadas, double precioVenta)
        {
            return ventasRealizadas * precioVenta;
        }
        public int CalcularStockRestante(int stockDisponible, int demanda)
        {
            if (stockDisponible - demanda > 0)
            {
                return stockDisponible - demanda;
            }
            else
            {
                return 0;
            }
        }
        public double CalcularGananciasPorDevolucion(int stockRestante, double precioDevolucion)
        {
            return stockRestante * precioDevolucion;
        }
        public int CalcularDemandaNoSatisfecha(int stockDisponible, int demnada)
        {
            if (demnada - stockDisponible > 0)
            {
                return Demanda -  stockDisponible;
            }
            else
            {
                return 0;
            }
        }
        public double CalcularCostoOportunidad(int demandaNoSatisfecha, double costoOprtunidad)
        {
            return demandaNoSatisfecha * costoOprtunidad;
        }
        public double CalcularAcumulacionVentas(double acumuladorVentasDiaAnterior, int ventaActual)
        {
            return acumuladorVentasDiaAnterior + ventaActual;
        }
        public double PromedioVentasProDia(double acumuladorVentas, int iteracion)
        {
            double promedioVetnas = acumuladorVentas / iteracion;
            return (Math.Round(promedioVetnas, MidpointRounding.ToPositiveInfinity));
        }
        public double CalcularAcumulacionGanaciasPorVentas(double acumuladorGanaciasVentasAnterior, double gananciaActual)
        {
            return(acumuladorGanaciasVentasAnterior + gananciaActual);
        }
        public double CalcularAcumulacionPorDevolucion(double acumuladorGanaciasDevolucionAnterior, double gananciaDevlucionActual)
        {
            return (acumuladorGanaciasDevolucionAnterior + gananciaDevlucionActual);
        }
        public double CalcularAcumulacionCostoPorAdquicision(double acumuladorCostoAnterior, double costoActual)
        {
            return (acumuladorCostoAnterior + costoActual);
        }
        public double CalcularGanaciaNeta(double ganaciaVentas, double ganaciaDevoulucion, double costoAdquisicion) 
        {
            return(ganaciaVentas+ganaciaDevoulucion-costoAdquisicion);
        }
        public double CalcularGananciaNetaAcumulada(double acumuladorGananciaNetaAnterior, double ganancuaNetaActual)
        {
            return(acumuladorGananciaNetaAnterior + ganancuaNetaActual);
        }
        public double CalcularGananciaNetaPromedioPorDia(double acumuladorGanaciaNeta, int iteracion)
        {
            return (acumuladorGanaciaNeta / iteracion);
        }
        public double CalcularCostoOportunidadAcumulado(double acumuladorCostoOprtunidadAnterior, double costoOportunidadActual)
        {
            return (acumuladorCostoOprtunidadAnterior + costoOportunidadActual);
        }
        public double CalcularCostoOportunidadProemdio(double acumuladorCostoOprtunidad, int i)
        {
            return (acumuladorCostoOprtunidad / i);
        }
    }
}
