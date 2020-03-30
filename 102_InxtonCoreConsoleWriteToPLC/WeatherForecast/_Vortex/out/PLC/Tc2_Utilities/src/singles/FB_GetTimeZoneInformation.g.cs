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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "FB_GetTimeZoneInformation", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class FB_GetTimeZoneInformation : Vortex.Connector.IVortexObject, IFB_GetTimeZoneInformation, IShadowFB_GetTimeZoneInformation, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _bExecute;
		public Vortex.Connector.ValueTypes.OnlinerBool bExecute
		{
			get
			{
				return _bExecute;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IFB_GetTimeZoneInformation.bExecute
		{
			get
			{
				return bExecute;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowFB_GetTimeZoneInformation.bExecute
		{
			get
			{
				return bExecute;
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

		Vortex.Connector.ValueTypes.Online.IOnlineTime IFB_GetTimeZoneInformation.tTimeout
		{
			get
			{
				return tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowFB_GetTimeZoneInformation.tTimeout
		{
			get
			{
				return tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _bBusy;
		public Vortex.Connector.ValueTypes.OnlinerBool bBusy
		{
			get
			{
				return _bBusy;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IFB_GetTimeZoneInformation.bBusy
		{
			get
			{
				return bBusy;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowFB_GetTimeZoneInformation.bBusy
		{
			get
			{
				return bBusy;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _bError;
		public Vortex.Connector.ValueTypes.OnlinerBool bError
		{
			get
			{
				return _bError;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IFB_GetTimeZoneInformation.bError
		{
			get
			{
				return bError;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowFB_GetTimeZoneInformation.bError
		{
			get
			{
				return bError;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _nErrID;
		public Vortex.Connector.ValueTypes.OnlinerUDInt nErrID
		{
			get
			{
				return _nErrID;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IFB_GetTimeZoneInformation.nErrID
		{
			get
			{
				return nErrID;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowFB_GetTimeZoneInformation.nErrID
		{
			get
			{
				return nErrID;
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
		Vortex.Connector.ValueTypes.Online.IOnlineInt IFB_GetTimeZoneInformation.tzID
		{
			get
			{
				return tzID;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_TimeZoneID))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowFB_GetTimeZoneInformation.tzID
		{
			get
			{
				return tzID;
			}
		}

		Tc2_Utilities.ST_TimeZoneInformation _tzInfo;
		internal Tc2_Utilities.ST_TimeZoneInformation tzInfo
		{
			get
			{
				return _tzInfo;
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

		Vortex.Connector.ValueTypes.Online.IOnlineByte IFB_GetTimeZoneInformation.state
		{
			get
			{
				return state;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte IShadowFB_GetTimeZoneInformation.state
		{
			get
			{
				return state;
			}
		}

		Tc2_Utilities.ST_AmsGetTimeZoneInformation _res;
		internal Tc2_Utilities.ST_AmsGetTimeZoneInformation res
		{
			get
			{
				return _res;
			}
		}

		public void LazyOnlineToShadow()
		{
			bExecute.Shadow = bExecute.LastValue;
			tTimeout.Shadow = tTimeout.LastValue;
			bBusy.Shadow = bBusy.LastValue;
			bError.Shadow = bError.LastValue;
			nErrID.Shadow = nErrID.LastValue;
			tzID.Shadow = tzID.LastValue;
			state.Shadow = state.LastValue;
		}

		public void LazyShadowToOnline()
		{
			bExecute.Cyclic = bExecute.Shadow;
			tTimeout.Cyclic = tTimeout.Shadow;
			bBusy.Cyclic = bBusy.Shadow;
			bError.Cyclic = bError.Shadow;
			nErrID.Cyclic = nErrID.Shadow;
			tzID.Cyclic = tzID.Shadow;
			state.Cyclic = state.Shadow;
		}

		public PlainFB_GetTimeZoneInformation CreatePlainerType()
		{
			var cloned = new PlainFB_GetTimeZoneInformation();
			cloned.tzInfo = tzInfo.CreatePlainerType();
			cloned.res = res.CreatePlainerType();
			return cloned;
		}

		protected PlainFB_GetTimeZoneInformation CreatePlainerType(PlainFB_GetTimeZoneInformation cloned)
		{
			cloned.tzInfo = tzInfo.CreatePlainerType();
			cloned.res = res.CreatePlainerType();
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainFB_GetTimeZoneInformation source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainFB_GetTimeZoneInformation source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainFB_GetTimeZoneInformation source)
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

		public FB_GetTimeZoneInformation(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_bExecute = @Connector.Online.Adapter.CreateBOOL(this, "", "bExecute");
			_tTimeout = @Connector.Online.Adapter.CreateTIME(this, "", "tTimeout");
			_bBusy = @Connector.Online.Adapter.CreateBOOL(this, "", "bBusy");
			_bError = @Connector.Online.Adapter.CreateBOOL(this, "", "bError");
			_nErrID = @Connector.Online.Adapter.CreateUDINT(this, "", "nErrID");
			_tzID = @Connector.Online.Adapter.CreateINT(this, "", "tzID");
			_tzInfo = new Tc2_Utilities.ST_TimeZoneInformation(this, "", "tzInfo");
			_state = @Connector.Online.Adapter.CreateBYTE(this, "", "state");
			_res = new Tc2_Utilities.ST_AmsGetTimeZoneInformation(this, "", "res");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public FB_GetTimeZoneInformation()
		{
			PexPreConstructorParameterless();
			_bExecute = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_tTimeout = Vortex.Connector.IConnectorFactory.CreateTIME();
			_bBusy = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_bError = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_nErrID = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_tzID = Vortex.Connector.IConnectorFactory.CreateINT();
			_tzInfo = new Tc2_Utilities.ST_TimeZoneInformation();
			_state = Vortex.Connector.IConnectorFactory.CreateBYTE();
			_res = new Tc2_Utilities.ST_AmsGetTimeZoneInformation();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IFB_GetTimeZoneInformation : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool bExecute
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime tTimeout
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool bBusy
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool bError
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt nErrID
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

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainFB_GetTimeZoneInformation CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainFB_GetTimeZoneInformation source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainFB_GetTimeZoneInformation source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowFB_GetTimeZoneInformation : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool bExecute
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime tTimeout
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool bBusy
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool bError
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt nErrID
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

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainFB_GetTimeZoneInformation CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainFB_GetTimeZoneInformation source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainFB_GetTimeZoneInformation : Vortex.Connector.IPlain
	{
		System.Boolean _bExecute;
		public System.Boolean bExecute
		{
			get
			{
				return _bExecute;
			}

			set
			{
				_bExecute = value;
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

		System.Boolean _bBusy;
		public System.Boolean bBusy
		{
			get
			{
				return _bBusy;
			}

			set
			{
				_bBusy = value;
			}
		}

		System.Boolean _bError;
		public System.Boolean bError
		{
			get
			{
				return _bError;
			}

			set
			{
				_bError = value;
			}
		}

		System.UInt32 _nErrID;
		public System.UInt32 nErrID
		{
			get
			{
				return _nErrID;
			}

			set
			{
				_nErrID = value;
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

		Tc2_Utilities.PlainST_TimeZoneInformation _tzInfo;
		internal Tc2_Utilities.PlainST_TimeZoneInformation tzInfo
		{
			get
			{
				return _tzInfo;
			}

			set
			{
				_tzInfo = value;
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

		Tc2_Utilities.PlainST_AmsGetTimeZoneInformation _res;
		internal Tc2_Utilities.PlainST_AmsGetTimeZoneInformation res
		{
			get
			{
				return _res;
			}

			set
			{
				_res = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.FB_GetTimeZoneInformation target)
		{
			target.bExecute.Cyclic = bExecute;
			target.tTimeout.Cyclic = tTimeout;
			target.bBusy.Cyclic = bBusy;
			target.bError.Cyclic = bError;
			target.nErrID.Cyclic = nErrID;
			target.tzID.Cyclic = tzID;
			tzInfo.CopyPlainToCyclic(target.tzInfo);
			target.state.Cyclic = state;
			res.CopyPlainToCyclic(target.res);
		}

		public void CopyPlainToCyclic(Tc2_Utilities.IFB_GetTimeZoneInformation target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.FB_GetTimeZoneInformation)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.FB_GetTimeZoneInformation target)
		{
			target.bExecute.Shadow = bExecute;
			target.tTimeout.Shadow = tTimeout;
			target.bBusy.Shadow = bBusy;
			target.bError.Shadow = bError;
			target.nErrID.Shadow = nErrID;
			target.tzID.Shadow = tzID;
			tzInfo.CopyPlainToShadow(target.tzInfo);
			target.state.Shadow = state;
			res.CopyPlainToShadow(target.res);
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowFB_GetTimeZoneInformation target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.FB_GetTimeZoneInformation)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.FB_GetTimeZoneInformation source)
		{
			bExecute = source.bExecute.LastValue;
			tTimeout = source.tTimeout.LastValue;
			bBusy = source.bBusy.LastValue;
			bError = source.bError.LastValue;
			nErrID = source.nErrID.LastValue;
			tzID = source.tzID.LastValue;
			tzInfo.CopyCyclicToPlain(source.tzInfo);
			state = source.state.LastValue;
			res.CopyCyclicToPlain(source.res);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.IFB_GetTimeZoneInformation source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.FB_GetTimeZoneInformation)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.FB_GetTimeZoneInformation source)
		{
			bExecute = source.bExecute.Shadow;
			tTimeout = source.tTimeout.Shadow;
			bBusy = source.bBusy.Shadow;
			bError = source.bError.Shadow;
			nErrID = source.nErrID.Shadow;
			tzID = source.tzID.Shadow;
			tzInfo.CopyShadowToPlain(source.tzInfo);
			state = source.state.Shadow;
			res.CopyShadowToPlain(source.res);
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowFB_GetTimeZoneInformation source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.FB_GetTimeZoneInformation)source);
		}

		public PlainFB_GetTimeZoneInformation()
		{
			_tzInfo = new Tc2_Utilities.PlainST_TimeZoneInformation();
			_res = new Tc2_Utilities.PlainST_AmsGetTimeZoneInformation();
		}
	}
}