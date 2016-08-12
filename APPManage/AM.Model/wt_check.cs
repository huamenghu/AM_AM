/**  版本信息模板在安装目录下，可自行修改。
* wt_check.cs
*
* 功 能： N/A
* 类 名： wt_check
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
	/// wt_check:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class wt_check
	{
		public wt_check()
		{}
		#region Model
		private string _guid;
		private string _userid;
		private DateTime? _createdate;
		private string _wtdwmc;
		private string _wtdwdz;
		private string _lxr;
		private string _lxdh;
		private string _gcmc;
		private string _gcdz;
		private string _sgdw;
		private string _sgdz;
		private string _jynr;
		private string _jysl;
		private string _sccj;
		private string _sbbh;
		private string _sbxh;
		private string _azgd;
		private string _qt;
		private string _qbgfs;
		private string _bgtd;
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
		public string WTDWMC
		{
			set{ _wtdwmc=value;}
			get{return _wtdwmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WTDWDZ
		{
			set{ _wtdwdz=value;}
			get{return _wtdwdz;}
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
		public string LXDH
		{
			set{ _lxdh=value;}
			get{return _lxdh;}
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
		public string GCDZ
		{
			set{ _gcdz=value;}
			get{return _gcdz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SGDW
		{
			set{ _sgdw=value;}
			get{return _sgdw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SGDZ
		{
			set{ _sgdz=value;}
			get{return _sgdz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JYNR
		{
			set{ _jynr=value;}
			get{return _jynr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JYSL
		{
			set{ _jysl=value;}
			get{return _jysl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SCCJ
		{
			set{ _sccj=value;}
			get{return _sccj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBBH
		{
			set{ _sbbh=value;}
			get{return _sbbh;}
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
		public string AZGD
		{
			set{ _azgd=value;}
			get{return _azgd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QT
		{
			set{ _qt=value;}
			get{return _qt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QBGFS
		{
			set{ _qbgfs=value;}
			get{return _qbgfs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BGTD
		{
			set{ _bgtd=value;}
			get{return _bgtd;}
		}
		#endregion Model

	}
}

