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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "ST_TimeZoneInformation", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class ST_TimeZoneInformation : Vortex.Connector.IVortexObject, IST_TimeZoneInformation, IShadowST_TimeZoneInformation, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerDInt _bias;
		public Vortex.Connector.ValueTypes.OnlinerDInt bias
		{
			get
			{
				return _bias;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt IST_TimeZoneInformation.bias
		{
			get
			{
				return bias;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowST_TimeZoneInformation.bias
		{
			get
			{
				return bias;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _standardName;
		public Vortex.Connector.ValueTypes.OnlinerString standardName
		{
			get
			{
				return _standardName;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IST_TimeZoneInformation.standardName
		{
			get
			{
				return standardName;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowST_TimeZoneInformation.standardName
		{
			get
			{
				return standardName;
			}
		}

		Tc2_Utilities.TIMESTRUCT _standardDate;
		internal Tc2_Utilities.TIMESTRUCT standardDate
		{
			get
			{
				return _standardDate;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _standardBias;
		public Vortex.Connector.ValueTypes.OnlinerDInt standardBias
		{
			get
			{
				return _standardBias;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt IST_TimeZoneInformation.standardBias
		{
			get
			{
				return standardBias;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowST_TimeZoneInformation.standardBias
		{
			get
			{
				return standardBias;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _daylightName;
		public Vortex.Connector.ValueTypes.OnlinerString daylightName
		{
			get
			{
				return _daylightName;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IST_TimeZoneInformation.daylightName
		{
			get
			{
				return daylightName;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowST_TimeZoneInformation.daylightName
		{
			get
			{
				return daylightName;
			}
		}

		Tc2_Utilities.TIMESTRUCT _daylightDate;
		internal Tc2_Utilities.TIMESTRUCT daylightDate
		{
			get
			{
				return _daylightDate;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _daylightBias;
		public Vortex.Connector.ValueTypes.OnlinerDInt daylightBias
		{
			get
			{
				return _daylightBias;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt IST_TimeZoneInformation.daylightBias
		{
			get
			{
				return daylightBias;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowST_TimeZoneInformation.daylightBias
		{
			get
			{
				return daylightBias;
			}
		}

		public void LazyOnlineToShadow()
		{
			bias.Shadow = bias.LastValue;
			standardName.Shadow = standardName.LastValue;
			standardBias.Shadow = standardBias.LastValue;
			daylightName.Shadow = daylightName.LastValue;
			daylightBias.Shadow = daylightBias.LastValue;
		}

		public void LazyShadowToOnline()
		{
			bias.Cyclic = bias.Shadow;
			standardName.Cyclic = standardName.Shadow;
			standardBias.Cyclic = standardBias.Shadow;
			daylightName.Cyclic = daylightName.Shadow;
			daylightBias.Cyclic = daylightBias.Shadow;
		}

		public PlainST_TimeZoneInformation CreatePlainerType()
		{
			var cloned = new PlainST_TimeZoneInformation();
			cloned.standardDate = standardDate.CreatePlainerType();
			cloned.daylightDate = daylightDate.CreatePlainerType();
			return cloned;
		}

		protected PlainST_TimeZoneInformation CreatePlainerType(PlainST_TimeZoneInformation cloned)
		{
			cloned.standardDate = standardDate.CreatePlainerType();
			cloned.daylightDate = daylightDate.CreatePlainerType();
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainST_TimeZoneInformation source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainST_TimeZoneInformation source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainST_TimeZoneInformation source)
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

		public ST_TimeZoneInformation(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_bias = @Connector.Online.Adapter.CreateDINT(this, "", "bias");
			_standardName = @Connector.Online.Adapter.CreateSTRING(this, "", "standardName");
			_standardDate = new Tc2_Utilities.TIMESTRUCT(this, "", "standardDate");
			_standardBias = @Connector.Online.Adapter.CreateDINT(this, "", "standardBias");
			_daylightName = @Connector.Online.Adapter.CreateSTRING(this, "", "daylightName");
			_daylightDate = new Tc2_Utilities.TIMESTRUCT(this, "", "daylightDate");
			_daylightBias = @Connector.Online.Adapter.CreateDINT(this, "", "daylightBias");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public ST_TimeZoneInformation()
		{
			PexPreConstructorParameterless();
			_bias = Vortex.Connector.IConnectorFactory.CreateDINT();
			_standardName = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_standardDate = new Tc2_Utilities.TIMESTRUCT();
			_standardBias = Vortex.Connector.IConnectorFactory.CreateDINT();
			_daylightName = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_daylightDate = new Tc2_Utilities.TIMESTRUCT();
			_daylightBias = Vortex.Connector.IConnectorFactory.CreateDINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IST_TimeZoneInformation : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineDInt bias
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString standardName
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt standardBias
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString daylightName
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt daylightBias
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainST_TimeZoneInformation CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainST_TimeZoneInformation source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainST_TimeZoneInformation source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowST_TimeZoneInformation : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt bias
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString standardName
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt standardBias
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString daylightName
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt daylightBias
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainST_TimeZoneInformation CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainST_TimeZoneInformation source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainST_TimeZoneInformation : Vortex.Connector.IPlain
	{
		System.Int32 _bias;
		public System.Int32 bias
		{
			get
			{
				return _bias;
			}

			set
			{
				_bias = value;
			}
		}

		System.String _standardName;
		public System.String standardName
		{
			get
			{
				return _standardName;
			}

			set
			{
				_standardName = value;
			}
		}

		Tc2_Utilities.PlainTIMESTRUCT _standardDate;
		internal Tc2_Utilities.PlainTIMESTRUCT standardDate
		{
			get
			{
				return _standardDate;
			}

			set
			{
				_standardDate = value;
			}
		}

		System.Int32 _standardBias;
		public System.Int32 standardBias
		{
			get
			{
				return _standardBias;
			}

			set
			{
				_standardBias = value;
			}
		}

		System.String _daylightName;
		public System.String daylightName
		{
			get
			{
				return _daylightName;
			}

			set
			{
				_daylightName = value;
			}
		}

		Tc2_Utilities.PlainTIMESTRUCT _daylightDate;
		internal Tc2_Utilities.PlainTIMESTRUCT daylightDate
		{
			get
			{
				return _daylightDate;
			}

			set
			{
				_daylightDate = value;
			}
		}

		System.Int32 _daylightBias;
		public System.Int32 daylightBias
		{
			get
			{
				return _daylightBias;
			}

			set
			{
				_daylightBias = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.ST_TimeZoneInformation target)
		{
			target.bias.Cyclic = bias;
			target.standardName.Cyclic = standardName;
			standardDate.CopyPlainToCyclic(target.standardDate);
			target.standardBias.Cyclic = standardBias;
			target.daylightName.Cyclic = daylightName;
			daylightDate.CopyPlainToCyclic(target.daylightDate);
			target.daylightBias.Cyclic = daylightBias;
		}

		public void CopyPlainToCyclic(Tc2_Utilities.IST_TimeZoneInformation target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.ST_TimeZoneInformation)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.ST_TimeZoneInformation target)
		{
			target.bias.Shadow = bias;
			target.standardName.Shadow = standardName;
			standardDate.CopyPlainToShadow(target.standardDate);
			target.standardBias.Shadow = standardBias;
			target.daylightName.Shadow = daylightName;
			daylightDate.CopyPlainToShadow(target.daylightDate);
			target.daylightBias.Shadow = daylightBias;
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowST_TimeZoneInformation target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.ST_TimeZoneInformation)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.ST_TimeZoneInformation source)
		{
			bias = source.bias.LastValue;
			standardName = source.standardName.LastValue;
			standardDate.CopyCyclicToPlain(source.standardDate);
			standardBias = source.standardBias.LastValue;
			daylightName = source.daylightName.LastValue;
			daylightDate.CopyCyclicToPlain(source.daylightDate);
			daylightBias = source.daylightBias.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Utilities.IST_TimeZoneInformation source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.ST_TimeZoneInformation)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.ST_TimeZoneInformation source)
		{
			bias = source.bias.Shadow;
			standardName = source.standardName.Shadow;
			standardDate.CopyShadowToPlain(source.standardDate);
			standardBias = source.standardBias.Shadow;
			daylightName = source.daylightName.Shadow;
			daylightDate.CopyShadowToPlain(source.daylightDate);
			daylightBias = source.daylightBias.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowST_TimeZoneInformation source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.ST_TimeZoneInformation)source);
		}

		public PlainST_TimeZoneInformation()
		{
			_standardDate = new Tc2_Utilities.PlainTIMESTRUCT();
			_daylightDate = new Tc2_Utilities.PlainTIMESTRUCT();
		}
	}
}