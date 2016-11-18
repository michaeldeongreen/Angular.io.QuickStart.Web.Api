namespace Angular.io.QuickStart.Web.Api.DependencyResolution {
    using System.Web;

    using Angular.io.QuickStart.Web.Api.App_Start;

    using StructureMap.Web.Pipeline;
    using Repository.Interfaces;
    using System.Web.Mvc;
    using System.Diagnostics;

    public class StructureMapScopeModule : IHttpModule {
        #region Public Methods and Operators

        public void Dispose() {
        }

        public void Init(HttpApplication context) {
            context.BeginRequest += (sender, e) => StructuremapMvc.StructureMapDependencyScope.CreateNestedContainer();
            context.EndRequest += (sender, e) => {
                HttpContextLifecycle.DisposeAndClearAll();
                StructuremapMvc.StructureMapDependencyScope.DisposeNestedContainer();
            };
        }
        #endregion
    }
}