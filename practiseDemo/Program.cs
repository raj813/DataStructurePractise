// See https://aka.ms/new-console-template for more information
using System.Buffers;
using System.Globalization;
using System.Collections.Generic;
using practiseDemo;
using static practiseDemo.LinkedList;
using System.Diagnostics;
using NodeT = practiseDemo.NodeT;
using System.Reflection.Metadata.Ecma335;
using System.Collections;

Console.WriteLine("Hello, World!");




List<int> re = new List<int>();
Console.WriteLine(re.Count());
int[] arr = { 1, 2, 3, 4 };
int n = arr.Length;
string s = "A&x#";
// int s = 23;
// Console.WriteLine(subarraySum(arr,n,s));
//Console.WriteLine(maxSubarraySum(arr, n));

//Console.WriteLine(remove_duplicate(arr, n));

//Console.WriteLine(MaxArea(arr));

//Special array reversal
//Given a string S, containing special characters and all the alphabets, reverse the string without
//affecting the positions of the special characters.
//*//
// reverse(s) ;


//*
//Find the maximum subarray XOR in a given array
//*//
//Console.WriteLine("Max array XOR : {0}",maxSubarrayXOR(arr,n));

//*
//Unique element in an array where all elements occur k times except one
//*//

//Console.WriteLine("Find Unique :{0}",findUnique(arr, n, 3));

//* Count the trailing zero for the factorial of given number. 
//int x = 234;
//Console.WriteLine("Traling zero : {0}",tralingzero(x));
//*//
//revnumber();

//bool[] resbool = seiveOfEratoSthenes(20);
//for (int i = 0; i <= resbool.Length; i++) 
//{
//    Console.WriteLine(resbool[i]);
//}

//*
//Find the number of ways in n*m matrix 
//Console.WriteLine("Total ways are :{0}",FindWay(8,8));
//*//

/*int  x = 123;

Console.WriteLine("reverse nub is:{0}", Reverse(x));
*/

// NQueen();
static int Reverse(int x)
{
    int rev = 0;

      Console.WriteLine(int.MaxValue);
    while (x != 0)
    {
        int pop = x % 10;
        x = x / 10;
        Console.WriteLine("pop :{0} ,x :{1}",pop,x);
        Console.WriteLine(rev > int.MaxValue / 10);Console.WriteLine(rev == int.MaxValue / 10 && pop > 7);
        if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
        if (rev < int.MinValue / 10 || (rev == int.MaxValue / 10 && pop < -8)) return 0;

        rev = rev * 10 + pop;
        Console.WriteLine("rev :{0}  ,pop :{1}  ,x :{2}",rev,pop,x);
    }

    return rev;
}

static void revnumber() 
  {
    int n = 123;
    int rev = 0;
    while (n > 0) 
    {
        rev = rev * 10 + n % 10;
        n = n / 10;
        Console.WriteLine(rev);
    }
}

List<int> subarraySum(int[] arr, int n, int s)
{ List<int> re = new List<int>();
    int sum = arr[0], start = 0;
    for (int i = 1; i < n; i++)
    {
        Console.WriteLine("Enter for loop :i = {0};start :{1};sum={2}", i, start, sum);
        while (sum > s && start < i-1)
        {
            Console.WriteLine("Enter While:i = {0};start :{1};sum={2}", i, start, sum);
            sum = sum - arr[start];
            start++;

        }
        if (sum == s)
        {
            Console.WriteLine("Enter first if:i = {0};start :{1};sum={2}", i, start, sum);
            re.Add(start + 1);
            re.Add(i + 1);
            Console.WriteLine("sum ==s ,start  = {0} and i ={1}", start , i);
            return re;
        }

        if (i < n)
        {
            Console.WriteLine("Enter 2nd if - (i<n) :i = {0};start :{1};sum={2}", i, start, sum);
            sum = sum + arr[i];
        }
    }
    //code here
    if (re.Count() == 0)
    {
        re.Add(-1);
    }
    return re;
}

 long maxSubarraySum(int[] arr, int n)
{
    long sum = 0 , max_sum = 0;
    //code here
   

    for (int i = 0; i < n; i++) 
    {
        sum += arr[i];

        if (max_sum < sum) 
        {
            max_sum = sum;
        }
        if (sum < 0) 
        {
            if (max_sum == 0) 
            {
                max_sum = sum;
            }
            sum = 0;
        }

    }

    return max_sum;}

