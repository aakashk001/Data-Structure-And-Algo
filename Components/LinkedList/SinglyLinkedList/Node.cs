public class Node{

    public int Data {get;set;}

    public Node? Next {get;set;}

    public Node(int data, Node next){
        this.Data = data;
        this.Next = next;
    }

    public Node(int data){
        this.Data = data;
    }

}