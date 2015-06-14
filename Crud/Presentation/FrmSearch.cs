using Crud.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;


namespace Crud.Presentation
{
    //-----------------------------------------------------------------------------------------
    /// <summary>
    /// 検索画面クラス
    /// </summary>
    //-----------------------------------------------------------------------------------------
    public partial class FrmSearch : Form
    {
        private DbCarTable dbCar = new DbCarTable(); 
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 検索画面
        /// </summary>
        //-------------------------------------------------------------------------------------
        public FrmSearch()
        {
            InitializeComponent();
            //TODO:NullReferenceException
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = dbCar.SelectCarJoinVc(null);
            //dataGridView1.DataMember = "Car";
           
        }

        /// <summary>
        /// フォーム生成時に、dataGridViewにデータを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = dbCar.SelectCarJoinVc(null);
            //dataGridView1.DataMember = "Car";
            
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 検索ボタンを押下した際のイベント
        /// テキストボックスに入っている値を取得して、SQL文を発行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //-------------------------------------------------------------------------------------
        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<String> compornent = new List<String>();
            compornent.Add(tBoxCarName.Text);
            compornent.Add(cBoxCClass.Text);
            compornent.Add(tBoxNumClass.Text);
            compornent.Add(tBoxNumber.Text);
            compornent.Add(tBoxColor.Text);
            compornent.Add(cBoxUsed.Text);
            compornent.Add(tBoxCapacity.Text);
            compornent.Add(cBoxStartYear.Text);
            compornent.Add(cBoxStartMonth.Text);
            compornent.Add(cBoxStartDay.Text);
            compornent.Add(cBoxLastYear.Text);
            compornent.Add(cBoxLastMonth.Text);
            compornent.Add(cBoxLastDay.Text);
            
            //Carテーブルの検索
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dbCar.SelectCarJoinVc(compornent); 
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 選択されたDataGridViewの行を削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //-------------------------------------------------------------------------------------
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //使用中かどうかの判定
                bool decision = (bool)dataGridView1.CurrentRow.Cells[9].Value;
                //取得した値=1の場合
                if (decision == true)
                    //選択された行が使用中の車の場合、「使用中のため削除できません」Dialogの表示
                    MessageBox.Show("使用中のため、削除できません。明細画面で使用状況を変更してください。");
                else
                {
                    //取得した値=0の場合
                    //「このデータを削除しますか？」Dialogの表示
                    DialogResult dResult = MessageBox.Show("本当に削除しますか?"
                                                            , "削除", MessageBoxButtons.OKCancel);
                    if (dResult == System.Windows.Forms.DialogResult.OK)
                    {
                        //「はい」をクリックされたら削除
                        deleteDataTable();
                    }
                    else if (dResult == System.Windows.Forms.DialogResult.Cancel)
                        //「いいえ」をクリックされたら何もしない
                        MessageBox.Show("削除をキャンセルしました。");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("データを選択してください。");
            }
        }

        //--------------------------------------------------------------------------------------
        /// <summary>
        /// 選択されたレコードの削除処理
        /// </summary>
        /// <param name="sqlcon">Carテーブルを取得</param>
        //--------------------------------------------------------------------------------------
        private void deleteDataTable()
        {
            //DataGridViewの選択されている行の主キーを取得
            int dGViewCarId = (Int32)dataGridView1.CurrentRow.Cells[0].Value;
            //選択された行の削除
            dbCar.DeleteRow(dGViewCarId);            
        }

        //------------------------------------------------------------------------------------
        /// <summary>
        /// 明細画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //------------------------------------------------------------------------------------
        private void detailbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //DataGridViewで選択されている行を取得
                DataGridViewRow dGridRow = this.dataGridView1.CurrentRow;

                //行を取得したら、明細画面に行の主キーを変数に格納する
                int id = (int)dGridRow.Cells[0].Value;

                ////明細画面に遷移する
                ////明細画面インスタンスを生成する
                FrmDetail detail = new FrmDetail(id);
                detail.Show();
            }catch(NullReferenceException){
                MessageBox.Show("詳細を表示したいレコードを選択してください。");
            }
            
        }

        //-----------------------------------------------------------------------------------
        /// <summary>
        /// 追加画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //-----------------------------------------------------------------------------------
        private void addbtn_Click(object sender, EventArgs e)
        {
            FrmRegister register;
            try
            {
                //DataGridViewで選択されている行を取得
                DataGridViewRow dgRow = this.dataGridView1.CurrentRow;
                //主キーの値を変数に格納
                int primaryId = (int)dgRow.Cells[0].Value;

                //追加画面に遷移する
                register = new FrmRegister(primaryId);
                register.Show();
            }
            catch (NullReferenceException)
            {
                //行が選択されていない場合は、値を渡さずに遷移する
                register = new FrmRegister(0);
                register.ShowDialog();
            }
        }
    }
}
