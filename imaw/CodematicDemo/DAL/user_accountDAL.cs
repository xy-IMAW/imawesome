/**  版本信息模板在安装目录下，可自行修改。
* user_accountDAL.cs
*
* 功 能： N/A
* 类 名： user_accountDAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:14   N/A    初版
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
	/// 数据访问类:user_accountDAL
	/// </summary>
	public partial class user_accountDAL
	{
		public user_accountDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string user_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from user_account");
			strSql.Append(" where user_id=SQL2012user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,50)			};
			parameters[0].Value = user_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.user_account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into user_account(");
			strSql.Append("user_id,user_pwd,user_nickname,user_registerdate,user_lastlogindate,user_loginnum,user_email,user_photo,user_pwd_que,user_pwd_ans,user_class)");
			strSql.Append(" values (");
			strSql.Append("SQL2012user_id,SQL2012user_pwd,SQL2012user_nickname,SQL2012user_registerdate,SQL2012user_lastlogindate,SQL2012user_loginnum,SQL2012user_email,SQL2012user_photo,SQL2012user_pwd_que,SQL2012user_pwd_ans,SQL2012user_class)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_pwd", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012user_nickname", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_registerdate", SqlDbType.DateTime),
					new SqlParameter("SQL2012user_lastlogindate", SqlDbType.DateTime),
					new SqlParameter("SQL2012user_loginnum", SqlDbType.Int,4),
					new SqlParameter("SQL2012user_email", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_photo", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_pwd_que", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_pwd_ans", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_class", SqlDbType.Int,4)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.user_pwd;
			parameters[2].Value = model.user_nickname;
			parameters[3].Value = model.user_registerdate;
			parameters[4].Value = model.user_lastlogindate;
			parameters[5].Value = model.user_loginnum;
			parameters[6].Value = model.user_email;
			parameters[7].Value = model.user_photo;
			parameters[8].Value = model.user_pwd_que;
			parameters[9].Value = model.user_pwd_ans;
			parameters[10].Value = model.user_class;

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
		public bool Update(Maticsoft.Model.user_account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update user_account set ");
			strSql.Append("user_pwd=SQL2012user_pwd,");
			strSql.Append("user_nickname=SQL2012user_nickname,");
			strSql.Append("user_registerdate=SQL2012user_registerdate,");
			strSql.Append("user_lastlogindate=SQL2012user_lastlogindate,");
			strSql.Append("user_loginnum=SQL2012user_loginnum,");
			strSql.Append("user_email=SQL2012user_email,");
			strSql.Append("user_photo=SQL2012user_photo,");
			strSql.Append("user_pwd_que=SQL2012user_pwd_que,");
			strSql.Append("user_pwd_ans=SQL2012user_pwd_ans,");
			strSql.Append("user_class=SQL2012user_class");
			strSql.Append(" where user_id=SQL2012user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_pwd", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012user_nickname", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_registerdate", SqlDbType.DateTime),
					new SqlParameter("SQL2012user_lastlogindate", SqlDbType.DateTime),
					new SqlParameter("SQL2012user_loginnum", SqlDbType.Int,4),
					new SqlParameter("SQL2012user_email", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_photo", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012user_pwd_que", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_pwd_ans", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012user_class", SqlDbType.Int,4),
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.user_pwd;
			parameters[1].Value = model.user_nickname;
			parameters[2].Value = model.user_registerdate;
			parameters[3].Value = model.user_lastlogindate;
			parameters[4].Value = model.user_loginnum;
			parameters[5].Value = model.user_email;
			parameters[6].Value = model.user_photo;
			parameters[7].Value = model.user_pwd_que;
			parameters[8].Value = model.user_pwd_ans;
			parameters[9].Value = model.user_class;
			parameters[10].Value = model.user_id;

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
			strSql.Append("delete from user_account ");
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
			strSql.Append("delete from user_account ");
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
		public Maticsoft.Model.user_account GetModel(string user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 user_id,user_pwd,user_nickname,user_registerdate,user_lastlogindate,user_loginnum,user_email,user_photo,user_pwd_que,user_pwd_ans,user_class from user_account ");
			strSql.Append(" where user_id=SQL2012user_id ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012user_id", SqlDbType.VarChar,50)			};
			parameters[0].Value = user_id;

			Maticsoft.Model.user_account model=new Maticsoft.Model.user_account();
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
		public Maticsoft.Model.user_account DataRowToModel(DataRow row)
		{
			Maticsoft.Model.user_account model=new Maticsoft.Model.user_account();
			if (row != null)
			{
				if(row["user_id"]!=null)
				{
					model.user_id=row["user_id"].ToString();
				}
				if(row["user_pwd"]!=null)
				{
					model.user_pwd=row["user_pwd"].ToString();
				}
				if(row["user_nickname"]!=null)
				{
					model.user_nickname=row["user_nickname"].ToString();
				}
				if(row["user_registerdate"]!=null && row["user_registerdate"].ToString()!="")
				{
					model.user_registerdate=DateTime.Parse(row["user_registerdate"].ToString());
				}
				if(row["user_lastlogindate"]!=null && row["user_lastlogindate"].ToString()!="")
				{
					model.user_lastlogindate=DateTime.Parse(row["user_lastlogindate"].ToString());
				}
				if(row["user_loginnum"]!=null && row["user_loginnum"].ToString()!="")
				{
					model.user_loginnum=int.Parse(row["user_loginnum"].ToString());
				}
				if(row["user_email"]!=null)
				{
					model.user_email=row["user_email"].ToString();
				}
				if(row["user_photo"]!=null)
				{
					model.user_photo=row["user_photo"].ToString();
				}
				if(row["user_pwd_que"]!=null)
				{
					model.user_pwd_que=row["user_pwd_que"].ToString();
				}
				if(row["user_pwd_ans"]!=null)
				{
					model.user_pwd_ans=row["user_pwd_ans"].ToString();
				}
				if(row["user_class"]!=null && row["user_class"].ToString()!="")
				{
					model.user_class=int.Parse(row["user_class"].ToString());
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
			strSql.Append("select user_id,user_pwd,user_nickname,user_registerdate,user_lastlogindate,user_loginnum,user_email,user_photo,user_pwd_que,user_pwd_ans,user_class ");
			strSql.Append(" FROM user_account ");
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
			strSql.Append(" user_id,user_pwd,user_nickname,user_registerdate,user_lastlogindate,user_loginnum,user_email,user_photo,user_pwd_que,user_pwd_ans,user_class ");
			strSql.Append(" FROM user_account ");
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
			strSql.Append("select count(1) FROM user_account ");
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
			strSql.Append(")AS Row, T.*  from user_account T ");
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
			parameters[0].Value = "user_account";
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

