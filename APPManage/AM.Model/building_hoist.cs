/**  版本信息模板在安装目录下，可自行修改。
* building_hoist.cs
*
* 功 能： N/A
* 类 名： building_hoist
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:17   N/A    初版
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
	/// building_hoist:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class building_hoist
	{
		public building_hoist()
		{}
		#region Model
		private string _guid;
		private string _userid;
		private DateTime? _createdate;
		private string _gcmc;
		private string _sydw;
		private string _sgdd;
		private string _jldw;
		private string _azdw;
		private string _azfzr;
		private string _sbmc;
		private string _sbxh;
		private string _zzdw;
		private string _zzxkzh;
		private string _ccbh;
		private string _azgzrq;
		private string _babh;
		private string _edzzl;
		private string _dlzl;
		private string _edtssd;
		private string _fzaqqxs;
		private string _dzzl;
		private string _tysazgd;
		private string _zydgd;
		private string _fqds;
		private string _dyfqgd;
		private string _bzjgg;
		private string _jylx;
		private string _yqmc1;
		private string _xh1;
		private string _bh1;
		private string _zt1;
		private string _yqmc2;
		private string _xh2;
		private string _bh2;
		private string _zt2;
		private string _yqmc3;
		private string _xh3;
		private string _bh3;
		private string _zt3;
		private string _yqmc4;
		private string _xh4;
		private string _bh4;
		private string _zt4;
		private string _yqmc5;
		private string _xh5;
		private string _bh5;
		private string _zt5;
		private string _bzxmbhgs;
		private string _ybxmbhgs;
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
		public string GCMC
		{
			set{ _gcmc=value;}
			get{return _gcmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SYDW
		{
			set{ _sydw=value;}
			get{return _sydw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SGDD
		{
			set{ _sgdd=value;}
			get{return _sgdd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JLDW
		{
			set{ _jldw=value;}
			get{return _jldw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AZDW
		{
			set{ _azdw=value;}
			get{return _azdw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AZFZR
		{
			set{ _azfzr=value;}
			get{return _azfzr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBMC
		{
			set{ _sbmc=value;}
			get{return _sbmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBXH
		{
			set{ _sbxh=value;}
			get{return _sbxh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZZDW
		{
			set{ _zzdw=value;}
			get{return _zzdw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZZXKZH
		{
			set{ _zzxkzh=value;}
			get{return _zzxkzh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CCBH
		{
			set{ _ccbh=value;}
			get{return _ccbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AZGZRQ
		{
			set{ _azgzrq=value;}
			get{return _azgzrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BABH
		{
			set{ _babh=value;}
			get{return _babh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EDZZL
		{
			set{ _edzzl=value;}
			get{return _edzzl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DLZL
		{
			set{ _dlzl=value;}
			get{return _dlzl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EDTSSD
		{
			set{ _edtssd=value;}
			get{return _edtssd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FZAQQXS
		{
			set{ _fzaqqxs=value;}
			get{return _fzaqqxs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DZZL
		{
			set{ _dzzl=value;}
			get{return _dzzl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYSAZGD
		{
			set{ _tysazgd=value;}
			get{return _tysazgd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYDGD
		{
			set{ _zydgd=value;}
			get{return _zydgd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FQDS
		{
			set{ _fqds=value;}
			get{return _fqds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DYFQGD
		{
			set{ _dyfqgd=value;}
			get{return _dyfqgd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZJGG
		{
			set{ _bzjgg=value;}
			get{return _bzjgg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JYLX
		{
			set{ _jylx=value;}
			get{return _jylx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YQMC1
		{
			set{ _yqmc1=value;}
			get{return _yqmc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XH1
		{
			set{ _xh1=value;}
			get{return _xh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BH1
		{
			set{ _bh1=value;}
			get{return _bh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZT1
		{
			set{ _zt1=value;}
			get{return _zt1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YQMC2
		{
			set{ _yqmc2=value;}
			get{return _yqmc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XH2
		{
			set{ _xh2=value;}
			get{return _xh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BH2
		{
			set{ _bh2=value;}
			get{return _bh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZT2
		{
			set{ _zt2=value;}
			get{return _zt2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YQMC3
		{
			set{ _yqmc3=value;}
			get{return _yqmc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XH3
		{
			set{ _xh3=value;}
			get{return _xh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BH3
		{
			set{ _bh3=value;}
			get{return _bh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZT3
		{
			set{ _zt3=value;}
			get{return _zt3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YQMC4
		{
			set{ _yqmc4=value;}
			get{return _yqmc4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XH4
		{
			set{ _xh4=value;}
			get{return _xh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BH4
		{
			set{ _bh4=value;}
			get{return _bh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZT4
		{
			set{ _zt4=value;}
			get{return _zt4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YQMC5
		{
			set{ _yqmc5=value;}
			get{return _yqmc5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XH5
		{
			set{ _xh5=value;}
			get{return _xh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BH5
		{
			set{ _bh5=value;}
			get{return _bh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZT5
		{
			set{ _zt5=value;}
			get{return _zt5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZXMBHGS
		{
			set{ _bzxmbhgs=value;}
			get{return _bzxmbhgs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YBXMBHGS
		{
			set{ _ybxmbhgs=value;}
			get{return _ybxmbhgs;}
		}
		#endregion Model

	}
}

