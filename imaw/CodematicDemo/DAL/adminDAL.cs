/**  版本信息模板在安装目录下，可自行修改。
* adminDAL.cs
*
* 功 能： N/A
* 类 名： adminDAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:10   N/A    初版
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
	/// 数据访问类:adminDAL
	/// </summary>
	public partial class adminDAL
	{
		public adminDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string admin_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from admin");
			strSql.Append(" where admin_id=SQL2012admin_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012admin_id", SqlDbType.VarChar,20)			};
			parameters[0].Value = admin_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into admin(");
			strSql.Append("admin_id,admin_pwd,admin_class,admin_lastlogintime,admin_loginnum)");
			strSql.Append(" values (");
			strSql.Append("SQL2012admin_id,SQL2012admin_pwd,SQL2012admin_class,SQL2012admin_lastlogintime,SQL2012admin_loginnum)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012admin_id", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012admin_pwd", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012admin_class", SqlDbType.Int,4),
					new SqlParameter("SQL2012admin_lastlogintime", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012admin_loginnum", SqlDbType.VarChar,50)};
			parameters[0].Value = model.admin_id;
			parameters[1].Value = model.admin_pwd;
			parameters[2].Value = model.admin_class;
			parameters[3].Value = model.admin_lastlogintime;
			parameters[4].Value = model.admin_loginnum;

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
		public bool Update(Maticsoft.Model.admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update admin set ");
			strSql.Append("admin_pwd=SQL2012admin_pwd,");
			strSql.Append("admin_class=SQL2012admin_class,");
			strSql.Append("admin_lastlogintime=SQL2012admin_lastlogintime,");
			strSql.Append("admin_loginnum=SQL2012admin_loginnum");
			strSql.Append(" where admin_id=SQL2012admin_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012admin_pwd", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012admin_class", SqlDbType.Int,4),
					new SqlParameter("SQL2012admin_lastlogintime", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012admin_loginnum", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012admin_id", SqlDbType.VarChar,20)};
			parameters[0].Value = model.admin_pwd;
			parameters[1].Value = model.admin_class;
			parameters[2].Value = model.admin_lastlogintime;
			parameters[3].Value = model.admin_loginnum;
			parameters[4].Value = model.admin_id;

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
		public bool Delete(string admin_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from admin ");
			strSql.Append(" where admin_id=SQL2012admin_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012admin_id", SqlDbType.VarChar,20)			};
			parameters[0].Value = admin_id;

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
		public bool DeleteList(string admin_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from admin ");
			strSql.Append(" where admin_id in ("+admin_idlist + ")  ");
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
		public Maticsoft.Model.admin GetModel(string admin_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 admin_id,admin_pwd,admin_class,admin_lastlogintime,admin_loginnum from admin ");
			strSql.Append(" where admin_id=SQL2012admin_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012admin_id", SqlDbType.VarChar,20)			};
			parameters[0].Value = admin_id;

			Maticsoft.Model.admin model=new Maticsoft.Model.admin();
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
		public Maticsoft.Model.admin DataRowToModel(DataRow row)
		{
			Maticsoft.Model.admin model=new Maticsoft.Model.admin();
			if (row != null)
			{
				if(row["admin_id"]!=null)
				{
					model.admin_id=row["admin_id"].ToString();
				}
				if(row["admin_pwd"]!=null)
				{
					model.admin_pwd=row["admin_pwd"].ToString();
				}
				if(row["admin_class"]!=null && row["admin_class"].ToString()!="")
				{
					model.admin_class=int.Parse(row["admin_class"].ToString());
				}
				if(row["admin_lastlogintime"]!=null)
				{
					model.admin_lastlogintime=row["admin_lastlogintime"].ToString();
				}
				if(row["admin_loginnum"]!=null)
				{
					model.admin_loginnum=row["admin_loginnum"].ToString();
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
			strSql.Append("select admin_id,admin_pwd,admin_class,admin_lastlogintime,admin_loginnum ");
			strSql.Append(" FROM admin ");
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
			strSql.Append(" admin_id,admin_pwd,admin_class,admin_lastlogintime,admin_loginnum ");
			strSql.Append(" FROM admin ");
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
			strSql.Append("select count(1) FROM admin ");
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
				strSql.Append("order by T.admin_id desc");
			}
			strSql.Append(")AS Row, T.*  from admin T ");
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
			parameters[0].Value = "admin";
			parameters[1].Value = "admin_id";
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

