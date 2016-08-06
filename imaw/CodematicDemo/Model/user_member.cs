/**  版本信息模板在安装目录下，可自行修改。
* user_member.cs
*
* 功 能： N/A
* 类 名： user_member
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:16   N/A    初版
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
	/// user_member:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user_member
	{
		public user_member()
		{}
		#region Model
		private string _user_id;
		private string _member_id;
		private string _member_stuid;
		private int? _member_balance;
		private int? _member_level;
		private string _member_activities_sn;
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
		public string member_id
		{
			set{ _member_id=value;}
			get{return _member_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_stuid
		{
			set{ _member_stuid=value;}
			get{return _member_stuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? member_balance
		{
			set{ _member_balance=value;}
			get{return _member_balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? member_level
		{
			set{ _member_level=value;}
			get{return _member_level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_activities_sn
		{
			set{ _member_activities_sn=value;}
			get{return _member_activities_sn;}
		}
		#endregion Model

	}
}

