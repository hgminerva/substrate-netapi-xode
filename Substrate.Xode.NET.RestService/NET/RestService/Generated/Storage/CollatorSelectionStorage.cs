//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Xode.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ICollatorSelectionStorage interface definition.
    /// </summary>
    public interface ICollatorSelectionStorage : IStorage
    {
        
        /// <summary>
        /// >> Invulnerables
        ///  The invulnerable, fixed collators.
        /// </summary>
        Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6 GetInvulnerables();
        
        /// <summary>
        /// >> Candidates
        ///  The (community, limited) collation candidates.
        /// </summary>
        Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7 GetCandidates();
        
        /// <summary>
        /// >> LastAuthoredBlock
        ///  Last block authored by collator.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetLastAuthoredBlock(string key);
        
        /// <summary>
        /// >> DesiredCandidates
        ///  Desired number of candidates.
        /// 
        ///  This should ideally always be less than [`Config::MaxCandidates`] for weights to be correct.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetDesiredCandidates();
        
        /// <summary>
        /// >> CandidacyBond
        ///  Fixed amount to deposit to become a collator.
        /// 
        ///  When a collator calls `leave_intent` they immediately receive the deposit back.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetCandidacyBond();
    }
    
    /// <summary>
    /// CollatorSelectionStorage class definition.
    /// </summary>
    public sealed class CollatorSelectionStorage : ICollatorSelectionStorage
    {
        
        /// <summary>
        /// _invulnerablesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6> _invulnerablesTypedStorage;
        
        /// <summary>
        /// _candidatesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7> _candidatesTypedStorage;
        
        /// <summary>
        /// _lastAuthoredBlockTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _lastAuthoredBlockTypedStorage;
        
        /// <summary>
        /// _desiredCandidatesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _desiredCandidatesTypedStorage;
        
        /// <summary>
        /// _candidacyBondTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _candidacyBondTypedStorage;
        
        /// <summary>
        /// CollatorSelectionStorage constructor.
        /// </summary>
        public CollatorSelectionStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.InvulnerablesTypedStorage = new TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6>("CollatorSelection.Invulnerables", storageDataProvider, storageChangeDelegates);
            this.CandidatesTypedStorage = new TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>("CollatorSelection.Candidates", storageDataProvider, storageChangeDelegates);
            this.LastAuthoredBlockTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("CollatorSelection.LastAuthoredBlock", storageDataProvider, storageChangeDelegates);
            this.DesiredCandidatesTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("CollatorSelection.DesiredCandidates", storageDataProvider, storageChangeDelegates);
            this.CandidacyBondTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("CollatorSelection.CandidacyBond", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _invulnerablesTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6> InvulnerablesTypedStorage
        {
            get
            {
                return _invulnerablesTypedStorage;
            }
            set
            {
                _invulnerablesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _candidatesTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7> CandidatesTypedStorage
        {
            get
            {
                return _candidatesTypedStorage;
            }
            set
            {
                _candidatesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lastAuthoredBlockTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> LastAuthoredBlockTypedStorage
        {
            get
            {
                return _lastAuthoredBlockTypedStorage;
            }
            set
            {
                _lastAuthoredBlockTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _desiredCandidatesTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> DesiredCandidatesTypedStorage
        {
            get
            {
                return _desiredCandidatesTypedStorage;
            }
            set
            {
                _desiredCandidatesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _candidacyBondTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> CandidacyBondTypedStorage
        {
            get
            {
                return _candidacyBondTypedStorage;
            }
            set
            {
                _candidacyBondTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await InvulnerablesTypedStorage.InitializeAsync("CollatorSelection", "Invulnerables");
            await CandidatesTypedStorage.InitializeAsync("CollatorSelection", "Candidates");
            await LastAuthoredBlockTypedStorage.InitializeAsync("CollatorSelection", "LastAuthoredBlock");
            await DesiredCandidatesTypedStorage.InitializeAsync("CollatorSelection", "DesiredCandidates");
            await CandidacyBondTypedStorage.InitializeAsync("CollatorSelection", "CandidacyBond");
        }
        
        /// <summary>
        /// Implements any storage change for CollatorSelection.Invulnerables
        /// </summary>
        [StorageChange("CollatorSelection", "Invulnerables")]
        public void OnUpdateInvulnerables(string data)
        {
            InvulnerablesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Invulnerables
        ///  The invulnerable, fixed collators.
        /// </summary>
        public Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6 GetInvulnerables()
        {
            return InvulnerablesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CollatorSelection.Candidates
        /// </summary>
        [StorageChange("CollatorSelection", "Candidates")]
        public void OnUpdateCandidates(string data)
        {
            CandidatesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Candidates
        ///  The (community, limited) collation candidates.
        /// </summary>
        public Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7 GetCandidates()
        {
            return CandidatesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CollatorSelection.LastAuthoredBlock
        /// </summary>
        [StorageChange("CollatorSelection", "LastAuthoredBlock")]
        public void OnUpdateLastAuthoredBlock(string key, string data)
        {
            LastAuthoredBlockTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> LastAuthoredBlock
        ///  Last block authored by collator.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetLastAuthoredBlock(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (LastAuthoredBlockTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for CollatorSelection.DesiredCandidates
        /// </summary>
        [StorageChange("CollatorSelection", "DesiredCandidates")]
        public void OnUpdateDesiredCandidates(string data)
        {
            DesiredCandidatesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> DesiredCandidates
        ///  Desired number of candidates.
        /// 
        ///  This should ideally always be less than [`Config::MaxCandidates`] for weights to be correct.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetDesiredCandidates()
        {
            return DesiredCandidatesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CollatorSelection.CandidacyBond
        /// </summary>
        [StorageChange("CollatorSelection", "CandidacyBond")]
        public void OnUpdateCandidacyBond(string data)
        {
            CandidacyBondTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CandidacyBond
        ///  Fixed amount to deposit to become a collator.
        /// 
        ///  When a collator calls `leave_intent` they immediately receive the deposit back.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetCandidacyBond()
        {
            return CandidacyBondTypedStorage.Get();
        }
    }
}
