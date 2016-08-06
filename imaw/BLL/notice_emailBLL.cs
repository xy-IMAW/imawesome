/* activities_recordBLL.cs
*
* 功 能： N/A
* 类 名： activities_recordBLL
*
* Ver    2016.8.6             负责人  liushangnan
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:10   N/A    初版
*
* Copyright (c) 2012 IMAW Corporation. All rights reserved.
*/

using System;
using System.Data;
using System.Collections.Generic;
using IMAW.Model;
using COMMON;
namespace IMAW.BLL
{
	/// <summary>
	/// notice_emailBLL
	/// </summary>
	public partial class notice_emailBLL
	{
		private readonly IMAW.DAL.notice_emailDAL dal=new IMAW.DAL.notice_emailDAL();
		public notice_emailBLL()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string email_sn)
		{
			return dal.Exists(email_sn);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IMAW.Model.notice_email model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IMAW.Model.notice_email model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string email_sn)
		{
			
			return dal.Delete(email_sn);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string email_snlist )
		{
			return dal.DeleteList(email_snlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IMAW.Model.notice_email GetModel(string email_sn)
		{
			
			return dal.GetModel(email_sn);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		//public IMAW.Model.notice_email GetModelByCache(string email_sn)
		//{
			
		//	string CacheKey = "notice_emailModel-" + email_sn;
		//	object objModel = IMAW.Common.DataCache.GetCache(CacheKey);
		//	if (objModel == null)
		//	{
		//		try
		//		{
		//			objModel = dal.GetModel(email_sn);
		//			if (objModel != null)
		//			{
		//				int ModelCache = IMAW.Common.ConfigHelper.GetConfigInt("ModelCache");
		//				IMAW.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
		//			}
		//		}
		//		catch{}
		//	}
		//	return (IMAW.Model.notice_email)objModel;
		//}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<IMAW.Model.notice_email> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<IMAW.Model.notice_email> DataTableToList(DataTable dt)
		{
			List<IMAW.Model.notice_email> modelList = new List<IMAW.Model.notice_email>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				IMAW.Model.notice_email model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

