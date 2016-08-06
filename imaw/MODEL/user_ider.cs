/* activities.cs
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
	/// user_ider:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user_ider
	{
		public user_ider()
		{}
		#region Model
		private string _ider_id;
		private int _dept_id;
		private int _role_id;
		private DateTime _role_starttime;
		private DateTime _role_endtime;
		private int _ider_balance;
		/// <summary>
		/// 
		/// </summary>
		public string ider_id
		{
			set{ _ider_id=value;}
			get{return _ider_id;}
		}
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
		public int role_id
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime role_starttime
		{
			set{ _role_starttime=value;}
			get{return _role_starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime role_endtime
		{
			set{ _role_endtime=value;}
			get{return _role_endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ider_balance
		{
			set{ _ider_balance=value;}
			get{return _ider_balance;}
		}
		#endregion Model

	}
}

