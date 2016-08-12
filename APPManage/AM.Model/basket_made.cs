/**  版本信息模板在安装目录下，可自行修改。
* basket_made.cs
*
* 功 能： N/A
* 类 名： basket_made
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 17:55:17   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace AM.Model
{
	/// <summary>
	/// basket_made:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class basket_made
	{
		public basket_made()
		{}
		#region Model
		private string _guid;
		private string _userid;
		private DateTime? _createdate;
		private string _qymc;
		private string _qydz;
		private string _yb;
		private string _zzjgdm;
		private string _lxr;
		private string _gddh;
		private string _yddh;
		private string _dzyx;
		private string _cz;
		private string _yyzzzch;
		private string _jjlx;
		private string _zczj;
		private string _gdzc;
		private string _qyzgzrs;
		private string _kszzdlrq;
		private string _sqcpggxh;
		private string _fddbxm;
		private string _fddbxb;
		private string _fddbzgxl;
		private string _fddbzw;
		private string _fddbzc;
		private string _fddbzy;
		private string _fddbgddh;
		private string _fddbyddh;
		private string _fddbzypx;
		private string _fddbpxsj;
		private string _fddbzsbh;
		private string _zlfzrxm;
		private string _zlfzrxb;
		private string _zlfzrzgxl;
		private string _zlfzrzw;
		private string _zlfzrzc;
		private string _zlfzrzy;
		private string _zlfzrgddh;
		private string _zlfzryddh;
		private string _zlfzrzypx;
		private string _zlfzrpxsj;
		private string _zlfzrzsbh;
		private string _gzryxh1;
		private string _gzryxm1;
		private string _gzryzw1;
		private string _gzryzc1;
		private string _gzryfzjg1;
		private string _gzryxl1;
		private string _gzryzy1;
		private string _gzryxh2;
		private string _gzryxm2;
		private string _gzryzw2;
		private string _gzryzc2;
		private string _gzryfzjg2;
		private string _gzryxl2;
		private string _gzryzy2;
		private string _gzryxh3;
		private string _gzryxm3;
		private string _gzryzw3;
		private string _gzryzc3;
		private string _gzryfzjg3;
		private string _gzryxl3;
		private string _gzryzy3;
		private string _gzryxh4;
		private string _gzryxm4;
		private string _gzryzw4;
		private string _gzryzc4;
		private string _gzryfzjg4;
		private string _gzryxl4;
		private string _gzryzy4;
		private string _gzryxh5;
		private string _gzryxm5;
		private string _gzryzw5;
		private string _gzryzc5;
		private string _gzryfzjg5;
		private string _gzryxl5;
		private string _gzryzy5;
		private string _tzzyryxh1;
		private string _tzzyryxm1;
		private string _tzzyrygz1;
		private string _tzzyryxh2;
		private string _tzzyryxm2;
		private string _tzzyrygz2;
		private string _tzzyryxh3;
		private string _tzzyryxm3;
		private string _tzzyrygz3;
		private string _tzzyryxh4;
		private string _tzzyryxm4;
		private string _tzzyrygz4;
		private string _tzzyryxh5;
		private string _tzzyryxm5;
		private string _tzzyrygz5;
		private string _zgzsfzjg1;
		private string _zgzszsbh1;
		private string _zgzsyxq1;
		private string _zgzsfzjg2;
		private string _zgzszsbh2;
		private string _zgzsyxq2;
		private string _zgzsfzjg3;
		private string _zgzszsbh3;
		private string _zgzsyxq3;
		private string _zgzsfzjg4;
		private string _zgzszsbh4;
		private string _zgzsyxq4;
		private string _zgzsfzjg5;
		private string _zgzszsbh5;
		private string _zgzsyxq5;
		private string _mxxh1;
		private string _mxsbmc1;
		private string _mxgg1;
		private string _mxsl1;
		private string _mxzzs1;
		private string _mxxh2;
		private string _mxsbmc2;
		private string _mxgg2;
		private string _mxsl2;
		private string _mxzzs2;
		private string _mxxh3;
		private string _mxsbmc3;
		private string _mxgg3;
		private string _mxsl3;
		private string _mxzzs3;
		private string _mxxh4;
		private string _mxsbmc4;
		private string _mxgg4;
		private string _mxsl4;
		private string _mxzzs4;
		private string _mxxh5;
		private string _mxsbmc5;
		private string _mxgg5;
		private string _mxsl5;
		private string _mxzzs5;
		private string _jyylmxxh1;
		private string _jyylmxmc1;
		private string _jyylmxgg1;
		private string _jyylmxsl1;
		private string _jyylmxyxq1;
		private string _jyylmxxh2;
		private string _jyylmxmc2;
		private string _jyylmxgg2;
		private string _jyylmxsl2;
		private string _jyylmxyxq2;
		private string _jyylmxxh3;
		private string _jyylmxmc3;
		private string _jyylmxgg3;
		private string _jyylmxsl3;
		private string _jyylmxyxq3;
		private string _jyylmxxh4;
		private string _jyylmxmc4;
		private string _jyylmxgg4;
		private string _jyylmxsl4;
		private string _jyylmxyxq4;
		private string _jyylmxxh5;
		private string _jyylmxmc5;
		private string _jyylmxgg5;
		private string _jyylmxsl5;
		private string _jyylmxyxq5;
		private string _yjylnd1;
		private string _yjylggxh1;
		private string _yjylcl1;
		private string _yjylxssr1;
		private string _yjylbz1;
		private string _yjylnd2;
		private string _yjylggxh2;
		private string _yjylcl2;
		private string _yjylxssr2;
		private string _yjylbz2;
		private string _yjylnd3;
		private string _yjylggxh3;
		private string _yjylcl3;
		private string _yjylxssr3;
		private string _yjylbz3;
		private string _yjylnd4;
		private string _yjylggxh4;
		private string _yjylcl4;
		private string _yjylxssr4;
		private string _yjylbz4;
		private string _yjylnd5;
		private string _yjylggxh5;
		private string _yjylcl5;
		private string _yjylxssr5;
		private string _yjylbz5;
		/// <summary>
		/// 
		/// </summary>
		public string Guid
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userid
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qymc
		{
			set{ _qymc=value;}
			get{return _qymc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qydz
		{
			set{ _qydz=value;}
			get{return _qydz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yb
		{
			set{ _yb=value;}
			get{return _yb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zzjgdm
		{
			set{ _zzjgdm=value;}
			get{return _zzjgdm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lxr
		{
			set{ _lxr=value;}
			get{return _lxr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gddh
		{
			set{ _gddh=value;}
			get{return _gddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yddh
		{
			set{ _yddh=value;}
			get{return _yddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dzyx
		{
			set{ _dzyx=value;}
			get{return _dzyx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cz
		{
			set{ _cz=value;}
			get{return _cz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yyzzzch
		{
			set{ _yyzzzch=value;}
			get{return _yyzzzch;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jjlx
		{
			set{ _jjlx=value;}
			get{return _jjlx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zczj
		{
			set{ _zczj=value;}
			get{return _zczj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gdzc
		{
			set{ _gdzc=value;}
			get{return _gdzc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qyzgzrs
		{
			set{ _qyzgzrs=value;}
			get{return _qyzgzrs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string kszzdlrq
		{
			set{ _kszzdlrq=value;}
			get{return _kszzdlrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sqcpggxh
		{
			set{ _sqcpggxh=value;}
			get{return _sqcpggxh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbxm
		{
			set{ _fddbxm=value;}
			get{return _fddbxm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbxb
		{
			set{ _fddbxb=value;}
			get{return _fddbxb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbzgxl
		{
			set{ _fddbzgxl=value;}
			get{return _fddbzgxl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbzw
		{
			set{ _fddbzw=value;}
			get{return _fddbzw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbzc
		{
			set{ _fddbzc=value;}
			get{return _fddbzc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbzy
		{
			set{ _fddbzy=value;}
			get{return _fddbzy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbgddh
		{
			set{ _fddbgddh=value;}
			get{return _fddbgddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbyddh
		{
			set{ _fddbyddh=value;}
			get{return _fddbyddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbzypx
		{
			set{ _fddbzypx=value;}
			get{return _fddbzypx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbpxsj
		{
			set{ _fddbpxsj=value;}
			get{return _fddbpxsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fddbzsbh
		{
			set{ _fddbzsbh=value;}
			get{return _fddbzsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzrxm
		{
			set{ _zlfzrxm=value;}
			get{return _zlfzrxm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzrxb
		{
			set{ _zlfzrxb=value;}
			get{return _zlfzrxb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzrzgxl
		{
			set{ _zlfzrzgxl=value;}
			get{return _zlfzrzgxl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzrzw
		{
			set{ _zlfzrzw=value;}
			get{return _zlfzrzw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzrzc
		{
			set{ _zlfzrzc=value;}
			get{return _zlfzrzc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzrzy
		{
			set{ _zlfzrzy=value;}
			get{return _zlfzrzy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzrgddh
		{
			set{ _zlfzrgddh=value;}
			get{return _zlfzrgddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzryddh
		{
			set{ _zlfzryddh=value;}
			get{return _zlfzryddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzrzypx
		{
			set{ _zlfzrzypx=value;}
			get{return _zlfzrzypx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzrpxsj
		{
			set{ _zlfzrpxsj=value;}
			get{return _zlfzrpxsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zlfzrzsbh
		{
			set{ _zlfzrzsbh=value;}
			get{return _zlfzrzsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxh1
		{
			set{ _gzryxh1=value;}
			get{return _gzryxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxm1
		{
			set{ _gzryxm1=value;}
			get{return _gzryxm1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzw1
		{
			set{ _gzryzw1=value;}
			get{return _gzryzw1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzc1
		{
			set{ _gzryzc1=value;}
			get{return _gzryzc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryfzjg1
		{
			set{ _gzryfzjg1=value;}
			get{return _gzryfzjg1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxl1
		{
			set{ _gzryxl1=value;}
			get{return _gzryxl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzy1
		{
			set{ _gzryzy1=value;}
			get{return _gzryzy1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxh2
		{
			set{ _gzryxh2=value;}
			get{return _gzryxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxm2
		{
			set{ _gzryxm2=value;}
			get{return _gzryxm2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzw2
		{
			set{ _gzryzw2=value;}
			get{return _gzryzw2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzc2
		{
			set{ _gzryzc2=value;}
			get{return _gzryzc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryfzjg2
		{
			set{ _gzryfzjg2=value;}
			get{return _gzryfzjg2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxl2
		{
			set{ _gzryxl2=value;}
			get{return _gzryxl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzy2
		{
			set{ _gzryzy2=value;}
			get{return _gzryzy2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxh3
		{
			set{ _gzryxh3=value;}
			get{return _gzryxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxm3
		{
			set{ _gzryxm3=value;}
			get{return _gzryxm3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzw3
		{
			set{ _gzryzw3=value;}
			get{return _gzryzw3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzc3
		{
			set{ _gzryzc3=value;}
			get{return _gzryzc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryfzjg3
		{
			set{ _gzryfzjg3=value;}
			get{return _gzryfzjg3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxl3
		{
			set{ _gzryxl3=value;}
			get{return _gzryxl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzy3
		{
			set{ _gzryzy3=value;}
			get{return _gzryzy3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxh4
		{
			set{ _gzryxh4=value;}
			get{return _gzryxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxm4
		{
			set{ _gzryxm4=value;}
			get{return _gzryxm4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzw4
		{
			set{ _gzryzw4=value;}
			get{return _gzryzw4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzc4
		{
			set{ _gzryzc4=value;}
			get{return _gzryzc4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryfzjg4
		{
			set{ _gzryfzjg4=value;}
			get{return _gzryfzjg4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxl4
		{
			set{ _gzryxl4=value;}
			get{return _gzryxl4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzy4
		{
			set{ _gzryzy4=value;}
			get{return _gzryzy4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxh5
		{
			set{ _gzryxh5=value;}
			get{return _gzryxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxm5
		{
			set{ _gzryxm5=value;}
			get{return _gzryxm5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzw5
		{
			set{ _gzryzw5=value;}
			get{return _gzryzw5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzc5
		{
			set{ _gzryzc5=value;}
			get{return _gzryzc5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryfzjg5
		{
			set{ _gzryfzjg5=value;}
			get{return _gzryfzjg5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryxl5
		{
			set{ _gzryxl5=value;}
			get{return _gzryxl5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzryzy5
		{
			set{ _gzryzy5=value;}
			get{return _gzryzy5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyryxh1
		{
			set{ _tzzyryxh1=value;}
			get{return _tzzyryxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyryxm1
		{
			set{ _tzzyryxm1=value;}
			get{return _tzzyryxm1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyrygz1
		{
			set{ _tzzyrygz1=value;}
			get{return _tzzyrygz1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyryxh2
		{
			set{ _tzzyryxh2=value;}
			get{return _tzzyryxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyryxm2
		{
			set{ _tzzyryxm2=value;}
			get{return _tzzyryxm2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyrygz2
		{
			set{ _tzzyrygz2=value;}
			get{return _tzzyrygz2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyryxh3
		{
			set{ _tzzyryxh3=value;}
			get{return _tzzyryxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyryxm3
		{
			set{ _tzzyryxm3=value;}
			get{return _tzzyryxm3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyrygz3
		{
			set{ _tzzyrygz3=value;}
			get{return _tzzyrygz3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyryxh4
		{
			set{ _tzzyryxh4=value;}
			get{return _tzzyryxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyryxm4
		{
			set{ _tzzyryxm4=value;}
			get{return _tzzyryxm4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyrygz4
		{
			set{ _tzzyrygz4=value;}
			get{return _tzzyrygz4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyryxh5
		{
			set{ _tzzyryxh5=value;}
			get{return _tzzyryxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyryxm5
		{
			set{ _tzzyryxm5=value;}
			get{return _tzzyryxm5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzzyrygz5
		{
			set{ _tzzyrygz5=value;}
			get{return _tzzyrygz5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzsfzjg1
		{
			set{ _zgzsfzjg1=value;}
			get{return _zgzsfzjg1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzszsbh1
		{
			set{ _zgzszsbh1=value;}
			get{return _zgzszsbh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzsyxq1
		{
			set{ _zgzsyxq1=value;}
			get{return _zgzsyxq1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzsfzjg2
		{
			set{ _zgzsfzjg2=value;}
			get{return _zgzsfzjg2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzszsbh2
		{
			set{ _zgzszsbh2=value;}
			get{return _zgzszsbh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzsyxq2
		{
			set{ _zgzsyxq2=value;}
			get{return _zgzsyxq2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzsfzjg3
		{
			set{ _zgzsfzjg3=value;}
			get{return _zgzsfzjg3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzszsbh3
		{
			set{ _zgzszsbh3=value;}
			get{return _zgzszsbh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzsyxq3
		{
			set{ _zgzsyxq3=value;}
			get{return _zgzsyxq3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzsfzjg4
		{
			set{ _zgzsfzjg4=value;}
			get{return _zgzsfzjg4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzszsbh4
		{
			set{ _zgzszsbh4=value;}
			get{return _zgzszsbh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzsyxq4
		{
			set{ _zgzsyxq4=value;}
			get{return _zgzsyxq4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzsfzjg5
		{
			set{ _zgzsfzjg5=value;}
			get{return _zgzsfzjg5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzszsbh5
		{
			set{ _zgzszsbh5=value;}
			get{return _zgzszsbh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zgzsyxq5
		{
			set{ _zgzsyxq5=value;}
			get{return _zgzsyxq5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxxh1
		{
			set{ _mxxh1=value;}
			get{return _mxxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxsbmc1
		{
			set{ _mxsbmc1=value;}
			get{return _mxsbmc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxgg1
		{
			set{ _mxgg1=value;}
			get{return _mxgg1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxsl1
		{
			set{ _mxsl1=value;}
			get{return _mxsl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxzzs1
		{
			set{ _mxzzs1=value;}
			get{return _mxzzs1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxxh2
		{
			set{ _mxxh2=value;}
			get{return _mxxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxsbmc2
		{
			set{ _mxsbmc2=value;}
			get{return _mxsbmc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxgg2
		{
			set{ _mxgg2=value;}
			get{return _mxgg2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxsl2
		{
			set{ _mxsl2=value;}
			get{return _mxsl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxzzs2
		{
			set{ _mxzzs2=value;}
			get{return _mxzzs2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxxh3
		{
			set{ _mxxh3=value;}
			get{return _mxxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxsbmc3
		{
			set{ _mxsbmc3=value;}
			get{return _mxsbmc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxgg3
		{
			set{ _mxgg3=value;}
			get{return _mxgg3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxsl3
		{
			set{ _mxsl3=value;}
			get{return _mxsl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxzzs3
		{
			set{ _mxzzs3=value;}
			get{return _mxzzs3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxxh4
		{
			set{ _mxxh4=value;}
			get{return _mxxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxsbmc4
		{
			set{ _mxsbmc4=value;}
			get{return _mxsbmc4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxgg4
		{
			set{ _mxgg4=value;}
			get{return _mxgg4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxsl4
		{
			set{ _mxsl4=value;}
			get{return _mxsl4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxzzs4
		{
			set{ _mxzzs4=value;}
			get{return _mxzzs4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxxh5
		{
			set{ _mxxh5=value;}
			get{return _mxxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxsbmc5
		{
			set{ _mxsbmc5=value;}
			get{return _mxsbmc5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxgg5
		{
			set{ _mxgg5=value;}
			get{return _mxgg5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxsl5
		{
			set{ _mxsl5=value;}
			get{return _mxsl5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mxzzs5
		{
			set{ _mxzzs5=value;}
			get{return _mxzzs5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxxh1
		{
			set{ _jyylmxxh1=value;}
			get{return _jyylmxxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxmc1
		{
			set{ _jyylmxmc1=value;}
			get{return _jyylmxmc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxgg1
		{
			set{ _jyylmxgg1=value;}
			get{return _jyylmxgg1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxsl1
		{
			set{ _jyylmxsl1=value;}
			get{return _jyylmxsl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxyxq1
		{
			set{ _jyylmxyxq1=value;}
			get{return _jyylmxyxq1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxxh2
		{
			set{ _jyylmxxh2=value;}
			get{return _jyylmxxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxmc2
		{
			set{ _jyylmxmc2=value;}
			get{return _jyylmxmc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxgg2
		{
			set{ _jyylmxgg2=value;}
			get{return _jyylmxgg2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxsl2
		{
			set{ _jyylmxsl2=value;}
			get{return _jyylmxsl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxyxq2
		{
			set{ _jyylmxyxq2=value;}
			get{return _jyylmxyxq2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxxh3
		{
			set{ _jyylmxxh3=value;}
			get{return _jyylmxxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxmc3
		{
			set{ _jyylmxmc3=value;}
			get{return _jyylmxmc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxgg3
		{
			set{ _jyylmxgg3=value;}
			get{return _jyylmxgg3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxsl3
		{
			set{ _jyylmxsl3=value;}
			get{return _jyylmxsl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxyxq3
		{
			set{ _jyylmxyxq3=value;}
			get{return _jyylmxyxq3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxxh4
		{
			set{ _jyylmxxh4=value;}
			get{return _jyylmxxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxmc4
		{
			set{ _jyylmxmc4=value;}
			get{return _jyylmxmc4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxgg4
		{
			set{ _jyylmxgg4=value;}
			get{return _jyylmxgg4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxsl4
		{
			set{ _jyylmxsl4=value;}
			get{return _jyylmxsl4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxyxq4
		{
			set{ _jyylmxyxq4=value;}
			get{return _jyylmxyxq4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxxh5
		{
			set{ _jyylmxxh5=value;}
			get{return _jyylmxxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxmc5
		{
			set{ _jyylmxmc5=value;}
			get{return _jyylmxmc5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxgg5
		{
			set{ _jyylmxgg5=value;}
			get{return _jyylmxgg5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxsl5
		{
			set{ _jyylmxsl5=value;}
			get{return _jyylmxsl5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyylmxyxq5
		{
			set{ _jyylmxyxq5=value;}
			get{return _jyylmxyxq5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylnd1
		{
			set{ _yjylnd1=value;}
			get{return _yjylnd1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylggxh1
		{
			set{ _yjylggxh1=value;}
			get{return _yjylggxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylcl1
		{
			set{ _yjylcl1=value;}
			get{return _yjylcl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylxssr1
		{
			set{ _yjylxssr1=value;}
			get{return _yjylxssr1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylbz1
		{
			set{ _yjylbz1=value;}
			get{return _yjylbz1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylnd2
		{
			set{ _yjylnd2=value;}
			get{return _yjylnd2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylggxh2
		{
			set{ _yjylggxh2=value;}
			get{return _yjylggxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylcl2
		{
			set{ _yjylcl2=value;}
			get{return _yjylcl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylxssr2
		{
			set{ _yjylxssr2=value;}
			get{return _yjylxssr2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylbz2
		{
			set{ _yjylbz2=value;}
			get{return _yjylbz2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylnd3
		{
			set{ _yjylnd3=value;}
			get{return _yjylnd3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylggxh3
		{
			set{ _yjylggxh3=value;}
			get{return _yjylggxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylcl3
		{
			set{ _yjylcl3=value;}
			get{return _yjylcl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylxssr3
		{
			set{ _yjylxssr3=value;}
			get{return _yjylxssr3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylbz3
		{
			set{ _yjylbz3=value;}
			get{return _yjylbz3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylnd4
		{
			set{ _yjylnd4=value;}
			get{return _yjylnd4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylggxh4
		{
			set{ _yjylggxh4=value;}
			get{return _yjylggxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylcl4
		{
			set{ _yjylcl4=value;}
			get{return _yjylcl4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylxssr4
		{
			set{ _yjylxssr4=value;}
			get{return _yjylxssr4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylbz4
		{
			set{ _yjylbz4=value;}
			get{return _yjylbz4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylnd5
		{
			set{ _yjylnd5=value;}
			get{return _yjylnd5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylggxh5
		{
			set{ _yjylggxh5=value;}
			get{return _yjylggxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylcl5
		{
			set{ _yjylcl5=value;}
			get{return _yjylcl5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylxssr5
		{
			set{ _yjylxssr5=value;}
			get{return _yjylxssr5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yjylbz5
		{
			set{ _yjylbz5=value;}
			get{return _yjylbz5;}
		}
		#endregion Model

	}
}

