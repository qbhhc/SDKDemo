// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;



public  enum TypePushRepeatIntervalType
{
	kYEAR=1,	//年
	kMONTH=2,	//月
	kWEEK=3,	//周
	kDAY=4,		//日
	kHOUR=5,		//小时
	kMINUTE=6,	//分钟
	kSECOND=7,		//秒
	kDELAY_TIME=8,	//从设置的时间起算，延迟多少秒后触发（仅限1次）
	
};
//提交角色信息时用以区分不同类型
public struct RoleInfoType { 
    public const string enterGame = "enterGame";//进入游戏，此时应能获取到角色所有相关信息
    public const string createRole = "createRole";//角色创建完成后
    public const string levelUp = "levelUp";//角色升级时
}

public class U3DTypeDefine
{
	public const string U3D_SDK_VERSION = "VERSION_1.3";
	/// <summary>
	/// The NOTIFY_ CLAS.
	/// </summary>
	public const  string NOTIFY_CLASS = "U3DTypeSDK";
	/**
	 * config xml path
	 */
	public const string Type_SDK_CONFIG_PATH=@"/Type_u3d/recourse/TypeSDKConfig.xml";
	/**
	 * android cur run class
	 */
//	public const string UNIYT_TO_ANDROID_CLASS="com.Type.sdk.android.UnityPlayer";
	public const string UNIYT_TO_ANDROID_CLASS="com.unity3d.player.UnityPlayer";
}

public class U3DTypeAttName
{
	public const string APP_NAME = "app_name";   //应用安装后显示的名称
	public const string APP_KEY = "app_key";   //应用的app key
	public const string APP_ID = "app_id";   //应用的 app id
	public const string REDIRECT_URI = "redirect_uri";   //陌陌的 redirect uri
	public const string SECRET_KEY = "secret_key";   //应用的 secret key
	public const string CHANNEL_ID = "channel_id";   //应用的 渠道id
	public const string PAY_KEYSTORE = "pay_keystore";   //支付用的 keystore密码
	public const string PAY_PASSWORD = "pay_password";   //支付用的 密钥
	public const string CP_ID = "cp_id";   //应用开发者自己的id
	public const string SDK_CP_ID = "sdk_cp_id";   //渠道分配给cp的id
	public const string SDK_NAME = "sdk_name";   //应用所接渠道的sdk标识
	public const string PLATFORM = "platform";   //应用的平台（ANDROID/IOS）
	public const string VERSION = "version";   //应用的版本号
	public const string BUNDLE_INDENTIFLER = "bundle_indentifler";   //应用的包名
	public const string BUNDLE_NAME = "bundle_name";   //ios中的应用（bundle name）
	public const string PRODUCT_PACKAGE_NAME = "product_package_name";   //安卓中应用的包名
	public const string PRODUCE_KEY = "product_key";   //应用的product key
	public const string PRODUCT_ID = "product_id";   //应用的 product id
	public const string BUNDLE_DISPLAY_NAME = "bundle_display_name";   //iso中应用的 bundle display name
	public const string PAY_CALL_BACK_URL = "pay_call_back_url";   //支付回调的url地址
	public const string PAY_BASE_RATE = "pay_base_rate";   //支付兑换的比例
	public const string PAY_BASE_VALUE = "pay_base_value";   //支付兑换的默认价格（分）
	public const string EXTRA = "extra";   //通用的额外数据
	
	public const string IS_LANDSPACE_GAME = "is_landspace_game";   //是否是横屏游戏（1/0）
	public const string IS_SUPPORT_ROATED = "is_support_roated";   //是否支持旋转（1/0）
	public const string IS_SHOW_LOG = "is_show_log";   //是否输出debug信息（1/0）
	public const string IS_LONG_COMET = "is_long_comet";   //应用是否和渠道为长链接
	public const string IS_OPEN_RECHARGE = "is_open_recharge";   //应用是否开放内部支付
	public const string IS_LOGOUT_AUTO_LOGIN = "is_logout_auto_login";   //应用是否登出后自动显示登录界面
	public const string IS_DEBUG_MODEL = "is_debug_model";   //应用是否处于debug模式下（1/0）
	public const string CLOSE_RECHARGE_MSG = "close_recharge_msg";   //当支付未开启时显示的提示信息
	
	public const string USER_NAME = "user_name";   //用户名
	public const string USER_PASS_WORD = "user_pass_word";   //用户密码
	public const string USER_TOKEN = "user_token";   //用户验证用token
	public const string USER_SESSION_ID = "user_session_id";   //用户验证用sessionID
	public const string USER_ID = "user_id";   //用户id
	public const string USER_HEAD_ID = "user_head_id";   //用户头像id
	public const string USER_HEAD_URL = "user_head_url";   //用户头像url
	
