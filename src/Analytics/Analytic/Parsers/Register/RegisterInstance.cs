using Microsoft.CodeAnalysis;

namespace Unity.Precompiler.Analysis
{
    public static partial class RegisterMethodParsers
    {
        [Parser(OperationKind.Invocation,
            "Unity.IUnityContainer.RegisterInstance(System.Type, string, object, Unity.Lifetime.IInstanceLifetimeManager)")]
        public static AnalyticModel? RegisterInstance_Type_string_object_IInstanceLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterInstance<TInterface>(Unity.IUnityContainer, TInterface)")]
        public static AnalyticModel? RegisterInstance_TInterface_IUnityContainer_TInterface(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterInstance<TInterface>(Unity.IUnityContainer, TInterface, Unity.Lifetime.IInstanceLifetimeManager)")]
        public static AnalyticModel? RegisterInstance_TInterface_IUnityContainer_TInterface_IInstanceLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterInstance<TInterface>(Unity.IUnityContainer, string, TInterface)")]
        public static AnalyticModel? RegisterInstance_TInterface_IUnityContainer_string_TInterface(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterInstance<TInterface>(Unity.IUnityContainer, string, TInterface, Unity.Lifetime.IInstanceLifetimeManager)")]
        public static AnalyticModel? RegisterInstance_TInterface_IUnityContainer_string_TInterface_IInstanceLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterInstance(Unity.IUnityContainer, System.Type, object)")]
        public static AnalyticModel? RegisterInstance_IUnityContainer_Type_object(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterInstance(Unity.IUnityContainer, System.Type, object, Unity.Lifetime.IInstanceLifetimeManager)")]
        public static AnalyticModel? RegisterInstance_IUnityContainer_Type_object_IInstanceLifetimeManager(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterInstance(Unity.IUnityContainer, System.Type, string, object)")]
        public static AnalyticModel? RegisterInstance_IUnityContainer_Type_string_object(IOperation operation)
        {
            return null;
        }
    }
}
