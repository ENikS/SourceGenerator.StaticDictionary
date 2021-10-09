using Microsoft.CodeAnalysis;

namespace Unity.Precompiler.Analysis
{
    public static class ResolveMethodParsers
    {
        [Parser(OperationKind.Invocation, "Unity.UnityContainerExtensions.Resolve<T>(Unity.IUnityContainer, params Unity.Resolution.ResolverOverride[])")]
        public static AnalyticModel? Resolve_T_IUnityContainer_ResolverOverride(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, "Unity.UnityContainerExtensions.Resolve<T>(Unity.IUnityContainer, string, params Unity.Resolution.ResolverOverride[])")]
        public static AnalyticModel? Resolve_T_IUnityContainer_string_ResolverOverride(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, "Unity.UnityContainerExtensions.Resolve(Unity.IUnityContainer, System.Type, params Unity.Resolution.ResolverOverride[])")]
        public static AnalyticModel? Resolve_IUnityContainer_Type_ResolverOverride(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, "Unity.UnityContainerExtensions.ResolveAll(Unity.IUnityContainer, System.Type, params Unity.Resolution.ResolverOverride[])")]
        public static AnalyticModel? ResolveAll_IUnityContainer_Type_ResolverOverride(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, "Unity.UnityContainerExtensions.ResolveAll<T>(Unity.IUnityContainer, params Unity.Resolution.ResolverOverride[])")]
        public static AnalyticModel? ResolveAll_T_IUnityContainer_ResolverOverride(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, "Unity.UnityContainerExtensions.BuildUp<T>(Unity.IUnityContainer, T, params Unity.Resolution.ResolverOverride[])")]
        public static AnalyticModel? BuildUp_T_IUnityContainer_T_ResolverOverride(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, "Unity.UnityContainerExtensions.BuildUp<T>(Unity.IUnityContainer, T, string, params Unity.Resolution.ResolverOverride[])")]
        public static AnalyticModel? BuildUp_T_IUnityContainer_T_string_ResolverOverride(IOperation operation)
        {
            return null;
        }

        [Parser(OperationKind.Invocation, "Unity.UnityContainerExtensions.BuildUp(Unity.IUnityContainer, System.Type, object, params Unity.Resolution.ResolverOverride[])")]
        public static AnalyticModel? BuildUp_IUnityContainer_Type_object_ResolverOverride(IOperation operation)
        {
            return null;
        }
    }
}
