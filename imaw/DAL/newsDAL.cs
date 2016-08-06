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
using IMAW.Model;
using COMMON;

namespace IMAW.DAL
{
	/// <summary>
	/// 数据访问类:newsDAL
	/// </summary>
	public partial class newsDAL
	{
		public newsDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("news_id", "news"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int news_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from news");
			strSql.Append(" where news_id=@news_id");
			SqlParameter[] parameters = {
					new SqlParameter("@news_id", SqlDbType.Int,4)
			};
			parameters[0].Value = news_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(IMAW.Model.news model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into news(");
            strSql.Append("news_createtime,news_posterid,news_postername,news_title,news_class,news_abstract,news_content,news_readnum,news_state)");
            strSql.Append(" values (");
            strSql.Append("@news_createtime,@news_posterid,@news_postername,@news_title,@news_class,@news_abstract,@news_content,@news_readnum,@news_state)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@news_createtime", SqlDbType.DateTime),
                    new SqlParameter("@news_posterid", SqlDbType.VarChar,50),
                    new SqlParameter("@news_postername", SqlDbType.NVarChar,20),
                    new SqlParameter("@news_title", SqlDbType.NVarChar,50),
                    new SqlParameter("@news_class", SqlDbType.NVarChar,50),
                    new SqlParameter("@news_abstract", SqlDbType.NVarChar,200),
                    new SqlParameter("@news_content", SqlDbType.NVarChar,-1),
                    new SqlParameter("@news_readnum", SqlDbType.Int,4),
                    new SqlParameter("@news_state", SqlDbType.Int,4),

            };
            parameters[0].Value = model.news_createtime;
            parameters[1].Value = model.news_posterid;
            parameters[2].Value = model.news_postername;
            parameters[3].Value = model.news_title;
			parameters[4].Value = model.news_class;
			parameters[5].Value = model.news_abstract;
			parameters[6].Value = model.news_content;
			parameters[7].Value = model.news_readnum;
			parameters[8].Value = model.news_state;
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
		public bool Update(IMAW.Model.news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update news set ");
			strSql.Append("news_createtime=@news_createtime,");
			strSql.Append("news_posterid=@news_posterid,");
            strSql.Append("news_postername=@news_postername,");
            strSql.Append("news_title=@news_title,");
			strSql.Append("news_class=@news_class,");
			strSql.Append("news_abstract=@news_abstract,");
			strSql.Append("news_content=@news_content,");
			strSql.Append("news_readnum=@news_readnum,");
			strSql.Append("news_state=@news_state");
			strSql.Append(" where news_id=@news_id");
            SqlParameter[] parameters = {
                    new SqlParameter("@news_createtime", SqlDbType.DateTime),
                    new SqlParameter("@news_posterid", SqlDbType.VarChar,50),
                    new SqlParameter("@news_postername", SqlDbType.NVarChar,20),
                    new SqlParameter("@news_title", SqlDbType.NVarChar,50),
                    new SqlParameter("@news_class", SqlDbType.NVarChar,50),
                    new SqlParameter("@news_abstract", SqlDbType.NVarChar,200),
                    new SqlParameter("@news_content", SqlDbType.NVarChar,-1),
                    new SqlParameter("@news_readnum", SqlDbType.Int,4),
                    new SqlParameter("@news_state", SqlDbType.Int,4),
                    new SqlParameter("@news_id", SqlDbType.Int,4)

            };
            parameters[0].Value = model.news_createtime;
            parameters[1].Value = model.news_posterid;
            parameters[2].Value = model.news_postername;
            parameters[3].Value = model.news_title;
            parameters[4].Value = model.news_class;
            parameters[5].Value = model.news_abstract;
            parameters[6].Value = model.news_content;
            parameters[7].Value = model.news_readnum;
            parameters[8].Value = model.news_state;
            parameters[9].Value = model.news_id;


            int rows =DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int news_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from news ");
			strSql.Append(" where news_id=@news_id");
			SqlParameter[] parameters = {
					new SqlParameter("@news_id", SqlDbType.Int,4)
			};
			parameters[0].Value = news_id;

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
		public bool DeleteList(string news_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from news ");
			strSql.Append(" where news_id in ("+news_idlist + ")  ");
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
		public IMAW.Model.news GetModel(int news_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 news_id,news_createtime,news_posterid,news_postername,news_title,news_class,news_abstract,news_content,news_readnum,news_state from news ");
			strSql.Append(" where news_id=@news_id");
			SqlParameter[] parameters = {
					new SqlParameter("@news_id", SqlDbType.Int,4)
			};
			parameters[0].Value = news_id;

			IMAW.Model.news model=new IMAW.Model.news();
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
		public IMAW.Model.news DataRowToModel(DataRow row)
		{
			IMAW.Model.news model=new IMAW.Model.news();
			if (row != null)
			{
				if(row["news_id"]!=null && row["news_id"].ToString()!="")
				{
					model.news_id=int.Parse(row["news_id"].ToString());
				}
				if(row["news_createtime"]!=null && row["news_createtime"].ToString()!="")
				{
					model.news_createtime=DateTime.Parse(row["news_createtime"].ToString());
				}
				if(row["news_posterid"]!=null)
				{
					model.news_posterid=row["news_posterid"].ToString();
				}
                if (row["news_postername"] !=null)
				{
					model.news_postername = row["news_postername"].ToString();
				}
                if (row["news_title"] != null)
                {
                    model.news_title = row["news_title"].ToString();
                }
                if (row["news_class"]!=null)
				{
					model.news_class=row["news_class"].ToString();
				}
				if(row["news_abstract"]!=null)
				{
					model.news_abstract=row["news_abstract"].ToString();
				}
				if(row["news_content"]!=null)
				{
					model.news_content=row["news_content"].ToString();
				}
				if(row["news_readnum"]!=null && row["news_readnum"].ToString()!="")
				{
					model.news_readnum=int.Parse(row["news_readnum"].ToString());
				}
				if(row["news_state"]!=null && row["news_state"].ToString()!="")
				{
					model.news_state=int.Parse(row["news_state"].ToString());
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
			strSql.Append("select news_id,news_createtime,news_posterid,news_postername,news_title,news_class,news_abstract,news_content,news_readnum,news_state ");
			strSql.Append(" FROM news ");
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
			strSql.Append(" news_id,news_createtime,news_posterid,news_postername,news_postername,news_title,news_class,news_abstract,news_content,news_readnum,news_state ");
			strSql.Append(" FROM news ");
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
			strSql.Append("select count(1) FROM news ");
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
				strSql.Append("order by T.news_id desc");
			}
			strSql.Append(")AS Row, T.*  from news T ");
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
			parameters[0].Value = "news";
			parameters[1].Value = "news_id";
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

