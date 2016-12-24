using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using isRock.Framework;
using isRock.Framework.WebAPI;

namespace WebApplication15.BO
{
    public class Health : BusinessLogicBase
    {
        /// <summary>
        /// 計算BMI
        /// </summary>
        /// <param name="bodyInfo"></param>
        /// <returns></returns>
        public ExecuteCommandDefaultResult<float> BMI(BodyInfo bodyInfo)
        {
            float height = (bodyInfo.height) / 100;
            var bmi = bodyInfo.weight / (height * height);
            return new ExecuteCommandDefaultResult<float>()
            {
                Data = bmi,
                isSuccess = true
            };
        }
    }

    /// <summary>
    /// 個人身高體重
    /// </summary>
    public class BodyInfo
    {
        public float height { get; set; }
        public float weight { get; set; }
    }
}