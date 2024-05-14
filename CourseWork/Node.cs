namespace CourseWork;

public struct Node
{
    public int StartBid { get; set; }
    public int EndBid { get; set; }
    
    public override string ToString() => $"{StartBid} : {EndBid}";
}