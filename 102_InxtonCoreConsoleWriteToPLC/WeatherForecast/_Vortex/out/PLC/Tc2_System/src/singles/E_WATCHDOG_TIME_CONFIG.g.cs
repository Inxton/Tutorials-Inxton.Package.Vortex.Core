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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("", "E_WATCHDOG_TIME_CONFIG", "Tc2_System", TypeComplexityEnum.Enumerator)]
	public enum E_WATCHDOG_TIME_CONFIG : System.Int16
	{
		eWATCHDOG_TIME_DISABLED = 0,
		eWATCHDOG_TIME_SECONDS = 1,
		eWATCHDOG_TIME_MINUTES = 2
	}
}