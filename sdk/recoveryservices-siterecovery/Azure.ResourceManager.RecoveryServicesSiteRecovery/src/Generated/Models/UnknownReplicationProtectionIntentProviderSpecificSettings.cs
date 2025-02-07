// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownReplicationProtectionIntentProviderSpecificSettings. </summary>
    internal partial class UnknownReplicationProtectionIntentProviderSpecificSettings : ReplicationProtectionIntentProviderSpecificSettings
    {
        /// <summary> Initializes a new instance of UnknownReplicationProtectionIntentProviderSpecificSettings. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        internal UnknownReplicationProtectionIntentProviderSpecificSettings(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}
