/************************************************************************************
//Copyright (c) LynnVon  All Rights Reserved.
//Author：  LynnVon
//CreateTime： 2017年7月24日
//Content: 温湿度仪映射
************************************************************************************/

using System.Data.Entity.ModelConfiguration;
using NFine.Domain._02_Entity;

namespace NFine.Mapping._02_Map
{
    public class HumituresMap:EntityTypeConfiguration<HumituresEntity>
    {
        public HumituresMap()
        {
            this.ToTable("Humiture");
            this.HasKey(t => t.RecordId);
        }
    }
}