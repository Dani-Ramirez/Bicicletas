
using Bicicletas.Models;
using Bicicletas.Repositories;
using Bicicletas.ViewModels;
using Bicicletas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bicicletas
{
    
    public partial class MainPage : ContentPage
    {
       
           RepositoryBicis repo;
        public MainPage()
        {
            InitializeComponent();
            this.repo = new RepositoryBicis();
            this.repo.CrearBBDD();
            this.btneliminar.Clicked += Btneliminar_Clicked;
            this.btnmodificar.Clicked += Btnmodificar_Clicked;
            this.btnmostrar.Clicked += Btnmostrar_Clicked;
            this.btnnuevo.Clicked += Btnnuevo_Clicked;
        }

        private async void Btnnuevo_Clicked(object sender, EventArgs e)
        {
            InsertarBici view = new InsertarBici();
            await Navigation.PushModalAsync(view);

        }

        private async void Btnmostrar_Clicked(object sender, EventArgs e)
        {
            BicisView view = new BicisView();
            await Navigation.PushModalAsync(view);

        }

        private async void Btnmodificar_Clicked(object sender, EventArgs e)
        {
            ModificarBici view = new ModificarBici();
            BiciModel viewmodel = new BiciModel();

            //buscar el número de departamento que hay en la caja
            int num = int.Parse(this.cajacodigo.Text);
            //asociarlo con viewmodel
            Bici raz = this.repo.BuscarBici(num);
            viewmodel.Bici = raz;
            view.BindingContext = viewmodel;
            await Navigation.PushModalAsync(view);
        }

        private async void Btneliminar_Clicked(object sender, EventArgs e)
        {
            EliminarBici view = new EliminarBici();
            BiciModel viewmodel = new BiciModel();
            int num = int.Parse(this.cajacodigo.Text);
            Bici raz = this.repo.BuscarBici(num);
            viewmodel.Bici = raz;
            view.BindingContext = viewmodel;
            await Navigation.PushModalAsync(view);
        }
    }
}
       