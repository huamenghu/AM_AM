/**  版本信息模板在安装目录下，可自行修改。
* safe_lock.cs
*
* 功 能： N/A
* 类 名： safe_lock
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:19   N/A    初版
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
	/// safe_lock:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class safe_lock
	{
		public safe_lock()
		{}
		#region Model
		private string _guid;
		private string _userid;
		private DateTime? _createdate;
		private string _wtdw;
		private string _ypmc;
		private string _zzcs;
		private string _xhgg;
		private string _ccbh;
		private string _jyrq;
		private string _jyyj;
		private string _jyjl;
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
		public string WTDW
		{
			set{ _wtdw=value;}
			get{return _wtdw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YPMC
		{
			set{ _ypmc=value;}
			get{return _ypmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZZCS
		{
			set{ _zzcs=value;}
			get{return _zzcs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XHGG
		{
			set{ _xhgg=value;}
			get{return _xhgg;}
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
		public string JYRQ
		{
			set{ _jyrq=value;}
			get{return _jyrq;}
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
		public string JYJL
		{
			set{ _jyjl=value;}
			get{return _jyjl;}
		}
		#endregion Model

	}
}

