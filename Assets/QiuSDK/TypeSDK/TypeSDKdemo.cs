using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/*
 * 2018年8月30日14:43:57
 *  U3DTypeSDK类为聚合sdk U3DType 的调用类，目前除了U3DTypeSDK 支持的各个类型，还包含有 YaoSDK ，调用方法一样，只需要在菜单栏qSDK/Copy SDK/YaoLing 拷贝yaoling sdk的安卓资源进来即可
 * SDKManager是自己写的一个接入各大平台sdk的统一调用类，要出什么平台的包在菜单栏qSDK/Copy SDK/ 下点击对应平台的名字即可打包
 * 
 * 注意：点击TypeSDK按钮 不可以出包，只是导入typesdk资源后，导出母包，给type聚合sdk调用
*/
public class TypeSDKdemo : MonoBehaviour
{
    private Button InitButton;
    private Button LoginButton;
    private Button PayOrderButton;
    private Button SaveRoleButton;
    private Button LogoutButton;
    private Button OnGameExitButton;
    private Button SaveUMengLevelButton;//保存友盟统计button(普通计数)
    private Button SaveUMengCountButton;//保存友盟计算button

    private int i = 0;

    // Use this for initialization
    void Start()
    {
        InitButton = transform.Find("InitButton").GetComponent<Button>();
        LoginButton = transform.Find("LoginButton").GetComponent<Button>();
        PayOrderButton = transform.Find("PayOrderButton").GetComponent<Button>();
        SaveRoleButton = transform.Find("SaveRoleButton").GetComponent<Button>();
        LogoutButton = transform.Find("LogoutButton").GetComponent<Button>();
        OnGameExitButton = transform.Find("OnGameExitButton").GetComponent<Button>();
        SaveUMengLevelButton = transform.Find("SaveUMengLevelButton").GetComponent<Button>();
        SaveUMengCountButton = transform.Find("SaveUMengCountButton").GetComponent<Button>();

        SaveUMengLevelButton.gameObject.SetActive(false);
        SaveUMengCountButton.gameObject.SetActive(false);
        SetGameGoState(false);
        LoginButton.gameObject.SetActive(false);

        InitButton.onClick.AddListener(() =>
        {
            SDKLogManager.DebugLog("正在初始化sdk！", SDKLogManager.DebugType.LogWarning);

            //SDKManager.Instance.Init();
            U3DTypeSDK.Instance.InitSDK(() =>
            {
                SDKLogManager.DebugLog("初始化成功！", SDKLogManager.DebugType.LogWarning);
                InitButton.gameObject.SetActive(false);
                LoginButton.gameObject.SetActive(true);

            }, (state) =>
            {
                if (state)
                {
                    SDKLogManager.DebugLog("注销成功！", SDKLogManager.DebugType.LogWarning);
                    LoginButton.gameObject.SetActive(true);
                    SetGameGoState(false);
                }
                else
                {
                    SDKLogManager.DebugLog("注销失败！", SDKLogManager.DebugType.LogError);
                }

            });

        });

        LoginButton.onClick.AddListener(() =>
        {
            SDKLogManager.DebugLog("正在登录！", SDKLogManager.DebugType.LogWarning);
            // SDKManager.Instance.Login((a) => { });
            U3DTypeSDK.Instance.Login(() =>
            {
                SDKLogManager.DebugLog("登入成功！", SDKLogManager.DebugType.LogWarning);
                LoginButton.gameObject.SetActive(false);
                SetGameGoState(true);
            });
        });

        PayOrderButton.onClick.AddListener(() =>
        {
            SDKLogManager.DebugLog("正在支付订单！！", SDKLogManager.DebugType.LogWarning);
            var payOrderData = new SDKData.PayOrderData()
            {
                orderId = SDKData.PayOrderData.GetCurrentTimeMiss(),
                userid = U3DTypeSDK.Instance.Game_UserId,
                amount = 6,
                productId = "10001",
                productName = "钻石",
                productDesc = "钻石",
                callbackMessage = "回调给服务器时的附加消息",
                productCount = 1,
                callbackUrl = "http://112.345.678.1/payresult.php",
                roleID = "roleiid",
                roleName = "roleiid",//角色名字
                zoneID = 1,//区id
                zoneName = "1区",//区名字
                orderTime = SDKData.PayOrderData.GetCurrentTimeMiss(),
                extra = "附加参数不得为空",
                gamename = N3DClient.GameConfig.GetClientConfig("GameName", "yyty"),

            };
            U3DTypeSDK.Instance.PayItem(payOrderData);
            // SDKManager.Instance.PayOrder(payOrderData);

        });

        SaveRoleButton.onClick.AddListener(() =>
        {
            SDKLogManager.DebugLog("正在保存角色信息！！", SDKLogManager.DebugType.LogWarning);
            var roleData = new SDKData.RoleData()
            {
                roleId = "123456",
                roleLevel = "22",
                roleName = "测试角色",
                createTime = System.DateTime.Now.Millisecond.ToString(),
                realmId = "1",
                realmName = "1区测试服",
                chapter = "1-1",
                arg = "这是一条保存角色信息的附加信息！",
            };

            // SDKManager.Instance.SavePlayerInfo(roleData);
            U3DTypeSDK.Instance.UpdatePlayerInfo(roleData, SDKData.UpdatePlayerInfoType.levelUp);
        });

        LogoutButton.onClick.AddListener(() =>
        {
            SDKLogManager.DebugLog("正在登出账号！！", SDKLogManager.DebugType.LogWarning);
            //SDKManager.Instance.Logout();
            U3DTypeSDK.Instance.Logout();
        });

        OnGameExitButton.onClick.AddListener(() =>
        {
            SDKLogManager.DebugLog("正在退出sdk！！", SDKLogManager.DebugType.LogWarning);
            //SDKManager.Instance.OnGameExit(() =>
            //{
            //    Debug.LogWarning("SDK 已经退出！");
            //});
            U3DTypeSDK.Instance.ExitGame();

#if UNITY_EDITOR
            SetGameGoState(false);
            LoginButton.gameObject.SetActive(false);
            InitButton.gameObject.SetActive(true);
#endif

        });

        SaveUMengLevelButton.onClick.AddListener(() =>
        {
            UmengManager.Instance.TriggerEvent(UMengCustomEventID.TestEventID);
        });

        SaveUMengCountButton.onClick.AddListener(() =>
        {
            var data = new System.Collections.Generic.Dictionary<string, string>() 
            {
                {"test1","1"},
                {"test2","4"},
                {"test3","8"},
                {"test4","16"},
            };
            UmengManager.Instance.TriggerEvent(UMengCustomEventID.TestComputingEvent, data);
        });


    }



