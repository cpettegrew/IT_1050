import java.util.*;

public class PrimesMethod3_Nate_Boufford_Chantal_Pettegrew {



   // Task: Declare and define a new method called 
   // isPrime. Be sure to define the method such that
   // the call to this method in the main method below
   // is appropriate. 

   // isPrime method goes here!!!
   
   // This program prints out the first 100 prime numbers

   public static void main(String[] args) {
        

      int count = 0;
      int n = 1;
      
      // loop that iterates 100 times
      while (count <= 100) {

         // Use the isPrime method to check whether
         // the number n is prime or not
         if (isPrime(n)) {
            System.out.println(n + " is prime");
            count++;
         }
         
         // move on to the next n
         n++;
      }
   }
   
   public static boolean isPrime(int n){            

         // A number is prime if it is only divisible
         // by 1 and itself.
         for (int div = 2; div < n; div++) {
            if (n % div == 0) { // n is not prime
               div = n;
               return false;
          }
    } 
    return true; 
   }
}