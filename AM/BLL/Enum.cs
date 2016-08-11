using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using MFXinY.Common;

namespace AM.BLL
{
    /// <summary>
    /// 数据字典里的类型
    /// </summary>
    public enum EnumDBList
    {
        /// <summary>
        /// 矿井编号
        /// </summary>
        [ExDescriptionAttribute("矿井编号", true)]
        MineCode = 1,
        /// <summary>
        /// 职务
        /// </summary>
        [ExDescriptionAttribute("职务", true)]
        Duty = 2

    }
    /// <summary>
    /// RequestHttpType
    /// </summary>
    public enum EnumHttpType
    {
        /// <summary>
        /// Post提交
        /// </summary>
        [ExDescriptionAttribute("Post", true)]
        HttpPost,
        /// <summary>
        /// Get请求
        /// </summary>
        [ExDescriptionAttribute("Get", true)]
        HttpGet
    }
    /// <summary>
    /// 发送到本人还是亲属 类型
    /// </summary>
    public enum EnumSendToType
    {
        /// <summary>
        /// 本人
        /// </summary>
        [ExDescriptionAttribute("本人", true)]
        Self = 1,
        /// <summary>
        /// 亲属
        /// </summary>
        [ExDescriptionAttribute("亲属", true)]
        Friend = 2,
        /// <summary>
        /// 本人与亲属
        /// </summary>
        [ExDescriptionAttribute("本人与亲属", true)]
        SelfAndFriend = 3
    }
    /// <summary>
    /// 人员上下井状态
    /// </summary>
    public enum EnumRyState
    {
        /// <summary>
        /// 上井
        /// </summary>
        [ExDescriptionAttribute("上井", true)]
        Up = 2,
        /// <summary>
        /// 下井
        /// </summary>
        [ExDescriptionAttribute("下井", true)]
        Down = 1,
        /// <summary>
        /// 空闲
        /// </summary>
        [ExDescriptionAttribute("空闲", true)]
        UserNotDown = 0
    }
    /// <summary>
    /// 人员上下井状态
    /// </summary>
    public enum EnumRYWZState
    {
        /// <summary>
        /// 下井
        /// </summary>
        [ExDescriptionAttribute("下井", true)]
        Down = 1,
        /// <summary>
        /// 空闲
        /// </summary>
        [ExDescriptionAttribute("出井或者未入井", true)]
        UserNotDown = 0
    }

    /// <summary>
    /// 用户权限
    /// </summary>
    public enum EnumPermission
    {
        /// <summary>
        /// 超级管理员
        /// </summary>
        // [ExDescriptionAttribute("超级管理员", true)]
        //  Manager = 100,
        /// <summary>
        /// 管理员
        /// </summary>
        [ExDescriptionAttribute("管理员", true)]
        Admin = 1,
        /// <summary>
        /// 普通用户
        /// </summary>
        [ExDescriptionAttribute("普通用户", true)]
        User = 2,
    }
    /// <summary>
    /// 生日类型
    /// </summary>
    public enum EnumBirthdayType
    {
        /// <summary>
        /// 公历
        /// </summary>
        [ExDescriptionAttribute("公历", true)]
        GongLi = 1,
        /// <summary>
        /// 农历
        /// </summary>
        [ExDescriptionAttribute("农历", true)]
        NongLi = 2,
    }
    /// <summary>
    /// 短信类型
    /// </summary>
    public enum EnumMType
    {
        /// <summary>
        /// 上井短信
        /// </summary>
        [ExDescriptionAttribute("上井短信", true)]
        Up = 1,
        /// <summary>
        /// 下井短信
        /// </summary>
        [ExDescriptionAttribute("下井短信", true)]
        Down = 2,
        /// <summary>
        /// 普通短信
        /// </summary>
        [ExDescriptionAttribute("普通短信", true)]
        Normal = 3,
        /// <summary>
        /// 生日短信
        /// </summary>
        [ExDescriptionAttribute("生日短信", true)]
        Birthday = 4

    }
    /// <summary>
    /// 短信状态
    /// </summary>
    public enum EnumMState
    {
        /// <summary>
        /// 待发送
        /// </summary>
        [ExDescriptionAttribute("待发送", true)]
        Waiting = -1,
        /// <summary>
        /// 已发送
        /// </summary>
        [ExDescriptionAttribute("已发送", true)]
        Sended = -2,
        /// <summary>
        /// 发送成功
        /// </summary>
        [ExDescriptionAttribute("发送成功", true)]
        Success = 0,
        /// <summary>
        /// 发送失败
        /// </summary>
        [ExDescriptionAttribute("发送失败", true)]
        Fail = 1,
        /// <summary>
        /// 已撤消
        /// </summary>
        //[ExDescriptionAttribute("已撤消", true)]
        //Cancel = -100

    }