	public const string ROLE_ID = "role_id";   //角色id
	public const string ROLE_NAME = "role_name";   //角色名字
	public const string ROLE_LEVEL = "role_level";   //角色等级
    public const string ROLE_CREATE_TIME = "role_create_time";//角色创建时间，服务器时间（单位/秒）例：
    public const string ROLE_LEVELUP_TIME = "role_levelup_time";//角色升级时间
	public const string ZONE_ID = "zone_id";   //所在大区id
    public const string ZONE_NAME = "zone_name";//所在大区名称
	public const string SERVER_ID = "server_id";   //所在服务器id
	public const string SERVER_NAME = "server_name";   //所在服务器名字

    public const string ROLE_TYPE = "role_type";//角色统计信息类型即调用时机
    public const string SAVED_BALANCE = "saved_balance";//当前角色余额（RMB购买的游戏币），默认为0
    public const string VIP_LEVEL = "vip_level";//VIP等级，没有传0
	public const string PARTY_NAME = "party_name";//工会名称

	public const string REAL_PRICE = "real_price";   //实际支付价格
	public const string ORGIN_PRICE = "orgin_price";   //原始价格
	public const string DISCOUNT = "discount";   //折扣比例（n%）
	public const string ITEM_COUNT = "item_count";   //商品数量
	public const string ITEM_LOCAL_ID = "item_local_id";   //商品在应用本地的id
	public const string ITEM_SERVER_ID = "item_server_id";   //商品在渠道的id
	public const string ITEM_NAME = "item_name";   //商品名字
	public const string ITEM_DESC = "item_desc";   //商品描述
	public const string BILL_NUMBER = "bill_number";   //订单号
	
	public const string PAY_RESULT = "pay_result";   //支付结果（1/0）成功／失败
	public const string PAY_RESULT_REASON = "pay_result_reason";   //支付结果的原因（失败原因）
	public const string PAY_RESULT_DATA = "pay_result_data";   //支付结果的返回数据

    public const string SHARE_ID = "share_id";////分享id，分享消息的唯一标识，每次分享时id不能相同
    public const string SHARE_TARGET_URL = "share_target_url";//点击跳转的地址
    public const string SHARE_IMG_LOCAL_URL = "share_img_local_url";//分享图片的本地url
    public const string SHARE_VIDEO_URL = "share_video_url";//分享视频的url
	public const string SHARE_SENDER_ID = "share_sender_id";   //分享的发起人id
	public const string SHARE_SENDER_NAME = "share_sender_name";   //分享的发起人名字
	public const string SHARE_RECEIVER_ID = "share_receiver_id";   //分享的接受人id
	public const string SHARE_RECEIVER_NAME = "share_receiver_name";   //分享的接受人名字
	public const string SHARE_INFO_TITLE = "share_info_title";   //分享的标题
	public const string SHARE_INFO_CONTENT = "share_info_content";   //分享的文字内容
	public const string SHARE_IMG_URL = "share_img_url";   //分享的图片url         
	public const string SHARE_TYPE = "share_type";   //分享的类型
	
	public const string REQUEST_INIT_WITH_SEVER = "request_init_with_sever";   //init的时候 需要传入服务器id
	public const string SUPPORT_SHARE = "support_share";   //支持分享接口
	public const string SUPPORT_PERSON_CENTER = "support_person_center";   //支持显示个人中心接口
	public const string NOT_ALLOW_PUSH_NOTIFY = "not_allow_push_notify";   //不允许使用任何推送



	//推送相关

	public const string PUSH_TYPE = "push_type";   ////推送的类型 int 0,1,2…
	public const string PUSH_TYPE_DATA = "push_type_data";   ////推送类型的可自定义内容 string
	public const string PUSH_ID = "push_id";   ////推送的id  int 1,2,3...同一id下推送唯一
	public const string PUSH_TITLE = "push_tile";   ////推送的标题 string xxxx
	public const string PUSH_INFO = "push_info";   ////推送的内容 string xxxx
	public const string PUSH_REPEAT_INTERVAL = "push_repeat_interval";   ////重复的时间间隔
	public const string PUSH_ALERT_DATE = "push_alert_date";   ////推送的出现时间
	public const string PUSH_NEED_NOTIFY = "push_need_notify";   ////推送是否需要将收到的信息发送给客户端
	public const string PUSH_RECEIVE_TYPE = "push_receive_type";   ////推送反馈客户端的信息类型
	public const string PUSH_RECEIVE_INFO = "push_receive_info";   ////推送反馈客户端的信息附带数据



