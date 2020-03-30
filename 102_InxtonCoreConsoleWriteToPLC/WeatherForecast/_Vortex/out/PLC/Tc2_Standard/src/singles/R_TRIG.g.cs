using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Tc2_Standard
{
	
            /// <summary>
            /// This is an external type. No documentation available.
            /// </summary>
            /// <exclude />
	[IgnoreReflection()]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "R_TRIG", "Tc2_Standard", TypeComplexityEnum.Complex)]
	public partial class R_TRIG : Vortex.Connector.IVortexObject, IR_TRIG, IShadowR_TRIG, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
				return Tc2_StandardTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerBool _CLK;
		public Vortex.Connector.ValueTypes.OnlinerBool CLK
		{
			get
			{
				return _CLK;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IR_TRIG.CLK
		{
			get
			{
				return CLK;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowR_TRIG.CLK
		{
			get
			{
				return CLK;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Q;
		public Vortex.Connector.ValueTypes.OnlinerBool Q
		{
			get
			{
				return _Q;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IR_TRIG.Q
		{
			get
			{
				return Q;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowR_TRIG.Q
		{
			get
			{
				return Q;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _M;
		public Vortex.Connector.ValueTypes.OnlinerBool M
		{
			get
			{
				return _M;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IR_TRIG.M
		{
			get
			{
				return M;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowR_TRIG.M
		{
			get
			{
				return M;
			}
		}

		public void LazyOnlineToShadow()
		{
			CLK.Shadow = CLK.LastValue;
			Q.Shadow = Q.LastValue;
			M.Shadow = M.LastValue;
		}

		public void LazyShadowToOnline()
		{
			CLK.Cyclic = CLK.Shadow;
			Q.Cyclic = Q.Shadow;
			M.Cyclic = M.Shadow;
		}

		public PlainR_TRIG CreatePlainerType()
		{
			var cloned = new PlainR_TRIG();
			return cloned;
		}

		protected PlainR_TRIG CreatePlainerType(PlainR_TRIG cloned)
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

		public void FlushPlainToOnline(Tc2_Standard.PlainR_TRIG source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Standard.PlainR_TRIG source)
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

		public void FlushOnlineToPlain(Tc2_Standard.PlainR_TRIG source)
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
				return Tc2_StandardTwinController.Translator.Translate(_AttributeName).Interpolate(this);
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

		public R_TRIG(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_CLK = @Connector.Online.Adapter.CreateBOOL(this, "", "CLK");
			_Q = @Connector.Online.Adapter.CreateBOOL(this, "", "Q");
			_M = @Connector.Online.Adapter.CreateBOOL(this, "", "M");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public R_TRIG()
		{
			PexPreConstructorParameterless();
			_CLK = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_Q = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_M = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IR_TRIG : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool CLK
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Q
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool M
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Standard.PlainR_TRIG CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Standard.PlainR_TRIG source);
		void FlushOnlineToPlain(Tc2_Standard.PlainR_TRIG source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowR_TRIG : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool CLK
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Q
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool M
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Standard.PlainR_TRIG CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Standard.PlainR_TRIG source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainR_TRIG : Vortex.Connector.IPlain
	{
		System.Boolean _CLK;
		public System.Boolean CLK
		{
			get
			{
				return _CLK;
			}

			set
			{
				_CLK = value;
			}
		}

		System.Boolean _Q;
		public System.Boolean Q
		{
			get
			{
				return _Q;
			}

			set
			{
				_Q = value;
			}
		}

		System.Boolean _M;
		public System.Boolean M
		{
			get
			{
				return _M;
			}

			set
			{
				_M = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Standard.R_TRIG target)
		{
			target.CLK.Cyclic = CLK;
			target.Q.Cyclic = Q;
			target.M.Cyclic = M;
		}

		public void CopyPlainToCyclic(Tc2_Standard.IR_TRIG target)
		{
			this.CopyPlainToCyclic((Tc2_Standard.R_TRIG)target);
		}

		public void CopyPlainToShadow(Tc2_Standard.R_TRIG target)
		{
			target.CLK.Shadow = CLK;
			target.Q.Shadow = Q;
			target.M.Shadow = M;
		}

		public void CopyPlainToShadow(Tc2_Standard.IShadowR_TRIG target)
		{
			this.CopyPlainToShadow((Tc2_Standard.R_TRIG)target);
		}

		public void CopyCyclicToPlain(Tc2_Standard.R_TRIG source)
		{
			CLK = source.CLK.LastValue;
			Q = source.Q.LastValue;
			M = source.M.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Standard.IR_TRIG source)
		{
			this.CopyCyclicToPlain((Tc2_Standard.R_TRIG)source);
		}

		public void CopyShadowToPlain(Tc2_Standard.R_TRIG source)
		{
			CLK = source.CLK.Shadow;
			Q = source.Q.Shadow;
			M = source.M.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Standard.IShadowR_TRIG source)
		{
			this.CopyShadowToPlain((Tc2_Standard.R_TRIG)source);
		}

		public PlainR_TRIG()
		{
		}
	}
}