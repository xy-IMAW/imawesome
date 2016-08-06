/**  版本信息模板在安装目录下，可自行修改。
* activities_record.cs
*
* 功 能： N/A
* 类 名： activities_record
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:10   N/A    初版
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
	/// activities_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class activities_record
	{
		public activities_record()
		{}
		#region Model
		private string _act_sn;
		private DateTime _act_appleytime;
		private string _act_id;
		private string _member_id;
		private string _state;
		private string _checker_id;
		private string _checker_date;
		private string _member_evaluate;
		private string _reply_id;
		private DateTime? _reply_date;
		/// <summary>
		/// 
		/// </summary>
		public string act_sn
		{
			set{ _act_sn=value;}
			get{return _act_sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime act_appleytime
		{
			set{ _act_appleytime=value;}
			get{return _act_appleytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string act_id
		{
			set{ _act_id=value;}
			get{return _act_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_id
		{
			set{ _member_id=value;}
			get{return _member_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string checker_id
		{
			set{ _checker_id=value;}
			get{return _checker_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string checker_date
		{
			set{ _checker_date=value;}
			get{return _checker_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_evaluate
		{
			set{ _member_evaluate=value;}
			get{return _member_evaluate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reply_id
		{
			set{ _reply_id=value;}
			get{return _reply_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? reply_date
		{
			set{ _reply_date=value;}
			get{return _reply_date;}
		}
		#endregion Model

	}
}

