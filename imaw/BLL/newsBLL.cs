﻿/* activities_recordBLL.cs
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
	/// newsBLL
	/// </summary>
	public partial class newsBLL
	{
		private readonly IMAW.DAL.newsDAL dal=new IMAW.DAL.newsDAL();
		public newsBLL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int news_id)
		{
			return dal.Exists(news_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(IMAW.Model.news model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IMAW.Model.news model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int news_id)
		{
			
			return dal.Delete(news_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string news_idlist )
		{
			return dal.DeleteList(news_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IMAW.Model.news GetModel(int news_id)
		{
			
			return dal.GetModel(news_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		//public IMAW.Model.news GetModelByCache(int news_id)
		//{
			
		//	string CacheKey = "newsModel-" + news_id;
		//	object objModel = IMAW.Common.DataCache.GetCache(CacheKey);
		//	if (objModel == null)
		//	{
		//		try
		//		{
		//			objModel = dal.GetModel(news_id);
		//			if (objModel != null)
		//			{
		//				int ModelCache = IMAW.Common.ConfigHelper.GetConfigInt("ModelCache");
		//				IMAW.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
		//			}
		//		}
		//		catch{}
		//	}
		//	return (IMAW.Model.news)objModel;
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
		public List<IMAW.Model.news> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<IMAW.Model.news> DataTableToList(DataTable dt)
		{
			List<IMAW.Model.news> modelList = new List<IMAW.Model.news>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				IMAW.Model.news model;
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

