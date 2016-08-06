/**  版本信息模板在安装目录下，可自行修改。
* activities.cs
*
* 功 能： N/A
* 类 名： activities
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:09   N/A    初版
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
	/// activities:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class activities
	{
		public activities()
		{}
		#region Model
		private int _act_id;
		private string _act_class;
		private string _act_name;
		private DateTime _act_applytime;
		private DateTime _act_applysettime;
		private DateTime _act_startime;
		private DateTime _act_endtime;
		private string _poster_id;
		private string _doc_id;
		private string _act_abstract;
		/// <summary>
		/// 
		/// </summary>
		public int act_id
		{
			set{ _act_id=value;}
			get{return _act_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string act_class
		{
			set{ _act_class=value;}
			get{return _act_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string act_name
		{
			set{ _act_name=value;}
			get{return _act_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime act_applytime
		{
			set{ _act_applytime=value;}
			get{return _act_applytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime act_applysettime
		{
			set{ _act_applysettime=value;}
			get{return _act_applysettime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime act_startime
		{
			set{ _act_startime=value;}
			get{return _act_startime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime act_endtime
		{
			set{ _act_endtime=value;}
			get{return _act_endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string poster_id
		{
			set{ _poster_id=value;}
			get{return _poster_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string doc_id
		{
			set{ _doc_id=value;}
			get{return _doc_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string act_abstract
		{
			set{ _act_abstract=value;}
			get{return _act_abstract;}
		}
		#endregion Model

	}
}

