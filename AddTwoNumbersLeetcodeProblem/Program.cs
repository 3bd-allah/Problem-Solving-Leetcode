using System.Xml.XPath;

namespace AddTwoNumbersLeetcodeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ListNode node3 = new ListNode(3);
            //ListNode node2 = new ListNode(4, node3);
            //ListNode node1 = new ListNode(2, node2);

            //ListNode node4 = new ListNode(4);
            //ListNode node6 = new ListNode(6, node4  );
            //ListNode node5 = new ListNode(5, node6);

            //int lValue =GetValue(node1), rValue= GetValue(node5);

            //string sum = (lValue + rValue).ToString();

            //ListNode head = new ListNode();

            //for (int i = 0; i < sum.Length ; i++)
            //{
            //    ListNode curr = new ListNode();
            //    if (i == 0 )
            //    {
            //        // one way to convert from char to int
            //        curr.val= sum[i] - '0';
            //        curr.next = null;
            //    }
            //    else
            //    {
            //        curr.val = (int)Char.GetNumericValue(sum[i]);
            //        curr.next = head;
            //    }

            //    head = curr;
            //}

            //while(head is not null)
            //{
            //    Console.WriteLine(head.val);
            //    head= head.next;
            //}

            ListNode node1 = new ListNode(9);
            ListNode node2 = new ListNode(9,node1);
            ListNode node3 = new ListNode(9,node2);
            ListNode node4 = new ListNode(9,node3);
            ListNode node5 = new ListNode(9,node4);
            ListNode node6 = new ListNode(9,node5);
            ListNode node7 = new ListNode(9,node6);
            ListNode node8 = new ListNode(9, node7);
            ListNode node9 = new ListNode(9, node8);
            ListNode node10 = new ListNode(1, node9);

            ListNode node11 = new ListNode(9);
            Console.WriteLine(GetValue(node11));
            Console.WriteLine(GetValue(node10));

            Console.WriteLine(GetValue(node11) + GetValue(node10));
        }

        static int GetValue(ListNode node)
        {
            ListNode curr = node;
            int n =0 , resulut =0 ; 

            while (curr != null)
            {
                resulut += curr.val * (int) Math.Pow(10, n);
                n++; 
                curr = curr.next;
            }

            return resulut;  
        }
    }
}
