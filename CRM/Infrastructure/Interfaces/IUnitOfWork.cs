namespace Infrastructure.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IFanInterface FanInterface { get; }
    IGuruhInterface GuruhInterface { get; }
    ITalabaGuruhDavomatInterface TalabaGuruhDavomatInterface { get; }
    ITalabaGuruhInterface TalabaGuruhInterface { get; }
    ITalabaInterface TalabaInterface { get; }
    ITalabaTolovInterface TalabaTolovInterface { get; }
    IXonaInterface XonaInterface { get; }

    Task SaveChangeAsync();


}
