﻿/**  版本信息模板在安装目录下，可自行修改。
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
using COMMON;//Please add references

namespace IMAW.DAL
{
	/// <summary>
	/// 数据访问类:dept_infoDAL
	/// </summary>
	public partial class dept_infoDAL
	{
		public dept_infoDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("dept_id", "dept_info"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int dept_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from dept_info");
			strSql.Append(" where dept_id=@dept_id");
			SqlParameter[] parameters = {
					new SqlParameter("@dept_id", SqlDbType.Int,4)
			};
			parameters[0].Value = dept_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IMAW.Model.dept_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dept_info(");
			strSql.Append("dept_name,dept_introduce,dept_minister_id,dept_num)");
			strSql.Append(" values (");
			strSql.Append("@dept_name,@dept_introduce,@dept_minister_id,@dept_num)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@dept_name", SqlDbType.NVarChar,50),
					new SqlParameter("@dept_introduce", SqlDbType.NVarChar,300),
					new SqlParameter("@dept_minister_id", SqlDbType.VarChar,20),
					new SqlParameter("@dept_num", SqlDbType.Int,4)};
			parameters[0].Value = model.dept_name;
			parameters[1].Value = model.dept_introduce;
			parameters[2].Value = model.dept_minister_id;
			parameters[3].Value = model.dept_num;

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
		public bool Update(IMAW.Model.dept_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dept_info set ");
			strSql.Append("dept_name=@dept_name,");
			strSql.Append("dept_introduce=@dept_introduce,");
			strSql.Append("dept_minister_id=@dept_minister_id,");
			strSql.Append("dept_num=@dept_num");
			strSql.Append(" where dept_id=@dept_id");
			SqlParameter[] parameters = {
					new SqlParameter("@dept_name", SqlDbType.NVarChar,50),
					new SqlParameter("@dept_introduce", SqlDbType.NVarChar,300),
					new SqlParameter("@dept_minister_id", SqlDbType.VarChar,20),
					new SqlParameter("@dept_num", SqlDbType.Int,4),
					new SqlParameter("@dept_id", SqlDbType.Int,4)};
			parameters[0].Value = model.dept_name;
			parameters[1].Value = model.dept_introduce;
			parameters[2].Value = model.dept_minister_id;
			parameters[3].Value = model.dept_num;
			parameters[4].Value = model.dept_id;

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
		public bool Delete(int dept_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dept_info ");
			strSql.Append(" where dept_id=@dept_id");
			SqlParameter[] parameters = {
					new SqlParameter("@dept_id", SqlDbType.Int,4)
			};
			parameters[0].Value = dept_id;

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
		public bool DeleteList(string dept_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dept_info ");
			strSql.Append(" where dept_id in ("+dept_idlist + ")  ");
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
		public IMAW.Model.dept_info GetModel(int dept_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 dept_id,dept_name,dept_introduce,dept_minister_id,dept_num from dept_info ");
			strSql.Append(" where dept_id=@dept_id");
			SqlParameter[] parameters = {
					new SqlParameter("@dept_id", SqlDbType.Int,4)
			};
			parameters[0].Value = dept_id;

			IMAW.Model.dept_info model=new IMAW.Model.dept_info();
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
		public IMAW.Model.dept_info DataRowToModel(DataRow row)
		{
			IMAW.Model.dept_info model=new IMAW.Model.dept_info();
			if (row != null)
			{
				if(row["dept_id"]!=null && row["dept_id"].ToString()!="")
				{
					model.dept_id=int.Parse(row["dept_id"].ToString());
				}
				if(row["dept_name"]!=null)
				{
					model.dept_name=row["dept_name"].ToString();
				}
				if(row["dept_introduce"]!=null)
				{
					model.dept_introduce=row["dept_introduce"].ToString();
				}
				if(row["dept_minister_id"]!=null)
				{
					model.dept_minister_id=row["dept_minister_id"].ToString();
				}
				if(row["dept_num"]!=null && row["dept_num"].ToString()!="")
				{
					model.dept_num=int.Parse(row["dept_num"].ToString());
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
			strSql.Append("select dept_id,dept_name,dept_introduce,dept_minister_id,dept_num ");
			strSql.Append(" FROM dept_info ");
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
			strSql.Append(" dept_id,dept_name,dept_introduce,dept_minister_id,dept_num ");
			strSql.Append(" FROM dept_info ");
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
			strSql.Append("select count(1) FROM dept_info ");
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
				strSql.Append("order by T.dept_id desc");
			}
			strSql.Append(")AS Row, T.*  from dept_info T ");
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
			parameters[0].Value = "dept_info";
			parameters[1].Value = "dept_id";
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

