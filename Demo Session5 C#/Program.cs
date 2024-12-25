namespace Demo_Session5_C_
{
    internal class Program
    {

        public static void PrintShape(string Pattern, int Count = 10) 
        { 
           for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Pattern);
           }
        }

        public static void Swap(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        public static int SummArray(int X, params int[] Arr)
        {
            int Sum = 0;
            Arr[0] = 100;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        public static void SumMul (int X, int Y , ref int Sum, ref int Mul)
        {
            int sum = X + Y;
            int mul = X * Y;
            //return sum;
            //return mul;
        }

            static void Main(string[] args)
        {
            #region Casting [Boxing - Unboxing]
            //object obj = new object();
            //obj = "Mostafa";   // Reference typr Casting
            //obj = 2;          // Boxing[Casting from value type [int] to reference type]

            #region Boxing [safe Code]
            //int x = 10;
            //object obj01 = new object();
            //obj01 = x;

            //Console.WriteLine( obj01);
            // Parent = Child
            // Dog is Animal
            #endregion
            #region Unboxing [Unsafe Code]
            //object obj02 = new object();
            //obj02 = 10; 
            //int X  = (int)obj02;

            //Console.WriteLine(X);
            // Child = Parent
            // Animal is Dogs
            #endregion

            #endregion
            #region Nullable DataType
            #region Value Type
            // int X = null;  // int Number Only
            //int? X = null; // int Number and null
            //Console.WriteLine(X);

            //int? X = 10;
            //int Y;
            //if(X != null)
            //{
            //    Y =(int) X;  //Casting
            //}
            //else
            //{
            //    Y = 0;
            //}

            //if (X.HasValue)
            //{
            //    Y = X.Value;  // no Casitng
            //}
            //else
            //{
            //    Y = 0;
            //}

            //Y = X.HasValue ? X.Value : 0;
            //Console.WriteLine(Y);
            #endregion
            #region Reference Type
            //string? Name = null;

            //Console.WriteLine(Name);
            #endregion
            #endregion
            #region Null Propagation Operator
            //int[] Numbers = null;
            //if (Numbers != null)
            //{
            //    for (int i = 0; i < Numbers?.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}


            //int Length = Numbers?.Length ?? 0;
            //Console.WriteLine(Length);

            //Employee emp = new Employee();

            //emp.Department = new Department();

            //if (emp != null)
            //{
            //    if (emp.Department != null)
            //    {
            //        Console.WriteLine(emp.Department.Name);
            //    }
            //}

            //Console.WriteLine(emp?.Department.Name ?? "Not Found");
            #endregion
            #region Functions
            //PrintShape(10, "***^^");    // Passing by order
            //PrintShape(Pattern: "^^***", Count: 10);  // Passing by name

            // Console.WriteLine("Hello Mostafa \nwelcome to\tRoute");
            // PrintShape("/*\\", 10);
            #endregion
            #region Value Type Parameters
            #region By value
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #region By Reference
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(ref A,ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #endregion
            #region Reference Type Parameters
            #region By value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SummArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region By Reference
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SummArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #endregion
            #region Functions - Passing by Out
            //int A = 5;
            //int B = 10;
            //int Sum, Mul;
            //SumMul(A, B, ref Sum, ref Mul);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);
            #endregion
            #region Functions - Params
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(SummArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            int A = 10 , B = 20 , C = 30;
            Console.WriteLine("A : {0} , B : {1} ,C : {2}" , A,B,C);
            #endregion
        }
    }   }   
