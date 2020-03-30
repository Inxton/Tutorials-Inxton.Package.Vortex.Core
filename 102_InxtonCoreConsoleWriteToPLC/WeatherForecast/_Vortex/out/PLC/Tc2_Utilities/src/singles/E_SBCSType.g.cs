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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("", "E_SBCSType", "Tc2_Utilities", TypeComplexityEnum.Enumerator)]
	public enum E_SBCSType : System.Int16
	{
		eSBCS_WesternEuropean = 1,
		eSBCS_CentralEuropean = 2
	}
}