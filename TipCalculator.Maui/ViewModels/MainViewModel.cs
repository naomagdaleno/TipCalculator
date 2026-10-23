using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TipCalculator.Maui.Models;

namespace TipCalculator.Maui.ViewsModels
{
    public partial class MainViewsModel : ObservableObject
    {
        //variables de instancia para datos de entrada de la IU
        [ObservableProperty]
        private string _importeDelConsumo;
        [ObservableProperty]
        private string _numeroDePersonas;
        [ObservableProperty]
        private string _porcentajeDePropina;

        //variables de instancia para datos de salida de la IU
        [ObservableProperty]
        public string _importeDelConsumoPorPersona;
        [ObservableProperty]
        public string _importeDeLaPropina;
        [ObservableProperty]
        public string _importeDeLaPropinaPorPersona;
        [ObservableProperty]
        public string _importeTotalConPropina;
        [ObservableProperty]
        public string _importeTotalConPropinaPorPersona;

        public MainViewsModel()
        {
            Limpiar();
        }

        [RelayCommand]
        public void CalcularPropina()
        {
            decimal importeDelConsumo;
            int numeroDePersonas;
            decimal porcentajeDePropina;

            bool importeDelConsumoEsValido = decimal.TryParse(ImporteDelConsumo, out importeDelConsumo);
            bool numeroDePersonasEsValido = int.TryParse(NumeroDePersonas, out numeroDePersonas);
            bool porcentajeDePropinaEsValido = decimal.TryParse(PorcentajeDePropina, out porcentajeDePropina);

            if (importeDelConsumoEsValido && numeroDePersonasEsValido && porcentajeDePropinaEsValido)
            {
                var consumo = new ConsumoCompartido
                    (importeDelConsumo, numeroDePersonas, porcentajeDePropina);
                ImporteDelConsumoPorPersona = consumo.ImporteDelConsumoPorPersona.ToString("C2");
                ImporteDeLaPropina = consumo.ImporteDeLaPropina.ToString("C2");
                ImporteDeLaPropinaPorPersona = consumo.ImporteDeLaPropinaPorPersona.ToString("C2");
                ImporteTotalConPropina = consumo.ImporteTotalConPropina.ToString("C2");
                ImporteTotalConPropinaPorPersona = consumo.ImporteTotalConPropinaPorPersona.ToString("C2");
            }
        }
        [RelayCommand]
        public void Limpiar()
        {
            ImporteDelConsumoPorPersona = string.Empty;
            ImporteDeLaPropina = string.Empty;
            ImporteDeLaPropinaPorPersona = string.Empty;
            ImporteTotalConPropina = string.Empty;
            ImporteTotalConPropinaPorPersona = string.Empty;
        }

    }
}