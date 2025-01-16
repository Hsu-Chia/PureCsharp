using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicLinkedList_1
{

    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }

    public class DynamicLinkedList
    {
        private Node _head;
        private Node _tail;

        // 新增一筆資料value到容器中
        public void Add(int value)
        {
            // 先new一個Node存放新資料
            Node newNode = new Node();//看wilson資料寫出來的

            // 將此新Node串到現有串列中（提示：要判斷當前是否是第一個Node）
            //要判斷是否為第一個應該要判斷是否為_head?
            if (_head == null)                     //可是_head要怎麼判斷呢?是要參考刪除元素的部分嗎?//if (_head == _tail)原本是長這樣但出錯了直接溢位
            {
                newNode.Data = value;
                newNode.Next = null;
                _head = newNode;
                _tail = newNode;

            }                    //head是賦予給第一個的
            else
            {
                newNode.Data = value;
                newNode.Next = null;
                _tail.Next = newNode;
                _tail = newNode;
            }
        }

        // 輸入一筆資料值，檢查該資料是否存在於容器內，有的話則移除
        public void Remove(int value)//用wilson寫法
        {
            Node find = _head;
            Node prev = _head;
            while (find != null)
            {
                if (find.Data == value)
                {
                    prev.Next = find.Next;
                    break;
                }
                else
                {
                    prev = find;
                    find = find.Next;
                }
            }

        }

        public int Get(int i)
        {
            if (i < 0 || i >= Size())//突然想到可以用size()
            {
                throw new Exception("Index 超出容器範圍了！");
            }
            Node traversal = _head;
            for (int j = 0; j < i; j++)
            {

                traversal = traversal.Next;
            }
            return traversal.Data;


            // 查詢容器中index = i的資料（提示：LinkedList不像陣列可以用[]存取）
            //該怎麼查詢容器中的資料呢? 感覺也是用find去找，但是get這項功能指的是抓取第幾位的數字
            //不太像是輸入數字找出有沒有在裡面
            // 也要檢查此 index是否在容器合法的存取範圍內，如果不合法，則拋出Exception("Index 超出容器範圍了！")
        }

        // 回傳當前容器有多少筆有效資料
        public int Size() //感覺應該要用count的?
        {
            int count = 0;
            Node traversal = _head;
            while (traversal != null)
            {
                traversal = traversal.Next;
                count++;
            }

            return count;


        }

        // 將容器內所有元素形成一個string，如 1 -> 2 -> 3 -> 4 -> 5 -> null => "1 2 3 4 5"
        public string ToString()
        //{
        //    Node traversal = _head; //寫的方法不同，導致輸出有點落差，可能請wilson解答一下
        //    string LinkedList = "";
        //    while (traversal != null)
        //    {
        //        LinkedList += traversal;
        //        traversal = traversal.Next;
        //    }
        //    return LinkedList;

        //}
        {
            Node traversal = _head;
            StringBuilder result = new StringBuilder();

            while (traversal != null)
            {
                result.Append(traversal.Data);
                traversal = traversal.Next;
            }

            return result.ToString();
        }
    }
}
