/**  版本信息模板在安装目录下，可自行修改。
* user_info.cs
*
* 功 能： N/A
* 类 名： user_info
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:15   N/A    初版
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
	/// user_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user_info
	{
		public user_info()
		{}
		#region Model
		private string _user_id;
		private string _user_realname;
		private string _user_stuid;
		private string _user_school;
		private string _user_major;
		private string _user_sex;
		private string _user_phone;
		private string _user_email;
		private string _user_qq;
		private DateTime _user_birthday;
		private string _user_home;
		private string _user_nation;
		private string _user_politices;
		/// <summary>
		/// 
		/// </summary>
		public string user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_realname
		{
			set{ _user_realname=value;}
			get{return _user_realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_stuid
		{
			set{ _user_stuid=value;}
			get{return _user_stuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_school
		{
			set{ _user_school=value;}
			get{return _user_school;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_major
		{
			set{ _user_major=value;}
			get{return _user_major;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_sex
		{
			set{ _user_sex=value;}
			get{return _user_sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_phone
		{
			set{ _user_phone=value;}
			get{return _user_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_email
		{
			set{ _user_email=value;}
			get{return _user_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_qq
		{
			set{ _user_qq=value;}
			get{return _user_qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime user_birthday
		{
			set{ _user_birthday=value;}
			get{return _user_birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_home
		{
			set{ _user_home=value;}
			get{return _user_home;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_nation
		{
			set{ _user_nation=value;}
			get{return _user_nation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_politices
		{
			set{ _user_politices=value;}
			get{return _user_politices;}
		}
		#endregion Model

	}
}

