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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "T_ULARGE_INTEGER", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class T_ULARGE_INTEGER : Vortex.Connector.IVortexObject, IT_ULARGE_INTEGER, IShadowT_ULARGE_INTEGER, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerDWord _dwLowPart;
		public Vortex.Connector.ValueTypes.OnlinerDWord dwLowPart
		{
			get
			{
				return _dwLowPart;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IT_ULARGE_INTEGER.dwLowPart
		{
			get
			{
				return dwLowPart;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowT_ULARGE_INTEGER.dwLowPart
		{
			get
			{
				return dwLowPart;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _dwHighPart;
		public Vortex.Connector.ValueTypes.OnlinerDWord dwHighPart
		{
			get
			{
				return _dwHighPart;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IT_ULARGE_INTEGER.dwHighPart
		{
			get
			{
				return dwHighPart;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowT_ULARGE_INTEGER.dwHighPart
		{
			get
			{
				return dwHighPart;
			}
		}

		public void LazyOnlineToShadow()
		{
			dwLowPart.Shadow = dwLowPart.LastValue;
			dwHighPart.Shadow = dwHighPart.LastValue;
		}

		public void LazyShadowToOnline()
		{
			dwLowPart.Cyclic = dwLowPart.Shadow;
			dwHighPart.Cyclic = dwHighPart.Shadow;
		}

		public PlainT_ULARGE_INTEGER CreatePlainerType()
		{
			var cloned = new PlainT_ULARGE_INTEGER();
			return cloned;
		}

		protected PlainT_ULARGE_INTEGER CreatePlainerType(PlainT_ULARGE_INTEGER cloned)
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainT_ULARGE_INTEGER source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainT_ULARGE_INTEGER source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainT_ULARGE_INTEGER source)
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

		public T_ULARGE_INTEGER(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_dwLowPart = @Connector.Online.Adapter.CreateDWORD(this, "", "dwLowPart");
			_dwHighPart = @Connector.Online.Adapter.CreateDWORD(this, "", "dwHighPart");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public T_ULARGE_INTEGER()
		{
			PexPreConstructorParameterless();
			_dwLowPart = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_dwHighPart = Vortex.Connector.IConnectorFactory.CreateDWORD();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IT_ULARGE_INTEGER : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineDWord dwLowPart
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord dwHighPart
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainT_ULARGE_INTEGER CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainT_ULARGE_INTEGER source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainT_ULARGE_INTEGER source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowT_ULARGE_INTEGER : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowDWord dwLowPart
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord dwHighPart
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainT_ULARGE_INTEGER CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainT_ULARGE_INTEGER source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainT_ULARGE_INTEGER : Vortex.Connector.IPlain
	{
		System.UInt32 _dwLowPart;
		public System.UInt32 dwLowPart
		{
			get
			{
				return _dwLowPart;
			}

			set
			{
				_dwLowPart = value;
			}
		}

		System.UInt32 _dwHighPart;
		public System.UInt32 dwHighPart
		{
			get
			{
				return _dwHighPart;
			}

			set
			{
				_dwHighPart = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.T_ULARGE_INTEGER target)
		{
			target.dwLowPart.Cyclic = dwLowPart;
			target.dwHighPart.Cyclic = dwHighPart;
		}

		public void CopyPlainToCyclic(Tc2_Utilities.IT_ULARGE_INTEGER target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.T_ULARGE_INTEGER)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.T_ULARGE_INTEGER target)
		{
			target.dwLowPart.Shadow = dwLowPart;
			target.dwHighPart.Shadow = dwHighPart;
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowT_ULARGE_INTEGER target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.T_ULARGE_INTEGER)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.T_ULARGE_INTEGER source)
		{
			dwLowPart = source.dwLowPart.LastValue;
			dwHighPart = source.dwHighPart.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Utilities.IT_ULARGE_INTEGER source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.T_ULARGE_INTEGER)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.T_ULARGE_INTEGER source)
		{
			dwLowPart = source.dwLowPart.Shadow;
			dwHighPart = source.dwHighPart.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowT_ULARGE_INTEGER source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.T_ULARGE_INTEGER)source);
		}

		public PlainT_ULARGE_INTEGER()
		{
		}
	}
}