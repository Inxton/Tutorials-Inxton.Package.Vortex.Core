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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "NT_GetTime", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class NT_GetTime : Vortex.Connector.IVortexObject, INT_GetTime, IShadowNT_GetTime, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _START;
		public Vortex.Connector.ValueTypes.OnlinerBool START
		{
			get
			{
				return _START;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool INT_GetTime.START
		{
			get
			{
				return START;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowNT_GetTime.START
		{
			get
			{
				return START;
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

		Vortex.Connector.ValueTypes.Online.IOnlineTime INT_GetTime.TMOUT
		{
			get
			{
				return TMOUT;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowNT_GetTime.TMOUT
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool INT_GetTime.BUSY
		{
			get
			{
				return BUSY;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowNT_GetTime.BUSY
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool INT_GetTime.ERR
		{
			get
			{
				return ERR;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowNT_GetTime.ERR
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt INT_GetTime.ERRID
		{
			get
			{
				return ERRID;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowNT_GetTime.ERRID
		{
			get
			{
				return ERRID;
			}
		}

		Tc2_Utilities.TIMESTRUCT _TIMESTR;
		internal Tc2_Utilities.TIMESTRUCT TIMESTR
		{
			get
			{
				return _TIMESTR;
			}
		}

		public void LazyOnlineToShadow()
		{
			START.Shadow = START.LastValue;
			TMOUT.Shadow = TMOUT.LastValue;
			BUSY.Shadow = BUSY.LastValue;
			ERR.Shadow = ERR.LastValue;
			ERRID.Shadow = ERRID.LastValue;
		}

		public void LazyShadowToOnline()
		{
			START.Cyclic = START.Shadow;
			TMOUT.Cyclic = TMOUT.Shadow;
			BUSY.Cyclic = BUSY.Shadow;
			ERR.Cyclic = ERR.Shadow;
			ERRID.Cyclic = ERRID.Shadow;
		}

		public PlainNT_GetTime CreatePlainerType()
		{
			var cloned = new PlainNT_GetTime();
			cloned.TIMESTR = TIMESTR.CreatePlainerType();
			return cloned;
		}

		protected PlainNT_GetTime CreatePlainerType(PlainNT_GetTime cloned)
		{
			cloned.TIMESTR = TIMESTR.CreatePlainerType();
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainNT_GetTime source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainNT_GetTime source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainNT_GetTime source)
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

		public NT_GetTime(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_START = @Connector.Online.Adapter.CreateBOOL(this, "", "START");
			_TMOUT = @Connector.Online.Adapter.CreateTIME(this, "", "TMOUT");
			_BUSY = @Connector.Online.Adapter.CreateBOOL(this, "", "BUSY");
			_ERR = @Connector.Online.Adapter.CreateBOOL(this, "", "ERR");
			_ERRID = @Connector.Online.Adapter.CreateUDINT(this, "", "ERRID");
			_TIMESTR = new Tc2_Utilities.TIMESTRUCT(this, "", "TIMESTR");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public NT_GetTime()
		{
			PexPreConstructorParameterless();
			_START = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_TMOUT = Vortex.Connector.IConnectorFactory.CreateTIME();
			_BUSY = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_ERR = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_ERRID = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_TIMESTR = new Tc2_Utilities.TIMESTRUCT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface INT_GetTime : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool START
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

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainNT_GetTime CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainNT_GetTime source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainNT_GetTime source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowNT_GetTime : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool START
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

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainNT_GetTime CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainNT_GetTime source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainNT_GetTime : Vortex.Connector.IPlain
	{
		System.Boolean _START;
		public System.Boolean START
		{
			get
			{
				return _START;
			}

			set
			{
				_START = value;
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

		Tc2_Utilities.PlainTIMESTRUCT _TIMESTR;
		internal Tc2_Utilities.PlainTIMESTRUCT TIMESTR
		{
			get
			{
				return _TIMESTR;
			}

			set
			{
				_TIMESTR = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.NT_GetTime target)
		{
			target.START.Cyclic = START;
			target.TMOUT.Cyclic = TMOUT;
			target.BUSY.Cyclic = BUSY;
			target.ERR.Cyclic = ERR;
			target.ERRID.Cyclic = ERRID;
			TIMESTR.CopyPlainToCyclic(target.TIMESTR);
		}

		public void CopyPlainToCyclic(Tc2_Utilities.INT_GetTime target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.NT_GetTime)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.NT_GetTime target)
		{
			target.START.Shadow = START;
			target.TMOUT.Shadow = TMOUT;
			target.BUSY.Shadow = BUSY;
			target.ERR.Shadow = ERR;
			target.ERRID.Shadow = ERRID;
			TIMESTR.CopyPlainToShadow(target.TIMESTR);
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowNT_GetTime target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.NT_GetTime)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.NT_GetTime source)
		{
			START = source.START.LastValue;
			TMOUT = source.TMOUT.LastValue;
			BUSY = source.BUSY.LastValue;
			ERR = source.ERR.LastValue;
			ERRID = source.ERRID.LastValue;
			TIMESTR.CopyCyclicToPlain(source.TIMESTR);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.INT_GetTime source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.NT_GetTime)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.NT_GetTime source)
		{
			START = source.START.Shadow;
			TMOUT = source.TMOUT.Shadow;
			BUSY = source.BUSY.Shadow;
			ERR = source.ERR.Shadow;
			ERRID = source.ERRID.Shadow;
			TIMESTR.CopyShadowToPlain(source.TIMESTR);
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowNT_GetTime source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.NT_GetTime)source);
		}

		public PlainNT_GetTime()
		{
			_TIMESTR = new Tc2_Utilities.PlainTIMESTRUCT();
		}
	}
}