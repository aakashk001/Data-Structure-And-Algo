using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

public class Arrays{

//==================================================================
//                            Quick Sort
//==================================================================
   public int Partition(int[] arr, int low , int high){

    int pvt = arr[high];
    int i = low-1;

    for(int j = low ; j < high;j++){
        if(pvt >= arr[j]){
            //Increment the i 
            i = i+1;
            //swaping the values
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
    //putting the piviot value to its correct location which is i+1
    int temp1 = arr[i+1];
    arr[i+1] = arr[high];
    arr[high] = temp1;
    return i+1; 
   }

   public void QuickSort(int[] arr,int low , int high){
    if(low<high){
      int q =   Partition(arr , low, high);
        QuickSort(arr, low, q-1);
        QuickSort(arr, q+1,high);
    }
   }

   //=========================================================
   //Merge Sort Algo
   //=========================================================

   public void Merge( int[] arr, int left , int mid , int right){
    
    int leftleng = mid-left+1;
    int rightleng = right-mid;

    //Left and Right Arrays should have a size  leftleng+1; 

    int[] LeftArray = new int[leftleng+1];
    int[] RightArray = new int[rightleng+1];

    int i,j ;
    for(i = 0 ; i<leftleng ;i++){
       // Console.Write(arr[i+left]+ " ");
        LeftArray[i] = arr[i+left];
    } 
    LeftArray[leftleng] = int.MaxValue;

    for(j = 0 ; j < rightleng ; j++){
        //Console.Write(arr[j+mid+1]+ " ");
        RightArray[j] = arr[j+mid+1];
    }
    RightArray[rightleng] = int.MaxValue;
    i = j = 0;

    //Mergin the values into the main array
    for(int k = left ; k <= right ; k++){
        if(LeftArray[i] <= RightArray[j]){
            arr[k] = LeftArray[i];
            i++;
          //  Console.Write(arr[k]+ " ");
        }
        else{
           arr[k] =  RightArray[j]; 
           j++;
         //   Console.Write(arr[k]+ " ");
        }
    }

   }
   

   public void Merge_Sort(int[]arr , int left , int right){
    if(left<right){
        int mid = (left+right)/2;
        Merge_Sort(arr, left,mid);
        Merge_Sort(arr,mid+1,right);
        Merge(arr, left,mid,right);
        }
   }

   





}