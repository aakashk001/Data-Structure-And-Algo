using System.Buffers;
using System.ComponentModel;
using System.Data;
using System.Dynamic;
using System.Net.Sockets;
using System.Runtime;
using System.Runtime.InteropServices.Marshalling;

public class Binary{
/// <summary>
/// Binary Serach - Iterative Method
/// </summary>
public int BinarySerach(int[] arr , int x){
    int low = 0 ; 
    int high = arr.Length-1;
    while(low<=high){
    int mid = (low+high)/2;
    //Case1 element is at the middle of the array
    if(arr[mid]==x){
       return mid; 
    }
    //Case 2 element is at the leftside of array
    else if(arr[mid] >x){
        high = mid-1;
    }
    //Case 3 element is at the rightside of array.
    else{
        low = mid+1;
    }
    }
    //In case array is not there. 
    return -1;
    

}
/// <summary>
/// Binary Serach - Recursive Method 
/// </summary>

public int Binary_Recursive_Method(int[] arr, int low , int high , int target){
    //Base Case 
    if(low>=high){
        return -1;
    }
    
    //Recursive Condtions 

    int mid = (low+high)/2;
    //Target is at middle of the array
    if(arr[mid]==target){
        return mid;
    }
    //Target is at the left side of the array
    else if(arr[mid]>target){
        return Binary_Recursive_Method(arr,low,mid-1,target);
    }
    //Target is at the right side of the array
    return Binary_Recursive_Method(arr,mid+1,high,target);
}

/// <summary>
/// Lower Bound = lower bound index is a smallest index in a sorted array where the values of arr[index] >= target
/// </summary>

public int lowerBound(int[] arr , int target){
  int low = 0 ; 
  int high = arr.Length-1;
    int ans = -1;
  while(low <= high){
    int mid = (low+high)/2;
    if(arr[mid] >= target){
        ans = mid;
        high = mid-1;
    }else{
        low = mid+1;
    }
  }
  return ans;
}

///<summary>
/// Upper Bound => The smallest index in an sorted array where arr[index]>target
///</summary>
    public int UpperBound(int[] arr ,int target){
        int low = 0 ; 
        int high = arr.Length-1;
        int ans = -1;
        while(low<= high){
            int mid = (low+high)/2;
            if(arr[mid] > target){
                ans = mid;
                high = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        return ans;
    }

    ///<summary>
    ///Floor - The largest element in a sorted list which is smaller than or equal to target value 
    ///</summary>
    ///
    public int FoorValue(int[] arr, int target){
        int low = 0 ; 
        int high = arr.Length-1;
        int ans = -1;
        while(low<=high){
            int mid = (low+high)/2;

            if(arr[mid] <= target){
            ans = arr[mid];
            low = mid+1;
            }
            else{
                high = mid-1;
            }
        }
        return ans;
    }

    ///<summary>
    ///Ceil - the smallest value in a sorted array which is greater than or equal to target;
    /// Ceil - lower bound
    
    public int CeilValue(int[] arr, int target){
        int low = 0 ; 
        int high = arr.Length-1;
         int ans = -1;
        while(low<= high){
            int mid = (low+high)/2; 
           
            if(arr[mid] >= target){
                ans = arr[mid];
                high = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        return ans;
    }
    ///<summary>
    ///Last Occurance of an element in an array 
    ///
    public int LastOccurance(int[] arr, int target){
        int low = 0 ; 
        int high = arr.Length-1;
        int ans = -1;
        while(low <= high){
            int mid = (low+high)/2;
            if(arr[mid] == target){
                ans = mid;
                low = mid+1;
            }
            else if(arr[mid]> target){
                high = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        return ans;
    }
    ///<summary>
    ///First Occurance of an element in a sorted array
    ///

    public int FirstOccurance(int[] arr, int target){
        int low = 0 ; int high = arr.Length-1;int ans =-1;

        while(low <= high){
            int mid = (low+high)/2;
           
            if(arr[mid] == target){
                ans = mid;
                high = mid-1;
            }
            else if(arr[mid] < target ){
                low = mid+1;
            }
            else{
                high = mid-1;
            }
        }
        return ans;
    }
   /// <summary>
   /// Search in a Rotated Sorted Array 
   ///1.Find the side which is sorted half- Left/Right
   ///2.Check if the target lies in the sorted half.
   /// </summary>
    public int RotatedArray(int[] array , int target){
        int low = 0 ;
        int high = array.Length-1;

        while(low <= high){
                int mid = (low+high)/2;
                //Checking if the array at mid is eqaul to target value
                if(array[mid]== target){
                    return mid;
                }
                //Finding the side which is sorted 
                //Check for the left side 

            if(array[low] <=  array[mid]){
                if(array[low] <= target && array[mid]>= target){
                    high = mid-1;
                }
                else{
                    low = mid+1;
                }
            }
            //Right side is sorted
            else{
                if(target >= array[mid] && target <= array[high]){
                    low = mid+1;
                }
                else{
                    high = mid-1;
                }
            }
        }

        return -1;
    }
    /// <summary>
    /// Rotated array with duplicate values . 
    /// In this we will trim down our search space untill we are left with unique value at both low and high end. 
    ///</summary>
    

    public int RotatedArray_2(int[] arr, int target){
        int low = 0 ; 
        int high = arr.Length-1;
        
        while(low <= high){
            int mid = (low+high)/2;
            //Base condition
            if(arr[mid]==target){
                return mid;
            }
            //If we have duplicate a both ends then we will trimm down our serach space.
            if(arr[low] == arr[mid] && arr[mid]== arr[high]){
                low = low +1;
                high = high-1;
                continue;
            }
            //Left side is sorted
            if(arr[low] <= arr[mid]){
                if(arr[low] <= target && arr[mid] >= target){
                    high = mid-1;
                }
                else{
                    low = mid+1;
                }
            }
            //Right side is sorted
            else{
                if(arr[mid]<= target && arr[high] >= target){
                    low = mid+1;
                }
                else{
                    high = mid-1;
                }
            }
        }

        return -1;
    }
    ///<summary>
    /// Find the minimum in a rotated array 
    /// Approch - Find the sorted half -> Take the lowest value of the sorted half => Eliminate the sorted half. 
    /// </summary>
    
    public int MinimumRotatedArray_Value(int[] arr){

        int low = 0 ; 
        int high = arr.Length-1;
        int ans = int.MaxValue;
        while(low <= high){
            int mid = (low+high)/2;
        
            if(arr[low] <= arr[mid]){
                ans = Math.Min(ans,arr[low]); // taking the lowest values of sorted half
                low = mid+1;
            }
            else{
                ans = Math.Min(ans,arr[mid]);
               high = mid-1;
            }
        }

        return ans;
    }
}