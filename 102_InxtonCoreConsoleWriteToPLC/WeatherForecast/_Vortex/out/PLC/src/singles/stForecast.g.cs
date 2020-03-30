using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace PLC
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stForecast", "PLC", TypeComplexityEnum.Complex)]
	public partial class stForecast : Vortex.Connector.IVortexObject, IstForecast, IShadowstForecast, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerDateTime _timeFrom;
		public Vortex.Connector.ValueTypes.OnlinerDateTime timeFrom
		{
			get
			{
				return _timeFrom;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime IstForecast.timeFrom
		{
			get
			{
				return timeFrom;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime IShadowstForecast.timeFrom
		{
			get
			{
				return timeFrom;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDateTime _timeTo;
		public Vortex.Connector.ValueTypes.OnlinerDateTime timeTo
		{
			get
			{
				return _timeTo;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime IstForecast.timeTo
		{
			get
			{
				return timeTo;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime IShadowstForecast.timeTo
		{
			get
			{
				return timeTo;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _precipitation_unit;
		public Vortex.Connector.ValueTypes.OnlinerString precipitation_unit
		{
			get
			{
				return _precipitation_unit;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstForecast.precipitation_unit
		{
			get
			{
				return precipitation_unit;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstForecast.precipitation_unit
		{
			get
			{
				return precipitation_unit;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _precipitation_value;
		public Vortex.Connector.ValueTypes.OnlinerReal precipitation_value
		{
			get
			{
				return _precipitation_value;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstForecast.precipitation_value
		{
			get
			{
				return precipitation_value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstForecast.precipitation_value
		{
			get
			{
				return precipitation_value;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _precipitation_type;
		public Vortex.Connector.ValueTypes.OnlinerString precipitation_type
		{
			get
			{
				return _precipitation_type;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstForecast.precipitation_type
		{
			get
			{
				return precipitation_type;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstForecast.precipitation_type
		{
			get
			{
				return precipitation_type;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _windDirection_value;
		public Vortex.Connector.ValueTypes.OnlinerReal windDirection_value
		{
			get
			{
				return _windDirection_value;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstForecast.windDirection_value
		{
			get
			{
				return windDirection_value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstForecast.windDirection_value
		{
			get
			{
				return windDirection_value;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _windDirection_name;
		public Vortex.Connector.ValueTypes.OnlinerString windDirection_name
		{
			get
			{
				return _windDirection_name;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstForecast.windDirection_name
		{
			get
			{
				return windDirection_name;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstForecast.windDirection_name
		{
			get
			{
				return windDirection_name;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _windSpeed_value;
		public Vortex.Connector.ValueTypes.OnlinerReal windSpeed_value
		{
			get
			{
				return _windSpeed_value;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstForecast.windSpeed_value
		{
			get
			{
				return windSpeed_value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstForecast.windSpeed_value
		{
			get
			{
				return windSpeed_value;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _windSpeed_unit;
		public Vortex.Connector.ValueTypes.OnlinerString windSpeed_unit
		{
			get
			{
				return _windSpeed_unit;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstForecast.windSpeed_unit
		{
			get
			{
				return windSpeed_unit;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstForecast.windSpeed_unit
		{
			get
			{
				return windSpeed_unit;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _windSpeed_name;
		public Vortex.Connector.ValueTypes.OnlinerString windSpeed_name
		{
			get
			{
				return _windSpeed_name;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstForecast.windSpeed_name
		{
			get
			{
				return windSpeed_name;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstForecast.windSpeed_name
		{
			get
			{
				return windSpeed_name;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _temperature_value;
		public Vortex.Connector.ValueTypes.OnlinerReal temperature_value
		{
			get
			{
				return _temperature_value;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstForecast.temperature_value
		{
			get
			{
				return temperature_value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstForecast.temperature_value
		{
			get
			{
				return temperature_value;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _temperature_unit;
		public Vortex.Connector.ValueTypes.OnlinerString temperature_unit
		{
			get
			{
				return _temperature_unit;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstForecast.temperature_unit
		{
			get
			{
				return temperature_unit;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstForecast.temperature_unit
		{
			get
			{
				return temperature_unit;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _temperature_min;
		public Vortex.Connector.ValueTypes.OnlinerReal temperature_min
		{
			get
			{
				return _temperature_min;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstForecast.temperature_min
		{
			get
			{
				return temperature_min;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstForecast.temperature_min
		{
			get
			{
				return temperature_min;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _temperature_max;
		public Vortex.Connector.ValueTypes.OnlinerReal temperature_max
		{
			get
			{
				return _temperature_max;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstForecast.temperature_max
		{
			get
			{
				return temperature_max;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstForecast.temperature_max
		{
			get
			{
				return temperature_max;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _temperature_feel_like;
		public Vortex.Connector.ValueTypes.OnlinerReal temperature_feel_like
		{
			get
			{
				return _temperature_feel_like;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstForecast.temperature_feel_like
		{
			get
			{
				return temperature_feel_like;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstForecast.temperature_feel_like
		{
			get
			{
				return temperature_feel_like;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _pressure_value;
		public Vortex.Connector.ValueTypes.OnlinerReal pressure_value
		{
			get
			{
				return _pressure_value;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstForecast.pressure_value
		{
			get
			{
				return pressure_value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstForecast.pressure_value
		{
			get
			{
				return pressure_value;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _pressure_unit;
		public Vortex.Connector.ValueTypes.OnlinerString pressure_unit
		{
			get
			{
				return _pressure_unit;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstForecast.pressure_unit
		{
			get
			{
				return pressure_unit;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstForecast.pressure_unit
		{
			get
			{
				return pressure_unit;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _humidity_value;
		public Vortex.Connector.ValueTypes.OnlinerReal humidity_value
		{
			get
			{
				return _humidity_value;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstForecast.humidity_value
		{
			get
			{
				return humidity_value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstForecast.humidity_value
		{
			get
			{
				return humidity_value;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _humidity_UNIT;
		public Vortex.Connector.ValueTypes.OnlinerString humidity_UNIT
		{
			get
			{
				return _humidity_UNIT;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstForecast.humidity_UNIT
		{
			get
			{
				return humidity_UNIT;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstForecast.humidity_UNIT
		{
			get
			{
				return humidity_UNIT;
			}
		}

		public void LazyOnlineToShadow()
		{
			timeFrom.Shadow = timeFrom.LastValue;
			timeTo.Shadow = timeTo.LastValue;
			precipitation_unit.Shadow = precipitation_unit.LastValue;
			precipitation_value.Shadow = precipitation_value.LastValue;
			precipitation_type.Shadow = precipitation_type.LastValue;
			windDirection_value.Shadow = windDirection_value.LastValue;
			windDirection_name.Shadow = windDirection_name.LastValue;
			windSpeed_value.Shadow = windSpeed_value.LastValue;
			windSpeed_unit.Shadow = windSpeed_unit.LastValue;
			windSpeed_name.Shadow = windSpeed_name.LastValue;
			temperature_value.Shadow = temperature_value.LastValue;
			temperature_unit.Shadow = temperature_unit.LastValue;
			temperature_min.Shadow = temperature_min.LastValue;
			temperature_max.Shadow = temperature_max.LastValue;
			temperature_feel_like.Shadow = temperature_feel_like.LastValue;
			pressure_value.Shadow = pressure_value.LastValue;
			pressure_unit.Shadow = pressure_unit.LastValue;
			humidity_value.Shadow = humidity_value.LastValue;
			humidity_UNIT.Shadow = humidity_UNIT.LastValue;
		}

		public void LazyShadowToOnline()
		{
			timeFrom.Cyclic = timeFrom.Shadow;
			timeTo.Cyclic = timeTo.Shadow;
			precipitation_unit.Cyclic = precipitation_unit.Shadow;
			precipitation_value.Cyclic = precipitation_value.Shadow;
			precipitation_type.Cyclic = precipitation_type.Shadow;
			windDirection_value.Cyclic = windDirection_value.Shadow;
			windDirection_name.Cyclic = windDirection_name.Shadow;
			windSpeed_value.Cyclic = windSpeed_value.Shadow;
			windSpeed_unit.Cyclic = windSpeed_unit.Shadow;
			windSpeed_name.Cyclic = windSpeed_name.Shadow;
			temperature_value.Cyclic = temperature_value.Shadow;
			temperature_unit.Cyclic = temperature_unit.Shadow;
			temperature_min.Cyclic = temperature_min.Shadow;
			temperature_max.Cyclic = temperature_max.Shadow;
			temperature_feel_like.Cyclic = temperature_feel_like.Shadow;
			pressure_value.Cyclic = pressure_value.Shadow;
			pressure_unit.Cyclic = pressure_unit.Shadow;
			humidity_value.Cyclic = humidity_value.Shadow;
			humidity_UNIT.Cyclic = humidity_UNIT.Shadow;
		}

		public PlainstForecast CreatePlainerType()
		{
			var cloned = new PlainstForecast();
			return cloned;
		}

		protected PlainstForecast CreatePlainerType(PlainstForecast cloned)
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

		public void FlushPlainToOnline(PLC.PlainstForecast source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(PLC.PlainstForecast source)
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

		public void FlushOnlineToPlain(PLC.PlainstForecast source)
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

		public stForecast(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_timeFrom = @Connector.Online.Adapter.CreateDATE_TIME(this, "", "timeFrom");
			_timeTo = @Connector.Online.Adapter.CreateDATE_TIME(this, "", "timeTo");
			_precipitation_unit = @Connector.Online.Adapter.CreateSTRING(this, "", "precipitation_unit");
			_precipitation_value = @Connector.Online.Adapter.CreateREAL(this, "", "precipitation_value");
			_precipitation_type = @Connector.Online.Adapter.CreateSTRING(this, "", "precipitation_type");
			_windDirection_value = @Connector.Online.Adapter.CreateREAL(this, "", "windDirection_value");
			_windDirection_name = @Connector.Online.Adapter.CreateSTRING(this, "", "windDirection_name");
			_windSpeed_value = @Connector.Online.Adapter.CreateREAL(this, "", "windSpeed_value");
			_windSpeed_unit = @Connector.Online.Adapter.CreateSTRING(this, "", "windSpeed_unit");
			_windSpeed_name = @Connector.Online.Adapter.CreateSTRING(this, "", "windSpeed_name");
			_temperature_value = @Connector.Online.Adapter.CreateREAL(this, "", "temperature_value");
			_temperature_unit = @Connector.Online.Adapter.CreateSTRING(this, "", "temperature_unit");
			_temperature_min = @Connector.Online.Adapter.CreateREAL(this, "", "temperature_min");
			_temperature_max = @Connector.Online.Adapter.CreateREAL(this, "", "temperature_max");
			_temperature_feel_like = @Connector.Online.Adapter.CreateREAL(this, "", "temperature_feel_like");
			_pressure_value = @Connector.Online.Adapter.CreateREAL(this, "", "pressure_value");
			_pressure_unit = @Connector.Online.Adapter.CreateSTRING(this, "", "pressure_unit");
			_humidity_value = @Connector.Online.Adapter.CreateREAL(this, "", "humidity_value");
			_humidity_UNIT = @Connector.Online.Adapter.CreateSTRING(this, "", "humidity_UNIT");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public stForecast()
		{
			PexPreConstructorParameterless();
			_timeFrom = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			_timeTo = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			_precipitation_unit = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_precipitation_value = Vortex.Connector.IConnectorFactory.CreateREAL();
			_precipitation_type = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_windDirection_value = Vortex.Connector.IConnectorFactory.CreateREAL();
			_windDirection_name = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_windSpeed_value = Vortex.Connector.IConnectorFactory.CreateREAL();
			_windSpeed_unit = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_windSpeed_name = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_temperature_value = Vortex.Connector.IConnectorFactory.CreateREAL();
			_temperature_unit = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_temperature_min = Vortex.Connector.IConnectorFactory.CreateREAL();
			_temperature_max = Vortex.Connector.IConnectorFactory.CreateREAL();
			_temperature_feel_like = Vortex.Connector.IConnectorFactory.CreateREAL();
			_pressure_value = Vortex.Connector.IConnectorFactory.CreateREAL();
			_pressure_unit = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_humidity_value = Vortex.Connector.IConnectorFactory.CreateREAL();
			_humidity_UNIT = Vortex.Connector.IConnectorFactory.CreateSTRING();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstForecast
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstForecast()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstForecast : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineDateTime timeFrom
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime timeTo
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString precipitation_unit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal precipitation_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString precipitation_type
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal windDirection_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString windDirection_name
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal windSpeed_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString windSpeed_unit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString windSpeed_name
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal temperature_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString temperature_unit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal temperature_min
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal temperature_max
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal temperature_feel_like
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal pressure_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString pressure_unit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal humidity_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString humidity_UNIT
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		PLC.PlainstForecast CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(PLC.PlainstForecast source);
		void FlushOnlineToPlain(PLC.PlainstForecast source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstForecast : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime timeFrom
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime timeTo
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString precipitation_unit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal precipitation_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString precipitation_type
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal windDirection_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString windDirection_name
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal windSpeed_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString windSpeed_unit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString windSpeed_name
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal temperature_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString temperature_unit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal temperature_min
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal temperature_max
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal temperature_feel_like
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal pressure_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString pressure_unit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal humidity_value
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString humidity_UNIT
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		PLC.PlainstForecast CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(PLC.PlainstForecast source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstForecast : Vortex.Connector.IPlain
	{
		System.DateTime _timeFrom;
		public System.DateTime timeFrom
		{
			get
			{
				return _timeFrom;
			}

			set
			{
				_timeFrom = value;
			}
		}

		System.DateTime _timeTo;
		public System.DateTime timeTo
		{
			get
			{
				return _timeTo;
			}

			set
			{
				_timeTo = value;
			}
		}

		System.String _precipitation_unit;
		public System.String precipitation_unit
		{
			get
			{
				return _precipitation_unit;
			}

			set
			{
				_precipitation_unit = value;
			}
		}

		System.Single _precipitation_value;
		public System.Single precipitation_value
		{
			get
			{
				return _precipitation_value;
			}

			set
			{
				_precipitation_value = value;
			}
		}

		System.String _precipitation_type;
		public System.String precipitation_type
		{
			get
			{
				return _precipitation_type;
			}

			set
			{
				_precipitation_type = value;
			}
		}

		System.Single _windDirection_value;
		public System.Single windDirection_value
		{
			get
			{
				return _windDirection_value;
			}

			set
			{
				_windDirection_value = value;
			}
		}

		System.String _windDirection_name;
		public System.String windDirection_name
		{
			get
			{
				return _windDirection_name;
			}

			set
			{
				_windDirection_name = value;
			}
		}

		System.Single _windSpeed_value;
		public System.Single windSpeed_value
		{
			get
			{
				return _windSpeed_value;
			}

			set
			{
				_windSpeed_value = value;
			}
		}

		System.String _windSpeed_unit;
		public System.String windSpeed_unit
		{
			get
			{
				return _windSpeed_unit;
			}

			set
			{
				_windSpeed_unit = value;
			}
		}

		System.String _windSpeed_name;
		public System.String windSpeed_name
		{
			get
			{
				return _windSpeed_name;
			}

			set
			{
				_windSpeed_name = value;
			}
		}

		System.Single _temperature_value;
		public System.Single temperature_value
		{
			get
			{
				return _temperature_value;
			}

			set
			{
				_temperature_value = value;
			}
		}

		System.String _temperature_unit;
		public System.String temperature_unit
		{
			get
			{
				return _temperature_unit;
			}

			set
			{
				_temperature_unit = value;
			}
		}

		System.Single _temperature_min;
		public System.Single temperature_min
		{
			get
			{
				return _temperature_min;
			}

			set
			{
				_temperature_min = value;
			}
		}

		System.Single _temperature_max;
		public System.Single temperature_max
		{
			get
			{
				return _temperature_max;
			}

			set
			{
				_temperature_max = value;
			}
		}

		System.Single _temperature_feel_like;
		public System.Single temperature_feel_like
		{
			get
			{
				return _temperature_feel_like;
			}

			set
			{
				_temperature_feel_like = value;
			}
		}

		System.Single _pressure_value;
		public System.Single pressure_value
		{
			get
			{
				return _pressure_value;
			}

			set
			{
				_pressure_value = value;
			}
		}

		System.String _pressure_unit;
		public System.String pressure_unit
		{
			get
			{
				return _pressure_unit;
			}

			set
			{
				_pressure_unit = value;
			}
		}

		System.Single _humidity_value;
		public System.Single humidity_value
		{
			get
			{
				return _humidity_value;
			}

			set
			{
				_humidity_value = value;
			}
		}

		System.String _humidity_UNIT;
		public System.String humidity_UNIT
		{
			get
			{
				return _humidity_UNIT;
			}

			set
			{
				_humidity_UNIT = value;
			}
		}

		public void CopyPlainToCyclic(PLC.stForecast target)
		{
			target.timeFrom.Cyclic = timeFrom;
			target.timeTo.Cyclic = timeTo;
			target.precipitation_unit.Cyclic = precipitation_unit;
			target.precipitation_value.Cyclic = precipitation_value;
			target.precipitation_type.Cyclic = precipitation_type;
			target.windDirection_value.Cyclic = windDirection_value;
			target.windDirection_name.Cyclic = windDirection_name;
			target.windSpeed_value.Cyclic = windSpeed_value;
			target.windSpeed_unit.Cyclic = windSpeed_unit;
			target.windSpeed_name.Cyclic = windSpeed_name;
			target.temperature_value.Cyclic = temperature_value;
			target.temperature_unit.Cyclic = temperature_unit;
			target.temperature_min.Cyclic = temperature_min;
			target.temperature_max.Cyclic = temperature_max;
			target.temperature_feel_like.Cyclic = temperature_feel_like;
			target.pressure_value.Cyclic = pressure_value;
			target.pressure_unit.Cyclic = pressure_unit;
			target.humidity_value.Cyclic = humidity_value;
			target.humidity_UNIT.Cyclic = humidity_UNIT;
		}

		public void CopyPlainToCyclic(PLC.IstForecast target)
		{
			this.CopyPlainToCyclic((PLC.stForecast)target);
		}

		public void CopyPlainToShadow(PLC.stForecast target)
		{
			target.timeFrom.Shadow = timeFrom;
			target.timeTo.Shadow = timeTo;
			target.precipitation_unit.Shadow = precipitation_unit;
			target.precipitation_value.Shadow = precipitation_value;
			target.precipitation_type.Shadow = precipitation_type;
			target.windDirection_value.Shadow = windDirection_value;
			target.windDirection_name.Shadow = windDirection_name;
			target.windSpeed_value.Shadow = windSpeed_value;
			target.windSpeed_unit.Shadow = windSpeed_unit;
			target.windSpeed_name.Shadow = windSpeed_name;
			target.temperature_value.Shadow = temperature_value;
			target.temperature_unit.Shadow = temperature_unit;
			target.temperature_min.Shadow = temperature_min;
			target.temperature_max.Shadow = temperature_max;
			target.temperature_feel_like.Shadow = temperature_feel_like;
			target.pressure_value.Shadow = pressure_value;
			target.pressure_unit.Shadow = pressure_unit;
			target.humidity_value.Shadow = humidity_value;
			target.humidity_UNIT.Shadow = humidity_UNIT;
		}

		public void CopyPlainToShadow(PLC.IShadowstForecast target)
		{
			this.CopyPlainToShadow((PLC.stForecast)target);
		}

		public void CopyCyclicToPlain(PLC.stForecast source)
		{
			timeFrom = source.timeFrom.LastValue;
			timeTo = source.timeTo.LastValue;
			precipitation_unit = source.precipitation_unit.LastValue;
			precipitation_value = source.precipitation_value.LastValue;
			precipitation_type = source.precipitation_type.LastValue;
			windDirection_value = source.windDirection_value.LastValue;
			windDirection_name = source.windDirection_name.LastValue;
			windSpeed_value = source.windSpeed_value.LastValue;
			windSpeed_unit = source.windSpeed_unit.LastValue;
			windSpeed_name = source.windSpeed_name.LastValue;
			temperature_value = source.temperature_value.LastValue;
			temperature_unit = source.temperature_unit.LastValue;
			temperature_min = source.temperature_min.LastValue;
			temperature_max = source.temperature_max.LastValue;
			temperature_feel_like = source.temperature_feel_like.LastValue;
			pressure_value = source.pressure_value.LastValue;
			pressure_unit = source.pressure_unit.LastValue;
			humidity_value = source.humidity_value.LastValue;
			humidity_UNIT = source.humidity_UNIT.LastValue;
		}

		public void CopyCyclicToPlain(PLC.IstForecast source)
		{
			this.CopyCyclicToPlain((PLC.stForecast)source);
		}

		public void CopyShadowToPlain(PLC.stForecast source)
		{
			timeFrom = source.timeFrom.Shadow;
			timeTo = source.timeTo.Shadow;
			precipitation_unit = source.precipitation_unit.Shadow;
			precipitation_value = source.precipitation_value.Shadow;
			precipitation_type = source.precipitation_type.Shadow;
			windDirection_value = source.windDirection_value.Shadow;
			windDirection_name = source.windDirection_name.Shadow;
			windSpeed_value = source.windSpeed_value.Shadow;
			windSpeed_unit = source.windSpeed_unit.Shadow;
			windSpeed_name = source.windSpeed_name.Shadow;
			temperature_value = source.temperature_value.Shadow;
			temperature_unit = source.temperature_unit.Shadow;
			temperature_min = source.temperature_min.Shadow;
			temperature_max = source.temperature_max.Shadow;
			temperature_feel_like = source.temperature_feel_like.Shadow;
			pressure_value = source.pressure_value.Shadow;
			pressure_unit = source.pressure_unit.Shadow;
			humidity_value = source.humidity_value.Shadow;
			humidity_UNIT = source.humidity_UNIT.Shadow;
		}

		public void CopyShadowToPlain(PLC.IShadowstForecast source)
		{
			this.CopyShadowToPlain((PLC.stForecast)source);
		}

		public PlainstForecast()
		{
		}
	}
}