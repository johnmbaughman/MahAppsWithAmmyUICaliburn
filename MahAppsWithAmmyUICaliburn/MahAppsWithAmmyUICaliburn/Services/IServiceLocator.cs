namespace MahAppsWithAmmyUICaliburn.Services
{
    public interface IServiceLocator
    {
        T GetInstance<T>() where T : class;
    }
}