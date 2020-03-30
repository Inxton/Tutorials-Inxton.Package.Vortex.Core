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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "FB_RegQueryValue", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class FB_RegQueryValue : Vortex.Connector.IVortexObject, IFB_RegQueryValue, IShadowFB_RegQueryValue, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerUDInt _cbData;
		public Vortex.Connector.ValueTypes.OnlinerUDInt cbData
		{
			get
			{
				return _cbData;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IFB_RegQueryValue.cbData
		{
			get
			{
				return cbData;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowFB_RegQueryValue.cbData
		{
			get
			{
				return cbData;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerByte _pData;
		public Vortex.Connector.ValueTypes.OnlinerByte pData
		{
			get
			{
				return _pData;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte IFB_RegQueryValue.pData
		{
			get
			{
				return pData;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte IShadowFB_RegQueryValue.pData
		{
			get
			{
				return pData;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _bExecute;
		public Vortex.Connector.ValueTypes.OnlinerBool bExecute
		{
			get
			{
				return _bExecute;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IFB_RegQueryValue.bExecute
		{
			get
			{
				return bExecute;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowFB_RegQueryValue.bExecute
		{
			get
			{
				return bExecute;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTime _tTimeOut;
		public Vortex.Connector.ValueTypes.OnlinerTime tTimeOut
		{
			get
			{
				return _tTimeOut;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime IFB_RegQueryValue.tTimeOut
		{
			get
			{
				return tTimeOut;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowFB_RegQueryValue.tTimeOut
		{
			get
			{
				return tTimeOut;
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool IFB_RegQueryValue.bBusy
		{
			get
			{
				return bBusy;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowFB_RegQueryValue.bBusy
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool IFB_RegQueryValue.bError
		{
			get
			{
				return bError;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowFB_RegQueryValue.bError
		{
			get
			{
				return bError;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _nErrId;
		public Vortex.Connector.ValueTypes.OnlinerUDInt nErrId
		{
			get
			{
				return _nErrId;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IFB_RegQueryValue.nErrId
		{
			get
			{
				return nErrId;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowFB_RegQueryValue.nErrId
		{
			get
			{
				return nErrId;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _cbRead;
		public Vortex.Connector.ValueTypes.OnlinerUDInt cbRead
		{
			get
			{
				return _cbRead;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IFB_RegQueryValue.cbRead
		{
			get
			{
				return cbRead;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowFB_RegQueryValue.cbRead
		{
			get
			{
				return cbRead;
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

		Vortex.Connector.ValueTypes.Online.IOnlineByte IFB_RegQueryValue.state
		{
			get
			{
				return state;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte IShadowFB_RegQueryValue.state
		{
			get
			{
				return state;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _s1Len;
		public Vortex.Connector.ValueTypes.OnlinerUDInt s1Len
		{
			get
			{
				return _s1Len;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IFB_RegQueryValue.s1Len
		{
			get
			{
				return s1Len;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowFB_RegQueryValue.s1Len
		{
			get
			{
				return s1Len;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _s2Len;
		public Vortex.Connector.ValueTypes.OnlinerUDInt s2Len
		{
			get
			{
				return _s2Len;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IFB_RegQueryValue.s2Len
		{
			get
			{
				return s2Len;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowFB_RegQueryValue.s2Len
		{
			get
			{
				return s2Len;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerByte _ptr;
		public Vortex.Connector.ValueTypes.OnlinerByte ptr
		{
			get
			{
				return _ptr;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte IFB_RegQueryValue.ptr
		{
			get
			{
				return ptr;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte IShadowFB_RegQueryValue.ptr
		{
			get
			{
				return ptr;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _cbBuff;
		public Vortex.Connector.ValueTypes.OnlinerUDInt cbBuff
		{
			get
			{
				return _cbBuff;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IFB_RegQueryValue.cbBuff
		{
			get
			{
				return cbBuff;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowFB_RegQueryValue.cbBuff
		{
			get
			{
				return cbBuff;
			}
		}

		Tc2_Utilities.ST_HKeySrvRead _tmpBuff;
		internal Tc2_Utilities.ST_HKeySrvRead tmpBuff
		{
			get
			{
				return _tmpBuff;
			}
		}

		public void LazyOnlineToShadow()
		{
			cbData.Shadow = cbData.LastValue;
			pData.Shadow = pData.LastValue;
			bExecute.Shadow = bExecute.LastValue;
			tTimeOut.Shadow = tTimeOut.LastValue;
			bBusy.Shadow = bBusy.LastValue;
			bError.Shadow = bError.LastValue;
			nErrId.Shadow = nErrId.LastValue;
			cbRead.Shadow = cbRead.LastValue;
			state.Shadow = state.LastValue;
			s1Len.Shadow = s1Len.LastValue;
			s2Len.Shadow = s2Len.LastValue;
			ptr.Shadow = ptr.LastValue;
			cbBuff.Shadow = cbBuff.LastValue;
		}

		public void LazyShadowToOnline()
		{
			cbData.Cyclic = cbData.Shadow;
			pData.Cyclic = pData.Shadow;
			bExecute.Cyclic = bExecute.Shadow;
			tTimeOut.Cyclic = tTimeOut.Shadow;
			bBusy.Cyclic = bBusy.Shadow;
			bError.Cyclic = bError.Shadow;
			nErrId.Cyclic = nErrId.Shadow;
			cbRead.Cyclic = cbRead.Shadow;
			state.Cyclic = state.Shadow;
			s1Len.Cyclic = s1Len.Shadow;
			s2Len.Cyclic = s2Len.Shadow;
			ptr.Cyclic = ptr.Shadow;
			cbBuff.Cyclic = cbBuff.Shadow;
		}

		public PlainFB_RegQueryValue CreatePlainerType()
		{
			var cloned = new PlainFB_RegQueryValue();
			cloned.tmpBuff = tmpBuff.CreatePlainerType();
			return cloned;
		}

		protected PlainFB_RegQueryValue CreatePlainerType(PlainFB_RegQueryValue cloned)
		{
			cloned.tmpBuff = tmpBuff.CreatePlainerType();
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainFB_RegQueryValue source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainFB_RegQueryValue source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainFB_RegQueryValue source)
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

		public FB_RegQueryValue(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_cbData = @Connector.Online.Adapter.CreateUDINT(this, "", "cbData");
			_pData = @Connector.Online.Adapter.CreateBYTE(this, "", "pData");
			_bExecute = @Connector.Online.Adapter.CreateBOOL(this, "", "bExecute");
			_tTimeOut = @Connector.Online.Adapter.CreateTIME(this, "", "tTimeOut");
			_bBusy = @Connector.Online.Adapter.CreateBOOL(this, "", "bBusy");
			_bError = @Connector.Online.Adapter.CreateBOOL(this, "", "bError");
			_nErrId = @Connector.Online.Adapter.CreateUDINT(this, "", "nErrId");
			_cbRead = @Connector.Online.Adapter.CreateUDINT(this, "", "cbRead");
			_state = @Connector.Online.Adapter.CreateBYTE(this, "", "state");
			_s1Len = @Connector.Online.Adapter.CreateUDINT(this, "", "s1Len");
			_s2Len = @Connector.Online.Adapter.CreateUDINT(this, "", "s2Len");
			_ptr = @Connector.Online.Adapter.CreateBYTE(this, "", "ptr");
			_cbBuff = @Connector.Online.Adapter.CreateUDINT(this, "", "cbBuff");
			_tmpBuff = new Tc2_Utilities.ST_HKeySrvRead(this, "", "tmpBuff");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public FB_RegQueryValue()
		{
			PexPreConstructorParameterless();
			_cbData = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_pData = Vortex.Connector.IConnectorFactory.CreateBYTE();
			_bExecute = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_tTimeOut = Vortex.Connector.IConnectorFactory.CreateTIME();
			_bBusy = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_bError = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_nErrId = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_cbRead = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_state = Vortex.Connector.IConnectorFactory.CreateBYTE();
			_s1Len = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_s2Len = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_ptr = Vortex.Connector.IConnectorFactory.CreateBYTE();
			_cbBuff = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_tmpBuff = new Tc2_Utilities.ST_HKeySrvRead();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IFB_RegQueryValue : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUDInt cbData
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte pData
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool bExecute
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime tTimeOut
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt nErrId
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt cbRead
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte state
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt s1Len
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt s2Len
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte ptr
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt cbBuff
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainFB_RegQueryValue CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainFB_RegQueryValue source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainFB_RegQueryValue source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowFB_RegQueryValue : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt cbData
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte pData
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool bExecute
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime tTimeOut
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

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt nErrId
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt cbRead
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte state
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt s1Len
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt s2Len
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte ptr
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt cbBuff
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainFB_RegQueryValue CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainFB_RegQueryValue source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainFB_RegQueryValue : Vortex.Connector.IPlain
	{
		System.UInt32 _cbData;
		public System.UInt32 cbData
		{
			get
			{
				return _cbData;
			}

			set
			{
				_cbData = value;
			}
		}

		System.Byte _pData;
		public System.Byte pData
		{
			get
			{
				return _pData;
			}

			set
			{
				_pData = value;
			}
		}

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

		System.TimeSpan _tTimeOut;
		public System.TimeSpan tTimeOut
		{
			get
			{
				return _tTimeOut;
			}

			set
			{
				_tTimeOut = value;
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

		System.UInt32 _nErrId;
		public System.UInt32 nErrId
		{
			get
			{
				return _nErrId;
			}

			set
			{
				_nErrId = value;
			}
		}

		System.UInt32 _cbRead;
		public System.UInt32 cbRead
		{
			get
			{
				return _cbRead;
			}

			set
			{
				_cbRead = value;
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

		System.UInt32 _s1Len;
		public System.UInt32 s1Len
		{
			get
			{
				return _s1Len;
			}

			set
			{
				_s1Len = value;
			}
		}

		System.UInt32 _s2Len;
		public System.UInt32 s2Len
		{
			get
			{
				return _s2Len;
			}

			set
			{
				_s2Len = value;
			}
		}

		System.Byte _ptr;
		public System.Byte ptr
		{
			get
			{
				return _ptr;
			}

			set
			{
				_ptr = value;
			}
		}

		System.UInt32 _cbBuff;
		public System.UInt32 cbBuff
		{
			get
			{
				return _cbBuff;
			}

			set
			{
				_cbBuff = value;
			}
		}

		Tc2_Utilities.PlainST_HKeySrvRead _tmpBuff;
		internal Tc2_Utilities.PlainST_HKeySrvRead tmpBuff
		{
			get
			{
				return _tmpBuff;
			}

			set
			{
				_tmpBuff = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.FB_RegQueryValue target)
		{
			target.cbData.Cyclic = cbData;
			target.pData.Cyclic = pData;
			target.bExecute.Cyclic = bExecute;
			target.tTimeOut.Cyclic = tTimeOut;
			target.bBusy.Cyclic = bBusy;
			target.bError.Cyclic = bError;
			target.nErrId.Cyclic = nErrId;
			target.cbRead.Cyclic = cbRead;
			target.state.Cyclic = state;
			target.s1Len.Cyclic = s1Len;
			target.s2Len.Cyclic = s2Len;
			target.ptr.Cyclic = ptr;
			target.cbBuff.Cyclic = cbBuff;
			tmpBuff.CopyPlainToCyclic(target.tmpBuff);
		}

		public void CopyPlainToCyclic(Tc2_Utilities.IFB_RegQueryValue target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.FB_RegQueryValue)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.FB_RegQueryValue target)
		{
			target.cbData.Shadow = cbData;
			target.pData.Shadow = pData;
			target.bExecute.Shadow = bExecute;
			target.tTimeOut.Shadow = tTimeOut;
			target.bBusy.Shadow = bBusy;
			target.bError.Shadow = bError;
			target.nErrId.Shadow = nErrId;
			target.cbRead.Shadow = cbRead;
			target.state.Shadow = state;
			target.s1Len.Shadow = s1Len;
			target.s2Len.Shadow = s2Len;
			target.ptr.Shadow = ptr;
			target.cbBuff.Shadow = cbBuff;
			tmpBuff.CopyPlainToShadow(target.tmpBuff);
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowFB_RegQueryValue target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.FB_RegQueryValue)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.FB_RegQueryValue source)
		{
			cbData = source.cbData.LastValue;
			pData = source.pData.LastValue;
			bExecute = source.bExecute.LastValue;
			tTimeOut = source.tTimeOut.LastValue;
			bBusy = source.bBusy.LastValue;
			bError = source.bError.LastValue;
			nErrId = source.nErrId.LastValue;
			cbRead = source.cbRead.LastValue;
			state = source.state.LastValue;
			s1Len = source.s1Len.LastValue;
			s2Len = source.s2Len.LastValue;
			ptr = source.ptr.LastValue;
			cbBuff = source.cbBuff.LastValue;
			tmpBuff.CopyCyclicToPlain(source.tmpBuff);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.IFB_RegQueryValue source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.FB_RegQueryValue)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.FB_RegQueryValue source)
		{
			cbData = source.cbData.Shadow;
			pData = source.pData.Shadow;
			bExecute = source.bExecute.Shadow;
			tTimeOut = source.tTimeOut.Shadow;
			bBusy = source.bBusy.Shadow;
			bError = source.bError.Shadow;
			nErrId = source.nErrId.Shadow;
			cbRead = source.cbRead.Shadow;
			state = source.state.Shadow;
			s1Len = source.s1Len.Shadow;
			s2Len = source.s2Len.Shadow;
			ptr = source.ptr.Shadow;
			cbBuff = source.cbBuff.Shadow;
			tmpBuff.CopyShadowToPlain(source.tmpBuff);
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowFB_RegQueryValue source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.FB_RegQueryValue)source);
		}

		public PlainFB_RegQueryValue()
		{
			_tmpBuff = new Tc2_Utilities.PlainST_HKeySrvRead();
		}
	}
}