using System.Collections.Generic;

namespace RentalBooksApi.Data.Covert.Contract
{
    public interface IParser<TO, TD>
    {
        TD Parse(TO origin);
        List<TD> Parse(List<TO> origin);
    }
}