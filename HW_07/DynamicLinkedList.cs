//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CsharpTest.HW_07
//{
//    class Node
//    {
//        public int Data { get; set; }
//        public Node Next { get; set; }
//        private int _size;
//    }

//    public class DynamicLinkedList
//    {
//        private Node _head;
//        private Node _tail;

//        // 新增一筆資料value到容器中
//        public void Add(int value)
//        {
//            Node newNode = new Node();
//            newNode.Data = value;
//            newNode.Next = null;
//            if (_head == null)
//            {
//                // 如果是第一個節點
//                _head = newNode;
//                _tail = newNode;
//            }
//            else
//            {
//                // 如果已經有節點存在
//                _tail.Next = newNode; // 將新節點連接到目前的尾端
//                _tail = newNode;      // 更新尾節點為新節點
//            }

//            // 先new一個Node存放新資料

//            // 將此新Node串到現有串列中（提示：要判斷當前是否是第一個Node）
//        }

//        // 輸入一筆資料值，檢查該資料是否存在於容器內，有的話則移除
//        public void Remove(int value)
//        {
//            Node find = _head;
//            Node prev = _head;
//            while (find != null)
//            {
//                if (find.Data == value)
//                {
//                    prev.Next = find.Next;
//                    break;
//                }
//                else
//                {
//                    prev = find;
//                    find = find.Next;
//                }


//            }
//        }

//        public int Get(int i)
//        {
//            if (i < 0)
//            {
//                throw new Exception("索引不能小於 0！");
//            }
//            Node current = _head;
//            int index = 0;
//            while (current != null)
//            {
//                if (index == i)
//                {
//                    return current.Data; // 找到目標節點，回傳資料
//                }

//                current = current.Next;
//                index++;
//            }
//            throw new Exception("Index 超出容器範圍了！");
//            // 查詢容器中index = i的資料（提示：LinkedList不像陣列可以用[]存取）
//            // 也要檢查此 index是否在容器合法的存取範圍內，如果不合法，則拋出Exception("Index 超出容器範圍了！")
//        }

//        // 回傳當前容器有多少筆有效資料
//        public int Size()
//        {
//            return _size;

//        }

//        // 將容器內所有元素形成一個string，如 1 -> 2 -> 3 -> 4 -> 5 -> null => "1 2 3 4 5"
//        public string ToString()
//        {

//        }
//    }
//}
