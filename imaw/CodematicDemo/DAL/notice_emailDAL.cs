/**  版本信息模板在安装目录下，可自行修改。
* notice_emailDAL.cs
*
* 功 能： N/A
* 类 名： notice_emailDAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-08-05 21:39:13   N/A    初版
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
	/// 数据访问类:notice_emailDAL
	/// </summary>
	public partial class notice_emailDAL
	{
		public notice_emailDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string email_sn)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from notice_email");
			strSql.Append(" where email_sn=SQL2012email_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012email_sn", SqlDbType.VarChar,20)			};
			parameters[0].Value = email_sn;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.notice_email model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into notice_email(");
			strSql.Append("email_sn,email_class,email_theme,email_content,email_doc_id,email_postitme,email_settime,sender_id)");
			strSql.Append(" values (");
			strSql.Append("SQL2012email_sn,SQL2012email_class,SQL2012email_theme,SQL2012email_content,SQL2012email_doc_id,SQL2012email_postitme,SQL2012email_settime,SQL2012sender_id)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012email_sn", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012email_class", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012email_theme", SqlDbType.Bit,1),
					new SqlParameter("SQL2012email_content", SqlDbType.DateTime),
					new SqlParameter("SQL2012email_doc_id", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012email_postitme", SqlDbType.DateTime),
					new SqlParameter("SQL2012email_settime", SqlDbType.DateTime),
					new SqlParameter("SQL2012sender_id", SqlDbType.VarChar,20)};
			parameters[0].Value = model.email_sn;
			parameters[1].Value = model.email_class;
			parameters[2].Value = model.email_theme;
			parameters[3].Value = model.email_content;
			parameters[4].Value = model.email_doc_id;
			parameters[5].Value = model.email_postitme;
			parameters[6].Value = model.email_settime;
			parameters[7].Value = model.sender_id;

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
		public bool Update(Maticsoft.Model.notice_email model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update notice_email set ");
			strSql.Append("email_class=SQL2012email_class,");
			strSql.Append("email_theme=SQL2012email_theme,");
			strSql.Append("email_content=SQL2012email_content,");
			strSql.Append("email_doc_id=SQL2012email_doc_id,");
			strSql.Append("email_postitme=SQL2012email_postitme,");
			strSql.Append("email_settime=SQL2012email_settime,");
			strSql.Append("sender_id=SQL2012sender_id");
			strSql.Append(" where email_sn=SQL2012email_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012email_class", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012email_theme", SqlDbType.Bit,1),
					new SqlParameter("SQL2012email_content", SqlDbType.DateTime),
					new SqlParameter("SQL2012email_doc_id", SqlDbType.VarChar,50),
					new SqlParameter("SQL2012email_postitme", SqlDbType.DateTime),
					new SqlParameter("SQL2012email_settime", SqlDbType.DateTime),
					new SqlParameter("SQL2012sender_id", SqlDbType.VarChar,20),
					new SqlParameter("SQL2012email_sn", SqlDbType.VarChar,20)};
			parameters[0].Value = model.email_class;
			parameters[1].Value = model.email_theme;
			parameters[2].Value = model.email_content;
			parameters[3].Value = model.email_doc_id;
			parameters[4].Value = model.email_postitme;
			parameters[5].Value = model.email_settime;
			parameters[6].Value = model.sender_id;
			parameters[7].Value = model.email_sn;

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
		public bool Delete(string email_sn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from notice_email ");
			strSql.Append(" where email_sn=SQL2012email_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012email_sn", SqlDbType.VarChar,20)			};
			parameters[0].Value = email_sn;

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
		public bool DeleteList(string email_snlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from notice_email ");
			strSql.Append(" where email_sn in ("+email_snlist + ")  ");
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
		public Maticsoft.Model.notice_email GetModel(string email_sn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 email_sn,email_class,email_theme,email_content,email_doc_id,email_postitme,email_settime,sender_id from notice_email ");
			strSql.Append(" where email_sn=SQL2012email_sn ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012email_sn", SqlDbType.VarChar,20)			};
			parameters[0].Value = email_sn;

			Maticsoft.Model.notice_email model=new Maticsoft.Model.notice_email();
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
		public Maticsoft.Model.notice_email DataRowToModel(DataRow row)
		{
			Maticsoft.Model.notice_email model=new Maticsoft.Model.notice_email();
			if (row != null)
			{
				if(row["email_sn"]!=null)
				{
					model.email_sn=row["email_sn"].ToString();
				}
				if(row["email_class"]!=null)
				{
					model.email_class=row["email_class"].ToString();
				}
				if(row["email_theme"]!=null && row["email_theme"].ToString()!="")
				{
					if((row["email_theme"].ToString()=="1")||(row["email_theme"].ToString().ToLower()=="true"))
					{
						model.email_theme=true;
					}
					else
					{
						model.email_theme=false;
					}
				}
				if(row["email_content"]!=null && row["email_content"].ToString()!="")
				{
					model.email_content=DateTime.Parse(row["email_content"].ToString());
				}
				if(row["email_doc_id"]!=null)
				{
					model.email_doc_id=row["email_doc_id"].ToString();
				}
				if(row["email_postitme"]!=null && row["email_postitme"].ToString()!="")
				{
					model.email_postitme=DateTime.Parse(row["email_postitme"].ToString());
				}
				if(row["email_settime"]!=null && row["email_settime"].ToString()!="")
				{
					model.email_settime=DateTime.Parse(row["email_settime"].ToString());
				}
				if(row["sender_id"]!=null)
				{
					model.sender_id=row["sender_id"].ToString();
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
			strSql.Append("select email_sn,email_class,email_theme,email_content,email_doc_id,email_postitme,email_settime,sender_id ");
			strSql.Append(" FROM notice_email ");
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
			strSql.Append(" email_sn,email_class,email_theme,email_content,email_doc_id,email_postitme,email_settime,sender_id ");
			strSql.Append(" FROM notice_email ");
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
			strSql.Append("select count(1) FROM notice_email ");
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
				strSql.Append("order by T.email_sn desc");
			}
			strSql.Append(")AS Row, T.*  from notice_email T ");
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
			parameters[0].Value = "notice_email";
			parameters[1].Value = "email_sn";
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

