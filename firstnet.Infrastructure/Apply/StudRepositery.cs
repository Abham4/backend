using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Domain.Model;

namespace firstnet.Infrastracture.Apply;
public class StudRepositery : BaseRepositery<Stud>, IStudRepositery
{
    public StudRepositery(Context con) : base(con)
    {
    }
}