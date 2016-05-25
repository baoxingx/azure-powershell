// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Management.Internal.Resources.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.Management.Internal.Resources
{
    public static partial class FeaturesExtensions
    {
        /// <summary>
        /// Get all features under the subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <param name='featureName'>
        /// Required. Previewed feature name in the resource provider.
        /// </param>
        /// <returns>
        /// Previewed feature information.
        /// </returns>
        public static FeatureResponse Get(this IFeatures operations, string resourceProviderNamespace, string featureName)
        {
            return Task.Factory.StartNew((object s) =>
            {
                return ((IFeatures)s).GetAsync(resourceProviderNamespace, featureName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all features under the subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <param name='featureName'>
        /// Required. Previewed feature name in the resource provider.
        /// </param>
        /// <returns>
        /// Previewed feature information.
        /// </returns>
        public static Task<FeatureResponse> GetAsync(this IFeatures operations, string resourceProviderNamespace, string featureName)
        {
            return operations.GetAsync(resourceProviderNamespace, featureName, CancellationToken.None);
        }

        /// <summary>
        /// Gets a list of previewed features of a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. The namespace of the resource provider.
        /// </param>
        /// <returns>
        /// List of previewed features.
        /// </returns>
        public static FeatureOperationsListResult List(this IFeatures operations, string resourceProviderNamespace)
        {
            return Task.Factory.StartNew((object s) =>
            {
                return ((IFeatures)s).ListAsync(resourceProviderNamespace);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of previewed features of a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. The namespace of the resource provider.
        /// </param>
        /// <returns>
        /// List of previewed features.
        /// </returns>
        public static Task<FeatureOperationsListResult> ListAsync(this IFeatures operations, string resourceProviderNamespace)
        {
            return operations.ListAsync(resourceProviderNamespace, CancellationToken.None);
        }

        /// <summary>
        /// Gets a list of previewed features for all the providers in the
        /// current subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <returns>
        /// List of previewed features.
        /// </returns>
        public static FeatureOperationsListResult ListAll(this IFeatures operations)
        {
            return Task.Factory.StartNew((object s) =>
            {
                return ((IFeatures)s).ListAllAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of previewed features for all the providers in the
        /// current subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <returns>
        /// List of previewed features.
        /// </returns>
        public static Task<FeatureOperationsListResult> ListAllAsync(this IFeatures operations)
        {
            return operations.ListAllAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets a list of previewed features of a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of previewed features.
        /// </returns>
        public static FeatureOperationsListResult ListAllNext(this IFeatures operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) =>
            {
                return ((IFeatures)s).ListAllNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of previewed features of a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of previewed features.
        /// </returns>
        public static Task<FeatureOperationsListResult> ListAllNextAsync(this IFeatures operations, string nextLink)
        {
            return operations.ListAllNextAsync(nextLink, CancellationToken.None);
        }

        /// <summary>
        /// Gets a list of previewed features of a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of previewed features.
        /// </returns>
        public static FeatureOperationsListResult ListNext(this IFeatures operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) =>
            {
                return ((IFeatures)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of previewed features of a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of previewed features.
        /// </returns>
        public static Task<FeatureOperationsListResult> ListNextAsync(this IFeatures operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }

        /// <summary>
        /// Registers for a previewed feature of a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <param name='featureName'>
        /// Required. Previewed feature name in the resource provider.
        /// </param>
        /// <returns>
        /// Previewed feature information.
        /// </returns>
        public static FeatureResponse Register(this IFeatures operations, string resourceProviderNamespace, string featureName)
        {
            return Task.Factory.StartNew((object s) =>
            {
                return ((IFeatures)s).RegisterAsync(resourceProviderNamespace, featureName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Registers for a previewed feature of a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Internal.Resources.IFeatures.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <param name='featureName'>
        /// Required. Previewed feature name in the resource provider.
        /// </param>
        /// <returns>
        /// Previewed feature information.
        /// </returns>
        public static Task<FeatureResponse> RegisterAsync(this IFeatures operations, string resourceProviderNamespace, string featureName)
        {
            return operations.RegisterAsync(resourceProviderNamespace, featureName, CancellationToken.None);
        }
    }
}
