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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "ADSWRITE", "Tc2_System", TypeComplexityEnum.Complex)]
	public partial class ADSWRITE : Vortex.Connector.IVortexObject, IADSWRITE, IShadowADSWRITE, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IADSWRITE.IDXGRP
		{
			get
			{
				return IDXGRP;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowADSWRITE.IDXGRP
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IADSWRITE.IDXOFFS
		{
			get
			{
				return IDXOFFS;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowADSWRITE.IDXOFFS
		{
			get
			{
				return IDXOFFS;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _LEN;
		public Vortex.Connector.ValueTypes.OnlinerUDInt LEN
		{
			get
			{
				return _LEN;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IADSWRITE.LEN
		{
			get
			{
				return LEN;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowADSWRITE.LEN
		{
			get
			{
				return LEN;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _WRITE;
		public Vortex.Connector.ValueTypes.OnlinerBool WRITE
		{
			get
			{
				return _WRITE;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IADSWRITE.WRITE
		{
			get
			{
				return WRITE;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowADSWRITE.WRITE
		{
			get
			{
				return WRITE;
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

		Vortex.Connector.ValueTypes.Online.IOnlineTime IADSWRITE.TMOUT
		{
			get
			{
				return TMOUT;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowADSWRITE.TMOUT
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool IADSWRITE.BUSY
		{
			get
			{
				return BUSY;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowADSWRITE.BUSY
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool IADSWRITE.ERR
		{
			get
			{
				return ERR;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowADSWRITE.ERR
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IADSWRITE.ERRID
		{
			get
			{
				return ERRID;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowADSWRITE.ERRID
		{
			get
			{
				return ERRID;
			}
		}

		public void LazyOnlineToShadow()
		{
			IDXGRP.Shadow = IDXGRP.LastValue;
			IDXOFFS.Shadow = IDXOFFS.LastValue;
			LEN.Shadow = LEN.LastValue;
			WRITE.Shadow = WRITE.LastValue;
			TMOUT.Shadow = TMOUT.LastValue;
			BUSY.Shadow = BUSY.LastValue;
			ERR.Shadow = ERR.LastValue;
			ERRID.Shadow = ERRID.LastValue;
		}

		public void LazyShadowToOnline()
		{
			IDXGRP.Cyclic = IDXGRP.Shadow;
			IDXOFFS.Cyclic = IDXOFFS.Shadow;
			LEN.Cyclic = LEN.Shadow;
			WRITE.Cyclic = WRITE.Shadow;
			TMOUT.Cyclic = TMOUT.Shadow;
			BUSY.Cyclic = BUSY.Shadow;
			ERR.Cyclic = ERR.Shadow;
			ERRID.Cyclic = ERRID.Shadow;
		}

		public PlainADSWRITE CreatePlainerType()
		{
			var cloned = new PlainADSWRITE();
			return cloned;
		}

		protected PlainADSWRITE CreatePlainerType(PlainADSWRITE cloned)
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

		public void FlushPlainToOnline(Tc2_System.PlainADSWRITE source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_System.PlainADSWRITE source)
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

		public void FlushOnlineToPlain(Tc2_System.PlainADSWRITE source)
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

		public ADSWRITE(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_LEN = @Connector.Online.Adapter.CreateUDINT(this, "", "LEN");
			_WRITE = @Connector.Online.Adapter.CreateBOOL(this, "", "WRITE");
			_TMOUT = @Connector.Online.Adapter.CreateTIME(this, "", "TMOUT");
			_BUSY = @Connector.Online.Adapter.CreateBOOL(this, "", "BUSY");
			_ERR = @Connector.Online.Adapter.CreateBOOL(this, "", "ERR");
			_ERRID = @Connector.Online.Adapter.CreateUDINT(this, "", "ERRID");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public ADSWRITE()
		{
			PexPreConstructorParameterless();
			_IDXGRP = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_IDXOFFS = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_LEN = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_WRITE = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_TMOUT = Vortex.Connector.IConnectorFactory.CreateTIME();
			_BUSY = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_ERR = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_ERRID = Vortex.Connector.IConnectorFactory.CreateUDINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IADSWRITE : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IDXGRP
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IDXOFFS
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt LEN
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool WRITE
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

		Tc2_System.PlainADSWRITE CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_System.PlainADSWRITE source);
		void FlushOnlineToPlain(Tc2_System.PlainADSWRITE source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowADSWRITE : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IDXGRP
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IDXOFFS
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt LEN
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool WRITE
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

		Tc2_System.PlainADSWRITE CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_System.PlainADSWRITE source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainADSWRITE : Vortex.Connector.IPlain
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

		System.UInt32 _LEN;
		public System.UInt32 LEN
		{
			get
			{
				return _LEN;
			}

			set
			{
				_LEN = value;
			}
		}

		System.Boolean _WRITE;
		public System.Boolean WRITE
		{
			get
			{
				return _WRITE;
			}

			set
			{
				_WRITE = value;
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

		public void CopyPlainToCyclic(Tc2_System.ADSWRITE target)
		{
			target.IDXGRP.Cyclic = IDXGRP;
			target.IDXOFFS.Cyclic = IDXOFFS;
			target.LEN.Cyclic = LEN;
			target.WRITE.Cyclic = WRITE;
			target.TMOUT.Cyclic = TMOUT;
			target.BUSY.Cyclic = BUSY;
			target.ERR.Cyclic = ERR;
			target.ERRID.Cyclic = ERRID;
		}

		public void CopyPlainToCyclic(Tc2_System.IADSWRITE target)
		{
			this.CopyPlainToCyclic((Tc2_System.ADSWRITE)target);
		}

		public void CopyPlainToShadow(Tc2_System.ADSWRITE target)
		{
			target.IDXGRP.Shadow = IDXGRP;
			target.IDXOFFS.Shadow = IDXOFFS;
			target.LEN.Shadow = LEN;
			target.WRITE.Shadow = WRITE;
			target.TMOUT.Shadow = TMOUT;
			target.BUSY.Shadow = BUSY;
			target.ERR.Shadow = ERR;
			target.ERRID.Shadow = ERRID;
		}

		public void CopyPlainToShadow(Tc2_System.IShadowADSWRITE target)
		{
			this.CopyPlainToShadow((Tc2_System.ADSWRITE)target);
		}

		public void CopyCyclicToPlain(Tc2_System.ADSWRITE source)
		{
			IDXGRP = source.IDXGRP.LastValue;
			IDXOFFS = source.IDXOFFS.LastValue;
			LEN = source.LEN.LastValue;
			WRITE = source.WRITE.LastValue;
			TMOUT = source.TMOUT.LastValue;
			BUSY = source.BUSY.LastValue;
			ERR = source.ERR.LastValue;
			ERRID = source.ERRID.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_System.IADSWRITE source)
		{
			this.CopyCyclicToPlain((Tc2_System.ADSWRITE)source);
		}

		public void CopyShadowToPlain(Tc2_System.ADSWRITE source)
		{
			IDXGRP = source.IDXGRP.Shadow;
			IDXOFFS = source.IDXOFFS.Shadow;
			LEN = source.LEN.Shadow;
			WRITE = source.WRITE.Shadow;
			TMOUT = source.TMOUT.Shadow;
			BUSY = source.BUSY.Shadow;
			ERR = source.ERR.Shadow;
			ERRID = source.ERRID.Shadow;
		}

		public void CopyShadowToPlain(Tc2_System.IShadowADSWRITE source)
		{
			this.CopyShadowToPlain((Tc2_System.ADSWRITE)source);
		}

		public PlainADSWRITE()
		{
		}
	}
}