    public enum EnumSystemState
    {
        /// <summary>
        /// 人员系统
        /// </summary>
        [ExDescriptionAttribute("人员系统", true)]
        RenYuan = 1,
        /// <summary>
        /// 瓦斯系统
        /// </summary>
        [ExDescriptionAttribute("瓦斯系统", true)]
        WaSi = 2
    }

    /// <summary>
    /// 组合类型
    /// </summary>
    public enum EnumCombinationType
    {
        [ExDescriptionAttribute("全开报警", true)]
        FullyOpen = 0,
        [ExDescriptionAttribute("全关报警", true)]
        FullyColse = 1,
        [ExDescriptionAttribute("有开报警", true)]
        HasOpen = 2,
        [ExDescriptionAttribute("有关报警", true)]
        HasColse = 3,
        [ExDescriptionAttribute("", true)]
        None = 255

    }

    /// <summary>
    /// 消息级别
    /// </summary>
    public enum EnumMsgLevel
    {
        /// <summary>
        /// 正常
        /// </summary>
        [ExDescriptionAttribute("正常", true)]
        Normal = 1,
        /// <summary>
        /// 漏发
        /// </summary>
        [ExDescriptionAttribute("漏发", true)]
        Miss = 5,
        /// <summary>
        /// 异常
        /// </summary>
        [ExDescriptionAttribute("异常", true)]
        Exc = 10
    }
    /// <summary>
    /// 日志消息类别
    /// </summary>
    public enum EnumMsgLogType
    {
        /// <summary>
        /// 开关量
        /// </summary>
        [ExDescriptionAttribute("开关量", true)]
        Switcher = 1,
        /// <summary>
        /// 瓦斯
        /// </summary>
        [ExDescriptionAttribute("瓦斯", true)]
        WaSi = 5,
        /// <summary>
        /// 人员
        /// </summary>
        [ExDescriptionAttribute("人员", true)]
        RenYuan = 10,
        /// <summary>
        /// 其他
        /// </summary>
        [ExDescriptionAttribute("其他", true)]
        Other = 15
    }


    /// <summary>
    /// 字段类型
    /// </summary>
    public enum EnumFieldType
    {
        /// <summary>
        /// 文件框
        /// </summary>
        [ExDescriptionAttribute("数字", true)]
        Number = 0,
        /// <summary>
        /// 文件框
        /// </summary>
        [ExDescriptionAttribute("文本框", true)]
        Text = 1,
        /// <summary>
        /// 多行文本框
        /// </summary>
        [ExDescriptionAttribute("多行文本框", true)]
        TextArea = 2,
        /// <summary>
        /// 单选
        /// </summary>
        [ExDescriptionAttribute("单选", true)]
        Radio = 3,
        /// <summary>
        /// 复选框
        /// </summary>
        [ExDescriptionAttribute("复选框", true)]
        CheckBox = 4,
        /// <summary>
        /// 下拉框
        /// </summary>
        [ExDescriptionAttribute("下拉框", true)]
        Select = 5,
        /// <summary>
        /// 图片
        /// </summary>
        [ExDescriptionAttribute("图片", true)]
        Image = 6,
        /// <summary>
        /// 日历
        /// </summary>
        [ExDescriptionAttribute("日历", true)]
        DataTime = 7,
        /// <summary>
        /// Email
        /// </summary>
        [ExDescriptionAttribute("Email", true)]
        Email = 8,
        /// <summary>
        /// URL
        /// </summary>
        [ExDescriptionAttribute("URL", true)]
        URL = 9
    }
    /// <summary>
    /// 描述位置
    /// </summary>
    public enum EnumDescDic
    {
        /// <summary>
        /// 描述在控件后面
        /// </summary>
        [ExDescriptionAttribute("控件后面", true)]
        After = 0,
        /// <summary>
        /// 描述在控件里面
        /// </summary>
        [ExDescriptionAttribute("控件里面", true)]
        Alt = 1,
        /// <summary>
        /// 不描述
        /// </summary>
        [ExDescriptionAttribute("无描述", true)]
        None = 2
    }

