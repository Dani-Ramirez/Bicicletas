using Bicicletas.Base;
using Bicicletas.Models;
using Bicicletas.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Bicicletas.ViewModels
{
    public class BiciModel : ViewModelBase
    {
        RepositoryBicis repo;
        public BiciModel()
        {
            this.repo = new RepositoryBicis();
            this.Bici = new Bici();
        }

        public Command InsertarBici
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.InsertarBici(this.Bici.Codigo,
                        Bici.Nombre, Bici.Caracteristicas
                        );
                });
            }
         }

        public Command ModificarBici
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.ModificarBici(this.Bici.Codigo,
                        Bici.Nombre, Bici.Caracteristicas
                        );
                });
            }
        }

        public Command EliminarBici
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.EliminarBici(this.Bici.Codigo
                        );
                });
            }
        }

        private Bici _Bici;
        public Bici Bici
        {
            get { return this._Bici; }
            set
            {
                this._Bici = value;
                OnPropertyChanged("Bici");
            }
        }
    }
}
