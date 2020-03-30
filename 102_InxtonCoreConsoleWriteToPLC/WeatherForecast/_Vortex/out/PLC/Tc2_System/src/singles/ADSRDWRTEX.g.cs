using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Tc2_System
{
	
            /// <summary>
            /// This is an external type. No documentation available.
            /// </summary>
            /// <exclude />
	[IgnoreReflection()]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "ADSRDWRTEX", "Tc2_System", TypeComplexityEnum.Complex)]
	public partial class ADSRDWRTEX : Vortex.Connector.IVortexObject, IADSRDWRTEX, IShadowADSRDWRTEX, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
				return Tc2_SystemTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerUDInt _IDXGRP;
		public Vortex.Connector.ValueTypes.OnlinerUDInt IDXGRP
		{
			get
			{
				return _IDXGRP;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IADSRDWRTEX.IDXGRP
		{
			get
			{
				return IDXGRP;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowADSRDWRTEX.IDXGRP
		{
			get
			{
				return IDXGRP;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _IDXOFFS;
		public Vortex.Connector.ValueTypes.OnlinerUDInt IDXOFFS
		{
			get
			{
				return _IDXOFFS;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IADSRDWRTEX.IDXOFFS
		{
			get
			{
				return IDXOFFS;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowADSRDWRTEX.IDXOFFS
		{
			get
			{
				return IDXOFFS;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _WRITELEN;
		public Vortex.Connector.ValueTypes.OnlinerUDInt WRITELEN
		{
			get
			{
				return _WRITELEN;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IADSRDWRTEX.WRITELEN
		{
			get
			{
				return WRITELEN;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowADSRDWRTEX.WRITELEN
		{
			get
			{
				return WRITELEN;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _READLEN;
		public Vortex.Connector.ValueTypes.OnlinerUDInt READLEN
		{
			get
			{
				return _READLEN;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IADSRDWRTEX.READLEN
		{
			get
			{
				return READLEN;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowADSRDWRTEX.READLEN
		{
			get
			{
				return READLEN;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _WRTRD;
		public Vortex.Connector.ValueTypes.OnlinerBool WRTRD
		{
			get
			{
				return _WRTRD;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IADSRDWRTEX.WRTRD
		{
			get
			{
				return WRTRD;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowADSRDWRTEX.WRTRD
		{
			get
			{
				return WRTRD;
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

		Vortex.Connector.ValueTypes.Online.IOnlineTime IADSRDWRTEX.TMOUT
		{
			get
			{
				return TMOUT;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowADSRDWRTEX.TMOUT
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool IADSRDWRTEX.BUSY
		{
			get
			{
				return BUSY;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowADSRDWRTEX.BUSY
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool IADSRDWRTEX.ERR
		{
			get
			{
				return ERR;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowADSRDWRTEX.ERR
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IADSRDWRTEX.ERRID
		{
			get
			{
				return ERRID;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowADSRDWRTEX.ERRID
		{
			get
			{
				return ERRID;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _COUNT_R;
		public Vortex.Connector.ValueTypes.OnlinerUDInt COUNT_R
		{
			get
			{
				return _COUNT_R;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IADSRDWRTEX.COUNT_R
		{
			get
			{
				return COUNT_R;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowADSRDWRTEX.COUNT_R
		{
			get
			{
				return COUNT_R;
			}
		}

		public void LazyOnlineToShadow()
		{
			IDXGRP.Shadow = IDXGRP.LastValue;
			IDXOFFS.Shadow = IDXOFFS.LastValue;
			WRITELEN.Shadow = WRITELEN.LastValue;
			READLEN.Shadow = READLEN.LastValue;
			WRTRD.Shadow = WRTRD.LastValue;
			TMOUT.Shadow = TMOUT.LastValue;
			BUSY.Shadow = BUSY.LastValue;
			ERR.Shadow = ERR.LastValue;
			ERRID.Shadow = ERRID.LastValue;
			COUNT_R.Shadow = COUNT_R.LastValue;
		}

		public void LazyShadowToOnline()
		{
			IDXGRP.Cyclic = IDXGRP.Shadow;
			IDXOFFS.Cyclic = IDXOFFS.Shadow;
			WRITELEN.Cyclic = WRITELEN.Shadow;
			READLEN.Cyclic = READLEN.Shadow;
			WRTRD.Cyclic = WRTRD.Shadow;
			TMOUT.Cyclic = TMOUT.Shadow;
			BUSY.Cyclic = BUSY.Shadow;
			ERR.Cyclic = ERR.Shadow;
			ERRID.Cyclic = ERRID.Shadow;
			COUNT_R.Cyclic = COUNT_R.Shadow;
		}

		public PlainADSRDWRTEX CreatePlainerType()
		{
			var cloned = new PlainADSRDWRTEX();
			return cloned;
		}

		protected PlainADSRDWRTEX CreatePlainerType(PlainADSRDWRTEX cloned)
		{
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

		public void FlushPlainToOnline(Tc2_System.PlainADSRDWRTEX source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_System.PlainADSRDWRTEX source)
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

		public void FlushOnlineToPlain(Tc2_System.PlainADSRDWRTEX source)
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
				return Tc2_SystemTwinController.Translator.Translate(_AttributeName).Interpolate(this);
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

		public ADSRDWRTEX(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_IDXGRP = @Connector.Online.Adapter.CreateUDINT(this, "", "IDXGRP");
			_IDXOFFS = @Connector.Online.Adapter.CreateUDINT(this, "", "IDXOFFS");
			_WRITELEN = @Connector.Online.Adapter.CreateUDINT(this, "", "WRITELEN");
			_READLEN = @Connector.Online.Adapter.CreateUDINT(this, "", "READLEN");
			_WRTRD = @Connector.Online.Adapter.CreateBOOL(this, "", "WRTRD");
			_TMOUT = @Connector.Online.Adapter.CreateTIME(this, "", "TMOUT");
			_BUSY = @Connector.Online.Adapter.CreateBOOL(this, "", "BUSY");
			_ERR = @Connector.Online.Adapter.CreateBOOL(this, "", "ERR");
			_ERRID = @Connector.Online.Adapter.CreateUDINT(this, "", "ERRID");
			_COUNT_R = @Connector.Online.Adapter.CreateUDINT(this, "", "COUNT_R");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public ADSRDWRTEX()
		{
			PexPreConstructorParameterless();
			_IDXGRP = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_IDXOFFS = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_WRITELEN = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_READLEN = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_WRTRD = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_TMOUT = Vortex.Connector.IConnectorFactory.CreateTIME();
			_BUSY = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_ERR = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_ERRID = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_COUNT_R = Vortex.Connector.IConnectorFactory.CreateUDINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IADSRDWRTEX : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IDXGRP
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IDXOFFS
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt WRITELEN
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt READLEN
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool WRTRD
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt COUNT_R
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_System.PlainADSRDWRTEX CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_System.PlainADSRDWRTEX source);
		void FlushOnlineToPlain(Tc2_System.PlainADSRDWRTEX source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowADSRDWRTEX : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IDXGRP
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IDXOFFS
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt WRITELEN
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt READLEN
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool WRTRD
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

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt COUNT_R
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_System.PlainADSRDWRTEX CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_System.PlainADSRDWRTEX source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainADSRDWRTEX : Vortex.Connector.IPlain
	{
		System.UInt32 _IDXGRP;
		public System.UInt32 IDXGRP
		{
			get
			{
				return _IDXGRP;
			}

			set
			{
				_IDXGRP = value;
			}
		}

		System.UInt32 _IDXOFFS;
		public System.UInt32 IDXOFFS
		{
			get
			{
				return _IDXOFFS;
			}

			set
			{
				_IDXOFFS = value;
			}
		}

		System.UInt32 _WRITELEN;
		public System.UInt32 WRITELEN
		{
			get
			{
				return _WRITELEN;
			}

			set
			{
				_WRITELEN = value;
			}
		}

		System.UInt32 _READLEN;
		public System.UInt32 READLEN
		{
			get
			{
				return _READLEN;
			}

			set
			{
				_READLEN = value;
			}
		}

		System.Boolean _WRTRD;
		public System.Boolean WRTRD
		{
			get
			{
				return _WRTRD;
			}

			set
			{
				_WRTRD = value;
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

		System.UInt32 _COUNT_R;
		public System.UInt32 COUNT_R
		{
			get
			{
				return _COUNT_R;
			}

			set
			{
				_COUNT_R = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_System.ADSRDWRTEX target)
		{
			target.IDXGRP.Cyclic = IDXGRP;
			target.IDXOFFS.Cyclic = IDXOFFS;
			target.WRITELEN.Cyclic = WRITELEN;
			target.READLEN.Cyclic = READLEN;
			target.WRTRD.Cyclic = WRTRD;
			target.TMOUT.Cyclic = TMOUT;
			target.BUSY.Cyclic = BUSY;
			target.ERR.Cyclic = ERR;
			target.ERRID.Cyclic = ERRID;
			target.COUNT_R.Cyclic = COUNT_R;
		}

		public void CopyPlainToCyclic(Tc2_System.IADSRDWRTEX target)
		{
			this.CopyPlainToCyclic((Tc2_System.ADSRDWRTEX)target);
		}

		public void CopyPlainToShadow(Tc2_System.ADSRDWRTEX target)
		{
			target.IDXGRP.Shadow = IDXGRP;
			target.IDXOFFS.Shadow = IDXOFFS;
			target.WRITELEN.Shadow = WRITELEN;
			target.READLEN.Shadow = READLEN;
			target.WRTRD.Shadow = WRTRD;
			target.TMOUT.Shadow = TMOUT;
			target.BUSY.Shadow = BUSY;
			target.ERR.Shadow = ERR;
			target.ERRID.Shadow = ERRID;
			target.COUNT_R.Shadow = COUNT_R;
		}

		public void CopyPlainToShadow(Tc2_System.IShadowADSRDWRTEX target)
		{
			this.CopyPlainToShadow((Tc2_System.ADSRDWRTEX)target);
		}

		public void CopyCyclicToPlain(Tc2_System.ADSRDWRTEX source)
		{
			IDXGRP = source.IDXGRP.LastValue;
			IDXOFFS = source.IDXOFFS.LastValue;
			WRITELEN = source.WRITELEN.LastValue;
			READLEN = source.READLEN.LastValue;
			WRTRD = source.WRTRD.LastValue;
			TMOUT = source.TMOUT.LastValue;
			BUSY = source.BUSY.LastValue;
			ERR = source.ERR.LastValue;
			ERRID = source.ERRID.LastValue;
			COUNT_R = source.COUNT_R.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_System.IADSRDWRTEX source)
		{
			this.CopyCyclicToPlain((Tc2_System.ADSRDWRTEX)source);
		}

		public void CopyShadowToPlain(Tc2_System.ADSRDWRTEX source)
		{
			IDXGRP = source.IDXGRP.Shadow;
			IDXOFFS = source.IDXOFFS.Shadow;
			WRITELEN = source.WRITELEN.Shadow;
			READLEN = source.READLEN.Shadow;
			WRTRD = source.WRTRD.Shadow;
			TMOUT = source.TMOUT.Shadow;
			BUSY = source.BUSY.Shadow;
			ERR = source.ERR.Shadow;
			ERRID = source.ERRID.Shadow;
			COUNT_R = source.COUNT_R.Shadow;
		}

		public void CopyShadowToPlain(Tc2_System.IShadowADSRDWRTEX source)
		{
			this.CopyShadowToPlain((Tc2_System.ADSRDWRTEX)source);
		}

		public PlainADSRDWRTEX()
		{
		}
	}
}