    /// <summary>
    /// 显示结果以什么方式来排序
    /// </summary>
    public enum EnumOrderBy
    {
        /// <summary>
        /// 以名称排序
        /// </summary>
        Name = 1,
        /// <summary>
        /// 以编码排序
        /// </summary>
        Code = 2,
        /// <summary>
        /// 以时间 正序 排序
        /// </summary>
        TimeAsc = 3,
        /// <summary>
        /// 以时间 反序 排序
        /// </summary>
        TimeDesc = 4,
        /// <summary>
        /// 以 排序 字段来排序
        /// </summary>
        Sort = 5
    }


    public enum EnumHeartbeat
    {

    }
    /// <summary>
    /// 定义好的正则表达式
    /// </summary>
    public enum EnumRegex
    {
        /// <summary>
        /// 整数
        /// </summary>
        [ExDescriptionAttribute("整数", true)]
        intege,
        /// <summary>
        /// 正整数
        /// </summary>
        [ExDescriptionAttribute("正整数", true)]
        intege1,
        /// <summary>
        /// 负整数
        /// </summary>
        [ExDescriptionAttribute("负整数", true)]
        intege2,
        /// <summary>
        /// 数字
        /// </summary>
        [ExDescriptionAttribute("数字", true)]
        num,
        /// <summary>
        /// 正数字
        /// </summary>
        [ExDescriptionAttribute("正数字", true)]
        num1,
        /// <summary>
        /// 负数字
        /// </summary>
        [ExDescriptionAttribute("负数字", true)]
        num2,
        /// <summary>
        /// 浮点数
        /// </summary>
        [ExDescriptionAttribute("浮点数", true)]
        decmal,
        /// <summary>
        /// 正浮点数
        /// </summary>
        [ExDescriptionAttribute("正浮点数", true)]
        decmal1,
        /// <summary>
        /// 负浮点数
        /// </summary>
        [ExDescriptionAttribute("负浮点数", true)]
        decmal2,
        /// <summary>
        /// Email
        /// </summary>
        [ExDescriptionAttribute("Email", true)]
        email,
        /// <summary>
        /// url
        /// </summary>
        [ExDescriptionAttribute("url", true)]
        url,
        /// <summary>
        /// 中文字符
        /// </summary>
        [ExDescriptionAttribute("中文字符", true)]
        chinese,
        /// <summary>
        /// 邮编
        /// </summary>
        [ExDescriptionAttribute("邮编", true)]
        zipcode,
        /// <summary>
        /// 手机
        /// </summary>
        [ExDescriptionAttribute("手机", true)]
        mobile,
        /// <summary>
        /// ip地址
        /// </summary>
        [ExDescriptionAttribute("ip地址", true)]
        ip4,
        /// <summary>
        /// 非空
        /// </summary>
        [ExDescriptionAttribute("非空", true)]
        notempty,
        /// <summary>
        /// 图片
        /// </summary>
        [ExDescriptionAttribute("图片", true)]
        picture,
        /// <summary>
        /// 压缩文件
        /// </summary>
        [ExDescriptionAttribute("压缩文件", true)]
        rar,
        /// <summary>
        /// 日期
        /// </summary>
        [ExDescriptionAttribute("日期", true)]
        date,
        /// <summary>
        /// QQ
        /// </summary>
        [ExDescriptionAttribute("QQ", true)]
        qq,
        /// <summary>
        /// 电话号码的函数(包括验证国内区号,国际区号,分机号)
        /// </summary>
        [ExDescriptionAttribute("电话号码", true)]
        tel,
        /// <summary>
        /// 用来用户注册。匹配由数字、26个英文字母或者下划线组成的字符串
        /// </summary>
        [ExDescriptionAttribute("注册用户", true)]
        username,
        /// <summary>
        /// 字母
        /// </summary>
        [ExDescriptionAttribute("字母", true)]
        letter,
        /// <summary>
        /// 大写字母
        /// </summary>
        [ExDescriptionAttribute("大写字母", true)]
        letter_u,
        /// <summary>
        /// 小写字母
        /// </summary>
        [ExDescriptionAttribute("小写字母", true)]
        letter_l,
        /// <summary>
        /// 身份证
        /// </summary>
        [ExDescriptionAttribute("身份证", true)]
        idcard
    }
    /// <summary>
    /// 网站配置关键字
    /// </summary>
    public enum EnumConfigKey
    {
        /// <summary>
        /// 是否自动生日短信
        /// </summary>
        [ExDescriptionAttribute("是否自动发生日短信", true)]
        IsAutoBirthdayMessage,
        /// <summary>
        /// 人员系统路径
        /// </summary>
        [ExDescriptionAttribute("人员系统路径", false)]
        PersonSystemPath,
        /// <summary>
        /// 人员系统路径
        /// </summary>
        [ExDescriptionAttribute("瓦斯系统路径", false)]
        WaSiSystemPath,
        /// <summary>
        /// 上井发短信
        /// </summary>
        [ExDescriptionAttribute("上井发短信", true)]
        UpSend,
        /// <summary>
        /// 下井发短信
        /// </summary>
        [ExDescriptionAttribute("下井发短信", true)]
        DownSend

    }

