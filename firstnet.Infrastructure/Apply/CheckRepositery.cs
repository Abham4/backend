using firstnet.Data;
using firstnet.Infrastracture.Interface;
using firstnet.Domain.Model;

namespace firstnet.Infrastracture.Apply;

public class CheckRepositery : BaseRepositery<Check>, IChecRepositery
{
    public CheckRepositery(Context con) : base(con)
    {
    }
}