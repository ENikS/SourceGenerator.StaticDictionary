using Microsoft.CodeAnalysis;

namespace Unity.Precompiler.Analysis
{
    public static partial class RegisterMethodParsers
    {
        [Parser(OperationKind.Invocation, 
            "Unity.UnityContainerExtensions.RegisterType<T>(Unity.IUnityContainer, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_T_IUnityContainer_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, 
            "Unity.UnityContainerExtensions.RegisterType<T>(Unity.IUnityContainer, Unity.Lifetime.ITypeLifetimeManager, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_T_IUnityContainer_ITypeLifetimeManager_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, 
            "Unity.UnityContainerExtensions.RegisterType<T>(Unity.IUnityContainer, string, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_T_IUnityContainer_string_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, 
            "Unity.UnityContainerExtensions.RegisterType<T>(Unity.IUnityContainer, string, Unity.Lifetime.ITypeLifetimeManager, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_T_IUnityContainer_string_ITypeLifetimeManager_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, 
            "Unity.UnityContainerExtensions.RegisterType<TFrom, TTo>(Unity.IUnityContainer, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_TFrom_TTo_IUnityContainer_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, 
            "Unity.UnityContainerExtensions.RegisterType<TFrom, TTo>(Unity.IUnityContainer, Unity.Lifetime.ITypeLifetimeManager, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_TFrom_TTo_IUnityContainer_ITypeLifetimeManager_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, 
            "Unity.UnityContainerExtensions.RegisterType<TFrom, TTo>(Unity.IUnityContainer, string, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_TFrom_TTo_IUnityContainer_string_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, 
            "Unity.UnityContainerExtensions.RegisterType<TFrom, TTo>(Unity.IUnityContainer, string, Unity.Lifetime.ITypeLifetimeManager, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterType_TFrom_TTo_IUnityContainer_string_ITypeLifetimeManager_InjectionMember(IOperation operation)
        {
            return null;
        }
    }
}
