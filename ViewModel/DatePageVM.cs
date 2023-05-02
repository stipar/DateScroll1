using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp3.Models;
using System.Collections.ObjectModel;

namespace MauiApp3.ViewModel
{
    public partial class DatePageVM : BaseViewModel
    {
        public DatePageVM()
        {
            int mes = DateTime.Now.Month;
            DateTime fecha = new(DateTime.Now.Year, mes, 1);

            ObservableCollection<DateModel> lista = new();

            bool sel;

            while (fecha.Month == DateTime.Now.Month)
            {
                if (fecha == DateTime.Now.Date)
                {
                    sel = true;
                    fechaAnterior = fecha;
                }
                else
                {
                    sel = false;
                }
  
                lista.Add(new DateModel
                {
                    Fecha = fecha,
                    Seleccionado = sel
                });
                fecha = fecha.AddDays(1);
            }
            DateList = lista;
        }

        [RelayCommand]
        private void SeleccionarFecha(DateModel fecha)
        {
            int id;
            DateModel fechaTmp = new();

            if (fecha.Fecha != fechaAnterior)
            {
                id = dateList.IndexOf(fecha);
                fechaTmp = new()
                {
                    Fecha = fecha.Fecha,
                    Seleccionado = true
                };
                DateList[id] = fechaTmp;

                id = dateList.IndexOf(dateList.FirstOrDefault(x => x.Fecha == fechaAnterior));
                fechaTmp = new()
                {
                    Fecha = fechaAnterior,
                    Seleccionado = false
                };
                DateList[id] = fechaTmp;
                fechaAnterior = fecha.Fecha;
            }
            //OnPropertyChanged(nameof(DateList));
        }

        [ObservableProperty] ObservableCollection<DateModel> dateList;

        DateTime fechaAnterior;
    }
}
