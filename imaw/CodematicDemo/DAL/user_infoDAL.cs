/**  版本信息模板在安装目录下，可自行修改。
* user_infoDAL.cs
*
* 功 能： N/A
* 类 名： user_infoDAL
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
	/// 数据访问类:user_infoDAL
	/// </summary>
	public partial class user_infoDAL
	{
		public user_infoDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string user_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from user_info");
			strSql.Append(" where user_id=SQL2012user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,50)			};
			parameters[0].Value = user_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.user_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into user_info(");
			strSql.Append("user_id,user_realname,user_stuid,user_school,user_major,user_sex,user_phone,user_email,user_qq,user_birthday,user_home,user_nation,user_politices)");
			strSql.Append(" values (");
			strSql.Append("SQL2012user_id,SQL2012user_realname,SQL2012user_stuid,SQL2012user_school,SQL2012user_major,SQL2012user_sex,SQL2012user_phone,SQL2012user_email,SQL2012user_qq,SQL2012user_birthday,SQL2012user_home,SQL2012user_nation,SQL2012user_politices)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_realname", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_stuid", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_school", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_major", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_sex", SqlDbType.NChar,2),
					new SqlParameter("SQL2012user_phone", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012user_email", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_qq", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_birthday", SqlDbType.date,3),
					new SqlParameter("SQL2012user_home", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012user_nation", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_politices", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.user_realname;
			parameters[2].Value = model.user_stuid;
			parameters[3].Value = model.user_school;
			parameters[4].Value = model.user_major;
			parameters[5].Value = model.user_sex;
			parameters[6].Value = model.user_phone;
			parameters[7].Value = model.user_email;
			parameters[8].Value = model.user_qq;
			parameters[9].Value = model.user_birthday;
			parameters[10].Value = model.user_home;
			parameters[11].Value = model.user_nation;
			parameters[12].Value = model.user_politices;

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
		public bool Update(Maticsoft.Model.user_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update user_info set ");
			strSql.Append("user_realname=SQL2012user_realname,");
			strSql.Append("user_stuid=SQL2012user_stuid,");
			strSql.Append("user_school=SQL2012user_school,");
			strSql.Append("user_major=SQL2012user_major,");
			strSql.Append("user_sex=SQL2012user_sex,");
			strSql.Append("user_phone=SQL2012user_phone,");
			strSql.Append("user_email=SQL2012user_email,");
			strSql.Append("user_qq=SQL2012user_qq,");
			strSql.Append("user_birthday=SQL2012user_birthday,");
			strSql.Append("user_home=SQL2012user_home,");
			strSql.Append("user_nation=SQL2012user_nation,");
			strSql.Append("user_politices=SQL2012user_politices");
			strSql.Append(" where user_id=SQL2012user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_realname", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_stuid", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_school", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_major", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_sex", SqlDbType.NChar,2),
					new SqlParameter("SQL2012user_phone", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012user_email", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_qq", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_birthday", SqlDbType.date,3),
					new SqlParameter("SQL2012user_home", SqlDbType.NVarChar,20),
					new SqlParameter("SQL2012user_nation", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_politices", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.user_realname;
			parameters[1].Value = model.user_stuid;
			parameters[2].Value = model.user_school;
			parameters[3].Value = model.user_major;
			parameters[4].Value = model.user_sex;
			parameters[5].Value = model.user_phone;
			parameters[6].Value = model.user_email;
			parameters[7].Value = model.user_qq;
			parameters[8].Value = model.user_birthday;
			parameters[9].Value = model.user_home;
			parameters[10].Value = model.user_nation;
			parameters[11].Value = model.user_politices;
			parameters[12].Value = model.user_id;

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
		public bool Delete(string user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from user_info ");
			strSql.Append(" where user_id=SQL2012user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,50)			};
			parameters[0].Value = user_id;

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
		public bool DeleteList(string user_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from user_info ");
			strSql.Append(" where user_id in ("+user_idlist + ")  ");
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
		public Maticsoft.Model.user_info GetModel(string user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 user_id,user_realname,user_stuid,user_school,user_major,user_sex,user_phone,user_email,user_qq,user_birthday,user_home,user_nation,user_politices from user_info ");
			strSql.Append(" where user_id=SQL2012user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,50)			};
			parameters[0].Value = user_id;

			Maticsoft.Model.user_info model=new Maticsoft.Model.user_info();
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
		public Maticsoft.Model.user_info DataRowToModel(DataRow row)
		{
			Maticsoft.Model.user_info model=new Maticsoft.Model.user_info();
			if (row != null)
			{
				if(row["user_id"]!=null)
				{
					model.user_id=row["user_id"].ToString();
				}
				if(row["user_realname"]!=null)
				{
					model.user_realname=row["user_realname"].ToString();
				}
				if(row["user_stuid"]!=null)
				{
					model.user_stuid=row["user_stuid"].ToString();
				}
				if(row["user_school"]!=null)
				{
					model.user_school=row["user_school"].ToString();
				}
				if(row["user_major"]!=null)
				{
					model.user_major=row["user_major"].ToString();
				}
				if(row["user_sex"]!=null)
				{
					model.user_sex=row["user_sex"].ToString();
				}
				if(row["user_phone"]!=null)
				{
					model.user_phone=row["user_phone"].ToString();
				}
				if(row["user_email"]!=null)
				{
					model.user_email=row["user_email"].ToString();
				}
				if(row["user_qq"]!=null)
				{
					model.user_qq=row["user_qq"].ToString();
				}
				if(row["user_birthday"]!=null && row["user_birthday"].ToString()!="")
				{
					model.user_birthday=DateTime.Parse(row["user_birthday"].ToString());
				}
				if(row["user_home"]!=null)
				{
					model.user_home=row["user_home"].ToString();
				}
				if(row["user_nation"]!=null)
				{
					model.user_nation=row["user_nation"].ToString();
				}
				if(row["user_politices"]!=null)
				{
					model.user_politices=row["user_politices"].ToString();
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
			strSql.Append("select user_id,user_realname,user_stuid,user_school,user_major,user_sex,user_phone,user_email,user_qq,user_birthday,user_home,user_nation,user_politices ");
			strSql.Append(" FROM user_info ");
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
			strSql.Append(" user_id,user_realname,user_stuid,user_school,user_major,user_sex,user_phone,user_email,user_qq,user_birthday,user_home,user_nation,user_politices ");
			strSql.Append(" FROM user_info ");
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
			strSql.Append("select count(1) FROM user_info ");
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
			strSql.Append(")AS Row, T.*  from user_info T ");
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
			parameters[0].Value = "user_info";
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

