/**  版本信息模板在安装目录下，可自行修改。
* basket_check.cs
*
* 功 能： N/A
* 类 名： basket_check
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 17:55:15   N/A    初版
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
	/// basket_check:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class basket_check
	{
		public basket_check()
		{}
		#region Model
		private string _guid;
		private string _userid;
		private DateTime? _createdate;
		private string _cpmc;
		private string _ggxh;
		private string _ypbh;
		private string _ypsl;
		private string _scrq;
		private string _jylx;
		private string _wtdw;
		private string _scdw;
		private string _jydd;
		private string _jysj;
		private string _jyyj;
		private string _jyjl;
		private string _bz;
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
		public string cpmc
		{
			set{ _cpmc=value;}
			get{return _cpmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ggxh
		{
			set{ _ggxh=value;}
			get{return _ggxh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ypbh
		{
			set{ _ypbh=value;}
			get{return _ypbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ypsl
		{
			set{ _ypsl=value;}
			get{return _ypsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scrq
		{
			set{ _scrq=value;}
			get{return _scrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jylx
		{
			set{ _jylx=value;}
			get{return _jylx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wtdw
		{
			set{ _wtdw=value;}
			get{return _wtdw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scdw
		{
			set{ _scdw=value;}
			get{return _scdw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jydd
		{
			set{ _jydd=value;}
			get{return _jydd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jysj
		{
			set{ _jysj=value;}
			get{return _jysj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyyj
		{
			set{ _jyyj=value;}
			get{return _jyyj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jyjl
		{
			set{ _jyjl=value;}
			get{return _jyjl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bz
		{
			set{ _bz=value;}
			get{return _bz;}
		}
		#endregion Model

	}
}

