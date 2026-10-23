using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator.Maui.Models
{
    public class ConsumoCompartido
    {
        //propiedades necesarias para realizar los calculos
        public decimal ImporteDelConsumo { get; set; }
        public int NumeroDePersonas { get; set; }
        public decimal PorcentajeDePropina { get; set; }
        //propiedades que guardan los calculos resultantes
        public decimal ImporteDelConsumoPorPersona => ImporteDelConsumo / NumeroDePersonas;
        public decimal ImporteDeLaPropina => ImporteDelConsumo * PorcentajeDePropina / 100.0m;
        public decimal ImporteDeLaPropinaPorPersona => ImporteDelConsumoPorPersona + ImporteDeLaPropina;
        public decimal ImporteTotalConPropina => ImporteDelConsumo + ImporteDeLaPropina;
        public decimal ImporteTotalConPropinaPorPersona => ImporteDelConsumoPorPersona + ImporteDeLaPropinaPorPersona;
        public ConsumoCompartido(decimal importeDelConsumo,
            int numeroDePersonas,
            decimal porcentajeDePropina)
        {
            ImporteDelConsumo = importeDelConsumo;
            NumeroDePersonas = numeroDePersonas;
            PorcentajeDePropina = porcentajeDePropina;
        }

    }
}