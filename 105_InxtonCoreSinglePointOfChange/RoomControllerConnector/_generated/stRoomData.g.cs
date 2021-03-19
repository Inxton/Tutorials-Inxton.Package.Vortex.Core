using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace RoomController
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stRoomData", "RoomController", TypeComplexityEnum.Complex)]
	public partial class stRoomData : Vortex.Connector.IVortexObject, IstRoomData, IShadowstRoomData, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
				return RoomControllerTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerReal _Temperature;
		public Vortex.Connector.ValueTypes.OnlinerReal Temperature
		{
			get
			{
				return _Temperature;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstRoomData.Temperature
		{
			get
			{
				return Temperature;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstRoomData.Temperature
		{
			get
			{
				return Temperature;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Humidity;
		public Vortex.Connector.ValueTypes.OnlinerReal Humidity
		{
			get
			{
				return _Humidity;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstRoomData.Humidity
		{
			get
			{
				return Humidity;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstRoomData.Humidity
		{
			get
			{
				return Humidity;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _VOC;
		public Vortex.Connector.ValueTypes.OnlinerReal VOC
		{
			get
			{
				return _VOC;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstRoomData.VOC
		{
			get
			{
				return VOC;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstRoomData.VOC
		{
			get
			{
				return VOC;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _CO2;
		public Vortex.Connector.ValueTypes.OnlinerReal CO2
		{
			get
			{
				return _CO2;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstRoomData.CO2
		{
			get
			{
				return CO2;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstRoomData.CO2
		{
			get
			{
				return CO2;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _AbsoluteHumidity;
		public Vortex.Connector.ValueTypes.OnlinerReal AbsoluteHumidity
		{
			get
			{
				return _AbsoluteHumidity;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstRoomData.AbsoluteHumidity
		{
			get
			{
				return AbsoluteHumidity;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstRoomData.AbsoluteHumidity
		{
			get
			{
				return AbsoluteHumidity;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Enthalpy;
		public Vortex.Connector.ValueTypes.OnlinerReal Enthalpy
		{
			get
			{
				return _Enthalpy;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstRoomData.Enthalpy
		{
			get
			{
				return Enthalpy;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstRoomData.Enthalpy
		{
			get
			{
				return Enthalpy;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _DewPoint;
		public Vortex.Connector.ValueTypes.OnlinerReal DewPoint
		{
			get
			{
				return _DewPoint;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstRoomData.DewPoint
		{
			get
			{
				return DewPoint;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstRoomData.DewPoint
		{
			get
			{
				return DewPoint;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _CO2VOC_MIX;
		public Vortex.Connector.ValueTypes.OnlinerReal CO2VOC_MIX
		{
			get
			{
				return _CO2VOC_MIX;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstRoomData.CO2VOC_MIX
		{
			get
			{
				return CO2VOC_MIX;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstRoomData.CO2VOC_MIX
		{
			get
			{
				return CO2VOC_MIX;
			}
		}

		public void LazyOnlineToShadow()
		{
			Temperature.Shadow = Temperature.LastValue;
			Humidity.Shadow = Humidity.LastValue;
			VOC.Shadow = VOC.LastValue;
			CO2.Shadow = CO2.LastValue;
			AbsoluteHumidity.Shadow = AbsoluteHumidity.LastValue;
			Enthalpy.Shadow = Enthalpy.LastValue;
			DewPoint.Shadow = DewPoint.LastValue;
			CO2VOC_MIX.Shadow = CO2VOC_MIX.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Temperature.Cyclic = Temperature.Shadow;
			Humidity.Cyclic = Humidity.Shadow;
			VOC.Cyclic = VOC.Shadow;
			CO2.Cyclic = CO2.Shadow;
			AbsoluteHumidity.Cyclic = AbsoluteHumidity.Shadow;
			Enthalpy.Cyclic = Enthalpy.Shadow;
			DewPoint.Cyclic = DewPoint.Shadow;
			CO2VOC_MIX.Cyclic = CO2VOC_MIX.Shadow;
		}

		public PlainstRoomData CreatePlainerType()
		{
			var cloned = new PlainstRoomData();
			return cloned;
		}

		protected PlainstRoomData CreatePlainerType(PlainstRoomData cloned)
		{
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

		public void FlushPlainToOnline(RoomController.PlainstRoomData source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(RoomController.PlainstRoomData source)
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

		public void FlushOnlineToPlain(RoomController.PlainstRoomData source)
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
				return RoomControllerTwinController.Translator.Translate(_AttributeName).Interpolate(this);
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

		public stRoomData(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_Temperature = @Connector.Online.Adapter.CreateREAL(this, "<#Actual room temperature °C#>", "Temperature");
			Temperature.AttributeName = "<#Actual room temperature °C#>";
			_Humidity = @Connector.Online.Adapter.CreateREAL(this, "<#Actual room humidity %#>", "Humidity");
			Humidity.AttributeName = "<#Actual room humidity %#>";
			_VOC = @Connector.Online.Adapter.CreateREAL(this, "<#Actual room VOC %#>", "VOC");
			VOC.AttributeName = "<#Actual room VOC %#>";
			_CO2 = @Connector.Online.Adapter.CreateREAL(this, "<#Actual room CO2 concentration ppm#>", "CO2");
			CO2.AttributeName = "<#Actual room CO2 concentration ppm#>";
			_AbsoluteHumidity = @Connector.Online.Adapter.CreateREAL(this, "<#Actual room absolute humidity g/m3#>", "AbsoluteHumidity");
			AbsoluteHumidity.AttributeName = "<#Actual room absolute humidity g/m3#>";
			_Enthalpy = @Connector.Online.Adapter.CreateREAL(this, "<#Actual room enthalpy kJ/k#>", "Enthalpy");
			Enthalpy.AttributeName = "<#Actual room enthalpy kJ/k#>";
			_DewPoint = @Connector.Online.Adapter.CreateREAL(this, "<#Actual room dew point °C#>", "DewPoint");
			DewPoint.AttributeName = "<#Actual room dew point °C#>";
			_CO2VOC_MIX = @Connector.Online.Adapter.CreateREAL(this, "<#Actual room CO2 VOC mix#>", "CO2VOC_MIX");
			CO2VOC_MIX.AttributeName = "<#Actual room CO2 VOC mix#>";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stRoomData()
		{
			PexPreConstructorParameterless();
			_Temperature = Vortex.Connector.IConnectorFactory.CreateREAL();
			Temperature.AttributeName = "<#Actual room temperature °C#>";
			_Humidity = Vortex.Connector.IConnectorFactory.CreateREAL();
			Humidity.AttributeName = "<#Actual room humidity %#>";
			_VOC = Vortex.Connector.IConnectorFactory.CreateREAL();
			VOC.AttributeName = "<#Actual room VOC %#>";
			_CO2 = Vortex.Connector.IConnectorFactory.CreateREAL();
			CO2.AttributeName = "<#Actual room CO2 concentration ppm#>";
			_AbsoluteHumidity = Vortex.Connector.IConnectorFactory.CreateREAL();
			AbsoluteHumidity.AttributeName = "<#Actual room absolute humidity g/m3#>";
			_Enthalpy = Vortex.Connector.IConnectorFactory.CreateREAL();
			Enthalpy.AttributeName = "<#Actual room enthalpy kJ/k#>";
			_DewPoint = Vortex.Connector.IConnectorFactory.CreateREAL();
			DewPoint.AttributeName = "<#Actual room dew point °C#>";
			_CO2VOC_MIX = Vortex.Connector.IConnectorFactory.CreateREAL();
			CO2VOC_MIX.AttributeName = "<#Actual room CO2 VOC mix#>";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstRoomData
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstRoomData()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstRoomData : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineReal Temperature
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Humidity
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal VOC
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal CO2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal AbsoluteHumidity
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Enthalpy
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal DewPoint
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal CO2VOC_MIX
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainstRoomData CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(RoomController.PlainstRoomData source);
		void FlushOnlineToPlain(RoomController.PlainstRoomData source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstRoomData : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowReal Temperature
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Humidity
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal VOC
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal CO2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal AbsoluteHumidity
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Enthalpy
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal DewPoint
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal CO2VOC_MIX
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainstRoomData CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(RoomController.PlainstRoomData source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstRoomData : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Single _Temperature;
		public System.Single Temperature
		{
			get
			{
				return _Temperature;
			}

			set
			{
				if (_Temperature != value)
				{
					_Temperature = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Temperature)));
				}
			}
		}

		System.Single _Humidity;
		public System.Single Humidity
		{
			get
			{
				return _Humidity;
			}

			set
			{
				if (_Humidity != value)
				{
					_Humidity = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Humidity)));
				}
			}
		}

		System.Single _VOC;
		public System.Single VOC
		{
			get
			{
				return _VOC;
			}

			set
			{
				if (_VOC != value)
				{
					_VOC = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(VOC)));
				}
			}
		}

		System.Single _CO2;
		public System.Single CO2
		{
			get
			{
				return _CO2;
			}

			set
			{
				if (_CO2 != value)
				{
					_CO2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(CO2)));
				}
			}
		}

		System.Single _AbsoluteHumidity;
		public System.Single AbsoluteHumidity
		{
			get
			{
				return _AbsoluteHumidity;
			}

			set
			{
				if (_AbsoluteHumidity != value)
				{
					_AbsoluteHumidity = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AbsoluteHumidity)));
				}
			}
		}

		System.Single _Enthalpy;
		public System.Single Enthalpy
		{
			get
			{
				return _Enthalpy;
			}

			set
			{
				if (_Enthalpy != value)
				{
					_Enthalpy = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Enthalpy)));
				}
			}
		}

		System.Single _DewPoint;
		public System.Single DewPoint
		{
			get
			{
				return _DewPoint;
			}

			set
			{
				if (_DewPoint != value)
				{
					_DewPoint = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DewPoint)));
				}
			}
		}

		System.Single _CO2VOC_MIX;
		public System.Single CO2VOC_MIX
		{
			get
			{
				return _CO2VOC_MIX;
			}

			set
			{
				if (_CO2VOC_MIX != value)
				{
					_CO2VOC_MIX = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(CO2VOC_MIX)));
				}
			}
		}

		public void CopyPlainToCyclic(RoomController.stRoomData target)
		{
			target.Temperature.Cyclic = Temperature;
			target.Humidity.Cyclic = Humidity;
			target.VOC.Cyclic = VOC;
			target.CO2.Cyclic = CO2;
			target.AbsoluteHumidity.Cyclic = AbsoluteHumidity;
			target.Enthalpy.Cyclic = Enthalpy;
			target.DewPoint.Cyclic = DewPoint;
			target.CO2VOC_MIX.Cyclic = CO2VOC_MIX;
		}

		public void CopyPlainToCyclic(RoomController.IstRoomData target)
		{
			this.CopyPlainToCyclic((RoomController.stRoomData)target);
		}

		public void CopyPlainToShadow(RoomController.stRoomData target)
		{
			target.Temperature.Shadow = Temperature;
			target.Humidity.Shadow = Humidity;
			target.VOC.Shadow = VOC;
			target.CO2.Shadow = CO2;
			target.AbsoluteHumidity.Shadow = AbsoluteHumidity;
			target.Enthalpy.Shadow = Enthalpy;
			target.DewPoint.Shadow = DewPoint;
			target.CO2VOC_MIX.Shadow = CO2VOC_MIX;
		}

		public void CopyPlainToShadow(RoomController.IShadowstRoomData target)
		{
			this.CopyPlainToShadow((RoomController.stRoomData)target);
		}

		public void CopyCyclicToPlain(RoomController.stRoomData source)
		{
			Temperature = source.Temperature.LastValue;
			Humidity = source.Humidity.LastValue;
			VOC = source.VOC.LastValue;
			CO2 = source.CO2.LastValue;
			AbsoluteHumidity = source.AbsoluteHumidity.LastValue;
			Enthalpy = source.Enthalpy.LastValue;
			DewPoint = source.DewPoint.LastValue;
			CO2VOC_MIX = source.CO2VOC_MIX.LastValue;
		}

		public void CopyCyclicToPlain(RoomController.IstRoomData source)
		{
			this.CopyCyclicToPlain((RoomController.stRoomData)source);
		}

		public void CopyShadowToPlain(RoomController.stRoomData source)
		{
			Temperature = source.Temperature.Shadow;
			Humidity = source.Humidity.Shadow;
			VOC = source.VOC.Shadow;
			CO2 = source.CO2.Shadow;
			AbsoluteHumidity = source.AbsoluteHumidity.Shadow;
			Enthalpy = source.Enthalpy.Shadow;
			DewPoint = source.DewPoint.Shadow;
			CO2VOC_MIX = source.CO2VOC_MIX.Shadow;
		}

		public void CopyShadowToPlain(RoomController.IShadowstRoomData source)
		{
			this.CopyShadowToPlain((RoomController.stRoomData)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstRoomData()
		{
		}
	}
}