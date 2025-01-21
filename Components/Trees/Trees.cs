using System;
using System.ComponentModel.Design.Serialization;
using System.IO.Pipes;
using System.Net;
/// <summary>
/// 1. BT - Binary Tree 
/// </summary>
public class Tree{  

    public void PreOrderTraversal(Tree_Node root , List<int> arr){
        //Base => Left => Right
        //Base condition 
        if(root == null){
            return  ;
        }

        //Add the current Root value to the Result array 
        arr.Add(root.Data);

        //Left Trversal 

        PreOrderTraversal(root.Left , arr);
        
        //Right Traversal 
        PreOrderTraversal(root.Right, arr);

    } 

    public void InOrderTraversal(Tree_Node root, IList<int> arr){
       // List<int> list =  new List<int>();
        //lEFT => Root => Right
        //Base Condition 
        if(root == null ){
            return;
        }
        //Left Call 
        InOrderTraversal(root.Left,arr);
        //Adding current root value to the array 
        arr.Add(root.Data);
        //Right Call 
        InOrderTraversal(root.Right, arr);
    }

    public void PostOrderTraversal(Tree_Node root , IList<int> arr){
        //Left => Right => Root 
        //Base Condition
        if(root == null){
            return ;
        }
        //Left Traversal
        PostOrderTraversal(root.Left, arr);
        //Right Traversa//l
        PostOrderTraversal(root.Right , arr);
        //Adding the root value to the array
        arr.Add(root.Data);
    }


    public List<List<int>> LevelOrderTraversal(Tree_Node root){
        List<List<int>> arrayList = new List<List<int>>();

            if(root == null){
                return arrayList;
            }

            Queue<Tree_Node> queue = new Queue<Tree_Node>();

            //Starting the current queue with the current root node 
            
            queue.Enqueue(root);

            while(queue.Count != 0 ){
                int size = queue.Count();
                //Create a node that store the current node 

                List<int> level = new List<int>();

                for(int i = 0 ; i < size ; i++){
                    Tree_Node node = queue.Peek();
                    queue.Dequeue();
                    level.Add(node.Data);

                    if(node.Left != null){
                        queue.Enqueue(node.Left);
                    }

                    if(node.Right != null){
                        queue.Enqueue(node.Right);
                    }

                }
                PrintData(level);
                arrayList.Add(level);
            }

            return arrayList;

    }

    public void PrintData(List<int> list){
        foreach(var i in list){
            Console.Write(i + " ");
        }
    }
    
    public List<int> PreOrderTraversal_Iterative(Tree_Node root){
        List<int> list = new List<int>();
        if(root == null){
            return list;
        }
        Stack<Tree_Node> st = new Stack<Tree_Node>();
        st.Push(root);
        while(st.Count != 0){
            root = st.Pop();
            list.Add(root.Data);
            if(root.Right != null){
                st.Push(root.Right);
            }
              if(root.Left != null){
                st.Push(root.Left);
            }
        }
        return list;
    }

    public List<int> InOrderTraversal_Iterative(Tree_Node root){
        List<int> inorder = new List<int>();

        Stack<Tree_Node> st = new Stack<Tree_Node>();
        Tree_Node node = root;
        while(true){
             if(node != null){
            st.Push(node);
            node = node.Left;
        }
        else{
            if(st.Count == 0){
                break;
            }
           node = st.Pop();
           inorder.Add(node.Data);
            node = node.Right;
        }
        }
       return inorder;
    }

    public List<int> PostOrderTraversal_Iterative_Stack_2(Tree_Node root){
        List<int> postOrder = new List<int>();  
        Stack<Tree_Node> st1 = new Stack<Tree_Node>();
        Stack<Tree_Node> st2 = new Stack<Tree_Node>();
        Tree_Node node = root;
        st1.Push(node);   
        while(st1.Count != 0){
            node = st1.Pop();
            st2.Push(node);

            if(node.Left != null ){
                st1.Push(node.Left);
            }
            if(node.Right != null){
                st2.Push(node.Right);
            }
        }
        while(st2.Count != 0){
          postOrder.Add(st2.Pop().Data);

        }
        return postOrder;
    }



    
}