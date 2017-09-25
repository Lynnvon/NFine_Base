/************************************************************************************
//Copyright (c) LynnVon  All Rights Reserved.
//Author：  LynnVon
//CreateTime： 2017年7月25日
//Content: 公共方法
************************************************************************************/

using NFine.Code;
using NFine.Data;
using NFine.Domain._01_Infrastructure;

namespace NFine.Application._01_Infrastructure
{
    public class BasicApp<TRespo,TEntity>:IBasicApp<TEntity> where TRespo : RepositoryBase<TEntity>,new () where TEntity : class,IEntity,new ()
    {
        /// <summary>
        /// 获取一条数据
        /// </summary>
        /// <param name="keyValue">RecordId</param>
        /// <returns></returns>
        public TEntity GetForm(string keyValue)
        {
            return new TRespo().FindEntity(keyValue);
        }
        /// <summary>
        /// 是否存在 by RecordId
        /// </summary>
        /// <param name="keyValue">recordId</param>
        /// <returns></returns>
        public bool ExistsByRecordId(string keyValue)
        {
            return !new TRespo().FindEntity(keyValue).IsEmpty();
        }
        /// <summary>
        /// 删除一条设局
        /// </summary>
        /// <param name="keyValue">RecordId</param>
        public void DeleteForm(string keyValue)
        {
            new TRespo().Delete(t => t.RecordId == keyValue);
        }

        /// <summary>
        /// 添加一条数据
        /// </summary>
        public void UpdateEntity(TEntity tEntity)
        {
            new TRespo().Update(tEntity);
        }

    }
}