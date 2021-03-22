using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace RoomController
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbIntValueSimulation", "RoomController", TypeComplexityEnum.Complex)]
	public partial class fbIntValueSimulation : Vortex.Connector.IVortexObject, IfbIntValueSimulation, IShadowfbIntValueSimulation, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerInt _MinValue;
		public Vortex.Connector.ValueTypes.OnlinerInt MinValue
		{
			get
			{
				return _MinValue;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IfbIntValueSimulation.MinValue
		{
			get
			{
				return MinValue;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowfbIntValueSimulation.MinValue
		{
			get
			{
				return MinValue;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _MaxValue;
		public Vortex.Connector.ValueTypes.OnlinerInt MaxValue
		{
			get
			{
				return _MaxValue;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IfbIntValueSimulation.MaxValue
		{
			get
			{
				return MaxValue;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowfbIntValueSimulation.MaxValue
		{
			get
			{
				return MaxValue;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _p1;
		public Vortex.Connector.ValueTypes.OnlinerInt p1
		{
			get
			{
				return _p1;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IfbIntValueSimulation.p1
		{
			get
			{
				return p1;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowfbIntValueSimulation.p1
		{
			get
			{
				return p1;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _p2;
		public Vortex.Connector.ValueTypes.OnlinerInt p2
		{
			get
			{
				return _p2;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IfbIntValueSimulation.p2
		{
			get
			{
				return p2;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowfbIntValueSimulation.p2
		{
			get
			{
				return p2;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _pm;
		public Vortex.Connector.ValueTypes.OnlinerInt pm
		{
			get
			{
				return _pm;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IfbIntValueSimulation.pm
		{
			get
			{
				return pm;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowfbIntValueSimulation.pm
		{
			get
			{
				return pm;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _x0;
		public Vortex.Connector.ValueTypes.OnlinerInt x0
		{
			get
			{
				return _x0;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IfbIntValueSimulation.x0
		{
			get
			{
				return x0;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowfbIntValueSimulation.x0
		{
			get
			{
				return x0;
			}
		}

		public void LazyOnlineToShadow()
		{
			MinValue.Shadow = MinValue.LastValue;
			MaxValue.Shadow = MaxValue.LastValue;
			p1.Shadow = p1.LastValue;
			p2.Shadow = p2.LastValue;
			pm.Shadow = pm.LastValue;
			x0.Shadow = x0.LastValue;
		}

		public void LazyShadowToOnline()
		{
			MinValue.Cyclic = MinValue.Shadow;
			MaxValue.Cyclic = MaxValue.Shadow;
			p1.Cyclic = p1.Shadow;
			p2.Cyclic = p2.Shadow;
			pm.Cyclic = pm.Shadow;
			x0.Cyclic = x0.Shadow;
		}

		public PlainfbIntValueSimulation CreatePlainerType()
		{
			var cloned = new PlainfbIntValueSimulation();
			return cloned;
		}

		protected PlainfbIntValueSimulation CreatePlainerType(PlainfbIntValueSimulation cloned)
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

		public void FlushPlainToOnline(RoomController.PlainfbIntValueSimulation source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(RoomController.PlainfbIntValueSimulation source)
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

		public void FlushOnlineToPlain(RoomController.PlainfbIntValueSimulation source)
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

		public fbIntValueSimulation(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_MinValue = @Connector.Online.Adapter.CreateINT(this, "", "MinValue");
			_MaxValue = @Connector.Online.Adapter.CreateINT(this, "", "MaxValue");
			_p1 = @Connector.Online.Adapter.CreateINT(this, "", "p1");
			_p2 = @Connector.Online.Adapter.CreateINT(this, "", "p2");
			_pm = @Connector.Online.Adapter.CreateINT(this, "", "pm");
			_x0 = @Connector.Online.Adapter.CreateINT(this, "", "x0");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public fbIntValueSimulation()
		{
			PexPreConstructorParameterless();
			_MinValue = Vortex.Connector.IConnectorFactory.CreateINT();
			_MaxValue = Vortex.Connector.IConnectorFactory.CreateINT();
			_p1 = Vortex.Connector.IConnectorFactory.CreateINT();
			_p2 = Vortex.Connector.IConnectorFactory.CreateINT();
			_pm = Vortex.Connector.IConnectorFactory.CreateINT();
			_x0 = Vortex.Connector.IConnectorFactory.CreateINT();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbIntValueSimulation
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbIntValueSimulation()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbIntValueSimulation : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineInt MinValue
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt MaxValue
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt p1
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt p2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt pm
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt x0
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainfbIntValueSimulation CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(RoomController.PlainfbIntValueSimulation source);
		void FlushOnlineToPlain(RoomController.PlainfbIntValueSimulation source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbIntValueSimulation : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowInt MinValue
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt MaxValue
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt p1
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt p2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt pm
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt x0
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainfbIntValueSimulation CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(RoomController.PlainfbIntValueSimulation source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbIntValueSimulation : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Int16 _MinValue;
		public System.Int16 MinValue
		{
			get
			{
				return _MinValue;
			}

			set
			{
				if (_MinValue != value)
				{
					_MinValue = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MinValue)));
				}
			}
		}

		System.Int16 _MaxValue;
		public System.Int16 MaxValue
		{
			get
			{
				return _MaxValue;
			}

			set
			{
				if (_MaxValue != value)
				{
					_MaxValue = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MaxValue)));
				}
			}
		}

		System.Int16 _p1;
		public System.Int16 p1
		{
			get
			{
				return _p1;
			}

			set
			{
				if (_p1 != value)
				{
					_p1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(p1)));
				}
			}
		}

		System.Int16 _p2;
		public System.Int16 p2
		{
			get
			{
				return _p2;
			}

			set
			{
				if (_p2 != value)
				{
					_p2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(p2)));
				}
			}
		}

		System.Int16 _pm;
		public System.Int16 pm
		{
			get
			{
				return _pm;
			}

			set
			{
				if (_pm != value)
				{
					_pm = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(pm)));
				}
			}
		}

		System.Int16 _x0;
		public System.Int16 x0
		{
			get
			{
				return _x0;
			}

			set
			{
				if (_x0 != value)
				{
					_x0 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(x0)));
				}
			}
		}

		public void CopyPlainToCyclic(RoomController.fbIntValueSimulation target)
		{
			target.MinValue.Cyclic = MinValue;
			target.MaxValue.Cyclic = MaxValue;
			target.p1.Cyclic = p1;
			target.p2.Cyclic = p2;
			target.pm.Cyclic = pm;
			target.x0.Cyclic = x0;
		}

		public void CopyPlainToCyclic(RoomController.IfbIntValueSimulation target)
		{
			this.CopyPlainToCyclic((RoomController.fbIntValueSimulation)target);
		}

		public void CopyPlainToShadow(RoomController.fbIntValueSimulation target)
		{
			target.MinValue.Shadow = MinValue;
			target.MaxValue.Shadow = MaxValue;
			target.p1.Shadow = p1;
			target.p2.Shadow = p2;
			target.pm.Shadow = pm;
			target.x0.Shadow = x0;
		}

		public void CopyPlainToShadow(RoomController.IShadowfbIntValueSimulation target)
		{
			this.CopyPlainToShadow((RoomController.fbIntValueSimulation)target);
		}

		public void CopyCyclicToPlain(RoomController.fbIntValueSimulation source)
		{
			MinValue = source.MinValue.LastValue;
			MaxValue = source.MaxValue.LastValue;
			p1 = source.p1.LastValue;
			p2 = source.p2.LastValue;
			pm = source.pm.LastValue;
			x0 = source.x0.LastValue;
		}

		public void CopyCyclicToPlain(RoomController.IfbIntValueSimulation source)
		{
			this.CopyCyclicToPlain((RoomController.fbIntValueSimulation)source);
		}

		public void CopyShadowToPlain(RoomController.fbIntValueSimulation source)
		{
			MinValue = source.MinValue.Shadow;
			MaxValue = source.MaxValue.Shadow;
			p1 = source.p1.Shadow;
			p2 = source.p2.Shadow;
			pm = source.pm.Shadow;
			x0 = source.x0.Shadow;
		}

		public void CopyShadowToPlain(RoomController.IShadowfbIntValueSimulation source)
		{
			this.CopyShadowToPlain((RoomController.fbIntValueSimulation)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbIntValueSimulation()
		{
		}
	}
}