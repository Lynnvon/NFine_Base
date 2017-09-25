/************************************************************************************
//Copyright (c) LynnVon  All Rights Reserved.
//Author：  LynnVon
//CreateTime： 2017年7月24日
//Content: 温湿度仪Entity
************************************************************************************/

using System;
using NFine.Domain._01_Infrastructure;

namespace NFine.Domain._02_Entity
{
    public class HumituresEntity : Entity<HumituresEntity>,IEntity
    {
        //记录Id
        public string RecordId { get; set; }
        //设备编号
        public string DeviceId { get; set; }
        //经度
        public Double Longitude { get; set; }
        //纬度
        public Double Latitude { get; set; }
        //节点编号
        public int? NodeId { get; set; }
        //温度`
        public Double Temperature { get; set; }
        //湿度
        public Double Humidity { get; set; }
        //记录时间
        public DateTime? RecordTime { get; set; }
        //传感器类型
        public string SensorType { get; set; }
    }
}