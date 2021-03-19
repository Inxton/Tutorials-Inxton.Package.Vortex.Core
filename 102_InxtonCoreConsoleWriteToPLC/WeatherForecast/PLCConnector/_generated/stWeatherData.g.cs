using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace PLC
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stWeatherData", "PLC", TypeComplexityEnum.Complex)]
	public partial class stWeatherData : Vortex.Connector.IVortexObject, IstWeatherData, IShadowstWeatherData, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerDateTime _sunrise;
		public Vortex.Connector.ValueTypes.OnlinerDateTime sunrise
		{
			get
			{
				return _sunrise;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime IstWeatherData.sunrise
		{
			get
			{
				return sunrise;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime IShadowstWeatherData.sunrise
		{
			get
			{
				return sunrise;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDateTime _sunset;
		public Vortex.Connector.ValueTypes.OnlinerDateTime sunset
		{
			get
			{
				return _sunset;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime IstWeatherData.sunset
		{
			get
			{
				return sunset;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime IShadowstWeatherData.sunset
		{
			get
			{
				return sunset;
			}
		}

		public stForecast[] Forecast
		{
			get;
			set;
		}

		IstForecast[] IstWeatherData.Forecast
		{
			get
			{
				return Forecast;
			}

			set
			{
				Forecast = (stForecast[])value;
			}
		}

		IShadowstForecast[] IShadowstWeatherData.Forecast
		{
			get
			{
				return Forecast;
			}
		}

		public void LazyOnlineToShadow()
		{
			sunrise.Shadow = sunrise.LastValue;
			sunset.Shadow = sunset.LastValue;
			Vortex.Connector.BuilderHelpers.Arrays.CopyCyclicToShadowComplex<stForecast>(Forecast);
		}

		public void LazyShadowToOnline()
		{
			sunrise.Cyclic = sunrise.Shadow;
			sunset.Cyclic = sunset.Shadow;
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToCyclicComplex<stForecast>(Forecast);
		}

		public PlainstWeatherData CreatePlainerType()
		{
			var cloned = new PlainstWeatherData();
			cloned.Forecast = new PlainstForecast[40];
			Vortex.Connector.BuilderHelpers.Arrays.CreatePlainerType<PlainstForecast>(cloned.Forecast);
			return cloned;
		}

		protected PlainstWeatherData CreatePlainerType(PlainstWeatherData cloned)
		{
			cloned.Forecast = new PlainstForecast[40];
			Vortex.Connector.BuilderHelpers.Arrays.CreatePlainerType<PlainstForecast>(cloned.Forecast);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
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

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

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

		public void FlushPlainToOnline(PLC.PlainstWeatherData source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(PLC.PlainstWeatherData source)
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

		public void FlushOnlineToPlain(PLC.PlainstWeatherData source)
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

		public stWeatherData(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_sunrise = @Connector.Online.Adapter.CreateDATE_TIME(this, "", "sunrise");
			_sunset = @Connector.Online.Adapter.CreateDATE_TIME(this, "", "sunset");
			Forecast = new stForecast[40];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(Forecast, this, "", "Forecast", (p, rt, st) => new stForecast(p, rt, st));
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stWeatherData()
		{
			PexPreConstructorParameterless();
			_sunrise = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			_sunset = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			Forecast = new stForecast[40];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(Forecast, () => new stForecast());
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstWeatherData
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstWeatherData()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstWeatherData : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineDateTime sunrise
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime sunset
		{
			get;
		}

		IstForecast[] Forecast
		{
			get;
			set;
		}

		System.String AttributeName
		{
			get;
		}

		PLC.PlainstWeatherData CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(PLC.PlainstWeatherData source);
		void FlushOnlineToPlain(PLC.PlainstWeatherData source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstWeatherData : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime sunrise
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime sunset
		{
			get;
		}

		IShadowstForecast[] Forecast
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		PLC.PlainstWeatherData CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(PLC.PlainstWeatherData source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstWeatherData : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.DateTime _sunrise;
		public System.DateTime sunrise
		{
			get
			{
				return _sunrise;
			}

			set
			{
				if (_sunrise != value)
				{
					_sunrise = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(sunrise)));
				}
			}
		}

		System.DateTime _sunset;
		public System.DateTime sunset
		{
			get
			{
				return _sunset;
			}

			set
			{
				if (_sunset != value)
				{
					_sunset = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(sunset)));
				}
			}
		}

		public PlainstForecast[] Forecast
		{
			get;
			set;
		}

		public void CopyPlainToCyclic(PLC.stWeatherData target)
		{
			target.sunrise.Cyclic = sunrise;
			target.sunset.Cyclic = sunset;
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToOnline<PlainstForecast, stForecast>(Forecast, target.Forecast);
		}

		public void CopyPlainToCyclic(PLC.IstWeatherData target)
		{
			this.CopyPlainToCyclic((PLC.stWeatherData)target);
		}

		public void CopyPlainToShadow(PLC.stWeatherData target)
		{
			target.sunrise.Shadow = sunrise;
			target.sunset.Shadow = sunset;
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToShadow<PlainstForecast, stForecast>(Forecast, target.Forecast);
		}

		public void CopyPlainToShadow(PLC.IShadowstWeatherData target)
		{
			this.CopyPlainToShadow((PLC.stWeatherData)target);
		}

		public void CopyCyclicToPlain(PLC.stWeatherData source)
		{
			sunrise = source.sunrise.LastValue;
			sunset = source.sunset.LastValue;
			Vortex.Connector.BuilderHelpers.Arrays.CopyOnlineToPlain<stForecast, PlainstForecast>(source.Forecast, Forecast);
		}

		public void CopyCyclicToPlain(PLC.IstWeatherData source)
		{
			this.CopyCyclicToPlain((PLC.stWeatherData)source);
		}

		public void CopyShadowToPlain(PLC.stWeatherData source)
		{
			sunrise = source.sunrise.Shadow;
			sunset = source.sunset.Shadow;
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToPlain<stForecast, PlainstForecast>(source.Forecast, Forecast);
		}

		public void CopyShadowToPlain(PLC.IShadowstWeatherData source)
		{
			this.CopyShadowToPlain((PLC.stWeatherData)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstWeatherData()
		{
			Forecast = new PlainstForecast[40];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiatePlainerType<PlainstForecast>(Forecast);
		}
	}
}