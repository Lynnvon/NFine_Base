/************************************************************************************
//Copyright (c) LynnVon  All Rights Reserved.
//Author：  LynnVon
//CreateTime： 2017年7月24日
//Content: Entity
************************************************************************************/

using System;

namespace NFine.Domain._01_Infrastructure
{
    public interface IEntity
    {
        //记录Id guid
        string RecordId { get; set; }
        //记录时间
        DateTime? RecordTime { get; set; }
        //传感器类型
        string SensorType { get; set; }
    }
}