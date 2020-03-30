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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "GETCPUCOUNTER", "Tc2_System", TypeComplexityEnum.Complex)]
	public partial class GETCPUCOUNTER : Vortex.Connector.IVortexObject, IGETCPUCOUNTER, IShadowGETCPUCOUNTER, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerUDInt _cpuCntLoDW;
		public Vortex.Connector.ValueTypes.OnlinerUDInt cpuCntLoDW
		{
			get
			{
				return _cpuCntLoDW;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IGETCPUCOUNTER.cpuCntLoDW
		{
			get
			{
				return cpuCntLoDW;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowGETCPUCOUNTER.cpuCntLoDW
		{
			get
			{
				return cpuCntLoDW;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _cpuCntHiDW;
		public Vortex.Connector.ValueTypes.OnlinerUDInt cpuCntHiDW
		{
			get
			{
				return _cpuCntHiDW;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IGETCPUCOUNTER.cpuCntHiDW
		{
			get
			{
				return cpuCntHiDW;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowGETCPUCOUNTER.cpuCntHiDW
		{
			get
			{
				return cpuCntHiDW;
			}
		}

		Tc2_System.FW_GetCpuCounter _fbGetCpuCounter;
		internal Tc2_System.FW_GetCpuCounter fbGetCpuCounter
		{
			get
			{
				return _fbGetCpuCounter;
			}
		}

		public void LazyOnlineToShadow()
		{
			cpuCntLoDW.Shadow = cpuCntLoDW.LastValue;
			cpuCntHiDW.Shadow = cpuCntHiDW.LastValue;
		}

		public void LazyShadowToOnline()
		{
			cpuCntLoDW.Cyclic = cpuCntLoDW.Shadow;
			cpuCntHiDW.Cyclic = cpuCntHiDW.Shadow;
		}

		public PlainGETCPUCOUNTER CreatePlainerType()
		{
			var cloned = new PlainGETCPUCOUNTER();
			cloned.fbGetCpuCounter = fbGetCpuCounter.CreatePlainerType();
			return cloned;
		}

		protected PlainGETCPUCOUNTER CreatePlainerType(PlainGETCPUCOUNTER cloned)
		{
			cloned.fbGetCpuCounter = fbGetCpuCounter.CreatePlainerType();
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

		public void FlushPlainToOnline(Tc2_System.PlainGETCPUCOUNTER source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_System.PlainGETCPUCOUNTER source)
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

		public void FlushOnlineToPlain(Tc2_System.PlainGETCPUCOUNTER source)
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

		public GETCPUCOUNTER(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_cpuCntLoDW = @Connector.Online.Adapter.CreateUDINT(this, "", "cpuCntLoDW");
			_cpuCntHiDW = @Connector.Online.Adapter.CreateUDINT(this, "", "cpuCntHiDW");
			_fbGetCpuCounter = new Tc2_System.FW_GetCpuCounter(this, "", "fbGetCpuCounter");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public GETCPUCOUNTER()
		{
			PexPreConstructorParameterless();
			_cpuCntLoDW = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_cpuCntHiDW = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_fbGetCpuCounter = new Tc2_System.FW_GetCpuCounter();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IGETCPUCOUNTER : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUDInt cpuCntLoDW
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt cpuCntHiDW
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_System.PlainGETCPUCOUNTER CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_System.PlainGETCPUCOUNTER source);
		void FlushOnlineToPlain(Tc2_System.PlainGETCPUCOUNTER source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowGETCPUCOUNTER : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt cpuCntLoDW
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt cpuCntHiDW
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_System.PlainGETCPUCOUNTER CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_System.PlainGETCPUCOUNTER source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainGETCPUCOUNTER : Vortex.Connector.IPlain
	{
		System.UInt32 _cpuCntLoDW;
		public System.UInt32 cpuCntLoDW
		{
			get
			{
				return _cpuCntLoDW;
			}

			set
			{
				_cpuCntLoDW = value;
			}
		}

		System.UInt32 _cpuCntHiDW;
		public System.UInt32 cpuCntHiDW
		{
			get
			{
				return _cpuCntHiDW;
			}

			set
			{
				_cpuCntHiDW = value;
			}
		}

		Tc2_System.PlainFW_GetCpuCounter _fbGetCpuCounter;
		internal Tc2_System.PlainFW_GetCpuCounter fbGetCpuCounter
		{
			get
			{
				return _fbGetCpuCounter;
			}

			set
			{
				_fbGetCpuCounter = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_System.GETCPUCOUNTER target)
		{
			target.cpuCntLoDW.Cyclic = cpuCntLoDW;
			target.cpuCntHiDW.Cyclic = cpuCntHiDW;
			fbGetCpuCounter.CopyPlainToCyclic(target.fbGetCpuCounter);
		}

		public void CopyPlainToCyclic(Tc2_System.IGETCPUCOUNTER target)
		{
			this.CopyPlainToCyclic((Tc2_System.GETCPUCOUNTER)target);
		}

		public void CopyPlainToShadow(Tc2_System.GETCPUCOUNTER target)
		{
			target.cpuCntLoDW.Shadow = cpuCntLoDW;
			target.cpuCntHiDW.Shadow = cpuCntHiDW;
			fbGetCpuCounter.CopyPlainToShadow(target.fbGetCpuCounter);
		}

		public void CopyPlainToShadow(Tc2_System.IShadowGETCPUCOUNTER target)
		{
			this.CopyPlainToShadow((Tc2_System.GETCPUCOUNTER)target);
		}

		public void CopyCyclicToPlain(Tc2_System.GETCPUCOUNTER source)
		{
			cpuCntLoDW = source.cpuCntLoDW.LastValue;
			cpuCntHiDW = source.cpuCntHiDW.LastValue;
			fbGetCpuCounter.CopyCyclicToPlain(source.fbGetCpuCounter);
		}

		public void CopyCyclicToPlain(Tc2_System.IGETCPUCOUNTER source)
		{
			this.CopyCyclicToPlain((Tc2_System.GETCPUCOUNTER)source);
		}

		public void CopyShadowToPlain(Tc2_System.GETCPUCOUNTER source)
		{
			cpuCntLoDW = source.cpuCntLoDW.Shadow;
			cpuCntHiDW = source.cpuCntHiDW.Shadow;
			fbGetCpuCounter.CopyShadowToPlain(source.fbGetCpuCounter);
		}

		public void CopyShadowToPlain(Tc2_System.IShadowGETCPUCOUNTER source)
		{
			this.CopyShadowToPlain((Tc2_System.GETCPUCOUNTER)source);
		}

		public PlainGETCPUCOUNTER()
		{
			_fbGetCpuCounter = new Tc2_System.PlainFW_GetCpuCounter();
		}
	}
}