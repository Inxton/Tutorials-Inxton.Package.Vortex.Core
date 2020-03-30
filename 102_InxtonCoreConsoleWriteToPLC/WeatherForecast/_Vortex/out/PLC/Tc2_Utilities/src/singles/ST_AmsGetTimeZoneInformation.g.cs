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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "ST_AmsGetTimeZoneInformation", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class ST_AmsGetTimeZoneInformation : Vortex.Connector.IVortexObject, IST_AmsGetTimeZoneInformation, IShadowST_AmsGetTimeZoneInformation, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Tc2_Utilities.ST_TimeZoneInformation _tzInfo;
		internal Tc2_Utilities.ST_TimeZoneInformation tzInfo
		{
			get
			{
				return _tzInfo;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _apiResult;
		public Vortex.Connector.ValueTypes.OnlinerDWord apiResult
		{
			get
			{
				return _apiResult;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IST_AmsGetTimeZoneInformation.apiResult
		{
			get
			{
				return apiResult;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowST_AmsGetTimeZoneInformation.apiResult
		{
			get
			{
				return apiResult;
			}
		}

		public void LazyOnlineToShadow()
		{
			apiResult.Shadow = apiResult.LastValue;
		}

		public void LazyShadowToOnline()
		{
			apiResult.Cyclic = apiResult.Shadow;
		}

		public PlainST_AmsGetTimeZoneInformation CreatePlainerType()
		{
			var cloned = new PlainST_AmsGetTimeZoneInformation();
			cloned.tzInfo = tzInfo.CreatePlainerType();
			return cloned;
		}

		protected PlainST_AmsGetTimeZoneInformation CreatePlainerType(PlainST_AmsGetTimeZoneInformation cloned)
		{
			cloned.tzInfo = tzInfo.CreatePlainerType();
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainST_AmsGetTimeZoneInformation source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainST_AmsGetTimeZoneInformation source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainST_AmsGetTimeZoneInformation source)
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

		public ST_AmsGetTimeZoneInformation(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_tzInfo = new Tc2_Utilities.ST_TimeZoneInformation(this, "", "tzInfo");
			_apiResult = @Connector.Online.Adapter.CreateDWORD(this, "", "apiResult");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public ST_AmsGetTimeZoneInformation()
		{
			PexPreConstructorParameterless();
			_tzInfo = new Tc2_Utilities.ST_TimeZoneInformation();
			_apiResult = Vortex.Connector.IConnectorFactory.CreateDWORD();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IST_AmsGetTimeZoneInformation : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineDWord apiResult
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainST_AmsGetTimeZoneInformation CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainST_AmsGetTimeZoneInformation source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainST_AmsGetTimeZoneInformation source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowST_AmsGetTimeZoneInformation : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowDWord apiResult
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainST_AmsGetTimeZoneInformation CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainST_AmsGetTimeZoneInformation source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainST_AmsGetTimeZoneInformation : Vortex.Connector.IPlain
	{
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

		System.UInt32 _apiResult;
		public System.UInt32 apiResult
		{
			get
			{
				return _apiResult;
			}

			set
			{
				_apiResult = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.ST_AmsGetTimeZoneInformation target)
		{
			tzInfo.CopyPlainToCyclic(target.tzInfo);
			target.apiResult.Cyclic = apiResult;
		}

		public void CopyPlainToCyclic(Tc2_Utilities.IST_AmsGetTimeZoneInformation target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.ST_AmsGetTimeZoneInformation)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.ST_AmsGetTimeZoneInformation target)
		{
			tzInfo.CopyPlainToShadow(target.tzInfo);
			target.apiResult.Shadow = apiResult;
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowST_AmsGetTimeZoneInformation target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.ST_AmsGetTimeZoneInformation)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.ST_AmsGetTimeZoneInformation source)
		{
			tzInfo.CopyCyclicToPlain(source.tzInfo);
			apiResult = source.apiResult.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Utilities.IST_AmsGetTimeZoneInformation source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.ST_AmsGetTimeZoneInformation)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.ST_AmsGetTimeZoneInformation source)
		{
			tzInfo.CopyShadowToPlain(source.tzInfo);
			apiResult = source.apiResult.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowST_AmsGetTimeZoneInformation source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.ST_AmsGetTimeZoneInformation)source);
		}

		public PlainST_AmsGetTimeZoneInformation()
		{
			_tzInfo = new Tc2_Utilities.PlainST_TimeZoneInformation();
		}
	}
}