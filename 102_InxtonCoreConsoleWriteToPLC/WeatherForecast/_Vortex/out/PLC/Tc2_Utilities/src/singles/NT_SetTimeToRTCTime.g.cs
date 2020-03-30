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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "NT_SetTimeToRTCTime", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class NT_SetTimeToRTCTime : Vortex.Connector.IVortexObject, INT_SetTimeToRTCTime, IShadowNT_SetTimeToRTCTime, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _SET;
		public Vortex.Connector.ValueTypes.OnlinerBool SET
		{
			get
			{
				return _SET;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool INT_SetTimeToRTCTime.SET
		{
			get
			{
				return SET;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowNT_SetTimeToRTCTime.SET
		{
			get
			{
				return SET;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTime _TMOUT;
		public Vortex.Connector.ValueTypes.OnlinerTime TMOUT
		{
			get
			{
				return _TMOUT;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime INT_SetTimeToRTCTime.TMOUT
		{
			get
			{
				return TMOUT;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowNT_SetTimeToRTCTime.TMOUT
		{
			get
			{
				return TMOUT;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _BUSY;
		public Vortex.Connector.ValueTypes.OnlinerBool BUSY
		{
			get
			{
				return _BUSY;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool INT_SetTimeToRTCTime.BUSY
		{
			get
			{
				return BUSY;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowNT_SetTimeToRTCTime.BUSY
		{
			get
			{
				return BUSY;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _ERR;
		public Vortex.Connector.ValueTypes.OnlinerBool ERR
		{
			get
			{
				return _ERR;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool INT_SetTimeToRTCTime.ERR
		{
			get
			{
				return ERR;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowNT_SetTimeToRTCTime.ERR
		{
			get
			{
				return ERR;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _ERRID;
		public Vortex.Connector.ValueTypes.OnlinerUDInt ERRID
		{
			get
			{
				return _ERRID;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt INT_SetTimeToRTCTime.ERRID
		{
			get
			{
				return ERRID;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowNT_SetTimeToRTCTime.ERRID
		{
			get
			{
				return ERRID;
			}
		}

		Tc2_Utilities.FB_RegQueryValue _fbRegQuery;
		internal Tc2_Utilities.FB_RegQueryValue fbRegQuery
		{
			get
			{
				return _fbRegQuery;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _bTmp;
		public Vortex.Connector.ValueTypes.OnlinerDWord bTmp
		{
			get
			{
				return _bTmp;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord INT_SetTimeToRTCTime.bTmp
		{
			get
			{
				return bTmp;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowNT_SetTimeToRTCTime.bTmp
		{
			get
			{
				return bTmp;
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

		Vortex.Connector.ValueTypes.Online.IOnlineByte INT_SetTimeToRTCTime.state
		{
			get
			{
				return state;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte IShadowNT_SetTimeToRTCTime.state
		{
			get
			{
				return state;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _bInit;
		public Vortex.Connector.ValueTypes.OnlinerBool bInit
		{
			get
			{
				return _bInit;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool INT_SetTimeToRTCTime.bInit
		{
			get
			{
				return bInit;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowNT_SetTimeToRTCTime.bInit
		{
			get
			{
				return bInit;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _numOfCPUs;
		public Vortex.Connector.ValueTypes.OnlinerDWord numOfCPUs
		{
			get
			{
				return _numOfCPUs;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord INT_SetTimeToRTCTime.numOfCPUs
		{
			get
			{
				return numOfCPUs;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowNT_SetTimeToRTCTime.numOfCPUs
		{
			get
			{
				return numOfCPUs;
			}
		}

		public void LazyOnlineToShadow()
		{
			SET.Shadow = SET.LastValue;
			TMOUT.Shadow = TMOUT.LastValue;
			BUSY.Shadow = BUSY.LastValue;
			ERR.Shadow = ERR.LastValue;
			ERRID.Shadow = ERRID.LastValue;
			bTmp.Shadow = bTmp.LastValue;
			state.Shadow = state.LastValue;
			bInit.Shadow = bInit.LastValue;
			numOfCPUs.Shadow = numOfCPUs.LastValue;
		}

		public void LazyShadowToOnline()
		{
			SET.Cyclic = SET.Shadow;
			TMOUT.Cyclic = TMOUT.Shadow;
			BUSY.Cyclic = BUSY.Shadow;
			ERR.Cyclic = ERR.Shadow;
			ERRID.Cyclic = ERRID.Shadow;
			bTmp.Cyclic = bTmp.Shadow;
			state.Cyclic = state.Shadow;
			bInit.Cyclic = bInit.Shadow;
			numOfCPUs.Cyclic = numOfCPUs.Shadow;
		}

		public PlainNT_SetTimeToRTCTime CreatePlainerType()
		{
			var cloned = new PlainNT_SetTimeToRTCTime();
			cloned.fbRegQuery = fbRegQuery.CreatePlainerType();
			return cloned;
		}

		protected PlainNT_SetTimeToRTCTime CreatePlainerType(PlainNT_SetTimeToRTCTime cloned)
		{
			cloned.fbRegQuery = fbRegQuery.CreatePlainerType();
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainNT_SetTimeToRTCTime source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainNT_SetTimeToRTCTime source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainNT_SetTimeToRTCTime source)
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

		public NT_SetTimeToRTCTime(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_SET = @Connector.Online.Adapter.CreateBOOL(this, "", "SET");
			_TMOUT = @Connector.Online.Adapter.CreateTIME(this, "", "TMOUT");
			_BUSY = @Connector.Online.Adapter.CreateBOOL(this, "", "BUSY");
			_ERR = @Connector.Online.Adapter.CreateBOOL(this, "", "ERR");
			_ERRID = @Connector.Online.Adapter.CreateUDINT(this, "", "ERRID");
			_fbRegQuery = new Tc2_Utilities.FB_RegQueryValue(this, "", "fbRegQuery");
			_bTmp = @Connector.Online.Adapter.CreateDWORD(this, "", "bTmp");
			_state = @Connector.Online.Adapter.CreateBYTE(this, "", "state");
			_bInit = @Connector.Online.Adapter.CreateBOOL(this, "", "bInit");
			_numOfCPUs = @Connector.Online.Adapter.CreateDWORD(this, "", "numOfCPUs");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public NT_SetTimeToRTCTime()
		{
			PexPreConstructorParameterless();
			_SET = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_TMOUT = Vortex.Connector.IConnectorFactory.CreateTIME();
			_BUSY = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_ERR = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_ERRID = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_fbRegQuery = new Tc2_Utilities.FB_RegQueryValue();
			_bTmp = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_state = Vortex.Connector.IConnectorFactory.CreateBYTE();
			_bInit = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_numOfCPUs = Vortex.Connector.IConnectorFactory.CreateDWORD();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface INT_SetTimeToRTCTime : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool SET
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime TMOUT
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool BUSY
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ERR
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt ERRID
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord bTmp
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte state
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool bInit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord numOfCPUs
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainNT_SetTimeToRTCTime CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainNT_SetTimeToRTCTime source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainNT_SetTimeToRTCTime source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowNT_SetTimeToRTCTime : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool SET
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime TMOUT
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool BUSY
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool ERR
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt ERRID
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord bTmp
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte state
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool bInit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord numOfCPUs
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainNT_SetTimeToRTCTime CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainNT_SetTimeToRTCTime source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainNT_SetTimeToRTCTime : Vortex.Connector.IPlain
	{
		System.Boolean _SET;
		public System.Boolean SET
		{
			get
			{
				return _SET;
			}

			set
			{
				_SET = value;
			}
		}

		System.TimeSpan _TMOUT;
		public System.TimeSpan TMOUT
		{
			get
			{
				return _TMOUT;
			}

			set
			{
				_TMOUT = value;
			}
		}

		System.Boolean _BUSY;
		public System.Boolean BUSY
		{
			get
			{
				return _BUSY;
			}

			set
			{
				_BUSY = value;
			}
		}

		System.Boolean _ERR;
		public System.Boolean ERR
		{
			get
			{
				return _ERR;
			}

			set
			{
				_ERR = value;
			}
		}

		System.UInt32 _ERRID;
		public System.UInt32 ERRID
		{
			get
			{
				return _ERRID;
			}

			set
			{
				_ERRID = value;
			}
		}

		Tc2_Utilities.PlainFB_RegQueryValue _fbRegQuery;
		internal Tc2_Utilities.PlainFB_RegQueryValue fbRegQuery
		{
			get
			{
				return _fbRegQuery;
			}

			set
			{
				_fbRegQuery = value;
			}
		}

		System.UInt32 _bTmp;
		public System.UInt32 bTmp
		{
			get
			{
				return _bTmp;
			}

			set
			{
				_bTmp = value;
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

		System.Boolean _bInit;
		public System.Boolean bInit
		{
			get
			{
				return _bInit;
			}

			set
			{
				_bInit = value;
			}
		}

		System.UInt32 _numOfCPUs;
		public System.UInt32 numOfCPUs
		{
			get
			{
				return _numOfCPUs;
			}

			set
			{
				_numOfCPUs = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.NT_SetTimeToRTCTime target)
		{
			target.SET.Cyclic = SET;
			target.TMOUT.Cyclic = TMOUT;
			target.BUSY.Cyclic = BUSY;
			target.ERR.Cyclic = ERR;
			target.ERRID.Cyclic = ERRID;
			fbRegQuery.CopyPlainToCyclic(target.fbRegQuery);
			target.bTmp.Cyclic = bTmp;
			target.state.Cyclic = state;
			target.bInit.Cyclic = bInit;
			target.numOfCPUs.Cyclic = numOfCPUs;
		}

		public void CopyPlainToCyclic(Tc2_Utilities.INT_SetTimeToRTCTime target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.NT_SetTimeToRTCTime)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.NT_SetTimeToRTCTime target)
		{
			target.SET.Shadow = SET;
			target.TMOUT.Shadow = TMOUT;
			target.BUSY.Shadow = BUSY;
			target.ERR.Shadow = ERR;
			target.ERRID.Shadow = ERRID;
			fbRegQuery.CopyPlainToShadow(target.fbRegQuery);
			target.bTmp.Shadow = bTmp;
			target.state.Shadow = state;
			target.bInit.Shadow = bInit;
			target.numOfCPUs.Shadow = numOfCPUs;
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowNT_SetTimeToRTCTime target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.NT_SetTimeToRTCTime)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.NT_SetTimeToRTCTime source)
		{
			SET = source.SET.LastValue;
			TMOUT = source.TMOUT.LastValue;
			BUSY = source.BUSY.LastValue;
			ERR = source.ERR.LastValue;
			ERRID = source.ERRID.LastValue;
			fbRegQuery.CopyCyclicToPlain(source.fbRegQuery);
			bTmp = source.bTmp.LastValue;
			state = source.state.LastValue;
			bInit = source.bInit.LastValue;
			numOfCPUs = source.numOfCPUs.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Utilities.INT_SetTimeToRTCTime source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.NT_SetTimeToRTCTime)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.NT_SetTimeToRTCTime source)
		{
			SET = source.SET.Shadow;
			TMOUT = source.TMOUT.Shadow;
			BUSY = source.BUSY.Shadow;
			ERR = source.ERR.Shadow;
			ERRID = source.ERRID.Shadow;
			fbRegQuery.CopyShadowToPlain(source.fbRegQuery);
			bTmp = source.bTmp.Shadow;
			state = source.state.Shadow;
			bInit = source.bInit.Shadow;
			numOfCPUs = source.numOfCPUs.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowNT_SetTimeToRTCTime source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.NT_SetTimeToRTCTime)source);
		}

		public PlainNT_SetTimeToRTCTime()
		{
			_fbRegQuery = new Tc2_Utilities.PlainFB_RegQueryValue();
		}
	}
}