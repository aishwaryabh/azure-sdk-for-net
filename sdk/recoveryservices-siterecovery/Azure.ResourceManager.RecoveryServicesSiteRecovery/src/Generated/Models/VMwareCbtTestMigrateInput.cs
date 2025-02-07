// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt specific test migrate input. </summary>
    public partial class VMwareCbtTestMigrateInput : TestMigrateProviderSpecificInput
    {
        /// <summary> Initializes a new instance of VMwareCbtTestMigrateInput. </summary>
        /// <param name="recoveryPointId"> The recovery point Id. </param>
        /// <param name="networkId"> The test network Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> or <paramref name="networkId"/> is null. </exception>
        public VMwareCbtTestMigrateInput(string recoveryPointId, string networkId)
        {
            Argument.AssertNotNull(recoveryPointId, nameof(recoveryPointId));
            Argument.AssertNotNull(networkId, nameof(networkId));

            RecoveryPointId = recoveryPointId;
            NetworkId = networkId;
            VmNics = new ChangeTrackingList<VMwareCbtNicInput>();
            InstanceType = "VMwareCbt";
        }

        /// <summary> The recovery point Id. </summary>
        public string RecoveryPointId { get; }
        /// <summary> The test network Id. </summary>
        public string NetworkId { get; }
        /// <summary> The list of NIC details. </summary>
        public IList<VMwareCbtNicInput> VmNics { get; }
        /// <summary> A value indicating the inplace OS Upgrade version. </summary>
        public string OSUpgradeVersion { get; set; }
    }
}
