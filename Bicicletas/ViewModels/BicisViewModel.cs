using Bicicletas.Base;
using Bicicletas.Models;
using Bicicletas.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Bicicletas.ViewModels
{
    public class BicisViewModel:ViewModelBase
    {
        public BicisViewModel()
        {
            RepositoryBicis repo = new RepositoryBicis();
            List<Bici> lista = repo.GetBicis();
            this.Bicis = new ObservableCollection<Bici>(lista);
        }

        private ObservableCollection<Bici> _Bicis;
        public ObservableCollection<Bici> Bicis
        {
            get { return this._Bicis; }
            set
            {
                this._Bicis = value;
                OnPropertyChanged("Bicis");
            }
        }
    }
}
