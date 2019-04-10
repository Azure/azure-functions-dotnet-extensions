//// Copyright (c) .NET Foundation. All rights reserved.
//// Licensed under the MIT License. See License.txt in the project root for license information.

//using System;
//using System.Reflection;
//using System.Threading.Tasks;
//using Microsoft.Azure.WebJobs.Host.Bindings;
//using Microsoft.Azure.WebJobs.Host.Config;
//using Microsoft.Azure.WebJobs.Host.Protocols;

//namespace Microsoft.Azure.Functions.Extensions.DependencyInjection.Binding
//{
//    internal class FromServicesExtensionConfigProvider : IExtensionConfigProvider
//    {
//        public FromServicesExtensionConfigProvider()
//        {

//        }

//        public void Initialize(ExtensionConfigContext context)
//        {
//            if (context == null)
//            {
//                throw new ArgumentNullException(nameof(context));
//            }

//            context.AddBindingRule<FromServicesAttribute>()
//                .Bind(new FromServicesBindingProvider());

//        }
//    }

//    internal class FromServicesBindingProvider : IBindingProvider
//    {
//        public Task<IBinding> TryCreateAsync(BindingProviderContext context)
//        {
//            if (context == null)
//            {
//                throw new ArgumentNullException(nameof(context));
//            }

//            FromServicesAttribute attribute = context.Parameter.GetCustomAttribute<FromServicesAttribute>(inherit: false);

//            if (attribute == null)
//            {
//                return null;
//            }

//            return Task.FromResult<IBinding>(new ServiceBinding(context.Parameter));
//        }

//        public class ServiceBinding : IBinding
//        {
//            private readonly ParameterInfo _parameter;

//            public ServiceBinding(ParameterInfo parameter)
//            {
//                _parameter = parameter;
//            }

//            public bool FromAttribute => true;

//            public Task<IValueProvider> BindAsync(object value, ValueBindingContext context)
//            {
//                if (value != null)
//                {
//                    var binding = new ServiceValueProvider(_parameter.ParameterType, request, "request");
//                    return Task.FromResult<IValueProvider>(binding);
//                }
//                throw new InvalidOperationException("value must be an HttpRequest");
//            }

//            public Task<IValueProvider> BindAsync(BindingContext context)
//            {
//                throw new NotImplementedException();
//            }

//            public ParameterDescriptor ToParameterDescriptor()
//            {
//                throw new NotImplementedException();
//            }
//        }

//        public class ServiceValueProvider : IValueProvider
//        {
//            private readonly Type _type;
//            private readonly IServiceProvider _serviceProvider;

//            public ServiceValueProvider(Type type, IServiceProvider serviceProvider)
//            {
//                _type = type ?? throw new ArgumentNullException(nameof(type));
//                _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
//            }

//            public Type Type => _type;

//            public Task<object> GetValueAsync()
//            {
//                _serviceProvider.GetService(_type);
//            }

//            public string ToInvokeString()
//            {
//                return $"Service type '{_type.FullName}'";
//            }
//        }
//    }
//}
