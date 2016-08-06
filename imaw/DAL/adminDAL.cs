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
			strSql.Append(" where admin_id=@admin_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@admin_id", SqlDbType.VarChar,20)			};
			parameters[0].Value = admin_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IMAW.Model.admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into admin(");
			strSql.Append("admin_id,admin_pwd,admin_class,admin_lastlogintime,admin_loginnum)");
			strSql.Append(" values (");
			strSql.Append("@admin_id,@admin_pwd,@admin_class,@admin_lastlogintime,@admin_loginnum)");
			SqlParameter[] parameters = {
					new SqlParameter("@admin_id", SqlDbType.VarChar,20),
					new SqlParameter("@admin_pwd", SqlDbType.VarChar,20),
					new SqlParameter("@admin_class", SqlDbType.Int,4),
					new SqlParameter("@admin_lastlogintime", SqlDbType.VarChar,50),
					new SqlParameter("@admin_loginnum", SqlDbType.VarChar,50)};
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
		public bool Update(IMAW.Model.admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update admin set ");
			strSql.Append("admin_pwd=@admin_pwd,");
			strSql.Append("admin_class=@admin_class,");
			strSql.Append("admin_lastlogintime=@admin_lastlogintime,");
			strSql.Append("admin_loginnum=@admin_loginnum");
			strSql.Append(" where admin_id=@admin_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@admin_pwd", SqlDbType.VarChar,20),
					new SqlParameter("@admin_class", SqlDbType.Int,4),
					new SqlParameter("@admin_lastlogintime", SqlDbType.VarChar,50),
					new SqlParameter("@admin_loginnum", SqlDbType.VarChar,50),
					new SqlParameter("@admin_id", SqlDbType.VarChar,20)};
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
			strSql.Append(" where admin_id=@admin_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@admin_id", SqlDbType.VarChar,20)			};
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
		public IMAW.Model.admin GetModel(string admin_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 admin_id,admin_pwd,admin_class,admin_lastlogintime,admin_loginnum from admin ");
			strSql.Append(" where admin_id=@admin_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@admin_id", SqlDbType.VarChar,20)			};
			parameters[0].Value = admin_id;

			IMAW.Model.admin model=new IMAW.Model.admin();
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
		public IMAW.Model.admin DataRowToModel(DataRow row)
		{
			IMAW.Model.admin model=new IMAW.Model.admin();
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
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
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

