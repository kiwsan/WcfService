﻿using Autofac.Core.Lifetime;
using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service : IService
    {

        [WebGet]
        public string GetData(int value)
        {
            try
            {
                using (var httpRequestScope = AutofacHostFactory.Container.BeginLifetimeScope(MatchingScopeLifetimeTags.RequestLifetimeScopeTag))
                {
                    //var appConfigurationService = httpRequestScope.Resolve<IAppConfigurationService>();

                    return string.Format("You entered: {0}", value);
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }
}
