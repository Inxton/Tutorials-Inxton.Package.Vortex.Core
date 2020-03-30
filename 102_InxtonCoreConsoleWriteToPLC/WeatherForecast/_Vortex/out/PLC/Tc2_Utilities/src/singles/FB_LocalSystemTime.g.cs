using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Tc2_Utilities
{
	
            /// <summary>
            /// This is an external type. No documentation available.
            /// </summary>
            /// <exclude />
	[IgnoreReflection()]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "FB_LocalSystemTime", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class FB_LocalSystemTime : Vortex.Connector.IVortexObject, IFB_LocalSystemTime, IShadowFB_LocalSystemTime, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return Tc2_UtilitiesTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerBool _bEnable;
		public Vortex.Connector.ValueTypes.OnlinerBool bEnable
		{
			get
			{
				return _bEnable;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IFB_LocalSystemTime.bEnable
		{
			get
			{
				return bEnable;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowFB_LocalSystemTime.bEnable
		{
			get
			{
				return bEnable;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _dwCycle;
		public Vortex.Connector.ValueTypes.OnlinerDWord dwCycle
		{
			get
			{
				return _dwCycle;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IFB_LocalSystemTime.dwCycle
		{
			get
			{
				return dwCycle;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowFB_LocalSystemTime.dwCycle
		{
			get
			{
				return dwCycle;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _dwOpt;
		public Vortex.Connector.ValueTypes.OnlinerDWord dwOpt
		{
			get
			{
				return _dwOpt;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IFB_LocalSystemTime.dwOpt
		{
			get
			{
				return dwOpt;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowFB_LocalSystemTime.dwOpt
		{
			get
			{
				return dwOpt;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTime _tTimeout;
		public Vortex.Connector.ValueTypes.OnlinerTime tTimeout
		{
			get
			{
				return _tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime IFB_LocalSystemTime.tTimeout
		{
			get
			{
				return tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowFB_LocalSystemTime.tTimeout
		{
			get
			{
				return tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _bValid;
		public Vortex.Connector.ValueTypes.OnlinerBool bValid
		{
			get
			{
				return _bValid;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IFB_LocalSystemTime.bValid
		{
			get
			{
				return bValid;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowFB_LocalSystemTime.bValid
		{
			get
			{
				return bValid;
			}
		}

		Tc2_Utilities.TIMESTRUCT _systemTime;
		internal Tc2_Utilities.TIMESTRUCT systemTime
		{
			get
			{
				return _systemTime;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _tzID;
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_TimeZoneID))]
		public Vortex.Connector.ValueTypes.OnlinerInt tzID
		{
			get
			{
				return _tzID;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_TimeZoneID))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IFB_LocalSystemTime.tzID
		{
			get
			{
				return tzID;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_TimeZoneID))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowFB_LocalSystemTime.tzID
		{
			get
			{
				return tzID;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerByte _state;
		public Vortex.Connector.ValueTypes.OnlinerByte state
		{
			get
			{
				return _state;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte IFB_LocalSystemTime.state
		{
			get
			{
				return state;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte IShadowFB_LocalSystemTime.state
		{
			get
			{
				return state;
			}
		}

		Tc2_Utilities.NT_GetTime _fbNT;
		internal Tc2_Utilities.NT_GetTime fbNT
		{
			get
			{
				return _fbNT;
			}
		}

		Tc2_Utilities.FB_GetTimeZoneInformation _fbTZ;
		internal Tc2_Utilities.FB_GetTimeZoneInformation fbTZ
		{
			get
			{
				return _fbTZ;
			}
		}

		Tc2_Utilities.NT_SetTimeToRTCTime _fbSET;
		internal Tc2_Utilities.NT_SetTimeToRTCTime fbSET
		{
			get
			{
				return _fbSET;
			}
		}

		Tc2_Utilities.RTC_EX2 _fbRTC;
		internal Tc2_Utilities.RTC_EX2 fbRTC
		{
			get
			{
				return _fbRTC;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _nSync;
		public Vortex.Connector.ValueTypes.OnlinerDWord nSync
		{
			get
			{
				return _nSync;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IFB_LocalSystemTime.nSync
		{
			get
			{
				return nSync;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowFB_LocalSystemTime.nSync
		{
			get
			{
				return nSync;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _bNotSup;
		public Vortex.Connector.ValueTypes.OnlinerBool bNotSup
		{
			get
			{
				return _bNotSup;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IFB_LocalSystemTime.bNotSup
		{
			get
			{
				return bNotSup;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowFB_LocalSystemTime.bNotSup
		{
			get
			{
				return bNotSup;
			}
		}

		public void LazyOnlineToShadow()
		{
			bEnable.Shadow = bEnable.LastValue;
			dwCycle.Shadow = dwCycle.LastValue;
			dwOpt.Shadow = dwOpt.LastValue;
			tTimeout.Shadow = tTimeout.LastValue;
			bValid.Shadow = bValid.LastValue;
			tzID.Shadow = tzID.LastValue;
			state.Shadow = state.LastValue;
			nSync.Shadow = nSync.LastValue;
			bNotSup.Shadow = bNotSup.LastValue;
		}

		public void LazyShadowToOnline()
		{
			bEnable.Cyclic = bEnable.Shadow;
			dwCycle.Cyclic = dwCycle.Shadow;
			dwOpt.Cyclic = dwOpt.Shadow;
			tTimeout.Cyclic = tTimeout.Shadow;
			bValid.Cyclic = bValid.Shadow;
			tzID.Cyclic = tzID.Shadow;
			state.Cyclic = state.Shadow;
			nSync.Cyclic = nSync.Shadow;
			bNotSup.Cyclic = bNotSup.Shadow;
		}

		public PlainFB_LocalSystemTime CreatePlainerType()
		{
			var cloned = new PlainFB_LocalSystemTime();
			cloned.systemTime = systemTime.CreatePlainerType();
			cloned.fbNT = fbNT.CreatePlainerType();
			cloned.fbTZ = fbTZ.CreatePlainerType();
			cloned.fbSET = fbSET.CreatePlainerType();
			cloned.fbRTC = fbRTC.CreatePlainerType();
			return cloned;
		}

		protected PlainFB_LocalSystemTime CreatePlainerType(PlainFB_LocalSystemTime cloned)
		{
			cloned.systemTime = systemTime.CreatePlainerType();
			cloned.fbNT = fbNT.CreatePlainerType();
			cloned.fbTZ = fbTZ.CreatePlainerType();
			cloned.fbSET = fbSET.CreatePlainerType();
			cloned.fbRTC = fbRTC.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Tc2_Utilities.PlainFB_LocalSystemTime source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainFB_LocalSystemTime source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Tc2_Utilities.PlainFB_LocalSystemTime source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return Tc2_UtilitiesTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public FB_LocalSystemTime(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_bEnable = @Connector.Online.Adapter.CreateBOOL(this, "", "bEnable");
			_dwCycle = @Connector.Online.Adapter.CreateDWORD(this, "", "dwCycle");
			_dwOpt = @Connector.Online.Adapter.CreateDWORD(this, "", "dwOpt");
			_tTimeout = @Connector.Online.Adapter.CreateTIME(this, "", "tTimeout");
			_bValid = @Connector.Online.Adapter.CreateBOOL(this, "", "bValid");
			_systemTime = new Tc2_Utilities.TIMESTRUCT(this, "", "systemTime");
			_tzID = @Connector.Online.Adapter.CreateINT(this, "", "tzID");
			_state = @Connector.Online.Adapter.CreateBYTE(this, "", "state");
			_fbNT = new Tc2_Utilities.NT_GetTime(this, "", "fbNT");
			_fbTZ = new Tc2_Utilities.FB_GetTimeZoneInformation(this, "", "fbTZ");
			_fbSET = new Tc2_Utilities.NT_SetTimeToRTCTime(this, "", "fbSET");
			_fbRTC = new Tc2_Utilities.RTC_EX2(this, "", "fbRTC");
			_nSync = @Connector.Online.Adapter.CreateDWORD(this, "", "nSync");
			_bNotSup = @Connector.Online.Adapter.CreateBOOL(this, "", "bNotSup");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public FB_LocalSystemTime()
		{
			PexPreConstructorParameterless();
			_bEnable = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_dwCycle = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_dwOpt = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_tTimeout = Vortex.Connector.IConnectorFactory.CreateTIME();
			_bValid = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_systemTime = new Tc2_Utilities.TIMESTRUCT();
			_tzID = Vortex.Connector.IConnectorFactory.CreateINT();
			_state = Vortex.Connector.IConnectorFactory.CreateBYTE();
			_fbNT = new Tc2_Utilities.NT_GetTime();
			_fbTZ = new Tc2_Utilities.FB_GetTimeZoneInformation();
			_fbSET = new Tc2_Utilities.NT_SetTimeToRTCTime();
			_fbRTC = new Tc2_Utilities.RTC_EX2();
			_nSync = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_bNotSup = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IFB_LocalSystemTime : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool bEnable
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord dwCycle
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord dwOpt
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime tTimeout
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool bValid
		{
			get;
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_TimeZoneID))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt tzID
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte state
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord nSync
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool bNotSup
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainFB_LocalSystemTime CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainFB_LocalSystemTime source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainFB_LocalSystemTime source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowFB_LocalSystemTime : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool bEnable
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord dwCycle
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord dwOpt
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime tTimeout
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool bValid
		{
			get;
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_TimeZoneID))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt tzID
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte state
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord nSync
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool bNotSup
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainFB_LocalSystemTime CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainFB_LocalSystemTime source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainFB_LocalSystemTime : Vortex.Connector.IPlain
	{
		System.Boolean _bEnable;
		public System.Boolean bEnable
		{
			get
			{
				return _bEnable;
			}

			set
			{
				_bEnable = value;
			}
		}

		System.UInt32 _dwCycle;
		public System.UInt32 dwCycle
		{
			get
			{
				return _dwCycle;
			}

			set
			{
				_dwCycle = value;
			}
		}

		System.UInt32 _dwOpt;
		public System.UInt32 dwOpt
		{
			get
			{
				return _dwOpt;
			}

			set
			{
				_dwOpt = value;
			}
		}

		System.TimeSpan _tTimeout;
		public System.TimeSpan tTimeout
		{
			get
			{
				return _tTimeout;
			}

			set
			{
				_tTimeout = value;
			}
		}

		System.Boolean _bValid;
		public System.Boolean bValid
		{
			get
			{
				return _bValid;
			}

			set
			{
				_bValid = value;
			}
		}

		Tc2_Utilities.PlainTIMESTRUCT _systemTime;
		internal Tc2_Utilities.PlainTIMESTRUCT systemTime
		{
			get
			{
				return _systemTime;
			}

			set
			{
				_systemTime = value;
			}
		}

		System.Int16 _tzID;
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_TimeZoneID))]
		public System.Int16 tzID
		{
			get
			{
				return _tzID;
			}

			set
			{
				_tzID = value;
			}
		}

		System.Byte _state;
		public System.Byte state
		{
			get
			{
				return _state;
			}

			set
			{
				_state = value;
			}
		}

		Tc2_Utilities.PlainNT_GetTime _fbNT;
		internal Tc2_Utilities.PlainNT_GetTime fbNT
		{
			get
			{
				return _fbNT;
			}

			set
			{
				_fbNT = value;
			}
		}

		Tc2_Utilities.PlainFB_GetTimeZoneInformation _fbTZ;
		internal Tc2_Utilities.PlainFB_GetTimeZoneInformation fbTZ
		{
			get
			{
				return _fbTZ;
			}

			set
			{
				_fbTZ = value;
			}
		}

		Tc2_Utilities.PlainNT_SetTimeToRTCTime _fbSET;
		internal Tc2_Utilities.PlainNT_SetTimeToRTCTime fbSET
		{
			get
			{
				return _fbSET;
			}

			set
			{
				_fbSET = value;
			}
		}

		Tc2_Utilities.PlainRTC_EX2 _fbRTC;
		internal Tc2_Utilities.PlainRTC_EX2 fbRTC
		{
			get
			{
				return _fbRTC;
			}

			set
			{
				_fbRTC = value;
			}
		}

		System.UInt32 _nSync;
		public System.UInt32 nSync
		{
			get
			{
				return _nSync;
			}

			set
			{
				_nSync = value;
			}
		}

		System.Boolean _bNotSup;
		public System.Boolean bNotSup
		{
			get
			{
				return _bNotSup;
			}

			set
			{
				_bNotSup = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.FB_LocalSystemTime target)
		{
			target.bEnable.Cyclic = bEnable;
			target.dwCycle.Cyclic = dwCycle;
			target.dwOpt.Cyclic = dwOpt;
			target.tTimeout.Cyclic = tTimeout;
			target.bValid.Cyclic = bValid;
			systemTime.CopyPlainToCyclic(target.systemTime);
			target.tzID.Cyclic = tzID;
			target.state.Cyclic = state;
			fbNT.CopyPlainToCyclic(target.fbNT);
			fbTZ.CopyPlainToCyclic(target.fbTZ);
			fbSET.CopyPlainToCyclic(target.fbSET);
			fbRTC.CopyPlainToCyclic(target.fbRTC);
			target.nSync.Cyclic = nSync;
			target.bNotSup.Cyclic = bNotSup;
		}

		public void CopyPlainToCyclic(Tc2_Utilities.IFB_LocalSystemTime target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.FB_LocalSystemTime)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.FB_LocalSystemTime target)
		{
			target.bEnable.Shadow = bEnable;
			target.dwCycle.Shadow = dwCycle;
			target.dwOpt.Shadow = dwOpt;
			target.tTimeout.Shadow = tTimeout;
			target.bValid.Shadow = bValid;
			systemTime.CopyPlainToShadow(target.systemTime);
			target.tzID.Shadow = tzID;
			target.state.Shadow = state;
			fbNT.CopyPlainToShadow(target.fbNT);
			fbTZ.CopyPlainToShadow(target.fbTZ);
			fbSET.CopyPlainToShadow(target.fbSET);
			fbRTC.CopyPlainToShadow(target.fbRTC);
			target.nSync.Shadow = nSync;
			target.bNotSup.Shadow = bNotSup;
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowFB_LocalSystemTime target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.FB_LocalSystemTime)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.FB_LocalSystemTime source)
		{
			bEnable = source.bEnable.LastValue;
			dwCycle = source.dwCycle.LastValue;
			dwOpt = source.dwOpt.LastValue;
			tTimeout = source.tTimeout.LastValue;
			bValid = source.bValid.LastValue;
			systemTime.CopyCyclicToPlain(source.systemTime);
			tzID = source.tzID.LastValue;
			state = source.state.LastValue;
			fbNT.CopyCyclicToPlain(source.fbNT);
			fbTZ.CopyCyclicToPlain(source.fbTZ);
			fbSET.CopyCyclicToPlain(source.fbSET);
			fbRTC.CopyCyclicToPlain(source.fbRTC);
			nSync = source.nSync.LastValue;
			bNotSup = source.bNotSup.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Utilities.IFB_LocalSystemTime source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.FB_LocalSystemTime)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.FB_LocalSystemTime source)
		{
			bEnable = source.bEnable.Shadow;
			dwCycle = source.dwCycle.Shadow;
			dwOpt = source.dwOpt.Shadow;
			tTimeout = source.tTimeout.Shadow;
			bValid = source.bValid.Shadow;
			systemTime.CopyShadowToPlain(source.systemTime);
			tzID = source.tzID.Shadow;
			state = source.state.Shadow;
			fbNT.CopyShadowToPlain(source.fbNT);
			fbTZ.CopyShadowToPlain(source.fbTZ);
			fbSET.CopyShadowToPlain(source.fbSET);
			fbRTC.CopyShadowToPlain(source.fbRTC);
			nSync = source.nSync.Shadow;
			bNotSup = source.bNotSup.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowFB_LocalSystemTime source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.FB_LocalSystemTime)source);
		}

		public PlainFB_LocalSystemTime()
		{
			_systemTime = new Tc2_Utilities.PlainTIMESTRUCT();
			_fbNT = new Tc2_Utilities.PlainNT_GetTime();
			_fbTZ = new Tc2_Utilities.PlainFB_GetTimeZoneInformation();
			_fbSET = new Tc2_Utilities.PlainNT_SetTimeToRTCTime();
			_fbRTC = new Tc2_Utilities.PlainRTC_EX2();
		}
	}
}