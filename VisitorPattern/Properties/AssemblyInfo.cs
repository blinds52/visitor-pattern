﻿using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.ExtensibilityHosting;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("VisitorPattern")]
[assembly: AssemblyDescription("VisitorPattern toolkit")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("VisitorPattern")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b660b989-815f-4619-b36c-5daae8a20fe6")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: NeutralResourcesLanguage("en")]

// Required to import/export MEF classes from this extension.
[assembly: VsCatalogName(NuPattern.ComponentModel.Composition.Catalog.DefaultCatalogName)]
[assembly: VsCatalogName(NuPattern.VisualStudio.Composition.Catalog.DefaultCatalogName)]