int remove_duplicate(int[] a, int n) { int i = 0;
    for (int j = 1; j < n; j++)
    {
        if (a[j] != a[i])
        {
            i++;
            a[i] = a[j];
        }
    }
    return i + 1;}

int MaxArea(int[] height)
{

    int maxArea = 0, start = 0, end = height.Length - 1;

    while (start != end)
    {
        maxArea = Math.Max(maxArea, (end - start) * Math.Min(height[start], height[end]));

        (start, end) = height[start] < height[end] ? (start + 1, end) : (start, end - 1);
    }

    return maxArea;}

//string reverse(string str) 
//{
//    string rev ="" ;
//    int r = str.Length - 1,l = 0;
//    while (r > l) 
//    {
//      if((str[l])
//    }
//    foreach (char c in rev)
//    {
//        Console.WriteLine(c);
//    }
//    return rev.ToString();
//    
//}

static int maxSubarrayXOR(int[] arr, int n) 
{
    int sum = int.MinValue;

    for(int i = 0;i < n;i++)
    {
        int cur_xor = 0;

        for (int j = i; j < n; j++) 
        {
            cur_xor = cur_xor ^ arr[j];
            Console.WriteLine("cur_xor :{0}  ,i :{1} , j:{2}",cur_xor,i,j);
            sum = Math.Max(sum, cur_xor);
        }
        
    }
    return sum;
}

static int findUnique(int[] a, int n, int k)
{
    // Create a count array to store count of
    // numbers that have a particular bit set.
    // count[i] stores count of array elements
    // with i-th bit set.
    byte sizeof_int = 4;
    int INT_SIZE = 8 * sizeof_int;
    int[] count = new int[INT_SIZE];

    // AND(bitwise) each element of the array
    // with each set digit (one at a time)
    // to get the count of set bits at each
    // position
    for (int i = 0; i < INT_SIZE; i++)
        for (int j = 0; j < n; j++)
            if ((a[j] & (1 << i)) != 0)
                count[i] += 1;

    // Now consider all bits whose count is
    // not multiple of k to form the required
    // number.
    int res = 0;
    for (int i = 0; i < INT_SIZE; i++)
        res += (count[i] % k) * (1 << i);

    // Before returning the res we need
    // to check the occurrence  of that
    // unique element and divide it
    res = res / (n % k);
    return res;
}

static int tralingzero(int n ) 
{
    int res = 0;
    for (int i = 5; i <= n; i = i * 5)
    {
        res = res + n / i;
        Console.WriteLine("res  : {0}",res);
    }

    return res;
}

static Boolean[] seiveOfEratoSthenes(int n) 
{
    bool[] isPrime = new Boolean[n+1];
    Array.Fill(isPrime, true);
    isPrime[0] = false;
    isPrime[1] = false;

    for (int i = 2; i * i <= n; i++) // same as i <= root of n
    {
        for (int j = 2*i; j <= n; j += i) 
        {
             isPrime[j] = false;
        }
    }
    return isPrime;
}

static int GCD(int a,int b) 
{
    int gcd;
    gcd=(b == 0) ?a :GCD(b,a % b);
    return gcd;
}

static int FindWay(int m,int n) 
{
    if (m == 1 || n == 1) return 1;

    return FindWay(m - 1, n) + FindWay(m, n - 1);
}

