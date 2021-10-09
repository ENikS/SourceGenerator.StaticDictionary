using Microsoft.CodeAnalysis;

namespace Unity.Precompiler.Analysis
{
    public static partial class RegisterMethodParsers
    {
        [Parser(OperationKind.Invocation,
            "Unity.IUnityContainer.RegisterFactory(System.Type, string, Func<IUnityContainer, System.Type, string, object>, Unity.Lifetime.IFactoryLifetimeManager)")]
        public static AnalyticModel? RegisterFactory_Type_string_Func_IUnityContainer_Type_string_object_IFactoryLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterFactory<TInterface>(Unity.IUnityContainer, Func<IUnityContainer, object>, Unity.Lifetime.IFactoryLifetimeManager)")]
        public static AnalyticModel? RegisterFactory_TInterface_IUnityContainer_Func_IUnityContainer_object_IFactoryLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterFactory<TInterface>(Unity.IUnityContainer, Func<IUnityContainer, System.Type, string, object>, Unity.Lifetime.IFactoryLifetimeManager)")]
        public static AnalyticModel? RegisterFactory_TInterface_IUnityContainer_Func_IUnityContainer_Type_string_object_IFactoryLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterFactory<TInterface>(Unity.IUnityContainer, string, Func<IUnityContainer, object>, Unity.Lifetime.IFactoryLifetimeManager)")]
        public static AnalyticModel? RegisterFactory_TInterface_IUnityContainer_string_Func_IUnityContainer_object_IFactoryLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterFactory<TInterface>(Unity.IUnityContainer, string, Func<IUnityContainer, System.Type, string, object>, Unity.Lifetime.IFactoryLifetimeManager)")]
        public static AnalyticModel? RegisterFactory_TInterface_IUnityContainer_string_Func_IUnityContainer_Type_string_object_IFactoryLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterFactory(Unity.IUnityContainer, System.Type, Func<IUnityContainer, object>, Unity.Lifetime.IFactoryLifetimeManager)")]
        public static AnalyticModel? RegisterFactory_IUnityContainer_Type_Func_IUnityContainer_object_IFactoryLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterFactory(Unity.IUnityContainer, System.Type, Func<IUnityContainer, System.Type, string, object>, Unity.Lifetime.IFactoryLifetimeManager)")]
        public static AnalyticModel? RegisterFactory_IUnityContainer_Type_Func_IUnityContainer_Type_string_object_IFactoryLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterFactory(Unity.IUnityContainer, System.Type, string, Func<IUnityContainer, object>, Unity.Lifetime.IFactoryLifetimeManager)")]
        public static AnalyticModel? RegisterFactory_IUnityContainer_Type_string_Func_IUnityContainer_object_IFactoryLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterFactory(Unity.IUnityContainer, System.Type, string, Func<IUnityContainer, System.Type, string, object>, Unity.Lifetime.IFactoryLifetimeManager)")]
        public static AnalyticModel? RegisterFactory_IUnityContainer_Type_string_Func_IUnityContainer_Type_string_object_IFactoryLifetimeManager(IOperation operation)
        {
            return null;
        }
    }
}
