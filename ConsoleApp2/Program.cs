using System;
using System.Security.Cryptography.X509Certificates;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode a = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode b = new ListNode(5, new ListNode(6, new ListNode(4, null)));
            ListNode c;
            Program d = new Program();
            c = d.AddTwoNumbers(a, b);
            while (c != null)
            {
                Console.WriteLine(c.val);
                c = c.next;
            }
        }
    
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                    this.val = val;
                    this.next = next;
            }
        }
        //bool des = false;
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode temp = result;
            int des = 0;
            while (l1 != null || l2 != null)
            {
                int x = l1.val + l2.val+des;
                des = x / 10;
                temp.next = new ListNode(x % 10, null);
                temp = temp.next;
                if(l1.next != null || l2.next != null)
                {
                    l1 = l1.next ?? new ListNode(0, null);
                    l2 = l2.next ?? new ListNode(0, null);
                }
                else
                {
                    l1 = null;
                    l2 = null;
                }
            }
            if(des>0)
            {
                temp.next = new ListNode(1, null);
            }
            return result.next;
        }
    }
}
