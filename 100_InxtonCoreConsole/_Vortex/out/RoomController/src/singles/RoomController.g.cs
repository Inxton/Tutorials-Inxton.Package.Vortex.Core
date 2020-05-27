using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;
using RoomControllerConnector.Properties;

[assembly: Vortex.Connector.Attributes.AssemblyPlcCounterPart("{\r\n  \"Types\": [\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbIntValueSimulation\",\r\n      \"Namespace\": \"RoomController\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"stAi4CH\",\r\n      \"Namespace\": \"RoomController\",\r\n      \"TypeMetaInfo\": 1\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"stRoomData\",\r\n      \"Namespace\": \"RoomController\",\r\n      \"TypeMetaInfo\": 1\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"IO\",\r\n      \"Namespace\": \"RoomController\",\r\n      \"TypeMetaInfo\": 0\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"Hardware_Simulation\",\r\n      \"Namespace\": \"RoomController\",\r\n      \"TypeMetaInfo\": 3\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"MAIN\",\r\n      \"Namespace\": \"RoomController\",\r\n      \"TypeMetaInfo\": 3\r\n    }\r\n  ],\r\n  \"Name\": \"RoomController\",\r\n  \"Namespace\": \"RoomController\"\r\n}")]
namespace RoomController
{
	public partial class RoomControllerTwinController : Vortex.Connector.ITwinController, IRoomControllerTwinController, IShadowRoomControllerTwinController
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
		IO _IO;
		public IO IO
		{
			get
			{
				return _IO;
			}
		}

		IIO IRoomControllerTwinController.IO
		{
			get
			{
				return IO;
			}
		}

		IShadowIO IShadowRoomControllerTwinController.IO
		{
			get
			{
				return IO;
			}
		}

		Hardware_Simulation _Hardware_Simulation;
		public Hardware_Simulation Hardware_Simulation
		{
			get
			{
				return _Hardware_Simulation;
			}
		}

		IHardware_Simulation IRoomControllerTwinController.Hardware_Simulation
		{
			get
			{
				return Hardware_Simulation;
			}
		}

		IShadowHardware_Simulation IShadowRoomControllerTwinController.Hardware_Simulation
		{
			get
			{
				return Hardware_Simulation;
			}
		}

		MAIN _MAIN;
		public MAIN MAIN
		{
			get
			{
				return _MAIN;
			}
		}

		IMAIN IRoomControllerTwinController.MAIN
		{
			get
			{
				return MAIN;
			}
		}

		IShadowMAIN IShadowRoomControllerTwinController.MAIN
		{
			get
			{
				return MAIN;
			}
		}

		public void LazyOnlineToShadow()
		{
			IO.LazyOnlineToShadow();
			Hardware_Simulation.LazyOnlineToShadow();
			MAIN.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			IO.LazyShadowToOnline();
			Hardware_Simulation.LazyShadowToOnline();
			MAIN.LazyShadowToOnline();
		}

		public PlainRoomControllerTwinController CreatePlainerType()
		{
			var cloned = new PlainRoomControllerTwinController();
			cloned.IO = IO.CreatePlainerType();
			cloned.Hardware_Simulation = Hardware_Simulation.CreatePlainerType();
			cloned.MAIN = MAIN.CreatePlainerType();
			return cloned;
		}

