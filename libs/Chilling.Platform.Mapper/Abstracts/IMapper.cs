namespace Chilling.Platform.Mapper.Abstracts
{
    public interface IMapper
    {
        TResult Map<TIn, TResult>(TIn model);

        IEnumerable<TResult> Map<TIn, TResult>(IEnumerable<TIn> model);
    }
}
