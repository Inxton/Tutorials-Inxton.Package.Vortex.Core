using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace RoomController
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stAi4CH", "RoomController", TypeComplexityEnum.Complex)]
	public partial class stAi4CH : Vortex.Connector.IVortexObject, IstAi4CH, IShadowstAi4CH, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerInt _CH1;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerInt CH1
		{
			get
			{
				return _CH1;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IstAi4CH.CH1
		{
			get
			{
				return CH1;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstAi4CH.CH1
		{
			get
			{
				return CH1;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _CH2;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerInt CH2
		{
			get
			{
				return _CH2;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IstAi4CH.CH2
		{
			get
			{
				return CH2;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstAi4CH.CH2
		{
			get
			{
				return CH2;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _CH3;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerInt CH3
		{
			get
			{
				return _CH3;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IstAi4CH.CH3
		{
			get
			{
				return CH3;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstAi4CH.CH3
		{
			get
			{
				return CH3;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _CH4;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerInt CH4
		{
			get
			{
				return _CH4;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IstAi4CH.CH4
		{
			get
			{
				return CH4;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstAi4CH.CH4
		{
			get
			{
				return CH4;
			}
		}

		public void LazyOnlineToShadow()
		{
			CH1.Shadow = CH1.LastValue;
			CH2.Shadow = CH2.LastValue;
			CH3.Shadow = CH3.LastValue;
			CH4.Shadow = CH4.LastValue;
		}

		public void LazyShadowToOnline()
		{
			CH1.Cyclic = CH1.Shadow;
			CH2.Cyclic = CH2.Shadow;
			CH3.Cyclic = CH3.Shadow;
			CH4.Cyclic = CH4.Shadow;
		}

		public PlainstAi4CH CreatePlainerType()
		{
			var cloned = new PlainstAi4CH();
			return cloned;
		}

		protected PlainstAi4CH CreatePlainerType(PlainstAi4CH cloned)
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

		public void FlushPlainToOnline(RoomController.PlainstAi4CH source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(RoomController.PlainstAi4CH source)
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

		public void FlushOnlineToPlain(RoomController.PlainstAi4CH source)
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

		public stAi4CH(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_CH1 = @Connector.Online.Adapter.CreateINT(this, "", "CH1");
			_CH2 = @Connector.Online.Adapter.CreateINT(this, "", "CH2");
			_CH3 = @Connector.Online.Adapter.CreateINT(this, "", "CH3");
			_CH4 = @Connector.Online.Adapter.CreateINT(this, "", "CH4");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stAi4CH()
		{
			PexPreConstructorParameterless();
			_CH1 = Vortex.Connector.IConnectorFactory.CreateINT();
			_CH2 = Vortex.Connector.IConnectorFactory.CreateINT();
			_CH3 = Vortex.Connector.IConnectorFactory.CreateINT();
			_CH4 = Vortex.Connector.IConnectorFactory.CreateINT();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstAi4CH
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstAi4CH()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstAi4CH : Vortex.Connector.IVortexOnlineObject
	{
		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineInt CH1
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineInt CH2
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineInt CH3
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineInt CH4
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainstAi4CH CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(RoomController.PlainstAi4CH source);
		void FlushOnlineToPlain(RoomController.PlainstAi4CH source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstAi4CH : Vortex.Connector.IVortexShadowObject
	{
		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt CH1
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt CH2
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt CH3
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt CH4
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainstAi4CH CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(RoomController.PlainstAi4CH source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstAi4CH : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Int16 _CH1;
		[IoLinkable("Inputs")]
		public System.Int16 CH1
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

		System.Int16 _CH2;
		[IoLinkable("Inputs")]
		public System.Int16 CH2
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

		System.Int16 _CH3;
		[IoLinkable("Inputs")]
		public System.Int16 CH3
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

		System.Int16 _CH4;
		[IoLinkable("Inputs")]
		public System.Int16 CH4
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

		public void CopyPlainToCyclic(RoomController.stAi4CH target)
		{
			target.CH1.Cyclic = CH1;
			target.CH2.Cyclic = CH2;
			target.CH3.Cyclic = CH3;
			target.CH4.Cyclic = CH4;
		}

		public void CopyPlainToCyclic(RoomController.IstAi4CH target)
		{
			this.CopyPlainToCyclic((RoomController.stAi4CH)target);
		}

		public void CopyPlainToShadow(RoomController.stAi4CH target)
		{
			target.CH1.Shadow = CH1;
			target.CH2.Shadow = CH2;
			target.CH3.Shadow = CH3;
			target.CH4.Shadow = CH4;
		}

		public void CopyPlainToShadow(RoomController.IShadowstAi4CH target)
		{
			this.CopyPlainToShadow((RoomController.stAi4CH)target);
		}

		public void CopyCyclicToPlain(RoomController.stAi4CH source)
		{
			CH1 = source.CH1.LastValue;
			CH2 = source.CH2.LastValue;
			CH3 = source.CH3.LastValue;
			CH4 = source.CH4.LastValue;
		}

		public void CopyCyclicToPlain(RoomController.IstAi4CH source)
		{
			this.CopyCyclicToPlain((RoomController.stAi4CH)source);
		}

		public void CopyShadowToPlain(RoomController.stAi4CH source)
		{
			CH1 = source.CH1.Shadow;
			CH2 = source.CH2.Shadow;
			CH3 = source.CH3.Shadow;
			CH4 = source.CH4.Shadow;
		}

		public void CopyShadowToPlain(RoomController.IShadowstAi4CH source)
		{
			this.CopyShadowToPlain((RoomController.stAi4CH)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstAi4CH()
		{
		}
	}
}