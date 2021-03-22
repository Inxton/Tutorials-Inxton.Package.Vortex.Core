using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace RoomController
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "IO", "RoomController", TypeComplexityEnum.Complex)]
	public partial class IO : Vortex.Connector.IVortexObject, IIO, IShadowIO, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		stAi8CH _hwAirDataIN;
		public stAi8CH hwAirDataIN
		{
			get
			{
				return _hwAirDataIN;
			}
		}

		IstAi8CH IIO.hwAirDataIN
		{
			get
			{
				return hwAirDataIN;
			}
		}

		IShadowstAi8CH IShadowIO.hwAirDataIN
		{
			get
			{
				return hwAirDataIN;
			}
		}

		public void LazyOnlineToShadow()
		{
			hwAirDataIN.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			hwAirDataIN.LazyShadowToOnline();
		}

		public PlainIO CreatePlainerType()
		{
			var cloned = new PlainIO();
			cloned.hwAirDataIN = hwAirDataIN.CreatePlainerType();
			return cloned;
		}

		protected PlainIO CreatePlainerType(PlainIO cloned)
		{
			cloned.hwAirDataIN = hwAirDataIN.CreatePlainerType();
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

		public void FlushPlainToOnline(RoomController.PlainIO source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(RoomController.PlainIO source)
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

		public void FlushOnlineToPlain(RoomController.PlainIO source)
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

		public IO(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_hwAirDataIN = new stAi8CH(this, "", "hwAirDataIN");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public IO()
		{
			PexPreConstructorParameterless();
			_hwAirDataIN = new stAi8CH();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcIO
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcIO()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IIO : Vortex.Connector.IVortexOnlineObject
	{
		IstAi8CH hwAirDataIN
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainIO CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(RoomController.PlainIO source);
		void FlushOnlineToPlain(RoomController.PlainIO source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowIO : Vortex.Connector.IVortexShadowObject
	{
		IShadowstAi8CH hwAirDataIN
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainIO CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(RoomController.PlainIO source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainIO : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainstAi8CH _hwAirDataIN;
		public PlainstAi8CH hwAirDataIN
		{
			get
			{
				return _hwAirDataIN;
			}

			set
			{
				if (_hwAirDataIN != value)
				{
					_hwAirDataIN = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(hwAirDataIN)));
				}
			}
		}

		public void CopyPlainToCyclic(RoomController.IO target)
		{
			hwAirDataIN.CopyPlainToCyclic(target.hwAirDataIN);
		}

		public void CopyPlainToCyclic(RoomController.IIO target)
		{
			this.CopyPlainToCyclic((RoomController.IO)target);
		}

		public void CopyPlainToShadow(RoomController.IO target)
		{
			hwAirDataIN.CopyPlainToShadow(target.hwAirDataIN);
		}

		public void CopyPlainToShadow(RoomController.IShadowIO target)
		{
			this.CopyPlainToShadow((RoomController.IO)target);
		}

		public void CopyCyclicToPlain(RoomController.IO source)
		{
			hwAirDataIN.CopyCyclicToPlain(source.hwAirDataIN);
		}

		public void CopyCyclicToPlain(RoomController.IIO source)
		{
			this.CopyCyclicToPlain((RoomController.IO)source);
		}

		public void CopyShadowToPlain(RoomController.IO source)
		{
			hwAirDataIN.CopyShadowToPlain(source.hwAirDataIN);
		}

		public void CopyShadowToPlain(RoomController.IShadowIO source)
		{
			this.CopyShadowToPlain((RoomController.IO)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainIO()
		{
			_hwAirDataIN = new PlainstAi8CH();
		}
	}
}