		protected PlainRoomControllerTwinController CreatePlainerType(PlainRoomControllerTwinController cloned)
		{
			cloned.IO = IO.CreatePlainerType();
			cloned.Hardware_Simulation = Hardware_Simulation.CreatePlainerType();
			cloned.MAIN = MAIN.CreatePlainerType();
			return cloned;
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

		public IRoomControllerTwinController Online
		{
			get
			{
				return (IRoomControllerTwinController)this;
			}
		}

		public IShadowRoomControllerTwinController Shadow
		{
			get
			{
				return (IShadowRoomControllerTwinController)this;
			}
		}

		public Vortex.Connector.IConnector Connector
		{
			get;
			set;
		}

		public RoomControllerTwinController()
		{
			var adapter = new Vortex.Connector.ConnectorAdapter(typeof (DummyConnectorFactory));
			this.Connector = adapter.GetConnector(new object[]{});
			_IO = new IO(this.Connector, "", "IO");
			_Hardware_Simulation = new Hardware_Simulation(this.Connector, "", "Hardware_Simulation");
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public RoomControllerTwinController(Vortex.Connector.ConnectorAdapter adapter, object[] parameters)
		{
			this.Connector = adapter.GetConnector(parameters);
			_IO = new IO(this.Connector, "", "IO");
			_Hardware_Simulation = new Hardware_Simulation(this.Connector, "", "Hardware_Simulation");
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public RoomControllerTwinController(Vortex.Connector.ConnectorAdapter adapter)
		{
			this.Connector = adapter.GetConnector(adapter.Parameters);
			_IO = new IO(this.Connector, "", "IO");
			_Hardware_Simulation = new Hardware_Simulation(this.Connector, "", "Hardware_Simulation");
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

	public partial interface IRoomControllerTwinController
	{
		IIO IO
		{
			get;
		}

		IHardware_Simulation Hardware_Simulation
		{
			get;
		}

		IMAIN MAIN
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainRoomControllerTwinController CreatePlainerType();
	}

	public partial interface IShadowRoomControllerTwinController
	{
		IShadowIO IO
		{
			get;
		}

		IShadowHardware_Simulation Hardware_Simulation
		{
			get;
		}

		IShadowMAIN MAIN
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		RoomController.PlainRoomControllerTwinController CreatePlainerType();
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainRoomControllerTwinController : Vortex.Connector.IPlain
	{
		PlainIO _IO;
		public PlainIO IO
		{
			get
			{
				return _IO;
			}

			set
			{
				_IO = value;
			}
		}

		PlainHardware_Simulation _Hardware_Simulation;
		public PlainHardware_Simulation Hardware_Simulation
		{
			get
			{
				return _Hardware_Simulation;
			}

			set
			{
				_Hardware_Simulation = value;
			}
		}

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

		public void CopyPlainToCyclic(RoomController.RoomControllerTwinController target)
		{
			IO.CopyPlainToCyclic(target.IO);
			Hardware_Simulation.CopyPlainToCyclic(target.Hardware_Simulation);
			MAIN.CopyPlainToCyclic(target.MAIN);
		}

		public void CopyPlainToCyclic(RoomController.IRoomControllerTwinController target)
		{
			this.CopyPlainToCyclic((RoomController.RoomControllerTwinController)target);
		}

		public void CopyPlainToShadow(RoomController.RoomControllerTwinController target)
		{
			IO.CopyPlainToShadow(target.IO);
			Hardware_Simulation.CopyPlainToShadow(target.Hardware_Simulation);
			MAIN.CopyPlainToShadow(target.MAIN);
		}

		public void CopyPlainToShadow(RoomController.IShadowRoomControllerTwinController target)
		{
			this.CopyPlainToShadow((RoomController.RoomControllerTwinController)target);
		}

		public void CopyCyclicToPlain(RoomController.RoomControllerTwinController source)
		{
			IO.CopyCyclicToPlain(source.IO);
			Hardware_Simulation.CopyCyclicToPlain(source.Hardware_Simulation);
			MAIN.CopyCyclicToPlain(source.MAIN);
		}

		public void CopyCyclicToPlain(RoomController.IRoomControllerTwinController source)
		{
			this.CopyCyclicToPlain((RoomController.RoomControllerTwinController)source);
		}

		public void CopyShadowToPlain(RoomController.RoomControllerTwinController source)
		{
			IO.CopyShadowToPlain(source.IO);
			Hardware_Simulation.CopyShadowToPlain(source.Hardware_Simulation);
			MAIN.CopyShadowToPlain(source.MAIN);
		}

		public void CopyShadowToPlain(RoomController.IShadowRoomControllerTwinController source)
		{
			this.CopyShadowToPlain((RoomController.RoomControllerTwinController)source);
		}

		public PlainRoomControllerTwinController()
		{
			_IO = new PlainIO();
			_Hardware_Simulation = new PlainHardware_Simulation();
			_MAIN = new PlainMAIN();
		}
	}
}