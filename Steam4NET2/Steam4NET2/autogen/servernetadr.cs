// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct servernetadr_t
	{
		UInt16 m_usConnectionPort;
		UInt16 m_usQueryPort;
		UInt32 m_unIP;
	};
	
}