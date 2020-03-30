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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "RTC_EX2", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class RTC_EX2 : Vortex.Connector.IVortexObject, IRTC_EX2, IShadowRTC_EX2, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _EN;
		public Vortex.Connector.ValueTypes.OnlinerBool EN
		{
			get
			{
				return _EN;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IRTC_EX2.EN
		{
			get
			{
				return EN;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowRTC_EX2.EN
		{
			get
			{
				return EN;
			}
		}

		Tc2_Utilities.TIMESTRUCT _PDT;
		internal Tc2_Utilities.TIMESTRUCT PDT
		{
			get
			{
				return _PDT;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _PMICRO;
		public Vortex.Connector.ValueTypes.OnlinerDWord PMICRO
		{
			get
			{
				return _PMICRO;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IRTC_EX2.PMICRO
		{
			get
			{
				return PMICRO;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowRTC_EX2.PMICRO
		{
			get
			{
				return PMICRO;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Q;
		public Vortex.Connector.ValueTypes.OnlinerBool Q
		{
			get
			{
				return _Q;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IRTC_EX2.Q
		{
			get
			{
				return Q;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowRTC_EX2.Q
		{
			get
			{
				return Q;
			}
		}

		Tc2_Utilities.TIMESTRUCT _CDT;
		internal Tc2_Utilities.TIMESTRUCT CDT
		{
			get
			{
				return _CDT;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _CMICRO;
		public Vortex.Connector.ValueTypes.OnlinerDWord CMICRO
		{
			get
			{
				return _CMICRO;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IRTC_EX2.CMICRO
		{
			get
			{
				return CMICRO;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowRTC_EX2.CMICRO
		{
			get
			{
				return CMICRO;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _oldTick;
		public Vortex.Connector.ValueTypes.OnlinerDWord oldTick
		{
			get
			{
				return _oldTick;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IRTC_EX2.oldTick
		{
			get
			{
				return oldTick;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowRTC_EX2.oldTick
		{
			get
			{
				return oldTick;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _currTick;
		public Vortex.Connector.ValueTypes.OnlinerDWord currTick
		{
			get
			{
				return _currTick;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IRTC_EX2.currTick
		{
			get
			{
				return currTick;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowRTC_EX2.currTick
		{
			get
			{
				return currTick;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _nanoDiff;
		public Vortex.Connector.ValueTypes.OnlinerDWord nanoDiff
		{
			get
			{
				return _nanoDiff;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IRTC_EX2.nanoDiff
		{
			get
			{
				return nanoDiff;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowRTC_EX2.nanoDiff
		{
			get
			{
				return nanoDiff;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _nanoRest;
		public Vortex.Connector.ValueTypes.OnlinerDWord nanoRest
		{
			get
			{
				return _nanoRest;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IRTC_EX2.nanoRest
		{
			get
			{
				return nanoRest;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowRTC_EX2.nanoRest
		{
			get
			{
				return nanoRest;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _secDiff;
		public Vortex.Connector.ValueTypes.OnlinerDWord secDiff
		{
			get
			{
				return _secDiff;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IRTC_EX2.secDiff
		{
			get
			{
				return secDiff;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowRTC_EX2.secDiff
		{
			get
			{
				return secDiff;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDateTime _dateTime;
		public Vortex.Connector.ValueTypes.OnlinerDateTime dateTime
		{
			get
			{
				return _dateTime;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime IRTC_EX2.dateTime
		{
			get
			{
				return dateTime;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime IShadowRTC_EX2.dateTime
		{
			get
			{
				return dateTime;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _bInitialized;
		public Vortex.Connector.ValueTypes.OnlinerBool bInitialized
		{
			get
			{
				return _bInitialized;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IRTC_EX2.bInitialized
		{
			get
			{
				return bInitialized;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowRTC_EX2.bInitialized
		{
			get
			{
				return bInitialized;
			}
		}

		public void LazyOnlineToShadow()
		{
			EN.Shadow = EN.LastValue;
			PMICRO.Shadow = PMICRO.LastValue;
			Q.Shadow = Q.LastValue;
			CMICRO.Shadow = CMICRO.LastValue;
			oldTick.Shadow = oldTick.LastValue;
			currTick.Shadow = currTick.LastValue;
			nanoDiff.Shadow = nanoDiff.LastValue;
			nanoRest.Shadow = nanoRest.LastValue;
			secDiff.Shadow = secDiff.LastValue;
			dateTime.Shadow = dateTime.LastValue;
			bInitialized.Shadow = bInitialized.LastValue;
		}

		public void LazyShadowToOnline()
		{
			EN.Cyclic = EN.Shadow;
			PMICRO.Cyclic = PMICRO.Shadow;
			Q.Cyclic = Q.Shadow;
			CMICRO.Cyclic = CMICRO.Shadow;
			oldTick.Cyclic = oldTick.Shadow;
			currTick.Cyclic = currTick.Shadow;
			nanoDiff.Cyclic = nanoDiff.Shadow;
			nanoRest.Cyclic = nanoRest.Shadow;
			secDiff.Cyclic = secDiff.Shadow;
			dateTime.Cyclic = dateTime.Shadow;
			bInitialized.Cyclic = bInitialized.Shadow;
		}

		public PlainRTC_EX2 CreatePlainerType()
		{
			var cloned = new PlainRTC_EX2();
			cloned.PDT = PDT.CreatePlainerType();
			cloned.CDT = CDT.CreatePlainerType();
			return cloned;
		}

		protected PlainRTC_EX2 CreatePlainerType(PlainRTC_EX2 cloned)
		{
			cloned.PDT = PDT.CreatePlainerType();
			cloned.CDT = CDT.CreatePlainerType();
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainRTC_EX2 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainRTC_EX2 source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainRTC_EX2 source)
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

		public RTC_EX2(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_EN = @Connector.Online.Adapter.CreateBOOL(this, "", "EN");
			_PDT = new Tc2_Utilities.TIMESTRUCT(this, "", "PDT");
			_PMICRO = @Connector.Online.Adapter.CreateDWORD(this, "", "PMICRO");
			_Q = @Connector.Online.Adapter.CreateBOOL(this, "", "Q");
			_CDT = new Tc2_Utilities.TIMESTRUCT(this, "", "CDT");
			_CMICRO = @Connector.Online.Adapter.CreateDWORD(this, "", "CMICRO");
			_oldTick = @Connector.Online.Adapter.CreateDWORD(this, "", "oldTick");
			_currTick = @Connector.Online.Adapter.CreateDWORD(this, "", "currTick");
			_nanoDiff = @Connector.Online.Adapter.CreateDWORD(this, "", "nanoDiff");
			_nanoRest = @Connector.Online.Adapter.CreateDWORD(this, "", "nanoRest");
			_secDiff = @Connector.Online.Adapter.CreateDWORD(this, "", "secDiff");
			_dateTime = @Connector.Online.Adapter.CreateDATE_TIME(this, "", "dateTime");
			_bInitialized = @Connector.Online.Adapter.CreateBOOL(this, "", "bInitialized");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public RTC_EX2()
		{
			PexPreConstructorParameterless();
			_EN = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_PDT = new Tc2_Utilities.TIMESTRUCT();
			_PMICRO = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_Q = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_CDT = new Tc2_Utilities.TIMESTRUCT();
			_CMICRO = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_oldTick = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_currTick = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_nanoDiff = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_nanoRest = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_secDiff = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_dateTime = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			_bInitialized = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IRTC_EX2 : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool EN
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord PMICRO
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Q
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord CMICRO
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord oldTick
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord currTick
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord nanoDiff
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord nanoRest
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord secDiff
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime dateTime
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool bInitialized
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainRTC_EX2 CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainRTC_EX2 source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainRTC_EX2 source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowRTC_EX2 : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool EN
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord PMICRO
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Q
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord CMICRO
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord oldTick
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord currTick
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord nanoDiff
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord nanoRest
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord secDiff
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime dateTime
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool bInitialized
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainRTC_EX2 CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainRTC_EX2 source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainRTC_EX2 : Vortex.Connector.IPlain
	{
		System.Boolean _EN;
		public System.Boolean EN
		{
			get
			{
				return _EN;
			}

			set
			{
				_EN = value;
			}
		}

		Tc2_Utilities.PlainTIMESTRUCT _PDT;
		internal Tc2_Utilities.PlainTIMESTRUCT PDT
		{
			get
			{
				return _PDT;
			}

			set
			{
				_PDT = value;
			}
		}

		System.UInt32 _PMICRO;
		public System.UInt32 PMICRO
		{
			get
			{
				return _PMICRO;
			}

			set
			{
				_PMICRO = value;
			}
		}

		System.Boolean _Q;
		public System.Boolean Q
		{
			get
			{
				return _Q;
			}

			set
			{
				_Q = value;
			}
		}

		Tc2_Utilities.PlainTIMESTRUCT _CDT;
		internal Tc2_Utilities.PlainTIMESTRUCT CDT
		{
			get
			{
				return _CDT;
			}

			set
			{
				_CDT = value;
			}
		}

		System.UInt32 _CMICRO;
		public System.UInt32 CMICRO
		{
			get
			{
				return _CMICRO;
			}

			set
			{
				_CMICRO = value;
			}
		}

		System.UInt32 _oldTick;
		public System.UInt32 oldTick
		{
			get
			{
				return _oldTick;
			}

			set
			{
				_oldTick = value;
			}
		}

		System.UInt32 _currTick;
		public System.UInt32 currTick
		{
			get
			{
				return _currTick;
			}

			set
			{
				_currTick = value;
			}
		}

		System.UInt32 _nanoDiff;
		public System.UInt32 nanoDiff
		{
			get
			{
				return _nanoDiff;
			}

			set
			{
				_nanoDiff = value;
			}
		}

		System.UInt32 _nanoRest;
		public System.UInt32 nanoRest
		{
			get
			{
				return _nanoRest;
			}

			set
			{
				_nanoRest = value;
			}
		}

		System.UInt32 _secDiff;
		public System.UInt32 secDiff
		{
			get
			{
				return _secDiff;
			}

			set
			{
				_secDiff = value;
			}
		}

		System.DateTime _dateTime;
		public System.DateTime dateTime
		{
			get
			{
				return _dateTime;
			}

			set
			{
				_dateTime = value;
			}
		}

		System.Boolean _bInitialized;
		public System.Boolean bInitialized
		{
			get
			{
				return _bInitialized;
			}

			set
			{
				_bInitialized = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.RTC_EX2 target)
		{
			target.EN.Cyclic = EN;
			PDT.CopyPlainToCyclic(target.PDT);
			target.PMICRO.Cyclic = PMICRO;
			target.Q.Cyclic = Q;
			CDT.CopyPlainToCyclic(target.CDT);
			target.CMICRO.Cyclic = CMICRO;
			target.oldTick.Cyclic = oldTick;
			target.currTick.Cyclic = currTick;
			target.nanoDiff.Cyclic = nanoDiff;
			target.nanoRest.Cyclic = nanoRest;
			target.secDiff.Cyclic = secDiff;
			target.dateTime.Cyclic = dateTime;
			target.bInitialized.Cyclic = bInitialized;
		}

		public void CopyPlainToCyclic(Tc2_Utilities.IRTC_EX2 target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.RTC_EX2)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.RTC_EX2 target)
		{
			target.EN.Shadow = EN;
			PDT.CopyPlainToShadow(target.PDT);
			target.PMICRO.Shadow = PMICRO;
			target.Q.Shadow = Q;
			CDT.CopyPlainToShadow(target.CDT);
			target.CMICRO.Shadow = CMICRO;
			target.oldTick.Shadow = oldTick;
			target.currTick.Shadow = currTick;
			target.nanoDiff.Shadow = nanoDiff;
			target.nanoRest.Shadow = nanoRest;
			target.secDiff.Shadow = secDiff;
			target.dateTime.Shadow = dateTime;
			target.bInitialized.Shadow = bInitialized;
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowRTC_EX2 target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.RTC_EX2)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.RTC_EX2 source)
		{
			EN = source.EN.LastValue;
			PDT.CopyCyclicToPlain(source.PDT);
			PMICRO = source.PMICRO.LastValue;
			Q = source.Q.LastValue;
			CDT.CopyCyclicToPlain(source.CDT);
			CMICRO = source.CMICRO.LastValue;
			oldTick = source.oldTick.LastValue;
			currTick = source.currTick.LastValue;
			nanoDiff = source.nanoDiff.LastValue;
			nanoRest = source.nanoRest.LastValue;
			secDiff = source.secDiff.LastValue;
			dateTime = source.dateTime.LastValue;
			bInitialized = source.bInitialized.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Utilities.IRTC_EX2 source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.RTC_EX2)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.RTC_EX2 source)
		{
			EN = source.EN.Shadow;
			PDT.CopyShadowToPlain(source.PDT);
			PMICRO = source.PMICRO.Shadow;
			Q = source.Q.Shadow;
			CDT.CopyShadowToPlain(source.CDT);
			CMICRO = source.CMICRO.Shadow;
			oldTick = source.oldTick.Shadow;
			currTick = source.currTick.Shadow;
			nanoDiff = source.nanoDiff.Shadow;
			nanoRest = source.nanoRest.Shadow;
			secDiff = source.secDiff.Shadow;
			dateTime = source.dateTime.Shadow;
			bInitialized = source.bInitialized.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowRTC_EX2 source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.RTC_EX2)source);
		}

		public PlainRTC_EX2()
		{
			_PDT = new Tc2_Utilities.PlainTIMESTRUCT();
			_CDT = new Tc2_Utilities.PlainTIMESTRUCT();
		}
	}
}