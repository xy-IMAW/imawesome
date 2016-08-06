/**  版本信息模板在安装目录下，可自行修改。
* news.cs
*
* 功 能： N/A
* 类 名： news
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:13   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// news:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class news
	{
		public news()
		{}
		#region Model
		private int _news_id;
		private DateTime _news_createtime;
		private string _news_posterid;
		private string _news_title;
		private string _news_class;
		private string _news_abstract;
		private string _news_content;
		private int _news_readnum;
		private int _news_state;
		/// <summary>
		/// 
		/// </summary>
		public int news_id
		{
			set{ _news_id=value;}
			get{return _news_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime news_createtime
		{
			set{ _news_createtime=value;}
			get{return _news_createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_posterid
		{
			set{ _news_posterid=value;}
			get{return _news_posterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_title
		{
			set{ _news_title=value;}
			get{return _news_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_class
		{
			set{ _news_class=value;}
			get{return _news_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_abstract
		{
			set{ _news_abstract=value;}
			get{return _news_abstract;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_content
		{
			set{ _news_content=value;}
			get{return _news_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int news_readnum
		{
			set{ _news_readnum=value;}
			get{return _news_readnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int news_state
		{
			set{ _news_state=value;}
			get{return _news_state;}
		}
		#endregion Model

	}
}

