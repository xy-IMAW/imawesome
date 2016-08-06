/**  版本信息模板在安装目录下，可自行修改。
* user_memberDAL.cs
*
* 功 能： N/A
* 类 名： user_memberDAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:16   N/A    初版
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
	/// 数据访问类:user_memberDAL
	/// </summary>
	public partial class user_memberDAL
	{
		public user_memberDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.user_member model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into user_member(");
			strSql.Append("user_id,member_id,member_stuid,member_balance,member_level,member_activities_sn)");
			strSql.Append(" values (");
			strSql.Append("SQL2012user_id,SQL2012member_id,SQL2012member_stuid,SQL2012member_balance,SQL2012member_level,SQL2012member_activities_sn)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012member_id", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012member_stuid", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012member_balance", SqlDbType.Int,4),
					new SqlParameter("SQL2012member_level", SqlDbType.Int,4),
					new SqlParameter("SQL2012member_activities_sn", SqlDbType.NVarChar,1000)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.member_id;
			parameters[2].Value = model.member_stuid;
			parameters[3].Value = model.member_balance;
			parameters[4].Value = model.member_level;
			parameters[5].Value = model.member_activities_sn;

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
		public bool Update(Maticsoft.Model.user_member model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update user_member set ");
			strSql.Append("user_id=SQL2012user_id,");
			strSql.Append("member_id=SQL2012member_id,");
			strSql.Append("member_stuid=SQL2012member_stuid,");
			strSql.Append("member_balance=SQL2012member_balance,");
			strSql.Append("member_level=SQL2012member_level,");
			strSql.Append("member_activities_sn=SQL2012member_activities_sn");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012member_id", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012member_stuid", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012member_balance", SqlDbType.Int,4),
					new SqlParameter("SQL2012member_level", SqlDbType.Int,4),
					new SqlParameter("SQL2012member_activities_sn", SqlDbType.NVarChar,1000)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.member_id;
			parameters[2].Value = model.member_stuid;
			parameters[3].Value = model.member_balance;
			parameters[4].Value = model.member_level;
			parameters[5].Value = model.member_activities_sn;

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
			strSql.Append("delete from user_member ");
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
		public Maticsoft.Model.user_member GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 user_id,member_id,member_stuid,member_balance,member_level,member_activities_sn from user_member ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.user_member model=new Maticsoft.Model.user_member();
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
		public Maticsoft.Model.user_member DataRowToModel(DataRow row)
		{
			Maticsoft.Model.user_member model=new Maticsoft.Model.user_member();
			if (row != null)
			{
				if(row["user_id"]!=null)
				{
					model.user_id=row["user_id"].ToString();
				}
				if(row["member_id"]!=null)
				{
					model.member_id=row["member_id"].ToString();
				}
				if(row["member_stuid"]!=null)
				{
					model.member_stuid=row["member_stuid"].ToString();
				}
				if(row["member_balance"]!=null && row["member_balance"].ToString()!="")
				{
					model.member_balance=int.Parse(row["member_balance"].ToString());
				}
				if(row["member_level"]!=null && row["member_level"].ToString()!="")
				{
					model.member_level=int.Parse(row["member_level"].ToString());
				}
				if(row["member_activities_sn"]!=null)
				{
					model.member_activities_sn=row["member_activities_sn"].ToString();
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
			strSql.Append("select user_id,member_id,member_stuid,member_balance,member_level,member_activities_sn ");
			strSql.Append(" FROM user_member ");
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
			strSql.Append(" user_id,member_id,member_stuid,member_balance,member_level,member_activities_sn ");
			strSql.Append(" FROM user_member ");
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
			strSql.Append("select count(1) FROM user_member ");
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
			strSql.Append(")AS Row, T.*  from user_member T ");
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
			parameters[0].Value = "user_member";
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

