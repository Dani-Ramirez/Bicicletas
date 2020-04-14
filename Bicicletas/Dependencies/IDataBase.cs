using System;
using System.Collections.Generic;
using System.Text;

namespace Bicicletas.Dependencies
{
    public interface IDataBase
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
