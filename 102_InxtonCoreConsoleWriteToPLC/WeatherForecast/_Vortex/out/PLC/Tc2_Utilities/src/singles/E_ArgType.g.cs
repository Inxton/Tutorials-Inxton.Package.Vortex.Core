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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("", "E_ArgType", "Tc2_Utilities", TypeComplexityEnum.Enumerator)]
	public enum E_ArgType : System.Int16
	{
		ARGTYPE_UNKNOWN = 0,
		ARGTYPE_BYTE = 1,
		ARGTYPE_WORD = 2,
		ARGTYPE_DWORD = 3,
		ARGTYPE_REAL = 4,
		ARGTYPE_LREAL = 5,
		ARGTYPE_SINT = 6,
		ARGTYPE_INT = 7,
		ARGTYPE_DINT = 8,
		ARGTYPE_USINT = 9,
		ARGTYPE_UINT = 10,
		ARGTYPE_UDINT = 11,
		ARGTYPE_STRING = 12,
		ARGTYPE_BOOL = 13,
		ARGTYPE_BIGTYPE = 14,
		ARGTYPE_ULARGE = 15,
		ARGTYPE_UHUGE = 16,
		ARGTYPE_LARGE = 17,
		ARGTYPE_HUGE = 18,
		ARGTYPE_LWORD = 19
	}
}