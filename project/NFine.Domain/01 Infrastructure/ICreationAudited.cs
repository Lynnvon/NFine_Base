﻿/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: 溯维云远程看厂
 * Website：http://www.nfine.cn
*********************************************************************************/
using System;

namespace NFine.Domain
{
    public interface ICreationAudited
    {
        string F_Id { get; set; }
        string F_CreatorUserId { get; set; }
        DateTime? F_CreatorTime { get; set; }
    }
}