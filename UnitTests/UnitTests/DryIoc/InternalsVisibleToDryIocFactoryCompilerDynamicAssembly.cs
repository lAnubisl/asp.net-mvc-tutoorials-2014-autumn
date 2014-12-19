using System.Runtime.CompilerServices;
using DryIoc;

// NOTE: Could be removed if you are not registering internal types.

[assembly: InternalsVisibleTo(FactoryCompiler.DYNAMIC_ASSEMBLY_NAME)]

// NOTE: Use this attribute instead of above if you are: 
//     Have internal types registered into Container, 
//     and signing your assemblies and DryIoc with Strong Name.
//[assembly: InternalsVisibleTo(DryIoc.FactoryCompiler.DYNAMIC_ASSEMBLY_NAME_WITH_PUBLIC_KEY)]