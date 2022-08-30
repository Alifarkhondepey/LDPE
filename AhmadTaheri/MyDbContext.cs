using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AhmadTaheri
{
    class MyDbContext:DbContext
    {

        public MyDbContext() : base()
        {
            var cs = ConfigurationManager.ConnectionStrings["defaultConnection"]
                                         .ConnectionString;

            this.Database.Connection.ConnectionString = cs;
        }

    }
}
