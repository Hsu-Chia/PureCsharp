using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray_1
{
    public enum OrderType
    {
        Ascending,
        Descending
    }

    // 此容器設計將所有有效資料都放在_data陣列前面，並用_nextIndex紀錄有效資料後下一筆新資料會被放置的index
    // 假設_data = [1, 2, 3, 0, 0]其中有效資料是1,2,3，則_nextIndex會是3
    public class DynamicArray//要搞清楚這兩個參數是在幹嘛的_nextIndex：用於操作有效資料時（例如新增資料、遍歷有效資料）。*_data.Length 用於操作整個陣列時（例如擴充容量、複製所有元素）。
    {
        private int[] _data;          // 實際存放資料的陣列
        private int _nextIndex = 0;   // 下一筆新資料要放的index

        public DynamicArray()
        {
            _data = new int[5]; // 初始化 _data的容量為5個//原本寫 int[]_data = new int [5];但似乎這是錯誤的初始化 //* 因為這是成員變數，執行完就會消毀掉?反而原本的_data還是null
        }

        // 新增一筆資料value到容器中
        public void Add(int value)
        /*第一步思考，現在有下面兩個功能要實施，我到底應該要先做if還是先做add，似乎都可以，但要檢查當前空間是否夠要用甚麼程式碼?要怎麼比較呢?
         要使用_data.length先知道_data資料數量，要怎麼讓目前添加次數加到__nextIndex之中呢? 要用for迴圈嗎?*/
        {

            if (_data.Length <= _nextIndex)//假設輸入次數大於length可以Resize//System.NullReferenceException: 'Object reference not set to an instance of an object.' 出現未初始化的錯誤
            {
                Resize();
            }
            _data[_nextIndex] = value;//看Wilson教學解出來//出現溢位的問題，可能是Resize那邊有狀況
            _nextIndex++;
            //要把新資料加入容器中要怎麼加呢?

            // 先檢查當前可用空間是否足夠，不夠則需要先呼叫Resize()擴充容量 /*發現可以加入Resize()*/

            // 將新資料加入到容器中
        }

        private void Resize()
        {
            int[] newData = new int[_data.Length * 2];//原本是想寫 int[] _data = new int[_data.Length*2] 但跳錯，似乎是_data這樣會被覆蓋，感覺是我對於data的東西不夠熟悉?
            for (int i = 0; i < _data.Length; i++)//要把資料搬到新的陣列//有點困惑到底該用_data.length還是_next
            {
                newData[i] = _data[i];

            }

            _data = newData;//更新成員參數?可是上面不是已經算更新了嗎?//***雖然資料已經複製到 newData，但若不更新 _data，其他方法依然使用舊的 _data，這樣新增資料時會導致越界錯誤。
            // 將原陣列的容量擴充成2倍，並把舊資料全部搬到新陣列中
        }

        public void Remove(int value)//檢查該資料是不是應該用for迴圈?這時候是不是應該使用nextindex?可是nextindex這裡扮的腳色為何，因為前面_nextIndex都會加加，所以可以?
        {
            for (int i = 0; i < _nextIndex; i++)//在remove的時候應該針對_nextIndex為主? 因為那個才是有效的數字?
            {
                if (_data[i] == value)//Remove這裡出現溢位的狀況
                {
                    for (int j = i; j < _nextIndex - 1; j++)//這段程式碼是替代數字用的，用_data.Length - 1，因為不能到最後一位，這樣會溢位因為沒有最後一位的下一位
                                                            //這句變的怪怪的//最後解法發現還是要以_nextIndex為主，然後在if那邊判斷_data[i]是否為那個數字
                    {
                        _data[j] = _data[j + 1];

                    }
                    //但通常最後一位也是需要處理，這裡就賦予0
                    int lastIndex = _data.Length - 1;//但這邊就很吃_data.Length的操作，如果沒有清楚_data.Length此處扮的腳色會亂掉
                    _data[lastIndex] = 0;

                    //*********最後一個地方導致結果不太依樣
                    ///*移動後續的資料，覆蓋掉要刪除的那個元素`。將陣列最後一位設為 0（作為標記），但這一位實際上已經不再是有效資料。透過更新有效資料索引 nextIndex，間接縮減了有效資料的範圍。但陣列還是沒有改變
                    // 更新有效資料索引
                    _nextIndex--;

                    // 只移除第一個匹配的資料，提前退出
                    return;


                }

            }

            // 輸入一筆資料值，檢查該資料是否存在於容器內，有的話則移除，並移動後續元素，維持有效資料都在容器的前面
        }

        // 查詢容器中index = i的資料
        public int Get(int i)//存取範圍是甚麼?除了不能小於0，也不能超過陣列中的範圍，陣列範圍似乎只能用_nextIndex因為那是唯一有計算次數的? i代表的是提取第幾位，不是在找尋那個數字
        {
            if (i < 0 || i > _nextIndex)
            {
                throw new Exception("Index 超出容器範圍了！");

            }

            return _data[i];

            // 先檢查此 index是否在容器有效的存取範圍內，如果不有效，則拋出Exception("Index 超出容器範圍了！")

            // 回傳目標資料
        }

        // 回傳當前容器有多少筆有效資料
        public int Size()
        {
            return _nextIndex;//不太確定，但應該是這個

        }

        // 使用BubbleSort排序容器內的有效資料，並可以藉由OrderType來指定要由小到大排序或是由大到小排序
        public void Sort(OrderType order = OrderType.Ascending)//現在看起來enum有兩個區分，應該就是看選誰，可以先執行氣泡排序 看wilson教學
        {
            for (int i = 0; i < _nextIndex - 1; i++)//原本想用_data.Length想一想不太對，因為要避免可能空位數字進去?
            {
                for (int j = 0; j < _nextIndex - i - 1; j++)
                {
                    if (order == OrderType.Ascending)
                    {
                        if (_data[j] > _data[j + 1])
                        {
                            int temp = _data[j];
                            _data[j] = _data[j + 1];
                            _data[j + 1] = temp;
                        }
                    }
                    else if (order == OrderType.Descending)
                    {
                        if (_data[j] < _data[j + 1])
                        {
                            int temp = _data[j];
                            _data[j] = _data[j + 1];
                            _data[j + 1] = temp;
                        }


                    }



                }


            }


        }

        // 將容器內所有元素形成一個string，如 {1, 2, 3, 4, 5} => "1 2 3 4 5"
        public string ToString()//我先將array先列好，先建立一個空的string
        {
            string Array = "";
            for (int i = 0; i <= _nextIndex - 1; i++)
            {
                Array += _data[i];

            }

            return Array;//要回一個string回去



        }
    }
}


