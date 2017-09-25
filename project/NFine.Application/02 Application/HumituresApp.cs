/************************************************************************************
//Copyright (c) LynnVon  All Rights Reserved.
//Author：  LynnVon
//CreateTime： 2017年7月24日
//Content: 温湿度传感器应用层
************************************************************************************/

using NFine.Repository._02_Repository;
using NFine.Code;
using System.Collections.Generic;
using NFine.Domain._02_Entity;
using System.Linq;
using NFine.Application._01_Infrastructure;

namespace NFine.Application._02_Application
{
    public class HumituresApp:BasicApp<HumituresRep,HumituresEntity>
    {
        private HumituresRep service = new HumituresRep();


        /// <summary>
        /// 获取某一编号设备的一列数据
        /// </summary>
        /// <param name="keyword">设备编号</param>
        /// <returns></returns>
        public List<HumituresEntity> GetList(string keyword)
        {
            var expression = ExtLinq.True<HumituresEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.DeviceId.Equals(keyword));
            }
            return service.IQueryable(expression).OrderBy(t => t.RecordTime).ToList();
        }
        /// <summary>
        /// 是否存在 by deviceId
        /// </summary>
        /// <param name="keyValue">deviceId</param>
        /// <returns></returns>
        public bool ExistsByDeviceId(string deviceId)
        {
            var expression = ExtLinq.True<HumituresEntity>();
            if (!string.IsNullOrEmpty(deviceId))
            {
                expression = expression.And(t => t.DeviceId.Equals(deviceId));
            }
            return service.IQueryable(expression).Any();
        }
        /// <summary>
        /// 获取某一设备多条数据
        /// </summary>
        public List<HumituresEntity> GetSeveralData(string deviceId,int nums)
        {
            var expression = ExtLinq.True<HumituresEntity>();
            if (!string.IsNullOrEmpty(deviceId))
            {
                expression = expression.And(t => t.DeviceId.Equals(deviceId));
            }
            return service.IQueryable(expression).OrderBy(t => t.RecordTime).Take(nums).ToList();
        }


    
    }
}