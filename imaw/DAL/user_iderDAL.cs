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
using IMAW.Model;
using COMMON;

namespace IMAW.DAL
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
		public bool Add(IMAW.Model.user_ider model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into user_ider(");
			strSql.Append("ider_id,dept_id,role_id,role_starttime,role_endtime,ider_balance)");
			strSql.Append(" values (");
			strSql.Append("@ider_id,@dept_id,@role_id,@role_starttime,@role_endtime,@ider_balance)");
			SqlParameter[] parameters = {
					new SqlParameter("@ider_id", SqlDbType.VarChar,50),
					new SqlParameter("@dept_id", SqlDbType.Int,4),
					new SqlParameter("@role_id", SqlDbType.Int,4),
					new SqlParameter("@role_starttime", SqlDbType.DateTime),
					new SqlParameter("@role_endtime", SqlDbType.DateTime),
					new SqlParameter("@ider_balance", SqlDbType.Int,4)};
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
		public bool Update(IMAW.Model.user_ider model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update user_ider set ");
			strSql.Append("ider_id=@ider_id,");
			strSql.Append("dept_id=@dept_id,");
			strSql.Append("role_id=@role_id,");
			strSql.Append("role_starttime=@role_starttime,");
			strSql.Append("role_endtime=@role_endtime,");
			strSql.Append("ider_balance=@ider_balance");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ider_id", SqlDbType.VarChar,50),
					new SqlParameter("@dept_id", SqlDbType.Int,4),
					new SqlParameter("@role_id", SqlDbType.Int,4),
					new SqlParameter("@role_starttime", SqlDbType.DateTime),
					new SqlParameter("@role_endtime", SqlDbType.DateTime),
					new SqlParameter("@ider_balance", SqlDbType.Int,4)};
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
		public IMAW.Model.user_ider GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ider_id,dept_id,role_id,role_starttime,role_endtime,ider_balance from user_ider ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			IMAW.Model.user_ider model=new IMAW.Model.user_ider();
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
		public IMAW.Model.user_ider DataRowToModel(DataRow row)
		{
			IMAW.Model.user_ider model=new IMAW.Model.user_ider();
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
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
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

