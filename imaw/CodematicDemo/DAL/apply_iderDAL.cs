﻿/**  版本信息模板在安装目录下，可自行修改。
* apply_iderDAL.cs
*
* 功 能： N/A
* 类 名： apply_iderDAL
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
	/// 数据访问类:apply_iderDAL
	/// </summary>
	public partial class apply_iderDAL
	{
		public apply_iderDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string apply_sn)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from apply_ider");
			strSql.Append(" where apply_sn=SQL2012apply_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012apply_sn", SqlDbType.VarChar,50)			};
			parameters[0].Value = apply_sn;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.apply_ider model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into apply_ider(");
			strSql.Append("apply_sn,user_id,password,firstChoice,secondChoice,adjusted,apply_phote,apply_introduce,apply_hobby,apply_advantage,apply_workplan,apply_time,apply_state,apply_remark)");
			strSql.Append(" values (");
			strSql.Append("SQL2012apply_sn,SQL2012user_id,SQL2012password,SQL2012firstChoice,SQL2012secondChoice,SQL2012adjusted,SQL2012apply_phote,SQL2012apply_introduce,SQL2012apply_hobby,SQL2012apply_advantage,SQL2012apply_workplan,SQL2012apply_time,SQL2012apply_state,SQL2012apply_remark)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012apply_sn", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012password", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012firstChoice", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012secondChoice", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012adjusted", SqlDbType.Bit,1),
					new SqlParameter("SQL2012apply_phote", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012apply_introduce", SqlDbType.NVarChar,300),
					new SqlParameter("SQL2012apply_hobby", SqlDbType.NVarChar,300),
					new SqlParameter("SQL2012apply_advantage", SqlDbType.NVarChar,300),
					new SqlParameter("SQL2012apply_workplan", SqlDbType.NVarChar,300),
					new SqlParameter("SQL2012apply_time", SqlDbType.DateTime),
					new SqlParameter("SQL2012apply_state", SqlDbType.DateTime),
					new SqlParameter("SQL2012apply_remark", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.apply_sn;
			parameters[1].Value = model.user_id;
			parameters[2].Value = model.password;
			parameters[3].Value = model.firstChoice;
			parameters[4].Value = model.secondChoice;
			parameters[5].Value = model.adjusted;
			parameters[6].Value = model.apply_phote;
			parameters[7].Value = model.apply_introduce;
			parameters[8].Value = model.apply_hobby;
			parameters[9].Value = model.apply_advantage;
			parameters[10].Value = model.apply_workplan;
			parameters[11].Value = model.apply_time;
			parameters[12].Value = model.apply_state;
			parameters[13].Value = model.apply_remark;

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
		public bool Update(Maticsoft.Model.apply_ider model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update apply_ider set ");
			strSql.Append("user_id=SQL2012user_id,");
			strSql.Append("password=SQL2012password,");
			strSql.Append("firstChoice=SQL2012firstChoice,");
			strSql.Append("secondChoice=SQL2012secondChoice,");
			strSql.Append("adjusted=SQL2012adjusted,");
			strSql.Append("apply_phote=SQL2012apply_phote,");
			strSql.Append("apply_introduce=SQL2012apply_introduce,");
			strSql.Append("apply_hobby=SQL2012apply_hobby,");
			strSql.Append("apply_advantage=SQL2012apply_advantage,");
			strSql.Append("apply_workplan=SQL2012apply_workplan,");
			strSql.Append("apply_time=SQL2012apply_time,");
			strSql.Append("apply_state=SQL2012apply_state,");
			strSql.Append("apply_remark=SQL2012apply_remark");
			strSql.Append(" where apply_sn=SQL2012apply_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012password", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012firstChoice", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012secondChoice", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012adjusted", SqlDbType.Bit,1),
					new SqlParameter("SQL2012apply_phote", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012apply_introduce", SqlDbType.NVarChar,300),
					new SqlParameter("SQL2012apply_hobby", SqlDbType.NVarChar,300),
					new SqlParameter("SQL2012apply_advantage", SqlDbType.NVarChar,300),
					new SqlParameter("SQL2012apply_workplan", SqlDbType.NVarChar,300),
					new SqlParameter("SQL2012apply_time", SqlDbType.DateTime),
					new SqlParameter("SQL2012apply_state", SqlDbType.DateTime),
					new SqlParameter("SQL2012apply_remark", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012apply_sn", SqlDbType.VarChar,50)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.password;
			parameters[2].Value = model.firstChoice;
			parameters[3].Value = model.secondChoice;
			parameters[4].Value = model.adjusted;
			parameters[5].Value = model.apply_phote;
			parameters[6].Value = model.apply_introduce;
			parameters[7].Value = model.apply_hobby;
			parameters[8].Value = model.apply_advantage;
			parameters[9].Value = model.apply_workplan;
			parameters[10].Value = model.apply_time;
			parameters[11].Value = model.apply_state;
			parameters[12].Value = model.apply_remark;
			parameters[13].Value = model.apply_sn;

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
		public bool Delete(string apply_sn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from apply_ider ");
			strSql.Append(" where apply_sn=SQL2012apply_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012apply_sn", SqlDbType.VarChar,50)			};
			parameters[0].Value = apply_sn;

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
		public bool DeleteList(string apply_snlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from apply_ider ");
			strSql.Append(" where apply_sn in ("+apply_snlist + ")  ");
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
		public Maticsoft.Model.apply_ider GetModel(string apply_sn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 apply_sn,user_id,password,firstChoice,secondChoice,adjusted,apply_phote,apply_introduce,apply_hobby,apply_advantage,apply_workplan,apply_time,apply_state,apply_remark from apply_ider ");
			strSql.Append(" where apply_sn=SQL2012apply_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012apply_sn", SqlDbType.VarChar,50)			};
			parameters[0].Value = apply_sn;

			Maticsoft.Model.apply_ider model=new Maticsoft.Model.apply_ider();
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
		public Maticsoft.Model.apply_ider DataRowToModel(DataRow row)
		{
			Maticsoft.Model.apply_ider model=new Maticsoft.Model.apply_ider();
			if (row != null)
			{
				if(row["apply_sn"]!=null)
				{
					model.apply_sn=row["apply_sn"].ToString();
				}
				if(row["user_id"]!=null)
				{
					model.user_id=row["user_id"].ToString();
				}
				if(row["password"]!=null)
				{
					model.password=row["password"].ToString();
				}
				if(row["firstChoice"]!=null)
				{
					model.firstChoice=row["firstChoice"].ToString();
				}
				if(row["secondChoice"]!=null)
				{
					model.secondChoice=row["secondChoice"].ToString();
				}
				if(row["adjusted"]!=null && row["adjusted"].ToString()!="")
				{
					if((row["adjusted"].ToString()=="1")||(row["adjusted"].ToString().ToLower()=="true"))
					{
						model.adjusted=true;
					}
					else
					{
						model.adjusted=false;
					}
				}
				if(row["apply_phote"]!=null)
				{
					model.apply_phote=row["apply_phote"].ToString();
				}
				if(row["apply_introduce"]!=null)
				{
					model.apply_introduce=row["apply_introduce"].ToString();
				}
				if(row["apply_hobby"]!=null)
				{
					model.apply_hobby=row["apply_hobby"].ToString();
				}
				if(row["apply_advantage"]!=null)
				{
					model.apply_advantage=row["apply_advantage"].ToString();
				}
				if(row["apply_workplan"]!=null)
				{
					model.apply_workplan=row["apply_workplan"].ToString();
				}
				if(row["apply_time"]!=null && row["apply_time"].ToString()!="")
				{
					model.apply_time=DateTime.Parse(row["apply_time"].ToString());
				}
				if(row["apply_state"]!=null && row["apply_state"].ToString()!="")
				{
					model.apply_state=DateTime.Parse(row["apply_state"].ToString());
				}
				if(row["apply_remark"]!=null)
				{
					model.apply_remark=row["apply_remark"].ToString();
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
			strSql.Append("select apply_sn,user_id,password,firstChoice,secondChoice,adjusted,apply_phote,apply_introduce,apply_hobby,apply_advantage,apply_workplan,apply_time,apply_state,apply_remark ");
			strSql.Append(" FROM apply_ider ");
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
			strSql.Append(" apply_sn,user_id,password,firstChoice,secondChoice,adjusted,apply_phote,apply_introduce,apply_hobby,apply_advantage,apply_workplan,apply_time,apply_state,apply_remark ");
			strSql.Append(" FROM apply_ider ");
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
			strSql.Append("select count(1) FROM apply_ider ");
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
			strSql.Append(")AS Row, T.*  from apply_ider T ");
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
			parameters[0].Value = "apply_ider";
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

