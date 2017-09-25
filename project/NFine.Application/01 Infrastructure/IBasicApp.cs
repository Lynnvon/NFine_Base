/************************************************************************************
//Copyright (c) LynnVon  All Rights Reserved.
//Author：  LynnVon
//CreateTime： 2017年7月25日
//Content: 
************************************************************************************/

namespace NFine.Application._01_Infrastructure
{
    public interface IBasicApp<TEntity> where TEntity : class ,new ()
    {
        TEntity GetForm(string keyValue);
        bool ExistsByRecordId(string keyValue);
        void DeleteForm(string keyValue);
        void UpdateEntity(TEntity tEntity);




    }
}