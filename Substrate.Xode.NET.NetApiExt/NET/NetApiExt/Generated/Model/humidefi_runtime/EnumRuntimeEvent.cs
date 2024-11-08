//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Xode.NET.NetApiExt.Generated.Model.humidefi_runtime
{
    
    
    /// <summary>
    /// >> RuntimeEvent
    /// </summary>
    public enum RuntimeEvent
    {
        
        /// <summary>
        /// >> System
        /// </summary>
        System = 0,
        
        /// <summary>
        /// >> ParachainSystem
        /// </summary>
        ParachainSystem = 1,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 10,
        
        /// <summary>
        /// >> TransactionPayment
        /// </summary>
        TransactionPayment = 11,
        
        /// <summary>
        /// >> CollatorSelection
        /// </summary>
        CollatorSelection = 21,
        
        /// <summary>
        /// >> Session
        /// </summary>
        Session = 22,
        
        /// <summary>
        /// >> XcmpQueue
        /// </summary>
        XcmpQueue = 30,
        
        /// <summary>
        /// >> PolkadotXcm
        /// </summary>
        PolkadotXcm = 31,
        
        /// <summary>
        /// >> CumulusXcm
        /// </summary>
        CumulusXcm = 32,
        
        /// <summary>
        /// >> DmpQueue
        /// </summary>
        DmpQueue = 33,
        
        /// <summary>
        /// >> TemplatePallet
        /// </summary>
        TemplatePallet = 40,
        
        /// <summary>
        /// >> Assets
        /// </summary>
        Assets = 50,
        
        /// <summary>
        /// >> Contracts
        /// </summary>
        Contracts = 60,
        
        /// <summary>
        /// >> Sudo
        /// </summary>
        Sudo = 65,
    }
    
    /// <summary>
    /// >> 20 - Variant[humidefi_runtime.RuntimeEvent]
    /// </summary>
    public sealed class EnumRuntimeEvent : BaseEnumRust<RuntimeEvent>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumRuntimeEvent()
        {
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumEvent>(RuntimeEvent.System);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.pallet.EnumEvent>(RuntimeEvent.ParachainSystem);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_balances.pallet.EnumEvent>(RuntimeEvent.Balances);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_transaction_payment.pallet.EnumEvent>(RuntimeEvent.TransactionPayment);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet.EnumEvent>(RuntimeEvent.CollatorSelection);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_session.pallet.EnumEvent>(RuntimeEvent.Session);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.pallet.EnumEvent>(RuntimeEvent.XcmpQueue);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumEvent>(RuntimeEvent.PolkadotXcm);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcm.pallet.EnumEvent>(RuntimeEvent.CumulusXcm);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.pallet.EnumEvent>(RuntimeEvent.DmpQueue);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_parachain_template.pallet.EnumEvent>(RuntimeEvent.TemplatePallet);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_assets.pallet.EnumEvent>(RuntimeEvent.Assets);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_contracts.pallet.EnumEvent>(RuntimeEvent.Contracts);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_sudo.pallet.EnumEvent>(RuntimeEvent.Sudo);
        }
    }
}
