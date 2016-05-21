using System;
using System.Linq;
using Microsoft.Practices.Unity;

namespace JBrick.Client.Web.EquipmentGuide.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            Web.Core.Config.UnityConfig.RegisterCommonTypes(container);

            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies().Where(t => t.Namespace != null && t.Namespace.StartsWith("JBrick.BL.EquipmentGuide")),
                WithMappings.FromMatchingInterface,
                overwriteExistingMappings: false);

            // Uncomment the registration section for either EF or Sql UoW implementation
            //container.RegisterTypes(
            //    AllClasses.FromLoadedAssemblies().Where(t => t.Namespace != null && t.Namespace.StartsWith("JBrick.Dal.Sql.EquipmentGuideMock")),
            //    WithMappings.FromMatchingInterface,
            //    overwriteExistingMappings: false);

            //container.RegisterTypes(
            //    AllClasses.FromLoadedAssemblies().Where(t => t.Namespace != null && t.Namespace.StartsWith("JBrick.Dal.Sql")),
            //    WithMappings.FromMatchingInterface,
            //    overwriteExistingMappings: false);

            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies().Where(t => t.Namespace != null && t.Namespace.StartsWith("JBrick.Dal.EF.EquipmentGuide")),
                WithMappings.FromMatchingInterface,
                overwriteExistingMappings: false);

            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies().Where(t => t.Namespace != null && t.Namespace.StartsWith("JBrick.Dal.EF")),
                WithMappings.FromMatchingInterface,
                overwriteExistingMappings: false);
        }
    }
}
