using Helpers.Implementations;
using Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresRomains
{
    public class NinjectBinding : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IConvertisseurRomain>().To<ConvertisseurRomain>();
        }
    }
}
