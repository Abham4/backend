using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Domain.Model;

namespace firstnet.Infrastracture.Apply;

public class MemberRepositery : BaseRepositery<Member>,IMemberRepositery
{
    public MemberRepositery(Context con) : base(con)
    {
    }
}