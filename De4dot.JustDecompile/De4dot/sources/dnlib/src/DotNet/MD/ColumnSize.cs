/*
    Copyright (C) 2012-2013 de4dot@gmail.com

    Permission is hereby granted, free of charge, to any person obtaining
    a copy of this software and associated documentation files (the
    "Software"), to deal in the Software without restriction, including
    without limitation the rights to use, copy, modify, merge, publish,
    distribute, sublicense, and/or sell copies of the Software, and to
    permit persons to whom the Software is furnished to do so, subject to
    the following conditions:

    The above copyright notice and this permission notice shall be
    included in all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
    CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
    TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
    SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

﻿namespace dnlib.DotNet.MD {
	/// <summary>
	/// MD table column size
	/// </summary>
	public enum ColumnSize : byte {
		/// <summary>RID into Module table</summary>
		Module,
		/// <summary>RID into TypeRef table</summary>
		TypeRef,
		/// <summary>RID into TypeDef table</summary>
		TypeDef,
		/// <summary>RID into FieldPtr table</summary>
		FieldPtr,
		/// <summary>RID into Field table</summary>
		Field,
		/// <summary>RID into MethodPtr table</summary>
		MethodPtr,
		/// <summary>RID into Method table</summary>
		Method,
		/// <summary>RID into ParamPtr table</summary>
		ParamPtr,
		/// <summary>RID into Param table</summary>
		Param,
		/// <summary>RID into InterfaceImpl table</summary>
		InterfaceImpl,
		/// <summary>RID into MemberRef table</summary>
		MemberRef,
		/// <summary>RID into Constant table</summary>
		Constant,
		/// <summary>RID into CustomAttribute table</summary>
		CustomAttribute,
		/// <summary>RID into FieldMarshal table</summary>
		FieldMarshal,
		/// <summary>RID into DeclSecurity table</summary>
		DeclSecurity,
		/// <summary>RID into ClassLayout table</summary>
		ClassLayout,
		/// <summary>RID into FieldLayout table</summary>
		FieldLayout,
		/// <summary>RID into StandAloneSig table</summary>
		StandAloneSig,
		/// <summary>RID into EventMap table</summary>
		EventMap,
		/// <summary>RID into EventPtr table</summary>
		EventPtr,
		/// <summary>RID into Event table</summary>
		Event,
		/// <summary>RID into PropertyMap table</summary>
		PropertyMap,
		/// <summary>RID into PropertyPtr table</summary>
		PropertyPtr,
		/// <summary>RID into Property table</summary>
		Property,
		/// <summary>RID into MethodSemantics table</summary>
		MethodSemantics,
		/// <summary>RID into MethodImpl table</summary>
		MethodImpl,
		/// <summary>RID into ModuleRef table</summary>
		ModuleRef,
		/// <summary>RID into TypeSpec table</summary>
		TypeSpec,
		/// <summary>RID into ImplMap table</summary>
		ImplMap,
		/// <summary>RID into FieldRVA table</summary>
		FieldRVA,
		/// <summary>RID into ENCLog table</summary>
		ENCLog,
		/// <summary>RID into ENCMap table</summary>
		ENCMap,
		/// <summary>RID into Assembly table</summary>
		Assembly,
		/// <summary>RID into AssemblyProcessor table</summary>
		AssemblyProcessor,
		/// <summary>RID into AssemblyOS table</summary>
		AssemblyOS,
		/// <summary>RID into AssemblyRef table</summary>
		AssemblyRef,
		/// <summary>RID into AssemblyRefProcessor table</summary>
		AssemblyRefProcessor,
		/// <summary>RID into AssemblyRefOS table</summary>
		AssemblyRefOS,
		/// <summary>RID into File table</summary>
		File,
		/// <summary>RID into ExportedType table</summary>
		ExportedType,
		/// <summary>RID into ManifestResource table</summary>
		ManifestResource,
		/// <summary>RID into NestedClass table</summary>
		NestedClass,
		/// <summary>RID into GenericParam table</summary>
		GenericParam,
		/// <summary>RID into MethodSpec table</summary>
		MethodSpec,
		/// <summary>RID into GenericParamConstraint table</summary>
		GenericParamConstraint,
		/// <summary>8-bit byte</summary>
		Byte = 0x40,
		/// <summary>16-bit signed int</summary>
		Int16,
		/// <summary>16-bit unsigned int</summary>
		UInt16,
		/// <summary>32-bit signed int</summary>
		Int32,
		/// <summary>32-bit unsigned int</summary>
		UInt32,
		/// <summary>Index into #Strings stream</summary>
		Strings,
		/// <summary>Index into #GUID stream</summary>
		GUID,
		/// <summary>Index into #Blob stream</summary>
		Blob,
		/// <summary>TypeDefOrRef encoded token</summary>
		TypeDefOrRef,
		/// <summary>HasConstant encoded token</summary>
		HasConstant,
		/// <summary>HasCustomAttribute encoded token</summary>
		HasCustomAttribute,
		/// <summary>HasFieldMarshal encoded token</summary>
		HasFieldMarshal,
		/// <summary>HasDeclSecurity encoded token</summary>
		HasDeclSecurity,
		/// <summary>MemberRefParent encoded token</summary>
		MemberRefParent,
		/// <summary>HasSemantic encoded token</summary>
		HasSemantic,
		/// <summary>MethodDefOrRef encoded token</summary>
		MethodDefOrRef,
		/// <summary>MemberForwarded encoded token</summary>
		MemberForwarded,
		/// <summary>Implementation encoded token</summary>
		Implementation,
		/// <summary>CustomAttributeType encoded token</summary>
		CustomAttributeType,
		/// <summary>ResolutionScope encoded token</summary>
		ResolutionScope,
		/// <summary>TypeOrMethodDef encoded token</summary>
		TypeOrMethodDef,
	}
}
