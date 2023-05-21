using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TikTok.Datos;
using TikTok.Modelo;
using Xamarin.Forms;

namespace TikTok.VistaModelo
{
    public class VMReproductor : BaseViewModel
    {

        #region VARIABLES        
        ObservableCollection<MVideos> _Lista;
        #endregion
        #region CONSTRUCTOR
        public VMReproductor(INavigation navigation)
        {
            Navigation = navigation;
            MostrarLista();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<MVideos> Lista
        {
            get { return _Lista; }
            set { SetValue(ref _Lista, value); }
        }
        #endregion
        #region PROCESOS
        public async void MostrarLista()
        {
            var funcion = new DVideos();
            Lista = funcion.MostrarVideos();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        
        #endregion

    }
}
