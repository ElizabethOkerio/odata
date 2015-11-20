using Microsoft.OData.Edm;
using odata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace odata
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapODataServiceRoute("odata", null, GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
            config.EnsureInitialized();
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.Namespace = "Sample";
            builder.ContainerName = "DefaultContainer";
            builder.EntitySet<User>("Users");
            builder.EntitySet<Address>("Addresses");
            var edmModel = builder.GetEdmModel();
            return edmModel;
        }
    }
}
