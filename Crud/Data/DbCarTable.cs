using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Crud.Business;
using System.Data;
using System.Data.SqlClient;

namespace Crud.Data
{

    //------------------------------------------------------------------------------------------
    /// <summary>
    /// Carテーブル処理クラス
    /// </summary>
    //------------------------------------------------------------------------------------------
    public class DbCarTable:DbConnection
    {
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        //--------------------------------------------------------------------------------------
        /// <summary>
        /// コンストラクタ
        /// </summary>
        //--------------------------------------------------------------------------------------
        public DbCarTable()
        {
        }

        //--------------------------------------------------------------------------------------
        /// <summary>
        /// FrmSearchクラスのDataGridViewに表示するデータを取得する
        /// </summary>
        /// <param name="comp"></param>
        //--------------------------------------------------------------------------------------
        public DataTable SelectCarJoinVc(List<String> comp)
        {
            //検索ボタンを押下すると、SQL文をgetDataメソッドに発行
            //固定であるSQL文"SELECT * FROM Carを変数に格納
            string sqlSentence = "SELECT * FROM Car LEFT JOIN CarClass ON " + "Car." + "車種区分ID" + "=" + "CarClass." + "車種区分ID";
            //必要に応じて使用するSQL文"WHERE" "AND"も変数に格納
            string sqlW = " WHERE ";

            //carNameが空でない場合
            if (comp[0]!= "")
            {
                //固定SQL文にWHERE変数を連結(+=)
                sqlSentence += sqlW + "自動車名=" + "'" + comp[0] + "'";
                sqlW = " AND ";
            }

            //CarClassが空でない場合
            if (comp[1] != "")
            {
                //固定SQL文にWHERE変数を連結
                sqlSentence += sqlW + "車種区分=" + "'" + comp[1] + "'";
                sqlW = " AND ";
            }

            //numClassが空でない場合
            if (comp[2] != "")
            {
                sqlSentence += sqlW + "分類番号=" + "'" + comp[2] + "'";
                sqlW = " AND ";
            }

            //numberが空でない場合
            if (comp[3] != "")
            {
                sqlSentence += sqlW + "ナンバー=" + "'" + comp[3] + "'";
                sqlW = " AND ";
            }

            //colorが空でない場合
            if (comp[4] != "")
            {
                sqlSentence += sqlW + "色=" + "'" + comp[4] + "'";
                sqlW = " AND ";
            }

            //usedが"使用中"=>チェックが入っている=>データベーステーブルの値はtrue
            //テーブルの型はbit型=>True Falseで入っている=>1 or 0
            if (comp[5] == "未使用")
            {
                sqlSentence += sqlW + "使用状況=0";
                sqlW = " AND ";
            }
            else if (comp[5] == "使用中")
            {
                sqlSentence += sqlW + "使用状況=1";
                sqlW = " AND ";
            }

            //capacityが空でない場合
            if (comp[6] != "")
            {
                sqlSentence += sqlW + "定員=" + "'" + comp[6] + "'";
                sqlW = " AND ";
            }

            //TODO:startYear lastYearを入力すると、検索可能にする
            //startY,startM,startD,lastY,lastM,lastDが空でない場合
            if (comp[7] != "" && comp[8] != "" && comp[9] != "" && comp[10] != ""
                    && comp[11] != "" && comp[12] != "")
            {
                //start変数とlast変数をそれぞれ連結               
                string startDays = comp[7] + comp[8] + "月" + comp[9] +"日 0:00:00";
                string lastDays = comp[10] + comp[11] + "月" + comp[12] + "日 0:00:00";

                //暦変換
                CommonFunctions cFunctions = new CommonFunctions();
                DateTime start = cFunctions.JCalender(startDays);
                DateTime last = cFunctions.JCalender(lastDays);

                sqlSentence += sqlW + "車検日>=" + "'" + startDays + "'" +
                    " AND " + "車検日<=" + "'" + lastDays + "'";
            }
            return setCarTable(Connection(sqlSentence));          
        }

        /// <summary>
        /// 
        /// </summary>
        public DataTable SelectCar(int id)
        {
            string sql = "SELECT * FROM Car";
            string sqlCondition = "WHERE";
            if (id != 0)
                sql += sqlCondition + "自動車ID=" + id;
            return setCarTable(Connection(sql));
        }

        //----------------------------------------------------------------------
        /// <summary>
        /// テーブルをセット
        /// </summary>
        /// <param name="command">SQL文</param>
        /// <returns>Carテーブルのデータセットを返す</returns>
        //----------------------------------------------------------------------
        private DataTable setCarTable(SqlCommand command)
        {
            
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "Car");

            DataTable dataTable = dataSet.Tables["Car"];
            return dataTable;
        }

        //----------------------------------------------------------------------
        /// <summary>
        /// dataGridViewにて選択された行を削除
        /// </summary>
        //----------------------------------------------------------------------
        public void DeleteRow(int id)
        {
            dataSet.Clear();
            //データテーブルをセット
            DataTable dTable = SelectCar(0);
            //取得したテーブルの主キーを指定
            dTable.PrimaryKey = new DataColumn[] { dTable.Columns["自動車ID"] };
            //特定の行を指定して削除
            DataRow targetRow;
            targetRow = dTable.Rows.Find(id);
            targetRow.Delete();

            //DELETE文の自動生成
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataSet,"Car");
        }
    }
}