    /// <summary>
    /// 客户端与服务端标识
    /// </summary>
    public enum EnumCS : byte
    {
        //人员1-50，瓦斯51-100，开关量101-150，其他151-200
        /// <summary>
        /// 人员旧标准
        /// </summary>
        RenYuan = 1,
        /// <summary>
        /// 人员DB14标准
        /// </summary>
        RenYuan_DB14 = 2,
        /// <summary>
        /// 人员心跳
        /// </summary>
        RenYuan_Question = 3,
        /// <summary>
        /// 人员建立连接
        /// </summary>
        RenYuan_Plus = 4,
        /// <summary>
        /// 人员断开连接
        /// </summary>
        RenYuan_Minus = 5,

        /// <summary>
        /// 人员设置IP
        /// </summary>
        RenYuan_SetIP = 6,
        /// <summary>
        /// 文件路径
        /// </summary>
        RenYuan_FilePath = 7,
        /// <summary>
        /// 设置文件路径
        /// </summary>
        RenYuan_SetFilePath = 8,
        /// <summary>
        /// 瓦斯旧标准
        /// </summary>
        WaSi = 51,
        /// <summary>
        /// 瓦斯DB14标准
        /// </summary>
        WaSi_DB14 = 52,
        /// <summary>
        /// 瓦斯心跳
        /// </summary>
        WaSi_Question = 53,
        /// <summary>
        /// 瓦斯建立连接
        /// </summary>
        WaSi_Plus = 54,
        /// <summary>
        /// 瓦斯断开连接
        /// </summary>
        WaSi_Minus = 55,
        /// <summary>
        /// 瓦斯设置
        /// </summary>
        WaSi_SetIP = 56,
        /// <summary>
        /// 文件路径
        /// </summary>
        WaSi_FilePath = 57,
        /// <summary>
        /// 设置文件路径
        /// </summary>
        WaSi_SetFilePath = 58,
        /// <summary>
        /// 瓦斯DB14标准
        /// </summary>
        WaSi_DB14_AQMC = 60,
        /// <summary>
        /// 瓦斯DB14标准
        /// </summary>
        WaSi_DB14_AQSS = 61,
        /// <summary>
        /// 开关量旧标准
        /// </summary>
        Switcher = 101,
        /// <summary>
        /// 开关量DB14标准
        /// </summary>
        Switcher_DB14 = 102
    }

