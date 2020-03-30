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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("", "E_TimeZoneID", "Tc2_Utilities", TypeComplexityEnum.Enumerator)]
	public enum E_TimeZoneID : System.Int16
	{
		eTimeZoneID_Invalid = -1,
		eTimeZoneID_Unknown = 0,
		eTimeZoneID_Standard = 1,
		eTimeZoneID_Daylight = 2
	}
}