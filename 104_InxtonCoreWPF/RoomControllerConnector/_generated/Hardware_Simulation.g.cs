using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace RoomController
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "Hardware_Simulation", "RoomController", TypeComplexityEnum.Complex)]
	public partial class Hardware_Simulation : Vortex.Connector.IVortexObject, IHardware_Simulation, IShadowHardware_Simulation, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		fbIntValueSimulation _CH1;
		public fbIntValueSimulation CH1
		{
			get
			{
				return _CH1;
			}
		}

		IfbIntValueSimulation IHardware_Simulation.CH1
		{
			get
			{
				return CH1;
			}
		}

		IShadowfbIntValueSimulation IShadowHardware_Simulation.CH1
		{
			get
			{
				return CH1;
			}
		}

		fbIntValueSimulation _CH2;
		public fbIntValueSimulation CH2
		{
			get
			{
				return _CH2;
			}
		}

		IfbIntValueSimulation IHardware_Simulation.CH2
		{
			get
			{
				return CH2;
			}
		}

		IShadowfbIntValueSimulation IShadowHardware_Simulation.CH2
		{
			get
			{
				return CH2;
			}
		}

		fbIntValueSimulation _CH3;
		public fbIntValueSimulation CH3
		{
			get
			{
				return _CH3;
			}
		}

		IfbIntValueSimulation IHardware_Simulation.CH3
		{
			get
			{
				return CH3;
			}
		}

		IShadowfbIntValueSimulation IShadowHardware_Simulation.CH3
		{
			get
			{
				return CH3;
			}
		}

		fbIntValueSimulation _CH4;
		public fbIntValueSimulation CH4
		{
			get
			{
				return _CH4;
			}
		}

		IfbIntValueSimulation IHardware_Simulation.CH4
		{
			get
			{
				return CH4;
			}
		}

		IShadowfbIntValueSimulation IShadowHardware_Simulation.CH4
		{
			get
			{
				return CH4;
			}
		}

		public void LazyOnlineToShadow()
		{
			CH1.LazyOnlineToShadow();
			CH2.LazyOnlineToShadow();
			CH3.LazyOnlineToShadow();
			CH4.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			CH1.LazyShadowToOnline();
			CH2.LazyShadowToOnline();
			CH3.LazyShadowToOnline();
			CH4.LazyShadowToOnline();
		}

		public PlainHardware_Simulation CreatePlainerType()
		{
			var cloned = new PlainHardware_Simulation();
			cloned.CH1 = CH1.CreatePlainerType();
			cloned.CH2 = CH2.CreatePlainerType();
			cloned.CH3 = CH3.CreatePlainerType();
			cloned.CH4 = CH4.CreatePlainerType();
			return cloned;
		}

		protected PlainHardware_Simulation CreatePlainerType(PlainHardware_Simulation cloned)
		{
			cloned.CH1 = CH1.CreatePlainerType();
			cloned.CH2 = CH2.CreatePlainerType();
			cloned.CH3 = CH3.CreatePlainerType();
			cloned.CH4 = CH4.CreatePlainerType();
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

		public void FlushPlainToOnline(RoomController.PlainHardware_Simulation source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(RoomController.PlainHardware_Simulation source)
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

		public void FlushOnlineToPlain(RoomController.PlainHardware_Simulation source)
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

		public Hardware_Simulation(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_CH1 = new fbIntValueSimulation(this, "", "CH1");
			_CH2 = new fbIntValueSimulation(this, "", "CH2");
			_CH3 = new fbIntValueSimulation(this, "", "CH3");
			_CH4 = new fbIntValueSimulation(this, "", "CH4");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Hardware_Simulation()
		{
			PexPreConstructorParameterless();
			_CH1 = new fbIntValueSimulation();
			_CH2 = new fbIntValueSimulation();
			_CH3 = new fbIntValueSimulation();
			_CH4 = new fbIntValueSimulation();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcHardware_Simulation
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcHardware_Simulation()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IHardware_Simulation : Vortex.Connector.IVortexOnlineObject
	{
		IfbIntValueSimulation CH1
		{
			get;
		}

		IfbIntValueSimulation CH2
		{
			get;
		}

		IfbIntValueSimulation CH3
		{
			get;
		}

		IfbIntValueSimulation CH4
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainHardware_Simulation CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(RoomController.PlainHardware_Simulation source);
		void FlushOnlineToPlain(RoomController.PlainHardware_Simulation source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowHardware_Simulation : Vortex.Connector.IVortexShadowObject
	{
		IShadowfbIntValueSimulation CH1
		{
			get;
		}

		IShadowfbIntValueSimulation CH2
		{
			get;
		}

		IShadowfbIntValueSimulation CH3
		{
			get;
		}

		IShadowfbIntValueSimulation CH4
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainHardware_Simulation CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(RoomController.PlainHardware_Simulation source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainHardware_Simulation : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainfbIntValueSimulation _CH1;
		public PlainfbIntValueSimulation CH1
		{
			get
			{
				return _CH1;
			}

			set
			{
				if (_CH1 != value)
				{
					_CH1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(CH1)));
				}
			}
		}

		PlainfbIntValueSimulation _CH2;
		public PlainfbIntValueSimulation CH2
		{
			get
			{
				return _CH2;
			}

			set
			{
				if (_CH2 != value)
				{
					_CH2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(CH2)));
				}
			}
		}

		PlainfbIntValueSimulation _CH3;
		public PlainfbIntValueSimulation CH3
		{
			get
			{
				return _CH3;
			}

			set
			{
				if (_CH3 != value)
				{
					_CH3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(CH3)));
				}
			}
		}

		PlainfbIntValueSimulation _CH4;
		public PlainfbIntValueSimulation CH4
		{
			get
			{
				return _CH4;
			}

			set
			{
				if (_CH4 != value)
				{
					_CH4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(CH4)));
				}
			}
		}

		public void CopyPlainToCyclic(RoomController.Hardware_Simulation target)
		{
			CH1.CopyPlainToCyclic(target.CH1);
			CH2.CopyPlainToCyclic(target.CH2);
			CH3.CopyPlainToCyclic(target.CH3);
			CH4.CopyPlainToCyclic(target.CH4);
		}

		public void CopyPlainToCyclic(RoomController.IHardware_Simulation target)
		{
			this.CopyPlainToCyclic((RoomController.Hardware_Simulation)target);
		}

		public void CopyPlainToShadow(RoomController.Hardware_Simulation target)
		{
			CH1.CopyPlainToShadow(target.CH1);
			CH2.CopyPlainToShadow(target.CH2);
			CH3.CopyPlainToShadow(target.CH3);
			CH4.CopyPlainToShadow(target.CH4);
		}

		public void CopyPlainToShadow(RoomController.IShadowHardware_Simulation target)
		{
			this.CopyPlainToShadow((RoomController.Hardware_Simulation)target);
		}

		public void CopyCyclicToPlain(RoomController.Hardware_Simulation source)
		{
			CH1.CopyCyclicToPlain(source.CH1);
			CH2.CopyCyclicToPlain(source.CH2);
			CH3.CopyCyclicToPlain(source.CH3);
			CH4.CopyCyclicToPlain(source.CH4);
		}

		public void CopyCyclicToPlain(RoomController.IHardware_Simulation source)
		{
			this.CopyCyclicToPlain((RoomController.Hardware_Simulation)source);
		}

		public void CopyShadowToPlain(RoomController.Hardware_Simulation source)
		{
			CH1.CopyShadowToPlain(source.CH1);
			CH2.CopyShadowToPlain(source.CH2);
			CH3.CopyShadowToPlain(source.CH3);
			CH4.CopyShadowToPlain(source.CH4);
		}

		public void CopyShadowToPlain(RoomController.IShadowHardware_Simulation source)
		{
			this.CopyShadowToPlain((RoomController.Hardware_Simulation)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainHardware_Simulation()
		{
			_CH1 = new PlainfbIntValueSimulation();
			_CH2 = new PlainfbIntValueSimulation();
			_CH3 = new PlainfbIntValueSimulation();
			_CH4 = new PlainfbIntValueSimulation();
		}
	}
}