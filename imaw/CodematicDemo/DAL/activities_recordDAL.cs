/**  版本信息模板在安装目录下，可自行修改。
* activities_recordDAL.cs
*
* 功 能： N/A
* 类 名： activities_recordDAL
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
	/// 数据访问类:activities_recordDAL
	/// </summary>
	public partial class activities_recordDAL
	{
		public activities_recordDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string act_sn)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from activities_record");
			strSql.Append(" where act_sn=SQL2012act_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012act_sn", SqlDbType.VarChar,20)			};
			parameters[0].Value = act_sn;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.activities_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into activities_record(");
			strSql.Append("act_sn,act_appleytime,act_id,member_id,state,checker_id,checker_date,member_evaluate,reply_id,reply_date)");
			strSql.Append(" values (");
			strSql.Append("SQL2012act_sn,SQL2012act_appleytime,SQL2012act_id,SQL2012member_id,SQL2012state,SQL2012checker_id,SQL2012checker_date,SQL2012member_evaluate,SQL2012reply_id,SQL2012reply_date)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012act_sn", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012act_appleytime", SqlDbType.DateTime),
					new SqlParameter("SQL2012act_id", SqlDbType.Char,8),
					new SqlParameter("SQL2012member_id", SqlDbType.Char,13),
					new SqlParameter("SQL2012state", SqlDbType.NVarChar,8),
					new SqlParameter("SQL2012checker_id", SqlDbType.Char,2),
					new SqlParameter("SQL2012checker_date", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012member_evaluate", SqlDbType.Char,200),
					new SqlParameter("SQL2012reply_id", SqlDbType.Char,10),
					new SqlParameter("SQL2012reply_date", SqlDbType.DateTime)};
			parameters[0].Value = model.act_sn;
			parameters[1].Value = model.act_appleytime;
			parameters[2].Value = model.act_id;
			parameters[3].Value = model.member_id;
			parameters[4].Value = model.state;
			parameters[5].Value = model.checker_id;
			parameters[6].Value = model.checker_date;
			parameters[7].Value = model.member_evaluate;
			parameters[8].Value = model.reply_id;
			parameters[9].Value = model.reply_date;

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
		public bool Update(Maticsoft.Model.activities_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update activities_record set ");
			strSql.Append("act_appleytime=SQL2012act_appleytime,");
			strSql.Append("act_id=SQL2012act_id,");
			strSql.Append("member_id=SQL2012member_id,");
			strSql.Append("state=SQL2012state,");
			strSql.Append("checker_id=SQL2012checker_id,");
			strSql.Append("checker_date=SQL2012checker_date,");
			strSql.Append("member_evaluate=SQL2012member_evaluate,");
			strSql.Append("reply_id=SQL2012reply_id,");
			strSql.Append("reply_date=SQL2012reply_date");
			strSql.Append(" where act_sn=SQL2012act_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012act_appleytime", SqlDbType.DateTime),
					new SqlParameter("SQL2012act_id", SqlDbType.Char,8),
					new SqlParameter("SQL2012member_id", SqlDbType.Char,13),
					new SqlParameter("SQL2012state", SqlDbType.NVarChar,8),
					new SqlParameter("SQL2012checker_id", SqlDbType.Char,2),
					new SqlParameter("SQL2012checker_date", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012member_evaluate", SqlDbType.Char,200),
					new SqlParameter("SQL2012reply_id", SqlDbType.Char,10),
					new SqlParameter("SQL2012reply_date", SqlDbType.DateTime),
					new SqlParameter("SQL2012act_sn", SqlDbType.VarChar,20)};
			parameters[0].Value = model.act_appleytime;
			parameters[1].Value = model.act_id;
			parameters[2].Value = model.member_id;
			parameters[3].Value = model.state;
			parameters[4].Value = model.checker_id;
			parameters[5].Value = model.checker_date;
			parameters[6].Value = model.member_evaluate;
			parameters[7].Value = model.reply_id;
			parameters[8].Value = model.reply_date;
			parameters[9].Value = model.act_sn;

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
		public bool Delete(string act_sn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from activities_record ");
			strSql.Append(" where act_sn=SQL2012act_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012act_sn", SqlDbType.VarChar,20)			};
			parameters[0].Value = act_sn;

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
		public bool DeleteList(string act_snlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from activities_record ");
			strSql.Append(" where act_sn in ("+act_snlist + ")  ");
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
		public Maticsoft.Model.activities_record GetModel(string act_sn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 act_sn,act_appleytime,act_id,member_id,state,checker_id,checker_date,member_evaluate,reply_id,reply_date from activities_record ");
			strSql.Append(" where act_sn=SQL2012act_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012act_sn", SqlDbType.VarChar,20)			};
			parameters[0].Value = act_sn;

			Maticsoft.Model.activities_record model=new Maticsoft.Model.activities_record();
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
		public Maticsoft.Model.activities_record DataRowToModel(DataRow row)
		{
			Maticsoft.Model.activities_record model=new Maticsoft.Model.activities_record();
			if (row != null)
			{
				if(row["act_sn"]!=null)
				{
					model.act_sn=row["act_sn"].ToString();
				}
				if(row["act_appleytime"]!=null && row["act_appleytime"].ToString()!="")
				{
					model.act_appleytime=DateTime.Parse(row["act_appleytime"].ToString());
				}
				if(row["act_id"]!=null)
				{
					model.act_id=row["act_id"].ToString();
				}
				if(row["member_id"]!=null)
				{
					model.member_id=row["member_id"].ToString();
				}
				if(row["state"]!=null)
				{
					model.state=row["state"].ToString();
				}
				if(row["checker_id"]!=null)
				{
					model.checker_id=row["checker_id"].ToString();
				}
				if(row["checker_date"]!=null)
				{
					model.checker_date=row["checker_date"].ToString();
				}
				if(row["member_evaluate"]!=null)
				{
					model.member_evaluate=row["member_evaluate"].ToString();
				}
				if(row["reply_id"]!=null)
				{
					model.reply_id=row["reply_id"].ToString();
				}
				if(row["reply_date"]!=null && row["reply_date"].ToString()!="")
				{
					model.reply_date=DateTime.Parse(row["reply_date"].ToString());
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
			strSql.Append("select act_sn,act_appleytime,act_id,member_id,state,checker_id,checker_date,member_evaluate,reply_id,reply_date ");
			strSql.Append(" FROM activities_record ");
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
			strSql.Append(" act_sn,act_appleytime,act_id,member_id,state,checker_id,checker_date,member_evaluate,reply_id,reply_date ");
			strSql.Append(" FROM activities_record ");
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
			strSql.Append("select count(1) FROM activities_record ");
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
				strSql.Append("order by T.act_sn desc");
			}
			strSql.Append(")AS Row, T.*  from activities_record T ");
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
			parameters[0].Value = "activities_record";
			parameters[1].Value = "act_sn";
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

