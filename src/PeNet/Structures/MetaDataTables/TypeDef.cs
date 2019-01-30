﻿using System;
using System.Collections.Generic;
using System.Text;
using PeNet.Test.Structures;

namespace PeNet.Structures.MetaDataTables
{
    public class TypeDef : AbstractTable
    {
        public TypeDef(byte[] buff, uint offset, HeapSizes heapSizes, IndexSize indexSizes) 
            : base(buff, offset, heapSizes, indexSizes)
        {
            Flags = ReadSize(4, ref CurrentOffset);
            TypeName = ReadSize(HeapSizes.String, ref CurrentOffset);
            TypeNamespace = ReadSize(HeapSizes.String, ref CurrentOffset);
            Extends = ReadSize(IndexSizes[Index.TypeDefOrRef], ref CurrentOffset);
            FieldList = ReadSize(IndexSizes[Index.Field], ref CurrentOffset);
            MethodList = ReadSize(IndexSizes[Index.MethodDef], ref CurrentOffset);
        }

        public uint Flags {get;}

        public uint TypeName {get;}

        public uint TypeNamespace {get;}

        public uint Extends {get;}

        public uint FieldList {get;}

        public uint MethodList {get;}
    }
}