void NQueen()
{
    int N = 4;

    solveNQ();
   void printSolution(int [,]board)
    {
        for (int i = 0; i < N; i++) 
        {
            for (int j = 0; j < N; j++)
                Console.Write(" " + board[i, j]
                                  + " ");
            Console.WriteLine();
        }
    }
     
    bool isSafe(int[,] board , int row,int col) 
    {
        int i, j;
        for (i = 0; i < col; i++)
            if (board[row, i] == 1)
                return false;

        /* Check upper diagonal on left side */
        for (i = row, j = col; i >= 0 &&
             j >= 0; i--, j--)
            if (board[i, j] == 1)
                return false;

        /* Check lower diagonal on left side */
        for (i = row, j = col; j >= 0 &&
                      i < N; i++, j--)
            if (board[i, j] == 1)
                return false;

        return true;
    }
    /* A recursive utility function to solve N
   Queen problem */
    bool solveNQUtil(int[,] board, int col)
    {
        /* base case: If all queens are placed
        then return true */
        if (col >= N)
            return true;

        /* Consider this column and try placing
        this queen in all rows one by one */
        for (int i = 0; i < N; i++)
        {
            /* Check if the queen can be placed on
            board[i,col] */
            if (isSafe(board, i, col))
            {
                /* Place this queen in board[i,col] */
                board[i, col] = 1;

                /* recur to place rest of the queens */
                if (solveNQUtil(board, col + 1) == true)
                    return true;

                /* If placing queen in board[i,col]
                doesn't lead to a solution then
                remove queen from board[i,col] */
                board[i, col] = 0; // BACKTRACK
            }
        }
        /* If the queen can not be placed in any row in
        this column col, then return false */
        return false;
    }

    bool solveNQ()
    {
        int[,] board = {{ 0, 0, 0, 0 },
                        { 0, 0, 0, 0 },
                        { 0, 0, 0, 0 },
                        { 0, 0, 0, 0 }};

        if (solveNQUtil(board, 0) == false)
        {
            Console.Write("Solution does not exist");
            return false;
        }

        printSolution(board);
        return true;
    }
    

}

//int[,] arrip = new int[,] { { 1, 3 }, { 2, 4 }, { 6, 8 }, { 9, 10 } };
int[,] arrip = new int[,] { { 6, 8 }, { 1, 9 }, { 2, 4 }, { 4, 7 } };
//print2dArray(arrip);
//sortarr(arrip);
//print2dArray(arrip); 
//OverlappingIntervals(arrip);
void print2dArray(int[,] arrip) 
{
    int x = arrip.GetLength(0);
    int z = arrip.GetLength(1);
    Console.WriteLine("Print start");
    for (int i = 0; i < x ; i++)
    {
        for (int j = 0; j < z; j++)
        {
            //Console.WriteLine("arrip[{0},{1}] :{2}", i, j, arrip[i, j]);
            Console.Write("{0}  ", arrip[i, j]);
        }
        Console.WriteLine();
      //  Console.WriteLine("arrip[{0},{1}] :{2} ,arrip[{0},{3}] :{4}", i,0, arrip[i, 0],1, arrip[i, 1]);
    }
    Console.WriteLine("Print end");

}
int[,] sortarr(int[,] arr)
{
    int a = arr.Length / 2;
    for (int i = 0; i < a / 2; i++)
    {
        int[,] temp = new int[,] { {0,0},{0,0} };

        for (int j = 0; j < a  - i - 1;j++) 
        {
            if (arr[j, 0] > arr[j + 1, 0])
            {
                int temp1 = arr[j,0];
                int temp2 = arr[j,1];
                arr[j, 0] = arr[j + 1, 0];
                arr[j, 1] = arr[j + 1, 1];
                arr[j+1, 0] = temp1;
                arr[j+1, 1] = temp2;
            }
        }
        /*
        if (arr[i, 0] < arr[i + 1, 0]) 
        {   //*
            
            temp[0,0] = arr[i, 0];
            temp[0, 1] = arr[i,1];
            
            arr[i, 0] = arr[i + 1, 0];
            arr[i, 1] = arr[i + 1, 1];
            
            arr[i + 1, 0] = temp[0, 0];
            arr[i + 1, 1] = temp[0, 1];
      


    }
        */
    }
    return arr;
}
int[,] OverlappingIntervals (int[,] arr)
{   int[,] re = new int[,] {  };
    arr = sortarr(arr);
    print2dArray(arr);
    int j = 0;
    for (int i = 0;i < arr.Length / 2 - 1;i++ ) 
    {
        if (arr[i, 1] >= arr[i + 1, 0])
        { if (arr[i + 1, 1] >= arr[i, 1]) 
            {
                arr[i, 1] = arr[i + 1, 1];
                for (int k = 0; k < 2; k++) 
                {
                    re[j,k] = arr[i, k];
                }
                j++;
            }
        }
    }
    Console.WriteLine("****************************");
    print2dArray(arr);
    print2dArray(re);
   
   
        return re;
}
//Console.WriteLine("Mod Power :{0}", ModPower(20,55 , 45));
int ModPower(int x,int y,int p)
{ 
    int re = power(x,y);
    return re%p;
}
int power(int x,int y) 
{
    if (y != 0) 
    {
        return (x * power(x,y-1));
    }
    return 1;
}
/*
int[,] mat = { { 1, 2, 3, 4 },
               { 5, 6, 7, 8 },
               { 9, 10, 11, 12 },
               { 13, 14, 15, 16 } };
*/
int[,] mat = {
    {1 , 2, 3},
    {4 , 5, 6},
    {7 , 8, 9}
};

