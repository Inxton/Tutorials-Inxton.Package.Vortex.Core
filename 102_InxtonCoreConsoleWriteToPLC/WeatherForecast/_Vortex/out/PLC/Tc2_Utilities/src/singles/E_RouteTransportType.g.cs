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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("", "E_RouteTransportType", "Tc2_Utilities", TypeComplexityEnum.Enumerator)]
	public enum E_RouteTransportType : System.UInt16
	{
		eRouteTransport_None = 0,
		eRouteTransport_TCP_IP = 1,
		eRouteTransport_IIO_LIGHTBUS = 2,
		eRouteTransport_PROFIBUS_DP = 3,
		eRouteTransport_PCI_ISA_BUS = 4,
		eRouteTransport_ADS_UDP = 5,
		eRouteTransport_FATP_UDP = 6,
		eRouteTransport_COM_PORT = 7,
		eRouteTransport_USB = 8,
		eRouteTransport_CAN_OPEN = 9,
		eRouteTransport_DEVICE_NET = 10,
		eRouteTransport_SSB = 11,
		eRouteTransport_SOAP = 12
	}
}