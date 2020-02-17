using System;

namespace tik_tak_toe_3
{
    class Program
    {
        public static string[,] a = new string[3, 3];
     

        static void Main(string[] args)
        {
            int l = 1;
            int i = 0;
            int j = 0;
            
            Console.WriteLine("Tik Tak Toe");
            Console.WriteLine("EA SPORTS");
            for (int k = 0; k < 3; k++)
            {
                for (int y = 0; y < 3; y++)
                {
                    a[k, y] = "_";
                }
            }
            

            
          
            while (l <= 9)
            {
                pattern();
                
                if (l == 1 || l == 3 || l == 5 || l == 7 || l == 9)
                {
                    Console.WriteLine("Player 1 Turn ");
                    Console.WriteLine("Enter number of row ");
                    Console.WriteLine("select :0  1  2");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number of column ");
                    Console.WriteLine("select :0  1  2");
                    int r = Convert.ToInt32(Console.ReadLine());
                    for ( i = 0; i <= c; i++)
                    {
                        for ( j = 0; j <= r; j++)
                        {


                            if (i == c && j == r)
                            {
                                if (a[i, j] == "_")
                                {

                                    a[i, j] = "x";
                                    winflag1();
                                    ++l;
                                }
                            }
                            
                            

                        }
                    }
                    
                    
                }
                else
                {
                    Console.WriteLine("Player 2 Turn ");
                    Console.WriteLine("Enter number of column ");
                    Console.WriteLine("select :0  1  2");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number of row ");
                    Console.WriteLine("select :0  1  2");
                    int r = Convert.ToInt32(Console.ReadLine());
                    for ( i = 0; i <= c; i++)
                    {
                        for ( j = 0; j <= r; j++)
                        {
                            if (i == c && j == r)
                            {
                                if (a[i, j] == "_")
                                {

                                    a[i, j] = "o";
                                    winflag1();
                                    ++l;
                                }
                            }
                        }
                    }


                }
                if (winflag1() == 1)
                {
                    pattern();
                    Console.WriteLine("Player 1 Won !!!!!!");
                    break;
                }
                else if(winflag1()==2)
                {
                    pattern();
                    Console.WriteLine("Player 2 Won!!!!!!!!");
                    break;
                }
                else if(l==9)
                {
                    Console.WriteLine("Game Draw");
                    break;
                }
                 
            }
            Console.WriteLine("");
            Console.WriteLine("");
            
           
        }
        public static int winflag1()
        {
            int chk = 0;
            if (a[0, 0] == a[0, 1] && a[0, 1] == a[0, 2] && a[0, 0] == a[0, 2])
            {
                if (a[0, 0] == "x")
                {
                    chk =1;
             
                }
                else if(a[0,0]=="o")
                {
                    chk = 2;
                    
                    
                }
            }
            else if (a[1, 0] == a[1, 1] && a[1, 1] == a[1, 2] && a[1, 2] == a[0, 0])
            {
                if (a[1, 0] == "x")
                {
                    chk = 1;
                    
                }
                else if(a[1, 0] == "o")
                {
                    chk = 2;
                }
            }
            else if (a[2, 0] == a[2, 1] && a[2, 1] == a[2, 2] && a[2, 2] == a[2, 0])
            {
           
                if (a[2, 0] == "x")
                {
                     chk=1;
                   
                }
                else if (a[2, 0] == "o")
                {
                    chk = 2;
                }
            }
            else if (a[0, 0] == a[1, 0] && a[1, 0] == a[2, 0] && a[0, 0] == a[2, 0])
            {
                if (a[0, 0] == "x")
                {
                    chk = 1;                    
                }
                else if (a[0, 0] == "o")
                {
                    chk = 2;
                }
            }
            else if (a[0, 1] == a[1, 1] && a[1, 1] == a[2, 1] && a[2, 1] == a[0, 1])
            {
                if (a[0, 1] == "x")
                {
                    chk = 1;

                }
                else if (a[0, 1] == "o")
                {
                    chk = 2;
                }
            }
            else if (a[0, 2] == a[1, 2] && a[1, 2] == a[2, 2] && a[0, 2] == a[2, 2])
            {
                if (a[0, 2] == "x")
                {
                    chk = 1;

                }
                else if (a[0, 2] == "o")
                {
                    chk = 2;
                }
            }
            else if (a[0, 0] == a[1, 1] && a[1, 1] == a[2, 2] && a[2, 2] == a[0, 0])
            {
                if (a[0, 0] == "x")
                {

                    chk = 1;


                }
                else if (a[0, 0] == "o")
                {
                    chk = 2;
                }
            }
            else if (a[2, 0] == a[1, 1] && a[1, 1] == a[0, 2] && a[0, 2] == a[2, 0])
            {
                if (a[2, 0] == "x")

                {
                    chk = 1;

                }
                else if (a[2, 0] == "o")
                {
                    chk = 2;
                }
            }
            else
            {
                chk= 0;
            }
            return chk;  
        }
        public static void pattern()
        {
            
            
               
                
                    Console.WriteLine();
                    Console.WriteLine("  "+a[0, 0] + " | " + a[0, 1] + " | " + a[0, 2]);
                    Console.WriteLine("  ______");
                    Console.WriteLine("  "+a[1, 0] + " | " + a[1, 1] + " | " + a[1, 2]);
                    Console.WriteLine("  ______");
                    Console.WriteLine("  "+a[2, 0] + " | " + a[2, 1] + " | " + a[2, 2]);
                    Console.WriteLine();

                
            
        }
        

    }
        

        
}

