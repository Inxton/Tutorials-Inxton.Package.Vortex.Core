using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace PLC
{
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
			Forecast[0].LazyOnlineToShadow();
			Forecast[1].LazyOnlineToShadow();
			Forecast[2].LazyOnlineToShadow();
			Forecast[3].LazyOnlineToShadow();
			Forecast[4].LazyOnlineToShadow();
			Forecast[5].LazyOnlineToShadow();
			Forecast[6].LazyOnlineToShadow();
			Forecast[7].LazyOnlineToShadow();
			Forecast[8].LazyOnlineToShadow();
			Forecast[9].LazyOnlineToShadow();
			Forecast[10].LazyOnlineToShadow();
			Forecast[11].LazyOnlineToShadow();
			Forecast[12].LazyOnlineToShadow();
			Forecast[13].LazyOnlineToShadow();
			Forecast[14].LazyOnlineToShadow();
			Forecast[15].LazyOnlineToShadow();
			Forecast[16].LazyOnlineToShadow();
			Forecast[17].LazyOnlineToShadow();
			Forecast[18].LazyOnlineToShadow();
			Forecast[19].LazyOnlineToShadow();
			Forecast[20].LazyOnlineToShadow();
			Forecast[21].LazyOnlineToShadow();
			Forecast[22].LazyOnlineToShadow();
			Forecast[23].LazyOnlineToShadow();
			Forecast[24].LazyOnlineToShadow();
			Forecast[25].LazyOnlineToShadow();
			Forecast[26].LazyOnlineToShadow();
			Forecast[27].LazyOnlineToShadow();
			Forecast[28].LazyOnlineToShadow();
			Forecast[29].LazyOnlineToShadow();
			Forecast[30].LazyOnlineToShadow();
			Forecast[31].LazyOnlineToShadow();
			Forecast[32].LazyOnlineToShadow();
			Forecast[33].LazyOnlineToShadow();
			Forecast[34].LazyOnlineToShadow();
			Forecast[35].LazyOnlineToShadow();
			Forecast[36].LazyOnlineToShadow();
			Forecast[37].LazyOnlineToShadow();
			Forecast[38].LazyOnlineToShadow();
			Forecast[39].LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			sunrise.Cyclic = sunrise.Shadow;
			sunset.Cyclic = sunset.Shadow;
			Forecast[0].LazyShadowToOnline();
			Forecast[1].LazyShadowToOnline();
			Forecast[2].LazyShadowToOnline();
			Forecast[3].LazyShadowToOnline();
			Forecast[4].LazyShadowToOnline();
			Forecast[5].LazyShadowToOnline();
			Forecast[6].LazyShadowToOnline();
			Forecast[7].LazyShadowToOnline();
			Forecast[8].LazyShadowToOnline();
			Forecast[9].LazyShadowToOnline();
			Forecast[10].LazyShadowToOnline();
			Forecast[11].LazyShadowToOnline();
			Forecast[12].LazyShadowToOnline();
			Forecast[13].LazyShadowToOnline();
			Forecast[14].LazyShadowToOnline();
			Forecast[15].LazyShadowToOnline();
			Forecast[16].LazyShadowToOnline();
			Forecast[17].LazyShadowToOnline();
			Forecast[18].LazyShadowToOnline();
			Forecast[19].LazyShadowToOnline();
			Forecast[20].LazyShadowToOnline();
			Forecast[21].LazyShadowToOnline();
			Forecast[22].LazyShadowToOnline();
			Forecast[23].LazyShadowToOnline();
			Forecast[24].LazyShadowToOnline();
			Forecast[25].LazyShadowToOnline();
			Forecast[26].LazyShadowToOnline();
			Forecast[27].LazyShadowToOnline();
			Forecast[28].LazyShadowToOnline();
			Forecast[29].LazyShadowToOnline();
			Forecast[30].LazyShadowToOnline();
			Forecast[31].LazyShadowToOnline();
			Forecast[32].LazyShadowToOnline();
			Forecast[33].LazyShadowToOnline();
			Forecast[34].LazyShadowToOnline();
			Forecast[35].LazyShadowToOnline();
			Forecast[36].LazyShadowToOnline();
			Forecast[37].LazyShadowToOnline();
			Forecast[38].LazyShadowToOnline();
			Forecast[39].LazyShadowToOnline();
		}

		public PlainstWeatherData CreatePlainerType()
		{
			var cloned = new PlainstWeatherData();
			cloned.Forecast = new PlainstForecast [ 40 ];
			cloned.Forecast[0] = Forecast[0].CreatePlainerType();
			cloned.Forecast[1] = Forecast[1].CreatePlainerType();
			cloned.Forecast[2] = Forecast[2].CreatePlainerType();
			cloned.Forecast[3] = Forecast[3].CreatePlainerType();
			cloned.Forecast[4] = Forecast[4].CreatePlainerType();
			cloned.Forecast[5] = Forecast[5].CreatePlainerType();
			cloned.Forecast[6] = Forecast[6].CreatePlainerType();
			cloned.Forecast[7] = Forecast[7].CreatePlainerType();
			cloned.Forecast[8] = Forecast[8].CreatePlainerType();
			cloned.Forecast[9] = Forecast[9].CreatePlainerType();
			cloned.Forecast[10] = Forecast[10].CreatePlainerType();
			cloned.Forecast[11] = Forecast[11].CreatePlainerType();
			cloned.Forecast[12] = Forecast[12].CreatePlainerType();
			cloned.Forecast[13] = Forecast[13].CreatePlainerType();
			cloned.Forecast[14] = Forecast[14].CreatePlainerType();
			cloned.Forecast[15] = Forecast[15].CreatePlainerType();
			cloned.Forecast[16] = Forecast[16].CreatePlainerType();
			cloned.Forecast[17] = Forecast[17].CreatePlainerType();
			cloned.Forecast[18] = Forecast[18].CreatePlainerType();
			cloned.Forecast[19] = Forecast[19].CreatePlainerType();
			cloned.Forecast[20] = Forecast[20].CreatePlainerType();
			cloned.Forecast[21] = Forecast[21].CreatePlainerType();
			cloned.Forecast[22] = Forecast[22].CreatePlainerType();
			cloned.Forecast[23] = Forecast[23].CreatePlainerType();
			cloned.Forecast[24] = Forecast[24].CreatePlainerType();
			cloned.Forecast[25] = Forecast[25].CreatePlainerType();
			cloned.Forecast[26] = Forecast[26].CreatePlainerType();
			cloned.Forecast[27] = Forecast[27].CreatePlainerType();
			cloned.Forecast[28] = Forecast[28].CreatePlainerType();
			cloned.Forecast[29] = Forecast[29].CreatePlainerType();
			cloned.Forecast[30] = Forecast[30].CreatePlainerType();
			cloned.Forecast[31] = Forecast[31].CreatePlainerType();
			cloned.Forecast[32] = Forecast[32].CreatePlainerType();
			cloned.Forecast[33] = Forecast[33].CreatePlainerType();
			cloned.Forecast[34] = Forecast[34].CreatePlainerType();
			cloned.Forecast[35] = Forecast[35].CreatePlainerType();
			cloned.Forecast[36] = Forecast[36].CreatePlainerType();
			cloned.Forecast[37] = Forecast[37].CreatePlainerType();
			cloned.Forecast[38] = Forecast[38].CreatePlainerType();
			cloned.Forecast[39] = Forecast[39].CreatePlainerType();
			return cloned;
		}

		protected PlainstWeatherData CreatePlainerType(PlainstWeatherData cloned)
		{
			cloned.Forecast = new PlainstForecast [ 40 ];
			cloned.Forecast[0] = Forecast[0].CreatePlainerType();
			cloned.Forecast[1] = Forecast[1].CreatePlainerType();
			cloned.Forecast[2] = Forecast[2].CreatePlainerType();
			cloned.Forecast[3] = Forecast[3].CreatePlainerType();
			cloned.Forecast[4] = Forecast[4].CreatePlainerType();
			cloned.Forecast[5] = Forecast[5].CreatePlainerType();
			cloned.Forecast[6] = Forecast[6].CreatePlainerType();
			cloned.Forecast[7] = Forecast[7].CreatePlainerType();
			cloned.Forecast[8] = Forecast[8].CreatePlainerType();
			cloned.Forecast[9] = Forecast[9].CreatePlainerType();
			cloned.Forecast[10] = Forecast[10].CreatePlainerType();
			cloned.Forecast[11] = Forecast[11].CreatePlainerType();
			cloned.Forecast[12] = Forecast[12].CreatePlainerType();
			cloned.Forecast[13] = Forecast[13].CreatePlainerType();
			cloned.Forecast[14] = Forecast[14].CreatePlainerType();
			cloned.Forecast[15] = Forecast[15].CreatePlainerType();
			cloned.Forecast[16] = Forecast[16].CreatePlainerType();
			cloned.Forecast[17] = Forecast[17].CreatePlainerType();
			cloned.Forecast[18] = Forecast[18].CreatePlainerType();
			cloned.Forecast[19] = Forecast[19].CreatePlainerType();
			cloned.Forecast[20] = Forecast[20].CreatePlainerType();
			cloned.Forecast[21] = Forecast[21].CreatePlainerType();
			cloned.Forecast[22] = Forecast[22].CreatePlainerType();
			cloned.Forecast[23] = Forecast[23].CreatePlainerType();
			cloned.Forecast[24] = Forecast[24].CreatePlainerType();
			cloned.Forecast[25] = Forecast[25].CreatePlainerType();
			cloned.Forecast[26] = Forecast[26].CreatePlainerType();
			cloned.Forecast[27] = Forecast[27].CreatePlainerType();
			cloned.Forecast[28] = Forecast[28].CreatePlainerType();
			cloned.Forecast[29] = Forecast[29].CreatePlainerType();
			cloned.Forecast[30] = Forecast[30].CreatePlainerType();
			cloned.Forecast[31] = Forecast[31].CreatePlainerType();
			cloned.Forecast[32] = Forecast[32].CreatePlainerType();
			cloned.Forecast[33] = Forecast[33].CreatePlainerType();
			cloned.Forecast[34] = Forecast[34].CreatePlainerType();
			cloned.Forecast[35] = Forecast[35].CreatePlainerType();
			cloned.Forecast[36] = Forecast[36].CreatePlainerType();
			cloned.Forecast[37] = Forecast[37].CreatePlainerType();
			cloned.Forecast[38] = Forecast[38].CreatePlainerType();
			cloned.Forecast[39] = Forecast[39].CreatePlainerType();
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
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_sunrise = @Connector.Online.Adapter.CreateDATE_TIME(this, "", "sunrise");
			_sunset = @Connector.Online.Adapter.CreateDATE_TIME(this, "", "sunset");
			Forecast = new stForecast [ 40 ];
			Forecast [ 0 ] = new stForecast(this, "[[0]]", "Forecast[0]");
			Forecast [ 1 ] = new stForecast(this, "[[1]]", "Forecast[1]");
			Forecast [ 2 ] = new stForecast(this, "[[2]]", "Forecast[2]");
			Forecast [ 3 ] = new stForecast(this, "[[3]]", "Forecast[3]");
			Forecast [ 4 ] = new stForecast(this, "[[4]]", "Forecast[4]");
			Forecast [ 5 ] = new stForecast(this, "[[5]]", "Forecast[5]");
			Forecast [ 6 ] = new stForecast(this, "[[6]]", "Forecast[6]");
			Forecast [ 7 ] = new stForecast(this, "[[7]]", "Forecast[7]");
			Forecast [ 8 ] = new stForecast(this, "[[8]]", "Forecast[8]");
			Forecast [ 9 ] = new stForecast(this, "[[9]]", "Forecast[9]");
			Forecast [ 10 ] = new stForecast(this, "[[10]]", "Forecast[10]");
			Forecast [ 11 ] = new stForecast(this, "[[11]]", "Forecast[11]");
			Forecast [ 12 ] = new stForecast(this, "[[12]]", "Forecast[12]");
			Forecast [ 13 ] = new stForecast(this, "[[13]]", "Forecast[13]");
			Forecast [ 14 ] = new stForecast(this, "[[14]]", "Forecast[14]");
			Forecast [ 15 ] = new stForecast(this, "[[15]]", "Forecast[15]");
			Forecast [ 16 ] = new stForecast(this, "[[16]]", "Forecast[16]");
			Forecast [ 17 ] = new stForecast(this, "[[17]]", "Forecast[17]");
			Forecast [ 18 ] = new stForecast(this, "[[18]]", "Forecast[18]");
			Forecast [ 19 ] = new stForecast(this, "[[19]]", "Forecast[19]");
			Forecast [ 20 ] = new stForecast(this, "[[20]]", "Forecast[20]");
			Forecast [ 21 ] = new stForecast(this, "[[21]]", "Forecast[21]");
			Forecast [ 22 ] = new stForecast(this, "[[22]]", "Forecast[22]");
			Forecast [ 23 ] = new stForecast(this, "[[23]]", "Forecast[23]");
			Forecast [ 24 ] = new stForecast(this, "[[24]]", "Forecast[24]");
			Forecast [ 25 ] = new stForecast(this, "[[25]]", "Forecast[25]");
			Forecast [ 26 ] = new stForecast(this, "[[26]]", "Forecast[26]");
			Forecast [ 27 ] = new stForecast(this, "[[27]]", "Forecast[27]");
			Forecast [ 28 ] = new stForecast(this, "[[28]]", "Forecast[28]");
			Forecast [ 29 ] = new stForecast(this, "[[29]]", "Forecast[29]");
			Forecast [ 30 ] = new stForecast(this, "[[30]]", "Forecast[30]");
			Forecast [ 31 ] = new stForecast(this, "[[31]]", "Forecast[31]");
			Forecast [ 32 ] = new stForecast(this, "[[32]]", "Forecast[32]");
			Forecast [ 33 ] = new stForecast(this, "[[33]]", "Forecast[33]");
			Forecast [ 34 ] = new stForecast(this, "[[34]]", "Forecast[34]");
			Forecast [ 35 ] = new stForecast(this, "[[35]]", "Forecast[35]");
			Forecast [ 36 ] = new stForecast(this, "[[36]]", "Forecast[36]");
			Forecast [ 37 ] = new stForecast(this, "[[37]]", "Forecast[37]");
			Forecast [ 38 ] = new stForecast(this, "[[38]]", "Forecast[38]");
			Forecast [ 39 ] = new stForecast(this, "[[39]]", "Forecast[39]");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public stWeatherData()
		{
			PexPreConstructorParameterless();
			_sunrise = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			_sunset = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			Forecast = new stForecast [ 40 ];
			Forecast [ 0 ] = new stForecast();
			Forecast [ 1 ] = new stForecast();
			Forecast [ 2 ] = new stForecast();
			Forecast [ 3 ] = new stForecast();
			Forecast [ 4 ] = new stForecast();
			Forecast [ 5 ] = new stForecast();
			Forecast [ 6 ] = new stForecast();
			Forecast [ 7 ] = new stForecast();
			Forecast [ 8 ] = new stForecast();
			Forecast [ 9 ] = new stForecast();
			Forecast [ 10 ] = new stForecast();
			Forecast [ 11 ] = new stForecast();
			Forecast [ 12 ] = new stForecast();
			Forecast [ 13 ] = new stForecast();
			Forecast [ 14 ] = new stForecast();
			Forecast [ 15 ] = new stForecast();
			Forecast [ 16 ] = new stForecast();
			Forecast [ 17 ] = new stForecast();
			Forecast [ 18 ] = new stForecast();
			Forecast [ 19 ] = new stForecast();
			Forecast [ 20 ] = new stForecast();
			Forecast [ 21 ] = new stForecast();
			Forecast [ 22 ] = new stForecast();
			Forecast [ 23 ] = new stForecast();
			Forecast [ 24 ] = new stForecast();
			Forecast [ 25 ] = new stForecast();
			Forecast [ 26 ] = new stForecast();
			Forecast [ 27 ] = new stForecast();
			Forecast [ 28 ] = new stForecast();
			Forecast [ 29 ] = new stForecast();
			Forecast [ 30 ] = new stForecast();
			Forecast [ 31 ] = new stForecast();
			Forecast [ 32 ] = new stForecast();
			Forecast [ 33 ] = new stForecast();
			Forecast [ 34 ] = new stForecast();
			Forecast [ 35 ] = new stForecast();
			Forecast [ 36 ] = new stForecast();
			Forecast [ 37 ] = new stForecast();
			Forecast [ 38 ] = new stForecast();
			Forecast [ 39 ] = new stForecast();
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
	public partial class PlainstWeatherData : Vortex.Connector.IPlain
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
				_sunrise = value;
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
				_sunset = value;
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
			Forecast[0].CopyPlainToCyclic(target.Forecast[0]);
			Forecast[1].CopyPlainToCyclic(target.Forecast[1]);
			Forecast[2].CopyPlainToCyclic(target.Forecast[2]);
			Forecast[3].CopyPlainToCyclic(target.Forecast[3]);
			Forecast[4].CopyPlainToCyclic(target.Forecast[4]);
			Forecast[5].CopyPlainToCyclic(target.Forecast[5]);
			Forecast[6].CopyPlainToCyclic(target.Forecast[6]);
			Forecast[7].CopyPlainToCyclic(target.Forecast[7]);
			Forecast[8].CopyPlainToCyclic(target.Forecast[8]);
			Forecast[9].CopyPlainToCyclic(target.Forecast[9]);
			Forecast[10].CopyPlainToCyclic(target.Forecast[10]);
			Forecast[11].CopyPlainToCyclic(target.Forecast[11]);
			Forecast[12].CopyPlainToCyclic(target.Forecast[12]);
			Forecast[13].CopyPlainToCyclic(target.Forecast[13]);
			Forecast[14].CopyPlainToCyclic(target.Forecast[14]);
			Forecast[15].CopyPlainToCyclic(target.Forecast[15]);
			Forecast[16].CopyPlainToCyclic(target.Forecast[16]);
			Forecast[17].CopyPlainToCyclic(target.Forecast[17]);
			Forecast[18].CopyPlainToCyclic(target.Forecast[18]);
			Forecast[19].CopyPlainToCyclic(target.Forecast[19]);
			Forecast[20].CopyPlainToCyclic(target.Forecast[20]);
			Forecast[21].CopyPlainToCyclic(target.Forecast[21]);
			Forecast[22].CopyPlainToCyclic(target.Forecast[22]);
			Forecast[23].CopyPlainToCyclic(target.Forecast[23]);
			Forecast[24].CopyPlainToCyclic(target.Forecast[24]);
			Forecast[25].CopyPlainToCyclic(target.Forecast[25]);
			Forecast[26].CopyPlainToCyclic(target.Forecast[26]);
			Forecast[27].CopyPlainToCyclic(target.Forecast[27]);
			Forecast[28].CopyPlainToCyclic(target.Forecast[28]);
			Forecast[29].CopyPlainToCyclic(target.Forecast[29]);
			Forecast[30].CopyPlainToCyclic(target.Forecast[30]);
			Forecast[31].CopyPlainToCyclic(target.Forecast[31]);
			Forecast[32].CopyPlainToCyclic(target.Forecast[32]);
			Forecast[33].CopyPlainToCyclic(target.Forecast[33]);
			Forecast[34].CopyPlainToCyclic(target.Forecast[34]);
			Forecast[35].CopyPlainToCyclic(target.Forecast[35]);
			Forecast[36].CopyPlainToCyclic(target.Forecast[36]);
			Forecast[37].CopyPlainToCyclic(target.Forecast[37]);
			Forecast[38].CopyPlainToCyclic(target.Forecast[38]);
			Forecast[39].CopyPlainToCyclic(target.Forecast[39]);
		}

		public void CopyPlainToCyclic(PLC.IstWeatherData target)
		{
			this.CopyPlainToCyclic((PLC.stWeatherData)target);
		}

		public void CopyPlainToShadow(PLC.stWeatherData target)
		{
			target.sunrise.Shadow = sunrise;
			target.sunset.Shadow = sunset;
			Forecast[0].CopyPlainToShadow(target.Forecast[0]);
			Forecast[1].CopyPlainToShadow(target.Forecast[1]);
			Forecast[2].CopyPlainToShadow(target.Forecast[2]);
			Forecast[3].CopyPlainToShadow(target.Forecast[3]);
			Forecast[4].CopyPlainToShadow(target.Forecast[4]);
			Forecast[5].CopyPlainToShadow(target.Forecast[5]);
			Forecast[6].CopyPlainToShadow(target.Forecast[6]);
			Forecast[7].CopyPlainToShadow(target.Forecast[7]);
			Forecast[8].CopyPlainToShadow(target.Forecast[8]);
			Forecast[9].CopyPlainToShadow(target.Forecast[9]);
			Forecast[10].CopyPlainToShadow(target.Forecast[10]);
			Forecast[11].CopyPlainToShadow(target.Forecast[11]);
			Forecast[12].CopyPlainToShadow(target.Forecast[12]);
			Forecast[13].CopyPlainToShadow(target.Forecast[13]);
			Forecast[14].CopyPlainToShadow(target.Forecast[14]);
			Forecast[15].CopyPlainToShadow(target.Forecast[15]);
			Forecast[16].CopyPlainToShadow(target.Forecast[16]);
			Forecast[17].CopyPlainToShadow(target.Forecast[17]);
			Forecast[18].CopyPlainToShadow(target.Forecast[18]);
			Forecast[19].CopyPlainToShadow(target.Forecast[19]);
			Forecast[20].CopyPlainToShadow(target.Forecast[20]);
			Forecast[21].CopyPlainToShadow(target.Forecast[21]);
			Forecast[22].CopyPlainToShadow(target.Forecast[22]);
			Forecast[23].CopyPlainToShadow(target.Forecast[23]);
			Forecast[24].CopyPlainToShadow(target.Forecast[24]);
			Forecast[25].CopyPlainToShadow(target.Forecast[25]);
			Forecast[26].CopyPlainToShadow(target.Forecast[26]);
			Forecast[27].CopyPlainToShadow(target.Forecast[27]);
			Forecast[28].CopyPlainToShadow(target.Forecast[28]);
			Forecast[29].CopyPlainToShadow(target.Forecast[29]);
			Forecast[30].CopyPlainToShadow(target.Forecast[30]);
			Forecast[31].CopyPlainToShadow(target.Forecast[31]);
			Forecast[32].CopyPlainToShadow(target.Forecast[32]);
			Forecast[33].CopyPlainToShadow(target.Forecast[33]);
			Forecast[34].CopyPlainToShadow(target.Forecast[34]);
			Forecast[35].CopyPlainToShadow(target.Forecast[35]);
			Forecast[36].CopyPlainToShadow(target.Forecast[36]);
			Forecast[37].CopyPlainToShadow(target.Forecast[37]);
			Forecast[38].CopyPlainToShadow(target.Forecast[38]);
			Forecast[39].CopyPlainToShadow(target.Forecast[39]);
		}

		public void CopyPlainToShadow(PLC.IShadowstWeatherData target)
		{
			this.CopyPlainToShadow((PLC.stWeatherData)target);
		}

		public void CopyCyclicToPlain(PLC.stWeatherData source)
		{
			sunrise = source.sunrise.LastValue;
			sunset = source.sunset.LastValue;
			Forecast[0].CopyCyclicToPlain(source.Forecast[0]);
			Forecast[1].CopyCyclicToPlain(source.Forecast[1]);
			Forecast[2].CopyCyclicToPlain(source.Forecast[2]);
			Forecast[3].CopyCyclicToPlain(source.Forecast[3]);
			Forecast[4].CopyCyclicToPlain(source.Forecast[4]);
			Forecast[5].CopyCyclicToPlain(source.Forecast[5]);
			Forecast[6].CopyCyclicToPlain(source.Forecast[6]);
			Forecast[7].CopyCyclicToPlain(source.Forecast[7]);
			Forecast[8].CopyCyclicToPlain(source.Forecast[8]);
			Forecast[9].CopyCyclicToPlain(source.Forecast[9]);
			Forecast[10].CopyCyclicToPlain(source.Forecast[10]);
			Forecast[11].CopyCyclicToPlain(source.Forecast[11]);
			Forecast[12].CopyCyclicToPlain(source.Forecast[12]);
			Forecast[13].CopyCyclicToPlain(source.Forecast[13]);
			Forecast[14].CopyCyclicToPlain(source.Forecast[14]);
			Forecast[15].CopyCyclicToPlain(source.Forecast[15]);
			Forecast[16].CopyCyclicToPlain(source.Forecast[16]);
			Forecast[17].CopyCyclicToPlain(source.Forecast[17]);
			Forecast[18].CopyCyclicToPlain(source.Forecast[18]);
			Forecast[19].CopyCyclicToPlain(source.Forecast[19]);
			Forecast[20].CopyCyclicToPlain(source.Forecast[20]);
			Forecast[21].CopyCyclicToPlain(source.Forecast[21]);
			Forecast[22].CopyCyclicToPlain(source.Forecast[22]);
			Forecast[23].CopyCyclicToPlain(source.Forecast[23]);
			Forecast[24].CopyCyclicToPlain(source.Forecast[24]);
			Forecast[25].CopyCyclicToPlain(source.Forecast[25]);
			Forecast[26].CopyCyclicToPlain(source.Forecast[26]);
			Forecast[27].CopyCyclicToPlain(source.Forecast[27]);
			Forecast[28].CopyCyclicToPlain(source.Forecast[28]);
			Forecast[29].CopyCyclicToPlain(source.Forecast[29]);
			Forecast[30].CopyCyclicToPlain(source.Forecast[30]);
			Forecast[31].CopyCyclicToPlain(source.Forecast[31]);
			Forecast[32].CopyCyclicToPlain(source.Forecast[32]);
			Forecast[33].CopyCyclicToPlain(source.Forecast[33]);
			Forecast[34].CopyCyclicToPlain(source.Forecast[34]);
			Forecast[35].CopyCyclicToPlain(source.Forecast[35]);
			Forecast[36].CopyCyclicToPlain(source.Forecast[36]);
			Forecast[37].CopyCyclicToPlain(source.Forecast[37]);
			Forecast[38].CopyCyclicToPlain(source.Forecast[38]);
			Forecast[39].CopyCyclicToPlain(source.Forecast[39]);
		}

		public void CopyCyclicToPlain(PLC.IstWeatherData source)
		{
			this.CopyCyclicToPlain((PLC.stWeatherData)source);
		}

		public void CopyShadowToPlain(PLC.stWeatherData source)
		{
			sunrise = source.sunrise.Shadow;
			sunset = source.sunset.Shadow;
			Forecast[0].CopyShadowToPlain(source.Forecast[0]);
			Forecast[1].CopyShadowToPlain(source.Forecast[1]);
			Forecast[2].CopyShadowToPlain(source.Forecast[2]);
			Forecast[3].CopyShadowToPlain(source.Forecast[3]);
			Forecast[4].CopyShadowToPlain(source.Forecast[4]);
			Forecast[5].CopyShadowToPlain(source.Forecast[5]);
			Forecast[6].CopyShadowToPlain(source.Forecast[6]);
			Forecast[7].CopyShadowToPlain(source.Forecast[7]);
			Forecast[8].CopyShadowToPlain(source.Forecast[8]);
			Forecast[9].CopyShadowToPlain(source.Forecast[9]);
			Forecast[10].CopyShadowToPlain(source.Forecast[10]);
			Forecast[11].CopyShadowToPlain(source.Forecast[11]);
			Forecast[12].CopyShadowToPlain(source.Forecast[12]);
			Forecast[13].CopyShadowToPlain(source.Forecast[13]);
			Forecast[14].CopyShadowToPlain(source.Forecast[14]);
			Forecast[15].CopyShadowToPlain(source.Forecast[15]);
			Forecast[16].CopyShadowToPlain(source.Forecast[16]);
			Forecast[17].CopyShadowToPlain(source.Forecast[17]);
			Forecast[18].CopyShadowToPlain(source.Forecast[18]);
			Forecast[19].CopyShadowToPlain(source.Forecast[19]);
			Forecast[20].CopyShadowToPlain(source.Forecast[20]);
			Forecast[21].CopyShadowToPlain(source.Forecast[21]);
			Forecast[22].CopyShadowToPlain(source.Forecast[22]);
			Forecast[23].CopyShadowToPlain(source.Forecast[23]);
			Forecast[24].CopyShadowToPlain(source.Forecast[24]);
			Forecast[25].CopyShadowToPlain(source.Forecast[25]);
			Forecast[26].CopyShadowToPlain(source.Forecast[26]);
			Forecast[27].CopyShadowToPlain(source.Forecast[27]);
			Forecast[28].CopyShadowToPlain(source.Forecast[28]);
			Forecast[29].CopyShadowToPlain(source.Forecast[29]);
			Forecast[30].CopyShadowToPlain(source.Forecast[30]);
			Forecast[31].CopyShadowToPlain(source.Forecast[31]);
			Forecast[32].CopyShadowToPlain(source.Forecast[32]);
			Forecast[33].CopyShadowToPlain(source.Forecast[33]);
			Forecast[34].CopyShadowToPlain(source.Forecast[34]);
			Forecast[35].CopyShadowToPlain(source.Forecast[35]);
			Forecast[36].CopyShadowToPlain(source.Forecast[36]);
			Forecast[37].CopyShadowToPlain(source.Forecast[37]);
			Forecast[38].CopyShadowToPlain(source.Forecast[38]);
			Forecast[39].CopyShadowToPlain(source.Forecast[39]);
		}

		public void CopyShadowToPlain(PLC.IShadowstWeatherData source)
		{
			this.CopyShadowToPlain((PLC.stWeatherData)source);
		}

		public PlainstWeatherData()
		{
			Forecast = new PlainstForecast [ 40 ];
			Forecast [ 0 ] = new PlainstForecast();
			Forecast [ 1 ] = new PlainstForecast();
			Forecast [ 2 ] = new PlainstForecast();
			Forecast [ 3 ] = new PlainstForecast();
			Forecast [ 4 ] = new PlainstForecast();
			Forecast [ 5 ] = new PlainstForecast();
			Forecast [ 6 ] = new PlainstForecast();
			Forecast [ 7 ] = new PlainstForecast();
			Forecast [ 8 ] = new PlainstForecast();
			Forecast [ 9 ] = new PlainstForecast();
			Forecast [ 10 ] = new PlainstForecast();
			Forecast [ 11 ] = new PlainstForecast();
			Forecast [ 12 ] = new PlainstForecast();
			Forecast [ 13 ] = new PlainstForecast();
			Forecast [ 14 ] = new PlainstForecast();
			Forecast [ 15 ] = new PlainstForecast();
			Forecast [ 16 ] = new PlainstForecast();
			Forecast [ 17 ] = new PlainstForecast();
			Forecast [ 18 ] = new PlainstForecast();
			Forecast [ 19 ] = new PlainstForecast();
			Forecast [ 20 ] = new PlainstForecast();
			Forecast [ 21 ] = new PlainstForecast();
			Forecast [ 22 ] = new PlainstForecast();
			Forecast [ 23 ] = new PlainstForecast();
			Forecast [ 24 ] = new PlainstForecast();
			Forecast [ 25 ] = new PlainstForecast();
			Forecast [ 26 ] = new PlainstForecast();
			Forecast [ 27 ] = new PlainstForecast();
			Forecast [ 28 ] = new PlainstForecast();
			Forecast [ 29 ] = new PlainstForecast();
			Forecast [ 30 ] = new PlainstForecast();
			Forecast [ 31 ] = new PlainstForecast();
			Forecast [ 32 ] = new PlainstForecast();
			Forecast [ 33 ] = new PlainstForecast();
			Forecast [ 34 ] = new PlainstForecast();
			Forecast [ 35 ] = new PlainstForecast();
			Forecast [ 36 ] = new PlainstForecast();
			Forecast [ 37 ] = new PlainstForecast();
			Forecast [ 38 ] = new PlainstForecast();
			Forecast [ 39 ] = new PlainstForecast();
		}
	}
}