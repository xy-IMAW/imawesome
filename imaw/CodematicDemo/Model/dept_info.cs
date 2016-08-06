/**  版本信息模板在安装目录下，可自行修改。
* dept_info.cs
*
* 功 能： N/A
* 类 名： dept_info
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:12   N/A    初版
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
	/// dept_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class dept_info
	{
		public dept_info()
		{}
		#region Model
		private int _dept_id;
		private string _dept_name;
		private string _dept_introduce;
		private string _dept_minister_id;
		private int _dept_num;
		/// <summary>
		/// 
		/// </summary>
		public int dept_id
		{
			set{ _dept_id=value;}
			get{return _dept_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dept_name
		{
			set{ _dept_name=value;}
			get{return _dept_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dept_introduce
		{
			set{ _dept_introduce=value;}
			get{return _dept_introduce;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dept_minister_id
		{
			set{ _dept_minister_id=value;}
			get{return _dept_minister_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int dept_num
		{
			set{ _dept_num=value;}
			get{return _dept_num;}
		}
		#endregion Model

	}
}

