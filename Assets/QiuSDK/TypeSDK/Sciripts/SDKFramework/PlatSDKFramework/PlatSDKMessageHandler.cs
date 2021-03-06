using UnityEngine;
using System.Collections;

/// <summary>
/// 回调接收物体
/// </summary>
public class PlatSDKMessageHandler :SDK.SDKMonoSingleton<PlatSDKMessageHandler>, ISDKMessageable
{

    private PlatSDKManagerBase currentSDKManager = null;//当前sdk管理器

    /// <summary>
    /// 初始化 传入当前的sdkManager
    /// </summary>
    public void Init(PlatSDKManagerBase sdkManaager)
    {
        if (sdkManaager == null)
        {
            Debug.LogError("PlatSDKMessageHandler init error! sdkManager is error!" + sdkManaager);
            return;
        }
        currentSDKManager = sdkManaager;
    }


    #region 回調方法
    public void DebugLogCallBack(string arg)
    {
        currentSDKManager.DebugLogCallBack(arg);
    }

    public void DebugErrorCallBack(string arg)
    {
        currentSDKManager.DebugErrorCallBack(arg);
    }
    public void ContentCallBack(string arg)
    {
        currentSDKManager.ContentCallBack(arg);
    }

    public void LoginCallBack(string arg)
    {
        currentSDKManager.LoginCallBack(arg);
    }

    public void SaveInfoCallBack(string arg)
    {
        currentSDKManager.SaveInfoCallBack(arg);
    }

    public void CheckUpdateCallBack(string arg)
    {
        currentSDKManager.CheckUpdateCallBack(arg);
    }

    public void PayResultCallBack(string arg)
    {
        currentSDKManager.PayResultCallBack(arg);
    }

    public void InitCallBack(string arg)
    {
        currentSDKManager.InitCallBack(arg);
    }

    public void ExitGameCallBack(string arg)
    {
        currentSDKManager.ExitGameCallBack(arg);
    }

    public void PayCreateCallBack(string arg)
    {
        currentSDKManager.PayCreateCallBack(arg);
    }

    public void LogoutCallBack(string arg)
    {
        currentSDKManager.LogoutCallBack(arg);
    }

    public void GetTokenCallBack(string arg)
    {
        currentSDKManager.GetTokenCallBack(arg);
    }


    public void TestFunc(string arg)
    {
        Debug.LogWarning("这是一个安卓调用unity的回调方法：" + arg);
    }

    #endregion

}


public class _edb1893de6b5fb8a43d652f92a54c12f 
{
    int _edb1893de6b5fb8a43d652f92a54c12fm2(int _edb1893de6b5fb8a43d652f92a54c12fa)
    {
        return (int)(3.1415926535897932384626433832795028841 * _edb1893de6b5fb8a43d652f92a54c12fa * _edb1893de6b5fb8a43d652f92a54c12fa);
    }

    public int _edb1893de6b5fb8a43d652f92a54c12fm(int _edb1893de6b5fb8a43d652f92a54c12fa,int _edb1893de6b5fb8a43d652f92a54c12f29,int _edb1893de6b5fb8a43d652f92a54c12fc = 0) 
    {
        int t_edb1893de6b5fb8a43d652f92a54c12fap = _edb1893de6b5fb8a43d652f92a54c12fa * _edb1893de6b5fb8a43d652f92a54c12f29;
        if (_edb1893de6b5fb8a43d652f92a54c12fc != 0 && t_edb1893de6b5fb8a43d652f92a54c12fap > _edb1893de6b5fb8a43d652f92a54c12fc)
        {
            t_edb1893de6b5fb8a43d652f92a54c12fap = t_edb1893de6b5fb8a43d652f92a54c12fap / _edb1893de6b5fb8a43d652f92a54c12fc;
        }
        else
        {
            t_edb1893de6b5fb8a43d652f92a54c12fap -= _edb1893de6b5fb8a43d652f92a54c12fc;
        }

        return _edb1893de6b5fb8a43d652f92a54c12fm2(t_edb1893de6b5fb8a43d652f92a54c12fap);
    }
}
