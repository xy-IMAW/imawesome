/**  版本信息模板在安装目录下，可自行修改。
* activitiesDAL.cs
*
* 功 能： N/A
* 类 名： activitiesDAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:09   N/A    初版
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
			strSql.Append(" where act_id=SQL2012act_id");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012act_id", SqlDbType.Int,4)
			};
			parameters[0].Value = act_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.activities model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into activities(");
			strSql.Append("act_class,act_name,act_applytime,act_applysettime,act_startime,act_endtime,poster_id,doc_id,act_abstract)");
			strSql.Append(" values (");
			strSql.Append("SQL2012act_class,SQL2012act_name,SQL2012act_applytime,SQL2012act_applysettime,SQL2012act_startime,SQL2012act_endtime,SQL2012poster_id,SQL2012doc_id,SQL2012act_abstract)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012act_class", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012act_name", SqlDbType.NVarChar,100),
					new SqlParameter("SQL2012act_applytime", SqlDbType.DateTime),
					new SqlParameter("SQL2012act_applysettime", SqlDbType.DateTime),
					new SqlParameter("SQL2012act_startime", SqlDbType.DateTime),
					new SqlParameter("SQL2012act_endtime", SqlDbType.DateTime),
					new SqlParameter("SQL2012poster_id", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012doc_id", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012act_abstract", SqlDbType.NVarChar,-1)};
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
		public bool Update(Maticsoft.Model.activities model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update activities set ");
			strSql.Append("act_class=SQL2012act_class,");
			strSql.Append("act_name=SQL2012act_name,");
			strSql.Append("act_applytime=SQL2012act_applytime,");
			strSql.Append("act_applysettime=SQL2012act_applysettime,");
			strSql.Append("act_startime=SQL2012act_startime,");
			strSql.Append("act_endtime=SQL2012act_endtime,");
			strSql.Append("poster_id=SQL2012poster_id,");
			strSql.Append("doc_id=SQL2012doc_id,");
			strSql.Append("act_abstract=SQL2012act_abstract");
			strSql.Append(" where act_id=SQL2012act_id");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012act_class", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012act_name", SqlDbType.NVarChar,100),
					new SqlParameter("SQL2012act_applytime", SqlDbType.DateTime),
					new SqlParameter("SQL2012act_applysettime", SqlDbType.DateTime),
					new SqlParameter("SQL2012act_startime", SqlDbType.DateTime),
					new SqlParameter("SQL2012act_endtime", SqlDbType.DateTime),
					new SqlParameter("SQL2012poster_id", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012doc_id", SqlDbType.VarChar,100),
					new SqlParameter("SQL2012act_abstract", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012act_id", SqlDbType.Int,4)};
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
			strSql.Append(" where act_id=SQL2012act_id");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012act_id", SqlDbType.Int,4)
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
		public Maticsoft.Model.activities GetModel(int act_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 act_id,act_class,act_name,act_applytime,act_applysettime,act_startime,act_endtime,poster_id,doc_id,act_abstract from activities ");
			strSql.Append(" where act_id=SQL2012act_id");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012act_id", SqlDbType.Int,4)
			};
			parameters[0].Value = act_id;

			Maticsoft.Model.activities model=new Maticsoft.Model.activities();
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
		public Maticsoft.Model.activities DataRowToModel(DataRow row)
		{
			Maticsoft.Model.activities model=new Maticsoft.Model.activities();
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
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
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

