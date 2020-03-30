using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;
using PLCConnector.Properties;

[assembly: Vortex.Connector.Attributes.AssemblyPlcCounterPart("{\r\n  \"Types\": [\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"stForecast\",\r\n      \"Namespace\": \"PLC\",\r\n      \"TypeMetaInfo\": 1\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"stWeatherData\",\r\n      \"Namespace\": \"PLC\",\r\n      \"TypeMetaInfo\": 1\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"MAIN\",\r\n      \"Namespace\": \"PLC\",\r\n      \"TypeMetaInfo\": 3\r\n    }\r\n  ],\r\n  \"Name\": \"PLC\",\r\n  \"Namespace\": \"PLC\"\r\n}")]
namespace PLC
{
	public partial class PLCTwinController : Vortex.Connector.ITwinController, IPLCTwinController, IShadowPLCTwinController
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
				return PLCTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		MAIN _MAIN;
		public MAIN MAIN
		{
			get
			{
				return _MAIN;
			}
		}

		IMAIN IPLCTwinController.MAIN
		{
			get
			{
				return MAIN;
			}
		}

		IShadowMAIN IShadowPLCTwinController.MAIN
		{
			get
			{
				return MAIN;
			}
		}

		public void LazyOnlineToShadow()
		{
			MAIN.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			MAIN.LazyShadowToOnline();
		}

		public PlainPLCTwinController CreatePlainerType()
		{
			var cloned = new PlainPLCTwinController();
			cloned.MAIN = MAIN.CreatePlainerType();
			return cloned;
		}

		protected PlainPLCTwinController CreatePlainerType(PlainPLCTwinController cloned)
		{
			cloned.MAIN = MAIN.CreatePlainerType();
			return cloned;
		}

		public System.String AttributeName
		{
			get
			{
				return PLCTwinController.Translator.Translate(_AttributeName).Interpolate(this);
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

		public IPLCTwinController Online
		{
			get
			{
				return (IPLCTwinController)this;
			}
		}

		public IShadowPLCTwinController Shadow
		{
			get
			{
				return (IShadowPLCTwinController)this;
			}
		}

		public Vortex.Connector.IConnector Connector
		{
			get;
			set;
		}

		public PLCTwinController()
		{
			var adapter = new Vortex.Connector.ConnectorAdapter(typeof (DummyConnectorFactory));
			this.Connector = adapter.GetConnector(new object[]{});
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public PLCTwinController(Vortex.Connector.ConnectorAdapter adapter, object[] parameters)
		{
			this.Connector = adapter.GetConnector(parameters);
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public PLCTwinController(Vortex.Connector.ConnectorAdapter adapter)
		{
			this.Connector = adapter.GetConnector(adapter.Parameters);
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public static string LocalizationDirectory
		{
			get;
			set;
		}

		private static Vortex.Localizations.Abstractions.ITranslator _translator
		{
			get;
			set;
		}

		internal static Vortex.Localizations.Abstractions.ITranslator Translator
		{
			get
			{
				if (_translator == null)
				{
					_translator = Vortex.Localizations.Abstractions.ITranslator.Get(typeof (Localizations));
				} return  _translator ; 

			}
		}
	}

	public partial interface IPLCTwinController
	{
		IMAIN MAIN
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		PLC.PlainPLCTwinController CreatePlainerType();
	}

	public partial interface IShadowPLCTwinController
	{
		IShadowMAIN MAIN
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		PLC.PlainPLCTwinController CreatePlainerType();
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainPLCTwinController : Vortex.Connector.IPlain
	{
		PlainMAIN _MAIN;
		public PlainMAIN MAIN
		{
			get
			{
				return _MAIN;
			}

			set
			{
				_MAIN = value;
			}
		}

		public void CopyPlainToCyclic(PLC.PLCTwinController target)
		{
			MAIN.CopyPlainToCyclic(target.MAIN);
		}

		public void CopyPlainToCyclic(PLC.IPLCTwinController target)
		{
			this.CopyPlainToCyclic((PLC.PLCTwinController)target);
		}

		public void CopyPlainToShadow(PLC.PLCTwinController target)
		{
			MAIN.CopyPlainToShadow(target.MAIN);
		}

		public void CopyPlainToShadow(PLC.IShadowPLCTwinController target)
		{
			this.CopyPlainToShadow((PLC.PLCTwinController)target);
		}

		public void CopyCyclicToPlain(PLC.PLCTwinController source)
		{
			MAIN.CopyCyclicToPlain(source.MAIN);
		}

		public void CopyCyclicToPlain(PLC.IPLCTwinController source)
		{
			this.CopyCyclicToPlain((PLC.PLCTwinController)source);
		}

		public void CopyShadowToPlain(PLC.PLCTwinController source)
		{
			MAIN.CopyShadowToPlain(source.MAIN);
		}

		public void CopyShadowToPlain(PLC.IShadowPLCTwinController source)
		{
			this.CopyShadowToPlain((PLC.PLCTwinController)source);
		}

		public PlainPLCTwinController()
		{
			_MAIN = new PlainMAIN();
		}
	}
}