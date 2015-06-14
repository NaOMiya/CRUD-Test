using System;
using System.Globalization;

namespace Crud.Business
{

    //------------------------------------------------------------------------------------------
    /// <summary>
    /// 共通項目クラス
    /// </summary>
    //------------------------------------------------------------------------------------------
    public class CommonFunctions
    {

        //--------------------------------------------------------------------------------------
        /// <summary>
        /// コンストラクタ
        /// </summary>
        //--------------------------------------------------------------------------------------
        public CommonFunctions()
        {

        }

        //--------------------------------------------------------------------------------------
        /// <summary>
        /// 西暦→和暦変換
        /// </summary>
        /// <returns>和暦を返す</returns>
        //--------------------------------------------------------------------------------------
        public DateTime JCalender(string time)
        {
            //日本の暦を取得
            //CultureInfoインスタンスを生成
            CultureInfo cInfo = new CultureInfo("ja-JP", true);
            //和暦を西暦に変換
            cInfo.DateTimeFormat.Calendar = new JapaneseCalendar();

            //startDaysとlastDaysを、DateTime型に変換
            DateTime days = DateTime.ParseExact(time, "ggyy年MM月dd日 h:mm:ss", cInfo);
            return days;
           
        }
    }
}
