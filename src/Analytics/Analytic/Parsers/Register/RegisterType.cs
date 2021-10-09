using Microsoft.CodeAnalysis;

namespace Unity.Precompiler.Analysis
{
    public static partial class RegisterMethodParsers
    {
        [Parser(OperationKind.Invocation,
            "Unity.IUnityContainer.RegisterType(System.Type, System.Type, string, Unity.Lifetime.ITypeLifetimeManager, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_Type_Type_string_ITypeLifetimeManager_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterType(Unity.IUnityContainer, System.Type, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_IUnityContainer_Type_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterType(Unity.IUnityContainer, System.Type, Unity.Lifetime.ITypeLifetimeManager, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_IUnityContainer_Type_ITypeLifetimeManager_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterType(Unity.IUnityContainer, System.Type, string, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_IUnityContainer_Type_string_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterType(Unity.IUnityContainer, System.Type, string, Unity.Lifetime.ITypeLifetimeManager, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_IUnityContainer_Type_string_ITypeLifetimeManager_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterType(Unity.IUnityContainer, System.Type, System.Type, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_IUnityContainer_Type_Type_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterType(Unity.IUnityContainer, System.Type, System.Type, string, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_IUnityContainer_Type_Type_string_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterType(Unity.IUnityContainer, System.Type, System.Type, Unity.Lifetime.ITypeLifetimeManager, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_IUnityContainer_Type_Type_ITypeLifetimeManager_InjectionMember(IOperation operation)
        {
            return null;
        }
    }
}

