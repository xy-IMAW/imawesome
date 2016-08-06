/**  版本信息模板在安装目录下，可自行修改。
* admin.cs
*
* 功 能： N/A
* 类 名： admin
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
	/// admin:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class admin
	{
		public admin()
		{}
		#region Model
		private string _admin_id;
		private string _admin_pwd;
		private int _admin_class;
		private string _admin_lastlogintime;
		private string _admin_loginnum;
		/// <summary>
		/// 
		/// </summary>
		public string admin_id
		{
			set{ _admin_id=value;}
			get{return _admin_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string admin_pwd
		{
			set{ _admin_pwd=value;}
			get{return _admin_pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int admin_class
		{
			set{ _admin_class=value;}
			get{return _admin_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string admin_lastlogintime
		{
			set{ _admin_lastlogintime=value;}
			get{return _admin_lastlogintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string admin_loginnum
		{
			set{ _admin_loginnum=value;}
			get{return _admin_loginnum;}
		}
		#endregion Model

	}
}

