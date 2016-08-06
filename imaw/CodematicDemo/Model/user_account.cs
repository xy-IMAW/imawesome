/**  版本信息模板在安装目录下，可自行修改。
* user_account.cs
*
* 功 能： N/A
* 类 名： user_account
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:14   N/A    初版
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
	/// user_account:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user_account
	{
		public user_account()
		{}
		#region Model
		private string _user_id;
		private string _user_pwd;
		private string _user_nickname;
		private DateTime _user_registerdate;
		private DateTime _user_lastlogindate;
		private int _user_loginnum;
		private string _user_email;
		private string _user_photo;
		private string _user_pwd_que;
		private string _user_pwd_ans;
		private int _user_class;
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
		public string user_pwd
		{
			set{ _user_pwd=value;}
			get{return _user_pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_nickname
		{
			set{ _user_nickname=value;}
			get{return _user_nickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime user_registerdate
		{
			set{ _user_registerdate=value;}
			get{return _user_registerdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime user_lastlogindate
		{
			set{ _user_lastlogindate=value;}
			get{return _user_lastlogindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int user_loginnum
		{
			set{ _user_loginnum=value;}
			get{return _user_loginnum;}
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
		public string user_photo
		{
			set{ _user_photo=value;}
			get{return _user_photo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_pwd_que
		{
			set{ _user_pwd_que=value;}
			get{return _user_pwd_que;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_pwd_ans
		{
			set{ _user_pwd_ans=value;}
			get{return _user_pwd_ans;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int user_class
		{
			set{ _user_class=value;}
			get{return _user_class;}
		}
		#endregion Model

	}
}

