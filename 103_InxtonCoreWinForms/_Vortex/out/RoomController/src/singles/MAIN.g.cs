using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace RoomController
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MAIN", "RoomController", TypeComplexityEnum.Complex)]
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
				return RoomControllerTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		stRoomData _RoomData;
		public stRoomData RoomData
		{
			get
			{
				return _RoomData;
			}
		}

		IstRoomData IMAIN.RoomData
		{
			get
			{
				return RoomData;
			}
		}

		IShadowstRoomData IShadowMAIN.RoomData
		{
			get
			{
				return RoomData;
			}
		}

		public void LazyOnlineToShadow()
		{
			RoomData.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			RoomData.LazyShadowToOnline();
		}

		public PlainMAIN CreatePlainerType()
		{
			var cloned = new PlainMAIN();
			cloned.RoomData = RoomData.CreatePlainerType();
			return cloned;
		}

		protected PlainMAIN CreatePlainerType(PlainMAIN cloned)
		{
			cloned.RoomData = RoomData.CreatePlainerType();
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

		public void FlushPlainToOnline(RoomController.PlainMAIN source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(RoomController.PlainMAIN source)
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

		public void FlushOnlineToPlain(RoomController.PlainMAIN source)
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
			_RoomData = new stRoomData(this, "", "RoomData");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public MAIN()
		{
			PexPreConstructorParameterless();
			_RoomData = new stRoomData();
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
		IstRoomData RoomData
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainMAIN CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(RoomController.PlainMAIN source);
		void FlushOnlineToPlain(RoomController.PlainMAIN source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowMAIN : Vortex.Connector.IVortexShadowObject
	{
		IShadowstRoomData RoomData
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainMAIN CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(RoomController.PlainMAIN source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMAIN : Vortex.Connector.IPlain
	{
		PlainstRoomData _RoomData;
		public PlainstRoomData RoomData
		{
			get
			{
				return _RoomData;
			}

			set
			{
				_RoomData = value;
			}
		}

		public void CopyPlainToCyclic(RoomController.MAIN target)
		{
			RoomData.CopyPlainToCyclic(target.RoomData);
		}

		public void CopyPlainToCyclic(RoomController.IMAIN target)
		{
			this.CopyPlainToCyclic((RoomController.MAIN)target);
		}

		public void CopyPlainToShadow(RoomController.MAIN target)
		{
			RoomData.CopyPlainToShadow(target.RoomData);
		}

		public void CopyPlainToShadow(RoomController.IShadowMAIN target)
		{
			this.CopyPlainToShadow((RoomController.MAIN)target);
		}

		public void CopyCyclicToPlain(RoomController.MAIN source)
		{
			RoomData.CopyCyclicToPlain(source.RoomData);
		}

		public void CopyCyclicToPlain(RoomController.IMAIN source)
		{
			this.CopyCyclicToPlain((RoomController.MAIN)source);
		}

		public void CopyShadowToPlain(RoomController.MAIN source)
		{
			RoomData.CopyShadowToPlain(source.RoomData);
		}

		public void CopyShadowToPlain(RoomController.IShadowMAIN source)
		{
			this.CopyShadowToPlain((RoomController.MAIN)source);
		}

		public PlainMAIN()
		{
			_RoomData = new PlainstRoomData();
		}
	}
}