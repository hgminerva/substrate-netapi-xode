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


namespace Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> NewInvulnerables
        /// </summary>
        NewInvulnerables = 0,
        
        /// <summary>
        /// >> NewDesiredCandidates
        /// </summary>
        NewDesiredCandidates = 1,
        
        /// <summary>
        /// >> NewCandidacyBond
        /// </summary>
        NewCandidacyBond = 2,
        
        /// <summary>
        /// >> CandidateAdded
        /// </summary>
        CandidateAdded = 3,
        
        /// <summary>
        /// >> CandidateRemoved
        /// </summary>
        CandidateRemoved = 4,
    }
    
    /// <summary>
    /// >> 35 - Variant[pallet_collator_selection.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.NewInvulnerables);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.NewDesiredCandidates);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Event.NewCandidacyBond);
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.CandidateAdded);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(Event.CandidateRemoved);
        }
    }
}
