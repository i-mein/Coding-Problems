using System;
using System.Text;
using System.Security.Cryptography; 

public class CsharpHashAlgo{    

static void MakeChange(double origAmount, double remainAmount, int[] coins)    
{ 
   if ((origAmount % 50) < origAmount) // check how many 50p coins we need - index 5        
   {            
    coins[5] = (int)(origAmount / 50);            
    remainAmount = origAmount % 50;            
    origAmount = remainAmount;        
   }
   if ((origAmount % 20) < origAmount) // check how many 20p coins we need - index 4        
   {            
     coins[4] = (int)(origAmount / 20);            
     remainAmount = origAmount % 20;            
     origAmount = remainAmount;        
    }
    if ((origAmount % 10) < origAmount) // check how many 10p coins we need - index 3        
    {            
      coins[3] = (int)(origAmount / 10);            
      remainAmount = origAmount % 10;            
      origAmount = remainAmount;        
    }
           
    if ((origAmount % 5) < origAmount) // check how many 5p coins we need - index 2        
    {            
    coins[2] = (int)(origAmount / 5);            
    remainAmount = origAmount % 5;            
    origAmount = remainAmount;        
    }
        
    if ((origAmount % 2) < origAmount) // check how many 2p coins we need - index 1        
    {            
    coins[1] = (int)(origAmount / 2);            
    remainAmount = origAmount % 2;            
    origAmount = remainAmount;        
    }        
    
    if ((origAmount % 1) < origAmount) // check how many 1p coins we need - index 0
        {            
        coins[0] = (int)(origAmount / 1);            
        remainAmount = origAmount % 1;        
        }    
  }
  
  static void ShowChange(int[] arr)    
  {  
    if (arr[5] > 0)            
    Console.WriteLine("Number of 50p coins is: " + arr[5]); 
    // bale: else Console.WriteLine("Number of 50p coins is: 0");
    
    if (arr[4] > 0)            
    Console.WriteLine("Number of 20p coins is: " + arr[4]); 
    // bale: else Console.WriteLine("Number of 20p coins is: 0");        
    
    if (arr[3] > 0)            
    Console.WriteLine("Number of 10p coins is: " + arr[3]); 
    // bale: else Console.WriteLine("Number of 10p coins is: 0");
        
     if (arr[2] > 0)            
     Console.WriteLine("Number of 5pcoins is: " + arr[2]); 
     // bale: else Console.WriteLine("Number of 5p coins is: 0");        
     
     if (arr[1] > 0)            
     Console.WriteLine("Number of 2pcoins is: " + arr[1]); 
     // bale: else Console.WriteLine("Number of 2p coins is: 0");        
     
     if (arr[0] > 0)            
     Console.WriteLine("Number of 1pcoins is: " + arr[0]); 
     // bale: else Console.WriteLine("Number of 1p coins is: 0");    
    }    
   
   static void Main()    
   {        
     Console.WriteLine("Enter the amount in cents:");        
     double origAmount = Convert.ToDouble(Console.ReadLine()); 
     
     Console.WriteLine("Enter the item cost in cents:");
     double cost_item = Convert.ToDouble(Console.ReadLine()); 
     
     double toChange = origAmount-cost_item;         
     double remainAmount = 0.0;        
     int[] coins = new int[6];        
     
     MakeChange(toChange, remainAmount, coins);         
     Console.WriteLine("The best way to change " +  toChange + " cents is: ");        
     ShowChange(coins);    
    }
}
