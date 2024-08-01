using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Tabla
    {
        public int Reloj{get;set;}
        public double RndDemanda { get;set;}
        public int Demanda { get;set;}
        public double RndDemora { get;set;}
        public int Demora { get;set;}
        public string OrdenPedido { get;set;}
        public int LlegadaPedido { get;set;}
        public int StockDisponible { get;set;}
        public int Stock { get; set; }
        public int StockFaltante { get; set; }
        public double Ko { get; set; }
        public double Km { get; set; }
        public double Ks { get; set; }
        public double CostoTotal { get; set; }
        public double CostoAcumulado { get; set; }




        public double GenerarRnd()
        {
            Random rnd = new Random();
            return (double)rnd.NextDouble();
        }

        
        public double CalcularCosto(int stock, double costoPorUnidad)
        {
            double costo = stock * costoPorUnidad;
            return costo;
        }

        public bool CalcularCantidadDemanda(double rnd, double limiteInf, double limiteSup)
        {
            if (rnd >= limiteInf && rnd < limiteSup) {
                return true;
            }
            return false;
        }

        public int CalcularStockRestante(int stockDisponible, int demanda)
        {
            if (stockDisponible - demanda >= 0) {
                return stockDisponible - demanda;
            }
            else
            {
                return 0;
            }
        }

        public int CalcularStockFaltante(int stockDisponible, int demanda)
        {
            if (stockDisponible - demanda < 0)
            {
                return Math.Abs(stockDisponible - demanda);
            }
            else
            {
                return 0;
            }
        }

        public double CalcularCostoOportunidad(int demandaNoSatisfecha, double ks)
        {
            return demandaNoSatisfecha * ks;
        }
        public double CalcularCostoTotal(double ko, double km, double ks)
        {
            return (ko + km + ks);
        }
        public double CalcularAcumulacionCosto(double acumuladorCostoAnterior, double costoActual)
        {
            return (acumuladorCostoAnterior + costoActual);
        }
        public int ProximaLlegadaPedido(int relos, int demora)
        {
            return (relos + demora);
        }


    }
}
