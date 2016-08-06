/**  版本信息模板在安装目录下，可自行修改。
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
	/// adminBLL
	/// </summary>
	public partial class adminBLL
	{
		private readonly IMAW.DAL.adminDAL dal=new IMAW.DAL.adminDAL();
		public adminBLL()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string admin_id)
		{
			return dal.Exists(admin_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IMAW.Model.admin model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IMAW.Model.admin model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string admin_id)
		{
			
			return dal.Delete(admin_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string admin_idlist )
		{
			return dal.DeleteList(admin_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IMAW.Model.admin GetModel(string admin_id)
		{
			
			return dal.GetModel(admin_id);
		}

		///// <summary>
		///// 得到一个对象实体，从缓存中
		///// </summary>
		//public IMAW.Model.admin GetModelByCache(string admin_id)
		//{
			
		//	string CacheKey = "adminModel-" + admin_id;
		//	object objModel = IMAW.Common.DataCache.GetCache(CacheKey);
		//	if (objModel == null)
		//	{
		//		try
		//		{
		//			objModel = dal.GetModel(admin_id);
		//			if (objModel != null)
		//			{
		//				int ModelCache = IMAW.Common.ConfigHelper.GetConfigInt("ModelCache");
		//				IMAW.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
		//			}
		//		}
		//		catch{}
		//	}
		//	return (IMAW.Model.admin)objModel;
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
		public List<IMAW.Model.admin> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<IMAW.Model.admin> DataTableToList(DataTable dt)
		{
			List<IMAW.Model.admin> modelList = new List<IMAW.Model.admin>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				IMAW.Model.admin model;
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