void Transpose (int[,] mat) 
{  
    int n=  mat.GetLength(0);
    Console.WriteLine("{0}",n);
    
    for (int i = 0; i < n; i++) 
    {
        for (int j = i; j < n; j++) 
        {   int temp = mat[i, j];
            mat[i,j] = mat[j,i];
            mat[j,i] = temp;
        }
    }
    
}
void ReverseArrRow(int[,] mat)
{
    int n = mat.GetLength(0);
    
    for (int i = 0; i < n; i++)
    {
        int k = mat.GetLength(0) - 1;
        for (int j = 0; j < n / 2; j++)
        {
            int temp = mat[i, j];
            mat[i, j] = mat[i,k];
            mat[i, k] = temp;
            k--;
        }
    }

}
void ReverseArrCol(int[,] mat)
{
    int n = mat.GetLength(0);
    
    for (int i = 0; i < n; i++)
    {
        int k = mat.GetLength(0) - 1;
        for (int j = 0; j < n / 2; j++)
        {
            int temp = mat[j, i];
            mat[j, i] = mat[k, i];
            mat[k, i] = temp;
            k--;
        }
    }

}
//Rotate90clockwise();
//Rotate90Anticlockwise();
void Rotate90clockwise() 
{
    Console.WriteLine("90 Degree Clock wise rotation.");
    print2dArray(mat);
    Transpose(mat);
    print2dArray(mat);
    ReverseArrRow(mat);
    print2dArray(mat);

}
void Rotate90Anticlockwise()
{
    Console.WriteLine("90 Degree Anti - Clock wise rotation.");
    print2dArray(mat);
    Transpose(mat);
 // print2dArray(mat);
    ReverseArrCol(mat);
    print2dArray(mat);

} 

//Rotate90AntiClockwise(mat);
void Rotate90AntiClockwise(int[,]mat) 
{   
    int N = mat.GetLength(0);
    
    for (int x = 0; x < N / 2; x++)
        {
            // Consider elements
            // in group of 4 in
            // current square
            for (int y = x; y < N - x - 1; y++)
            {
                // store current cell
                // in temp variable
                int temp = mat[x, y];

                // move values from
                // right to top
                mat[x, y] = mat[y, N - 1 - x];

                // move values from
                // bottom to right
                mat[y, N - 1 - x]
                    = mat[N - 1 - x, N - 1 - y];

                // move values from
                // left to bottom
                mat[N - 1 - x, N - 1 - y]
                    = mat[N - 1 - y, x];

                // assign temp to left
                mat[N - 1 - y, x] = temp;
            }
    }
    print2dArray(mat);
}
int[] arr1 = { 4, 3, 7, 8, 6, 2, 1 };
//BubleSort(arr1);
void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0} ", arr[i]);
    }
    Console.WriteLine();
}
void BubleSort(int[] arr) 
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (arr[j] > arr[j + 1])
            {
                // swap temp and arr[i]
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
    printArray(arr);
}
//Console.WriteLine(KlargestEliment(arr1, 3));  //Find optimal solution below -KthlargestEliment
int KlargestEliment(int[] arr, int k) 
{
    int klarge = 0;
    printArray(arr);
    int n = arr.Length; 
    for (int i = 0; i < n - k; i++)
    {
        for (int j = 0; j < n - i -1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j+1] = temp;
            }
            Console.WriteLine(i);
            printArray(arr);
        }
    }
    printArray(arr);
    klarge = arr[n-k];
    return klarge;
}
// Console.WriteLine(KsmallestEliment(arr1, 3));
int KsmallestEliment(int[] arr, int k)
{
    int ksmall = 0;
    int n = arr.Length;
    for (int i = 0; i < n ; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
            Console.WriteLine(i);
            printArray(arr);
        }
    }
    printArray(arr);
    ksmall = arr[k];
    return ksmall;
}
arrayToZigZag(arr1);
void arrayToZigZag(int[] arr) 
{
    int n = arr.Length;
    bool fleg = true;
    for (int i = 0; i < n -2 ; i++)
    { 
        if (fleg == true)
        {
           if (arr[i] > arr[i + 1])
           {
               int temp = arr[i + 1];
               arr[i + 1] = arr[i];
               arr[i] = temp;
           }
        }
        else {
            if (arr[i] < arr[i + 1])
            {
                int temp = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
        }
     fleg = !fleg;
    }
    printArray(arr);
}

void PythagoreantTriplet(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            if(true){}
        }
    }
}

