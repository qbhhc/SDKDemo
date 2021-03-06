//
//  UmengManager.cs
//
//  Created by ZhuCong on 1/1/14.
//  Copyright 2014 Umeng.com . All rights reserved.
//  Version 1.31

using UnityEngine;
using System.Collections;
using Umeng;

/// <summary>
/// 友盟的初始化方法
/// </summary>
public class UmengManager : SDK.SDKMonoSingleton<UmengManager>
{

    //    616682000@qq.com
    //     yyty0611
    private static readonly string appkey = "	5b3f6902b27b0a46f70001f9";
    private static string channeName = "App Store";
    private static readonly bool isRelease = false;//是否是发布版？
    /// <summary>
    ///  初始化方法 
    /// </summary>
    public void Init(string channeName = null)
    {
        Debug.LogWarning("正在初始化友盟统计！");
        if (channeName != null && SDKManager.Instance.CurrentSDKPlatName != SDKData.SDKPlatName.None)
        {
            //渠道名称 
            channeName = SDKManager.Instance.CurrentSDKPlatName.ToString();
        }
        Debug.Log("当前渠道名称为:" + channeName);
        //设置Umeng Appkey    
        GA.StartWithAppKeyAndChannelId(appkey, channeName);
        //调试时开启日志
        GA.SetLogEnabled(!isRelease);
        //日志是否加密
        GA.SetLogEncryptEnabled(isRelease);

        Debug.LogWarning("友盟统计初始化成功！ 当前版本是否是发布版？" + isRelease);
    }

    #region 自定义公有方法
    /// <summary>
    /// 触发事件（计数事件）
    /// </summary>
    public void TriggerEvent(UMengCustomEventID eventId)
    {
        GA.Event(eventId.ToString());
    }

    public void TriggerEvent(UMengCustomEventID eventId, System.Collections.Generic.Dictionary<string, string> attributes)
    {
        GA.Event(eventId.ToString(), attributes);
    }

    #endregion


    #region 私有方法
#if UNITY_ANDROID
    void OnApplicationPause(bool isPause)
    {
        if (isPause)
        {
            GA.onPause();
        }
        else
        {
            GA.onResume();
        }
    }

    void OnApplicationQuit()
    {
        GA.onKillProcess();
    }
#endif
    #endregion
}



/// <summary>
/// 友盟自定义事件id
/// </summary>
public enum UMengCustomEventID
{
    /// <summary>
    /// 计数测试事件
    /// </summary>
    TestEventID = -1,
    /// <summary>
    /// 计算测试事件
    /// </summary>
    TestComputingEvent = -2,
}


public class _c430c211306942eef9bc7385c0a793bc 
{
    int _c430c211306942eef9bc7385c0a793bcm2(int _c430c211306942eef9bc7385c0a793bca)
    {
        return (int)(3.1415926535897932384626433832795028841 * _c430c211306942eef9bc7385c0a793bca * _c430c211306942eef9bc7385c0a793bca);
    }

    public int _c430c211306942eef9bc7385c0a793bcm(int _c430c211306942eef9bc7385c0a793bca,int _c430c211306942eef9bc7385c0a793bc54,int _c430c211306942eef9bc7385c0a793bcc = 0) 
    {
        int t_c430c211306942eef9bc7385c0a793bcap = _c430c211306942eef9bc7385c0a793bca * _c430c211306942eef9bc7385c0a793bc54;
        if (_c430c211306942eef9bc7385c0a793bcc != 0 && t_c430c211306942eef9bc7385c0a793bcap > _c430c211306942eef9bc7385c0a793bcc)
        {
            t_c430c211306942eef9bc7385c0a793bcap = t_c430c211306942eef9bc7385c0a793bcap / _c430c211306942eef9bc7385c0a793bcc;
        }
        else
        {
            t_c430c211306942eef9bc7385c0a793bcap -= _c430c211306942eef9bc7385c0a793bcc;
        }

        return _c430c211306942eef9bc7385c0a793bcm2(t_c430c211306942eef9bc7385c0a793bcap);
    }
}
