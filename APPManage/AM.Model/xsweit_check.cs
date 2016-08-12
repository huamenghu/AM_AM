/**  版本信息模板在安装目录下，可自行修改。
* xsweit_check.cs
*
* 功 能： N/A
* 类 名： xsweit_check
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:22   N/A    初版
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
	/// xsweit_check:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class xsweit_check
	{
		public xsweit_check()
		{}
		#region Model
		private string _guid;
		private string _userid;
		private DateTime? _createdate;
		private string _cpmc;
		private string _ggxh;
		private string _wtdw;
		private string _lxr;
		private string _scdw;
		private string _lxdh;
		private string _cpbh;
		private string _wtrq;
		private string _dwdz;
		private string _wtjyyq;
		private string _jyyj;
		private string _jyfy;
		private string _yqwcrq;
		private string _phwcxm;
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
		public string CPMC
		{
			set{ _cpmc=value;}
			get{return _cpmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GGXH
		{
			set{ _ggxh=value;}
			get{return _ggxh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WTDW
		{
			set{ _wtdw=value;}
			get{return _wtdw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LXR
		{
			set{ _lxr=value;}
			get{return _lxr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SCDW
		{
			set{ _scdw=value;}
			get{return _scdw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LXDH
		{
			set{ _lxdh=value;}
			get{return _lxdh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPBH
		{
			set{ _cpbh=value;}
			get{return _cpbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WTRQ
		{
			set{ _wtrq=value;}
			get{return _wtrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DWDZ
		{
			set{ _dwdz=value;}
			get{return _dwdz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WTJYYQ
		{
			set{ _wtjyyq=value;}
			get{return _wtjyyq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JYYJ
		{
			set{ _jyyj=value;}
			get{return _jyyj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JYFY
		{
			set{ _jyfy=value;}
			get{return _jyfy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YQWCRQ
		{
			set{ _yqwcrq=value;}
			get{return _yqwcrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PHWCXM
		{
			set{ _phwcxm=value;}
			get{return _phwcxm;}
		}
		#endregion Model

	}
}

