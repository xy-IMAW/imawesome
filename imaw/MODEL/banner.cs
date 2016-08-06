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
	/// banner:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class banner
	{
		public banner()
		{}
		#region Model
		private int _banner_id;
		private string _banner_title;
		private string _banner_abstract;
		private string _banner_link;
		private string _banner_img;
		private int _banner_state;
		private string _banner_posterid;
		private DateTime _banner_postdate;
		/// <summary>
		/// 
		/// </summary>
		public int banner_id
		{
			set{ _banner_id=value;}
			get{return _banner_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string banner_title
		{
			set{ _banner_title=value;}
			get{return _banner_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string banner_abstract
		{
			set{ _banner_abstract=value;}
			get{return _banner_abstract;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string banner_link
		{
			set{ _banner_link=value;}
			get{return _banner_link;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string banner_img
		{
			set{ _banner_img=value;}
			get{return _banner_img;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int banner_state
		{
			set{ _banner_state=value;}
			get{return _banner_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string banner_posterid
		{
			set{ _banner_posterid=value;}
			get{return _banner_posterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime banner_postdate
		{
			set{ _banner_postdate=value;}
			get{return _banner_postdate;}
		}
		#endregion Model

	}
}

