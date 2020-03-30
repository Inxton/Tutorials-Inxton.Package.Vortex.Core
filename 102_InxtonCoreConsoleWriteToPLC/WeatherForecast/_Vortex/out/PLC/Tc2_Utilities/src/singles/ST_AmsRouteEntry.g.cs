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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "ST_AmsRouteEntry", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class ST_AmsRouteEntry : Vortex.Connector.IVortexObject, IST_AmsRouteEntry, IShadowST_AmsRouteEntry, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerString _sName;
		public Vortex.Connector.ValueTypes.OnlinerString sName
		{
			get
			{
				return _sName;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IST_AmsRouteEntry.sName
		{
			get
			{
				return sName;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowST_AmsRouteEntry.sName
		{
			get
			{
				return sName;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _sAddress;
		public Vortex.Connector.ValueTypes.OnlinerString sAddress
		{
			get
			{
				return _sAddress;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IST_AmsRouteEntry.sAddress
		{
			get
			{
				return sAddress;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowST_AmsRouteEntry.sAddress
		{
			get
			{
				return sAddress;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _eTransport;
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_RouteTransportType))]
		public Vortex.Connector.ValueTypes.OnlinerUInt eTransport
		{
			get
			{
				return _eTransport;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_RouteTransportType))]
		Vortex.Connector.ValueTypes.Online.IOnlineUInt IST_AmsRouteEntry.eTransport
		{
			get
			{
				return eTransport;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_RouteTransportType))]
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowST_AmsRouteEntry.eTransport
		{
			get
			{
				return eTransport;
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

		Vortex.Connector.ValueTypes.Online.IOnlineTime IST_AmsRouteEntry.tTimeout
		{
			get
			{
				return tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowST_AmsRouteEntry.tTimeout
		{
			get
			{
				return tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _dwFlags;
		public Vortex.Connector.ValueTypes.OnlinerDWord dwFlags
		{
			get
			{
				return _dwFlags;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IST_AmsRouteEntry.dwFlags
		{
			get
			{
				return dwFlags;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowST_AmsRouteEntry.dwFlags
		{
			get
			{
				return dwFlags;
			}
		}

		public void LazyOnlineToShadow()
		{
			sName.Shadow = sName.LastValue;
			sAddress.Shadow = sAddress.LastValue;
			eTransport.Shadow = eTransport.LastValue;
			tTimeout.Shadow = tTimeout.LastValue;
			dwFlags.Shadow = dwFlags.LastValue;
		}

		public void LazyShadowToOnline()
		{
			sName.Cyclic = sName.Shadow;
			sAddress.Cyclic = sAddress.Shadow;
			eTransport.Cyclic = eTransport.Shadow;
			tTimeout.Cyclic = tTimeout.Shadow;
			dwFlags.Cyclic = dwFlags.Shadow;
		}

		public PlainST_AmsRouteEntry CreatePlainerType()
		{
			var cloned = new PlainST_AmsRouteEntry();
			return cloned;
		}

		protected PlainST_AmsRouteEntry CreatePlainerType(PlainST_AmsRouteEntry cloned)
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainST_AmsRouteEntry source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainST_AmsRouteEntry source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainST_AmsRouteEntry source)
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

		public ST_AmsRouteEntry(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_sName = @Connector.Online.Adapter.CreateSTRING(this, "", "sName");
			_sAddress = @Connector.Online.Adapter.CreateSTRING(this, "", "sAddress");
			_eTransport = @Connector.Online.Adapter.CreateUINT(this, "", "eTransport");
			_tTimeout = @Connector.Online.Adapter.CreateTIME(this, "", "tTimeout");
			_dwFlags = @Connector.Online.Adapter.CreateDWORD(this, "", "dwFlags");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public ST_AmsRouteEntry()
		{
			PexPreConstructorParameterless();
			_sName = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_sAddress = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_eTransport = Vortex.Connector.IConnectorFactory.CreateUINT();
			_tTimeout = Vortex.Connector.IConnectorFactory.CreateTIME();
			_dwFlags = Vortex.Connector.IConnectorFactory.CreateDWORD();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IST_AmsRouteEntry : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString sName
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString sAddress
		{
			get;
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_RouteTransportType))]
		Vortex.Connector.ValueTypes.Online.IOnlineUInt eTransport
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime tTimeout
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord dwFlags
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainST_AmsRouteEntry CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainST_AmsRouteEntry source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainST_AmsRouteEntry source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowST_AmsRouteEntry : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString sName
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString sAddress
		{
			get;
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_RouteTransportType))]
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt eTransport
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime tTimeout
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord dwFlags
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainST_AmsRouteEntry CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainST_AmsRouteEntry source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainST_AmsRouteEntry : Vortex.Connector.IPlain
	{
		System.String _sName;
		public System.String sName
		{
			get
			{
				return _sName;
			}

			set
			{
				_sName = value;
			}
		}

		System.String _sAddress;
		public System.String sAddress
		{
			get
			{
				return _sAddress;
			}

			set
			{
				_sAddress = value;
			}
		}

		System.UInt16 _eTransport;
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_RouteTransportType))]
		public System.UInt16 eTransport
		{
			get
			{
				return _eTransport;
			}

			set
			{
				_eTransport = value;
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

		System.UInt32 _dwFlags;
		public System.UInt32 dwFlags
		{
			get
			{
				return _dwFlags;
			}

			set
			{
				_dwFlags = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.ST_AmsRouteEntry target)
		{
			target.sName.Cyclic = sName;
			target.sAddress.Cyclic = sAddress;
			target.eTransport.Cyclic = eTransport;
			target.tTimeout.Cyclic = tTimeout;
			target.dwFlags.Cyclic = dwFlags;
		}

		public void CopyPlainToCyclic(Tc2_Utilities.IST_AmsRouteEntry target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.ST_AmsRouteEntry)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.ST_AmsRouteEntry target)
		{
			target.sName.Shadow = sName;
			target.sAddress.Shadow = sAddress;
			target.eTransport.Shadow = eTransport;
			target.tTimeout.Shadow = tTimeout;
			target.dwFlags.Shadow = dwFlags;
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowST_AmsRouteEntry target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.ST_AmsRouteEntry)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.ST_AmsRouteEntry source)
		{
			sName = source.sName.LastValue;
			sAddress = source.sAddress.LastValue;
			eTransport = source.eTransport.LastValue;
			tTimeout = source.tTimeout.LastValue;
			dwFlags = source.dwFlags.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Utilities.IST_AmsRouteEntry source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.ST_AmsRouteEntry)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.ST_AmsRouteEntry source)
		{
			sName = source.sName.Shadow;
			sAddress = source.sAddress.Shadow;
			eTransport = source.eTransport.Shadow;
			tTimeout = source.tTimeout.Shadow;
			dwFlags = source.dwFlags.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowST_AmsRouteEntry source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.ST_AmsRouteEntry)source);
		}

		public PlainST_AmsRouteEntry()
		{
		}
	}
}