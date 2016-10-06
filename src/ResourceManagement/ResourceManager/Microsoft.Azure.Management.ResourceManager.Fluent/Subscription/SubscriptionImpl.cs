﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Resource.Fluent;
using Microsoft.Azure.Management.Resource.Fluent.Models;
using Microsoft.Azure.Management.Resource.Fluent.Core;
using System.Collections.Generic;
using System;

namespace Microsoft.Azure.Management.Resource.Fluent
{
    internal class SubscriptionImpl :
        IndexableWrapper<Management.Resource.Fluent.Models.SubscriptionInner>,
        ISubscription
    {
        private ISubscriptionsOperations innerCollection;

        internal SubscriptionImpl(Management.Resource.Fluent.Models.SubscriptionInner innerModel, ISubscriptionsOperations client) : base(innerModel)
        {
            innerCollection = client;
        }

        public string DisplayName
        {
            get
            {
                return Inner.DisplayName;
            }
        }

        public string State
        {
            get
            {
                return Inner.State;
            }
        }

        public string SubscriptionId
        {
            get
            {
                return Inner.SubscriptionId;
            }
        }

        public SubscriptionPolicies SubscriptionPolicies
        {
            get
            {
                return Inner.SubscriptionPolicies;
            }
        }

        public PagedList<ILocation> ListLocations()
        {
            IEnumerable<Location> firstPage = innerCollection.ListLocations(this.SubscriptionId);
            throw new NotImplementedException("GeneratedSDKIssue: Generated SDK is not using LocationInner");
            //return new PagedList<ILocation>(firstPage);
        }
    }
}