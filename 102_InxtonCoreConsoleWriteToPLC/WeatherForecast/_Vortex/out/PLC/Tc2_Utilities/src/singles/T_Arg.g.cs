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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "T_Arg", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class T_Arg : Vortex.Connector.IVortexObject, IT_Arg, IShadowT_Arg, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerInt _eType;
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_ArgType))]
		public Vortex.Connector.ValueTypes.OnlinerInt eType
		{
			get
			{
				return _eType;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_ArgType))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IT_Arg.eType
		{
			get
			{
				return eType;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_ArgType))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowT_Arg.eType
		{
			get
			{
				return eType;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _cbLen;
		public Vortex.Connector.ValueTypes.OnlinerUDInt cbLen
		{
			get
			{
				return _cbLen;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IT_Arg.cbLen
		{
			get
			{
				return cbLen;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowT_Arg.cbLen
		{
			get
			{
				return cbLen;
			}
		}

		public void LazyOnlineToShadow()
		{
			eType.Shadow = eType.LastValue;
			cbLen.Shadow = cbLen.LastValue;
		}

		public void LazyShadowToOnline()
		{
			eType.Cyclic = eType.Shadow;
			cbLen.Cyclic = cbLen.Shadow;
		}

		public PlainT_Arg CreatePlainerType()
		{
			var cloned = new PlainT_Arg();
			return cloned;
		}

		protected PlainT_Arg CreatePlainerType(PlainT_Arg cloned)
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainT_Arg source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainT_Arg source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainT_Arg source)
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

		public T_Arg(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_eType = @Connector.Online.Adapter.CreateINT(this, "", "eType");
			_cbLen = @Connector.Online.Adapter.CreateUDINT(this, "", "cbLen");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public T_Arg()
		{
			PexPreConstructorParameterless();
			_eType = Vortex.Connector.IConnectorFactory.CreateINT();
			_cbLen = Vortex.Connector.IConnectorFactory.CreateUDINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IT_Arg : Vortex.Connector.IVortexOnlineObject
	{
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_ArgType))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt eType
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt cbLen
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainT_Arg CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainT_Arg source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainT_Arg source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowT_Arg : Vortex.Connector.IVortexShadowObject
	{
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_ArgType))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt eType
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt cbLen
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainT_Arg CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainT_Arg source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainT_Arg : Vortex.Connector.IPlain
	{
		System.Int16 _eType;
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (Tc2_Utilities.E_ArgType))]
		public System.Int16 eType
		{
			get
			{
				return _eType;
			}

			set
			{
				_eType = value;
			}
		}

		System.UInt32 _cbLen;
		public System.UInt32 cbLen
		{
			get
			{
				return _cbLen;
			}

			set
			{
				_cbLen = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.T_Arg target)
		{
			target.eType.Cyclic = eType;
			target.cbLen.Cyclic = cbLen;
		}

		public void CopyPlainToCyclic(Tc2_Utilities.IT_Arg target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.T_Arg)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.T_Arg target)
		{
			target.eType.Shadow = eType;
			target.cbLen.Shadow = cbLen;
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowT_Arg target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.T_Arg)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.T_Arg source)
		{
			eType = source.eType.LastValue;
			cbLen = source.cbLen.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Utilities.IT_Arg source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.T_Arg)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.T_Arg source)
		{
			eType = source.eType.Shadow;
			cbLen = source.cbLen.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowT_Arg source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.T_Arg)source);
		}

		public PlainT_Arg()
		{
		}
	}
}