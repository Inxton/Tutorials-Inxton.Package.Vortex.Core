using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace PLC
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MAIN", "PLC", TypeComplexityEnum.Complex)]
	public partial class MAIN : Vortex.Connector.IVortexObject, IMAIN, IShadowMAIN, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
				return PLCTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		stWeatherData _WeatherData;
		public stWeatherData WeatherData
		{
			get
			{
				return _WeatherData;
			}
		}

		IstWeatherData IMAIN.WeatherData
		{
			get
			{
				return WeatherData;
			}
		}

		IShadowstWeatherData IShadowMAIN.WeatherData
		{
			get
			{
				return WeatherData;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _bGetWeatherData;
		public Vortex.Connector.ValueTypes.OnlinerBool bGetWeatherData
		{
			get
			{
				return _bGetWeatherData;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IMAIN.bGetWeatherData
		{
			get
			{
				return bGetWeatherData;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowMAIN.bGetWeatherData
		{
			get
			{
				return bGetWeatherData;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDateTime _actDateTime;
		public Vortex.Connector.ValueTypes.OnlinerDateTime actDateTime
		{
			get
			{
				return _actDateTime;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime IMAIN.actDateTime
		{
			get
			{
				return actDateTime;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime IShadowMAIN.actDateTime
		{
			get
			{
				return actDateTime;
			}
		}

		public void LazyOnlineToShadow()
		{
			WeatherData.LazyOnlineToShadow();
			bGetWeatherData.Shadow = bGetWeatherData.LastValue;
			actDateTime.Shadow = actDateTime.LastValue;
		}

		public void LazyShadowToOnline()
		{
			WeatherData.LazyShadowToOnline();
			bGetWeatherData.Cyclic = bGetWeatherData.Shadow;
			actDateTime.Cyclic = actDateTime.Shadow;
		}

		public PlainMAIN CreatePlainerType()
		{
			var cloned = new PlainMAIN();
			cloned.WeatherData = WeatherData.CreatePlainerType();
			return cloned;
		}

		protected PlainMAIN CreatePlainerType(PlainMAIN cloned)
		{
			cloned.WeatherData = WeatherData.CreatePlainerType();
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

		public void FlushPlainToOnline(PLC.PlainMAIN source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(PLC.PlainMAIN source)
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

		public void FlushOnlineToPlain(PLC.PlainMAIN source)
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
				return PLCTwinController.Translator.Translate(_AttributeName).Interpolate(this);
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

		public MAIN(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_WeatherData = new stWeatherData(this, "", "WeatherData");
			_bGetWeatherData = @Connector.Online.Adapter.CreateBOOL(this, "", "bGetWeatherData");
			_actDateTime = @Connector.Online.Adapter.CreateDATE_TIME(this, "", "actDateTime");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public MAIN()
		{
			PexPreConstructorParameterless();
			_WeatherData = new stWeatherData();
			_bGetWeatherData = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_actDateTime = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcMAIN
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcMAIN()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IMAIN : Vortex.Connector.IVortexOnlineObject
	{
		IstWeatherData WeatherData
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool bGetWeatherData
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime actDateTime
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		PLC.PlainMAIN CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(PLC.PlainMAIN source);
		void FlushOnlineToPlain(PLC.PlainMAIN source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowMAIN : Vortex.Connector.IVortexShadowObject
	{
		IShadowstWeatherData WeatherData
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool bGetWeatherData
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime actDateTime
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		PLC.PlainMAIN CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(PLC.PlainMAIN source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMAIN : Vortex.Connector.IPlain
	{
		PlainstWeatherData _WeatherData;
		public PlainstWeatherData WeatherData
		{
			get
			{
				return _WeatherData;
			}

			set
			{
				_WeatherData = value;
			}
		}

		System.Boolean _bGetWeatherData;
		public System.Boolean bGetWeatherData
		{
			get
			{
				return _bGetWeatherData;
			}

			set
			{
				_bGetWeatherData = value;
			}
		}

		System.DateTime _actDateTime;
		public System.DateTime actDateTime
		{
			get
			{
				return _actDateTime;
			}

			set
			{
				_actDateTime = value;
			}
		}

		public void CopyPlainToCyclic(PLC.MAIN target)
		{
			WeatherData.CopyPlainToCyclic(target.WeatherData);
			target.bGetWeatherData.Cyclic = bGetWeatherData;
			target.actDateTime.Cyclic = actDateTime;
		}

		public void CopyPlainToCyclic(PLC.IMAIN target)
		{
			this.CopyPlainToCyclic((PLC.MAIN)target);
		}

		public void CopyPlainToShadow(PLC.MAIN target)
		{
			WeatherData.CopyPlainToShadow(target.WeatherData);
			target.bGetWeatherData.Shadow = bGetWeatherData;
			target.actDateTime.Shadow = actDateTime;
		}

		public void CopyPlainToShadow(PLC.IShadowMAIN target)
		{
			this.CopyPlainToShadow((PLC.MAIN)target);
		}

		public void CopyCyclicToPlain(PLC.MAIN source)
		{
			WeatherData.CopyCyclicToPlain(source.WeatherData);
			bGetWeatherData = source.bGetWeatherData.LastValue;
			actDateTime = source.actDateTime.LastValue;
		}

		public void CopyCyclicToPlain(PLC.IMAIN source)
		{
			this.CopyCyclicToPlain((PLC.MAIN)source);
		}

		public void CopyShadowToPlain(PLC.MAIN source)
		{
			WeatherData.CopyShadowToPlain(source.WeatherData);
			bGetWeatherData = source.bGetWeatherData.Shadow;
			actDateTime = source.actDateTime.Shadow;
		}

		public void CopyShadowToPlain(PLC.IShadowMAIN source)
		{
			this.CopyShadowToPlain((PLC.MAIN)source);
		}

		public PlainMAIN()
		{
			_WeatherData = new PlainstWeatherData();
		}
	}
}