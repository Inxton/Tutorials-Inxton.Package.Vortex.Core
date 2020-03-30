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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "TIMESTRUCT", "Tc2_Utilities", TypeComplexityEnum.Complex)]
	public partial class TIMESTRUCT : Vortex.Connector.IVortexObject, ITIMESTRUCT, IShadowTIMESTRUCT, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerWord _wYear;
		public Vortex.Connector.ValueTypes.OnlinerWord wYear
		{
			get
			{
				return _wYear;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord ITIMESTRUCT.wYear
		{
			get
			{
				return wYear;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord IShadowTIMESTRUCT.wYear
		{
			get
			{
				return wYear;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWord _wMonth;
		public Vortex.Connector.ValueTypes.OnlinerWord wMonth
		{
			get
			{
				return _wMonth;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord ITIMESTRUCT.wMonth
		{
			get
			{
				return wMonth;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord IShadowTIMESTRUCT.wMonth
		{
			get
			{
				return wMonth;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWord _wDayOfWeek;
		public Vortex.Connector.ValueTypes.OnlinerWord wDayOfWeek
		{
			get
			{
				return _wDayOfWeek;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord ITIMESTRUCT.wDayOfWeek
		{
			get
			{
				return wDayOfWeek;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord IShadowTIMESTRUCT.wDayOfWeek
		{
			get
			{
				return wDayOfWeek;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWord _wDay;
		public Vortex.Connector.ValueTypes.OnlinerWord wDay
		{
			get
			{
				return _wDay;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord ITIMESTRUCT.wDay
		{
			get
			{
				return wDay;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord IShadowTIMESTRUCT.wDay
		{
			get
			{
				return wDay;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWord _wHour;
		public Vortex.Connector.ValueTypes.OnlinerWord wHour
		{
			get
			{
				return _wHour;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord ITIMESTRUCT.wHour
		{
			get
			{
				return wHour;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord IShadowTIMESTRUCT.wHour
		{
			get
			{
				return wHour;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWord _wMinute;
		public Vortex.Connector.ValueTypes.OnlinerWord wMinute
		{
			get
			{
				return _wMinute;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord ITIMESTRUCT.wMinute
		{
			get
			{
				return wMinute;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord IShadowTIMESTRUCT.wMinute
		{
			get
			{
				return wMinute;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWord _wSecond;
		public Vortex.Connector.ValueTypes.OnlinerWord wSecond
		{
			get
			{
				return _wSecond;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord ITIMESTRUCT.wSecond
		{
			get
			{
				return wSecond;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord IShadowTIMESTRUCT.wSecond
		{
			get
			{
				return wSecond;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWord _wMilliseconds;
		public Vortex.Connector.ValueTypes.OnlinerWord wMilliseconds
		{
			get
			{
				return _wMilliseconds;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord ITIMESTRUCT.wMilliseconds
		{
			get
			{
				return wMilliseconds;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord IShadowTIMESTRUCT.wMilliseconds
		{
			get
			{
				return wMilliseconds;
			}
		}

		public void LazyOnlineToShadow()
		{
			wYear.Shadow = wYear.LastValue;
			wMonth.Shadow = wMonth.LastValue;
			wDayOfWeek.Shadow = wDayOfWeek.LastValue;
			wDay.Shadow = wDay.LastValue;
			wHour.Shadow = wHour.LastValue;
			wMinute.Shadow = wMinute.LastValue;
			wSecond.Shadow = wSecond.LastValue;
			wMilliseconds.Shadow = wMilliseconds.LastValue;
		}

		public void LazyShadowToOnline()
		{
			wYear.Cyclic = wYear.Shadow;
			wMonth.Cyclic = wMonth.Shadow;
			wDayOfWeek.Cyclic = wDayOfWeek.Shadow;
			wDay.Cyclic = wDay.Shadow;
			wHour.Cyclic = wHour.Shadow;
			wMinute.Cyclic = wMinute.Shadow;
			wSecond.Cyclic = wSecond.Shadow;
			wMilliseconds.Cyclic = wMilliseconds.Shadow;
		}

		public PlainTIMESTRUCT CreatePlainerType()
		{
			var cloned = new PlainTIMESTRUCT();
			return cloned;
		}

		protected PlainTIMESTRUCT CreatePlainerType(PlainTIMESTRUCT cloned)
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

		public void FlushPlainToOnline(Tc2_Utilities.PlainTIMESTRUCT source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Tc2_Utilities.PlainTIMESTRUCT source)
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

		public void FlushOnlineToPlain(Tc2_Utilities.PlainTIMESTRUCT source)
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

		public TIMESTRUCT(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_wYear = @Connector.Online.Adapter.CreateWORD(this, "", "wYear");
			_wMonth = @Connector.Online.Adapter.CreateWORD(this, "", "wMonth");
			_wDayOfWeek = @Connector.Online.Adapter.CreateWORD(this, "", "wDayOfWeek");
			_wDay = @Connector.Online.Adapter.CreateWORD(this, "", "wDay");
			_wHour = @Connector.Online.Adapter.CreateWORD(this, "", "wHour");
			_wMinute = @Connector.Online.Adapter.CreateWORD(this, "", "wMinute");
			_wSecond = @Connector.Online.Adapter.CreateWORD(this, "", "wSecond");
			_wMilliseconds = @Connector.Online.Adapter.CreateWORD(this, "", "wMilliseconds");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public TIMESTRUCT()
		{
			PexPreConstructorParameterless();
			_wYear = Vortex.Connector.IConnectorFactory.CreateWORD();
			_wMonth = Vortex.Connector.IConnectorFactory.CreateWORD();
			_wDayOfWeek = Vortex.Connector.IConnectorFactory.CreateWORD();
			_wDay = Vortex.Connector.IConnectorFactory.CreateWORD();
			_wHour = Vortex.Connector.IConnectorFactory.CreateWORD();
			_wMinute = Vortex.Connector.IConnectorFactory.CreateWORD();
			_wSecond = Vortex.Connector.IConnectorFactory.CreateWORD();
			_wMilliseconds = Vortex.Connector.IConnectorFactory.CreateWORD();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface ITIMESTRUCT : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineWord wYear
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord wMonth
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord wDayOfWeek
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord wDay
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord wHour
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord wMinute
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord wSecond
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord wMilliseconds
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainTIMESTRUCT CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Tc2_Utilities.PlainTIMESTRUCT source);
		void FlushOnlineToPlain(Tc2_Utilities.PlainTIMESTRUCT source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowTIMESTRUCT : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowWord wYear
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord wMonth
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord wDayOfWeek
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord wDay
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord wHour
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord wMinute
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord wSecond
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord wMilliseconds
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Tc2_Utilities.PlainTIMESTRUCT CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Tc2_Utilities.PlainTIMESTRUCT source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTIMESTRUCT : Vortex.Connector.IPlain
	{
		System.UInt16 _wYear;
		public System.UInt16 wYear
		{
			get
			{
				return _wYear;
			}

			set
			{
				_wYear = value;
			}
		}

		System.UInt16 _wMonth;
		public System.UInt16 wMonth
		{
			get
			{
				return _wMonth;
			}

			set
			{
				_wMonth = value;
			}
		}

		System.UInt16 _wDayOfWeek;
		public System.UInt16 wDayOfWeek
		{
			get
			{
				return _wDayOfWeek;
			}

			set
			{
				_wDayOfWeek = value;
			}
		}

		System.UInt16 _wDay;
		public System.UInt16 wDay
		{
			get
			{
				return _wDay;
			}

			set
			{
				_wDay = value;
			}
		}

		System.UInt16 _wHour;
		public System.UInt16 wHour
		{
			get
			{
				return _wHour;
			}

			set
			{
				_wHour = value;
			}
		}

		System.UInt16 _wMinute;
		public System.UInt16 wMinute
		{
			get
			{
				return _wMinute;
			}

			set
			{
				_wMinute = value;
			}
		}

		System.UInt16 _wSecond;
		public System.UInt16 wSecond
		{
			get
			{
				return _wSecond;
			}

			set
			{
				_wSecond = value;
			}
		}

		System.UInt16 _wMilliseconds;
		public System.UInt16 wMilliseconds
		{
			get
			{
				return _wMilliseconds;
			}

			set
			{
				_wMilliseconds = value;
			}
		}

		public void CopyPlainToCyclic(Tc2_Utilities.TIMESTRUCT target)
		{
			target.wYear.Cyclic = wYear;
			target.wMonth.Cyclic = wMonth;
			target.wDayOfWeek.Cyclic = wDayOfWeek;
			target.wDay.Cyclic = wDay;
			target.wHour.Cyclic = wHour;
			target.wMinute.Cyclic = wMinute;
			target.wSecond.Cyclic = wSecond;
			target.wMilliseconds.Cyclic = wMilliseconds;
		}

		public void CopyPlainToCyclic(Tc2_Utilities.ITIMESTRUCT target)
		{
			this.CopyPlainToCyclic((Tc2_Utilities.TIMESTRUCT)target);
		}

		public void CopyPlainToShadow(Tc2_Utilities.TIMESTRUCT target)
		{
			target.wYear.Shadow = wYear;
			target.wMonth.Shadow = wMonth;
			target.wDayOfWeek.Shadow = wDayOfWeek;
			target.wDay.Shadow = wDay;
			target.wHour.Shadow = wHour;
			target.wMinute.Shadow = wMinute;
			target.wSecond.Shadow = wSecond;
			target.wMilliseconds.Shadow = wMilliseconds;
		}

		public void CopyPlainToShadow(Tc2_Utilities.IShadowTIMESTRUCT target)
		{
			this.CopyPlainToShadow((Tc2_Utilities.TIMESTRUCT)target);
		}

		public void CopyCyclicToPlain(Tc2_Utilities.TIMESTRUCT source)
		{
			wYear = source.wYear.LastValue;
			wMonth = source.wMonth.LastValue;
			wDayOfWeek = source.wDayOfWeek.LastValue;
			wDay = source.wDay.LastValue;
			wHour = source.wHour.LastValue;
			wMinute = source.wMinute.LastValue;
			wSecond = source.wSecond.LastValue;
			wMilliseconds = source.wMilliseconds.LastValue;
		}

		public void CopyCyclicToPlain(Tc2_Utilities.ITIMESTRUCT source)
		{
			this.CopyCyclicToPlain((Tc2_Utilities.TIMESTRUCT)source);
		}

		public void CopyShadowToPlain(Tc2_Utilities.TIMESTRUCT source)
		{
			wYear = source.wYear.Shadow;
			wMonth = source.wMonth.Shadow;
			wDayOfWeek = source.wDayOfWeek.Shadow;
			wDay = source.wDay.Shadow;
			wHour = source.wHour.Shadow;
			wMinute = source.wMinute.Shadow;
			wSecond = source.wSecond.Shadow;
			wMilliseconds = source.wMilliseconds.Shadow;
		}

		public void CopyShadowToPlain(Tc2_Utilities.IShadowTIMESTRUCT source)
		{
			this.CopyShadowToPlain((Tc2_Utilities.TIMESTRUCT)source);
		}

		public PlainTIMESTRUCT()
		{
		}
	}
}