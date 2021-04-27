
using System;
using System.Windows;
using System.Windows.Input;
using Business;
using Semana04.Model;
namespace Semana04.ViewModel
{
    public class ManCategoriaViewModel : ViewModelBase
    {
        #region propiedades
        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    OnPropertyChanged();
                }
            }
        }

        string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (_Nombre != value)
                {
                    _Nombre = value;
                    OnPropertyChanged();
                }
            }
        }

        string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                if (_Descripcion != value)
                {
                    _Descripcion = value;
                    OnPropertyChanged();
                }
            }
        }

       
        #endregion

        public ICommand GrabarCommand {  set; get; }
        public ICommand CerrarCommand { set; get; }
        
        public ManCategoriaViewModel()
        {
            
         
            GrabarCommand = new RelayCommand<Window>(
                o => Grabar(o) );

            CerrarCommand = new RelayCommand<Window>(
                param => Cerrar(param)
                );

        }   
        void Grabar(Window window)
        {
            {

                if (ID > 0)
                    new CategoriaModel().Actualizar(new Entity.Categoria
                    {
                        IdCategoria = ID,
                        NombreCategoria = Nombre,
                        Desripcion = Descripcion
                    });
                else
                    new CategoriaModel().Insertar(new Entity.Categoria
                    {

                        NombreCategoria = Nombre,
                        Desripcion = Descripcion
                    });
                window.Close();
            }
        }
        void Cerrar(Window window)
        {
            window.Close();
            
        }
    }
    


}
