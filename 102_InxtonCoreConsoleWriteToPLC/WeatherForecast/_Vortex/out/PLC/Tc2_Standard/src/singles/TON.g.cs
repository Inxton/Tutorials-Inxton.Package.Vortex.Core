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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "TON", "Tc2_Standard", TypeComplexityEnum.Complex)]
	public partial class TON : Vortex.Connector.IVortexObject, ITON, IShadowTON, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _IN;
		public Vortex.Connector.ValueTypes.OnlinerBool IN
		{
			get
			{
				return _IN;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ITON.IN
		{
			get
			{
				return IN;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowTON.IN
		{
			get
			{
				return IN;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTime _PT;
		public Vortex.Connector.ValueTypes.OnlinerTime PT
		{
			get
			{
				return _PT;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime ITON.PT
		{
			get
			{
				return PT;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowTON.PT
		{
			get
			{
				return PT;
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool ITON.Q
		{
			get
			{
				return Q;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowTON.Q
		{
			get
			{
				return Q;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTime _ET;
		public Vortex.Connector.ValueTypes.OnlinerTime ET
		{
			get
			{
				return _ET;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime ITON.ET
		{
			get
			{
				return ET;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowTON.ET
		{
			get
			{
				return ET;
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool ITON.M
		{
			get
			{
				return M;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowTON.M
		{
			get
			{
				return M;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTime _StartTime;
		public Vortex.Connector.ValueTypes.OnlinerTime StartTime
		{
			get
			{
				return _StartTime;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime ITON.StartTime
		{
			get
			{
				return StartTime;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowTON.StartTime
		{
			get
			{
				return StartTime;
			}
		}

		public void LazyOnlineToShadow()
		{
			IN.Shadow = IN.LastValue;
			PT.Shadow = PT.LastValue;
			Q.Shadow = Q.LastValue;
			ET.Shadow = ET.LastValue;
			M.Shadow = M.LastValue;
			StartTime.Shadow = StartTime.LastValue;
		}

		public void LazyShadowToOnline()
		{
			IN.Cyclic = IN.Shadow;
			PT.Cyclic = PT.Shadow;
			Q.Cyclic = Q.Shadow;
			ET.Cyclic = ET.Shadow;
			M.Cyclic = M.Shadow;
			StartTime.Cyclic = StartTime.Shadow;
		}

		public PlainTON CreatePlainerType()
		{
			var cloned = new PlainTON();
			return cloned;
		}

		protected PlainTON CreatePlainerType(PlainTON cloned)
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

		public void FlushPlainToOnline(Tc2_Standard.PlainTON source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Standard.PlainTON source)
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

		public void FlushOnlineToPlain(Tc2_Standard.PlainTON source)
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

		public TON(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_IN = @Connector.Online.Adapter.CreateBOOL(this, "", "IN");
			_PT = @Connector.Online.Adapter.CreateTIME(this, "", "PT");
			_Q = @Connector.Online.Adapter.CreateBOOL(this, "", "Q");
			_ET = @Connector.Online.Adapter.CreateTIME(this, "", "ET");
			_M = @Connector.Online.Adapter.CreateBOOL(this, "", "M");
			_StartTime = @Connector.Online.Adapter.CreateTIME(this, "", "StartTime");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public TON()
		{
			PexPreConstructorParameterless();
			_IN = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_PT = Vortex.Connector.IConnectorFactory.CreateTIME();
			_Q = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_ET = Vortex.Connector.IConnectorFactory.CreateTIME();
			_M = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_StartTime = Vortex.Connector.IConnectorFactory.CreateTIME();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface ITON : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool IN
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime PT
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Q
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime ET
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool M
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime StartTime
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Standard.PlainTON CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Standard.PlainTON source);
		void FlushOnlineToPlain(Tc2_Standard.PlainTON source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowTON : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IN
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime PT
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Q
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime ET
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool M
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime StartTime
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Standard.PlainTON CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Standard.PlainTON source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTON : Vortex.Connector.IPlain
	{
		System.Boolean _IN;
		public System.Boolean IN
		{
			get
			{
				return _IN;
			}

			set
			{
				_IN = value;
			}
		}

		System.TimeSpan _PT;
		public System.TimeSpan PT
		{
			get
			{
				return _PT;
			}

			set
			{
				_PT = value;
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

		System.TimeSpan _ET;
		public System.TimeSpan ET
		{
			get
			{
				return _ET;
			}

			set
			{
				_ET = value;
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

		System.TimeSpan _StartTime;
		public System.TimeSpan StartTime
		{
			get
			{
				return _StartTime;
			}

			set
			{
				_StartTime = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Standard.TON target)
		{
			target.IN.Cyclic = IN;
			target.PT.Cyclic = PT;
			target.Q.Cyclic = Q;
			target.ET.Cyclic = ET;
			target.M.Cyclic = M;
			target.StartTime.Cyclic = StartTime;
		}

		public void CopyPlainToCyclic(Tc2_Standard.ITON target)
		{
			this.CopyPlainToCyclic((Tc2_Standard.TON)target);
		}

		public void CopyPlainToShadow(Tc2_Standard.TON target)
		{
			target.IN.Shadow = IN;
			target.PT.Shadow = PT;
			target.Q.Shadow = Q;
			target.ET.Shadow = ET;
			target.M.Shadow = M;
			target.StartTime.Shadow = StartTime;
		}

		public void CopyPlainToShadow(Tc2_Standard.IShadowTON target)
		{
			this.CopyPlainToShadow((Tc2_Standard.TON)target);
		}

		public void CopyCyclicToPlain(Tc2_Standard.TON source)
		{
			IN = source.IN.LastValue;
			PT = source.PT.LastValue;
			Q = source.Q.LastValue;
			ET = source.ET.LastValue;
			M = source.M.LastValue;
			StartTime = source.StartTime.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Standard.ITON source)
		{
			this.CopyCyclicToPlain((Tc2_Standard.TON)source);
		}

		public void CopyShadowToPlain(Tc2_Standard.TON source)
		{
			IN = source.IN.Shadow;
			PT = source.PT.Shadow;
			Q = source.Q.Shadow;
			ET = source.ET.Shadow;
			M = source.M.Shadow;
			StartTime = source.StartTime.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Standard.IShadowTON source)
		{
			this.CopyShadowToPlain((Tc2_Standard.TON)source);
		}

		public PlainTON()
		{
		}
	}
}