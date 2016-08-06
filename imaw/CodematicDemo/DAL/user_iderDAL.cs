/**  版本信息模板在安装目录下，可自行修改。
* user_iderDAL.cs
*
* 功 能： N/A
* 类 名： user_iderDAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:15   N/A    初版
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
	/// 数据访问类:user_iderDAL
	/// </summary>
	public partial class user_iderDAL
	{
		public user_iderDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.user_ider model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into user_ider(");
			strSql.Append("ider_id,dept_id,role_id,role_starttime,role_endtime,ider_balance)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ider_id,SQL2012dept_id,SQL2012role_id,SQL2012role_starttime,SQL2012role_endtime,SQL2012ider_balance)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ider_id", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012dept_id", SqlDbType.Int,4),
					new SqlParameter("SQL2012role_id", SqlDbType.Int,4),
					new SqlParameter("SQL2012role_starttime", SqlDbType.DateTime),
					new SqlParameter("SQL2012role_endtime", SqlDbType.DateTime),
					new SqlParameter("SQL2012ider_balance", SqlDbType.Int,4)};
			parameters[0].Value = model.ider_id;
			parameters[1].Value = model.dept_id;
			parameters[2].Value = model.role_id;
			parameters[3].Value = model.role_starttime;
			parameters[4].Value = model.role_endtime;
			parameters[5].Value = model.ider_balance;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.user_ider model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update user_ider set ");
			strSql.Append("ider_id=SQL2012ider_id,");
			strSql.Append("dept_id=SQL2012dept_id,");
			strSql.Append("role_id=SQL2012role_id,");
			strSql.Append("role_starttime=SQL2012role_starttime,");
			strSql.Append("role_endtime=SQL2012role_endtime,");
			strSql.Append("ider_balance=SQL2012ider_balance");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ider_id", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012dept_id", SqlDbType.Int,4),
					new SqlParameter("SQL2012role_id", SqlDbType.Int,4),
					new SqlParameter("SQL2012role_starttime", SqlDbType.DateTime),
					new SqlParameter("SQL2012role_endtime", SqlDbType.DateTime),
					new SqlParameter("SQL2012ider_balance", SqlDbType.Int,4)};
			parameters[0].Value = model.ider_id;
			parameters[1].Value = model.dept_id;
			parameters[2].Value = model.role_id;
			parameters[3].Value = model.role_starttime;
			parameters[4].Value = model.role_endtime;
			parameters[5].Value = model.ider_balance;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from user_ider ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.user_ider GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ider_id,dept_id,role_id,role_starttime,role_endtime,ider_balance from user_ider ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.user_ider model=new Maticsoft.Model.user_ider();
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
		public Maticsoft.Model.user_ider DataRowToModel(DataRow row)
		{
			Maticsoft.Model.user_ider model=new Maticsoft.Model.user_ider();
			if (row != null)
			{
				if(row["ider_id"]!=null)
				{
					model.ider_id=row["ider_id"].ToString();
				}
				if(row["dept_id"]!=null && row["dept_id"].ToString()!="")
				{
					model.dept_id=int.Parse(row["dept_id"].ToString());
				}
				if(row["role_id"]!=null && row["role_id"].ToString()!="")
				{
					model.role_id=int.Parse(row["role_id"].ToString());
				}
				if(row["role_starttime"]!=null && row["role_starttime"].ToString()!="")
				{
					model.role_starttime=DateTime.Parse(row["role_starttime"].ToString());
				}
				if(row["role_endtime"]!=null && row["role_endtime"].ToString()!="")
				{
					model.role_endtime=DateTime.Parse(row["role_endtime"].ToString());
				}
				if(row["ider_balance"]!=null && row["ider_balance"].ToString()!="")
				{
					model.ider_balance=int.Parse(row["ider_balance"].ToString());
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
			strSql.Append("select ider_id,dept_id,role_id,role_starttime,role_endtime,ider_balance ");
			strSql.Append(" FROM user_ider ");
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
			strSql.Append(" ider_id,dept_id,role_id,role_starttime,role_endtime,ider_balance ");
			strSql.Append(" FROM user_ider ");
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
			strSql.Append("select count(1) FROM user_ider ");
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
				strSql.Append("order by T.user_id desc");
			}
			strSql.Append(")AS Row, T.*  from user_ider T ");
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
			parameters[0].Value = "user_ider";
			parameters[1].Value = "user_id";
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

