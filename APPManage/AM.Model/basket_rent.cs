/**  版本信息模板在安装目录下，可自行修改。
* basket_rent.cs
*
* 功 能： N/A
* 类 名： basket_rent
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:14   N/A    初版
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
	/// basket_rent:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class basket_rent
	{
		public basket_rent()
		{}
		#region Model
		private string _guid;
		private string _userid;
		private DateTime? _createdate;
		private string _qyqymc;
		private string _qyqydz;
		private string _qyyb;
		private string _qyzzjgdm;
		private string _qylxr;
		private string _qygddh;
		private string _qyyddh;
		private string _qydzyx;
		private string _qycz;
		private string _qyyyzzzch;
		private string _qyzcrq;
		private string _qyyyzzdjjg;
		private string _qyjjlx;
		private string _qyzczj;
		private string _qygdzc;
		private string _qycsdlywrs;
		private string _qyqyzgzrs;
		private string _qyczydlsl;
		private string _qykscsdlywrq;
		private string _qyqyjj;
		private string _qyfrxm;
		private string _qyfrxb;
		private string _qyfrzgxl;
		private string _qyfrzw;
		private string _qyfrzc;
		private string _qyfrzy;
		private string _qyfrgddh;
		private string _qyfryddh;
		private string _qyfrpx;
		private string _qyfrpxsj;
		private string _qyfrpxhgzsbh;
		private string _qyjlxm;
		private string _qyjlxb;
		private string _qyjlzgxl;
		private string _qyjlzw;
		private string _qyjlzc;
		private string _qyjlzy;
		private string _qyjlgddh;
		private string _qyjlyddh;
		private string _qyjlpx;
		private string _qyjlpxsj;
		private string _qyjlpxhgzsbh;
		private string _qyjsxm;
		private string _qyjsxb;
		private string _qyjszgxl;
		private string _qyjszw;
		private string _qyjszc;
		private string _qyjszy;
		private string _qyjsgddh;
		private string _qyjsyddh;
		private string _qyjspx;
		private string _qyjspxsj;
		private string _qyjspxhgzsbh;
		private string _glryxh1;
		private string _glryxm1;
		private string _glryzw1;
		private string _glryzc1;
		private string _glryxl1;
		private string _glryzy1;
		private string _glrysfzhm1;
		private string _glryxh2;
		private string _glryxm2;
		private string _glryzw2;
		private string _glryzc2;
		private string _glryxl2;
		private string _glryzy2;
		private string _glrysfzhm2;
		private string _glryxh3;
		private string _glryxm3;
		private string _glryzw3;
		private string _glryzc3;
		private string _glryxl3;
		private string _glryzy3;
		private string _glrysfzhm3;
		private string _glryxh4;
		private string _glryxm4;
		private string _glryzw4;
		private string _glryzc4;
		private string _glryxl4;
		private string _glryzy4;
		private string _glrysfzhm4;
		private string _glryxh5;
		private string _glryxm5;
		private string _glryzw5;
		private string _glryzc5;
		private string _glryxl5;
		private string _glryzy5;
		private string _glrysfzhm5;
		private string _jsgrxh1;
		private string _jsgrxm1;
		private string _jsgrgz1;
		private string _jsgrxh2;
		private string _jsgrxm2;
		private string _jsgrgz2;
		private string _jsgrxh3;
		private string _jsgrxm3;
		private string _jsgrgz3;
		private string _jsgrxh4;
		private string _jsgrxm4;
		private string _jsgrgz4;
		private string _jsgrxh5;
		private string _jsgrxm5;
		private string _jsgrgz5;
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
		private string _wxjcsbxuh1;
		private string _wxjcsbmc1;
		private string _wxjcsbxh1;
		private string _wxjcsbsl1;
		private string _wxjcsbbz1;
		private string _wxjcsbxuh2;
		private string _wxjcsbmc2;
		private string _wxjcsbxh2;
		private string _wxjcsbsl2;
		private string _wxjcsbbz2;
		private string _wxjcsbxuh3;
		private string _wxjcsbmc3;
		private string _wxjcsbxh3;
		private string _wxjcsbsl3;
		private string _wxjcsbbz3;
		private string _wxjcsbxuh4;
		private string _wxjcsbmc4;
		private string _wxjcsbxh4;
		private string _wxjcsbsl4;
		private string _wxjcsbbz4;
		private string _wxjcsbxuh5;
		private string _wxjcsbmc5;
		private string _wxjcsbxh5;
		private string _wxjcsbsl5;
		private string _wxjcsbbz5;
		private string _gcyjxh1;
		private string _gcyjgcxmmc1;
		private string _gcyjzldlts1;
		private string _gcyjzjze1;
		private string _gcyjkjgsj1;
		private string _gcyjbz1;
		private string _gcyjxh2;
		private string _gcyjgcxmmc2;
		private string _gcyjzldlts2;
		private string _gcyjzjze2;
		private string _gcyjkjgsj2;
		private string _gcyjbz2;
		private string _gcyjxh3;
		private string _gcyjgcxmmc3;
		private string _gcyjzldlts3;
		private string _gcyjzjze3;
		private string _gcyjkjgsj3;
		private string _gcyjbz3;
		private string _gcyjxh4;
		private string _gcyjgcxmmc4;
		private string _gcyjzldlts4;
		private string _gcyjzjze4;
		private string _gcyjkjgsj4;
		private string _gcyjbz4;
		private string _gcyjxh5;
		private string _gcyjgcxmmc5;
		private string _gcyjzldlts5;
		private string _gcyjzjze5;
		private string _gcyjkjgsj5;
		private string _gcyjbz5;
		private string _czdlxuh1;
		private string _czdlxh1;
		private string _czdlmc1;
		private string _czdlccrq1;
		private string _czdldlzzcj1;
		private string _czdlsl1;
		private string _czdlxuh2;
		private string _czdlxh2;
		private string _czdlmc2;
		private string _czdlccrq2;
		private string _czdldlzzcj2;
		private string _czdlsl2;
		private string _czdlxuh3;
		private string _czdlxh3;
		private string _czdlmc3;
		private string _czdlccrq3;
		private string _czdldlzzcj3;
		private string _czdlsl3;
		private string _czdlxuh4;
		private string _czdlxh4;
		private string _czdlmc4;
		private string _czdlccrq4;
		private string _czdldlzzcj4;
		private string _czdlsl4;
		private string _czdlxuh5;
		private string _czdlxh5;
		private string _czdlmc5;
		private string _czdlccrq5;
		private string _czdldlzzcj5;
		private string _czdlsl5;
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
		public string QYQYMC
		{
			set{ _qyqymc=value;}
			get{return _qyqymc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYQYDZ
		{
			set{ _qyqydz=value;}
			get{return _qyqydz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYYB
		{
			set{ _qyyb=value;}
			get{return _qyyb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYZZJGDM
		{
			set{ _qyzzjgdm=value;}
			get{return _qyzzjgdm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYLXR
		{
			set{ _qylxr=value;}
			get{return _qylxr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYGDDH
		{
			set{ _qygddh=value;}
			get{return _qygddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYYDDH
		{
			set{ _qyyddh=value;}
			get{return _qyyddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYDZYX
		{
			set{ _qydzyx=value;}
			get{return _qydzyx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYCZ
		{
			set{ _qycz=value;}
			get{return _qycz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYYYZZZCH
		{
			set{ _qyyyzzzch=value;}
			get{return _qyyyzzzch;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYZCRQ
		{
			set{ _qyzcrq=value;}
			get{return _qyzcrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYYYZZDJJG
		{
			set{ _qyyyzzdjjg=value;}
			get{return _qyyyzzdjjg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJJLX
		{
			set{ _qyjjlx=value;}
			get{return _qyjjlx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYZCZJ
		{
			set{ _qyzczj=value;}
			get{return _qyzczj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYGDZC
		{
			set{ _qygdzc=value;}
			get{return _qygdzc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYCSDLYWRS
		{
			set{ _qycsdlywrs=value;}
			get{return _qycsdlywrs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYQYZGZRS
		{
			set{ _qyqyzgzrs=value;}
			get{return _qyqyzgzrs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYCZYDLSL
		{
			set{ _qyczydlsl=value;}
			get{return _qyczydlsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYKSCSDLYWRQ
		{
			set{ _qykscsdlywrq=value;}
			get{return _qykscsdlywrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYQYJJ
		{
			set{ _qyqyjj=value;}
			get{return _qyqyjj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRXM
		{
			set{ _qyfrxm=value;}
			get{return _qyfrxm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRXB
		{
			set{ _qyfrxb=value;}
			get{return _qyfrxb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRZGXL
		{
			set{ _qyfrzgxl=value;}
			get{return _qyfrzgxl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRZW
		{
			set{ _qyfrzw=value;}
			get{return _qyfrzw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRZC
		{
			set{ _qyfrzc=value;}
			get{return _qyfrzc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRZY
		{
			set{ _qyfrzy=value;}
			get{return _qyfrzy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRGDDH
		{
			set{ _qyfrgddh=value;}
			get{return _qyfrgddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRYDDH
		{
			set{ _qyfryddh=value;}
			get{return _qyfryddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRPX
		{
			set{ _qyfrpx=value;}
			get{return _qyfrpx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRPXSJ
		{
			set{ _qyfrpxsj=value;}
			get{return _qyfrpxsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYFRPXHGZSBH
		{
			set{ _qyfrpxhgzsbh=value;}
			get{return _qyfrpxhgzsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLXM
		{
			set{ _qyjlxm=value;}
			get{return _qyjlxm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLXB
		{
			set{ _qyjlxb=value;}
			get{return _qyjlxb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLZGXL
		{
			set{ _qyjlzgxl=value;}
			get{return _qyjlzgxl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLZW
		{
			set{ _qyjlzw=value;}
			get{return _qyjlzw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLZC
		{
			set{ _qyjlzc=value;}
			get{return _qyjlzc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLZY
		{
			set{ _qyjlzy=value;}
			get{return _qyjlzy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLGDDH
		{
			set{ _qyjlgddh=value;}
			get{return _qyjlgddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLYDDH
		{
			set{ _qyjlyddh=value;}
			get{return _qyjlyddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLPX
		{
			set{ _qyjlpx=value;}
			get{return _qyjlpx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLPXSJ
		{
			set{ _qyjlpxsj=value;}
			get{return _qyjlpxsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJLPXHGZSBH
		{
			set{ _qyjlpxhgzsbh=value;}
			get{return _qyjlpxhgzsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSXM
		{
			set{ _qyjsxm=value;}
			get{return _qyjsxm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSXB
		{
			set{ _qyjsxb=value;}
			get{return _qyjsxb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSZGXL
		{
			set{ _qyjszgxl=value;}
			get{return _qyjszgxl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSZW
		{
			set{ _qyjszw=value;}
			get{return _qyjszw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSZC
		{
			set{ _qyjszc=value;}
			get{return _qyjszc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSZY
		{
			set{ _qyjszy=value;}
			get{return _qyjszy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSGDDH
		{
			set{ _qyjsgddh=value;}
			get{return _qyjsgddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSYDDH
		{
			set{ _qyjsyddh=value;}
			get{return _qyjsyddh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSPX
		{
			set{ _qyjspx=value;}
			get{return _qyjspx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSPXSJ
		{
			set{ _qyjspxsj=value;}
			get{return _qyjspxsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QYJSPXHGZSBH
		{
			set{ _qyjspxhgzsbh=value;}
			get{return _qyjspxhgzsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXH1
		{
			set{ _glryxh1=value;}
			get{return _glryxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXM1
		{
			set{ _glryxm1=value;}
			get{return _glryxm1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZW1
		{
			set{ _glryzw1=value;}
			get{return _glryzw1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZC1
		{
			set{ _glryzc1=value;}
			get{return _glryzc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXL1
		{
			set{ _glryxl1=value;}
			get{return _glryxl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZY1
		{
			set{ _glryzy1=value;}
			get{return _glryzy1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYSFZHM1
		{
			set{ _glrysfzhm1=value;}
			get{return _glrysfzhm1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXH2
		{
			set{ _glryxh2=value;}
			get{return _glryxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXM2
		{
			set{ _glryxm2=value;}
			get{return _glryxm2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZW2
		{
			set{ _glryzw2=value;}
			get{return _glryzw2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZC2
		{
			set{ _glryzc2=value;}
			get{return _glryzc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXL2
		{
			set{ _glryxl2=value;}
			get{return _glryxl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZY2
		{
			set{ _glryzy2=value;}
			get{return _glryzy2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYSFZHM2
		{
			set{ _glrysfzhm2=value;}
			get{return _glrysfzhm2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXH3
		{
			set{ _glryxh3=value;}
			get{return _glryxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXM3
		{
			set{ _glryxm3=value;}
			get{return _glryxm3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZW3
		{
			set{ _glryzw3=value;}
			get{return _glryzw3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZC3
		{
			set{ _glryzc3=value;}
			get{return _glryzc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXL3
		{
			set{ _glryxl3=value;}
			get{return _glryxl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZY3
		{
			set{ _glryzy3=value;}
			get{return _glryzy3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYSFZHM3
		{
			set{ _glrysfzhm3=value;}
			get{return _glrysfzhm3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXH4
		{
			set{ _glryxh4=value;}
			get{return _glryxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXM4
		{
			set{ _glryxm4=value;}
			get{return _glryxm4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZW4
		{
			set{ _glryzw4=value;}
			get{return _glryzw4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZC4
		{
			set{ _glryzc4=value;}
			get{return _glryzc4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXL4
		{
			set{ _glryxl4=value;}
			get{return _glryxl4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZY4
		{
			set{ _glryzy4=value;}
			get{return _glryzy4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYSFZHM4
		{
			set{ _glrysfzhm4=value;}
			get{return _glrysfzhm4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXH5
		{
			set{ _glryxh5=value;}
			get{return _glryxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXM5
		{
			set{ _glryxm5=value;}
			get{return _glryxm5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZW5
		{
			set{ _glryzw5=value;}
			get{return _glryzw5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZC5
		{
			set{ _glryzc5=value;}
			get{return _glryzc5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYXL5
		{
			set{ _glryxl5=value;}
			get{return _glryxl5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYZY5
		{
			set{ _glryzy5=value;}
			get{return _glryzy5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLRYSFZHM5
		{
			set{ _glrysfzhm5=value;}
			get{return _glrysfzhm5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRXH1
		{
			set{ _jsgrxh1=value;}
			get{return _jsgrxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRXM1
		{
			set{ _jsgrxm1=value;}
			get{return _jsgrxm1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRGZ1
		{
			set{ _jsgrgz1=value;}
			get{return _jsgrgz1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRXH2
		{
			set{ _jsgrxh2=value;}
			get{return _jsgrxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRXM2
		{
			set{ _jsgrxm2=value;}
			get{return _jsgrxm2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRGZ2
		{
			set{ _jsgrgz2=value;}
			get{return _jsgrgz2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRXH3
		{
			set{ _jsgrxh3=value;}
			get{return _jsgrxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRXM3
		{
			set{ _jsgrxm3=value;}
			get{return _jsgrxm3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRGZ3
		{
			set{ _jsgrgz3=value;}
			get{return _jsgrgz3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRXH4
		{
			set{ _jsgrxh4=value;}
			get{return _jsgrxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRXM4
		{
			set{ _jsgrxm4=value;}
			get{return _jsgrxm4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRGZ4
		{
			set{ _jsgrgz4=value;}
			get{return _jsgrgz4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRXH5
		{
			set{ _jsgrxh5=value;}
			get{return _jsgrxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRXM5
		{
			set{ _jsgrxm5=value;}
			get{return _jsgrxm5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSGRGZ5
		{
			set{ _jsgrgz5=value;}
			get{return _jsgrgz5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSFZJG1
		{
			set{ _zgzsfzjg1=value;}
			get{return _zgzsfzjg1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSZSBH1
		{
			set{ _zgzszsbh1=value;}
			get{return _zgzszsbh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSYXQ1
		{
			set{ _zgzsyxq1=value;}
			get{return _zgzsyxq1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSFZJG2
		{
			set{ _zgzsfzjg2=value;}
			get{return _zgzsfzjg2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSZSBH2
		{
			set{ _zgzszsbh2=value;}
			get{return _zgzszsbh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSYXQ2
		{
			set{ _zgzsyxq2=value;}
			get{return _zgzsyxq2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSFZJG3
		{
			set{ _zgzsfzjg3=value;}
			get{return _zgzsfzjg3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSZSBH3
		{
			set{ _zgzszsbh3=value;}
			get{return _zgzszsbh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSYXQ3
		{
			set{ _zgzsyxq3=value;}
			get{return _zgzsyxq3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSFZJG4
		{
			set{ _zgzsfzjg4=value;}
			get{return _zgzsfzjg4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSZSBH4
		{
			set{ _zgzszsbh4=value;}
			get{return _zgzszsbh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSYXQ4
		{
			set{ _zgzsyxq4=value;}
			get{return _zgzsyxq4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSFZJG5
		{
			set{ _zgzsfzjg5=value;}
			get{return _zgzsfzjg5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSZSBH5
		{
			set{ _zgzszsbh5=value;}
			get{return _zgzszsbh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZGZSYXQ5
		{
			set{ _zgzsyxq5=value;}
			get{return _zgzsyxq5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBXUH1
		{
			set{ _wxjcsbxuh1=value;}
			get{return _wxjcsbxuh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBMC1
		{
			set{ _wxjcsbmc1=value;}
			get{return _wxjcsbmc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBXH1
		{
			set{ _wxjcsbxh1=value;}
			get{return _wxjcsbxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBSL1
		{
			set{ _wxjcsbsl1=value;}
			get{return _wxjcsbsl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBBZ1
		{
			set{ _wxjcsbbz1=value;}
			get{return _wxjcsbbz1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBXUH2
		{
			set{ _wxjcsbxuh2=value;}
			get{return _wxjcsbxuh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBMC2
		{
			set{ _wxjcsbmc2=value;}
			get{return _wxjcsbmc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBXH2
		{
			set{ _wxjcsbxh2=value;}
			get{return _wxjcsbxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBSL2
		{
			set{ _wxjcsbsl2=value;}
			get{return _wxjcsbsl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBBZ2
		{
			set{ _wxjcsbbz2=value;}
			get{return _wxjcsbbz2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBXUH3
		{
			set{ _wxjcsbxuh3=value;}
			get{return _wxjcsbxuh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBMC3
		{
			set{ _wxjcsbmc3=value;}
			get{return _wxjcsbmc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBXH3
		{
			set{ _wxjcsbxh3=value;}
			get{return _wxjcsbxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBSL3
		{
			set{ _wxjcsbsl3=value;}
			get{return _wxjcsbsl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBBZ3
		{
			set{ _wxjcsbbz3=value;}
			get{return _wxjcsbbz3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBXUH4
		{
			set{ _wxjcsbxuh4=value;}
			get{return _wxjcsbxuh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBMC4
		{
			set{ _wxjcsbmc4=value;}
			get{return _wxjcsbmc4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBXH4
		{
			set{ _wxjcsbxh4=value;}
			get{return _wxjcsbxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBSL4
		{
			set{ _wxjcsbsl4=value;}
			get{return _wxjcsbsl4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBBZ4
		{
			set{ _wxjcsbbz4=value;}
			get{return _wxjcsbbz4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBXUH5
		{
			set{ _wxjcsbxuh5=value;}
			get{return _wxjcsbxuh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBMC5
		{
			set{ _wxjcsbmc5=value;}
			get{return _wxjcsbmc5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBXH5
		{
			set{ _wxjcsbxh5=value;}
			get{return _wxjcsbxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBSL5
		{
			set{ _wxjcsbsl5=value;}
			get{return _wxjcsbsl5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXJCSBBZ5
		{
			set{ _wxjcsbbz5=value;}
			get{return _wxjcsbbz5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJXH1
		{
			set{ _gcyjxh1=value;}
			get{return _gcyjxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJGCXMMC1
		{
			set{ _gcyjgcxmmc1=value;}
			get{return _gcyjgcxmmc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJZLDLTS1
		{
			set{ _gcyjzldlts1=value;}
			get{return _gcyjzldlts1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJZJZE1
		{
			set{ _gcyjzjze1=value;}
			get{return _gcyjzjze1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJKJGSJ1
		{
			set{ _gcyjkjgsj1=value;}
			get{return _gcyjkjgsj1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJBZ1
		{
			set{ _gcyjbz1=value;}
			get{return _gcyjbz1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJXH2
		{
			set{ _gcyjxh2=value;}
			get{return _gcyjxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJGCXMMC2
		{
			set{ _gcyjgcxmmc2=value;}
			get{return _gcyjgcxmmc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJZLDLTS2
		{
			set{ _gcyjzldlts2=value;}
			get{return _gcyjzldlts2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJZJZE2
		{
			set{ _gcyjzjze2=value;}
			get{return _gcyjzjze2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJKJGSJ2
		{
			set{ _gcyjkjgsj2=value;}
			get{return _gcyjkjgsj2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJBZ2
		{
			set{ _gcyjbz2=value;}
			get{return _gcyjbz2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJXH3
		{
			set{ _gcyjxh3=value;}
			get{return _gcyjxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJGCXMMC3
		{
			set{ _gcyjgcxmmc3=value;}
			get{return _gcyjgcxmmc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJZLDLTS3
		{
			set{ _gcyjzldlts3=value;}
			get{return _gcyjzldlts3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJZJZE3
		{
			set{ _gcyjzjze3=value;}
			get{return _gcyjzjze3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJKJGSJ3
		{
			set{ _gcyjkjgsj3=value;}
			get{return _gcyjkjgsj3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJBZ3
		{
			set{ _gcyjbz3=value;}
			get{return _gcyjbz3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJXH4
		{
			set{ _gcyjxh4=value;}
			get{return _gcyjxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJGCXMMC4
		{
			set{ _gcyjgcxmmc4=value;}
			get{return _gcyjgcxmmc4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJZLDLTS4
		{
			set{ _gcyjzldlts4=value;}
			get{return _gcyjzldlts4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJZJZE4
		{
			set{ _gcyjzjze4=value;}
			get{return _gcyjzjze4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJKJGSJ4
		{
			set{ _gcyjkjgsj4=value;}
			get{return _gcyjkjgsj4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJBZ4
		{
			set{ _gcyjbz4=value;}
			get{return _gcyjbz4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJXH5
		{
			set{ _gcyjxh5=value;}
			get{return _gcyjxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJGCXMMC5
		{
			set{ _gcyjgcxmmc5=value;}
			get{return _gcyjgcxmmc5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJZLDLTS5
		{
			set{ _gcyjzldlts5=value;}
			get{return _gcyjzldlts5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJZJZE5
		{
			set{ _gcyjzjze5=value;}
			get{return _gcyjzjze5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJKJGSJ5
		{
			set{ _gcyjkjgsj5=value;}
			get{return _gcyjkjgsj5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCYJBZ5
		{
			set{ _gcyjbz5=value;}
			get{return _gcyjbz5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLXUH1
		{
			set{ _czdlxuh1=value;}
			get{return _czdlxuh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLXH1
		{
			set{ _czdlxh1=value;}
			get{return _czdlxh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLMC1
		{
			set{ _czdlmc1=value;}
			get{return _czdlmc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLCCRQ1
		{
			set{ _czdlccrq1=value;}
			get{return _czdlccrq1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLDLZZCJ1
		{
			set{ _czdldlzzcj1=value;}
			get{return _czdldlzzcj1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLSL1
		{
			set{ _czdlsl1=value;}
			get{return _czdlsl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLXUH2
		{
			set{ _czdlxuh2=value;}
			get{return _czdlxuh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLXH2
		{
			set{ _czdlxh2=value;}
			get{return _czdlxh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLMC2
		{
			set{ _czdlmc2=value;}
			get{return _czdlmc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLCCRQ2
		{
			set{ _czdlccrq2=value;}
			get{return _czdlccrq2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLDLZZCJ2
		{
			set{ _czdldlzzcj2=value;}
			get{return _czdldlzzcj2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLSL2
		{
			set{ _czdlsl2=value;}
			get{return _czdlsl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLXUH3
		{
			set{ _czdlxuh3=value;}
			get{return _czdlxuh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLXH3
		{
			set{ _czdlxh3=value;}
			get{return _czdlxh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLMC3
		{
			set{ _czdlmc3=value;}
			get{return _czdlmc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLCCRQ3
		{
			set{ _czdlccrq3=value;}
			get{return _czdlccrq3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLDLZZCJ3
		{
			set{ _czdldlzzcj3=value;}
			get{return _czdldlzzcj3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLSL3
		{
			set{ _czdlsl3=value;}
			get{return _czdlsl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLXUH4
		{
			set{ _czdlxuh4=value;}
			get{return _czdlxuh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLXH4
		{
			set{ _czdlxh4=value;}
			get{return _czdlxh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLMC4
		{
			set{ _czdlmc4=value;}
			get{return _czdlmc4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLCCRQ4
		{
			set{ _czdlccrq4=value;}
			get{return _czdlccrq4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLDLZZCJ4
		{
			set{ _czdldlzzcj4=value;}
			get{return _czdldlzzcj4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLSL4
		{
			set{ _czdlsl4=value;}
			get{return _czdlsl4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLXUH5
		{
			set{ _czdlxuh5=value;}
			get{return _czdlxuh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLXH5
		{
			set{ _czdlxh5=value;}
			get{return _czdlxh5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLMC5
		{
			set{ _czdlmc5=value;}
			get{return _czdlmc5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLCCRQ5
		{
			set{ _czdlccrq5=value;}
			get{return _czdlccrq5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLDLZZCJ5
		{
			set{ _czdldlzzcj5=value;}
			get{return _czdldlzzcj5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CZDLSL5
		{
			set{ _czdlsl5=value;}
			get{return _czdlsl5;}
		}
		#endregion Model

	}
}

