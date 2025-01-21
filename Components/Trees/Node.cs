public class Tree_Node {
    public int Data{get;set;}

    public Tree_Node? Left {get;set;}

    public Tree_Node? Right {get;set;}

    public Tree_Node(int data){
        this.Data = data;
    }
}