//printArray(InsertionSort(arr1));
int[] InsertionSort(int[] arr){
    int n = arr.Length- 1;
    for(int i = 1;i < n ;i++) 
    {
        int temp = arr[i];
        int j = i-1 ; 
        while(j>=0 && arr[j] > temp){
        
            arr[j+1] = arr[j];
            j--;
        }
        arr[j+1] = temp;
    }
    return arr;
}
int[] arr2 = { 4, 1, 9, 2, 3, 6 };
//SelectionSort(arr2);
void SelectionSort(int[] arr) 
{
    n = arr.Length ;
   // One by one move boundary of unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;

            // Swap the found minimum element with the first
            // element
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        printArray(arr);
        }
    
}
int[] arr0 = { 1, 4, 5, 6, 0, 9 };
// SmallestSubArraySum(arr0, 51);
void SmallestSubArraySum(int[] arr, int sum)
{
    int n = arr.Length ;
    int smallestnum = n+1;
    int k = 0;
    printArray(arr);
    
    while (k < n) 
    {
        int s = 0;
        int count = 0;
        Console.WriteLine("s = {0}", s);
        Console.WriteLine("count = {0}", count);

        for (int i = k; i < n; i++)
        {
            s =s + arr[i];
            Console.WriteLine("s = {0}",s);
            ++count;
            Console.WriteLine("count = {0}", count);
            if (s > sum)
            {
                Console.WriteLine("in if(s>sum)");
                if (count < smallestnum)
                {
                    Console.WriteLine("in if(count<smallest)");
                    smallestnum = count;
                    Console.WriteLine("smallest num = {0}", smallestnum);

                }
                break;
            }
        }
        k++;
    }
    Console.WriteLine("Smallest sum = {0}", smallestnum);
    printArray(arr);

}

int[] a = { 15, 17, 20 };
//minPage(a, 2);
// Minimise the meximum number of pages read by student - Google interview Hard 
void minPage(int[] arr,int k) 
{
    int min = maxof(arr);
    int max = sumof(arr);

    int res = 0;

    while (min <= max) 
    {
        int mid = (min + max)/ 2;
        if (isFeasible(arr, k, mid))
        {
            res = mid;
            max = mid - 1;
        }
        else {
            min = mid + 1;
        }
    }
    Console.WriteLine("Min page :{0}", res);
}
int maxof(int[] arr) 
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] > max) 
        {
            max = arr[i];
        }  
    }
    return max; 
}
int sumof(int[] arr) 
{
    int sum = 0;
    foreach (int a in arr) 
    {
        sum += a;
    }
    return sum;
}
bool isFeasible(int[] arr,int k,int res) 
{
    int student = 0;
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (sum + arr[i] > res)
        {
            student++;
            sum = arr[i];

        }
        else 
        {
            sum += arr[i];
        }
    }
    return student <= k;
}

int[] nums = { 5, 7, 7, 8, 8, 10 };int target = 8;

//Console.WriteLine("Search range is :");

//int[] t = SearchRange(nums, target);
//printArray(t);
int[] SearchRange(int[] nums, int target)
{
    int[] re = { -1, -1 };
    if (nums.Length == 0) return re;
    int firstpos = BinarySearch(nums, 0, nums.Length - 1, target);
    if (firstpos == -1) return re;
    int startpos = firstpos;
    int endPos = firstpos;
    int temp1 = 0, temp2 = 0;
    while (startpos != -1)
    {
        temp1 = startpos;
        startpos = BinarySearch(nums, 0, startpos - 1, target);
    }
    startpos = temp1;

    while (endPos != -1)
    {
        temp2 = endPos;
        endPos = BinarySearch(nums, endPos + 1, nums.Length - 1, target);
    }
    endPos = temp2;
    re[0] = startpos;
    re[1] = endPos;

    return re;
}
int BinarySearch(int[] nums,int start,int end ,int target) 
{
    int mid = (start + end) / 2;
   
    while (start <= end)
    {
        if (nums[mid] == target)
        {
          return mid;
        }
        else if (nums[mid] < target)
        {
            start = mid + 1;
        }
        else
        {
            end = mid - 1;
        }
    }
    return -1;
}


