/**  版本信息模板在安装目录下，可自行修改。
* activities_recordDAL.cs
*
* 功 能： N/A
* 类 名： activities_recordDAL
*
* Ver    2016.8.6             负责人  liushangnan
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:10   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using COMMON;
using IMAW.Model;

namespace IMAW.DAL
{
	/// <summary>
	/// 数据访问类:activitiesDAL
	/// </summary>
	public partial class activitiesDAL
	{
		public activitiesDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("act_id", "activities"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int act_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from activities");
			strSql.Append(" where act_id=@act_id");
			SqlParameter[] parameters = {
					new SqlParameter("@act_id", SqlDbType.Int,4)
			};
			parameters[0].Value = act_id;
			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IMAW.Model.activities model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into activities(");
			strSql.Append("act_class,act_name,act_applytime,act_applysettime,act_startime,act_endtime,poster_id,doc_id,act_abstract)");
			strSql.Append(" values (");
			strSql.Append("@act_class,@act_name,@act_applytime,@act_applysettime,@act_startime,@act_endtime,@poster_id,@doc_id,@act_abstract)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@act_class", SqlDbType.NVarChar,20),
					new SqlParameter("@act_name", SqlDbType.NVarChar,100),
					new SqlParameter("@act_applytime", SqlDbType.DateTime),
					new SqlParameter("@act_applysettime", SqlDbType.DateTime),
					new SqlParameter("@act_startime", SqlDbType.DateTime),
					new SqlParameter("@act_endtime", SqlDbType.DateTime),
					new SqlParameter("@poster_id", SqlDbType.VarChar,20),
					new SqlParameter("@doc_id", SqlDbType.VarChar,100),
					new SqlParameter("@act_abstract", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.act_class;
			parameters[1].Value = model.act_name;
			parameters[2].Value = model.act_applytime;
			parameters[3].Value = model.act_applysettime;
			parameters[4].Value = model.act_startime;
			parameters[5].Value = model.act_endtime;
			parameters[6].Value = model.poster_id;
			parameters[7].Value = model.doc_id;
			parameters[8].Value = model.act_abstract;

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
		public bool Update(IMAW.Model.activities model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update activities set ");
			strSql.Append("act_class=@act_class,");
			strSql.Append("act_name=@act_name,");
			strSql.Append("act_applytime=@act_applytime,");
			strSql.Append("act_applysettime=@act_applysettime,");
			strSql.Append("act_startime=@act_startime,");
			strSql.Append("act_endtime=@act_endtime,");
			strSql.Append("poster_id=@poster_id,");
			strSql.Append("doc_id=@doc_id,");
			strSql.Append("act_abstract=@act_abstract");
			strSql.Append(" where act_id=@act_id");
			SqlParameter[] parameters = {
					new SqlParameter("@act_class", SqlDbType.NVarChar,20),
					new SqlParameter("@act_name", SqlDbType.NVarChar,100),
					new SqlParameter("@act_applytime", SqlDbType.DateTime),
					new SqlParameter("@act_applysettime", SqlDbType.DateTime),
					new SqlParameter("@act_startime", SqlDbType.DateTime),
					new SqlParameter("@act_endtime", SqlDbType.DateTime),
					new SqlParameter("@poster_id", SqlDbType.VarChar,20),
					new SqlParameter("@doc_id", SqlDbType.VarChar,100),
					new SqlParameter("@act_abstract", SqlDbType.NVarChar,-1),
					new SqlParameter("@act_id", SqlDbType.Int,4)};
			parameters[0].Value = model.act_class;
			parameters[1].Value = model.act_name;
			parameters[2].Value = model.act_applytime;
			parameters[3].Value = model.act_applysettime;
			parameters[4].Value = model.act_startime;
			parameters[5].Value = model.act_endtime;
			parameters[6].Value = model.poster_id;
			parameters[7].Value = model.doc_id;
			parameters[8].Value = model.act_abstract;
			parameters[9].Value = model.act_id;

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
		public bool Delete(int act_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from activities ");
			strSql.Append(" where act_id=@act_id");
			SqlParameter[] parameters = {
					new SqlParameter("@act_id", SqlDbType.Int,4)
			};
			parameters[0].Value = act_id;

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
		public bool DeleteList(string act_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from activities ");
			strSql.Append(" where act_id in ("+act_idlist + ")  ");
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
		public IMAW.Model.activities GetModel(int act_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 act_id,act_class,act_name,act_applytime,act_applysettime,act_startime,act_endtime,poster_id,doc_id,act_abstract from activities ");
			strSql.Append(" where act_id=@act_id");
			SqlParameter[] parameters = {
					new SqlParameter("@act_id", SqlDbType.Int,4)
			};
			parameters[0].Value = act_id;

			IMAW.Model.activities model=new IMAW.Model.activities();
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
		public IMAW.Model.activities DataRowToModel(DataRow row)
		{
			IMAW.Model.activities model=new IMAW.Model.activities();
			if (row != null)
			{
				if(row["act_id"]!=null && row["act_id"].ToString()!="")
				{
					model.act_id=int.Parse(row["act_id"].ToString());
				}
				if(row["act_class"]!=null)
				{
					model.act_class=row["act_class"].ToString();
				}
				if(row["act_name"]!=null)
				{
					model.act_name=row["act_name"].ToString();
				}
				if(row["act_applytime"]!=null && row["act_applytime"].ToString()!="")
				{
					model.act_applytime=DateTime.Parse(row["act_applytime"].ToString());
				}
				if(row["act_applysettime"]!=null && row["act_applysettime"].ToString()!="")
				{
					model.act_applysettime=DateTime.Parse(row["act_applysettime"].ToString());
				}
				if(row["act_startime"]!=null && row["act_startime"].ToString()!="")
				{
					model.act_startime=DateTime.Parse(row["act_startime"].ToString());
				}
				if(row["act_endtime"]!=null && row["act_endtime"].ToString()!="")
				{
					model.act_endtime=DateTime.Parse(row["act_endtime"].ToString());
				}
				if(row["poster_id"]!=null)
				{
					model.poster_id=row["poster_id"].ToString();
				}
				if(row["doc_id"]!=null)
				{
					model.doc_id=row["doc_id"].ToString();
				}
				if(row["act_abstract"]!=null)
				{
					model.act_abstract=row["act_abstract"].ToString();
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
			strSql.Append("select act_id,act_class,act_name,act_applytime,act_applysettime,act_startime,act_endtime,poster_id,doc_id,act_abstract ");
			strSql.Append(" FROM activities ");
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
			strSql.Append(" act_id,act_class,act_name,act_applytime,act_applysettime,act_startime,act_endtime,poster_id,doc_id,act_abstract ");
			strSql.Append(" FROM activities ");
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
			strSql.Append("select count(1) FROM activities ");
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
				strSql.Append("order by T.act_id desc");
			}
			strSql.Append(")AS Row, T.*  from activities T ");
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
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "activities";
			parameters[1].Value = "act_id";
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

