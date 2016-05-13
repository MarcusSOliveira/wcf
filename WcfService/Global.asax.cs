using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Ninject;
using Ninject.Web.Common;
using Projeto.Infra.Repositorio.Contracts;
using Projeto.Infra.Repositorio.Persistence;
using Service;

namespace WcfService
{
    public class Global : NinjectHttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        //Mapear as dependencias!!!
        protected override IKernel CreateKernel()
        {
            var Kernel = new StandardKernel();

            Kernel.Bind(typeof(IRepositoryBase<,>)).To(typeof(RepositoryBase<,>));
            Kernel.Bind<IRepositoryFuncionario>().To<RepositoryFuncionario>();
            Kernel.Bind<IRepositoryEndereco>().To<RepositoryEndereco>();

            return Kernel;
        }
    }
}