    /// <summary>
    /// 消息类别
    /// </summary>
    public enum EnumMessageCatalog
    {
        /// <summary>
        /// DB14协议
        /// </summary>
        DB14 = 1,
        /// <summary>
        /// 普通协议
        /// </summary>
        Normal = 5
    }

    /// <summary>
    /// 订单状态
    /// </summary>
    public enum EnumOrderType
    {
        /// <summary>
        /// 待付款
        /// </summary>
        [ExDescriptionAttribute("待付款", true)]
        WaitingMoney = 1,
        /// <summary>
        /// 待发货
        /// </summary>
        [ExDescriptionAttribute("待发货", true)]
        WaitingSend = 2,
        /// <summary>
        /// 待收货
        /// </summary>
        [ExDescriptionAttribute("待收货", true)]
        WaitingReceive = 3,
        /// <summary>
        /// 确认收货
        /// </summary>
        [ExDescriptionAttribute("确认收货", true)]
        WaitingPingJia = 4,
        
        /// <summary>
        /// 取消订单
        /// </summary>
        [ExDescriptionAttribute("取消订单", true)]
        CancelOrder = 0,       
        /// <summary>
        /// 完成订单
        /// </summary>
        [ExDescriptionAttribute("完成订单", true)]
        FinishOrder = 9,

        /// <summary>
        /// 已申请退款
        /// </summary>
        [ExDescriptionAttribute("已申请退款", true)]
        SQTK = 5,
        /// <summary>
        /// 退款成功
        /// </summary>
        [ExDescriptionAttribute("退款成功", true)]
        TKCG = 6,
        /// <summary>
        /// 退款失败
        /// </summary>
        [ExDescriptionAttribute("退款失败", true)]
        TKSB = 7,
        /// <summary>
        /// 退货中,
        /// </summary>
        [ExDescriptionAttribute("退货中", true)]
        Refund = 8,
    }

    public class EnumManager
    {
        /// <summary>
        /// 得到枚举 所有可用项的描述与名字
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> GetTypes(Type enumType)
        {
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();
            foreach (var name in Enum.GetNames(enumType))
            {
                FieldInfo enumInfo = enumType.GetField(name);
                ExDescriptionAttribute[] enumAttributes = (ExDescriptionAttribute[])enumInfo.
                    GetCustomAttributes(typeof(ExDescriptionAttribute), false);
                if (enumAttributes.Length > 0)
                {
                    result.Add(new KeyValuePair<string, string>(name, enumAttributes[0].DescriptionName));
                }
                else
                {
                    result.Add(new KeyValuePair<string, string>(name, name));
                }
            }
            return result;
        }
        /// <summary>
        /// 得到枚举，所有可用项的描述与枚举值
        /// key 描述
        /// value 枚举值
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> GetEnumInts(Type enumType)
        {
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();
            foreach (var name in Enum.GetNames(enumType))
            {
                FieldInfo enumInfo = enumType.GetField(name);
                ExDescriptionAttribute[] enumAttributes = (ExDescriptionAttribute[])enumInfo.
                    GetCustomAttributes(typeof(ExDescriptionAttribute), false);
                //值列
                var value = ((int)Enum.Parse(enumType, enumInfo.Name)).ToString();
                if (enumAttributes.Length > 0)
                {
                    result.Add(new KeyValuePair<string, string>(value, enumAttributes[0].DescriptionName));
                }
                else
                {
                    result.Add(new KeyValuePair<string, string>(value, name));
                }
            }
            return result;
        }
    }
}