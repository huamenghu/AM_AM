/**  版本信息模板在安装目录下，可自行修改。
* tower_crane.cs
*
* 功 能： N/A
* 类 名： tower_crane
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:20   N/A    初版
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
	/// tower_crane:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tower_crane
	{
		public tower_crane()
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
		private string _azgzrq;
		private string _ccbh;
		private string _zzxkzbh;
		private string _ccrq;
		private string _babh;
		private string _zdedqzl;
		private string _edlj;
		private string _xczdbfsd;
		private string _bzjggsl;
		private string _jysazgd;
		private string _zdfd;
		private string _yxdlgd;
		private string _azfzds;
		private string _dydfqgd;
		private string _jylb;
		private string _zysbmc1;
		private string _zysbxh1;
		private string _zysbbh1;
		private string _zysbzt1;
		private string _zysbmc2;
		private string _zysbxh2;
		private string _zysbbh2;
		private string _zysbzt2;
		private string _zysbmc3;
		private string _zysbxh3;
		private string _zysbbh3;
		private string _zysbzt3;
		private string _zysbmc4;
		private string _zysbxh4;
		private string _zysbbh4;
		private string _zysbzt4;
		private string _zysbmc5;
		private string _zysbxh5;
		private string _zysbbh5;
		private string _zysbzt5;
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
		public string AZGZRQ
		{
			set{ _azgzrq=value;}
			get{return _azgzrq;}
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
		public string ZZXKZBH
		{
			set{ _zzxkzbh=value;}
			get{return _zzxkzbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CCRQ
		{
			set{ _ccrq=value;}
			get{return _ccrq;}
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
		public string ZDEDQZL
		{
			set{ _zdedqzl=value;}
			get{return _zdedqzl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EDLJ
		{
			set{ _edlj=value;}
			get{return _edlj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XCZDBFSD
		{
			set{ _xczdbfsd=value;}
			get{return _xczdbfsd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZJGGSL
		{
			set{ _bzjggsl=value;}
			get{return _bzjggsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JYSAZGD
		{
			set{ _jysazgd=value;}
			get{return _jysazgd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZDFD
		{
			set{ _zdfd=value;}
			get{return _zdfd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YXDLGD
		{
			set{ _yxdlgd=value;}
			get{return _yxdlgd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AZFZDS
		{
			set{ _azfzds=value;}
			get{return _azfzds;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DYDFQGD
		{
			set{ _dydfqgd=value;}
			get{return _dydfqgd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JYLB
		{
			set{ _jylb=value;}
			get{return _jylb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBMC1
		{
			set{ _zysbmc1=value;}
			get{return _zysbmc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBXH1
		{
			set{ _zysbxh1=value;}
			get{return _zysbxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBBH1
		{
			set{ _zysbbh1=value;}
			get{return _zysbbh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBZT1
		{
			set{ _zysbzt1=value;}
			get{return _zysbzt1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBMC2
		{
			set{ _zysbmc2=value;}
			get{return _zysbmc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBXH2
		{
			set{ _zysbxh2=value;}
			get{return _zysbxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBBH2
		{
			set{ _zysbbh2=value;}
			get{return _zysbbh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBZT2
		{
			set{ _zysbzt2=value;}
			get{return _zysbzt2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBMC3
		{
			set{ _zysbmc3=value;}
			get{return _zysbmc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBXH3
		{
			set{ _zysbxh3=value;}
			get{return _zysbxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBBH3
		{
			set{ _zysbbh3=value;}
			get{return _zysbbh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBZT3
		{
			set{ _zysbzt3=value;}
			get{return _zysbzt3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBMC4
		{
			set{ _zysbmc4=value;}
			get{return _zysbmc4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBXH4
		{
			set{ _zysbxh4=value;}
			get{return _zysbxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBBH4
		{
			set{ _zysbbh4=value;}
			get{return _zysbbh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBZT4
		{
			set{ _zysbzt4=value;}
			get{return _zysbzt4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBMC5
		{
			set{ _zysbmc5=value;}
			get{return _zysbmc5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBXH5
		{
			set{ _zysbxh5=value;}
			get{return _zysbxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBBH5
		{
			set{ _zysbbh5=value;}
			get{return _zysbbh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYSBZT5
		{
			set{ _zysbzt5=value;}
			get{return _zysbzt5;}
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

