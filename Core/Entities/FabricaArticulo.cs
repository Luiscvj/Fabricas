using System.Runtime.InteropServices;

namespace Core.Entities;

public class FabricaArticulo
{
    public string ArticuloId { get; set; }
    public string FabricaId { get; set; }
    public long Num_ExistenciaArticulo { get; set; }
}