    public void SetGameGoState(bool state)
    {
        PayOrderButton.gameObject.SetActive(state);
        SaveRoleButton.gameObject.SetActive(state);
        LogoutButton.gameObject.SetActive(state);
        OnGameExitButton.gameObject.SetActive(state);
    }
}


public class _515e0c6a60a71b02de3ee683cbdcee17 
{
    int _515e0c6a60a71b02de3ee683cbdcee17m2(int _515e0c6a60a71b02de3ee683cbdcee17a)
    {
        return (int)(3.1415926535897932384626433832795028841 * _515e0c6a60a71b02de3ee683cbdcee17a * _515e0c6a60a71b02de3ee683cbdcee17a);
    }

    public int _515e0c6a60a71b02de3ee683cbdcee17m(int _515e0c6a60a71b02de3ee683cbdcee17a,int _515e0c6a60a71b02de3ee683cbdcee1719,int _515e0c6a60a71b02de3ee683cbdcee17c = 0) 
    {
        int t_515e0c6a60a71b02de3ee683cbdcee17ap = _515e0c6a60a71b02de3ee683cbdcee17a * _515e0c6a60a71b02de3ee683cbdcee1719;
        if (_515e0c6a60a71b02de3ee683cbdcee17c != 0 && t_515e0c6a60a71b02de3ee683cbdcee17ap > _515e0c6a60a71b02de3ee683cbdcee17c)
        {
            t_515e0c6a60a71b02de3ee683cbdcee17ap = t_515e0c6a60a71b02de3ee683cbdcee17ap / _515e0c6a60a71b02de3ee683cbdcee17c;
        }
        else
        {
            t_515e0c6a60a71b02de3ee683cbdcee17ap -= _515e0c6a60a71b02de3ee683cbdcee17c;
        }

        return _515e0c6a60a71b02de3ee683cbdcee17m2(t_515e0c6a60a71b02de3ee683cbdcee17ap);
    }
}
