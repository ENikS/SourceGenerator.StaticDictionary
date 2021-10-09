using Microsoft.CodeAnalysis;

namespace Unity.Precompiler.Analysis
{
    public static partial class RegisterMethodParsers
    {
        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterSingleton<T>(Unity.IUnityContainer, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterSingleton_T_IUnityContainer_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterSingleton<T>(Unity.IUnityContainer, string, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterSingleton_T_IUnityContainer_string_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterSingleton<TFrom, TTo>(Unity.IUnityContainer, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterSingleton_TFrom_TTo_IUnityContainer_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterSingleton<TFrom, TTo>(Unity.IUnityContainer, string, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterSingleton_TFrom_TTo_IUnityContainer_string_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterSingleton(Unity.IUnityContainer, System.Type, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterSingleton_IUnityContainer_Type_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterSingleton(Unity.IUnityContainer, System.Type, string, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterSingleton_IUnityContainer_Type_string_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterSingleton(Unity.IUnityContainer, System.Type, System.Type, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterSingleton_IUnityContainer_Type_Type_InjectionMember(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation,
            "Unity.UnityContainerExtensions.RegisterSingleton(Unity.IUnityContainer, System.Type, System.Type, string, params Unity.Injection.InjectionMember[])")]
        public static AnalyticModel? RegisterSingleton_IUnityContainer_Type_Type_string_InjectionMember(IOperation operation)
        {
            return null;
        }

    }
}

