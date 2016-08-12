/**  版本信息模板在安装目录下，可自行修改。
* basket_install.cs
*
* 功 能： N/A
* 类 名： basket_install
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
	/// basket_install:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class basket_install
	{
		public basket_install()
		{}
		#region Model
		private string _guid;
		private string _userid;
		private DateTime? _createdate;
		private string _gcmc;
		private string _sgdd;
		private string _sydw;
		private string _jldw;
		private string _sbmc;
		private string _azdw;
		private string _sbxh;
		private string _sbbh;
		private string _sccj;
		private string _aqsbh;
		private string _tzsbsczzxkz;
		private string _cqbh;
		private string _ccrq;
		private string _jygd;
		private string _szzobbh;
		private string _szzobyqzk;
		private string _wsdjbh;
		private string _wsdjyqzk;
		private string _szwybbh;
		private string _szwybyqzk;
		private string _scbh;
		private string _scyqzk;
		private string _gzcbh;
		private string _gzcyqzk;
		private string _szjdcbh;
		private string _szjdcyqzk;
		private string _fsybh;
		private string _fsyyqzk;
		private string _ybkcbh;
		private string _ybkcyqzk;
		private string _gjc30mbh;
		private string _gjc30mzxkz;
		private string _gjc5mbh;
		private string _gjc5mzxkz;
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
		public string gcmc
		{
			set{ _gcmc=value;}
			get{return _gcmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sgdd
		{
			set{ _sgdd=value;}
			get{return _sgdd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sydw
		{
			set{ _sydw=value;}
			get{return _sydw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jldw
		{
			set{ _jldw=value;}
			get{return _jldw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sbmc
		{
			set{ _sbmc=value;}
			get{return _sbmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string azdw
		{
			set{ _azdw=value;}
			get{return _azdw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sbxh
		{
			set{ _sbxh=value;}
			get{return _sbxh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sbbh
		{
			set{ _sbbh=value;}
			get{return _sbbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sccj
		{
			set{ _sccj=value;}
			get{return _sccj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string aqsbh
		{
			set{ _aqsbh=value;}
			get{return _aqsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzsbsczzxkz
		{
			set{ _tzsbsczzxkz=value;}
			get{return _tzsbsczzxkz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cqbh
		{
			set{ _cqbh=value;}
			get{return _cqbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ccrq
		{
			set{ _ccrq=value;}
			get{return _ccrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jygd
		{
			set{ _jygd=value;}
			get{return _jygd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string szzobbh
		{
			set{ _szzobbh=value;}
			get{return _szzobbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string szzobyqzk
		{
			set{ _szzobyqzk=value;}
			get{return _szzobyqzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wsdjbh
		{
			set{ _wsdjbh=value;}
			get{return _wsdjbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wsdjyqzk
		{
			set{ _wsdjyqzk=value;}
			get{return _wsdjyqzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string szwybbh
		{
			set{ _szwybbh=value;}
			get{return _szwybbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string szwybyqzk
		{
			set{ _szwybyqzk=value;}
			get{return _szwybyqzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scbh
		{
			set{ _scbh=value;}
			get{return _scbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scyqzk
		{
			set{ _scyqzk=value;}
			get{return _scyqzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzcbh
		{
			set{ _gzcbh=value;}
			get{return _gzcbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gzcyqzk
		{
			set{ _gzcyqzk=value;}
			get{return _gzcyqzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string szjdcbh
		{
			set{ _szjdcbh=value;}
			get{return _szjdcbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string szjdcyqzk
		{
			set{ _szjdcyqzk=value;}
			get{return _szjdcyqzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fsybh
		{
			set{ _fsybh=value;}
			get{return _fsybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fsyyqzk
		{
			set{ _fsyyqzk=value;}
			get{return _fsyyqzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ybkcbh
		{
			set{ _ybkcbh=value;}
			get{return _ybkcbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ybkcyqzk
		{
			set{ _ybkcyqzk=value;}
			get{return _ybkcyqzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gjc30mbh
		{
			set{ _gjc30mbh=value;}
			get{return _gjc30mbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gjc30mzxkz
		{
			set{ _gjc30mzxkz=value;}
			get{return _gjc30mzxkz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gjc5mbh
		{
			set{ _gjc5mbh=value;}
			get{return _gjc5mbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gjc5mzxkz
		{
			set{ _gjc5mzxkz=value;}
			get{return _gjc5mzxkz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bzxmbhgs
		{
			set{ _bzxmbhgs=value;}
			get{return _bzxmbhgs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ybxmbhgs
		{
			set{ _ybxmbhgs=value;}
			get{return _ybxmbhgs;}
		}
		#endregion Model

	}
}

