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

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AzureStack.Management;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management
{
    public static partial class PlanOperationsExtensions
    {
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.AzureStack.Management.IPlanOperations.
        /// </param>
        /// <param name='planId'>
        /// Required. Your documentation here.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static PlanGetResult Get(this IPlanOperations operations, string planId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPlanOperations)s).GetAsync(planId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.AzureStack.Management.IPlanOperations.
        /// </param>
        /// <param name='planId'>
        /// Required. Your documentation here.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static Task<PlanGetResult> GetAsync(this IPlanOperations operations, string planId)
        {
            return operations.GetAsync(planId, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the availability of the plan.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.AzureStack.Management.IPlanOperations.
        /// </param>
        /// <param name='planName'>
        /// Required. The plan name.
        /// </param>
        /// <returns>
        /// The plan availability result.
        /// </returns>
        public static PlanGetAvailabilityResult GetAvailability(this IPlanOperations operations, string planName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPlanOperations)s).GetAvailabilityAsync(planName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the availability of the plan.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.AzureStack.Management.IPlanOperations.
        /// </param>
        /// <param name='planName'>
        /// Required. The plan name.
        /// </param>
        /// <returns>
        /// The plan availability result.
        /// </returns>
        public static Task<PlanGetAvailabilityResult> GetAvailabilityAsync(this IPlanOperations operations, string planName)
        {
            return operations.GetAvailabilityAsync(planName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the plan price.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.AzureStack.Management.IPlanOperations.
        /// </param>
        /// <param name='planName'>
        /// Required. the plan name
        /// </param>
        /// <returns>
        /// Plan get price result.
        /// </returns>
        public static PlanGetPriceResult GetPrice(this IPlanOperations operations, string planName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPlanOperations)s).GetPriceAsync(planName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the plan price.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.AzureStack.Management.IPlanOperations.
        /// </param>
        /// <param name='planName'>
        /// Required. the plan name
        /// </param>
        /// <returns>
        /// Plan get price result.
        /// </returns>
        public static Task<PlanGetPriceResult> GetPriceAsync(this IPlanOperations operations, string planName)
        {
            return operations.GetPriceAsync(planName, CancellationToken.None);
        }
        
        /// <summary>
        /// Add on plans available for that subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.AzureStack.Management.IPlanOperations.
        /// </param>
        /// <returns>
        /// Plan list result.
        /// </returns>
        public static PlanListResult List(this IPlanOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPlanOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Add on plans available for that subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.AzureStack.Management.IPlanOperations.
        /// </param>
        /// <returns>
        /// Plan list result.
        /// </returns>
        public static Task<PlanListResult> ListAsync(this IPlanOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}
