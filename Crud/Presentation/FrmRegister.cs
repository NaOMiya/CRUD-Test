using Crud.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Crud.Presentation
{

    //-----------------------------------------------------------------------------------------
    /// <summary>
    /// 追加登録画面
    /// </summary>
    //-----------------------------------------------------------------------------------------
    public partial class FrmRegister : Form
    {
        private int primaryKeyId = 0;
        //DataTableオブジェクトを作成
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        //DataSetオブジェクトを作成
        private DataSet dSet = new DataSet();
        private DbCarTable carTable = new DbCarTable();

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 変数の初期化
        /// </summary>
        /// <param name="id">検索画面で選択された行の主キーの値</param>
        //-------------------------------------------------------------------------------------
        public FrmRegister(int id)
        {
            InitializeComponent();
            primaryKeyId = id;

        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 検索画面で行が選択されている場合、データを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //-------------------------------------------------------------------------------------
        private void Register_Load(object sender, EventArgs e)
        {
            if (primaryKeyId != 0)
            {
                ////primaryKeyIdの値を持ったレコードをCarテーブルから呼び出す
                //dataAdapter.SelectCommand = getTable("SELECT * FROM Car WHERE 自動車ID="
                //                                                                   + primaryKeyId);
                ////データアダプターにセット
                //dataAdapter.Fill(dSet, "Car");

                //Carテーブルのデータセットとコントロールをバインド
                DataTable dataTable = carTable.SelectCar(primaryKeyId);
                dataTable.AcceptChanges();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                //CarClassテーブルのデータセット
                dataAdapter.SelectCommand = getTable("SELECT * FROM CarClass");
                dataAdapter.Fill(dSet, "CarClass");
                {
                    //自動車名
                    this.tBoxCar.DataBindings.Add(new Binding("Text", bindingSource, "自動車名", true));
                    ////車種区分
                    BindingSource bindingVC = new BindingSource();
                    bindingVC.DataSource = dSet.Tables["CarClass"];
                    //色
                    this.tBoxColor.DataBindings.Add(new Binding("Text", bindingSource, "色", true));
                    //分類番号
                    this.tBoxNumClass.DataBindings.Add(new Binding("Text", bindingSource, "分類番号", true));
                    //ナンバー
                    this.tBoxNumber.DataBindings.Add(new Binding("Text", bindingSource, "ナンバー", true));
                    //定員
                    this.tBoxCapacity.DataBindings.Add(new Binding("Text", bindingSource, "定員", true));
                    //車検日
                    this.tBoxInspection.DataBindings.Add(new Binding("Text", bindingSource, "車検日", true));
                    //排気量
                    this.tBoxDisplacement.DataBindings.Add(new Binding("Text", bindingSource, "排気量", true));
                    //使用状況
                    this.checkBoxUsed.DataBindings.Add(new Binding("CheckState", bindingSource, "使用状況", true));
                    //車種区分ID
                    //CarClassテーブルのデータとバインド
                    this.cBoxCarClass.DataSource = bindingVC;
                    //選択一覧の表示
                    this.cBoxCarClass.DisplayMember = "車種区分";
                    //裏で渡される値
                    this.cBoxCarClass.ValueMember = "車種区分ID";

                    this.cBoxCarClass.DataBindings.Add(new Binding("SelectedValue", bindingSource, "車種区分ID"));
                }
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 入力されたデータをCarテーブルに登録する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //-------------------------------------------------------------------------------------
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //primaryKeyIdが0の場合は、CarとRunテーブルを追加
            if (primaryKeyId == 0)
                carTableInsert();
            //primaryKeyIdが0でない場合、Carテーブルをアップデート
            else
                carTableUpdate();
               
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 検索画面でレコードが選択されている場合、Carテーブルをアップデート
        /// </summary>
        //-------------------------------------------------------------------------------------
        private void carTableUpdate()
        {
            //Carテーブルのレコードを取得
            dataAdapter.SelectCommand = getTable("SELECT * FROM Car");
            dataAdapter.Fill(dSet, "UpdateCar");

            DataTable dataTable = dSet.Tables["UpdateCar"];
            //DataTableオブジェクトに主キーとなるカラムを設定
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["自動車ID"] };
            //主キーとなるカラムの値からレコードを取得
            DataRow targetRow;
            targetRow = dataTable.Rows.Find(primaryKeyId);
            //データを更新する行に値を代入
            targetRow["自動車名"] = tBoxCar.Text;
            targetRow["ナンバー"] = tBoxNumber.Text;
            targetRow["色"] = tBoxColor.Text;          
            targetRow["定員"] = tBoxCapacity.Text;
            targetRow["使用状況"] = checkBoxUsed.Checked;
            if (tBoxDisplacement.Text != "")
                targetRow["排気量"] = int.Parse(tBoxDisplacement.Text);
            if (tBoxNumClass.Text != "")
                targetRow["分類番号"] = int.Parse(tBoxNumClass.Text);
            if (cBoxCarClass.Text == "普通車")
                targetRow["車種区分ID"] = 1;
            else
                targetRow["車種区分ID"] = 2;
            targetRow["車検日"] = tBoxInspection.Text;
       
            //更新データをデータベースに反映
            SqlCommandBuilder sqlCBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dSet, "UpdateCar");
            //続けてRunテーブルを更新
            runTableUpdate();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// CarテーブルとRunテーブルに追加
        /// </summary>
        //-------------------------------------------------------------------------------------
        private void carTableInsert()
        {
                //Carテーブルの呼び出し          
                dataAdapter.SelectCommand = getTable("SELECT * FROM Car");
                //データアダプターにセット
                dataAdapter.Fill(dSet, "Car");             
                DataTable dTable = dSet.Tables["Car"];

                //新しいデータを作成
                DataRow newRow = dTable.NewRow();
                //自動車名
                newRow["自動車名"] = tBoxCar.Text;
                //使用状況
                newRow["使用状況"] = checkBoxUsed.Checked;
                //車検日
                if (tBoxInspection.Text != "")
                    newRow["車検日"] = tBoxInspection.Text;
                //車種区分ID
                if (cBoxCarClass.Text == "普通車")
                    newRow["車種区分ID"] = 1;
                else
                    newRow["車種区分ID"] = 2;
                //分類番号
                if (tBoxNumClass.Text != "")
                    newRow["分類番号"] = int.Parse(tBoxNumClass.Text);
                //ナンバー
                if (tBoxNumber.Text != "")
                    newRow["ナンバー"] = tBoxNumber.Text;
                //色
                if (tBoxColor.Text != "")
                    newRow["色"] = tBoxColor.Text;
                //定員
                if (tBoxCapacity.Text != "")
                    newRow["定員"] = tBoxCapacity.Text;
                //排気量
                if (tBoxDisplacement.Text != "")
                    newRow["排気量"] = int.Parse(tBoxDisplacement.Text);
                //レコードの追加
                dTable.Rows.Add(newRow);
                
                SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dSet, "Car");
                runTableInsert();
            
                      
            
        }

        //-------------------------------------------------------------------------------
        /// <summary>
        /// Carテーブルをアップデートする際に実行
        /// </summary>
        //-------------------------------------------------------------------------------
        private void runTableUpdate()
        {
            try
            {
                //dataTableをセット
                dataAdapter.Fill(dSet, "UpdateCarTable");
                DataTable dataTable = dSet.Tables["UpdateCarTable"];

                //Runテーブルの呼び出し
                dataAdapter.SelectCommand = getTable("SELECT * FROM Run");
                dataAdapter.Fill(dSet, "RunTable");
                dataTable = dSet.Tables["RunTable"];

                //Runテーブルの外部キーにprimaryKeyIdを代入
                DataRow updateRow = dataTable.NewRow();
                updateRow["自動車ID"] = primaryKeyId;

                //各データにテキストボックスの値を出力
                updateRow["総走行距離"] = tBoxRunDistance.Text;
                updateRow["走行日時"] = tBoxRunTime.Text;
                updateRow["給油量"] = tBoxFuel.Text;
                updateRow["経費"] = tBoxMoney.Text;

                //Runテーブルに追加
                dataTable.Rows.Add(updateRow);

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dSet, "RunTable");
            }
            catch (ArgumentException)
            {

            }
        }

        //-------------------------------------------------------------------------------
        /// <summary>
        /// Runテーブルに走行履歴等を追加登録
        /// </summary>
        //-------------------------------------------------------------------------------
        private void runTableInsert()
        {
            //dataAdapter,dataTableをもう一度セット
            dataAdapter.Fill(dSet, "Update");
            DataTable dTable = dSet.Tables["Update"];

            //新しいcarテーブルの主キーの値を取得
            int carRowsCount = dTable.Rows.Count - 1;
            int primary = (Int32)dTable.Rows[carRowsCount]["自動車ID"];
            dataAdapter.SelectCommand = getTable("SELECT * FROM Run");
            dataAdapter.Fill(dSet, "Run");
            dTable = dSet.Tables["Run"];
            //Carテーブルの新しい主キーを取得し、Runテーブルの外部キー（自動車ID）に代入
            DataRow newRunRow = dTable.NewRow();
            newRunRow["自動車ID"] = primary;
            //Runテーブルのその他のカラムはNull
            dTable.Rows.Add(newRunRow);

            //CarとRunテーブルをそれぞれ更新
            SqlCommandBuilder sqlCBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dSet, "Run");

        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// データベースとコネクションを確立
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>SqlDataAdapter</returns>
        //-------------------------------------------------------------------------------------
        private SqlCommand getTable(string sql)
        {
            string connectionString = string.Empty;
            connectionString += "Data Source         = localhost;";
            connectionString += "Initial Catalog     = SampleDB;";
            connectionString += "Integrated Security = false;";
            connectionString += "User ID             = sa;";
            connectionString += "Password            = chiiki";

            try
            {
                //データベースと接続するためにSqlDataAdapterインスタンスを生成
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connectionString;

                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = conn;
                sqlCom.CommandText = sql;
                return sqlCom;

            }
            catch (SqlException)
            {
                MessageBox.Show("失敗");
            }
            throw new NotImplementedException();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 検索画面に戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //-------------------------------------------------------------------------------------
        private void buttonBack_Click(object sender, EventArgs e)
        {
            //登録画面を閉じる
            this.Dispose();
        }

        
    }
}