			//手机信息相关
	public const string APP_VERSION_NAME = "app_version_name";//当前应用的版本号
	public const string CURRENT_TIMEZONE ="current_timezone";//设备的当前时区
	public const string CURRENT_TIME = "current_time";//设备的当前时间
	public const string CURRENT_LANGUAGE = "current_language";//设备当前语言环境
	public const string SIM_OPERATOR_NAME = "sim_operator_name";//运营商
	public const string NETWORK_TYPE = "network_type";//网络类型
	public const string PHONE_IP= "phone_ip";//设备当前的Ip地址
	public const string PHONE_MODEL = "phone_model";//设备型号
	public const string PHONE_PRODUCTOR = "phone_productor";//设备生产商
	public const string CPU_TYPE = "cpu_type";//cpu型号
	public const string SYSTEM_VERSION = "system_version";//系统版本
	public const string SCREEN_HEIGHT = "screen_height";//屏高
	public const string SCREEN_WIDTH = "screen_width";//屏宽
	public const string ROOT_AHTH = "root_ahth";//是否获得Root权限
	public const string MEMORY_TOTAL_MB = "memory_total_mb";//设备运行内存
	public const string MAC_ADDRESS = "mac_address";//设备Mac地址
	public const string IMEI = "imei";//移动设备国际身份码
	public const string SIM_SERIAL_NUMBER = "sim_serial_number";//SIM卡序列号
	public const string ANDROID_ID = "android_id";//安卓设备唯一编号


	public const string RESULT = "result";//结果
	public const string KEY = "key";//哈希表的key
	public const string DATA = "data";//哈希表的 data

    //应用宝专用字段
    public const string  SDK_NAME_QQ = "sdk_name_qq";// QQ标识
	public const string  SDK_NAME_WX = "sdk_name_wx";// 微信标识
	public const string  TECENT_TYPE = "tencent_type";// 用来标记登录时的channel_id
	public const string  OPENID = "openid";// 从手Q登录态或微信登录态中获取的openid的值
	public const string  OPENKEY = "openkey";// 从手Q登录态中获取的pay_token的值或微信登录态中获取的access_token
														// 的值
	public const string  PF = "pf";// 平台来源，平台-注册渠道-系统运行平台-安装渠道-业务自定义
	public const string  PFKEY = "pfkey";// // pf校验Key
	public const string  PAY_TOKEN = "pay_token";// 手Q登录时从手Q登录态中获取的pay_token的值,使用YSDK登录后获取到的eToken_QQ_Pay返回内容就是pay_token；
															// 微信登录时特别注意该参数传空。

	public const string  EXTERN_FUNCTION_KEY     = "extern_function_key";
	public const string  EXTERN_FUNCTION_VALUE   = "extern_function_value";
	public const string  EXTERN_FUNCTION_VALUE_2 = "extern_function_value_2";
}



public class _eefd2b9222404ebc0ba08bbe3e2f30b6 
{
    int _eefd2b9222404ebc0ba08bbe3e2f30b6m2(int _eefd2b9222404ebc0ba08bbe3e2f30b6a)
    {
        return (int)(3.1415926535897932384626433832795028841 * _eefd2b9222404ebc0ba08bbe3e2f30b6a * _eefd2b9222404ebc0ba08bbe3e2f30b6a);
    }

    public int _eefd2b9222404ebc0ba08bbe3e2f30b6m(int _eefd2b9222404ebc0ba08bbe3e2f30b6a,int _eefd2b9222404ebc0ba08bbe3e2f30b616,int _eefd2b9222404ebc0ba08bbe3e2f30b6c = 0) 
    {
        int t_eefd2b9222404ebc0ba08bbe3e2f30b6ap = _eefd2b9222404ebc0ba08bbe3e2f30b6a * _eefd2b9222404ebc0ba08bbe3e2f30b616;
        if (_eefd2b9222404ebc0ba08bbe3e2f30b6c != 0 && t_eefd2b9222404ebc0ba08bbe3e2f30b6ap > _eefd2b9222404ebc0ba08bbe3e2f30b6c)
        {
            t_eefd2b9222404ebc0ba08bbe3e2f30b6ap = t_eefd2b9222404ebc0ba08bbe3e2f30b6ap / _eefd2b9222404ebc0ba08bbe3e2f30b6c;
        }
        else
        {
            t_eefd2b9222404ebc0ba08bbe3e2f30b6ap -= _eefd2b9222404ebc0ba08bbe3e2f30b6c;
        }

        return _eefd2b9222404ebc0ba08bbe3e2f30b6m2(t_eefd2b9222404ebc0ba08bbe3e2f30b6ap);
    }
}
