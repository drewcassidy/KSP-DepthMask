using System.Reflection;

// KSP assembly information

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.
[assembly: AssemblyVersionAttribute("{{ ver_major }}.{{ ver_minor }}.{{ ver_patch }}")]
[assembly: AssemblyInformationalVersionAttribute("{{ ver_major }}.{{ ver_minor }}.{{ ver_patch }}")]
[assembly: KSPAssembly("DepthMask", {{ ver_major }}, {{ ver_minor }}, {{ ver_patch }})]

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.
[assembly: AssemblyCopyright("2022 Andrew Cassidy")]