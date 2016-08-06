/**  版本信息模板在安装目录下，可自行修改。
* bannerDAL.cs
*
* 功 能： N/A
* 类 名： bannerDAL
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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:bannerDAL
	/// </summary>
	public partial class bannerDAL
	{
		public bannerDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("banner_id", "banner"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int banner_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from banner");
			strSql.Append(" where banner_id=SQL2012banner_id");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012banner_id", SqlDbType.Int,4)
			};
			parameters[0].Value = banner_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.banner model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into banner(");
			strSql.Append("banner_title,banner_abstract,banner_link,banner_img,banner_state,banner_posterid,banner_postdate)");
			strSql.Append(" values (");
			strSql.Append("SQL2012banner_title,SQL2012banner_abstract,SQL2012banner_link,SQL2012banner_img,SQL2012banner_state,SQL2012banner_posterid,SQL2012banner_postdate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012banner_title", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012banner_abstract", SqlDbType.NVarChar,100),
					new SqlParameter("SQL2012banner_link", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012banner_img", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012banner_state", SqlDbType.Int,4),
					new SqlParameter("SQL2012banner_posterid", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012banner_postdate", SqlDbType.DateTime)};
			parameters[0].Value = model.banner_title;
			parameters[1].Value = model.banner_abstract;
			parameters[2].Value = model.banner_link;
			parameters[3].Value = model.banner_img;
			parameters[4].Value = model.banner_state;
			parameters[5].Value = model.banner_posterid;
			parameters[6].Value = model.banner_postdate;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.banner model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update banner set ");
			strSql.Append("banner_title=SQL2012banner_title,");
			strSql.Append("banner_abstract=SQL2012banner_abstract,");
			strSql.Append("banner_link=SQL2012banner_link,");
			strSql.Append("banner_img=SQL2012banner_img,");
			strSql.Append("banner_state=SQL2012banner_state,");
			strSql.Append("banner_posterid=SQL2012banner_posterid,");
			strSql.Append("banner_postdate=SQL2012banner_postdate");
			strSql.Append(" where banner_id=SQL2012banner_id");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012banner_title", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012banner_abstract", SqlDbType.NVarChar,100),
					new SqlParameter("SQL2012banner_link", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012banner_img", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012banner_state", SqlDbType.Int,4),
					new SqlParameter("SQL2012banner_posterid", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012banner_postdate", SqlDbType.DateTime),
					new SqlParameter("SQL2012banner_id", SqlDbType.Int,4)};
			parameters[0].Value = model.banner_title;
			parameters[1].Value = model.banner_abstract;
			parameters[2].Value = model.banner_link;
			parameters[3].Value = model.banner_img;
			parameters[4].Value = model.banner_state;
			parameters[5].Value = model.banner_posterid;
			parameters[6].Value = model.banner_postdate;
			parameters[7].Value = model.banner_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int banner_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from banner ");
			strSql.Append(" where banner_id=SQL2012banner_id");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012banner_id", SqlDbType.Int,4)
			};
			parameters[0].Value = banner_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string banner_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from banner ");
			strSql.Append(" where banner_id in ("+banner_idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.banner GetModel(int banner_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 banner_id,banner_title,banner_abstract,banner_link,banner_img,banner_state,banner_posterid,banner_postdate from banner ");
			strSql.Append(" where banner_id=SQL2012banner_id");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012banner_id", SqlDbType.Int,4)
			};
			parameters[0].Value = banner_id;

			Maticsoft.Model.banner model=new Maticsoft.Model.banner();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.banner DataRowToModel(DataRow row)
		{
			Maticsoft.Model.banner model=new Maticsoft.Model.banner();
			if (row != null)
			{
				if(row["banner_id"]!=null && row["banner_id"].ToString()!="")
				{
					model.banner_id=int.Parse(row["banner_id"].ToString());
				}
				if(row["banner_title"]!=null)
				{
					model.banner_title=row["banner_title"].ToString();
				}
				if(row["banner_abstract"]!=null)
				{
					model.banner_abstract=row["banner_abstract"].ToString();
				}
				if(row["banner_link"]!=null)
				{
					model.banner_link=row["banner_link"].ToString();
				}
				if(row["banner_img"]!=null)
				{
					model.banner_img=row["banner_img"].ToString();
				}
				if(row["banner_state"]!=null && row["banner_state"].ToString()!="")
				{
					model.banner_state=int.Parse(row["banner_state"].ToString());
				}
				if(row["banner_posterid"]!=null)
				{
					model.banner_posterid=row["banner_posterid"].ToString();
				}
				if(row["banner_postdate"]!=null && row["banner_postdate"].ToString()!="")
				{
					model.banner_postdate=DateTime.Parse(row["banner_postdate"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select banner_id,banner_title,banner_abstract,banner_link,banner_img,banner_state,banner_posterid,banner_postdate ");
			strSql.Append(" FROM banner ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" banner_id,banner_title,banner_abstract,banner_link,banner_img,banner_state,banner_posterid,banner_postdate ");
			strSql.Append(" FROM banner ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM banner ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.banner_id desc");
			}
			strSql.Append(")AS Row, T.*  from banner T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "banner";
			parameters[1].Value = "banner_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

