/**  版本信息模板在安装目录下，可自行修改。
* apply_member.cs
*
* 功 能： N/A
* 类 名： apply_member
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:11   N/A    初版
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
	/// apply_member:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class apply_member
	{
		public apply_member()
		{}
		#region Model
		private string _user_id;
		private string _applydate;
		private string _checker_id;
		private string _checkdate;
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
		public string applydate
		{
			set{ _applydate=value;}
			get{return _applydate;}
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
		public string checkdate
		{
			set{ _checkdate=value;}
			get{return _checkdate;}
		}
		#endregion Model

	}
}

