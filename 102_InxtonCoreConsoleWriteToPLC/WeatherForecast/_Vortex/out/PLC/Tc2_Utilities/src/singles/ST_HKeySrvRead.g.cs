using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Tc2_Utilities
{
	
            /// <summary>
            /// This is an external type. No documentation available.
            /// </summary>
            /// <exclude />
	[IgnoreReflection()]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "ST_HKeySrvRead", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class ST_HKeySrvRead : Vortex.Connector.IVortexObject, IST_HKeySrvRead, IShadowST_HKeySrvRead, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
				return Tc2_UtilitiesTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		public void LazyOnlineToShadow()
		{
		}

		public void LazyShadowToOnline()
		{
		}

		public PlainST_HKeySrvRead CreatePlainerType()
		{
			var cloned = new PlainST_HKeySrvRead();
			return cloned;
		}

		protected PlainST_HKeySrvRead CreatePlainerType(PlainST_HKeySrvRead cloned)
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainST_HKeySrvRead source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainST_HKeySrvRead source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainST_HKeySrvRead source)
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
				return Tc2_UtilitiesTwinController.Translator.Translate(_AttributeName).Interpolate(this);
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

		public ST_HKeySrvRead(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public ST_HKeySrvRead()
		{
			PexPreConstructorParameterless();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IST_HKeySrvRead : Vortex.Connector.IVortexOnlineObject
	{
		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainST_HKeySrvRead CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainST_HKeySrvRead source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainST_HKeySrvRead source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowST_HKeySrvRead : Vortex.Connector.IVortexShadowObject
	{
		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainST_HKeySrvRead CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainST_HKeySrvRead source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainST_HKeySrvRead : Vortex.Connector.IPlain
	{
		public void CopyPlainToCyclic(Tc2_Utilities.ST_HKeySrvRead target)
		{
		}

		public void CopyPlainToCyclic(Tc2_Utilities.IST_HKeySrvRead target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.ST_HKeySrvRead)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.ST_HKeySrvRead target)
		{
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowST_HKeySrvRead target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.ST_HKeySrvRead)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.ST_HKeySrvRead source)
		{
		}

		public void CopyCyclicToPlain(Tc2_Utilities.IST_HKeySrvRead source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.ST_HKeySrvRead)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.ST_HKeySrvRead source)
		{
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowST_HKeySrvRead source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.ST_HKeySrvRead)source);
		}

		public PlainST_HKeySrvRead()
		{
		}
	}
}