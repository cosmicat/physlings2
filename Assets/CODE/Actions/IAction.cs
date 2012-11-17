public interface IAction
{
    void Apply(ITarget primary, ITarget secondary, IAction next);
}