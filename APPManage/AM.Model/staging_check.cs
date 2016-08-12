/**  版本信息模板在安装目录下，可自行修改。
* staging_check.cs
*
* 功 能： N/A
* 类 名： staging_check
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
	/// staging_check:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class staging_check
	{
		public staging_check()
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
		private string _ccrq;
		private string _zzxkz;
		private string _jygd;
		private string _gxjwybh;
		private string _gxjwyzk;
		private string _njbsbh;
		private string _njbszk;
		private string _szzobbh;
		private string _szzobzk;
		private string _wsdjbh;
		private string _wsdjzk;
		private string _fsybh;
		private string _fsyzk;
		private string _ybkcbh;
		private string _ybkczk;
		private string _gjc30bh;
		private string _gjc30zk;
		private string _gjc5bh;
		private string _gjc5zk;
		private string _gzc1bh;
		private string _gzc1zk;
		private string _gzc2bh;
		private string _gzc2zk;
		private string _scbh;
		private string _sczk;
		private string _jyjg;
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
		public string SGDD
		{
			set{ _sgdd=value;}
			get{return _sgdd;}
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
		public string JLDW
		{
			set{ _jldw=value;}
			get{return _jldw;}
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
		public string AZDW
		{
			set{ _azdw=value;}
			get{return _azdw;}
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
		public string SBBH
		{
			set{ _sbbh=value;}
			get{return _sbbh;}
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
		public string CCRQ
		{
			set{ _ccrq=value;}
			get{return _ccrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZZXKZ
		{
			set{ _zzxkz=value;}
			get{return _zzxkz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JYGD
		{
			set{ _jygd=value;}
			get{return _jygd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GXJWYBH
		{
			set{ _gxjwybh=value;}
			get{return _gxjwybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GXJWYZK
		{
			set{ _gxjwyzk=value;}
			get{return _gxjwyzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NJBSBH
		{
			set{ _njbsbh=value;}
			get{return _njbsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NJBSZK
		{
			set{ _njbszk=value;}
			get{return _njbszk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SZZOBBH
		{
			set{ _szzobbh=value;}
			get{return _szzobbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SZZOBZK
		{
			set{ _szzobzk=value;}
			get{return _szzobzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WSDJBH
		{
			set{ _wsdjbh=value;}
			get{return _wsdjbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WSDJZK
		{
			set{ _wsdjzk=value;}
			get{return _wsdjzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FSYBH
		{
			set{ _fsybh=value;}
			get{return _fsybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FSYZK
		{
			set{ _fsyzk=value;}
			get{return _fsyzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YBKCBH
		{
			set{ _ybkcbh=value;}
			get{return _ybkcbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YBKCZK
		{
			set{ _ybkczk=value;}
			get{return _ybkczk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GJC30BH
		{
			set{ _gjc30bh=value;}
			get{return _gjc30bh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GJC30ZK
		{
			set{ _gjc30zk=value;}
			get{return _gjc30zk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GJC5BH
		{
			set{ _gjc5bh=value;}
			get{return _gjc5bh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GJC5ZK
		{
			set{ _gjc5zk=value;}
			get{return _gjc5zk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GZC1BH
		{
			set{ _gzc1bh=value;}
			get{return _gzc1bh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GZC1ZK
		{
			set{ _gzc1zk=value;}
			get{return _gzc1zk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GZC2BH
		{
			set{ _gzc2bh=value;}
			get{return _gzc2bh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GZC2ZK
		{
			set{ _gzc2zk=value;}
			get{return _gzc2zk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SCBH
		{
			set{ _scbh=value;}
			get{return _scbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SCZK
		{
			set{ _sczk=value;}
			get{return _sczk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JYJG
		{
			set{ _jyjg=value;}
			get{return _jyjg;}
		}
		#endregion Model

	}
}

