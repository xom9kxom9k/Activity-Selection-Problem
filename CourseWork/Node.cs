using ProtoBuf;

namespace CourseWork;
[ProtoContract]
[Serializable]
public struct Node
{
    [ProtoMember(1)] public int StartBid { get; set; } 
    [ProtoMember(2)] public int EndBid { get; set; }
    
    public override string ToString() => $"{StartBid} : {EndBid}";
    public Node(int startbid, int endbid)
    {
        StartBid = startbid;
        EndBid = endbid;
    }
}