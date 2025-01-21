using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Reflection;
public class Hashing{ 
      //Charcter Hasing 
    /// <summary>
    /// 1. Hashing - Number hashing using array 
    /// 2. Hashing - Character hashing using array 
    /// 3. Hashing - Basic of HashTable in CSharp 
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="q"></param>
    public void HashingIntArray(int[] arr){
        //Precompile 

        int[] hasharray = new int[13];
        for(int i = 0 ; i <  hasharray.Length;i++){
            hasharray[arr[i]] +=1;
        }
       // int q = hasharray.Length;

        for(int i = 0 ; i < hasharray.Length ;i++){
             Console.WriteLine("{0} : {1}", i , hasharray[i]);
         }

    }

  
    public void CharcterHasing(char[] arr, int q){
        //Precompile 
        int[] hash = new int[26];

        for(int i = 0 ; i < arr.Length ; i++){
            hash[arr[i]-'a']++;
        }
        //Fetching 
        while(q-->0){
            char c ;
            Console.WriteLine("Please end the charctaer to find the freq");
            c = Console.ReadLine()[0];
            Console.WriteLine(hash[c-'a']);
        }
    }
    /// <summary>
    /// Hastable - Propertioes and funciton 
    /// </summary>
    public void InbuildFunctionHashTable(){
        Hashtable hashtable = new Hashtable();
        //Adding values in hashtable 

        hashtable.Add(1,"One");
        hashtable.Add(2,"Two");
        hashtable.Add(3,"Three");
        hashtable.Add(4,"Four");
        hashtable.Add(5,false);
        hashtable.Add(6,5.44);

        Display(hashtable);
        Console.WriteLine("========================================");
        //Checking values 
        //Contains , ContiansKey - To check if the key exist in a hastable 

        Console.WriteLine(hashtable.Contains(2));
        Console.WriteLine(hashtable.ContainsKey(3));
        Console.WriteLine("========================================");
        //Contians Value to check if value is there or not 
        Console.WriteLine(hashtable.ContainsValue(5.44));
        Console.WriteLine(hashtable.ContainsValue(5.44444));
        Console.WriteLine("========================================");
        //Removing element from a hastable 
        //Remove - Removing a particular value for the table using key 
        hashtable.Remove(5);
        Display(hashtable);
        Console.WriteLine("========================================");
        //Clear the entire hastable 
        hashtable.Clear();
        Console.WriteLine("========================================");

        
        hashtable.Add(1,"One");
        hashtable.Add(2,"Two");
        hashtable.Add(3,"Three");
        hashtable.Add(4,"Four");
        hashtable.Add(5,false);
        hashtable.Add(6,5.44);

        //Updating a value 

        //Step 1 - Check if the value exists in the table or not using its key 
        //Step 2 - Assign the new value to the key . 

        var updatedValue = "New Updated Value";

        if(hashtable.ContainsKey(3)){
            hashtable[3] = updatedValue;
        }
        Display(hashtable);

     }

    public void Display(Hashtable hashtable){
        foreach(DictionaryEntry ele in hashtable){
            Console.WriteLine("{0} : {1}",ele.Key, ele.Value);
        }
    }


   
    
}