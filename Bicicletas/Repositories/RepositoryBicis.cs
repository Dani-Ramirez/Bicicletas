using Bicicletas.Dependencies;
using Bicicletas.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Bicicletas.Repositories
{
    public class RepositoryBicis
    {
        private SQLiteConnection cn;

        public RepositoryBicis()
        {
            this.cn = DependencyService.Get<IDataBase>().GetConnection();

        }

        //------------------MÉTODOS:
        public void CrearBBDD()
        {
            this.cn.DropTable<Bici>();
           
            this.cn.CreateTable<Bici>();

        }

        public List<Bici> GetBicis()
        {
            var consulta = from datos in cn.Table<Bici>()
                                        select datos;
            return consulta.ToList();
        }
        public Bici BuscarBici(int num)
        {
            var consulta = from datos in cn.Table<Bici>()
                           where datos.Codigo == num
                           select datos;
            return consulta.FirstOrDefault();
        }
        public void InsertarBici(int num, string nom, string car)
        {
            Bici raz = new Bici();
            raz.Caracteristicas = car;
            raz.Codigo = num;
            raz.Nombre = nom;
            this.cn.Insert(raz);
        }

        public void ModificarBici(int num, string nom, string car)
        {
            Bici raz = this.BuscarBici(num);
            raz.Nombre = nom;
            raz.Caracteristicas = car;
            this.cn.Update(raz);
        }
        public void EliminarBici(int num)
        {
            Bici raz = this.BuscarBici(num);
            this.cn.Delete<Bici>(num);
        }
    }
}
