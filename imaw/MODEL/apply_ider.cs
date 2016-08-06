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
	/// apply_ider:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class apply_ider
	{
		public apply_ider()
		{}
		#region Model
		private string _apply_sn;
		private string _user_id;
		private string _password;
		private string _firstchoice;
		private string _secondchoice;
		private bool _adjusted;
		private string _apply_phote;
		private string _apply_introduce;
		private string _apply_hobby;
		private string _apply_advantage;
		private string _apply_workplan;
		private DateTime _apply_time;
		private DateTime _apply_state;
		private string _apply_remark;
		/// <summary>
		/// 
		/// </summary>
		public string apply_sn
		{
			set{ _apply_sn=value;}
			get{return _apply_sn;}
		}
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
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string firstChoice
		{
			set{ _firstchoice=value;}
			get{return _firstchoice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string secondChoice
		{
			set{ _secondchoice=value;}
			get{return _secondchoice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool adjusted
		{
			set{ _adjusted=value;}
			get{return _adjusted;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string apply_phote
		{
			set{ _apply_phote=value;}
			get{return _apply_phote;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string apply_introduce
		{
			set{ _apply_introduce=value;}
			get{return _apply_introduce;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string apply_hobby
		{
			set{ _apply_hobby=value;}
			get{return _apply_hobby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string apply_advantage
		{
			set{ _apply_advantage=value;}
			get{return _apply_advantage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string apply_workplan
		{
			set{ _apply_workplan=value;}
			get{return _apply_workplan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime apply_time
		{
			set{ _apply_time=value;}
			get{return _apply_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime apply_state
		{
			set{ _apply_state=value;}
			get{return _apply_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string apply_remark
		{
			set{ _apply_remark=value;}
			get{return _apply_remark;}
		}
		#endregion Model

	}
}

