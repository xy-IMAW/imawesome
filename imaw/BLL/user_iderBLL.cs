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
	/// user_iderBLL
	/// </summary>
	public partial class user_iderBLL
	{
		private readonly IMAW.DAL.user_iderDAL dal=new IMAW.DAL.user_iderDAL();
		public user_iderBLL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IMAW.Model.user_ider model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IMAW.Model.user_ider model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IMAW.Model.user_ider GetModel(string ider_id)
		{
			return dal.GetModel(ider_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		//public IMAW.Model.user_ider GetModelByCache()
		//{
		//	//该表无主键信息，请自定义主键/条件字段
		//	string CacheKey = "user_iderModel-" ;
		//	object objModel = IMAW.Common.DataCache.GetCache(CacheKey);
		//	if (objModel == null)
		//	{
		//		try
		//		{
		//			objModel = dal.GetModel();
		//			if (objModel != null)
		//			{
		//				int ModelCache = IMAW.Common.ConfigHelper.GetConfigInt("ModelCache");
		//				IMAW.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
		//			}
		//		}
		//		catch{}
		//	}
		//	return (IMAW.Model.user_ider)objModel;
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
		public List<IMAW.Model.user_ider> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<IMAW.Model.user_ider> DataTableToList(DataTable dt)
		{
			List<IMAW.Model.user_ider> modelList = new List<IMAW.Model.user_ider>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				IMAW.Model.user_ider model;
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

