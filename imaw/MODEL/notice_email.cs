﻿/* activities.cs
*
* 功 能： N/A
* 类 名： activities
*
* Ver    2016.8.6             负责人  liushangnan
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:09   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*/
using System;
namespace IMAW.Model
{
	/// <summary>
	/// notice_email:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class notice_email
	{
		public notice_email()
		{}
		#region Model
		private string _email_sn;
		private string _email_class;
		private bool _email_theme;
		private DateTime _email_content;
		private string _email_doc_id;
		private DateTime _email_postitme;
		private DateTime _email_settime;
		private string _sender_id;
		/// <summary>
		/// 
		/// </summary>
		public string email_sn
		{
			set{ _email_sn=value;}
			get{return _email_sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email_class
		{
			set{ _email_class=value;}
			get{return _email_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool email_theme
		{
			set{ _email_theme=value;}
			get{return _email_theme;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime email_content
		{
			set{ _email_content=value;}
			get{return _email_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email_doc_id
		{
			set{ _email_doc_id=value;}
			get{return _email_doc_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime email_postitme
		{
			set{ _email_postitme=value;}
			get{return _email_postitme;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime email_settime
		{
			set{ _email_settime=value;}
			get{return _email_settime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sender_id
		{
			set{ _sender_id=value;}
			get{return _sender_id;}
		}
		#endregion Model

	}
}