//*
//LinkedList :
//Detect Loop
//Find sarting of loop
//Delete loop
//*//
//reverseLinkedList();
void reverseLinkedList() {
    LinkedList list = new LinkedList();
    list.head = new Node(50);
    list.head.next = new Node(20);
    list.head.next.next = new Node(15);
    list.head.next.next.next = new Node(4);
    list.head.next.next.next.next = new Node(10);
    list.head.next.next.next.next.next = new Node(30);
    list.head.next.next.next.next.next.next = new Node(40);
    list.printList(list.head);
 // list.reverseLinkelist(list.head);
 // Console.WriteLine("Linked List after reversing : ");
 // list.printList(list.head);
    
 // list.printList(list.head);
    list.reverseLinkelistmn(list.head,2,4);
    Console.WriteLine("After swithc");
    list.printList(list.head);



}

//createandtestLinkedList();

void createandtestLinkedList()
{    
    LinkedList list = new LinkedList();
    list.head = new Node(50);
    list.head.next = new Node(20);
    list.head.next.next = new Node(15);
    list.head.next.next.next = new Node(4);
    list.head.next.next.next.next = new Node(10);

    // Creating a loop for testing
    list.head.next.next.next.next.next = list.head.next.next;

    list.findFirstNodeandDelete(list.head);

    Console.WriteLine("Linked List after removing loop : ");
    list.printList(list.head);
}
int[] astack = { 4, 10, 5, 18, 3, 12, 7 };
// previousSmallerElement(astack);
void previousSmallerElement(int[] a) 
{
    printArray(a);
    Stack<int> s = new Stack<int>();

    for (int i = 0; i < a.Length; i++) 
    {
        while (s.Count > 0 && s.Peek() >= a[i])
        {
            s.Pop();
        }


        if (s.Count <= 0)
        {
            Console.Write("-1 ");
        }
        else 
        {
            Console.Write(s.Peek());
            Console.Write("  ");
        }
        s.Push(a[i]);
    }

}

//nextSmallerElement(astack);

void nextSmallerElement(int[] a)
{
    printArray(a);
    Stack<int> s = new Stack<int>();
    int[] aresult = new int[100];
    for (int i = a.Length; i >=0; i--)
    {
        while (s.Count > 0 && s.Peek() >= a[i])
        {
            s.Pop();
        }


        if (s.Count <= 0)
        {
            aresult.Append(-1);
           
        }
        else
        {
            aresult.Append(a[i]);
        }
        s.Push(a[i]);
        printArray(aresult);
    }

}

//string str = "(({}))"; 
//string str = "(}";
//Console.WriteLine(matchPrenthesis(str));

bool matchPrenthesis(string str) 
{
    Dictionary<char, char> dt = new Dictionary<char, char>();
    dt.Add('}','{');
    dt.Add(']','[');
    dt.Add(')','(');

    Stack <char> s = new Stack<char>();

    for (int i = 0; i < str.Length; i++) 
    {
        if (dt.ContainsValue(str[i]))
        {
            s.Push((char)str[i]);
        }
        else 
        {
            if (s.Count <= 0)
            {
                return false;
            }
            else if (!(dt[str[i]] == s.Peek()))
            {
                return false;
            }
            else 
            {
                s.Pop();
            }
        }

    }
    return s.Count <= 0 ? true :false;
}


//CreateTree();
NodeT CreateTree() 
{
    NodeT root = null;

    Console.WriteLine("Enter Data :");
    int data = Int32.Parse(Console.ReadLine());

    if (data == -1) return null;

    root = new NodeT(data);
    
    Console.WriteLine("Enter Data for left:{0}",data);
    root.Left = CreateTree(); 

    Console.WriteLine("Enter Data for Right:{0}", data);
    root.Right = CreateTree();



    return root;
}
//NodeT x = CreateTree();
// Array to  level order tree.

NodeT ArrayToTree(int[] a,int i,int n) 
{
    NodeT root = null;
    if (i < n) 
    {
        root = new NodeT(a[i]);

        root.Left = ArrayToTree(a, 2 * i + 1, n);
        root.Right = ArrayToTree(a, 2 * i + 2, n);
    }
    return root;
}

