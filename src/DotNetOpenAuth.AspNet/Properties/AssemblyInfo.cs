﻿//-----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Microsoft">
//     Copyright (c) Microsoft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2011")]
[assembly: CLSCompliant(true)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("c89b7e57-2735-4407-bcb9-dfe9bb9493a2")]

#if StrongNameSigned

[assembly: InternalsVisibleTo("DotNetOpenAuth.AspNet.Test, PublicKey=0024000004800000940000000602000000240000525341310004000001000100AD093C3765257C89A7010E853F2C7C741FF92FA8ACE06D7B8254702CAD5CF99104447F63AB05F8BB6F51CE0D81C8C93D2FCE8C20AAFF7042E721CBA16EAAE98778611DED11C0ABC8900DC5667F99B50A9DADEC24DBD8F2C91E3E8AD300EF64F1B4B9536CEB16FB440AF939F57624A9B486F867807C649AE4830EAB88C6C03998")]
#else
[assembly: InternalsVisibleTo("DotNetOpenAuth.AspNet.Test")]
#endif
