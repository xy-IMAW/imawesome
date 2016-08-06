/**  版本信息模板在安装目录下，可自行修改。
* dept_roleDAL.cs
*
* 功 能： N/A
* 类 名： dept_roleDAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:12   N/A    初版
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
	/// 数据访问类:dept_roleDAL
	/// </summary>
	public partial class dept_roleDAL
	{
		public dept_roleDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("role_id", "dept_role"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int role_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from dept_role");
			strSql.Append(" where role_id=SQL2012role_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012role_id", SqlDbType.Int,4)			};
			parameters[0].Value = role_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.dept_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dept_role(");
			strSql.Append("role_id,dept_id,role_introduce)");
			strSql.Append(" values (");
			strSql.Append("SQL2012role_id,SQL2012dept_id,SQL2012role_introduce)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012role_id", SqlDbType.Int,4),
					new SqlParameter("SQL2012dept_id", SqlDbType.Int,4),
					new SqlParameter("SQL2012role_introduce", SqlDbType.NVarChar,300)};
			parameters[0].Value = model.role_id;
			parameters[1].Value = model.dept_id;
			parameters[2].Value = model.role_introduce;

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
		public bool Update(Maticsoft.Model.dept_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dept_role set ");
			strSql.Append("dept_id=SQL2012dept_id,");
			strSql.Append("role_introduce=SQL2012role_introduce");
			strSql.Append(" where role_id=SQL2012role_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012dept_id", SqlDbType.Int,4),
					new SqlParameter("SQL2012role_introduce", SqlDbType.NVarChar,300),
					new SqlParameter("SQL2012role_id", SqlDbType.Int,4)};
			parameters[0].Value = model.dept_id;
			parameters[1].Value = model.role_introduce;
			parameters[2].Value = model.role_id;

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
		public bool Delete(int role_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dept_role ");
			strSql.Append(" where role_id=SQL2012role_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012role_id", SqlDbType.Int,4)			};
			parameters[0].Value = role_id;

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
		public bool DeleteList(string role_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dept_role ");
			strSql.Append(" where role_id in ("+role_idlist + ")  ");
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
		public Maticsoft.Model.dept_role GetModel(int role_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 role_id,dept_id,role_introduce from dept_role ");
			strSql.Append(" where role_id=SQL2012role_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012role_id", SqlDbType.Int,4)			};
			parameters[0].Value = role_id;

			Maticsoft.Model.dept_role model=new Maticsoft.Model.dept_role();
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
		public Maticsoft.Model.dept_role DataRowToModel(DataRow row)
		{
			Maticsoft.Model.dept_role model=new Maticsoft.Model.dept_role();
			if (row != null)
			{
				if(row["role_id"]!=null && row["role_id"].ToString()!="")
				{
					model.role_id=int.Parse(row["role_id"].ToString());
				}
				if(row["dept_id"]!=null && row["dept_id"].ToString()!="")
				{
					model.dept_id=int.Parse(row["dept_id"].ToString());
				}
				if(row["role_introduce"]!=null)
				{
					model.role_introduce=row["role_introduce"].ToString();
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
			strSql.Append("select role_id,dept_id,role_introduce ");
			strSql.Append(" FROM dept_role ");
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
			strSql.Append(" role_id,dept_id,role_introduce ");
			strSql.Append(" FROM dept_role ");
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
			strSql.Append("select count(1) FROM dept_role ");
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
				strSql.Append("order by T.role_id desc");
			}
			strSql.Append(")AS Row, T.*  from dept_role T ");
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
			parameters[0].Value = "dept_role";
			parameters[1].Value = "role_id";
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