int[] atree = { 1, 2, 3, 4, 5, 6};

//NodeT x = ArrayToTree(atree, 0,atree.Length);
//Console.WriteLine("In Order");
//NodeT x = CreateTree(); 
//inOrder(x);
// Console.WriteLine("Pre Order");
// preOrder(x);
// Console.WriteLine("Post Order");
// postOrder(x);
void inOrder(NodeT root) 
{
    if (root == null) return;

    inOrder(root.Left);
    Console.Write("{0} ", root.data);
    inOrder(root.Right);
}

void preOrder(NodeT root)
{
    if (root == null) return;
    Console.Write("{0} ",root.data);
    preOrder(root.Left);
    preOrder(root.Right);
}
                                                                  
void postOrder(NodeT root)
{
    if (root == null) return;
    postOrder(root.Left);
    postOrder(root.Right);
    Console.Write("{0} ", root.data);
}

//Console.WriteLine("Height of tree : {0}",height(x));
int height(NodeT root) 
{
    if (root == null) return 0;

    return Math.Max(height(root.Left), height(root.Right)) + 1;
}
//Console.WriteLine("Size of tree : {0}", size(x));
int size(NodeT root) 
{
    if (root == null) return 0;

    return size(root.Left) + size(root.Right) + 1;
}
//Console.WriteLine("Max of tree : {0}", maxInTree(x));

int maxInTree(NodeT root) 
{
    if (root == null) return int.MinValue;
    
    return Math.Max(root.data,Math.Max(maxInTree(root.Left),maxInTree(root.Right)));
}
//Console.WriteLine("Min of tree : {0}", minInTree(x));

int minInTree(NodeT root)
{
    if (root == null) return int.MaxValue;

    return Math.Min(root.data, Math.Min(minInTree(root.Left), minInTree(root.Right)));
}
 // Level order travsersal = Naive approch - Time  : O(n^2)
 void PrintCurrentLevel(NodeT root,int level) 
{
    if (root == null) return;
    if (level== 1) Console.Write(root.data + " ");
    else if(level>1)
    {
         PrintCurrentLevel(root.Left,level-1);
         PrintCurrentLevel(root.Right,level-1);
    }


}
//LevelOrderTravese(x);
void LevelOrderTravese(NodeT root) 
{
    Console.WriteLine("Level order travsel print: ");
    for (int i = height(root); i >= 1; i--) 
    {
        PrintCurrentLevel(root, i);
    }
}
// Level order travsersal = Using Queue Time  : O(n)
//using Queue<NodeT> which store n  ode 
//Console.WriteLine("Printing the Level order travsrse using Queue : ");
//PrintLevelOrder(x);
void PrintLevelOrder(NodeT root) 
{
    Queue<NodeT> q = new Queue<NodeT>();
     q.Enqueue(root);
     q.Enqueue(null);


    while (q.Count > 0)
    {
        NodeT cur = q.Dequeue();
        if (cur == null)
        {
            if (!(q.Count > 0)) return;

            q.Enqueue(null);
            Console.WriteLine();
        }
        else
        {
            Console.Write(cur.data + " " );

            if (cur.Left != null)
            {
                q.Enqueue((NodeT)cur.Left);
            }

            if (cur.Right != null)
            {
                q.Enqueue((NodeT)cur.Right);
            }
        }
    } 
}
// Print left view of the tree
NodeT x = new NodeT(0);
x = x.createSampletree();
//x = CreateTree();
Console.WriteLine("Printing tree in Order");
PrintLevelOrder(x);
Console.WriteLine();
Console.WriteLine("***************************");
//PrintLeftView(x);

void ptintLeftViewUtil(NodeT root,List<NodeT> list,int level)
{
    int h = height(root);
    
    if (root == null) return;
    Console.WriteLine("Level : " + level);

    if (list[level] == null) 
    {
        list.Add(root);
    }

    ptintLeftViewUtil(root.Right,list ,level + 1);
    ptintLeftViewUtil(root.Left,list,level + 1);
}

void PrintLeftView(NodeT root)
{
   
    List<NodeT> l = new List<NodeT>();
    ptintLeftViewUtil(root,l,0);
    Console.WriteLine("****************Printing left view***********************");
   
}
Console.WriteLine(" ");
printArray(BreathFirstSearch(x).ToArray());

