using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LablePrintProject.appWindows
{
    /// <summary>
    /// ucUsersManage.xaml 的交互逻辑
    /// </summary>
    public partial class ucPrintNomal : UserControl
    {
        public ucPrintNomal()
        {
            InitializeComponent();
            binData();
        }

        private void binData()
        {
            List<object> objList = new List<object>();
            for (int i = 0; i < 200; i += 1)
            {
                objList.Add(new
                {
                    ID = "编号" + i.ToString()   //编号
                    ,
                    PackageName = "包名称" + i.ToString() //包名称
                    ,
                    PrintedCount = "打印数量" + i.ToString()    //打印数量
                    ,
                    SterilizeDate = "灭菌日期" + i.ToString()   //灭菌日期
                    ,
                    FailDate = "失效日期" + i.ToString()    //失效日期
                    ,
                    SterilizeType = "灭菌类型" + i.ToString()   //灭菌类型
                    ,
                    LotNO = "锅号锅次" + i.ToString()   //锅号锅次
                    ,
                    PackEr = "包装人" + i.ToString()  //包装人
                    ,
                    CheckEr = "检查人" + i.ToString() //检查人
                    ,
                    else1 = "else" + i.ToString() //
                    ,
                    else2 = "else" + i.ToString() //
                    ,
                    else3 = "else" + i.ToString() //   
                });
            }
            dataGrid1.ItemsSource = objList;
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbSelectedAll_Checked(object sender, RoutedEventArgs e)
        {
            this.dataGrid1.SelectAll();
        }

        /// <summary>
        /// 全不选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbSelectedAll_Unchecked(object sender, RoutedEventArgs e)
        {
            this.dataGrid1.UnselectAll();
        }
    }
}
