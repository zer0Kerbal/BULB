﻿//13
// 
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// 

using System.Reflection;

[assembly: AssemblyFileVersion("1.3.4.13")]
[assembly: AssemblyVersion("1.3.4.2")]
[assembly: AssemblyInformationalVersion("1.3.4")]
[assembly: KSPAssembly("BULB", 1,3)]

namespace BULB
{
	/// <summary>Version - retrieved at compile from BULB.version</summary>
	public static class Version
	{
		/// <summary>Major revision</summary>
		public const int major = 1;
		/// <summary>Minor revision</summary>
		public const int minor = 3;
		/// <summary>Patch revision</summary>
		public const int patch = 4;
		/// <summary>Build revision</summary>
		public const int build = 2;
		/// <summary>Version String const</summary>
		public const string Number = "1.3.4.2";
#if DEBUG
		/// <summary>Debug Version String const</summary>
        public const string Text = Number + "-zed'K BETA DEBUG";
		/// <summary>Debug SVersion String const</summary>
        public const string SText = Number + "-zed'K BETA DEBUG";
#else
		/// <summary>Text Version String const</summary>
        public const string Text = Number + "-zed'K";
		/// <summary>Plain Text Version String const</summary>
		public const string SText = Number;
#endif
	}
}