List<int> BreathFirstSearch(NodeT root) 
{
    NodeT  cur = root;
    List<int> list = new List<int>();
    Queue<NodeT> q = new Queue<NodeT> ();
    q.Enqueue (cur);

    while (q.Count > 0) 
    {
        cur = q.Dequeue ();
        list.Add(cur.data);
       // Console.Write(cur.data + " " );
        if (cur.Left != null) 
        {
            q.Enqueue(cur.Left);
        }
        if (cur.Right != null)
        {
            q.Enqueue(cur.Right);
        }

    }
    return list;
}

Console.WriteLine("RightSideBinaryView ");
List<int> rel = new List<int>();
rel = RightSideBinaryView(x);
printArray(rel.ToArray());

List<int> RightSideBinaryView(NodeT root) 
{
    
    List<int> result = new List<int> ();
    if (root == null) return result;

    Queue<NodeT> q = new Queue<NodeT> ();
    
    q.Enqueue(root);

    while (q.Count > 0) 
    {
        int n = q.Count;
        result.Add (q.Peek().data);

        for(int i = 0;i < n; i++)
        {
            NodeT cur = q.Dequeue();
            if (cur.Right != null)
            {
                q.Enqueue(root.Right);
            }
            if (cur.Left != null) 
            {
                q.Enqueue(cur.Left);
            }
            
        }
        return result;
    }
    return result;
}

TreeView(x,true);

void TreeView(NodeT root,bool view) 
{
    Console.WriteLine("print {0} side Tree view",view == true? "Left" : "Right");

    if (root == null) return;
    Queue<NodeT> q = new Queue<NodeT> ();
    q.Enqueue(root);

    while (q.Count != 0) 
    {
        int n = q.Count;

        for (int i = 0; i < n; i++) 
        {
            NodeT cur = q.Peek();
            q.Dequeue();
            if (i == n - 1 && view == false) 
            {
                Console.Write(cur.data + " ");
            }
            if(i==0 && view == true)
            {
                Console.Write(cur.data + " ");
            }
            if (cur.Left != null) 
            {
                q.Enqueue (cur.Left);
            }
            if (cur.Right != null) 
            {
                q.Enqueue(cur.Right);
            }
        }

    }
}


// Top  and bottom view of the Tree : 
// 
Console.WriteLine("Top view of the tree : ");
printArray(TreeTopView(x).ToArray());

List<int> TreeTopView(NodeT root) 
{
    Queue<Pair> q = new Queue<Pair>();
    SortedDictionary<int,NodeT> topViewMap= new SortedDictionary<int,NodeT>();

    if (root == null) { return new List<int>(); }

    q.Enqueue(new Pair(0, root));

    while (q.Count > 0) 
    {
        Pair cur = q.Dequeue();

        if (!topViewMap.ContainsKey(cur.hd)) 
        {
             topViewMap.Add(cur.hd, cur.node);
        }
        if (cur.node.Left != null)
        {
            q.Enqueue(new Pair(cur.hd - 1, cur.node.Left));
        }
        if (cur.node.Right != null)
        {
            q.Enqueue(new Pair(cur.hd + 1, cur.node.Right));
        }
    }

    List<int> list = new List<int>();
    foreach (var item in topViewMap) 
    {
        list.Add(item.Value.data);
        Console.Write(item.Value.data + " ");
    }
     return list;
    
}

Console.WriteLine("Bottom view of the tree : ");
NodeT y = CreateTree();
int[] ar = TreeBottomView(y).ToArray();
printArray(ar);

List<int> TreeBottomView(NodeT root)
{
    Queue<Pair> q = new Queue<Pair>();
    SortedDictionary<int, NodeT> topViewMap = new SortedDictionary<int, NodeT>();

    if (root == null) { return new List<int>(); }

    q.Enqueue(new Pair(0, root));

    while (q.Count > 0)
    {
        Pair cur = q.Dequeue();

        
            topViewMap[cur.hd]= cur.node ;
        
        if (cur.node.Left != null)
        {
            q.Enqueue(new Pair(cur.hd - 1, cur.node.Left));
        }
        if (cur.node.Right != null)
        {
            q.Enqueue(new Pair(cur.hd + 1, cur.node.Right));
        }
    }

    List<int> list = new List<int>();
    foreach (var item in topViewMap)
    {
        list.Add(item.Value.data);
     //   Console.Write(item.Value.data + " ");
    }
    return list;

}
