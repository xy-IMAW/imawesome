/**  版本信息模板在安装目录下，可自行修改。
* apply_memberDAL.cs
*
* 功 能： N/A
* 类 名： apply_memberDAL
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
	/// 数据访问类:apply_memberDAL
	/// </summary>
	public partial class apply_memberDAL
	{
		public apply_memberDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.apply_member model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into apply_member(");
			strSql.Append("user_id,applydate,checker_id,checkdate)");
			strSql.Append(" values (");
			strSql.Append("SQL2012user_id,SQL2012applydate,SQL2012checker_id,SQL2012checkdate)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.NChar,20),
					new SqlParameter("SQL2012applydate", SqlDbType.NChar,10),
					new SqlParameter("SQL2012checker_id", SqlDbType.NChar,10),
					new SqlParameter("SQL2012checkdate", SqlDbType.NChar,10)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.applydate;
			parameters[2].Value = model.checker_id;
			parameters[3].Value = model.checkdate;

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
		public bool Update(Maticsoft.Model.apply_member model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update apply_member set ");
			strSql.Append("user_id=SQL2012user_id,");
			strSql.Append("applydate=SQL2012applydate,");
			strSql.Append("checker_id=SQL2012checker_id,");
			strSql.Append("checkdate=SQL2012checkdate");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.NChar,20),
					new SqlParameter("SQL2012applydate", SqlDbType.NChar,10),
					new SqlParameter("SQL2012checker_id", SqlDbType.NChar,10),
					new SqlParameter("SQL2012checkdate", SqlDbType.NChar,10)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.applydate;
			parameters[2].Value = model.checker_id;
			parameters[3].Value = model.checkdate;

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
			strSql.Append("delete from apply_member ");
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
		public Maticsoft.Model.apply_member GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 user_id,applydate,checker_id,checkdate from apply_member ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.apply_member model=new Maticsoft.Model.apply_member();
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
		public Maticsoft.Model.apply_member DataRowToModel(DataRow row)
		{
			Maticsoft.Model.apply_member model=new Maticsoft.Model.apply_member();
			if (row != null)
			{
				if(row["user_id"]!=null)
				{
					model.user_id=row["user_id"].ToString();
				}
				if(row["applydate"]!=null)
				{
					model.applydate=row["applydate"].ToString();
				}
				if(row["checker_id"]!=null)
				{
					model.checker_id=row["checker_id"].ToString();
				}
				if(row["checkdate"]!=null)
				{
					model.checkdate=row["checkdate"].ToString();
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
			strSql.Append("select user_id,applydate,checker_id,checkdate ");
			strSql.Append(" FROM apply_member ");
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
			strSql.Append(" user_id,applydate,checker_id,checkdate ");
			strSql.Append(" FROM apply_member ");
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
			strSql.Append("select count(1) FROM apply_member ");
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
				strSql.Append("order by T.apply_sn desc");
			}
			strSql.Append(")AS Row, T.*  from apply_member T ");
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
			parameters[0].Value = "apply_member";
			parameters[1].Value = "apply_sn";
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

