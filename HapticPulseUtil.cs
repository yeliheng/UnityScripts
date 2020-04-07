using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 2020-04-06
 * 手柄震动工具
 * Written By Yeliheng
 */
public class HapticPulseUtil{
    //public int pulseTime = 100;

    /// <summary>
    /// 扳机线性马达震动
    /// </summary>
    /// <param name="pulseTime">震动时间,默认1</param>
    /// <param name="strength">震动强度,默认1000</param>
    public void TriggerPulse(int pulseTime = 1,ushort strength = 1000)
    {
#if CURVEDUI_VIVE
        CurvedUIInputModule.Right.TriggerHapticPulse(pulseTime, strength);
#endif
    }

}
