/**  版本信息模板在安装目录下，可自行修改。
* pxkh_dlcz.cs
*
* 功 能： N/A
* 类 名： pxkh_dlcz
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/10 10:46:45   N/A    初版
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
	/// pxkh_dlcz:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class basket_train
	{
        public basket_train()
		{
           
        }
		#region Model
        private string _guid;
		private string _userid;
		private DateTime? _createdate;
		private string _xm;
		private string _xb;
		private string _whcd;
		private string _lxdh;
		private string _zygl;
		private string _stzk;
		private string _sfzh;
		private string _gzdw;
		private string _yb;
		private string _yx;
		private string _brqz;
		private string _pxd;
		private string _gzjl;
		private string _szdwyj;
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
		public string xm
		{
			set{ _xm=value;}
			get{return _xm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string xb
		{
			set{ _xb=value;}
			get{return _xb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string whcd
		{
			set{ _whcd=value;}
			get{return _whcd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lxdh
		{
			set{ _lxdh=value;}
			get{return _lxdh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zygl
		{
			set{ _zygl=value;}
			get{return _zygl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stzk
		{
			set{ _stzk=value;}
			get{return _stzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sfzh
		{
			set{ _sfzh=value;}
			get{return _sfzh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzdw
		{
			set{ _gzdw=value;}
			get{return _gzdw;}
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
		public string yx
		{
			set{ _yx=value;}
			get{return _yx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string brqz
		{
			set{ _brqz=value;}
			get{return _brqz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pxd
		{
			set{ _pxd=value;}
			get{return _pxd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzjl
		{
			set{ _gzjl=value;}
			get{return _gzjl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string szdwyj
		{
			set{ _szdwyj=value;}
			get{return _szdwyj;}
		}
		#endregion Model

	}
}

