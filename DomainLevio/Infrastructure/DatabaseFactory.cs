

using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private Contexte2 dataContext;
        public Contexte2 DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new Contexte2();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
