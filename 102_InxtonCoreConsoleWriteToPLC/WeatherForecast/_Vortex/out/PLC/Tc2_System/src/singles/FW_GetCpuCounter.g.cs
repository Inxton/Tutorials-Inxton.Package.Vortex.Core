using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Tc2_System
{
	
            /// <summary>
            /// This is an external type. No documentation available.
            /// </summary>
            /// <exclude />
	[IgnoreReflection()]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "FW_GetCpuCounter", "Tc2_System", TypeComplexityEnum.Complex)]
	public partial class FW_GetCpuCounter : Vortex.Connector.IVortexObject, IFW_GetCpuCounter, IShadowFW_GetCpuCounter, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
				return Tc2_SystemTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerUDInt _dwCpuCntLo;
		public Vortex.Connector.ValueTypes.OnlinerUDInt dwCpuCntLo
		{
			get
			{
				return _dwCpuCntLo;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IFW_GetCpuCounter.dwCpuCntLo
		{
			get
			{
				return dwCpuCntLo;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowFW_GetCpuCounter.dwCpuCntLo
		{
			get
			{
				return dwCpuCntLo;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _dwCpuCntHi;
		public Vortex.Connector.ValueTypes.OnlinerUDInt dwCpuCntHi
		{
			get
			{
				return _dwCpuCntHi;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IFW_GetCpuCounter.dwCpuCntHi
		{
			get
			{
				return dwCpuCntHi;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowFW_GetCpuCounter.dwCpuCntHi
		{
			get
			{
				return dwCpuCntHi;
			}
		}

		public void LazyOnlineToShadow()
		{
			dwCpuCntLo.Shadow = dwCpuCntLo.LastValue;
			dwCpuCntHi.Shadow = dwCpuCntHi.LastValue;
		}

		public void LazyShadowToOnline()
		{
			dwCpuCntLo.Cyclic = dwCpuCntLo.Shadow;
			dwCpuCntHi.Cyclic = dwCpuCntHi.Shadow;
		}

		public PlainFW_GetCpuCounter CreatePlainerType()
		{
			var cloned = new PlainFW_GetCpuCounter();
			return cloned;
		}

		protected PlainFW_GetCpuCounter CreatePlainerType(PlainFW_GetCpuCounter cloned)
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

		public void FlushPlainToOnline(Tc2_System.PlainFW_GetCpuCounter source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_System.PlainFW_GetCpuCounter source)
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

		public void FlushOnlineToPlain(Tc2_System.PlainFW_GetCpuCounter source)
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
				return Tc2_SystemTwinController.Translator.Translate(_AttributeName).Interpolate(this);
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

		public FW_GetCpuCounter(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_dwCpuCntLo = @Connector.Online.Adapter.CreateUDINT(this, "", "dwCpuCntLo");
			_dwCpuCntHi = @Connector.Online.Adapter.CreateUDINT(this, "", "dwCpuCntHi");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public FW_GetCpuCounter()
		{
			PexPreConstructorParameterless();
			_dwCpuCntLo = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_dwCpuCntHi = Vortex.Connector.IConnectorFactory.CreateUDINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IFW_GetCpuCounter : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUDInt dwCpuCntLo
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt dwCpuCntHi
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_System.PlainFW_GetCpuCounter CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_System.PlainFW_GetCpuCounter source);
		void FlushOnlineToPlain(Tc2_System.PlainFW_GetCpuCounter source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowFW_GetCpuCounter : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt dwCpuCntLo
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt dwCpuCntHi
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_System.PlainFW_GetCpuCounter CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_System.PlainFW_GetCpuCounter source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainFW_GetCpuCounter : Vortex.Connector.IPlain
	{
		System.UInt32 _dwCpuCntLo;
		public System.UInt32 dwCpuCntLo
		{
			get
			{
				return _dwCpuCntLo;
			}

			set
			{
				_dwCpuCntLo = value;
			}
		}

		System.UInt32 _dwCpuCntHi;
		public System.UInt32 dwCpuCntHi
		{
			get
			{
				return _dwCpuCntHi;
			}

			set
			{
				_dwCpuCntHi = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_System.FW_GetCpuCounter target)
		{
			target.dwCpuCntLo.Cyclic = dwCpuCntLo;
			target.dwCpuCntHi.Cyclic = dwCpuCntHi;
		}

		public void CopyPlainToCyclic(Tc2_System.IFW_GetCpuCounter target)
		{
			this.CopyPlainToCyclic((Tc2_System.FW_GetCpuCounter)target);
		}

		public void CopyPlainToShadow(Tc2_System.FW_GetCpuCounter target)
		{
			target.dwCpuCntLo.Shadow = dwCpuCntLo;
			target.dwCpuCntHi.Shadow = dwCpuCntHi;
		}

		public void CopyPlainToShadow(Tc2_System.IShadowFW_GetCpuCounter target)
		{
			this.CopyPlainToShadow((Tc2_System.FW_GetCpuCounter)target);
		}

		public void CopyCyclicToPlain(Tc2_System.FW_GetCpuCounter source)
		{
			dwCpuCntLo = source.dwCpuCntLo.LastValue;
			dwCpuCntHi = source.dwCpuCntHi.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_System.IFW_GetCpuCounter source)
		{
			this.CopyCyclicToPlain((Tc2_System.FW_GetCpuCounter)source);
		}

		public void CopyShadowToPlain(Tc2_System.FW_GetCpuCounter source)
		{
			dwCpuCntLo = source.dwCpuCntLo.Shadow;
			dwCpuCntHi = source.dwCpuCntHi.Shadow;
		}

		public void CopyShadowToPlain(Tc2_System.IShadowFW_GetCpuCounter source)
		{
			this.CopyShadowToPlain((Tc2_System.FW_GetCpuCounter)source);
		}

		public PlainFW_GetCpuCounter()
		{
		}
	}
}