using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Crud.Presentation
{
    //-----------------------------------------------------------------------------------------
    /// <summary>
    /// 明細画面クラス
    /// </summary>
    //-----------------------------------------------------------------------------------------
    public partial class FrmDetail : Form
    {
        private int keyId = 0;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataSet dataSet = new DataSet();

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 検索画面から主キーの値を受け取る
        /// </summary>
        /// <param name="key">Carテーブルの主キーの値</param>
        //-------------------------------------------------------------------------------------
        public FrmDetail(int key)
        {
            InitializeComponent();
            //検索フォームから主キーを受け取る
            keyId = key;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// テーブルからデータの出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //-------------------------------------------------------------------------------------
        private void formDetail_Load(object sender, EventArgs e)
        {
            //Carテーブルを取得
            dataAdapter.SelectCommand =  getTableData("SELECT * FROM Car WHERE 自動車ID=" + keyId);
            //データアダプターにセット
            dataAdapter.Fill(dataSet, "Car");
            //データセットの変更を許可
            dataSet.AcceptChanges();
            //データセットとバインド
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Tables["Car"];

            //VehicleClassificationテーブルのデータセット
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = getTableData("SELECT * FROM VehicleClassification");
            da.Fill(dataSet, "VehicleClassification");
            {
                //自動車名
                this.tBoxDetailCar.DataBindings.Add(new Binding("Text", bindingSource, "自動車名", true));
                //車種区分ID             
                this.cBoxVClass.DataBindings.Add(new Binding("SelectedValue", bindingSource, "車種区分ID"));
                //色
                this.tBoxColor.DataBindings.Add(new Binding("Text", bindingSource, "色", true));
                //ナンバー
                this.tBoxNumber.DataBindings.Add(new Binding("Text", bindingSource, "ナンバー", true));
                //分類番号
                this.tBoxNumClass.DataBindings.Add(new Binding("Text", bindingSource, "分類番号", true));
                //車検日
                this.tBoxVInspection.DataBindings.Add(new Binding("Text", bindingSource, "車検日", true));
                
                //TODO:暦変換
                //和暦変換
                CultureInfo culture = new CultureInfo("ja-JP", true);
                culture.DateTimeFormat.Calendar = new JapaneseCalendar();

                DateTime date = DateTime.Parse(dataSet.Tables["Car"].Rows[0]["車検日"].ToString());
                this.tBoxVInspection.Text = date.ToString("ggyy年MM月dd日", culture);

                //使用状況
                this.checkBoxUsed.DataBindings.Add(new Binding("CheckState", bindingSource, "使用状況", true));
                //定員
                this.tBoxCapacity.DataBindings.Add(new Binding("Text", bindingSource, "定員", true));
                //排気量
                this.tBoxDisplacement.DataBindings.Add(new Binding("Text", bindingSource, "排気量", true));

                //車種区分
                BindingSource bindingVC = new BindingSource();
                bindingVC.DataSource = dataSet.Tables["VehicleClassification"];
                
                this.cBoxVClass.DataSource = bindingVC;
                //選択一覧表示
                this.cBoxVClass.DisplayMember = "車種区分";
                //選択される車種区分の裏で渡される値
                this.cBoxVClass.ValueMember = "車種区分ID";
            }

          
            //取得した主キーと走行履歴テーブルの外部キーの値と一致するレコードをすべて取得
            //dTableにRunテーブルのデータを格納
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = getTableData("SELECT 走行日時,総走行距離,給油量,経費 FROM Run WHERE "
                + "自動車ID=" + keyId + "ORDER BY 走行日時 DESC");
            dAdapter.Fill(dataSet, "Run");

            //DataGridViewに自動表示
            dGView.AutoGenerateColumns = true;
            dGView.DataSource = dataSet.Tables["Run"];
            try
            {
                //取得するテーブルの行数が1以上
                if (0 < dataSet.Tables["Run"].Rows.Count)
                {
                    //最新の総走行距離と給油量を変数に格納
                    string runDistance = dataSet.Tables["Run"].Rows[0]["総走行距離"].ToString();
                    string fuel = dataSet.Tables["Run"].Rows[0]["給油量"].ToString();

                    //行数が1つの場合、計算して表示
                    if (dataSet.Tables["Run"].Rows.Count == 1)
                        labelFuelEfficiency.Text = ((int.Parse(runDistance)) / int.Parse(fuel)).ToString();
                        //行数が2以上の場合
                    else if (1 < dataSet.Tables["Run"].Rows.Count)
                    {
                        //最新の総走行距離の一つ前の値を変数に格納
                        string beforeRunDistance = dataSet.Tables["Run"].Rows[1]["総走行距離"].ToString();
                        labelFuelEfficiency.Text = ((int.Parse(runDistance) - int.Parse(beforeRunDistance)) / int.Parse(fuel)).ToString();
                    }
                }else
                    //取得するテー物の行数が0以下
                    labelFuelEfficiency.Text = "0";
            }
            catch (FormatException)
            {
                //変数の書式がおかしい場合
                labelFuelEfficiency.Text = "0";
            }
            //TODO:if文の連続
            //取得したレコードから、排気量フィールドの値を取得
            //普通車の場合
            try
            {
                int carTax = int.Parse(tBoxDisplacement.Text);

                if (cBoxVClass.Text.TrimEnd() == "普通車")
                {
                    //値（x）<=1000ccの場合、29,500円
                    if (carTax <= 1000)
                        labelVTax.Text = "29,500";
                    else if (1000 < carTax && carTax <= 1500)
                        //1000cc < x <= 1500cc の場合、34,500円
                        labelVTax.Text = "34,500";
                    else if (1500 < carTax && carTax <= 2000)
                        //1500cc < x <= 2000cc の場合、39,500円
                        labelVTax.Text = "39,500";
                    else if (2000 < carTax && carTax <= 2500)
                        //2000cc < x <= 2500cc の場合、45,000円
                        labelVTax.Text = "45,000";
                    else if (2500 < carTax && carTax <= 3000)
                        //2500cc < x <= 3000cc の場合、51,000円
                        labelVTax.Text = "51,000";
                    else if (3000 < carTax && carTax <= 3500)
                        //3000cc < x <= 3500cc の場合、58,000円
                        labelVTax.Text = "58,000";
                    else if (3500 < carTax && carTax <= 4000)
                        //3500cc < x <= 4000cc の場合、66,500円
                        labelVTax.Text = "66,500";
                    else if (4000 < carTax && carTax <= 4500)
                        //4000cc < x <= 4500cc の場合、76,500円
                        labelVTax.Text = "76,500";
                    else if (4500 < carTax && carTax <= 6000)
                        //4500cc < x <= 6000cc の場合、88,000円
                        labelVTax.Text = "88,000";
                    else//6000cc < x の場合、111,000円                          
                        labelVTax.Text = "111,000";
                }
                else//軽自動車の場合
                {
                    //分類番号の値を変数(y)に格納
                    int smallCarTax = int.Parse(tBoxNumClass.Text);
                    //50 <= y < 60 500 <= y < 600 (5ナンバー)の場合、7,200円
                    if ((50 <= smallCarTax && smallCarTax < 60) || (500 <= smallCarTax && smallCarTax < 600))
                        labelVTax.Text = "7,200";
                    else //50 <= y < 60 500 <= y < 600 (5ナンバー)の場合、7,200円                
                        labelVTax.Text = "4,000";
                }
            }
            catch (FormatException)
            {
                //変数の書式がおかしい場合
                labelVTax.Text = "0";
            }              
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// データベースとコネクションを取り、コマンドをを返す
        /// </summary>
        /// <param name="sqlTemp"></param>
        //-------------------------------------------------------------------------------------
        private SqlCommand getTableData(string sqlTemp)
        {
            //TODO:Connection取得処理
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
                sqlCom.CommandText = sqlTemp;
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
        /// データベース更新処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //-------------------------------------------------------------------------------------
        private void buttonRenewal_Click(object sender, EventArgs e)
        {
            //更新するテーブルをDataSetに読み込む
            //DataTableオブジェクトからDataRowで各レコードを参照可能な状態にする
            getRenewalDTable("SELECT * FROM Car WHERE 自動車ID=" + keyId);
            
           
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// データベースの更新
        /// </summary>
        /// <param name="sqlCon"></param>
        //-------------------------------------------------------------------------------------
        private void getRenewalDTable(string sqlCon)
        {
            string connectionString = string.Empty;
            connectionString += "Data Source         = localhost;";
            connectionString += "Initial Catalog     = SampleDB;";
            connectionString += "Integrated Security = false;";
            connectionString += "User ID             = sa;";
            connectionString += "Password            = chiiki";

            try
            {
                ///データベースと接続するためにSqlDataAdapterインスタンスを生成
                //dataAdapter.SelectCommand = getTableData(sqlCon);
                //dataSet.Clear();
                //dataAdapter.Fill(dataSet, "Car");

                DataTable dataTable = new DataTable();
                dataTable = dataSet.Tables["Car"];

                //DataTableオブジェクトに主キーとなるカラムを設定
                dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["自動車ID"] };
                //主キーとなるカラムの値からレコードを取得（主キー=keyId）
                DataRow targetRow;
                targetRow = dataTable.Rows.Find(keyId);
                targetRow["自動車名"] = tBoxDetailCar.Text;
                //データを更新する行に値を代入
                targetRow["ナンバー"] = tBoxNumber.Text;
                targetRow["色"] = tBoxColor.Text;
                targetRow["車検日"] = tBoxVInspection.Text;
                targetRow["使用状況"] = checkBoxUsed.Checked;

                //更新データをデータベースに反映
                SqlCommandBuilder sqlCBuilder = new SqlCommandBuilder(dataAdapter);
                //dataAdapter.UpdateCommand = getTableData("UPDATE Car SET 色 = " + "'" + tBoxColor.Text + "'" + " WHERE 自動車ID=" + keyId);
                dataAdapter.Update(dataSet, "Car");
               
            }
            catch (SqlException)
            {
                MessageBox.Show("失敗");
            }
            
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
            //明細画面を閉じる
            this.Close();
        }

       
    }
}
